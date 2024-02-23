namespace Bromo.Masters
{
    partial class MasterMaskapaiFrm
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
            System.Windows.Forms.Label namaLabel;
            System.Windows.Forms.Label perusahaanLabel;
            System.Windows.Forms.Label jumlahKruLabel;
            System.Windows.Forms.Label deskripsiLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perusahaanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jumlahKruDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deskripsiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UbahColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.HapusColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.namaTextBox = new System.Windows.Forms.TextBox();
            this.maskapaiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.perusahaanTextBox = new System.Windows.Forms.TextBox();
            this.jumlahKruNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.deskripsiTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            namaLabel = new System.Windows.Forms.Label();
            perusahaanLabel = new System.Windows.Forms.Label();
            jumlahKruLabel = new System.Windows.Forms.Label();
            deskripsiLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maskapaiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jumlahKruNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // namaLabel
            // 
            namaLabel.AutoSize = true;
            namaLabel.Location = new System.Drawing.Point(26, 432);
            namaLabel.Name = "namaLabel";
            namaLabel.Size = new System.Drawing.Size(47, 16);
            namaLabel.TabIndex = 3;
            namaLabel.Text = "Nama:";
            namaLabel.Click += new System.EventHandler(this.namaLabel_Click);
            // 
            // perusahaanLabel
            // 
            perusahaanLabel.AutoSize = true;
            perusahaanLabel.Location = new System.Drawing.Point(29, 471);
            perusahaanLabel.Name = "perusahaanLabel";
            perusahaanLabel.Size = new System.Drawing.Size(83, 16);
            perusahaanLabel.TabIndex = 5;
            perusahaanLabel.Text = "Perusahaan:";
            perusahaanLabel.Click += new System.EventHandler(this.perusahaanLabel_Click);
            // 
            // jumlahKruLabel
            // 
            jumlahKruLabel.AutoSize = true;
            jumlahKruLabel.Location = new System.Drawing.Point(30, 514);
            jumlahKruLabel.Name = "jumlahKruLabel";
            jumlahKruLabel.Size = new System.Drawing.Size(75, 16);
            jumlahKruLabel.TabIndex = 7;
            jumlahKruLabel.Text = "Jumlah Kru:";
            jumlahKruLabel.Click += new System.EventHandler(this.jumlahKruLabel_Click);
            // 
            // deskripsiLabel
            // 
            deskripsiLabel.AutoSize = true;
            deskripsiLabel.Location = new System.Drawing.Point(615, 432);
            deskripsiLabel.Name = "deskripsiLabel";
            deskripsiLabel.Size = new System.Drawing.Size(67, 16);
            deskripsiLabel.TabIndex = 9;
            deskripsiLabel.Text = "Deskripsi:";
            deskripsiLabel.Click += new System.EventHandler(this.deskripsiLabel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Master Maskapai";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(310, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Semua maskapai yang terdaftar akan muncul disini";
            this.label2.Click += new System.EventHandler(this.label2_Click);
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
            this.namaDataGridViewTextBoxColumn,
            this.perusahaanDataGridViewTextBoxColumn,
            this.jumlahKruDataGridViewTextBoxColumn,
            this.deskripsiDataGridViewTextBoxColumn,
            this.UbahColumn,
            this.HapusColumn});
            this.dataGridView1.DataSource = this.bindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(29, 92);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(974, 316);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // namaDataGridViewTextBoxColumn
            // 
            this.namaDataGridViewTextBoxColumn.DataPropertyName = "Nama";
            this.namaDataGridViewTextBoxColumn.HeaderText = "Nama";
            this.namaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.namaDataGridViewTextBoxColumn.Name = "namaDataGridViewTextBoxColumn";
            this.namaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // perusahaanDataGridViewTextBoxColumn
            // 
            this.perusahaanDataGridViewTextBoxColumn.DataPropertyName = "Perusahaan";
            this.perusahaanDataGridViewTextBoxColumn.HeaderText = "Perusahaan";
            this.perusahaanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.perusahaanDataGridViewTextBoxColumn.Name = "perusahaanDataGridViewTextBoxColumn";
            this.perusahaanDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // jumlahKruDataGridViewTextBoxColumn
            // 
            this.jumlahKruDataGridViewTextBoxColumn.DataPropertyName = "JumlahKru";
            this.jumlahKruDataGridViewTextBoxColumn.HeaderText = "JumlahKru";
            this.jumlahKruDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.jumlahKruDataGridViewTextBoxColumn.Name = "jumlahKruDataGridViewTextBoxColumn";
            this.jumlahKruDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // deskripsiDataGridViewTextBoxColumn
            // 
            this.deskripsiDataGridViewTextBoxColumn.DataPropertyName = "Deskripsi";
            this.deskripsiDataGridViewTextBoxColumn.HeaderText = "Deskripsi";
            this.deskripsiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.deskripsiDataGridViewTextBoxColumn.Name = "deskripsiDataGridViewTextBoxColumn";
            this.deskripsiDataGridViewTextBoxColumn.ReadOnly = true;
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
            this.bindingSource1.DataSource = typeof(Bromo.Maskapai);
            this.bindingSource1.CurrentChanged += new System.EventHandler(this.bindingSource1_CurrentChanged);
            // 
            // namaTextBox
            // 
            this.namaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.maskapaiBindingSource, "Nama", true));
            this.namaTextBox.Location = new System.Drawing.Point(131, 429);
            this.namaTextBox.Name = "namaTextBox";
            this.namaTextBox.Size = new System.Drawing.Size(228, 22);
            this.namaTextBox.TabIndex = 4;
            this.namaTextBox.TextChanged += new System.EventHandler(this.namaTextBox_TextChanged);
            // 
            // maskapaiBindingSource
            // 
            this.maskapaiBindingSource.DataSource = typeof(Bromo.Maskapai);
            this.maskapaiBindingSource.CurrentChanged += new System.EventHandler(this.maskapaiBindingSource_CurrentChanged);
            // 
            // perusahaanTextBox
            // 
            this.perusahaanTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.maskapaiBindingSource, "Perusahaan", true));
            this.perusahaanTextBox.Location = new System.Drawing.Point(132, 468);
            this.perusahaanTextBox.Name = "perusahaanTextBox";
            this.perusahaanTextBox.Size = new System.Drawing.Size(227, 22);
            this.perusahaanTextBox.TabIndex = 6;
            this.perusahaanTextBox.TextChanged += new System.EventHandler(this.perusahaanTextBox_TextChanged);
            // 
            // jumlahKruNumericUpDown
            // 
            this.jumlahKruNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.maskapaiBindingSource, "JumlahKru", true));
            this.jumlahKruNumericUpDown.Location = new System.Drawing.Point(131, 512);
            this.jumlahKruNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.jumlahKruNumericUpDown.Name = "jumlahKruNumericUpDown";
            this.jumlahKruNumericUpDown.Size = new System.Drawing.Size(228, 22);
            this.jumlahKruNumericUpDown.TabIndex = 8;
            this.jumlahKruNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.jumlahKruNumericUpDown.ValueChanged += new System.EventHandler(this.jumlahKruNumericUpDown_ValueChanged);
            // 
            // deskripsiTextBox
            // 
            this.deskripsiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.maskapaiBindingSource, "Deskripsi", true));
            this.deskripsiTextBox.Location = new System.Drawing.Point(712, 429);
            this.deskripsiTextBox.Multiline = true;
            this.deskripsiTextBox.Name = "deskripsiTextBox";
            this.deskripsiTextBox.Size = new System.Drawing.Size(235, 105);
            this.deskripsiTextBox.TabIndex = 10;
            this.deskripsiTextBox.TextChanged += new System.EventHandler(this.deskripsiTextBox_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(843, 559);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 35);
            this.button1.TabIndex = 11;
            this.button1.Text = "Simpan";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(712, 559);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 35);
            this.button2.TabIndex = 12;
            this.button2.Text = "Batal";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MasterMaskapaiFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1032, 647);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(deskripsiLabel);
            this.Controls.Add(this.deskripsiTextBox);
            this.Controls.Add(jumlahKruLabel);
            this.Controls.Add(this.jumlahKruNumericUpDown);
            this.Controls.Add(perusahaanLabel);
            this.Controls.Add(this.perusahaanTextBox);
            this.Controls.Add(namaLabel);
            this.Controls.Add(this.namaTextBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MasterMaskapaiFrm";
            this.Text = "MasterMaskapaiFrm";
            this.Load += new System.EventHandler(this.MasterMaskapaiFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maskapaiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jumlahKruNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.BindingSource maskapaiBindingSource;
        private System.Windows.Forms.TextBox namaTextBox;
        private System.Windows.Forms.TextBox perusahaanTextBox;
        private System.Windows.Forms.NumericUpDown jumlahKruNumericUpDown;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perusahaanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jumlahKruDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deskripsiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn UbahColumn;
        private System.Windows.Forms.DataGridViewButtonColumn HapusColumn;
        private System.Windows.Forms.TextBox deskripsiTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}