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
    public partial class FormOperationEntry : Form
    {
        private static FormOperationEntry _instance;
        public FormOperationEntry()
        {
            InitializeComponent();

            DtpEntry.Value = DateTime.Now;
            LstParking.DataSource = ParkingRepository.FindAllOpenWResponsible();
        }
        public static FormOperationEntry GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new FormOperationEntry();
            }
            _instance.MdiParent = FormMain.ActiveForm;
            _instance.WindowState = FormWindowState.Normal;
            return _instance;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtLicensePlate.Text == "")
                {
                    MessageBox.Show("License plate not entered!", "Something is wrong :/", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    TxtLicensePlate.Focus();
                }
                else
                {
                    ParkingRepository.Save(new Parking(TxtLicensePlate.Text, ChkLarge.Checked, DtpEntry.Value, FormMain.UserLogged));
                    LstParking.DataSource = ParkingRepository.FindAllOpenWResponsible();
                    MessageBox.Show($"Parking successfully registered.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TxtLicensePlate.Text = ""; DtpEntry.Value = DateTime.Now; ChkLarge.Checked = true; TxtLicensePlate.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Something is wrong :/", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void BtnShowData_Click(object sender, EventArgs e)
        {
            if (LstParking.SelectedIndex >= 0)
            {
                Parking parking = (Parking)LstParking.SelectedItem;
                MessageBox.Show($"Parking ID: {parking.ParkingId}\nLicense plate: {parking.LicensePlate}\nEntry: {parking.Entry}\nLarge: {(parking.Large ? "Yes" : "No")}\nResponsible: {parking.Responsible.FirstName} {parking.Responsible.LastName}", $"{parking.LicensePlate} parking data", MessageBoxButtons.OK);
            }
        }

        private void BtnDeleteParking_Click(object sender, EventArgs e)
        {
            try
            {
                if (LstParking.SelectedIndex >= 0)
                {
                    Parking parking = (Parking)LstParking.SelectedItem;
                    if (MessageBox.Show($"Do you want to delete the Parking \"{parking.LicensePlate}, Entry: {parking.Entry}\"?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        ParkingRepository.Remove(parking);
                        LstParking.DataSource = ParkingRepository.FindAllWResponsible();
                        MessageBox.Show($"Parking \"{parking.LicensePlate}, Entry: {parking.Entry}\" successfully deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Something is wrong :/", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void BtnReleaseCar_Click(object sender, EventArgs e)
        {
            if (LstParking.SelectedIndex >= 0)
            {
                FormOperationExit.GetInstance(LstParking.SelectedIndex).Show();
            }
        }

        private void BtnUpdateTime_Click(object sender, EventArgs e)
        {
            DtpEntry.Value = DateTime.Now;
        }
    }
}
