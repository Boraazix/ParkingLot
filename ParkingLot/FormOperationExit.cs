using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkingLot
{
    public partial class FormOperationExit : Form
    {
        private static FormOperationExit _instance;
        private static Parking _parkingCalculated;
        private static DateTime _possibleExit;
        private static int _index;
        public FormOperationExit()
        {
            InitializeComponent();

            LstParking.DataSource = ParkingRepository.FindAllOpenWResponsible();
            if (_index > -1 && _index < LstParking.Items.Count)
            {
                LstParking.SelectedIndex = _index;
            }
            LblClock.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }
        public static FormOperationExit GetInstance(int index)
        {
            _index = index;
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new FormOperationExit();
            }
            _instance.MdiParent = FormMain.ActiveForm;
            _instance.WindowState = FormWindowState.Normal;
            return _instance;
        }

        private void BtnCalculateFee_Click(object sender, EventArgs e)
        {
            if (LstParking.SelectedIndex >= 0)
            {
                _parkingCalculated = (Parking)LstParking.SelectedItem;
                _possibleExit = DateTime.Now;

                Decimal l_hour = Properties.Settings.Default.LSixtyOrLess, l_add = Properties.Settings.Default.LAdditionalHour;
                Decimal s_hour = Properties.Settings.Default.SSixtyOrLess, s_add = Properties.Settings.Default.SAdditionalHour;
                TimeSpan ts = _parkingCalculated.CalculatePastTime(_possibleExit);
                Decimal total = (_parkingCalculated.Large ? l_hour + (Convert.ToDecimal(Math.Floor(ts.TotalHours)) - (ts.Minutes == 0 ? 1 : 0)) * l_add : s_hour + (Convert.ToDecimal(Math.Floor(ts.TotalHours)) - (ts.Minutes == 0 ? 1 : 0)) * s_add);

                if (ts.TotalMinutes < 16)
                {
                    TxtResult.Text = $"{_parkingCalculated.LicensePlate} remained for {Math.Floor(ts.TotalMinutes)} minutes.\r\nUp to 15 minutes, {(_parkingCalculated.Large ? "large" : "small")} car. Amount to pay: ${(_parkingCalculated.Large ? Properties.Settings.Default.LFifteenOrLess : Properties.Settings.Default.SFifteenOrLess)}";
                    TxtTotal.Text = "$"+(_parkingCalculated.Large ? Properties.Settings.Default.LFifteenOrLess : Properties.Settings.Default.SFifteenOrLess).ToString();
                }
                else if (ts.TotalMinutes < 31)
                {
                    TxtResult.Text = $"{_parkingCalculated.LicensePlate} remained for {Math.Floor(ts.TotalMinutes)} minutes.\r\nUp to 30 minutes, {(_parkingCalculated.Large ? "large" : "small")} car. Amount to pay: ${(_parkingCalculated.Large ? Properties.Settings.Default.LThirtyOrLess : Properties.Settings.Default.SThirtyOrLess)}";
                    TxtTotal.Text = "$" + (_parkingCalculated.Large ? Properties.Settings.Default.LThirtyOrLess : Properties.Settings.Default.SThirtyOrLess).ToString();
                }
                else if (ts.TotalMinutes < 61)
                {
                    TxtResult.Text = $"{_parkingCalculated.LicensePlate} remained for {Math.Floor(ts.TotalMinutes)} minutes.\r\nUp to 1 hour, {(_parkingCalculated.Large ? "large" : "small")} car. Amount to pay: ${(_parkingCalculated.Large ? Properties.Settings.Default.LSixtyOrLess : Properties.Settings.Default.SSixtyOrLess)}";
                    TxtTotal.Text = "$" + (_parkingCalculated.Large ? Properties.Settings.Default.LSixtyOrLess : Properties.Settings.Default.SSixtyOrLess).ToString();
                }
                else
                {
                    String amount = $"(One hour = ${(_parkingCalculated.Large ? l_hour : s_hour)}) + (Additional hour = {Math.Floor(ts.TotalHours) - (ts.Minutes == 0 ? 1 : 0)} x ${(_parkingCalculated.Large ? l_add : s_add).ToString("N2")}) = ${total.ToString("N2")}";
                    TxtResult.Text = $"{_parkingCalculated.LicensePlate} remained for {Math.Floor(ts.TotalHours)} hour(s) and {ts.Minutes} minute(s). More than 1 hour, {(_parkingCalculated.Large ? "large" : "small")} car.\r\nAmount to pay: {amount}";
                    TxtTotal.Text = '$' + total.ToString("N2");
                }

                TxtLicensePlate.Text = _parkingCalculated.LicensePlate;
                TxtEntry.Text = _parkingCalculated.Entry.ToString("MM/dd/yyyy hh:mm:ss tt");
                TxtExit.Text = _possibleExit.ToString("MM/dd/yyyy hh:mm:ss tt");
                TxtInterval.Text = $"{Math.Floor(ts.TotalHours)} hour(s) and {ts.Minutes} minute(s)";
                BtnExitCar.Enabled = true;
            }
        }

        private void TmrClock_Tick(object sender, EventArgs e)
        {
            LblClock.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void BtnExitCar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Do you want to exit car \"{_parkingCalculated.LicensePlate}\"?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                _parkingCalculated.Exit = _possibleExit;
                _parkingCalculated.Paid = true;
                ParkingRepository.Save(_parkingCalculated);
                LstParking.DataSource = ParkingRepository.FindAllOpenWResponsible();
            }
        }
    }
}
