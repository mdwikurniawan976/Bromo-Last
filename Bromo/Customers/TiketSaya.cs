using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bromo.Customers
{
    public partial class TiketSaya : Form
    {
        int id;
        BromoAirlinesEntities1 db = new BromoAirlinesEntities1 ();
        public TiketSaya(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void TiketSaya_Load(object sender, EventArgs e)
        {
            var transaksiHeaders = db.TransaksiHeader
                .Where(th => th.AkunID == id)
                .ToList();

            bindingSource1.DataSource = transaksiHeaders;

        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].DataBoundItem is TransaksiHeader hdr)
            {
                if (e.ColumnIndex == KodePenerbangan.Index)
                {
                    e.Value = hdr.JadwalPenerbangan.KodePenerbangan;
                }
                else if (e.ColumnIndex == BandaraKeberangkatan.Index)
                {
                    e.Value = hdr.JadwalPenerbangan.Bandara.Nama;
                }
                else if (e.ColumnIndex == BandaraTujuanColumn.Index)
                {
                    e.Value = hdr.JadwalPenerbangan.Bandara1.Nama;
                }
                else if(e.ColumnIndex == TanggalKeberangkatanC.Index)
                {
                    e.Value = hdr.JadwalPenerbangan.TanggalWaktuKeberangkatan.ToString("dd-MM-yyyy");
                }
                else if(e.ColumnIndex == Maskapai.Index)
                {
                    e.Value = hdr.JadwalPenerbangan.Maskapai.Nama;
                }
                else if(e.ColumnIndex == WaktuKeberangkatan.Index)
                {
                    int durasi = Convert.ToInt32(e.Value);

                    DateTime waktuKeberangkatan = hdr.JadwalPenerbangan.TanggalWaktuKeberangkatan;

                    int durasidelay = hdr.JadwalPenerbangan.DurasiPenerbangan;

                    int total = durasi + durasidelay;


                    DateTime waktukedatangan = waktuKeberangkatan.AddMinutes(total);
                    e.Value = $"{waktuKeberangkatan.ToString("HH:mm")} - {waktukedatangan.ToString("HH:mm")}";
                }
                else if(e.ColumnIndex == StatusTerakhir.Index)
                {
                    var orderedStatusChanges = hdr.JadwalPenerbangan.PerubahanStatusJadwalPenerbangan
                  .OrderBy(sp => sp.WaktuPerubahanTerjadi) // Order status changes by time in ascending order
                  .ToList();

                    if (orderedStatusChanges.Any())
                    {
                        var latestStatusChange = orderedStatusChanges.Last(); // Get the latest status change

                        string status = latestStatusChange.StatusPenerbangan.Nama; // Assuming the status is a string property
                        if (status == "Delay")
                        {
                            int? perkiraanDurasiDelay = latestStatusChange.PerkiraanDurasiDelay;

                            if (perkiraanDurasiDelay.HasValue)
                            {
                                TimeSpan delayDuration = TimeSpan.FromMinutes(perkiraanDurasiDelay.Value);
                                e.Value = $"Delay (selama ±{delayDuration.TotalHours} jam {delayDuration.Minutes} menit)";
                            }
                            else
                            {
                                e.Value = "Delay (durasi tidak diketahui)";
                            }
                        }

                        else
                        {
                            e.Value = status;
                        }
                    }
                    else
                    {
                        e.Value = "Sesuai Jadwal";
                    }
                }
            }
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            CustomerFrm mm = new CustomerFrm(id);
            mm.Show();
           
        }
    }
}
