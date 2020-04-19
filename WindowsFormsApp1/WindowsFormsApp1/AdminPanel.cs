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
    public partial class AdminPanel : Form
    {
        private readonly Form _login;
        private readonly UsersDbEntities _db;
        private enum Previligies {ToAdmin,Activate,Delete};
        public AdminPanel(Form login)
        {
            InitializeComponent();
            _db = new UsersDbEntities();
            _login = login;
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {
            _login.Hide();
            dgvRefresh("New Users","New Users",false,false);
        }

        private void AdminPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            _login.Close();
        }

        private void dgvUsers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            txtUserEmail.Text = dgvUsers.Rows[e.RowIndex].Cells[2].Value.ToString();
            cmbPrevilieges.DataSource = Enum.GetValues(typeof(Previligies));
        }

        private void dgvRefresh(string user,string labelUserCount,bool Active=false,bool Deleted=false)
        {
            lblUserCount.Text = labelUserCount;
            usersCount.Text = _db.Users.Count(u => u.IsActivated == Active && u.IsDeleted == Deleted).ToString();
            dgvUsers.DataSource = _db.Users.Where(u => u.IsActivated == Active && u.IsDeleted == Deleted).
           Select(u => new
           {
               u.Id,
               u.Fullname,
               u.Email,
               u.IsActivated
           }).ToList();
            lblUsers.Text = user;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            User user = _db.Users.First(u => u.Email == txtUserEmail.Text.Trim());
            int priviliege = cmbPrevilieges.SelectedIndex;
            switch (priviliege)
            {
                case (int)Previligies.Activate:
                    user.IsActivated = true;
                    user.IsDeleted = false;
                        break;
                case (int)Previligies.ToAdmin:
                    user.IsActivated = true;
                    user.IsAdmin = true;
                    user.IsDeleted = false;
                        break;
                case (int)Previligies.Delete:
                    user.IsDeleted = true;
                    user.IsActivated = false;
                    user.IsAdmin = false;
                    break;
                default:
                    break;
            }

            await _db.SaveChangesAsync();
            txtUserEmail.Text = "";
            if(lblUsers.Text=="New Users")
            {
                dgvRefresh("New Users","New Users", false, false);
            }
            else if(lblUsers.Text=="Active Users")
            {
                dgvRefresh("Active Users","Active Users", true, false);
            }
            else
            {
                dgvRefresh("Deleted Users","Deleted Users",false, true);
            }
            cmbPrevilieges.DataSource = null;
        }

        private void newUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgvRefresh("New Users","New Users", false, false);
        }

        private void activeUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgvRefresh("Active Users","Active Users", true, false);

        }

        private void deletedUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgvRefresh("Deleted Users","Deleted Users", false, true);
        }

        private void createTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateType create = new CreateType();
            create.ShowDialog();
        }

        private void deleteTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteType delete = new DeleteType();
            delete.ShowDialog();
        }
    }
}
