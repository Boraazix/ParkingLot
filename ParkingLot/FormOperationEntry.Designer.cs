namespace ParkingLot
{
    partial class FormOperationEntry
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
            PnlMain = new Panel();
            BtnDeleteParking = new Button();
            BtnReleaseCar = new Button();
            BtnShowData = new Button();
            LstParking = new ListBox();
            GrpNewParking = new GroupBox();
            BtnSave = new Button();
            ChkLarge = new CheckBox();
            DtpEntry = new DateTimePicker();
            LblEntryTime = new Label();
            TxtLicensePlate = new TextBox();
            LblLicensePlate = new Label();
            BtnUpdateTime = new Button();
            PnlMain.SuspendLayout();
            GrpNewParking.SuspendLayout();
            SuspendLayout();
            // 
            // PnlMain
            // 
            PnlMain.Controls.Add(BtnUpdateTime);
            PnlMain.Controls.Add(BtnDeleteParking);
            PnlMain.Controls.Add(BtnReleaseCar);
            PnlMain.Controls.Add(BtnShowData);
            PnlMain.Controls.Add(LstParking);
            PnlMain.Controls.Add(GrpNewParking);
            PnlMain.Location = new Point(0, 0);
            PnlMain.Name = "PnlMain";
            PnlMain.Size = new Size(440, 351);
            PnlMain.TabIndex = 0;
            // 
            // BtnDeleteParking
            // 
            BtnDeleteParking.Location = new Point(325, 308);
            BtnDeleteParking.Name = "BtnDeleteParking";
            BtnDeleteParking.Size = new Size(98, 28);
            BtnDeleteParking.TabIndex = 5;
            BtnDeleteParking.Text = "Delete Parking";
            BtnDeleteParking.UseVisualStyleBackColor = true;
            BtnDeleteParking.Click += BtnDeleteParking_Click;
            // 
            // BtnReleaseCar
            // 
            BtnReleaseCar.Location = new Point(221, 308);
            BtnReleaseCar.Name = "BtnReleaseCar";
            BtnReleaseCar.Size = new Size(98, 28);
            BtnReleaseCar.TabIndex = 4;
            BtnReleaseCar.Text = "Release car";
            BtnReleaseCar.UseVisualStyleBackColor = true;
            BtnReleaseCar.Click += BtnReleaseCar_Click;
            // 
            // BtnShowData
            // 
            BtnShowData.Location = new Point(117, 308);
            BtnShowData.Name = "BtnShowData";
            BtnShowData.Size = new Size(98, 28);
            BtnShowData.TabIndex = 3;
            BtnShowData.Text = "Show data";
            BtnShowData.UseVisualStyleBackColor = true;
            BtnShowData.Click += BtnShowData_Click;
            // 
            // LstParking
            // 
            LstParking.FormattingEnabled = true;
            LstParking.ItemHeight = 15;
            LstParking.Location = new Point(12, 103);
            LstParking.Name = "LstParking";
            LstParking.Size = new Size(413, 199);
            LstParking.TabIndex = 1;
            // 
            // GrpNewParking
            // 
            GrpNewParking.Controls.Add(BtnSave);
            GrpNewParking.Controls.Add(ChkLarge);
            GrpNewParking.Controls.Add(DtpEntry);
            GrpNewParking.Controls.Add(LblEntryTime);
            GrpNewParking.Controls.Add(TxtLicensePlate);
            GrpNewParking.Controls.Add(LblLicensePlate);
            GrpNewParking.Location = new Point(12, 12);
            GrpNewParking.Name = "GrpNewParking";
            GrpNewParking.Size = new Size(413, 85);
            GrpNewParking.TabIndex = 0;
            GrpNewParking.TabStop = false;
            GrpNewParking.Text = "New Parking";
            // 
            // BtnSave
            // 
            BtnSave.Location = new Point(320, 44);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(75, 24);
            BtnSave.TabIndex = 3;
            BtnSave.Text = "Save";
            BtnSave.UseVisualStyleBackColor = true;
            BtnSave.Click += BtnSave_Click;
            // 
            // ChkLarge
            // 
            ChkLarge.AutoSize = true;
            ChkLarge.Checked = true;
            ChkLarge.CheckState = CheckState.Checked;
            ChkLarge.Location = new Point(239, 48);
            ChkLarge.Name = "ChkLarge";
            ChkLarge.Size = new Size(74, 19);
            ChkLarge.TabIndex = 2;
            ChkLarge.Text = "Large car";
            ChkLarge.UseVisualStyleBackColor = true;
            // 
            // DtpEntry
            // 
            DtpEntry.Format = DateTimePickerFormat.Time;
            DtpEntry.Location = new Point(126, 45);
            DtpEntry.MinDate = new DateTime(1753, 1, 2, 0, 0, 0, 0);
            DtpEntry.Name = "DtpEntry";
            DtpEntry.Size = new Size(101, 23);
            DtpEntry.TabIndex = 1;
            // 
            // LblEntryTime
            // 
            LblEntryTime.AutoSize = true;
            LblEntryTime.Location = new Point(126, 27);
            LblEntryTime.Name = "LblEntryTime";
            LblEntryTime.Size = new Size(61, 15);
            LblEntryTime.TabIndex = 2;
            LblEntryTime.Text = "Entry time";
            // 
            // TxtLicensePlate
            // 
            TxtLicensePlate.CharacterCasing = CharacterCasing.Upper;
            TxtLicensePlate.Location = new Point(15, 46);
            TxtLicensePlate.MaxLength = 7;
            TxtLicensePlate.Name = "TxtLicensePlate";
            TxtLicensePlate.Size = new Size(100, 23);
            TxtLicensePlate.TabIndex = 0;
            // 
            // LblLicensePlate
            // 
            LblLicensePlate.AutoSize = true;
            LblLicensePlate.Location = new Point(15, 28);
            LblLicensePlate.Name = "LblLicensePlate";
            LblLicensePlate.Size = new Size(75, 15);
            LblLicensePlate.TabIndex = 0;
            LblLicensePlate.Text = "License plate";
            // 
            // BtnUpdateTime
            // 
            BtnUpdateTime.Location = new Point(13, 308);
            BtnUpdateTime.Name = "BtnUpdateTime";
            BtnUpdateTime.Size = new Size(98, 28);
            BtnUpdateTime.TabIndex = 2;
            BtnUpdateTime.Text = "Update Time";
            BtnUpdateTime.UseVisualStyleBackColor = true;
            BtnUpdateTime.Click += BtnUpdateTime_Click;
            // 
            // FormOperationEntry
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(440, 351);
            Controls.Add(PnlMain);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormOperationEntry";
            Text = "Car entrance";
            PnlMain.ResumeLayout(false);
            GrpNewParking.ResumeLayout(false);
            GrpNewParking.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel PnlMain;
        private GroupBox GrpNewParking;
        private Label LblLicensePlate;
        private TextBox TxtLicensePlate;
        private Label LblEntryTime;
        private DateTimePicker DtpEntry;
        private CheckBox ChkLarge;
        private Button BtnSave;
        private ListBox LstParking;
        private Button BtnShowData;
        private Button BtnReleaseCar;
        private Button BtnDeleteParking;
        private Button BtnUpdateTime;
    }
}