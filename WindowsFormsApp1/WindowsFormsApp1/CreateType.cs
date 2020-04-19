using WindowsFormsApp1.Models;
using System;
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
    public partial class CreateType : Form
    {
        private readonly UsersDbEntities _db;
        public CreateType()
        {
            InitializeComponent();
            _db = new UsersDbEntities();
        }

        private async void btnCreateType_Click(object sender, EventArgs e)
        {
            string TypeName =txtCreateType.Text.Trim();
            if (TypeName == "")
            {
                MessageBox.Show("The field must be filled", "Warning", 
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (_db.MedicineTypes.Any(t => t.typeName == TypeName))
            {
                MessageBox.Show("This type is already exist", "Warning",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            MedicineType type = new MedicineType
            {
                typeName=TypeName
            };
            _db.MedicineTypes.Add(type);
            await _db.SaveChangesAsync();
            this.Close();
        }
    }
}
