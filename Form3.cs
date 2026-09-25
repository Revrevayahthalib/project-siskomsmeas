using LKS_ITSoftware.db_siskom_smeasDataSetTableAdapters;
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
    public partial class Form3 : Form
    {
        db_siskom_smeasEntities db;
        public Form3()
        {
            InitializeComponent();
        }

        private void onload()
        {
            db = new db_siskom_smeasEntities();

            studentsBindingSource.DataSource = db.students.ToList();
            classesBindingSource.DataSource = db.classes.ToList();

            bindingSource1.DataSource = typeof(student);
            bindingSource1.Clear();
            bindingSource1.AddNew();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            onload();

        }

        private void ApplyFilter()
        {
            var query = db.students.AsQueryable();

            if(!string.IsNullOrEmpty(textBox1.Text.Trim()))
            {
                query = query.Where(x => x.full_name.Contains(textBox1.Text.Trim()) || x.nisn.Contains(textBox1.Text.Trim()));
            }
            if(comboBox1.SelectedValue != null)
            {
                query = query.Where(x => x.id_class == (int)comboBox1.SelectedValue);
            }

            studentsBindingSource.DataSource = query.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ApplyFilter();
        }


        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex < 0) return;

            if (dataGridView1.Rows[e.RowIndex].DataBoundItem is student s)
            {
                if (e.ColumnIndex == idclassDataGridViewTextBoxColumn.Index) e.Value = s.@class.class_name;
                if (e.ColumnIndex == editCol.Index) e.Value = "Edit";
                if (e.ColumnIndex == delCol.Index) e.Value = "Delete";
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 0) return;

            if (dataGridView1.Rows[e.RowIndex].DataBoundItem is student s)
            {
                db = new db_siskom_smeasEntities();
                var datastud = db.students.FirstOrDefault(x => x.id_student == s.id_student);

                if (e.ColumnIndex == editCol.Index)
                {
                    bindingSource1.Clear();
                    bindingSource1.DataSource = datastud;
                }
                if (e.ColumnIndex == delCol.Index)
                {
                    var confirm = MessageBox.Show("Yakin ingin menghapus data?","peringatan", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if(confirm == DialogResult.Yes)
                    {
                        db.students.Remove(datastud);
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
            if(!ValidationHelper.ValidateAllRequired(this.Controls, new List<Control> {textBox1, comboBox1}))
            {
                return;
            }

            string nis = nisnTextBox.Text.Trim();
            
            if(nis.Length != 10)
            {
                MessageBox.Show("NISN harus berisi 10 angka");
                nisnTextBox.Focus();
                return;
            }



            bindingSource1.EndEdit();

            if (bindingSource1.Current is student s)
            {
                bool isDuplicate = db.students.Any(x => x.nisn == nisnTextBox.Text && x.id_student != s.id_student);

                if (isDuplicate)
                {
                    MessageBox.Show("NISN sudah terdaftar untuk siswa lain");
                    nisnTextBox.Focus();
                    return;
                }

                try
                {
                    db.students.AddOrUpdate(s);
                    db.SaveChanges();
                    MessageBox.Show("Data berhasil disimpan");
                    onload();
                }
                catch
                {

                }
                    
               
                
            }
            
            
        }

       
        private void nisnTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Harus mengisi dengan angka", "Peringatan", MessageBoxButtons.OK ,MessageBoxIcon.Warning);
            }
        }

        
        
    }
}
