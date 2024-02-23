namespace Bromo.Masters
{
    partial class UbahStatusPenerbangan
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kodePenerbanganDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Maskapai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BandaraKeberangkatan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BandaraTujuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tanggalWaktuKeberangkatanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WaktuKeberangkatan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durasiPenerbanganDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargaPerTiketDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusTerakhir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TerakhirDiubah = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UbahColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.statusPenerbanganBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.namaComboBox = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusPenerbanganBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ubah Status Penerbangan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(333, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Anda bisa mengubah status jadwal penerbangan disini\r\n";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDColumn,
            this.kodePenerbanganDataGridViewTextBoxColumn,
            this.Maskapai,
            this.BandaraKeberangkatan,
            this.BandaraTujuan,
            this.tanggalWaktuKeberangkatanDataGridViewTextBoxColumn,
            this.WaktuKeberangkatan,
            this.durasiPenerbanganDataGridViewTextBoxColumn,
            this.hargaPerTiketDataGridViewTextBoxColumn,
            this.StatusTerakhir,
            this.TerakhirDiubah,
            this.UbahColumn});
            this.dataGridView1.DataSource = this.bindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(28, 96);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(980, 336);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // IDColumn
            // 
            this.IDColumn.DataPropertyName = "ID";
            this.IDColumn.HeaderText = "ID";
            this.IDColumn.MinimumWidth = 6;
            this.IDColumn.Name = "IDColumn";
            this.IDColumn.ReadOnly = true;
            this.IDColumn.Visible = false;
            // 
            // kodePenerbanganDataGridViewTextBoxColumn
            // 
            this.kodePenerbanganDataGridViewTextBoxColumn.DataPropertyName = "KodePenerbangan";
            this.kodePenerbanganDataGridViewTextBoxColumn.HeaderText = "KodePenerbangan";
            this.kodePenerbanganDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kodePenerbanganDataGridViewTextBoxColumn.Name = "kodePenerbanganDataGridViewTextBoxColumn";
            this.kodePenerbanganDataGridViewTextBoxColumn.ReadOnly = true;
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
            // BandaraTujuan
            // 
            this.BandaraTujuan.HeaderText = "BandaraTujuan";
            this.BandaraTujuan.MinimumWidth = 6;
            this.BandaraTujuan.Name = "BandaraTujuan";
            this.BandaraTujuan.ReadOnly = true;
            // 
            // tanggalWaktuKeberangkatanDataGridViewTextBoxColumn
            // 
            this.tanggalWaktuKeberangkatanDataGridViewTextBoxColumn.DataPropertyName = "TanggalWaktuKeberangkatan";
            this.tanggalWaktuKeberangkatanDataGridViewTextBoxColumn.HeaderText = "TanggalKeberangkatan";
            this.tanggalWaktuKeberangkatanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tanggalWaktuKeberangkatanDataGridViewTextBoxColumn.Name = "tanggalWaktuKeberangkatanDataGridViewTextBoxColumn";
            this.tanggalWaktuKeberangkatanDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // WaktuKeberangkatan
            // 
            this.WaktuKeberangkatan.HeaderText = "WaktuKeberangkatan";
            this.WaktuKeberangkatan.MinimumWidth = 6;
            this.WaktuKeberangkatan.Name = "WaktuKeberangkatan";
            this.WaktuKeberangkatan.ReadOnly = true;
            // 
            // durasiPenerbanganDataGridViewTextBoxColumn
            // 
            this.durasiPenerbanganDataGridViewTextBoxColumn.DataPropertyName = "DurasiPenerbangan";
            this.durasiPenerbanganDataGridViewTextBoxColumn.HeaderText = "DurasiPenerbangan";
            this.durasiPenerbanganDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.durasiPenerbanganDataGridViewTextBoxColumn.Name = "durasiPenerbanganDataGridViewTextBoxColumn";
            this.durasiPenerbanganDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hargaPerTiketDataGridViewTextBoxColumn
            // 
            this.hargaPerTiketDataGridViewTextBoxColumn.DataPropertyName = "HargaPerTiket";
            this.hargaPerTiketDataGridViewTextBoxColumn.HeaderText = "HargaPerTiket";
            this.hargaPerTiketDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hargaPerTiketDataGridViewTextBoxColumn.Name = "hargaPerTiketDataGridViewTextBoxColumn";
            this.hargaPerTiketDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // StatusTerakhir
            // 
            this.StatusTerakhir.HeaderText = "StatusTerakhir";
            this.StatusTerakhir.MinimumWidth = 6;
            this.StatusTerakhir.Name = "StatusTerakhir";
            this.StatusTerakhir.ReadOnly = true;
            // 
            // TerakhirDiubah
            // 
            this.TerakhirDiubah.HeaderText = "TerakhirDiubah";
            this.TerakhirDiubah.MinimumWidth = 6;
            this.TerakhirDiubah.Name = "TerakhirDiubah";
            this.TerakhirDiubah.ReadOnly = true;
            // 
            // UbahColumn
            // 
            this.UbahColumn.HeaderText = "";
            this.UbahColumn.MinimumWidth = 6;
            this.UbahColumn.Name = "UbahColumn";
            this.UbahColumn.ReadOnly = true;
            this.UbahColumn.Text = "Ubah";
            this.UbahColumn.UseColumnTextForButtonValue = true;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(Bromo.JadwalPenerbangan);
            // 
            // statusPenerbanganBindingSource
            // 
            this.statusPenerbanganBindingSource.DataSource = typeof(Bromo.StatusPenerbangan);
            // 
            // namaComboBox
            // 
            this.namaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.statusPenerbanganBindingSource, "Nama", true));
            this.namaComboBox.DataSource = this.statusPenerbanganBindingSource;
            this.namaComboBox.DisplayMember = "Nama";
            this.namaComboBox.FormattingEnabled = true;
            this.namaComboBox.Location = new System.Drawing.Point(85, 459);
            this.namaComboBox.Name = "namaComboBox";
            this.namaComboBox.Size = new System.Drawing.Size(204, 24);
            this.namaComboBox.TabIndex = 4;
            this.namaComboBox.ValueMember = "ID";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(735, 504);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 37);
            this.button2.TabIndex = 24;
            this.button2.Text = "Batal";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(870, 504);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(116, 37);
            this.btnSimpan.TabIndex = 23;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(717, 453);
            this.maskedTextBox1.Mask = "00j\\am 00menit";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(269, 22);
            this.maskedTextBox1.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(554, 453);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 16);
            this.label3.TabIndex = 26;
            this.label3.Text = "Perkiraan Durasi Delay";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 456);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 27;
            this.label4.Text = "Status";
            // 
            // UbahStatusPenerbangan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1032, 647);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.namaComboBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UbahStatusPenerbangan";
            this.Text = "UbahStatusPenerbangan";
            this.Load += new System.EventHandler(this.UbahStatusPenerbangan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusPenerbanganBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource statusPenerbanganBindingSource;
        private System.Windows.Forms.ComboBox namaComboBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodePenerbanganDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Maskapai;
        private System.Windows.Forms.DataGridViewTextBoxColumn BandaraKeberangkatan;
        private System.Windows.Forms.DataGridViewTextBoxColumn BandaraTujuan;
        private System.Windows.Forms.DataGridViewTextBoxColumn tanggalWaktuKeberangkatanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn WaktuKeberangkatan;
        private System.Windows.Forms.DataGridViewTextBoxColumn durasiPenerbanganDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargaPerTiketDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusTerakhir;
        private System.Windows.Forms.DataGridViewTextBoxColumn TerakhirDiubah;
        private System.Windows.Forms.DataGridViewButtonColumn UbahColumn;
    }
}