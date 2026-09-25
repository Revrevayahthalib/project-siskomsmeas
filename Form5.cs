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
    public partial class Form5 : Form
    {
        db_siskom_smeasEntities db;
        public Form5()
        {
            InitializeComponent();
        }

        private void onload()
        {
            db = new db_siskom_smeasEntities();

            violationcategoriesBindingSource.DataSource = db.violation_categories.ToList();

            bindingSource1.DataSource = typeof(violation_categories);
            bindingSource1.Clear();
            bindingSource1.AddNew();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            onload();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex < 0) return;

            if (dataGridView1.Rows[e.RowIndex].DataBoundItem is violation_categories v)
            {
                if (e.ColumnIndex == editCol.Index) e.Value = "Edit";
                if (e.ColumnIndex == delCol.Index) e.Value = "Delete";
            }
        }

        private void ApplyFilter()
        {
            var query = db.violation_categories.AsQueryable();

            if(!string.IsNullOrEmpty(textBox1.Text.Trim()))
            {
                query = query.Where(x => x.category_name.Contains(textBox1.Text.Trim()));
            }
            violationcategoriesBindingSource.DataSource = query.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 0) return;

            if (dataGridView1.Rows[e.RowIndex].DataBoundItem is violation_categories v)
            {
                db = new db_siskom_smeasEntities();
                var datavicat = db.violation_categories.FirstOrDefault(x => x.id_category == v.id_category);

                if (e.ColumnIndex == editCol.Index)
                {
                    bindingSource1.Clear();
                    bindingSource1.DataSource = datavicat;
                }
                if (e.ColumnIndex == delCol.Index)
                {
                    var confirm = MessageBox.Show("Yakin ingin menghapus data?", "peringatan", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (confirm == DialogResult.Yes)
                    {
                        db.violation_categories.Remove(datavicat);
                        db.SaveChanges();
                        MessageBox.Show("Data berhasil dihapus");
                        onload();
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!ValidationHelper.ValidateAllRequired(this.Controls, new List<Control> { textBox1 }))
            {
                return;
            }

            bindingSource1.EndEdit();

            if (bindingSource1.Current is violation_categories v)
            db.violation_categories.AddOrUpdate(v);
            db.SaveChanges();
            MessageBox.Show("Data berhasil disimpan");
            onload();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bindingSource1.Clear();
            onload();
        }

        private void default_pointTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Harus mengisi dengan angka", "Peringatan", MessageBoxButtons.OK ,MessageBoxIcon.Warning);
            }
        }

        
    }
}
