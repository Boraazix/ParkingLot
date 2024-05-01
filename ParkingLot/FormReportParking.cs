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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace ParkingLot
{
    public partial class FormReportParking : Form
    {
        public static FormReportParking _instance;
        public FormReportParking()
        {
            InitializeComponent();

            DateTime now = DateTime.Now;
            DtpEntryStart.Value = new DateTime(now.Year, now.Month, now.Day, 0, 0, 0);
            DtpEntryFinish.Value = new DateTime(now.Year, now.Month, now.Day, 23, 59, 59);
            List<User> users = UserRepository.FindAll();
            CmbResponsible.Items.Add(new User() { FirstName = "Any", LastName = "User" });
            foreach (User user in users)
            {
                CmbResponsible.Items.Add(user);
            }
            CmbResponsible.SelectedIndex = 0;
        }
        public static FormReportParking GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new FormReportParking();
            }
            _instance.MdiParent = FormMain.ActiveForm;
            _instance.WindowState = FormWindowState.Normal;
            return _instance;
        }

        private void ChkAllDates_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkAllDates.Checked)
            {
                DtpEntryStart.Enabled = false;
                DtpEntryFinish.Enabled = false;
            }
            else
            {
                DtpEntryStart.Enabled = true;
                DtpEntryFinish.Enabled = true;
            }
        }

        private void CmbResponsible_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index == -1) { return; }

            string itemText = (CmbResponsible.Items[e.Index] as User).FullName;

            Color textColor = e.ForeColor;
            if (e.Index == 0) { textColor = Color.Gray; }

            e.DrawBackground();
            using (SolidBrush brush = new SolidBrush(textColor))
            {
                e.Graphics.DrawString(itemText, e.Font, brush, e.Bounds);
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            FormReportParkingOutput.GetInstance(
                ParkingRepository.FindWithFiltering(
                    TxtLicensePlate.Text, 
                    RbtnSmallCar.Checked ? 0 : (RbtnLargeCar.Checked ? 1 : 2), 
                    CmbResponsible.SelectedIndex < 0 ? CmbResponsible.Items[0] as User : CmbResponsible.SelectedItem as User, 
                    ChkAllDates.Checked, 
                    DtpEntryStart.Value, 
                    DtpEntryFinish.Value)
                ).Show();
        }
    }
}
