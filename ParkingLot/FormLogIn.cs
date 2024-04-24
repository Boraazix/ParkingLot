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
        public FormLogin()
        {
            InitializeComponent();
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
                    //

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Something is wrong :/", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtPassword.Text = string.Empty;
                TxtEmail.Focus();
                TxtEmail.SelectAll();
            }
        }

        private void TxtPassword_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Authenticate();
            }
        }
    }
}
