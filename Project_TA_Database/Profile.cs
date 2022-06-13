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
    public partial class Profile : Form
    {
        private string vuser;
        private string role;
        private readonly TAEntities _Ta;
        public Profile(string vuser, string role)
        {
            InitializeComponent();
            _Ta = new TAEntities();
            this.vuser = vuser;
            this.role = role;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string vPasslama = textBox1.Text;
            string vPassBaru = textBox2.Text;
            string vpassConfirm = textBox3.Text;


            if (role == "mhs")
            {
                var resultMhs = _Ta.tbl_mhs.FirstOrDefault(q => q.email.ToLower() == vuser);
                if (resultMhs.password.Trim() != vPasslama)
                {
                    MessageBox.Show("Password Lama salah !");
                }
                else if (vPassBaru != vpassConfirm) { 

                    MessageBox.Show("Repeat Password tidak match !");
                }
                else
                {
                    resultMhs.password = vPassBaru;
                    _Ta.SaveChanges();
                    MessageBox.Show("Password Berhasil Terganti !");
                }
             
                
            }
            else if(role == "dosen")
            {
                var resultDosen = _Ta.tbl_dosen.FirstOrDefault(q => q.email == vuser);
            }
            
            
            
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            MessageBox.Show($"role anda {role}");
            MessageBox.Show($"Email anda {vuser}");
        }
    }
}
