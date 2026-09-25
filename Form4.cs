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

namespace LKS_ITSoftware
{
    public partial class Form4 : Form
    {
        db_siskom_smeasEntities db;
        public Form4()
        {
            InitializeComponent();
        }

        private void onload()
        {
            db = new db_siskom_smeasEntities();

            classesBindingSource.DataSource = db.classes.ToList();

            bindingSource1.DataSource = typeof(@class);
            bindingSource1.Clear();
            bindingSource1.AddNew();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            onload();
        }

        private void ApplyFilter()
        {
            var query = db.classes.AsQueryable();

            if(!string.IsNullOrEmpty(textBox1.Text.Trim()))
            {
                query = query.Where(x => x.class_name.Contains(textBox1.Text.Trim()));
            }
            classesBindingSource.DataSource = query.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex < 0) return;

            if (dataGridView1.Rows[e.RowIndex].DataBoundItem is @class c)
            {
                if (e.ColumnIndex == editCol.Index) e.Value = "Edit";
                if (e.ColumnIndex == delCol.Index) e.Value = "Delete";
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 0) return;

            if (dataGridView1.Rows[e.RowIndex].DataBoundItem is @class c)
            {
                db = new db_siskom_smeasEntities();
                var dataclass = db.classes.FirstOrDefault(x => x.id_class == c.id_class);

                if (e.ColumnIndex == editCol.Index)
                {
                    bindingSource1.Clear();
                    bindingSource1.DataSource = dataclass;
                }
                if (e.ColumnIndex == delCol.Index)
                {
                    var confirm = MessageBox.Show("Yakin ingin menghapus data?", "peringatan", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (confirm == DialogResult.Yes)
                    {
                        db.classes.Remove(dataclass);
                        db.SaveChanges();
                        MessageBox.Show("Data berhasil dihapus");
                        onload();
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bindingSource1.Clear();
            onload();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!ValidationHelper.ValidateAllRequired(this.Controls, new List<Control> { textBox1 }))
            {
                return;
            }

            bindingSource1.EndEdit();

            if (bindingSource1.Current is @class c)
            db.classes.AddOrUpdate(c);
            db.SaveChanges();
            MessageBox.Show("Data berhasil disimpan");
            onload();
        }
    }
}
