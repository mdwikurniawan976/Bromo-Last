namespace Bromo.Customers
{
    partial class TiketSaya
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TiketSaya));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.KodePenerbangan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Maskapai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BandaraKeberangkatan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BandaraTujuanColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TanggalKeberangkatanC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WaktuKeberangkatan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusTerakhir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.akunIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tanggalTransaksiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jadwalPenerbanganIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jumlahPenumpangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalHargaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kodePromoIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.akunDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jadwalPenerbanganDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kodePromoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transaksiDetailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(72, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tiket Saya";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Bromo.Properties.Resources.chevron_left_solid_72;
            this.pictureBox1.Location = new System.Drawing.Point(15, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(283, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Semua tiket anda yang aktif akan muncul disini";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KodePenerbangan,
            this.Maskapai,
            this.BandaraKeberangkatan,
            this.BandaraTujuanColumn,
            this.TanggalKeberangkatanC,
            this.WaktuKeberangkatan,
            this.StatusTerakhir,
            this.iDDataGridViewTextBoxColumn,
            this.akunIDDataGridViewTextBoxColumn,
            this.tanggalTransaksiDataGridViewTextBoxColumn,
            this.jadwalPenerbanganIDDataGridViewTextBoxColumn,
            this.jumlahPenumpangDataGridViewTextBoxColumn,
            this.totalHargaDataGridViewTextBoxColumn,
            this.kodePromoIDDataGridViewTextBoxColumn,
            this.akunDataGridViewTextBoxColumn,
            this.jadwalPenerbanganDataGridViewTextBoxColumn,
            this.kodePromoDataGridViewTextBoxColumn,
            this.transaksiDetailDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(15, 99);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(827, 321);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // KodePenerbangan
            // 
            this.KodePenerbangan.HeaderText = "KodePenerbangan";
            this.KodePenerbangan.MinimumWidth = 6;
            this.KodePenerbangan.Name = "KodePenerbangan";
            this.KodePenerbangan.ReadOnly = true;
            // 
            // Maskapai
            // 
            this.Maskapai.HeaderText = "Maskapai";
            this.Maskapai.MinimumWidth = 6;
            this.Maskapai.Name = "Maskapai";
            this.Maskapai.ReadOnly = true;
            // 
            // BandaraKeberangkatan
            // 
            this.BandaraKeberangkatan.HeaderText = "BandaraKeberangkatan";
            this.BandaraKeberangkatan.MinimumWidth = 6;
            this.BandaraKeberangkatan.Name = "BandaraKeberangkatan";
            this.BandaraKeberangkatan.ReadOnly = true;
            // 
            // BandaraTujuanColumn
            // 
            this.BandaraTujuanColumn.HeaderText = "BandaraTujuan";
            this.BandaraTujuanColumn.MinimumWidth = 6;
            this.BandaraTujuanColumn.Name = "BandaraTujuanColumn";
            this.BandaraTujuanColumn.ReadOnly = true;
            // 
            // TanggalKeberangkatanC
            // 
            this.TanggalKeberangkatanC.HeaderText = "TanggalKeberangkatan";
            this.TanggalKeberangkatanC.MinimumWidth = 6;
            this.TanggalKeberangkatanC.Name = "TanggalKeberangkatanC";
            this.TanggalKeberangkatanC.ReadOnly = true;
            // 
            // WaktuKeberangkatan
            // 
            this.WaktuKeberangkatan.HeaderText = "WaktuPenerbangan";
            this.WaktuKeberangkatan.MinimumWidth = 6;
            this.WaktuKeberangkatan.Name = "WaktuKeberangkatan";
            this.WaktuKeberangkatan.ReadOnly = true;
            // 
            // StatusTerakhir
            // 
            this.StatusTerakhir.HeaderText = "StatusTerakhir";
            this.StatusTerakhir.MinimumWidth = 6;
            this.StatusTerakhir.Name = "StatusTerakhir";
            this.StatusTerakhir.ReadOnly = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // akunIDDataGridViewTextBoxColumn
            // 
            this.akunIDDataGridViewTextBoxColumn.DataPropertyName = "AkunID";
            this.akunIDDataGridViewTextBoxColumn.HeaderText = "AkunID";
            this.akunIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.akunIDDataGridViewTextBoxColumn.Name = "akunIDDataGridViewTextBoxColumn";
            this.akunIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.akunIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // tanggalTransaksiDataGridViewTextBoxColumn
            // 
            this.tanggalTransaksiDataGridViewTextBoxColumn.DataPropertyName = "TanggalTransaksi";
            this.tanggalTransaksiDataGridViewTextBoxColumn.HeaderText = "TanggalTransaksi";
            this.tanggalTransaksiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tanggalTransaksiDataGridViewTextBoxColumn.Name = "tanggalTransaksiDataGridViewTextBoxColumn";
            this.tanggalTransaksiDataGridViewTextBoxColumn.ReadOnly = true;
            this.tanggalTransaksiDataGridViewTextBoxColumn.Visible = false;
            // 
            // jadwalPenerbanganIDDataGridViewTextBoxColumn
            // 
            this.jadwalPenerbanganIDDataGridViewTextBoxColumn.DataPropertyName = "JadwalPenerbanganID";
            this.jadwalPenerbanganIDDataGridViewTextBoxColumn.HeaderText = "JadwalPenerbanganID";
            this.jadwalPenerbanganIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.jadwalPenerbanganIDDataGridViewTextBoxColumn.Name = "jadwalPenerbanganIDDataGridViewTextBoxColumn";
            this.jadwalPenerbanganIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.jadwalPenerbanganIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // jumlahPenumpangDataGridViewTextBoxColumn
            // 
            this.jumlahPenumpangDataGridViewTextBoxColumn.DataPropertyName = "JumlahPenumpang";
            this.jumlahPenumpangDataGridViewTextBoxColumn.HeaderText = "JumlahPenumpang";
            this.jumlahPenumpangDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.jumlahPenumpangDataGridViewTextBoxColumn.Name = "jumlahPenumpangDataGridViewTextBoxColumn";
            this.jumlahPenumpangDataGridViewTextBoxColumn.ReadOnly = true;
            this.jumlahPenumpangDataGridViewTextBoxColumn.Visible = false;
            // 
            // totalHargaDataGridViewTextBoxColumn
            // 
            this.totalHargaDataGridViewTextBoxColumn.DataPropertyName = "TotalHarga";
            this.totalHargaDataGridViewTextBoxColumn.HeaderText = "TotalHarga";
            this.totalHargaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalHargaDataGridViewTextBoxColumn.Name = "totalHargaDataGridViewTextBoxColumn";
            this.totalHargaDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalHargaDataGridViewTextBoxColumn.Visible = false;
            // 
            // kodePromoIDDataGridViewTextBoxColumn
            // 
            this.kodePromoIDDataGridViewTextBoxColumn.DataPropertyName = "KodePromoID";
            this.kodePromoIDDataGridViewTextBoxColumn.HeaderText = "KodePromoID";
            this.kodePromoIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kodePromoIDDataGridViewTextBoxColumn.Name = "kodePromoIDDataGridViewTextBoxColumn";
            this.kodePromoIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.kodePromoIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // akunDataGridViewTextBoxColumn
            // 
            this.akunDataGridViewTextBoxColumn.DataPropertyName = "Akun";
            this.akunDataGridViewTextBoxColumn.HeaderText = "Akun";
            this.akunDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.akunDataGridViewTextBoxColumn.Name = "akunDataGridViewTextBoxColumn";
            this.akunDataGridViewTextBoxColumn.ReadOnly = true;
            this.akunDataGridViewTextBoxColumn.Visible = false;
            // 
            // jadwalPenerbanganDataGridViewTextBoxColumn
            // 
            this.jadwalPenerbanganDataGridViewTextBoxColumn.DataPropertyName = "JadwalPenerbangan";
            this.jadwalPenerbanganDataGridViewTextBoxColumn.HeaderText = "JadwalPenerbangan";
            this.jadwalPenerbanganDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.jadwalPenerbanganDataGridViewTextBoxColumn.Name = "jadwalPenerbanganDataGridViewTextBoxColumn";
            this.jadwalPenerbanganDataGridViewTextBoxColumn.ReadOnly = true;
            this.jadwalPenerbanganDataGridViewTextBoxColumn.Visible = false;
            // 
            // kodePromoDataGridViewTextBoxColumn
            // 
            this.kodePromoDataGridViewTextBoxColumn.DataPropertyName = "KodePromo";
            this.kodePromoDataGridViewTextBoxColumn.HeaderText = "KodePromo";
            this.kodePromoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kodePromoDataGridViewTextBoxColumn.Name = "kodePromoDataGridViewTextBoxColumn";
            this.kodePromoDataGridViewTextBoxColumn.ReadOnly = true;
            this.kodePromoDataGridViewTextBoxColumn.Visible = false;
            // 
            // transaksiDetailDataGridViewTextBoxColumn
            // 
            this.transaksiDetailDataGridViewTextBoxColumn.DataPropertyName = "TransaksiDetail";
            this.transaksiDetailDataGridViewTextBoxColumn.HeaderText = "TransaksiDetail";
            this.transaksiDetailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.transaksiDetailDataGridViewTextBoxColumn.Name = "transaksiDetailDataGridViewTextBoxColumn";
            this.transaksiDetailDataGridViewTextBoxColumn.ReadOnly = true;
            this.transaksiDetailDataGridViewTextBoxColumn.Visible = false;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(Bromo.TransaksiHeader);
            // 
            // TiketSaya
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(854, 432);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TiketSaya";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bromo Airlines - Tiket Saya";
            this.Load += new System.EventHandler(this.TiketSaya_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn KodePenerbangan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Maskapai;
        private System.Windows.Forms.DataGridViewTextBoxColumn BandaraKeberangkatan;
        private System.Windows.Forms.DataGridViewTextBoxColumn BandaraTujuanColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TanggalKeberangkatanC;
        private System.Windows.Forms.DataGridViewTextBoxColumn WaktuKeberangkatan;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusTerakhir;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn akunIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tanggalTransaksiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jadwalPenerbanganIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jumlahPenumpangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalHargaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodePromoIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn akunDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jadwalPenerbanganDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodePromoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transaksiDetailDataGridViewTextBoxColumn;
    }
}