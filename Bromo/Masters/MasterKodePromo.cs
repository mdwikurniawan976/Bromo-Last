using System;
using System.Data;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Windows.Forms;

namespace Bromo.Masters
{
    public partial class MasterKodePromo : Form
    {
        BromoAirlinesEntities1 db = new BromoAirlinesEntities1 ();
        bool simpan = true;
        public MasterKodePromo()
        {
            InitializeComponent();
        }

        private void MasterKodePromo_Load(object sender, EventArgs e)
        {
            kodePromoBindingSource.Clear();
            kodePromoBindingSource.AddNew();
            bindingSource1.Clear();
            bindingSource1.DataSource = db.KodePromo.ToList();
            berlakuSampaiDateTimePicker.CustomFormat = "dd-MM-yyyy";
        }

        private void kodeTextBox_TextChanged(object sender, EventArgs e)
        {
            kodeTextBox.Text = kodeTextBox.Text.ToUpper(); 
            kodeTextBox.SelectionStart = kodeTextBox.Text.Length;   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int currentid = (kodePromoBindingSource.Current as KodePromo)?.ID ?? 0;
            if((kodeTextBox.Text == string.Empty) || (deskripsiTextBox.Text == string.Empty))
            {
                MessageBox.Show("Fields Tidak Boleh Kosong");
                return;
            }
            else if (!unik(kodeTextBox.Text,currentid))
            {
                MessageBox.Show("Kode Tersebut Sudah Terdaftar  Silahkan Pilih Kode Yang Lain", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                if(kodePromoBindingSource.Current is KodePromo kp)
                {
                    if (simpan)
                    {
                        db.KodePromo.Add(kp);
                        MessageBox.Show("Data Berhasil Ditambah");
                    }
                    else
                    {
                        db.KodePromo.AddOrUpdate(kp);
                        MessageBox.Show("Data Berhasil Diubah");
                    }

                    db.SaveChanges();
                    clear();
                    MasterKodePromo_Load(sender, e);
                }
            }
            
        }
        void clear()
        {
            kodeTextBox.Text =  deskripsiTextBox.Text = string.Empty;
            berlakuSampaiDateTimePicker.Text = "";
            persentaseDiskonNumericUpDown.Value = 1;
            maksimumDiskonNumericUpDown.Value = 1;
        }

        private bool unik(string kode, int id)
        {
            if(id == 0)
            {
               return ! db.KodePromo.Any(f=> f.Kode == kode);      

            }
            else
            {
                return !db.KodePromo.Any(f => f.Kode == kode && f.ID != id);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].DataBoundItem is KodePromo kodePromo)
            {
                if(e.ColumnIndex == UbahColumn.Index)
                {
                    kodePromoBindingSource.DataSource = db.KodePromo.AsNoTracking().First(f=> f.ID == kodePromo.ID);
                    simpan = false;
                }
                else if(e.ColumnIndex == HapusColumn.Index)
                {
                    var hapus = db.KodePromo.Where(f=> f.ID == kodePromo.ID).FirstOrDefault();
                    if(hapus != null)
                    {
                        DialogResult dr = MessageBox.Show($"Apakah Anda Yakin Akan Menghapus Data Ini  {hapus.Kode} ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (DialogResult.Yes == dr)
                        {
                            db.KodePromo.Remove(hapus);
                            db.SaveChanges();
                            MessageBox.Show("Data Berhasil Dihapus");
                            MasterKodePromo_Load(sender, e);

                        }
                        
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clear();
            kodePromoBindingSource.AddNew();
            simpan = true;
        }
    }
}
