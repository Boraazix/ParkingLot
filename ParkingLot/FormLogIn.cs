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
    public partial class FormLogin : Form
    {
        private static FormLogin _instance;
        public FormLogin()
        {
            InitializeComponent();
        }
        public static FormLogin GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new FormLogin();
            }
            _instance.WindowState = FormWindowState.Normal;
            return _instance;
        }

        private void ChkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkShowPassword.Checked)
                TxtPassword.PasswordChar = '\0';
            else
                TxtPassword.PasswordChar = '*';
        }
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            Authenticate();
        }
        private void Authenticate()
        {
            try
            {
                if (TxtEmail.Text == "")
                {
                    MessageBox.Show("Email not entered!", "Something is wrong :/", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    TxtEmail.Focus();
                    TxtEmail.SelectAll();
                }
                else if (TxtPassword.Text == "")
                {
                    MessageBox.Show("Password not entered!", "Something is wrong :/", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    TxtPassword.Focus();
                    TxtPassword.SelectAll();
                }
                else
                {
                    if (UserRepository.ValidateUser(TxtEmail.Text, TxtPassword.Text))
                    {
                        TxtEmail.Focus();
                        this.Hide();
                        TxtEmail.SelectAll();
                        TxtPassword.Text = "";
                        FormMain.GetInstance().Show();
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Something is wrong :/", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                if (ex.GetType() == typeof(InvalidDataException))
                {
                    TxtPassword.Text = string.Empty;
                    TxtEmail.Focus();
                    TxtEmail.SelectAll();
                }
                else if (ex.GetType() == typeof(UnauthorizedAccessException))
                {
                    TxtPassword.Focus();
                    TxtPassword.SelectAll();
                }
            }
        }

        private void TxtPassword_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Authenticate();
            }
        }

        private void FormLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
