using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Bromo.Masters
{
    public partial class UbahStatusPenerbangan : Form
    {
        BromoAirlinesEntities1 db = new BromoAirlinesEntities1 ();
   
        public UbahStatusPenerbangan()
        {
            InitializeComponent();
          
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].DataBoundItem is JadwalPenerbangan p)
            {
                if(e.ColumnIndex == durasiPenerbanganDataGridViewTextBoxColumn.Index)
                {
                    TimeSpan time = TimeSpan.FromMinutes(p.DurasiPenerbangan);
                    e.Value = $"{time.Hours:00} jam {time.Minutes:00} menit";
                }
                else if(e.ColumnIndex == tanggalWaktuKeberangkatanDataGridViewTextBoxColumn.Index)
                {
                    e.Value = p.TanggalWaktuKeberangkatan.ToString("dd-MM-yyyy");
                }
                else if(e.ColumnIndex == WaktuKeberangkatan.Index)
                {
                    e.Value = p.TanggalWaktuKeberangkatan.ToString("HH:mm");
                }
                else if(e.ColumnIndex == BandaraKeberangkatan.Index)
                {
                    e.Value = p.Bandara.Nama;
                }
                else if(e.ColumnIndex == BandaraTujuan.Index)
                {
                    e.Value = p.Bandara1.Nama;
                }
                else if(e.ColumnIndex == Maskapai.Index)
                {
                    e.Value = p.Maskapai.Nama;  
                }
                else if (e.ColumnIndex == TerakhirDiubah.Index)
                {
                        var terakhirdiuabh = p.PerubahanStatusJadwalPenerbangan.Max(a => (DateTime?)a.WaktuPerubahanTerjadi);
                   
                        if (terakhirdiuabh.HasValue)
                        {
                            e.Value = terakhirdiuabh.Value.ToString("dd-MM-yyyy HH:mm:ss");
                        }
                        else
                        {
                            e.Value = "-";
                        }
                    
                }
                else if (e.ColumnIndex == StatusTerakhir.Index)
                {
                    var c = p.PerubahanStatusJadwalPenerbangan;

                    if (c != null && c.Any())
                    {                       
                        var b = c.OrderByDescending(f => f.WaktuPerubahanTerjadi).First();
                        e.Value = b.StatusPenerbangan.Nama;
                    }
                    else
                    {
                        e.Value = "Sesuai Jadwal";
                    }
                }

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
       
            if (dataGridView1.Rows[e.RowIndex].DataBoundItem is JadwalPenerbangan b)
            {             
                if(e.ColumnIndex == UbahColumn.Index)
                {
                    namaComboBox.Visible = true;
                    label4.Visible = true;
                    btnSimpan.Visible = true;
                    button2.Visible = true;


                    if (e.ColumnIndex == StatusTerakhir.Index)
                    {
                        object value = dataGridView1.Rows[e.RowIndex].Cells["StatusTerakhir"].Value;
                        namaComboBox.SelectedValue = value;
                    }   
                }                
            }
        }

        private void UbahStatusPenerbangan_Load(object sender, EventArgs e)
        {
            
            bindingSource1.DataSource = db.JadwalPenerbangan.AsNoTracking().ToList();
            statusPenerbanganBindingSource.DataSource = db.StatusPenerbangan.AsNoTracking().ToList();
       

            namaComboBox.DataSource = statusPenerbanganBindingSource;
            namaComboBox.Visible = false;
            label4.Visible = false;
            label3.Visible = false;
            maskedTextBox1.Visible = false;
            btnSimpan.Visible = false;
            button2.Visible = false;
        }
        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow?.DataBoundItem is JadwalPenerbangan selectedJadwalPenerbangan)
            {             
                var perubahanStatus = new PerubahanStatusJadwalPenerbangan
                {
                    JadwalPenerbanganID = selectedJadwalPenerbangan.ID,
                    StatusPenerbanganID = (int)namaComboBox.SelectedValue,
                    WaktuPerubahanTerjadi = DateTime.Now,
                    PerkiraanDurasiDelay =  null
                };              
                db.PerubahanStatusJadwalPenerbangan.Add(perubahanStatus);              
                db.SaveChanges();              
                UbahStatusPenerbangan_Load(sender, e);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}
