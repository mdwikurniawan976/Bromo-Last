using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Bromo.Customers
{
    public partial class BeliTiket : Form
    {
        private int jumlahPenumpang;
        private string BandaraASal;
        private string bandaratj;
        private string kodeIATAasal;
        private  string kodeIATA2;
        int id;
        int jadwalid;
        private DateTime tanggalKeberangkatan;
        private double hargaPertiket; 
        private string maskapai;
        private string waktuPenerbangan; 

        BromoAirlinesEntities1 db = new BromoAirlinesEntities1 ();
        public BeliTiket(int jumlahPenumpang, string BandaraASal, string bandaratj, string kodeIATAasal , string kodeIATA2,DateTime tanggalKeberangkatan, double hargaPertiket, string maskapai, string waktuPenerbangan, int id, int jadwalid)
        {
            InitializeComponent();
            this.jumlahPenumpang = jumlahPenumpang;
            this.id = id;
            this.jadwalid = jadwalid;
            this.BandaraASal = BandaraASal;
            this.bandaratj = bandaratj;
            this.kodeIATA2 = kodeIATA2; 
            this.kodeIATAasal = kodeIATAasal;
            this.tanggalKeberangkatan = tanggalKeberangkatan;
            this.hargaPertiket = hargaPertiket; // Inisialisasi hargaPertiket
            this.maskapai = maskapai; // Inisialisasi maskapai
            this.waktuPenerbangan = waktuPenerbangan; // 

            label4.Text = $"{BandaraASal}  ({kodeIATAasal})";
            label5.Text = $"{bandaratj}  ({kodeIATA2})";
            label6.Text = maskapai;
            label9.Text = waktuPenerbangan;
            label8.Text = tanggalKeberangkatan.ToString("ddd, dd MMM yyyy");
          
            label10.Text = jumlahPenumpang + " Penumpang";
            double total = hargaPertiket * jumlahPenumpang;

         
            string formattedTotal = total.ToString("C0", new CultureInfo("id-ID"));

          
            label13.Text = formattedTotal;
        }

        void loadusercontrol()
        {
            flowLayoutPanel1.Controls.Clear();
            for (int i = 0; i < jumlahPenumpang; i++)
            {
                DetailPenumpang penumpangControl = new DetailPenumpang( i + 1);
                flowLayoutPanel1.Controls.Add(penumpangControl);
            }
        }

        private void BeliTiket_Load(object sender, EventArgs e)
        {
            loadusercontrol();
        }

        private void btnPakaiKodePromo_Click(object sender, EventArgs e)
        {
            if (validkodepromo(textBox1.Text))
            {
                var kpm = db.KodePromo.SingleOrDefault(f => f.Kode == textBox1.Text);
                if (kpm != null)
                {
                    if (IsPromoCodeValid(kpm))
                    {
                        double persentasediskon = kpm.PersentaseDiskon;
                        double maksimumdiskon = kpm.MaksimumDiskon;

                        double total = hargaPertiket * jumlahPenumpang;
                        double diskon = Math.Min(total * persentasediskon / 100, maksimumdiskon);
                        double set = total - diskon;

                        string format = set.ToString("C0", new CultureInfo("id-ID"));
                        label13.Text = format;
                    }
                    else
                    {
                        MessageBox.Show("Kode Promo sudah tidak berlaku");
                    }
                }
                else
                {
                    MessageBox.Show("Kode Promo Tidak Valid");
                }   
            }
        }

        bool validkodepromo(string text)
        {
            return db.KodePromo.Any(f => f.Kode == text);
        }
        bool IsPromoCodeValid(KodePromo promo)
        {
            return promo.BerlakuSampai >= DateTime.Now;
        }
      
        private void btnKonfirmasiPembayaran_Click(object sender, EventArgs e)
        {
            int? kodePromoID = null;
            bool kodePromoDipakai = !string.IsNullOrWhiteSpace(textBox1.Text);

            if (kodePromoDipakai)
            {
             
                var kodePromo = db.KodePromo.SingleOrDefault(f => f.Kode == textBox1.Text);
                if (kodePromo != null)
                {
                    kodePromoID = kodePromo.ID;
                }
            }

            TransaksiHeader aa = new TransaksiHeader()
            {
                AkunID = id,
                TanggalTransaksi = DateTime.Now,
                JadwalPenerbanganID = jadwalid,
                JumlahPenumpang = jumlahPenumpang,
        
                KodePromoID = kodePromoID,

            };
            if (double.TryParse(label13.Text.Replace("IDR", "").Trim(), NumberStyles.Currency, new CultureInfo("id-ID"), out double totalHarga))
            {
                aa.TotalHarga = totalHarga;
            }
          
            db.TransaksiHeader.Add(aa);
            db.SaveChanges();

           foreach(var control in flowLayoutPanel1.Controls)
           {
                if(control is DetailPenumpang penumpang)
                {
                    TransaksiDetail bb = new TransaksiDetail
                    {
                        TransaksiHeaderID = aa.ID,
                        TitelPenumpang = penumpang.titel(),
                        NamaLengkapPenumpang = penumpang.nama()
                    };
                   db.TransaksiDetail.Add(bb);
                };
           }
            db.SaveChanges();
            this.Close();

        
            CustomerFrm fm = new CustomerFrm(id);
            fm.Show();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

