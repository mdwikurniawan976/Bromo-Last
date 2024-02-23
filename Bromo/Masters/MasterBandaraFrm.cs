using Bromo.Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Bromo.Masters
{
    public partial class MasterBandaraFrm : Form
    {
        BromoAirlinesEntities1 db = new BromoAirlinesEntities1();
        bool simpan = true;
        public MasterBandaraFrm()
        {
            InitializeComponent();
        }

        private void MasterBandaraFrm_Load(object sender, EventArgs e)
        {         
            bandaraBindingSource.Clear();
            bandaraBindingSource.AddNew();
            bindingSource1.Clear();
            bindingSource1.DataSource = db.Bandara.OrderBy(f=> f.Nama).ToList();
            negaraBindingSource.DataSource = db.Negara.OrderBy(f=> f.Nama).ToList();
          //  bindingSource1.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int jumlah = kodeIATATextBox.Text.Length;
            int currentid = (bandaraBindingSource.Current as Bandara)?.ID ?? 0;

            if ((namaTextBox.Text == string.Empty) || (kodeIATATextBox.Text == string.Empty) || (kotaTextBox.Text == string.Empty) || (alamatTextBox.Text == string.Empty))
            {
                Alert.Error("Fields Tidak Boleh Kosong");
                return;
         
            }
            else if (!unik(namaTextBox.Text,currentid ))
            {
                Alert.Error("Nama Bandara Sudah Digunakan Silahkan Pilih Yang Lain");
                return;
            }
            else if (!iata(kodeIATATextBox.Text,currentid) || jumlah > 3)
            {
                Alert.Error("Kode Iata Sudah Digunakan Silahka Pilih Kode Yang Lain");
                return;

            }
            else if( jumlah > 3)
            {
                Alert.Information("Kode Iata Yang Di Input Harus 3 Huruf");
            }
            else
            {
                if(bandaraBindingSource.Current is Bandara b)
                {
                    if (simpan)
                    {
                         db.Bandara.Add(b);
                        Alert.Information("Data Berhasil Disimpan");
                    }
                    else
                    {
                        db.Bandara.AddOrUpdate(b);
                        Alert.Information("Data Berhasil Diubah");
                    }
                    db.SaveChanges();
                    MasterBandaraFrm_Load(sender, e);
                }
            }

        }

        private bool iata(string iata, int id )
        {
            if(id == 0)
            {
            return !db.Bandara.Any(f=> f.KodeIATA == iata); 

            }
            else
            {
                return !db.Bandara.Any(f => f.KodeIATA == iata && f.ID != id);
            }
        }
        private bool unik(string nama, int id)
        {
            if(id == 0)
            {
               return! db.Bandara.Any(f=> f.Nama == nama);    

            }
            else
            {
                return !db.Bandara.Any(f=> f.Nama == nama && f.ID != id);
            }

        }

        private void kodeIATATextBox_TextChanged(object sender, EventArgs e)
        {
   
            kodeIATATextBox.Text = new string(kodeIATATextBox.Text.Where(char.IsLetter).ToArray()).ToUpper();

          
            kodeIATATextBox.SelectionStart = kodeIATATextBox.Text.Length;
            kodeIATATextBox.MaxLength = 3;
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].DataBoundItem is Bandara ba)
            {
                if(e.ColumnIndex == NegaraColumn.Index)
                {
                    e.Value = ba.Negara.Nama;
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].DataBoundItem is Bandara a)
            {
                if(e.ColumnIndex == UbahColumn.Index)
                {
                    bandaraBindingSource.DataSource = db.Bandara.AsNoTracking().First(f=> f.ID == a.ID);
                    simpan = false;
                }
                else if(e.ColumnIndex == HapusColumn.Index)
                {
                    var hapus = db.Bandara.Where(f=> f.ID == a.ID).FirstOrDefault();    

                    if(hapus != null)
                    {
                        DialogResult dr = MessageBox.Show($"Apakah Anda Yakin Akan Menghapus Data Ini {hapus.Nama} ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if(DialogResult.Yes == dr)
                        {
                            db.Bandara.Remove(hapus);
                            MessageBox.Show("Data Berhasil Dihapus");
                            db.SaveChanges();
                            MasterBandaraFrm_Load(sender, e);
                        }
                    }
                }
            }
        }

        void clear()
        {
            namaTextBox.Text = kodeIATATextBox.Text = kotaTextBox.Text = comboBox1.Text = alamatTextBox.Text = string.Empty;
            jumlahTerminalNumericUpDown.Value = 1;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            clear();
            bandaraBindingSource.AddNew();
            simpan = true;
        }
    }
}
