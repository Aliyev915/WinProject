using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1
{
    public partial class Register : Form
    {
        private readonly Form _login;
        private readonly UsersDbEntities _db;
        public Register(Form login)
        {
            InitializeComponent();
            _login = login;
            _db = new UsersDbEntities();
        }

        private void Register_FormClosing(object sender, FormClosingEventArgs e)
        {
            _login.Show();
        }

        private async void btnLoginRegister_Click(object sender, EventArgs e)
        {
            string email = txtRegisterEmail.Text.Trim();
            string fullname = txtFullname.Text.Trim();
            string password = txtRegisterPssw.Text.Trim();
            string confirmPsw = txtRegisterConfirmPssw.Text.Trim();

            if (IsValid(email, fullname, password, confirmPsw) == false)
            {
                return;
            }

            User user = new User
            {
                Email=email,
                Fullname=fullname,
                Password=password.HashPassword()
            };

            bool UserInDb = _db.Users.Any(u => u.Email == email);

            if (UserInDb == true)
            {
                MessageBox.Show("This email is existed in Database", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _db.Users.Add(user);
            await _db.SaveChangesAsync();
            MessageBox.Show("Succesfully register", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            this.Close();
        }

        private bool IsValid(string email,string fullname,string password,string confirm)
        {
            if (email == "" || fullname == "" || password == "" || confirm == "")
            {
                MessageBox.Show("All fields must be filled", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (email.IsEmail()==false)
            {
                MessageBox.Show("Email is not correct format", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (password.Length < 8)
            {
                MessageBox.Show("Password consist of 8 symbols at least", "Warning",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!(char.IsUpper(password[0])))
            {
                MessageBox.Show("Password must begin with uppercase letter", "Warning",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (password != confirm)
            {
                MessageBox.Show("Please, confirm password", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void txtRegisterEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtFullname.Focus();
            }
        }

        private void txtFullname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtRegisterPssw.Focus();
            }
        }

        private void txtRegisterPssw_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtRegisterConfirmPssw.Focus();
            }
        }

        private void txtRegisterConfirmPssw_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLoginRegister.PerformClick();
            }
        }
    }
}
