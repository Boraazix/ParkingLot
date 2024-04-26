namespace ParkingLot
{
    partial class FormEditUser
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
            GrpEditUser = new GroupBox();
            BtnCancel = new Button();
            ChkAdministrator = new CheckBox();
            TxtConfirmPassword = new TextBox();
            LblConfirmPassword = new Label();
            TxtLastName = new TextBox();
            LblLastName = new Label();
            BtnSaveChanges = new Button();
            ChkActive = new CheckBox();
            LblBirth = new Label();
            DtpBirth = new DateTimePicker();
            TxtPassword = new TextBox();
            LblPassword = new Label();
            TxtEmail = new TextBox();
            LblEmail = new Label();
            TxtFirstName = new TextBox();
            LblFirstName = new Label();
            PnlMain.SuspendLayout();
            GrpEditUser.SuspendLayout();
            SuspendLayout();
            // 
            // PnlMain
            // 
            PnlMain.Controls.Add(GrpEditUser);
            PnlMain.Location = new Point(0, 0);
            PnlMain.Name = "PnlMain";
            PnlMain.Size = new Size(409, 239);
            PnlMain.TabIndex = 2;
            // 
            // GrpEditUser
            // 
            GrpEditUser.Controls.Add(BtnCancel);
            GrpEditUser.Controls.Add(ChkAdministrator);
            GrpEditUser.Controls.Add(TxtConfirmPassword);
            GrpEditUser.Controls.Add(LblConfirmPassword);
            GrpEditUser.Controls.Add(TxtLastName);
            GrpEditUser.Controls.Add(LblLastName);
            GrpEditUser.Controls.Add(BtnSaveChanges);
            GrpEditUser.Controls.Add(ChkActive);
            GrpEditUser.Controls.Add(LblBirth);
            GrpEditUser.Controls.Add(DtpBirth);
            GrpEditUser.Controls.Add(TxtPassword);
            GrpEditUser.Controls.Add(LblPassword);
            GrpEditUser.Controls.Add(TxtEmail);
            GrpEditUser.Controls.Add(LblEmail);
            GrpEditUser.Controls.Add(TxtFirstName);
            GrpEditUser.Controls.Add(LblFirstName);
            GrpEditUser.Location = new Point(12, 12);
            GrpEditUser.Name = "GrpEditUser";
            GrpEditUser.Size = new Size(384, 213);
            GrpEditUser.TabIndex = 2;
            GrpEditUser.TabStop = false;
            GrpEditUser.Text = "Edit User";
            // 
            // BtnCancel
            // 
            BtnCancel.Location = new Point(198, 175);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(75, 24);
            BtnCancel.TabIndex = 8;
            BtnCancel.Text = "Cancel";
            BtnCancel.UseVisualStyleBackColor = true;
            BtnCancel.Click += BtnCancel_Click;
            // 
            // ChkAdministrator
            // 
            ChkAdministrator.AutoSize = true;
            ChkAdministrator.Location = new Point(234, 92);
            ChkAdministrator.Name = "ChkAdministrator";
            ChkAdministrator.Size = new Size(99, 19);
            ChkAdministrator.TabIndex = 4;
            ChkAdministrator.Text = "Administrator";
            ChkAdministrator.UseVisualStyleBackColor = true;
            // 
            // TxtConfirmPassword
            // 
            TxtConfirmPassword.Location = new Point(146, 138);
            TxtConfirmPassword.MaxLength = 12;
            TxtConfirmPassword.Name = "TxtConfirmPassword";
            TxtConfirmPassword.PasswordChar = '*';
            TxtConfirmPassword.PlaceholderText = "Repeat the password";
            TxtConfirmPassword.Size = new Size(120, 23);
            TxtConfirmPassword.TabIndex = 6;
            // 
            // LblConfirmPassword
            // 
            LblConfirmPassword.AutoSize = true;
            LblConfirmPassword.Location = new Point(146, 120);
            LblConfirmPassword.Name = "LblConfirmPassword";
            LblConfirmPassword.Size = new Size(104, 15);
            LblConfirmPassword.TabIndex = 12;
            LblConfirmPassword.Text = "Confirm Password";
            // 
            // TxtLastName
            // 
            TxtLastName.Location = new Point(124, 46);
            TxtLastName.MaxLength = 20;
            TxtLastName.Name = "TxtLastName";
            TxtLastName.Size = new Size(98, 23);
            TxtLastName.TabIndex = 1;
            // 
            // LblLastName
            // 
            LblLastName.AutoSize = true;
            LblLastName.Location = new Point(125, 26);
            LblLastName.Name = "LblLastName";
            LblLastName.Size = new Size(63, 15);
            LblLastName.TabIndex = 10;
            LblLastName.Text = "Last Name";
            // 
            // BtnSaveChanges
            // 
            BtnSaveChanges.Location = new Point(279, 175);
            BtnSaveChanges.Name = "BtnSaveChanges";
            BtnSaveChanges.Size = new Size(87, 24);
            BtnSaveChanges.TabIndex = 9;
            BtnSaveChanges.Text = "Save changes";
            BtnSaveChanges.UseVisualStyleBackColor = true;
            BtnSaveChanges.Click += BtnSaveChanges_Click;
            // 
            // ChkActive
            // 
            ChkActive.AutoSize = true;
            ChkActive.Checked = true;
            ChkActive.CheckState = CheckState.Checked;
            ChkActive.Location = new Point(279, 140);
            ChkActive.Name = "ChkActive";
            ChkActive.Size = new Size(59, 19);
            ChkActive.TabIndex = 7;
            ChkActive.Text = "Active";
            ChkActive.UseVisualStyleBackColor = true;
            // 
            // LblBirth
            // 
            LblBirth.AutoSize = true;
            LblBirth.Location = new Point(233, 28);
            LblBirth.Name = "LblBirth";
            LblBirth.Size = new Size(32, 15);
            LblBirth.TabIndex = 7;
            LblBirth.Text = "Birth";
            // 
            // DtpBirth
            // 
            DtpBirth.Format = DateTimePickerFormat.Short;
            DtpBirth.Location = new Point(233, 46);
            DtpBirth.MaxDate = new DateTime(3000, 1, 1, 0, 0, 0, 0);
            DtpBirth.Name = "DtpBirth";
            DtpBirth.Size = new Size(131, 23);
            DtpBirth.TabIndex = 2;
            DtpBirth.Value = new DateTime(2024, 4, 25, 0, 0, 0, 0);
            // 
            // TxtPassword
            // 
            TxtPassword.Location = new Point(15, 138);
            TxtPassword.MaxLength = 12;
            TxtPassword.Name = "TxtPassword";
            TxtPassword.PasswordChar = '*';
            TxtPassword.PlaceholderText = "Between 8-12 chars";
            TxtPassword.Size = new Size(120, 23);
            TxtPassword.TabIndex = 5;
            // 
            // LblPassword
            // 
            LblPassword.AutoSize = true;
            LblPassword.Location = new Point(15, 120);
            LblPassword.Name = "LblPassword";
            LblPassword.Size = new Size(84, 15);
            LblPassword.TabIndex = 4;
            LblPassword.Text = "New Password";
            // 
            // TxtEmail
            // 
            TxtEmail.Location = new Point(15, 90);
            TxtEmail.MaxLength = 250;
            TxtEmail.Name = "TxtEmail";
            TxtEmail.Size = new Size(207, 23);
            TxtEmail.TabIndex = 3;
            // 
            // LblEmail
            // 
            LblEmail.AutoSize = true;
            LblEmail.Location = new Point(15, 72);
            LblEmail.Name = "LblEmail";
            LblEmail.Size = new Size(36, 15);
            LblEmail.TabIndex = 2;
            LblEmail.Text = "Email";
            // 
            // TxtFirstName
            // 
            TxtFirstName.Location = new Point(15, 46);
            TxtFirstName.MaxLength = 20;
            TxtFirstName.Name = "TxtFirstName";
            TxtFirstName.Size = new Size(98, 23);
            TxtFirstName.TabIndex = 0;
            // 
            // LblFirstName
            // 
            LblFirstName.AutoSize = true;
            LblFirstName.Location = new Point(15, 28);
            LblFirstName.Name = "LblFirstName";
            LblFirstName.Size = new Size(64, 15);
            LblFirstName.TabIndex = 0;
            LblFirstName.Text = "First Name";
            // 
            // FormEditUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(409, 239);
            Controls.Add(PnlMain);
            MaximizeBox = false;
            Name = "FormEditUser";
            Text = "Editing User";
            PnlMain.ResumeLayout(false);
            GrpEditUser.ResumeLayout(false);
            GrpEditUser.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel PnlMain;
        private GroupBox GrpEditUser;
        private CheckBox ChkAdministrator;
        private TextBox TxtConfirmPassword;
        private Label LblConfirmPassword;
        private TextBox TxtLastName;
        private Label LblLastName;
        private Button BtnSaveChanges;
        private CheckBox ChkActive;
        private Label LblBirth;
        private DateTimePicker DtpBirth;
        private TextBox TxtPassword;
        private Label LblPassword;
        private TextBox TxtEmail;
        private Label LblEmail;
        private TextBox TxtFirstName;
        private Label LblFirstName;
        private Button BtnCancel;
    }
}