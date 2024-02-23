using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bromo.Masters
{
    public partial class MasterJadwalPenerbangan : Form
    {
        BromoAirlinesEntities1 db = new BromoAirlinesEntities1();
        bool simpan = true;
        public MasterJadwalPenerbangan()
        {
            InitializeComponent();
        }

        private void MasterJadwalPenerbangan_Load(object sender, EventArgs e)
        {
            jadwalPenerbanganBindingSource.Clear();
            jadwalPenerbanganBindingSource.AddNew();
            bindingSource1.Clear();
            bindingSource1.DataSource = db.JadwalPenerbangan.OrderBy(f => f.TanggalWaktuKeberangkatan).ToList();
            BandaraBR.DataSource = db.Bandara.OrderBy(f=>f.Nama).ToList();
            BandaraTjb.DataSource = db.Bandara.OrderBy(f => f.Nama).ToList();
            maskapaiBindingSource.DataSource = db.Maskapai.OrderBy(f => f.Nama).ToList();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].DataBoundItem is JadwalPenerbangan b)
            {
                if(e.ColumnIndex == BandaraKeberangkatan.Index)
                {
                    e.Value = b.Bandara.Nama;
                }
                else if(e.ColumnIndex == BandaraTujuan.Index)
                {
                    e.Value = b.Bandara1.Nama;
                }
                else if(e.ColumnIndex == Maskapai.Index)
                {
                    e.Value = b.Maskapai.Nama;  
                }
                else if (e.ColumnIndex == tanggalWaktuKeberangkatanDataGridViewTextBoxColumn.Index)
                {
                    e.Value = b.TanggalWaktuKeberangkatan.ToString("dd-MM-yyyy");
                }
                else if(e.ColumnIndex == WaktuKeberangkatan.Index)
                {
                    e.Value = b.TanggalWaktuKeberangkatan.ToString("HH:mm");
                }
                else if(e.ColumnIndex == durasiPenerbanganDataGridViewTextBoxColumn.Index)
                {
                    int durasipenerbangan = Convert.ToInt32(e.Value);

                    int jam = durasipenerbangan / 60;
                    int menit = durasipenerbangan % 60;

                    e.Value = $"{jam:D2} jam {menit:D2}";

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {           
            if (string.IsNullOrWhiteSpace(kodePenerbanganMaskedTextBox.Text) || string.IsNullOrWhiteSpace(maskedTextBox1.Text) || string.IsNullOrWhiteSpace(maskedTextBox2.Text))
            {
                MessageBox.Show("Fields Tidak Boleh Kosong");
                return;
            }
            else if (comboBox1.Text == comboBox2.Text)
            {
                MessageBox.Show("Bandara keberangkatan dan tujuan yang dipilih tidak boleh sama");
                return;
            }
            else
            {
                if (jadwalPenerbanganBindingSource.Current is JadwalPenerbangan p)
                {
              
                    if(!DateTime.TryParse(maskedTextBox1.Text, out DateTime WaktuKeberangkatan))
                    {
                        MessageBox.Show("Format waktu keberangkatan tidak valid. Masukkan waktu dalam format 24 jam (00:00 - 23:59).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    string durasipenerbangan = maskedTextBox2.Text;

                    p.TanggalWaktuKeberangkatan = WaktuKeberangkatan;
                    p.DurasiPenerbangan = ParseDuration(durasipenerbangan);
                    if (simpan)
                    {
                        db.JadwalPenerbangan.Add(p);
                        MessageBox.Show("Data Berhasil Disimpan");
                    }
                    else
                    {
                        db.JadwalPenerbangan.AddOrUpdate(p);
                    }

                    try
                    {
                        db.SaveChanges();
                        MasterJadwalPenerbangan_Load(sender, e);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error during SaveChanges: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private int ParseDuration(string durationString)
        {
            // memisahkan string berdasarkan jam dan menit
            string[] parts = durationString.Split(new string[] { "jam", "menit" }, StringSplitOptions.RemoveEmptyEntries);
            //parsing jam dan menit dari array hasil pemmisahan
            int hours = int.Parse(parts[0].Trim());
            int minutes = int.Parse(parts[1].Trim());
            //mengembalikan total menit
            return hours * 60 + minutes;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void kodePenerbanganMaskedTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            kodePenerbanganMaskedTextBox.Text= kodePenerbanganMaskedTextBox.Text.ToUpper();
            kodePenerbanganMaskedTextBox.SelectionStart = kodePenerbanganMaskedTextBox.Text.Length;
        }
    }

}
