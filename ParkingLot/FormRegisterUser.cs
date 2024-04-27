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
    public partial class FormRegisterUser : Form
    {
        private static FormRegisterUser _instance;
        public FormRegisterUser()
        {
            InitializeComponent();
            LstUsers.DataSource = UserRepository.FindAll();
        }
        public static FormRegisterUser GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new FormRegisterUser();
            }
            _instance.MdiParent = FormMain.ActiveForm;
            _instance.WindowState = FormWindowState.Normal;
            return _instance;
        }
        public void RefreshList()
        {
            LstUsers.DataSource = UserRepository.FindAll();
        }
        private void BtnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtFirstName.Text == "")
                {
                    MessageBox.Show("First Name not entered!", "Something is wrong :/", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    TxtFirstName.Focus();
                }
                else if (TxtLastName.Text == "")
                {
                    MessageBox.Show("Last Name not entered!", "Something is wrong :/", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    TxtLastName.Focus();
                }
                else if (TxtEmail.Text == "")
                {
                    MessageBox.Show("Email not entered!", "Something is wrong :/", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    TxtEmail.Focus();
                }
                else if (TxtPassword.Text == "")
                {
                    MessageBox.Show("Password not entered!", "Something is wrong :/", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    TxtPassword.Focus();
                }
                else if (TxtConfirmPassword.Text == "")
                {
                    MessageBox.Show("Repeat the password in the \"Confirm Password\" field!", "Something is wrong :/", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    TxtConfirmPassword.Focus();
                }
                else if (TxtPassword.Text != TxtConfirmPassword.Text)
                {
                    MessageBox.Show("The Passwords entered do not match!", "Something is wrong :/", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    TxtConfirmPassword.Focus();
                    TxtConfirmPassword.SelectAll();
                }
                else
                {
                    UserRepository.Save(new User(TxtFirstName.Text, TxtLastName.Text, TxtEmail.Text, DtpBirth.Value, TxtPassword.Text, ChkActive.Checked, ChkAdministrator.Checked));
                    LstUsers.DataSource = UserRepository.FindAll();
                    MessageBox.Show($"User \"{TxtFirstName.Text}\" successfully registered.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TxtFirstName.Text = ""; TxtLastName.Text = ""; TxtPassword.Text = ""; ChkActive.Checked = true; ChkAdministrator.Checked = false;
                    TxtEmail.Text = ""; DtpBirth.Value = DateTime.Now; TxtFirstName.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Something is wrong :/", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                if (ex.GetType() == typeof(DuplicateNameException))
                {
                    TxtEmail.Focus();
                    TxtEmail.SelectAll();
                }
            }
        }

        private void BtnShowData_Click(object sender, EventArgs e)
        {
            if (LstUsers.SelectedIndex >= 0)
            {
                User user = (User)LstUsers.SelectedItem;
                MessageBox.Show($"User ID: {user.UserId}\nFirst Name: {user.FirstName}\nLast Name: {user.LastName}\nBirth date: {user.Birth.ToString("MM/dd/yyyy")}\nEmail: {user.Email}\nActive: {(user.Active ? "Yes" : "No")}\nAdministrator: {(user.Administrator ? "Yes" : "No")}", $"{user.FirstName} data", MessageBoxButtons.OK);
            }
        }

        private void BtnDeleteUser_Click(object sender, EventArgs e)
        {
            try
            {
                if (LstUsers.SelectedIndex >= 0)
                {
                    User user = (User)LstUsers.SelectedItem;
                    if (MessageBox.Show($"Do you want to delete the user \"{user.FirstName} {user.LastName}\"?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        UserRepository.Remove(user);
                        LstUsers.DataSource = UserRepository.FindAll();
                        MessageBox.Show($"User \"{user.FirstName} {user.LastName}\" successfully deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Something is wrong :/", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void BtnEditUser_Click(object sender, EventArgs e)
        {
            if (LstUsers.SelectedIndex >= 0)
            {
                FormEditUser.GetInstance((User)LstUsers.SelectedItem).Show();
            }
        }
    }
}
