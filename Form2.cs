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
    public partial class Form2 : Form
    {
        db_siskom_smeasEntities db = new db_siskom_smeasEntities();
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            new Form3().ShowDialog();
            Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            new Form4().ShowDialog();
            Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            new Form5().ShowDialog();
            Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UserSession.userID = 0;
            UserSession.fullName = null;
            UserSession.role = null;
            Close();
            new Form1().ShowDialog();
            Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            var user = db.users.FirstOrDefault(x => x.id_user == UserSession.userID);

            label1.Text = $"Halo, {user.full_name}";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
