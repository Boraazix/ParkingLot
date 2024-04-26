namespace ParkingLot
{
    partial class FormFileFees
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
            BtnSaveFees = new Button();
            GrpLargeCars = new GroupBox();
            NudLAdditionalHour = new NumericUpDown();
            LblLFifteenOrLess = new Label();
            LblLAdditionalHour = new Label();
            NudLFifteenOrLess = new NumericUpDown();
            NudLSixtyOrLess = new NumericUpDown();
            LblLThirtyOrLess = new Label();
            LblLSixtyOrLess = new Label();
            NudLThirtyOrLess = new NumericUpDown();
            GrpSmallCars = new GroupBox();
            NudSAdditionalHour = new NumericUpDown();
            LblSAdditionalHour = new Label();
            NudSSixtyOrLess = new NumericUpDown();
            LblSSixtyOrLess = new Label();
            NudSThirtyOrLess = new NumericUpDown();
            LblSThirtyOrLess = new Label();
            NudSFifteenOrLess = new NumericUpDown();
            LblSFifteenOrLess = new Label();
            LblDollar = new Label();
            PnlMain.SuspendLayout();
            GrpLargeCars.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NudLAdditionalHour).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NudLFifteenOrLess).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NudLSixtyOrLess).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NudLThirtyOrLess).BeginInit();
            GrpSmallCars.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NudSAdditionalHour).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NudSSixtyOrLess).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NudSThirtyOrLess).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NudSFifteenOrLess).BeginInit();
            SuspendLayout();
            // 
            // PnlMain
            // 
            PnlMain.Controls.Add(LblDollar);
            PnlMain.Controls.Add(BtnSaveFees);
            PnlMain.Controls.Add(GrpLargeCars);
            PnlMain.Controls.Add(GrpSmallCars);
            PnlMain.Location = new Point(0, 0);
            PnlMain.Name = "PnlMain";
            PnlMain.Size = new Size(444, 214);
            PnlMain.TabIndex = 0;
            // 
            // BtnSaveFees
            // 
            BtnSaveFees.Location = new Point(357, 179);
            BtnSaveFees.Name = "BtnSaveFees";
            BtnSaveFees.Size = new Size(75, 23);
            BtnSaveFees.TabIndex = 8;
            BtnSaveFees.Text = "Save Fees";
            BtnSaveFees.UseVisualStyleBackColor = true;
            BtnSaveFees.Click += BtnSaveFees_Click;
            // 
            // GrpLargeCars
            // 
            GrpLargeCars.Controls.Add(NudLAdditionalHour);
            GrpLargeCars.Controls.Add(LblLFifteenOrLess);
            GrpLargeCars.Controls.Add(LblLAdditionalHour);
            GrpLargeCars.Controls.Add(NudLFifteenOrLess);
            GrpLargeCars.Controls.Add(NudLSixtyOrLess);
            GrpLargeCars.Controls.Add(LblLThirtyOrLess);
            GrpLargeCars.Controls.Add(LblLSixtyOrLess);
            GrpLargeCars.Controls.Add(NudLThirtyOrLess);
            GrpLargeCars.Location = new Point(225, 12);
            GrpLargeCars.Name = "GrpLargeCars";
            GrpLargeCars.Size = new Size(207, 161);
            GrpLargeCars.TabIndex = 1;
            GrpLargeCars.TabStop = false;
            GrpLargeCars.Text = "Large Cars";
            // 
            // NudLAdditionalHour
            // 
            NudLAdditionalHour.DecimalPlaces = 2;
            NudLAdditionalHour.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            NudLAdditionalHour.Location = new Point(139, 122);
            NudLAdditionalHour.Maximum = new decimal(new int[] { 99999, 0, 0, 131072 });
            NudLAdditionalHour.Name = "NudLAdditionalHour";
            NudLAdditionalHour.Size = new Size(53, 23);
            NudLAdditionalHour.TabIndex = 7;
            // 
            // LblLFifteenOrLess
            // 
            LblLFifteenOrLess.AutoSize = true;
            LblLFifteenOrLess.Location = new Point(15, 28);
            LblLFifteenOrLess.Name = "LblLFifteenOrLess";
            LblLFifteenOrLess.Size = new Size(97, 15);
            LblLFifteenOrLess.TabIndex = 8;
            LblLFifteenOrLess.Text = "Up to 15 minutes";
            // 
            // LblLAdditionalHour
            // 
            LblLAdditionalHour.AutoSize = true;
            LblLAdditionalHour.Location = new Point(15, 124);
            LblLAdditionalHour.Name = "LblLAdditionalHour";
            LblLAdditionalHour.Size = new Size(90, 15);
            LblLAdditionalHour.TabIndex = 14;
            LblLAdditionalHour.Text = "Additional hour";
            // 
            // NudLFifteenOrLess
            // 
            NudLFifteenOrLess.DecimalPlaces = 2;
            NudLFifteenOrLess.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            NudLFifteenOrLess.Location = new Point(139, 26);
            NudLFifteenOrLess.Maximum = new decimal(new int[] { 99999, 0, 0, 131072 });
            NudLFifteenOrLess.Name = "NudLFifteenOrLess";
            NudLFifteenOrLess.Size = new Size(53, 23);
            NudLFifteenOrLess.TabIndex = 4;
            // 
            // NudLSixtyOrLess
            // 
            NudLSixtyOrLess.DecimalPlaces = 2;
            NudLSixtyOrLess.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            NudLSixtyOrLess.Location = new Point(139, 90);
            NudLSixtyOrLess.Maximum = new decimal(new int[] { 99999, 0, 0, 131072 });
            NudLSixtyOrLess.Name = "NudLSixtyOrLess";
            NudLSixtyOrLess.Size = new Size(53, 23);
            NudLSixtyOrLess.TabIndex = 6;
            // 
            // LblLThirtyOrLess
            // 
            LblLThirtyOrLess.AutoSize = true;
            LblLThirtyOrLess.Location = new Point(15, 60);
            LblLThirtyOrLess.Name = "LblLThirtyOrLess";
            LblLThirtyOrLess.Size = new Size(97, 15);
            LblLThirtyOrLess.TabIndex = 10;
            LblLThirtyOrLess.Text = "Up to 30 minutes";
            // 
            // LblLSixtyOrLess
            // 
            LblLSixtyOrLess.AutoSize = true;
            LblLSixtyOrLess.Location = new Point(15, 92);
            LblLSixtyOrLess.Name = "LblLSixtyOrLess";
            LblLSixtyOrLess.Size = new Size(73, 15);
            LblLSixtyOrLess.TabIndex = 12;
            LblLSixtyOrLess.Text = "Up to 1 hour";
            // 
            // NudLThirtyOrLess
            // 
            NudLThirtyOrLess.DecimalPlaces = 2;
            NudLThirtyOrLess.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            NudLThirtyOrLess.Location = new Point(139, 58);
            NudLThirtyOrLess.Maximum = new decimal(new int[] { 99999, 0, 0, 131072 });
            NudLThirtyOrLess.Name = "NudLThirtyOrLess";
            NudLThirtyOrLess.Size = new Size(53, 23);
            NudLThirtyOrLess.TabIndex = 5;
            // 
            // GrpSmallCars
            // 
            GrpSmallCars.Controls.Add(NudSAdditionalHour);
            GrpSmallCars.Controls.Add(LblSAdditionalHour);
            GrpSmallCars.Controls.Add(NudSSixtyOrLess);
            GrpSmallCars.Controls.Add(LblSSixtyOrLess);
            GrpSmallCars.Controls.Add(NudSThirtyOrLess);
            GrpSmallCars.Controls.Add(LblSThirtyOrLess);
            GrpSmallCars.Controls.Add(NudSFifteenOrLess);
            GrpSmallCars.Controls.Add(LblSFifteenOrLess);
            GrpSmallCars.Location = new Point(12, 12);
            GrpSmallCars.Name = "GrpSmallCars";
            GrpSmallCars.Size = new Size(207, 161);
            GrpSmallCars.TabIndex = 0;
            GrpSmallCars.TabStop = false;
            GrpSmallCars.Text = "Small Cars";
            // 
            // NudSAdditionalHour
            // 
            NudSAdditionalHour.DecimalPlaces = 2;
            NudSAdditionalHour.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            NudSAdditionalHour.Location = new Point(139, 122);
            NudSAdditionalHour.Maximum = new decimal(new int[] { 99999, 0, 0, 131072 });
            NudSAdditionalHour.Name = "NudSAdditionalHour";
            NudSAdditionalHour.Size = new Size(53, 23);
            NudSAdditionalHour.TabIndex = 3;
            // 
            // LblSAdditionalHour
            // 
            LblSAdditionalHour.AutoSize = true;
            LblSAdditionalHour.Location = new Point(15, 124);
            LblSAdditionalHour.Name = "LblSAdditionalHour";
            LblSAdditionalHour.Size = new Size(90, 15);
            LblSAdditionalHour.TabIndex = 6;
            LblSAdditionalHour.Text = "Additional hour";
            // 
            // NudSSixtyOrLess
            // 
            NudSSixtyOrLess.DecimalPlaces = 2;
            NudSSixtyOrLess.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            NudSSixtyOrLess.Location = new Point(139, 90);
            NudSSixtyOrLess.Maximum = new decimal(new int[] { 99999, 0, 0, 131072 });
            NudSSixtyOrLess.Name = "NudSSixtyOrLess";
            NudSSixtyOrLess.Size = new Size(53, 23);
            NudSSixtyOrLess.TabIndex = 2;
            // 
            // LblSSixtyOrLess
            // 
            LblSSixtyOrLess.AutoSize = true;
            LblSSixtyOrLess.Location = new Point(15, 92);
            LblSSixtyOrLess.Name = "LblSSixtyOrLess";
            LblSSixtyOrLess.Size = new Size(73, 15);
            LblSSixtyOrLess.TabIndex = 4;
            LblSSixtyOrLess.Text = "Up to 1 hour";
            // 
            // NudSThirtyOrLess
            // 
            NudSThirtyOrLess.DecimalPlaces = 2;
            NudSThirtyOrLess.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            NudSThirtyOrLess.Location = new Point(139, 58);
            NudSThirtyOrLess.Maximum = new decimal(new int[] { 99999, 0, 0, 131072 });
            NudSThirtyOrLess.Name = "NudSThirtyOrLess";
            NudSThirtyOrLess.Size = new Size(53, 23);
            NudSThirtyOrLess.TabIndex = 1;
            // 
            // LblSThirtyOrLess
            // 
            LblSThirtyOrLess.AutoSize = true;
            LblSThirtyOrLess.Location = new Point(15, 60);
            LblSThirtyOrLess.Name = "LblSThirtyOrLess";
            LblSThirtyOrLess.Size = new Size(97, 15);
            LblSThirtyOrLess.TabIndex = 2;
            LblSThirtyOrLess.Text = "Up to 30 minutes";
            // 
            // NudSFifteenOrLess
            // 
            NudSFifteenOrLess.DecimalPlaces = 2;
            NudSFifteenOrLess.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            NudSFifteenOrLess.Location = new Point(139, 26);
            NudSFifteenOrLess.Maximum = new decimal(new int[] { 99999, 0, 0, 131072 });
            NudSFifteenOrLess.Name = "NudSFifteenOrLess";
            NudSFifteenOrLess.Size = new Size(53, 23);
            NudSFifteenOrLess.TabIndex = 0;
            // 
            // LblSFifteenOrLess
            // 
            LblSFifteenOrLess.AutoSize = true;
            LblSFifteenOrLess.Location = new Point(15, 28);
            LblSFifteenOrLess.Name = "LblSFifteenOrLess";
            LblSFifteenOrLess.Size = new Size(97, 15);
            LblSFifteenOrLess.TabIndex = 0;
            LblSFifteenOrLess.Text = "Up to 15 minutes";
            // 
            // LblDollar
            // 
            LblDollar.AutoSize = true;
            LblDollar.ForeColor = Color.DarkRed;
            LblDollar.Location = new Point(12, 183);
            LblDollar.Name = "LblDollar";
            LblDollar.Size = new Size(91, 15);
            LblDollar.TabIndex = 9;
            LblDollar.Text = "Values ​​in dollars";
            // 
            // FormFileFees
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(444, 214);
            Controls.Add(PnlMain);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormFileFees";
            Text = "Fees";
            PnlMain.ResumeLayout(false);
            PnlMain.PerformLayout();
            GrpLargeCars.ResumeLayout(false);
            GrpLargeCars.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NudLAdditionalHour).EndInit();
            ((System.ComponentModel.ISupportInitialize)NudLFifteenOrLess).EndInit();
            ((System.ComponentModel.ISupportInitialize)NudLSixtyOrLess).EndInit();
            ((System.ComponentModel.ISupportInitialize)NudLThirtyOrLess).EndInit();
            GrpSmallCars.ResumeLayout(false);
            GrpSmallCars.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NudSAdditionalHour).EndInit();
            ((System.ComponentModel.ISupportInitialize)NudSSixtyOrLess).EndInit();
            ((System.ComponentModel.ISupportInitialize)NudSThirtyOrLess).EndInit();
            ((System.ComponentModel.ISupportInitialize)NudSFifteenOrLess).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel PnlMain;
        private GroupBox GrpLargeCars;
        private GroupBox GrpSmallCars;
        private Label LblSFifteenOrLess;
        private NumericUpDown NudSThirtyOrLess;
        private Label LblSThirtyOrLess;
        private NumericUpDown NudSFifteenOrLess;
        private NumericUpDown NudSSixtyOrLess;
        private Label LblSSixtyOrLess;
        private NumericUpDown NudSAdditionalHour;
        private Label LblSAdditionalHour;
        private NumericUpDown NudLAdditionalHour;
        private Label LblLFifteenOrLess;
        private Label LblLAdditionalHour;
        private NumericUpDown NudLFifteenOrLess;
        private NumericUpDown NudLSixtyOrLess;
        private Label LblLThirtyOrLess;
        private Label LblLSixtyOrLess;
        private NumericUpDown NudLThirtyOrLess;
        private Button BtnSaveFees;
        private Label LblDollar;
    }
}