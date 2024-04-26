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
    public partial class FormFileFees : Form
    {
        private static FormFileFees _instance;
        public FormFileFees()
        {
            InitializeComponent();

            NudSFifteenOrLess.Value = Properties.Settings.Default.SFifteenOrLess;
            NudSThirtyOrLess.Value = Properties.Settings.Default.SThirtyOrLess;
            NudSSixtyOrLess.Value = Properties.Settings.Default.SSixtyOrLess;
            NudSAdditionalHour.Value = Properties.Settings.Default.SAdditionalHour;

            NudLFifteenOrLess.Value = Properties.Settings.Default.LFifteenOrLess;
            NudLThirtyOrLess.Value = Properties.Settings.Default.LThirtyOrLess;
            NudLSixtyOrLess.Value = Properties.Settings.Default.LSixtyOrLess;
            NudLAdditionalHour.Value = Properties.Settings.Default.LAdditionalHour;
        }
        public static FormFileFees GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new FormFileFees();
            }
            _instance.MdiParent = FormMain.ActiveForm;
            _instance.WindowState = FormWindowState.Normal;
            return _instance;
        }

        private void BtnSaveFees_Click(object sender, EventArgs e)
        {
            try
            {
                Properties.Settings.Default.SFifteenOrLess = NudSFifteenOrLess.Value;
                Properties.Settings.Default.SThirtyOrLess = NudSThirtyOrLess.Value;
                Properties.Settings.Default.SSixtyOrLess = NudSSixtyOrLess.Value;
                Properties.Settings.Default.SAdditionalHour = NudSAdditionalHour.Value;

                Properties.Settings.Default.LFifteenOrLess = NudLFifteenOrLess.Value;
                Properties.Settings.Default.LThirtyOrLess = NudLThirtyOrLess.Value;
                Properties.Settings.Default.LSixtyOrLess = NudLSixtyOrLess.Value;
                Properties.Settings.Default.LAdditionalHour = NudLAdditionalHour.Value;

                Properties.Settings.Default.Save();
                MessageBox.Show("Fees updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Something is wrong :/", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
