
using Bromo.Masters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bromo
{
    public partial class Login : Form
    {
        BromoAirlinesEntities1 db = new BromoAirlinesEntities1();  
        public Login()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            //admin
            /*  textBox1.Text = "admin";
              textBox2.Text = "admin123";*/

            //customer
            textBox1.Text = "el";
            textBox2.Text = "mdwikurniawan";
        }

        void openForm<T>(T form) where T : Form
        {
            form.Show();
            form.FormClosed += formClosed;
            Hide();
        }

        void  formClosed(object sender, FormClosedEventArgs e)
        {
            Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == string.Empty)
            {
                MessageBox.Show("Username Tidak Boleh Kosong");
                return;
            }
            else if (textBox2.Text == string.Empty)
            {
                MessageBox.Show("Password Tidak Boleh Kosong");
                return;
            }
            else
            {
                var user = db.Akun.Where(f=> f.Username == textBox1.Text && f.Password == textBox2.Text).FirstOrDefault();
                if (user != null)
                {
                    if(user.MerupakanAdmin == true)
                    {
                        AdminMainFrm mm =  new AdminMainFrm(user.Nama);  
                        mm.Show();
                        this.Hide();    
                    }
                    else
                    {
                        CustomerFrm mm = new CustomerFrm(user.ID); 
                        mm.Show();
                        this.Hide();        
                    }
                }
                else
                {
                    MessageBox.Show("Username Atau Password Salah");
                    return;
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openForm(new DaftarFrm());
        }
    }
}
