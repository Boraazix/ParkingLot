namespace ParkingLot
{
    partial class FormReportParkingOutput
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReportParkingOutput));
            PnlMain = new Panel();
            DgvMain = new DataGridView();
            PnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvMain).BeginInit();
            SuspendLayout();
            // 
            // PnlMain
            // 
            PnlMain.Controls.Add(DgvMain);
            PnlMain.Location = new Point(0, 0);
            PnlMain.Name = "PnlMain";
            PnlMain.Size = new Size(800, 450);
            PnlMain.TabIndex = 0;
            // 
            // DgvMain
            // 
            DgvMain.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvMain.Location = new Point(12, 12);
            DgvMain.Name = "DgvMain";
            DgvMain.ReadOnly = true;
            DgvMain.Size = new Size(776, 426);
            DgvMain.TabIndex = 0;
            DgvMain.CellFormatting += DgvMain_CellFormatting;
            // 
            // FormReportParkingOutput
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(PnlMain);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FormReportParkingOutput";
            Text = "Parking Report output";
            PnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DgvMain).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel PnlMain;
        private DataGridView DgvMain;
    }
}