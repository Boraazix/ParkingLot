namespace ParkingLot
{
    partial class FormLogin
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
            ChkShowPassword = new CheckBox();
            BtnLogin = new Button();
            TxtPassword = new TextBox();
            LblPassword = new Label();
            TxtEmail = new TextBox();
            LblEmail = new Label();
            LblSignIn = new Label();
            PnlMain.SuspendLayout();
            SuspendLayout();
            // 
            // PnlMain
            // 
            PnlMain.Controls.Add(ChkShowPassword);
            PnlMain.Controls.Add(BtnLogin);
            PnlMain.Controls.Add(TxtPassword);
            PnlMain.Controls.Add(LblPassword);
            PnlMain.Controls.Add(TxtEmail);
            PnlMain.Controls.Add(LblEmail);
            PnlMain.Controls.Add(LblSignIn);
            PnlMain.Location = new Point(0, 0);
            PnlMain.Name = "PnlMain";
            PnlMain.Size = new Size(227, 277);
            PnlMain.TabIndex = 0;
            // 
            // ChkShowPassword
            // 
            ChkShowPassword.AutoSize = true;
            ChkShowPassword.Location = new Point(55, 178);
            ChkShowPassword.Name = "ChkShowPassword";
            ChkShowPassword.Size = new Size(108, 19);
            ChkShowPassword.TabIndex = 2;
            ChkShowPassword.Text = "Show Password";
            ChkShowPassword.UseVisualStyleBackColor = true;
            ChkShowPassword.CheckedChanged += ChkShowPassword_CheckedChanged;
            // 
            // BtnLogin
            // 
            BtnLogin.Font = new Font("Segoe UI", 10F);
            BtnLogin.Location = new Point(60, 218);
            BtnLogin.Name = "BtnLogin";
            BtnLogin.Size = new Size(95, 29);
            BtnLogin.TabIndex = 3;
            BtnLogin.Text = "Login";
            BtnLogin.UseVisualStyleBackColor = true;
            BtnLogin.Click += BtnLogin_Click;
            // 
            // TxtPassword
            // 
            TxtPassword.Font = new Font("Segoe UI", 10F);
            TxtPassword.Location = new Point(22, 147);
            TxtPassword.MaxLength = 250;
            TxtPassword.Name = "TxtPassword";
            TxtPassword.PasswordChar = '*';
            TxtPassword.PlaceholderText = "******";
            TxtPassword.Size = new Size(179, 25);
            TxtPassword.TabIndex = 1;
            TxtPassword.Text = "adm12345";
            TxtPassword.KeyUp += TxtPassword_KeyUp;
            // 
            // LblPassword
            // 
            LblPassword.AutoSize = true;
            LblPassword.Location = new Point(22, 129);
            LblPassword.Name = "LblPassword";
            LblPassword.Size = new Size(57, 15);
            LblPassword.TabIndex = 3;
            LblPassword.Text = "Password";
            // 
            // TxtEmail
            // 
            TxtEmail.CharacterCasing = CharacterCasing.Lower;
            TxtEmail.Font = new Font("Segoe UI", 10F);
            TxtEmail.Location = new Point(22, 89);
            TxtEmail.MaxLength = 250;
            TxtEmail.Name = "TxtEmail";
            TxtEmail.PlaceholderText = "Enter your Email";
            TxtEmail.Size = new Size(179, 25);
            TxtEmail.TabIndex = 0;
            TxtEmail.Text = "adm@mail.com";
            // 
            // LblEmail
            // 
            LblEmail.AutoSize = true;
            LblEmail.Location = new Point(22, 71);
            LblEmail.Name = "LblEmail";
            LblEmail.Size = new Size(36, 15);
            LblEmail.TabIndex = 1;
            LblEmail.Text = "Email";
            // 
            // LblSignIn
            // 
            LblSignIn.AutoSize = true;
            LblSignIn.Font = new Font("Segoe UI", 13F);
            LblSignIn.Location = new Point(75, 25);
            LblSignIn.Name = "LblSignIn";
            LblSignIn.Size = new Size(67, 25);
            LblSignIn.TabIndex = 0;
            LblSignIn.Text = "Sign In";
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(227, 277);
            Controls.Add(PnlMain);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormLogin";
            Text = "Login";
            FormClosed += FormLogin_FormClosed;
            PnlMain.ResumeLayout(false);
            PnlMain.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel PnlMain;
        private Label LblEmail;
        private Label LblSignIn;
        private TextBox TxtPassword;
        private Label LblPassword;
        private TextBox TxtEmail;
        private Button BtnLogin;
        private CheckBox ChkShowPassword;
    }
}