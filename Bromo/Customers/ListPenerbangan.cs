using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bromo.Customers
{
    public partial class ListPenerbangan : Form
    {
        string BandaraASal;
        string bandaratj;
        string kodeIATAasal;
        string kodeIATA2;

        DateTime TanggalKeberangkatan;
        int id;
        int jumlahpenumpang;
        BromoAirlinesEntities1 db = new BromoAirlinesEntities1 ();
        public ListPenerbangan(string BandaraASal,string kodeIATAasal, string bandaratj,string kodeIATA2, DateTime tanggalKeberangkatan, int  jumlahpenumpang , int id)
        {
            InitializeComponent();
            this.BandaraASal = BandaraASal;
            this.bandaratj = bandaratj;
            this.TanggalKeberangkatan = tanggalKeberangkatan.Date;
            this.jumlahpenumpang = jumlahpenumpang;
            this.kodeIATAasal = kodeIATAasal;

            this.kodeIATA2 = kodeIATA2;
            this.id = id;
            label2.Text = $"{BandaraASal}  ({kodeIATAasal})";
            label3.Text = $"{bandaratj}  ({kodeIATA2})";
            label4.Text = tanggalKeberangkatan.ToString("ddd, dd MMM yyyy");
            label5.Text = jumlahpenumpang + " Penumpang";

        }

        private void ListPenerbangan_Load(object sender, EventArgs e)
        {
            try
            {
                bindingSource1.DataSource = db.JadwalPenerbangan
                   .Where(f => f.Bandara.Nama == BandaraASal
                 && f.Bandara1.Nama == bandaratj
                 && DbFunctions.TruncateTime(f.TanggalWaktuKeberangkatan) == TanggalKeberangkatan.Date)
            .OrderByDescending(f => f.TanggalWaktuKeberangkatan)
              .ToList();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].DataBoundItem is JadwalPenerbangan b)
            {
                if (e.ColumnIndex == BandaraKeberangkatan.Index)
                {
                    e.Value = b.Bandara.Nama;
                }
                else if (e.ColumnIndex == BandaraTujuanColumn.Index)
                {
                    e.Value = b.Bandara1.Nama;
                }
                else if (e.ColumnIndex == Maskapai.Index)
                {
                    e.Value = b.Maskapai.Nama;
                }
                else if (e.ColumnIndex == TanggalKeberangkatanC.Index)
                {
                    e.Value = b.TanggalWaktuKeberangkatan.ToString("dd-MM-yyyy");
                }
                else if (e.ColumnIndex == WaktuKeberangkatan.Index)
                {
                    DateTime waktuKeberangkatan = b.TanggalWaktuKeberangkatan;

                    // Ambil nilai Durasi Penerbangan dari DataGridView
                    int durasiPenerbangan = Convert.ToInt32(e.Value);

                    // Ambil durasi delay dari entitas JadwalPenerbangan
                    int durasiDelay = b.DurasiPenerbangan  ; 

                    // Hitung total durasi penerbangan termasuk delay
                    int totalDurasi = durasiPenerbangan + durasiDelay;

                    // Hitung waktu kedatangan
                    DateTime waktuKedatangan = waktuKeberangkatan.AddMinutes(totalDurasi);

                    // Format string untuk waktu keberangkatan dan kedatangan
                    e.Value = $"{waktuKeberangkatan.ToString("HH:mm")} - {waktuKedatangan.ToString("HH:mm")}";

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                DateTime startDateTime = TanggalKeberangkatan.Date.AddHours(0);
                DateTime endDateTime = TanggalKeberangkatan.Date.AddHours(6);

                bindingSource1.DataSource = db.JadwalPenerbangan
                    .Where(f => f.Bandara.Nama == BandaraASal
                            && f.Bandara1.Nama == bandaratj
                            && DbFunctions.TruncateTime(f.TanggalWaktuKeberangkatan) == startDateTime
                            && DbFunctions.CreateTime(f.TanggalWaktuKeberangkatan.Hour, f.TanggalWaktuKeberangkatan.Minute, f.TanggalWaktuKeberangkatan.Second) >= startDateTime.TimeOfDay
                            && DbFunctions.CreateTime(f.TanggalWaktuKeberangkatan.Hour, f.TanggalWaktuKeberangkatan.Minute, f.TanggalWaktuKeberangkatan.Second) <= endDateTime.TimeOfDay)
                    .OrderByDescending(f => f.TanggalWaktuKeberangkatan)
                    .ToList();
            }
            else if (checkBox2.Checked)
            {
                DateTime s = TanggalKeberangkatan.Date.AddHours(6);
                DateTime end = TanggalKeberangkatan.Date.AddHours(12);

                bindingSource1.DataSource = db.JadwalPenerbangan.Where(f => f.Bandara.Nama == BandaraASal && f.Bandara1.Nama == bandaratj
                && DbFunctions.TruncateTime(f.TanggalWaktuKeberangkatan) == TanggalKeberangkatan.Date
                && DbFunctions.CreateTime(f.TanggalWaktuKeberangkatan.Hour, f.TanggalWaktuKeberangkatan.Minute, f.TanggalWaktuKeberangkatan.Second) >= s.TimeOfDay
                && DbFunctions.CreateTime(f.TanggalWaktuKeberangkatan.Hour, f.TanggalWaktuKeberangkatan.Minute, f.TanggalWaktuKeberangkatan.Second) <= end.TimeOfDay).OrderByDescending(f => f.TanggalWaktuKeberangkatan).ToList();
            }
            else if (checkBox3.Checked)
            {
                DateTime s = TanggalKeberangkatan.Date.AddHours(12);
                DateTime end = TanggalKeberangkatan.Date.AddHours(18);

                bindingSource1.DataSource = db.JadwalPenerbangan.Where(f => f.Bandara.Nama == BandaraASal && f.Bandara1.Nama == bandaratj
                && DbFunctions.TruncateTime(f.TanggalWaktuKeberangkatan) == TanggalKeberangkatan.Date
                && DbFunctions.CreateTime(f.TanggalWaktuKeberangkatan.Hour, f.TanggalWaktuKeberangkatan.Minute, f.TanggalWaktuKeberangkatan.Second) >= s.TimeOfDay
                && DbFunctions.CreateTime(f.TanggalWaktuKeberangkatan.Hour, f.TanggalWaktuKeberangkatan.Minute, f.TanggalWaktuKeberangkatan.Second) <= end.TimeOfDay).OrderByDescending(f => f.TanggalWaktuKeberangkatan).ToList();
            }
            else if (checkBox4.Checked)
            {
                DateTime s = TanggalKeberangkatan.Date.AddHours(18);
                DateTime end = TanggalKeberangkatan.Date.AddHours(24);

               bindingSource1.DataSource = db.JadwalPenerbangan.Where(f=> f.Bandara.Nama == BandaraASal && f.Bandara1.Nama == bandaratj
               && DbFunctions.TruncateTime(f.TanggalWaktuKeberangkatan) == TanggalKeberangkatan.Date
               && DbFunctions.CreateTime(f.TanggalWaktuKeberangkatan.Hour, f.TanggalWaktuKeberangkatan.Minute, f.TanggalWaktuKeberangkatan.Second) >= s.TimeOfDay
               && DbFunctions.CreateTime(f.TanggalWaktuKeberangkatan.Hour,f.TanggalWaktuKeberangkatan.Minute,f.TanggalWaktuKeberangkatan.Second)<= end.TimeOfDay).OrderByDescending(f=> f.TanggalWaktuKeberangkatan).ToList();
            }
            else if(comboBox1.SelectedItem !=  null)
            {
                string cb = comboBox1.SelectedItem.ToString();
             

                var query = db.JadwalPenerbangan.Where(f => f.Bandara.Nama == BandaraASal && f.Bandara1.Nama == bandaratj && DbFunctions.TruncateTime(f.TanggalWaktuKeberangkatan) == TanggalKeberangkatan.Date).OrderByDescending(f => f.TanggalWaktuKeberangkatan);
                switch(cb)
                {
                    case "Harga Terendah":
                        query = query.OrderBy(f => f.HargaPerTiket);
                        break;
                    case "Keberangkatan Paling Awal":
                        query = query.OrderBy(f => f.TanggalWaktuKeberangkatan);
                        break;
                    case "Keberangkatan Paling Akhir":
                        query = query.OrderByDescending(f => f.TanggalWaktuKeberangkatan);
                        break;
                    case "Kedatangan Paling Awal":
                        query = query.OrderBy(f => DbFunctions.AddMinutes(f.TanggalWaktuKeberangkatan, f.DurasiPenerbangan));
                        break;
                    case "Kedatangan Paling Akhir":
                        query = query.OrderByDescending(f => DbFunctions.AddMinutes(f.TanggalWaktuKeberangkatan, f.DurasiPenerbangan));
                        break;
                    case "Durasi Tercepat":
                        query = query.OrderBy(f => f.DurasiPenerbangan);
                        break;
                }
                bindingSource1.DataSource = query.ToList();
            }
            else
            {
                 bindingSource1.DataSource = db.JadwalPenerbangan.Where(f=> f.Bandara.Nama == BandaraASal && f.Bandara1.Nama == bandaratj
                 && DbFunctions.TruncateTime(f.TanggalWaktuKeberangkatan) == TanggalKeberangkatan.Date).OrderByDescending(f=> f.TanggalWaktuKeberangkatan).ToList();                   
            }


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
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].DataBoundItem is JadwalPenerbangan jadwalPenerbangan)
            {
                if (e.ColumnIndex == BeliTiket.Index)
                {
                    double hargaPertiket = jadwalPenerbangan.HargaPerTiket;
                    string maskapai = jadwalPenerbangan.Maskapai.Nama;
                    int durasiPenerbangan = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[WaktuKeberangkatan.Index].Value);
                    int jadwalid = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[JadwalID.Index].Value);
                  
                    int durasiDelay = jadwalPenerbangan.DurasiPenerbangan;


                    int totalDurasi = durasiPenerbangan + durasiDelay;

                    DateTime waktuKeberangkatan = jadwalPenerbangan.TanggalWaktuKeberangkatan;
                
                    DateTime waktuKedatangan = waktuKeberangkatan.AddMinutes(totalDurasi);                 
                    string waktuPenerbangan = $"{waktuKeberangkatan.ToString("HH:mm")} - {waktuKedatangan.ToString("HH:mm")}";
                    openForm(new BeliTiket(jumlahpenumpang, BandaraASal, bandaratj,kodeIATAasal ,kodeIATA2 ,TanggalKeberangkatan, hargaPertiket, maskapai, waktuPenerbangan, id, jadwalid));
           
                }
            }
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            CustomerFrm mm = new CustomerFrm(id);
            mm.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
