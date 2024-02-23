
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
    public partial class DaftarFrm : Form
    {

        BromoAirlinesEntities1 db = new BromoAirlinesEntities1();
        public DaftarFrm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if((textBox1.Text == string.Empty) || (textBox2.Text == string.Empty) || (textBox3.Text == string.Empty) || (textBox4.Text == string.Empty))
            {
                MessageBox.Show("Fields Tidak Boleh Kosong");
                return;
            }
            else if (!unik(textBox1.Text))
            {
                MessageBox.Show("Username Tersebut Sudah Terdaftar ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                int jumlah = textBox3.Text.Length;
                if(!Angka(textBox3.Text) || jumlah < 10 || jumlah > 15)
                {
                    MessageBox.Show("Nomor Telepon Yang Harus Diinputnkan Harus Angka Dan Minimal Panjangnya 10 Sampai 15 ","Informasi",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    return;
                }
                else if(textBox4.Text.Length < 8)
                {
                    MessageBox.Show("Password Akun Minimal Harus Berjumlah 8 Karakter","Informasi",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    return;
                }
              
                else
                {
                    Akun bb = new Akun()
                    {
                        Username = textBox1.Text,
                        Nama = textBox2.Text,
                        TanggalLahir = dateTimePicker1.Value,
                        NomorTelepon = textBox3.Text,
                        Password = textBox4.Text
                    };

                    db.Akun.Add(bb);   
                    db.SaveChanges();
                    CustomerFrm customerFrm = new CustomerFrm(bb.ID);
                    customerFrm.Show();
                    this.Hide();
                }
            }
        }

        private bool unik(string username)
        {
            return !db.Akun.Any(x => x.Username == username);
        }
        private bool Angka(string text)
        {
            return int.TryParse(text, out _);    
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Login().Show();
            this.Hide();
        }

        private void DaftarFrm_Load(object sender, EventArgs e)
        {
            dateTimePicker1.CustomFormat = "dd-MM-yyyy";
        }
    }
}
