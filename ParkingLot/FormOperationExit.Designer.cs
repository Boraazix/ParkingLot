namespace ParkingLot
{
    partial class FormOperationExit
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOperationExit));
            PnlMain = new Panel();
            GrpFinish = new GroupBox();
            BtnExitCar = new Button();
            LblTotal = new Label();
            TxtTotal = new TextBox();
            LblInterval = new Label();
            TxtInterval = new TextBox();
            LblExit = new Label();
            TxtExit = new TextBox();
            LblEntry = new Label();
            TxtEntry = new TextBox();
            LblCar = new Label();
            TxtLicensePlate = new TextBox();
            LblClock = new Label();
            TxtResult = new TextBox();
            BtnCalculateFee = new Button();
            LstParking = new ListBox();
            TmrClock = new System.Windows.Forms.Timer(components);
            PnlMain.SuspendLayout();
            GrpFinish.SuspendLayout();
            SuspendLayout();
            // 
            // PnlMain
            // 
            PnlMain.Controls.Add(GrpFinish);
            PnlMain.Controls.Add(LstParking);
            PnlMain.Location = new Point(0, 0);
            PnlMain.Name = "PnlMain";
            PnlMain.Size = new Size(458, 450);
            PnlMain.TabIndex = 0;
            // 
            // GrpFinish
            // 
            GrpFinish.Controls.Add(BtnExitCar);
            GrpFinish.Controls.Add(LblTotal);
            GrpFinish.Controls.Add(TxtTotal);
            GrpFinish.Controls.Add(LblInterval);
            GrpFinish.Controls.Add(TxtInterval);
            GrpFinish.Controls.Add(LblExit);
            GrpFinish.Controls.Add(TxtExit);
            GrpFinish.Controls.Add(LblEntry);
            GrpFinish.Controls.Add(TxtEntry);
            GrpFinish.Controls.Add(LblCar);
            GrpFinish.Controls.Add(TxtLicensePlate);
            GrpFinish.Controls.Add(LblClock);
            GrpFinish.Controls.Add(TxtResult);
            GrpFinish.Controls.Add(BtnCalculateFee);
            GrpFinish.Location = new Point(12, 217);
            GrpFinish.Name = "GrpFinish";
            GrpFinish.Size = new Size(433, 221);
            GrpFinish.TabIndex = 1;
            GrpFinish.TabStop = false;
            GrpFinish.Text = "Finish";
            // 
            // BtnExitCar
            // 
            BtnExitCar.Enabled = false;
            BtnExitCar.Location = new Point(343, 180);
            BtnExitCar.Name = "BtnExitCar";
            BtnExitCar.Size = new Size(72, 24);
            BtnExitCar.TabIndex = 7;
            BtnExitCar.Text = "Exit";
            BtnExitCar.UseVisualStyleBackColor = true;
            BtnExitCar.Click += BtnExitCar_Click;
            // 
            // LblTotal
            // 
            LblTotal.AutoSize = true;
            LblTotal.Location = new Point(244, 162);
            LblTotal.Name = "LblTotal";
            LblTotal.Size = new Size(32, 15);
            LblTotal.TabIndex = 13;
            LblTotal.Text = "Total";
            // 
            // TxtTotal
            // 
            TxtTotal.Location = new Point(244, 180);
            TxtTotal.Name = "TxtTotal";
            TxtTotal.PlaceholderText = "Total payable";
            TxtTotal.ReadOnly = true;
            TxtTotal.Size = new Size(93, 23);
            TxtTotal.TabIndex = 6;
            // 
            // LblInterval
            // 
            LblInterval.AutoSize = true;
            LblInterval.Location = new Point(15, 162);
            LblInterval.Name = "LblInterval";
            LblInterval.Size = new Size(46, 15);
            LblInterval.TabIndex = 11;
            LblInterval.Text = "Interval";
            // 
            // TxtInterval
            // 
            TxtInterval.Location = new Point(15, 180);
            TxtInterval.Name = "TxtInterval";
            TxtInterval.PlaceholderText = "Interval between Entry and Exit";
            TxtInterval.ReadOnly = true;
            TxtInterval.Size = new Size(223, 23);
            TxtInterval.TabIndex = 5;
            // 
            // LblExit
            // 
            LblExit.AutoSize = true;
            LblExit.Location = new Point(265, 114);
            LblExit.Name = "LblExit";
            LblExit.Size = new Size(26, 15);
            LblExit.TabIndex = 9;
            LblExit.Text = "Exit";
            // 
            // TxtExit
            // 
            TxtExit.Location = new Point(265, 132);
            TxtExit.Name = "TxtExit";
            TxtExit.PlaceholderText = "Exit Date";
            TxtExit.ReadOnly = true;
            TxtExit.Size = new Size(150, 23);
            TxtExit.TabIndex = 4;
            // 
            // LblEntry
            // 
            LblEntry.AutoSize = true;
            LblEntry.Location = new Point(109, 114);
            LblEntry.Name = "LblEntry";
            LblEntry.Size = new Size(34, 15);
            LblEntry.TabIndex = 7;
            LblEntry.Text = "Entry";
            // 
            // TxtEntry
            // 
            TxtEntry.Location = new Point(109, 132);
            TxtEntry.Name = "TxtEntry";
            TxtEntry.PlaceholderText = "Entry Date";
            TxtEntry.ReadOnly = true;
            TxtEntry.Size = new Size(150, 23);
            TxtEntry.TabIndex = 3;
            // 
            // LblCar
            // 
            LblCar.AutoSize = true;
            LblCar.Location = new Point(15, 114);
            LblCar.Name = "LblCar";
            LblCar.Size = new Size(25, 15);
            LblCar.TabIndex = 5;
            LblCar.Text = "Car";
            // 
            // TxtLicensePlate
            // 
            TxtLicensePlate.Location = new Point(15, 132);
            TxtLicensePlate.Name = "TxtLicensePlate";
            TxtLicensePlate.PlaceholderText = "License Plate";
            TxtLicensePlate.ReadOnly = true;
            TxtLicensePlate.Size = new Size(88, 23);
            TxtLicensePlate.TabIndex = 2;
            // 
            // LblClock
            // 
            LblClock.AutoSize = true;
            LblClock.Location = new Point(345, 27);
            LblClock.Name = "LblClock";
            LblClock.Size = new Size(37, 15);
            LblClock.TabIndex = 3;
            LblClock.Text = "Clock";
            LblClock.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TxtResult
            // 
            TxtResult.Location = new Point(15, 52);
            TxtResult.Multiline = true;
            TxtResult.Name = "TxtResult";
            TxtResult.PlaceholderText = "Result";
            TxtResult.ReadOnly = true;
            TxtResult.ScrollBars = ScrollBars.Horizontal;
            TxtResult.Size = new Size(401, 55);
            TxtResult.TabIndex = 1;
            TxtResult.WordWrap = false;
            // 
            // BtnCalculateFee
            // 
            BtnCalculateFee.Location = new Point(15, 22);
            BtnCalculateFee.Name = "BtnCalculateFee";
            BtnCalculateFee.Size = new Size(93, 24);
            BtnCalculateFee.TabIndex = 0;
            BtnCalculateFee.Text = "Calculate Fee";
            BtnCalculateFee.UseVisualStyleBackColor = true;
            BtnCalculateFee.Click += BtnCalculateFee_Click;
            // 
            // LstParking
            // 
            LstParking.FormattingEnabled = true;
            LstParking.ItemHeight = 15;
            LstParking.Location = new Point(12, 12);
            LstParking.Name = "LstParking";
            LstParking.Size = new Size(433, 199);
            LstParking.TabIndex = 0;
            // 
            // TmrClock
            // 
            TmrClock.Enabled = true;
            TmrClock.Interval = 1000;
            TmrClock.Tick += TmrClock_Tick;
            // 
            // FormOperationExit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(458, 450);
            Controls.Add(PnlMain);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FormOperationExit";
            Text = "Car exit";
            PnlMain.ResumeLayout(false);
            GrpFinish.ResumeLayout(false);
            GrpFinish.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel PnlMain;
        private ListBox LstParking;
        private Button BtnCalculateFee;
        private GroupBox GrpFinish;
        private TextBox TxtResult;
        private Label LblClock;
        private System.Windows.Forms.Timer TmrClock;
        private TextBox TxtLicensePlate;
        private Label LblCar;
        private TextBox TxtEntry;
        private Label LblInterval;
        private TextBox TxtInterval;
        private Label LblExit;
        private TextBox TxtExit;
        private Label LblEntry;
        private Button BtnExitCar;
        private Label LblTotal;
        private TextBox TxtTotal;
    }
}