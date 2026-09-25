using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LKS_ITSoftware
{
    public partial class Form1 : Form
    {
        db_siskom_smeasEntities db = new db_siskom_smeasEntities();
        public Form1()
        {
            InitializeComponent();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            if(!ValidationHelper.ValidateAllRequired(this.Controls))
            {
                return;
            }

            var userCheck = db.users.FirstOrDefault(u => u.username == usernameTextBox.Text && u.password == passwordTextBox.Text);

            if(userCheck == null)
            {
                MessageBox.Show("Akun tidak ditemukan");
                return;
            }
            
                UserSession.userID = userCheck.id_user;
                UserSession.fullName = userCheck.full_name;
                Hide();
                if (userCheck.role == "Admin")
                {
                    
                    Hide();
                    new Form2().ShowDialog();
                    Show();
                }
                else
                {
                    Hide();
                    new Form6().ShowDialog();
                    Show();
                }
            }
        

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            passwordTextBox.UseSystemPasswordChar = !checkBox1.Checked;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
