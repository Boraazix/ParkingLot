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
    public partial class FormEditUser : Form
    {
        private static FormEditUser _instance;
        private static User _user;
        public FormEditUser()
        {
            InitializeComponent();

            this.Text =$"Editing User \"{_user.FirstName}\"";
            TxtFirstName.Text = _user.FirstName; TxtLastName.Text = _user.LastName;
            DtpBirth.Value = _user.Birth; TxtEmail.Text = _user.Email;
            ChkActive.Checked = _user.Active; ChkAdministrator.Checked = _user.Administrator;
        }
        public static FormEditUser GetInstance(User user)
        {
            _user = user;
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new FormEditUser();
            }
            _instance.MdiParent = FormMain.ActiveForm;
            _instance.WindowState = FormWindowState.Normal;
            return _instance;
        }

        private void BtnSaveChanges_Click(object sender, EventArgs e)
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
                    _user.FirstName = TxtFirstName.Text; _user.LastName = TxtLastName.Text; _user.Email = TxtEmail.Text; _user.Birth = DtpBirth.Value;
                    _user.Password = TxtPassword.Text; _user.Active = ChkActive.Checked; _user.Administrator = ChkAdministrator.Checked;
                    UserRepository.Save(_user);
                    FormRegisterUser.GetInstance().RefreshList();
                    MessageBox.Show($"User \"{TxtFirstName.Text}\" updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
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

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
