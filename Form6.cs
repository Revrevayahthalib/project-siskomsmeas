using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LKS_ITSoftware
{
    public partial class Form6 : Form
    {
        db_siskom_smeasEntities db;
        public Form6()
        {
            InitializeComponent();
        }

        private void onload()
        {
            db = new db_siskom_smeasEntities();

            violationrecordsBindingSource.DataSource = db.violation_records.ToList();
            studentsBindingSource.DataSource = db.students.ToList();
            violationcategoriesBindingSource.DataSource = db.violation_categories.ToList();

            bindingSource1.DataSource = typeof(violation_records);
            bindingSource1.Clear();
            bindingSource1.AddNew();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            onload();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex < 0) return;

            if (dataGridView1.Rows[e.RowIndex].DataBoundItem is violation_records v)
            {
                if (e.ColumnIndex == idstudentDataGridViewTextBoxColumn.Index) e.Value = v.student.full_name;
                if (e.ColumnIndex == idreporteruserDataGridViewTextBoxColumn.Index) e.Value = v.user.full_name;
                if (e.ColumnIndex == idcategoryDataGridViewTextBoxColumn.Index) e.Value = v.violation_categories.category_name;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bindingSource1.Clear();
            onload();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!ValidationHelper.ValidateAllRequired(this.Controls))
            {
                return;
            }

            bindingSource1.EndEdit();

            if (bindingSource1.Current is violation_records vi)
            {

                vi.id_reporter_user = UserSession.userID;
              
                try
                {
                    db.violation_records.AddOrUpdate(vi);
                    db.SaveChanges();
                    MessageBox.Show("Data berhasil disimpan");
                    onload();
                }
                catch (System.Data.Entity.Infrastructure.DbUpdateException ex)
                {
                    MessageBox.Show(ex.InnerException?.InnerException?.Message ?? ex.Message);
                }
                
            }
            
        }
    }
}
