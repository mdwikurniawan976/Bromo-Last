namespace Bromo.Masters
{
    partial class MasterJadwalPenerbangan
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
            System.Windows.Forms.Label kodePenerbanganLabel;
            System.Windows.Forms.Label tanggalWaktuKeberangkatanLabel;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kodePenerbanganDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BandaraKeberangkatan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BandaraTujuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Maskapai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tanggalWaktuKeberangkatanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WaktuKeberangkatan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durasiPenerbanganDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargaPerTiketDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UbahColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.HapusColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.jadwalPenerbanganBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kodePenerbanganMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.BandaraBR = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.BandaraTjb = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.maskapaiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tanggalWaktuKeberangkatanDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            kodePenerbanganLabel = new System.Windows.Forms.Label();
            tanggalWaktuKeberangkatanLabel = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jadwalPenerbanganBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BandaraBR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BandaraTjb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maskapaiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // kodePenerbanganLabel
            // 
            kodePenerbanganLabel.AutoSize = true;
            kodePenerbanganLabel.ForeColor = System.Drawing.Color.Black;
            kodePenerbanganLabel.Location = new System.Drawing.Point(28, 453);
            kodePenerbanganLabel.Name = "kodePenerbanganLabel";
            kodePenerbanganLabel.Size = new System.Drawing.Size(127, 16);
            kodePenerbanganLabel.TabIndex = 3;
            kodePenerbanganLabel.Text = "Kode Penerbangan:";
            // 
            // tanggalWaktuKeberangkatanLabel
            // 
            tanggalWaktuKeberangkatanLabel.AutoSize = true;
            tanggalWaktuKeberangkatanLabel.Location = new System.Drawing.Point(568, 457);
            tanggalWaktuKeberangkatanLabel.Name = "tanggalWaktuKeberangkatanLabel";
            tanggalWaktuKeberangkatanLabel.Size = new System.Drawing.Size(58, 16);
            tanggalWaktuKeberangkatanLabel.TabIndex = 8;
            tanggalWaktuKeberangkatanLabel.Text = "Tanggal";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(568, 495);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(140, 16);
            label3.TabIndex = 10;
            label3.Text = "Waktu Keberangkatan";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(568, 535);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(131, 16);
            label4.TabIndex = 12;
            label4.Text = "Durasi Penerbangan";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(568, 574);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(102, 16);
            label5.TabIndex = 15;
            label5.Text = "Harga Per Tiket";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(21, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Master Jadwal Penerbangan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(285, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Semua jadwal penerbangan akan muncul disni";
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
            this.iDDataGridViewTextBoxColumn,
            this.kodePenerbanganDataGridViewTextBoxColumn,
            this.BandaraKeberangkatan,
            this.BandaraTujuan,
            this.Maskapai,
            this.tanggalWaktuKeberangkatanDataGridViewTextBoxColumn,
            this.WaktuKeberangkatan,
            this.durasiPenerbanganDataGridViewTextBoxColumn,
            this.hargaPerTiketDataGridViewTextBoxColumn,
            this.UbahColumn,
            this.HapusColumn});
            this.dataGridView1.DataSource = this.bindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(26, 89);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(980, 336);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
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
            // kodePenerbanganDataGridViewTextBoxColumn
            // 
            this.kodePenerbanganDataGridViewTextBoxColumn.DataPropertyName = "KodePenerbangan";
            this.kodePenerbanganDataGridViewTextBoxColumn.HeaderText = "KodePenerbangan";
            this.kodePenerbanganDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kodePenerbanganDataGridViewTextBoxColumn.Name = "kodePenerbanganDataGridViewTextBoxColumn";
            this.kodePenerbanganDataGridViewTextBoxColumn.ReadOnly = true;
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
            // Maskapai
            // 
            this.Maskapai.HeaderText = "Maskapai";
            this.Maskapai.MinimumWidth = 6;
            this.Maskapai.Name = "Maskapai";
            this.Maskapai.ReadOnly = true;
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
            // UbahColumn
            // 
            this.UbahColumn.HeaderText = "";
            this.UbahColumn.MinimumWidth = 6;
            this.UbahColumn.Name = "UbahColumn";
            this.UbahColumn.ReadOnly = true;
            this.UbahColumn.Text = "Ubah";
            this.UbahColumn.UseColumnTextForButtonValue = true;
            // 
            // HapusColumn
            // 
            this.HapusColumn.HeaderText = "";
            this.HapusColumn.MinimumWidth = 6;
            this.HapusColumn.Name = "HapusColumn";
            this.HapusColumn.ReadOnly = true;
            this.HapusColumn.Text = "Hapus";
            this.HapusColumn.UseColumnTextForButtonValue = true;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(Bromo.JadwalPenerbangan);
            // 
            // jadwalPenerbanganBindingSource
            // 
            this.jadwalPenerbanganBindingSource.DataSource = typeof(Bromo.JadwalPenerbangan);
            // 
            // kodePenerbanganMaskedTextBox
            // 
            this.kodePenerbanganMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jadwalPenerbanganBindingSource, "KodePenerbangan", true));
            this.kodePenerbanganMaskedTextBox.Location = new System.Drawing.Point(181, 453);
            this.kodePenerbanganMaskedTextBox.Mask = "AA-0000";
            this.kodePenerbanganMaskedTextBox.Name = "kodePenerbanganMaskedTextBox";
            this.kodePenerbanganMaskedTextBox.Size = new System.Drawing.Size(225, 22);
            this.kodePenerbanganMaskedTextBox.TabIndex = 4;
            this.kodePenerbanganMaskedTextBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.kodePenerbanganMaskedTextBox_MaskInputRejected);
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.jadwalPenerbanganBindingSource, "BandaraKeberangkatanID", true));
            this.comboBox1.DataSource = this.BandaraBR;
            this.comboBox1.DisplayMember = "Nama";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(181, 492);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(225, 24);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.ValueMember = "ID";
            // 
            // BandaraBR
            // 
            this.BandaraBR.DataSource = typeof(Bromo.Bandara);
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.jadwalPenerbanganBindingSource, "BandaraTujuanID", true));
            this.comboBox2.DataSource = this.BandaraTjb;
            this.comboBox2.DisplayMember = "Nama";
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(181, 532);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(225, 24);
            this.comboBox2.TabIndex = 6;
            this.comboBox2.ValueMember = "ID";
            // 
            // BandaraTjb
            // 
            this.BandaraTjb.DataSource = typeof(Bromo.Bandara);
            // 
            // comboBox3
            // 
            this.comboBox3.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.jadwalPenerbanganBindingSource, "MaskapaiID", true));
            this.comboBox3.DataSource = this.maskapaiBindingSource;
            this.comboBox3.DisplayMember = "Nama";
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(181, 572);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(225, 24);
            this.comboBox3.TabIndex = 7;
            this.comboBox3.ValueMember = "ID";
            // 
            // maskapaiBindingSource
            // 
            this.maskapaiBindingSource.DataSource = typeof(Bromo.Maskapai);
            // 
            // tanggalWaktuKeberangkatanDateTimePicker
            // 
            this.tanggalWaktuKeberangkatanDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jadwalPenerbanganBindingSource, "TanggalWaktuKeberangkatan", true));
            this.tanggalWaktuKeberangkatanDateTimePicker.Location = new System.Drawing.Point(721, 453);
            this.tanggalWaktuKeberangkatanDateTimePicker.Name = "tanggalWaktuKeberangkatanDateTimePicker";
            this.tanggalWaktuKeberangkatanDateTimePicker.Size = new System.Drawing.Size(251, 22);
            this.tanggalWaktuKeberangkatanDateTimePicker.TabIndex = 9;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(721, 492);
            this.maskedTextBox1.Mask = "00:00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(251, 22);
            this.maskedTextBox1.TabIndex = 11;
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(721, 535);
            this.maskedTextBox2.Mask = "00 j\\am 00 menit";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(251, 22);
            this.maskedTextBox2.TabIndex = 13;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.jadwalPenerbanganBindingSource, "HargaPerTiket", true));
            this.numericUpDown1.Location = new System.Drawing.Point(721, 572);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(251, 22);
            this.numericUpDown1.TabIndex = 14;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(28, 495);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Dari";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(28, 535);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "Ke";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(28, 574);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 16);
            this.label8.TabIndex = 18;
            this.label8.Text = "Maskapai";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(842, 624);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 37);
            this.button1.TabIndex = 19;
            this.button1.Text = "Simpan";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(721, 624);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 37);
            this.button2.TabIndex = 20;
            this.button2.Text = "Batal";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // MasterJadwalPenerbangan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1032, 696);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(label5);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(label4);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(label3);
            this.Controls.Add(tanggalWaktuKeberangkatanLabel);
            this.Controls.Add(this.tanggalWaktuKeberangkatanDateTimePicker);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(kodePenerbanganLabel);
            this.Controls.Add(this.kodePenerbanganMaskedTextBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MasterJadwalPenerbangan";
            this.Text = "MasterJadwalPenerbangan";
            this.Load += new System.EventHandler(this.MasterJadwalPenerbangan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jadwalPenerbanganBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BandaraBR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BandaraTjb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maskapaiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.BindingSource jadwalPenerbanganBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodePenerbanganDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BandaraKeberangkatan;
        private System.Windows.Forms.DataGridViewTextBoxColumn BandaraTujuan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Maskapai;
        private System.Windows.Forms.DataGridViewTextBoxColumn tanggalWaktuKeberangkatanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn WaktuKeberangkatan;
        private System.Windows.Forms.DataGridViewTextBoxColumn durasiPenerbanganDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargaPerTiketDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn UbahColumn;
        private System.Windows.Forms.DataGridViewButtonColumn HapusColumn;
        private System.Windows.Forms.MaskedTextBox kodePenerbanganMaskedTextBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.DateTimePicker tanggalWaktuKeberangkatanDateTimePicker;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.BindingSource BandaraBR;
        private System.Windows.Forms.BindingSource BandaraTjb;
        private System.Windows.Forms.BindingSource maskapaiBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}