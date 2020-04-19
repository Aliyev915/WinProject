using System;
using WindowsFormsApp1.Models;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Login : Form
    {
        private readonly UsersDbEntities _db;
        public Login()
        {
            InitializeComponent();
            _db = new UsersDbEntities();
            
        }

        private void btnLoginRegister_Click(object sender, EventArgs e)
        {
            Register register = new Register(this);
            register.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtLoginEmail.Text.Trim();
            string password = txtLoginPassword.Text.Trim();
            User ExistEmail =_db.Users.FirstOrDefault(u => u.Email == email);
            if (email == "" || password == "")
            {
                MessageBox.Show("All fields must be filled", "Warning",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(!IsValid(ExistEmail, password))
            {
                return;
            }

            if (ExistEmail.IsAdmin)
            {
                AdminPanel admin = new AdminPanel(this);
                admin.Show();
                return;
            }
            UsersPage userPage = new UsersPage();
            userPage.Show();

        }

        private bool IsValid(User user,string password)
        {
            if (user == null)
            {
                MessageBox.Show("This user is not exist in Database", "Warning",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (password.HashPassword() != user.Password)
            {
                MessageBox.Show("Password is not correct", "Warning",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (user.IsActivated == false && user.IsDeleted==false)
            {
                MessageBox.Show("Please,wait...", "Warning",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (user.IsActivated==false && user.IsDeleted == true)
            {
                MessageBox.Show("Your account is deleted", "Warning",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void txtLoginEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtLoginPassword.Focus();
            }
        }

        private void txtLoginPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }
    }
}
