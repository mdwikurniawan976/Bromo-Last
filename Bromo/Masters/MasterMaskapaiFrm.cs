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

namespace Bromo.Masters
{
    public partial class MasterMaskapaiFrm : Form
    {

        BromoAirlinesEntities1 db = new BromoAirlinesEntities1 ();
        bool simpan = true;
        public MasterMaskapaiFrm()
        {
            InitializeComponent();  
        }

        private void MasterMaskapaiFrm_Load(object sender, EventArgs e)
        {
            maskapaiBindingSource.Clear();
            maskapaiBindingSource.AddNew();
            bindingSource1.Clear();
            bindingSource1.DataSource = db.Maskapai.OrderBy(f => f.Nama).ToList();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if((namaTextBox.Text == string.Empty) || (perusahaanTextBox.Text == string.Empty) || (deskripsiTextBox.Text == string.Empty))
            {
                MessageBox.Show("Fields Tidak Boleh Kosong!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                if(maskapaiBindingSource.Current is Maskapai m)
                {
                    if (simpan)
                    {
                        db.Maskapai.Add (m);
                        MessageBox.Show("Data Berhasil Ditambah");                     
                    }
                    else
                    {
                        db.Maskapai.AddOrUpdate(m);
                        MessageBox.Show("Data Berhasil Diubah");
                    }
                    db.SaveChanges();
                    MasterMaskapaiFrm_Load(sender, e);
                    clear();
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].DataBoundItem is Maskapai m)
            {
                if(e.ColumnIndex == UbahColumn.Index)
                {
                     maskapaiBindingSource.DataSource = db.Maskapai.AsNoTracking().First(f=> f.ID == m.ID);
                    simpan = false;
                }
                else if (e.ColumnIndex == HapusColumn.Index)
                {
                    var hapus = db.Maskapai.Where(f=> f.ID == m.ID).FirstOrDefault();
                    if(hapus != null)
                    {
                        DialogResult dr = MessageBox.Show($"Apakah Anda Yakin Akan Menghapus Data Ini {hapus.Nama} ? ", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (dr == DialogResult.Yes)
                        {
                            db.Maskapai.Remove(hapus);
                            db.SaveChanges();
                            MessageBox.Show("Data Berhasil Dihapus");
                            MasterMaskapaiFrm_Load(sender, e);
                            clear();
                        }
                    }
                }
            }
        }

        void clear()
        {
            namaTextBox.Text = perusahaanTextBox.Text = deskripsiTextBox.Text = string.Empty;
            jumlahKruNumericUpDown.Value = 1;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            clear();
            maskapaiBindingSource.AddNew();
            simpan = true;
        }

        private void namaLabel_Click(object sender, EventArgs e)
        {

        }

        private void perusahaanLabel_Click(object sender, EventArgs e)
        {

        }

        private void jumlahKruLabel_Click(object sender, EventArgs e)
        {

        }

        private void deskripsiLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void namaTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskapaiBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void perusahaanTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void jumlahKruNumericUpDown_ValueChanged(object sender, EventArgs e)
        {

        }

        private void deskripsiTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
