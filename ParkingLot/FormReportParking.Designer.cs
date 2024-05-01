namespace ParkingLot
{
    partial class FormReportParking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReportParking));
            PnlMain = new Panel();
            GrpFilter = new GroupBox();
            BtnSearch = new Button();
            LblResponsible = new Label();
            CmbResponsible = new ComboBox();
            GrpEntryTime = new GroupBox();
            DtpEntryStart = new DateTimePicker();
            ChkAllDates = new CheckBox();
            LblUntil = new Label();
            DtpEntryFinish = new DateTimePicker();
            RbtnBoth = new RadioButton();
            RbtnLargeCar = new RadioButton();
            RbtnSmallCar = new RadioButton();
            TxtLicensePlate = new TextBox();
            LblLicensePlate = new Label();
            PnlMain.SuspendLayout();
            GrpFilter.SuspendLayout();
            GrpEntryTime.SuspendLayout();
            SuspendLayout();
            // 
            // PnlMain
            // 
            PnlMain.Controls.Add(GrpFilter);
            PnlMain.Location = new Point(0, 0);
            PnlMain.Name = "PnlMain";
            PnlMain.Size = new Size(450, 243);
            PnlMain.TabIndex = 0;
            // 
            // GrpFilter
            // 
            GrpFilter.Controls.Add(BtnSearch);
            GrpFilter.Controls.Add(LblResponsible);
            GrpFilter.Controls.Add(CmbResponsible);
            GrpFilter.Controls.Add(GrpEntryTime);
            GrpFilter.Controls.Add(RbtnBoth);
            GrpFilter.Controls.Add(RbtnLargeCar);
            GrpFilter.Controls.Add(RbtnSmallCar);
            GrpFilter.Controls.Add(TxtLicensePlate);
            GrpFilter.Controls.Add(LblLicensePlate);
            GrpFilter.Location = new Point(12, 12);
            GrpFilter.Name = "GrpFilter";
            GrpFilter.Size = new Size(425, 214);
            GrpFilter.TabIndex = 0;
            GrpFilter.TabStop = false;
            GrpFilter.Text = "Filter";
            // 
            // BtnSearch
            // 
            BtnSearch.Location = new Point(332, 173);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(75, 24);
            BtnSearch.TabIndex = 7;
            BtnSearch.Text = "Search";
            BtnSearch.UseVisualStyleBackColor = true;
            BtnSearch.Click += BtnSearch_Click;
            // 
            // LblResponsible
            // 
            LblResponsible.AutoSize = true;
            LblResponsible.Location = new Point(15, 157);
            LblResponsible.Name = "LblResponsible";
            LblResponsible.Size = new Size(70, 15);
            LblResponsible.TabIndex = 12;
            LblResponsible.Text = "Responsible";
            // 
            // CmbResponsible
            // 
            CmbResponsible.DisplayMember = "FullName";
            CmbResponsible.DrawMode = DrawMode.OwnerDrawFixed;
            CmbResponsible.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbResponsible.FlatStyle = FlatStyle.System;
            CmbResponsible.FormattingEnabled = true;
            CmbResponsible.Location = new Point(15, 175);
            CmbResponsible.Name = "CmbResponsible";
            CmbResponsible.Size = new Size(156, 24);
            CmbResponsible.TabIndex = 5;
            CmbResponsible.DrawItem += CmbResponsible_DrawItem;
            // 
            // GrpEntryTime
            // 
            GrpEntryTime.Controls.Add(DtpEntryStart);
            GrpEntryTime.Controls.Add(ChkAllDates);
            GrpEntryTime.Controls.Add(LblUntil);
            GrpEntryTime.Controls.Add(DtpEntryFinish);
            GrpEntryTime.Location = new Point(130, 28);
            GrpEntryTime.Name = "GrpEntryTime";
            GrpEntryTime.Size = new Size(277, 128);
            GrpEntryTime.TabIndex = 6;
            GrpEntryTime.TabStop = false;
            GrpEntryTime.Text = "Entry time";
            // 
            // DtpEntryStart
            // 
            DtpEntryStart.CustomFormat = "MM/dd/yyyy hh:mm:ss tt";
            DtpEntryStart.Enabled = false;
            DtpEntryStart.Format = DateTimePickerFormat.Custom;
            DtpEntryStart.Location = new Point(15, 31);
            DtpEntryStart.MinDate = new DateTime(1753, 1, 2, 0, 0, 0, 0);
            DtpEntryStart.Name = "DtpEntryStart";
            DtpEntryStart.Size = new Size(163, 23);
            DtpEntryStart.TabIndex = 0;
            // 
            // ChkAllDates
            // 
            ChkAllDates.AutoSize = true;
            ChkAllDates.Checked = true;
            ChkAllDates.CheckState = CheckState.Checked;
            ChkAllDates.Location = new Point(195, 62);
            ChkAllDates.Name = "ChkAllDates";
            ChkAllDates.Size = new Size(71, 19);
            ChkAllDates.TabIndex = 2;
            ChkAllDates.Text = "All dates";
            ChkAllDates.UseVisualStyleBackColor = true;
            ChkAllDates.CheckedChanged += ChkAllDates_CheckedChanged;
            // 
            // LblUntil
            // 
            LblUntil.AutoSize = true;
            LblUntil.Location = new Point(77, 62);
            LblUntil.Name = "LblUntil";
            LblUntil.Size = new Size(31, 15);
            LblUntil.TabIndex = 7;
            LblUntil.Text = "until";
            // 
            // DtpEntryFinish
            // 
            DtpEntryFinish.CustomFormat = "MM/dd/yyyy hh:mm:ss tt";
            DtpEntryFinish.Enabled = false;
            DtpEntryFinish.Format = DateTimePickerFormat.Custom;
            DtpEntryFinish.Location = new Point(15, 85);
            DtpEntryFinish.MinDate = new DateTime(1753, 1, 2, 0, 0, 0, 0);
            DtpEntryFinish.Name = "DtpEntryFinish";
            DtpEntryFinish.Size = new Size(163, 23);
            DtpEntryFinish.TabIndex = 1;
            // 
            // RbtnBoth
            // 
            RbtnBoth.AutoSize = true;
            RbtnBoth.Checked = true;
            RbtnBoth.Location = new Point(15, 130);
            RbtnBoth.Name = "RbtnBoth";
            RbtnBoth.Size = new Size(50, 19);
            RbtnBoth.TabIndex = 4;
            RbtnBoth.TabStop = true;
            RbtnBoth.Text = "Both";
            RbtnBoth.UseVisualStyleBackColor = true;
            // 
            // RbtnLargeCar
            // 
            RbtnLargeCar.AutoSize = true;
            RbtnLargeCar.Location = new Point(15, 80);
            RbtnLargeCar.Name = "RbtnLargeCar";
            RbtnLargeCar.Size = new Size(75, 19);
            RbtnLargeCar.TabIndex = 2;
            RbtnLargeCar.Text = "Large Car";
            RbtnLargeCar.UseVisualStyleBackColor = true;
            // 
            // RbtnSmallCar
            // 
            RbtnSmallCar.AutoSize = true;
            RbtnSmallCar.Location = new Point(15, 105);
            RbtnSmallCar.Name = "RbtnSmallCar";
            RbtnSmallCar.Size = new Size(75, 19);
            RbtnSmallCar.TabIndex = 3;
            RbtnSmallCar.Text = "Small Car";
            RbtnSmallCar.UseVisualStyleBackColor = true;
            // 
            // TxtLicensePlate
            // 
            TxtLicensePlate.CharacterCasing = CharacterCasing.Upper;
            TxtLicensePlate.Location = new Point(15, 46);
            TxtLicensePlate.MaxLength = 7;
            TxtLicensePlate.Name = "TxtLicensePlate";
            TxtLicensePlate.Size = new Size(100, 23);
            TxtLicensePlate.TabIndex = 1;
            // 
            // LblLicensePlate
            // 
            LblLicensePlate.AutoSize = true;
            LblLicensePlate.Location = new Point(15, 28);
            LblLicensePlate.Name = "LblLicensePlate";
            LblLicensePlate.Size = new Size(72, 15);
            LblLicensePlate.TabIndex = 0;
            LblLicensePlate.Text = "LicensePlate";
            // 
            // FormReportParking
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(450, 243);
            Controls.Add(PnlMain);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FormReportParking";
            Text = "Parking Report";
            PnlMain.ResumeLayout(false);
            GrpFilter.ResumeLayout(false);
            GrpFilter.PerformLayout();
            GrpEntryTime.ResumeLayout(false);
            GrpEntryTime.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel PnlMain;
        private GroupBox GrpFilter;
        private Label LblLicensePlate;
        private TextBox TxtLicensePlate;
        private RadioButton RbtnLargeCar;
        private RadioButton RbtnSmallCar;
        private RadioButton RbtnBoth;
        private CheckBox ChkAllDates;
        private DateTimePicker DtpEntryFinish;
        private Label LblUntil;
        private DateTimePicker DtpEntryStart;
        private GroupBox GrpEntryTime;
        private ComboBox CmbResponsible;
        private Label LblResponsible;
        private Button BtnSearch;
    }
}