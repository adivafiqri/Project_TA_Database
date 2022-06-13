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
    public partial class Form1 : Form
    {
        private readonly TAEntities _Ta;
       
        public Form1()
        {
            InitializeComponent();
            _Ta = new TAEntities(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {

            var vuser = textBox1.Text.ToLower();
            var vpassword = textBox2.Text;

            var resultMhs = _Ta.tbl_mhs.FirstOrDefault(q => q.email.ToLower() == vuser);

            if (resultMhs == null)
            {
                var resultDosen = _Ta.tbl_dosen.FirstOrDefault(q => q.email.ToLower() == vuser);
                if (resultDosen == null)
                {
                    MessageBox.Show("Username/Password Salah!");
                }
                else if (resultDosen.password.Trim() == vpassword)
                {
                    MessageBox.Show($"Berhasil login!");
                    var FormDashboard = new Dashboard(vuser, resultMhs.nama, "dosen");
                    FormDashboard.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Password Salah!");
                }
            }
            else if(resultMhs.password.Trim() == vpassword)
            {
                MessageBox.Show($"Berhasil login!");
                var FormDashboard = new Dashboard(vuser, resultMhs.nama, "mhs");
                FormDashboard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Password Salah!");
            }
        }
    }
}
