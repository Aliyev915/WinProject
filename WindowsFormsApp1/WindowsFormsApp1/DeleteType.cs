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
    public partial class DeleteType : Form
    {
        private readonly UsersDbEntities _db;
        public DeleteType()
        {
            InitializeComponent();
            _db = new UsersDbEntities();
        }

        private async void btnDeleteType_Click(object sender, EventArgs e)
        {
            int Id = ((CmbTypes)cmbTypes.SelectedItem).Id;
            MedicineType type = _db.MedicineTypes.Find(Id);
            type.Deleted = true;
            await _db.SaveChangesAsync();
            this.Close();
        }

        private void DeleteType_Load(object sender, EventArgs e)
        {
            cmbTypes.DataSource = _db.MedicineTypes.Where(t=>t.Deleted==false).Select(t => new CmbTypes
            {
                Id=t.Id,
                typeName = t.typeName
            }).ToArray();
        }
    }
}
