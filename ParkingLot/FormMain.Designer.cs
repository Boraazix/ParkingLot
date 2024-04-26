namespace ParkingLot
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            MnuMain = new MenuStrip();
            MnuFile = new ToolStripMenuItem();
            MnuFileFees = new ToolStripMenuItem();
            MnuFileLogoff = new ToolStripMenuItem();
            MnuFileExit = new ToolStripMenuItem();
            MnuRegister = new ToolStripMenuItem();
            MnuRegisterUser = new ToolStripMenuItem();
            MnuOperation = new ToolStripMenuItem();
            MnuOperationEntry = new ToolStripMenuItem();
            MnuOperationExit = new ToolStripMenuItem();
            MnuReport = new ToolStripMenuItem();
            MnuReportParking = new ToolStripMenuItem();
            MnuMain.SuspendLayout();
            SuspendLayout();
            // 
            // MnuMain
            // 
            MnuMain.Items.AddRange(new ToolStripItem[] { MnuFile, MnuRegister, MnuOperation, MnuReport });
            MnuMain.Location = new Point(0, 0);
            MnuMain.Name = "MnuMain";
            MnuMain.Size = new Size(800, 24);
            MnuMain.TabIndex = 1;
            MnuMain.Text = "menuStrip1";
            // 
            // MnuFile
            // 
            MnuFile.DropDownItems.AddRange(new ToolStripItem[] { MnuFileFees, MnuFileLogoff, MnuFileExit });
            MnuFile.Name = "MnuFile";
            MnuFile.Size = new Size(37, 20);
            MnuFile.Text = "File";
            // 
            // MnuFileFees
            // 
            MnuFileFees.Name = "MnuFileFees";
            MnuFileFees.Size = new Size(180, 22);
            MnuFileFees.Text = "Fees";
            MnuFileFees.Click += MnuFileFees_Click;
            // 
            // MnuFileLogoff
            // 
            MnuFileLogoff.Name = "MnuFileLogoff";
            MnuFileLogoff.Size = new Size(180, 22);
            MnuFileLogoff.Text = "Logoff";
            MnuFileLogoff.Click += MnuFileLogoff_Click;
            // 
            // MnuFileExit
            // 
            MnuFileExit.Name = "MnuFileExit";
            MnuFileExit.Size = new Size(180, 22);
            MnuFileExit.Text = "Exit";
            MnuFileExit.Click += MnuFileExit_Click;
            // 
            // MnuRegister
            // 
            MnuRegister.DropDownItems.AddRange(new ToolStripItem[] { MnuRegisterUser });
            MnuRegister.Name = "MnuRegister";
            MnuRegister.Size = new Size(61, 20);
            MnuRegister.Text = "Register";
            // 
            // MnuRegisterUser
            // 
            MnuRegisterUser.Name = "MnuRegisterUser";
            MnuRegisterUser.Size = new Size(180, 22);
            MnuRegisterUser.Text = "User";
            MnuRegisterUser.Click += MnuRegisterUser_Click;
            // 
            // MnuOperation
            // 
            MnuOperation.DropDownItems.AddRange(new ToolStripItem[] { MnuOperationEntry, MnuOperationExit });
            MnuOperation.Name = "MnuOperation";
            MnuOperation.Size = new Size(72, 20);
            MnuOperation.Text = "Operation";
            // 
            // MnuOperationEntry
            // 
            MnuOperationEntry.Name = "MnuOperationEntry";
            MnuOperationEntry.Size = new Size(141, 22);
            MnuOperationEntry.Text = "Car entrance";
            // 
            // MnuOperationExit
            // 
            MnuOperationExit.Name = "MnuOperationExit";
            MnuOperationExit.Size = new Size(141, 22);
            MnuOperationExit.Text = "Car exit";
            // 
            // MnuReport
            // 
            MnuReport.DropDownItems.AddRange(new ToolStripItem[] { MnuReportParking });
            MnuReport.Name = "MnuReport";
            MnuReport.Size = new Size(54, 20);
            MnuReport.Text = "Report";
            // 
            // MnuReportParking
            // 
            MnuReportParking.Name = "MnuReportParking";
            MnuReportParking.Size = new Size(114, 22);
            MnuReportParking.Text = "Parking";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(MnuMain);
            IsMdiContainer = true;
            MainMenuStrip = MnuMain;
            Name = "FormMain";
            Text = "Parking Lot";
            FormClosed += FormMain_FormClosed;
            MnuMain.ResumeLayout(false);
            MnuMain.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip MnuMain;
        private ToolStripMenuItem MnuFile;
        private ToolStripMenuItem MnuFileLogoff;
        private ToolStripMenuItem MnuFileExit;
        private ToolStripMenuItem MnuRegister;
        private ToolStripMenuItem MnuRegisterUser;
        private ToolStripMenuItem MnuOperation;
        private ToolStripMenuItem MnuOperationEntry;
        private ToolStripMenuItem MnuOperationExit;
        private ToolStripMenuItem MnuReport;
        private ToolStripMenuItem MnuReportParking;
        private ToolStripMenuItem MnuFileFees;
    }
}
