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
    public partial class FormReportParkingOutput : Form
    {
        private static FormReportParkingOutput _instance;
        private static List<Parking> _output;
        public FormReportParkingOutput()
        {
            InitializeComponent();

            DgvMain.DataSource = _output;
            DgvMain.Columns[0].HeaderText = "ID";
            DgvMain.Columns[0].Width = 40;
            DgvMain.Columns[2].Visible = false;
            DgvMain.Columns[3].Width = 60;
            DgvMain.Columns[4].Width = 120;
            DgvMain.Columns[5].Width = 120;
            DgvMain.Columns[6].Visible = false;
            DgvMain.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        public static FormReportParkingOutput GetInstance(List<Parking> output)
        {
            _output = output;
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new FormReportParkingOutput();
            }
            _instance.MdiParent = FormMain.ActiveForm;
            _instance.WindowState = FormWindowState.Normal;
            return _instance;
        }

        private void DgvMain_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == DgvMain.Columns["Exit"].Index && e.Value != null)
            {
                if ((DateTime)e.Value == new DateTime(1753, 1, 1))
                {
                    e.Value = "Not yet";

                    e.FormattingApplied = true;
                }
            }
            if (e.ColumnIndex == DgvMain.Columns["Responsible"].Index && e.Value != null)
            {
                e.Value = (e.Value as User).FullName;

                e.FormattingApplied = true;
            }
        }
    }
}
