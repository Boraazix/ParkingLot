namespace ParkingLot
{
    partial class FormRegisterUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegisterUser));
            PnlMain = new Panel();
            BtnDeleteUser = new Button();
            BtnEditUser = new Button();
            BtnShowData = new Button();
            LstUsers = new ListBox();
            GrpNewUser = new GroupBox();
            ChkAdministrator = new CheckBox();
            TxtConfirmPassword = new TextBox();
            LblConfirmPassword = new Label();
            TxtLastName = new TextBox();
            LblLastName = new Label();
            BtnRegister = new Button();
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
            GrpNewUser.SuspendLayout();
            SuspendLayout();
            // 
            // PnlMain
            // 
            PnlMain.Controls.Add(BtnDeleteUser);
            PnlMain.Controls.Add(BtnEditUser);
            PnlMain.Controls.Add(BtnShowData);
            PnlMain.Controls.Add(LstUsers);
            PnlMain.Controls.Add(GrpNewUser);
            PnlMain.Location = new Point(0, 0);
            PnlMain.Name = "PnlMain";
            PnlMain.Size = new Size(410, 442);
            PnlMain.TabIndex = 0;
            // 
            // BtnDeleteUser
            // 
            BtnDeleteUser.Location = new Point(271, 401);
            BtnDeleteUser.Name = "BtnDeleteUser";
            BtnDeleteUser.Size = new Size(125, 27);
            BtnDeleteUser.TabIndex = 4;
            BtnDeleteUser.Text = "Delete User";
            BtnDeleteUser.UseVisualStyleBackColor = true;
            BtnDeleteUser.Click += BtnDeleteUser_Click;
            // 
            // BtnEditUser
            // 
            BtnEditUser.Location = new Point(142, 401);
            BtnEditUser.Name = "BtnEditUser";
            BtnEditUser.Size = new Size(125, 27);
            BtnEditUser.TabIndex = 3;
            BtnEditUser.Text = "Edit User";
            BtnEditUser.UseVisualStyleBackColor = true;
            BtnEditUser.Click += BtnEditUser_Click;
            // 
            // BtnShowData
            // 
            BtnShowData.Location = new Point(12, 401);
            BtnShowData.Name = "BtnShowData";
            BtnShowData.Size = new Size(125, 27);
            BtnShowData.TabIndex = 2;
            BtnShowData.Text = "Show data";
            BtnShowData.UseVisualStyleBackColor = true;
            BtnShowData.Click += BtnShowData_Click;
            // 
            // LstUsers
            // 
            LstUsers.FormattingEnabled = true;
            LstUsers.ItemHeight = 15;
            LstUsers.Location = new Point(12, 196);
            LstUsers.Name = "LstUsers";
            LstUsers.Size = new Size(384, 199);
            LstUsers.TabIndex = 1;
            // 
            // GrpNewUser
            // 
            GrpNewUser.Controls.Add(ChkAdministrator);
            GrpNewUser.Controls.Add(TxtConfirmPassword);
            GrpNewUser.Controls.Add(LblConfirmPassword);
            GrpNewUser.Controls.Add(TxtLastName);
            GrpNewUser.Controls.Add(LblLastName);
            GrpNewUser.Controls.Add(BtnRegister);
            GrpNewUser.Controls.Add(ChkActive);
            GrpNewUser.Controls.Add(LblBirth);
            GrpNewUser.Controls.Add(DtpBirth);
            GrpNewUser.Controls.Add(TxtPassword);
            GrpNewUser.Controls.Add(LblPassword);
            GrpNewUser.Controls.Add(TxtEmail);
            GrpNewUser.Controls.Add(LblEmail);
            GrpNewUser.Controls.Add(TxtFirstName);
            GrpNewUser.Controls.Add(LblFirstName);
            GrpNewUser.Location = new Point(12, 12);
            GrpNewUser.Name = "GrpNewUser";
            GrpNewUser.Size = new Size(384, 178);
            GrpNewUser.TabIndex = 0;
            GrpNewUser.TabStop = false;
            GrpNewUser.Text = "New User";
            // 
            // ChkAdministrator
            // 
            ChkAdministrator.AutoSize = true;
            ChkAdministrator.Location = new Point(267, 92);
            ChkAdministrator.Name = "ChkAdministrator";
            ChkAdministrator.Size = new Size(99, 19);
            ChkAdministrator.TabIndex = 5;
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
            TxtConfirmPassword.TabIndex = 7;
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
            // BtnRegister
            // 
            BtnRegister.Location = new Point(277, 138);
            BtnRegister.Name = "BtnRegister";
            BtnRegister.Size = new Size(87, 24);
            BtnRegister.TabIndex = 8;
            BtnRegister.Text = "Register";
            BtnRegister.UseVisualStyleBackColor = true;
            BtnRegister.Click += BtnRegister_Click;
            // 
            // ChkActive
            // 
            ChkActive.AutoSize = true;
            ChkActive.Checked = true;
            ChkActive.CheckState = CheckState.Checked;
            ChkActive.Location = new Point(206, 92);
            ChkActive.Name = "ChkActive";
            ChkActive.Size = new Size(59, 19);
            ChkActive.TabIndex = 4;
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
            TxtPassword.TabIndex = 6;
            // 
            // LblPassword
            // 
            LblPassword.AutoSize = true;
            LblPassword.Location = new Point(15, 120);
            LblPassword.Name = "LblPassword";
            LblPassword.Size = new Size(57, 15);
            LblPassword.TabIndex = 4;
            LblPassword.Text = "Password";
            // 
            // TxtEmail
            // 
            TxtEmail.Location = new Point(15, 90);
            TxtEmail.MaxLength = 250;
            TxtEmail.Name = "TxtEmail";
            TxtEmail.Size = new Size(180, 23);
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
            // FormRegisterUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(410, 442);
            Controls.Add(PnlMain);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FormRegisterUser";
            Text = "User Registration";
            PnlMain.ResumeLayout(false);
            GrpNewUser.ResumeLayout(false);
            GrpNewUser.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel PnlMain;
        private GroupBox GrpNewUser;
        private Label LblFirstName;
        private TextBox TxtFirstName;
        private TextBox TxtPassword;
        private Label LblPassword;
        private TextBox TxtEmail;
        private Label LblEmail;
        private CheckBox ChkActive;
        private Label LblBirth;
        private DateTimePicker DtpBirth;
        private Button BtnRegister;
        private ListBox LstUsers;
        private TextBox TxtLastName;
        private Label LblLastName;
        private TextBox TxtConfirmPassword;
        private Label LblConfirmPassword;
        private Button BtnDeleteUser;
        private Button BtnEditUser;
        private Button BtnShowData;
        private CheckBox ChkAdministrator;
    }
}