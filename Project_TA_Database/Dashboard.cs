using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_TA_Database
{
    public partial class Dashboard : Form
    {
        private string vuser;
        private string nama;
        private string role;
        

        public Dashboard(string vuser, string nama, string role)
        {
            InitializeComponent();
            this.vuser = vuser;
            this.nama = nama;
            this.role = role;
            
        }


        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            
            MessageBox.Show($"Selamat datang {nama}");
        }

        private void profilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var FormProfile = new Profile(vuser, role);
            FormProfile.Show();
            this.Hide();
        }
    }
}
