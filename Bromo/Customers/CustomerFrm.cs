using Bromo.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Bromo
{
    public partial class CustomerFrm : Form
    {

        int id;
        BromoAirlinesEntities1 db = new BromoAirlinesEntities1();
        public CustomerFrm(int id)
        {
            InitializeComponent();

            this.id = id;
            var namaakun = db.Akun.FirstOrDefault(f => f.ID == id);
            label2.Text = $"Mau terbang ke mana hari ini , {namaakun.Nama} ?";
        }


        private void CustomerFrm_Load(object sender, EventArgs e)
        {
            AutoCompleteStringCollection collection1 = new AutoCompleteStringCollection();
            AutoCompleteStringCollection collection2 = new AutoCompleteStringCollection();

            List<Bandara> p = db.Bandara.ToList();

            foreach (var d in p)
            {
                collection1.Add($"{d.Nama}, {d.Alamat} ({d.KodeIATA})");
                collection2.Add($"{d.Nama}, {d.Alamat} ({d.KodeIATA})");
            }

            textBox1.AutoCompleteCustomSource = collection1;
            textBox2.AutoCompleteCustomSource = collection2;

        }
        void openForm<T>(T form) where T : Form
        {
            form.Show();
            form.FormClosed += formClosed;
            Hide();
        }

        void formClosed(object sender, FormClosedEventArgs e)
        {
            Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == string.Empty) || (textBox2.Text == string.Empty))
            {
                MessageBox.Show("Fields Tidak Boleh Kosong");
                return;
            }
            else if(textBox1.Text == textBox2.Text)
            {
                MessageBox.Show("Bandara Keberangkatan Dan Tujuan Tidak Boleh Sama","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            else
            {
              
                string BandaraASal = textBox1.Text.Split(',')[0].Trim();    
                string kodeIATAasal = textBox1.Text.Split('(', ')')[1];

                
                string bandaratj = textBox2.Text.Split(',')[0].Trim(); 
                string kodeIATA2 = textBox2.Text.Split('(', ')')[1];

                openForm(new ListPenerbangan(BandaraASal, kodeIATAasal, bandaratj, kodeIATA2,dateTimePicker1.Value, (int)numericUpDown1.Value, id));
            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            openForm(new TiketSaya(id));
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            var akun = db.Akun.FirstOrDefault(f => f.ID == id);
            DialogResult dr = MessageBox.Show($"Apakah Anda Yakin Akan Logout Dari Form Ini {akun.Nama}", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Login lgn = new Login();
                lgn.Show();
                this.Close();
            }
        }
    }
}
