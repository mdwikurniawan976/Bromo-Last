namespace Bromo.Masters
{
    partial class MasterKodePromo
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
            System.Windows.Forms.Label kodeLabel;
            System.Windows.Forms.Label berlakuSampaiLabel;
            System.Windows.Forms.Label maksimumDiskonLabel;
            System.Windows.Forms.Label persentaseDiskonLabel;
            System.Windows.Forms.Label deskripsiLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.UbahColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.HapusColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.kodeTextBox = new System.Windows.Forms.TextBox();
            this.berlakuSampaiDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.maksimumDiskonNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.persentaseDiskonNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.deskripsiTextBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.kodePromoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.persentaseDiskonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maksimumDiskonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.berlakuSampaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deskripsiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            kodeLabel = new System.Windows.Forms.Label();
            berlakuSampaiLabel = new System.Windows.Forms.Label();
            maksimumDiskonLabel = new System.Windows.Forms.Label();
            persentaseDiskonLabel = new System.Windows.Forms.Label();
            deskripsiLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maksimumDiskonNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.persentaseDiskonNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kodePromoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // kodeLabel
            // 
            kodeLabel.AutoSize = true;
            kodeLabel.Location = new System.Drawing.Point(32, 411);
            kodeLabel.Name = "kodeLabel";
            kodeLabel.Size = new System.Drawing.Size(42, 16);
            kodeLabel.TabIndex = 3;
            kodeLabel.Text = "Kode:";
            // 
            // berlakuSampaiLabel
            // 
            berlakuSampaiLabel.AutoSize = true;
            berlakuSampaiLabel.Location = new System.Drawing.Point(32, 450);
            berlakuSampaiLabel.Name = "berlakuSampaiLabel";
            berlakuSampaiLabel.Size = new System.Drawing.Size(106, 16);
            berlakuSampaiLabel.TabIndex = 5;
            berlakuSampaiLabel.Text = "Berlaku Sampai:";
            // 
            // maksimumDiskonLabel
            // 
            maksimumDiskonLabel.AutoSize = true;
            maksimumDiskonLabel.Location = new System.Drawing.Point(32, 527);
            maksimumDiskonLabel.Name = "maksimumDiskonLabel";
            maksimumDiskonLabel.Size = new System.Drawing.Size(120, 16);
            maksimumDiskonLabel.TabIndex = 7;
            maksimumDiskonLabel.Text = "Maksimum Diskon:";
            // 
            // persentaseDiskonLabel
            // 
            persentaseDiskonLabel.AutoSize = true;
            persentaseDiskonLabel.Location = new System.Drawing.Point(32, 489);
            persentaseDiskonLabel.Name = "persentaseDiskonLabel";
            persentaseDiskonLabel.Size = new System.Drawing.Size(124, 16);
            persentaseDiskonLabel.TabIndex = 9;
            persentaseDiskonLabel.Text = "Persentase Diskon:";
            // 
            // deskripsiLabel
            // 
            deskripsiLabel.AutoSize = true;
            deskripsiLabel.Location = new System.Drawing.Point(531, 420);
            deskripsiLabel.Name = "deskripsiLabel";
            deskripsiLabel.Size = new System.Drawing.Size(67, 16);
            deskripsiLabel.TabIndex = 11;
            deskripsiLabel.Text = "Deskripsi:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Master Kode Promo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(323, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Semua kode promo yang terdaftar akan muncul disini";
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
            this.kodeDataGridViewTextBoxColumn,
            this.persentaseDiskonDataGridViewTextBoxColumn,
            this.maksimumDiskonDataGridViewTextBoxColumn,
            this.berlakuSampaiDataGridViewTextBoxColumn,
            this.deskripsiDataGridViewTextBoxColumn,
            this.UbahColumn,
            this.HapusColumn});
            this.dataGridView1.DataSource = this.bindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(35, 102);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(968, 282);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // kodeTextBox
            // 
            this.kodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kodePromoBindingSource, "Kode", true));
            this.kodeTextBox.Location = new System.Drawing.Point(178, 411);
            this.kodeTextBox.Name = "kodeTextBox";
            this.kodeTextBox.Size = new System.Drawing.Size(253, 22);
            this.kodeTextBox.TabIndex = 4;
            this.kodeTextBox.TextChanged += new System.EventHandler(this.kodeTextBox_TextChanged);
            // 
            // berlakuSampaiDateTimePicker
            // 
            this.berlakuSampaiDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.kodePromoBindingSource, "BerlakuSampai", true));
            this.berlakuSampaiDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.berlakuSampaiDateTimePicker.Location = new System.Drawing.Point(178, 450);
            this.berlakuSampaiDateTimePicker.Name = "berlakuSampaiDateTimePicker";
            this.berlakuSampaiDateTimePicker.Size = new System.Drawing.Size(253, 22);
            this.berlakuSampaiDateTimePicker.TabIndex = 6;
            this.berlakuSampaiDateTimePicker.Value = new System.DateTime(2024, 2, 8, 0, 0, 0, 0);
            // 
            // maksimumDiskonNumericUpDown
            // 
            this.maksimumDiskonNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.kodePromoBindingSource, "MaksimumDiskon", true));
            this.maksimumDiskonNumericUpDown.Location = new System.Drawing.Point(178, 525);
            this.maksimumDiskonNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.maksimumDiskonNumericUpDown.Name = "maksimumDiskonNumericUpDown";
            this.maksimumDiskonNumericUpDown.Size = new System.Drawing.Size(253, 22);
            this.maksimumDiskonNumericUpDown.TabIndex = 8;
            this.maksimumDiskonNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // persentaseDiskonNumericUpDown
            // 
            this.persentaseDiskonNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.kodePromoBindingSource, "PersentaseDiskon", true));
            this.persentaseDiskonNumericUpDown.Location = new System.Drawing.Point(178, 489);
            this.persentaseDiskonNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.persentaseDiskonNumericUpDown.Name = "persentaseDiskonNumericUpDown";
            this.persentaseDiskonNumericUpDown.Size = new System.Drawing.Size(253, 22);
            this.persentaseDiskonNumericUpDown.TabIndex = 10;
            this.persentaseDiskonNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // deskripsiTextBox
            // 
            this.deskripsiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kodePromoBindingSource, "Deskripsi", true));
            this.deskripsiTextBox.Location = new System.Drawing.Point(622, 420);
            this.deskripsiTextBox.Multiline = true;
            this.deskripsiTextBox.Name = "deskripsiTextBox";
            this.deskripsiTextBox.Size = new System.Drawing.Size(301, 110);
            this.deskripsiTextBox.TabIndex = 12;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(625, 552);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 37);
            this.button2.TabIndex = 22;
            this.button2.Text = "Batal";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(760, 552);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 37);
            this.button1.TabIndex = 21;
            this.button1.Text = "Simpan";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // kodePromoBindingSource
            // 
            this.kodePromoBindingSource.DataSource = typeof(Bromo.KodePromo);
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
            // kodeDataGridViewTextBoxColumn
            // 
            this.kodeDataGridViewTextBoxColumn.DataPropertyName = "Kode";
            this.kodeDataGridViewTextBoxColumn.HeaderText = "Kode";
            this.kodeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kodeDataGridViewTextBoxColumn.Name = "kodeDataGridViewTextBoxColumn";
            this.kodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // persentaseDiskonDataGridViewTextBoxColumn
            // 
            this.persentaseDiskonDataGridViewTextBoxColumn.DataPropertyName = "PersentaseDiskon";
            this.persentaseDiskonDataGridViewTextBoxColumn.HeaderText = "PersentaseDiskon";
            this.persentaseDiskonDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.persentaseDiskonDataGridViewTextBoxColumn.Name = "persentaseDiskonDataGridViewTextBoxColumn";
            this.persentaseDiskonDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // maksimumDiskonDataGridViewTextBoxColumn
            // 
            this.maksimumDiskonDataGridViewTextBoxColumn.DataPropertyName = "MaksimumDiskon";
            this.maksimumDiskonDataGridViewTextBoxColumn.HeaderText = "MaksimumDiskon";
            this.maksimumDiskonDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maksimumDiskonDataGridViewTextBoxColumn.Name = "maksimumDiskonDataGridViewTextBoxColumn";
            this.maksimumDiskonDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // berlakuSampaiDataGridViewTextBoxColumn
            // 
            this.berlakuSampaiDataGridViewTextBoxColumn.DataPropertyName = "BerlakuSampai";
            this.berlakuSampaiDataGridViewTextBoxColumn.HeaderText = "BerlakuSampai";
            this.berlakuSampaiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.berlakuSampaiDataGridViewTextBoxColumn.Name = "berlakuSampaiDataGridViewTextBoxColumn";
            this.berlakuSampaiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // deskripsiDataGridViewTextBoxColumn
            // 
            this.deskripsiDataGridViewTextBoxColumn.DataPropertyName = "Deskripsi";
            this.deskripsiDataGridViewTextBoxColumn.HeaderText = "Deskripsi";
            this.deskripsiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.deskripsiDataGridViewTextBoxColumn.Name = "deskripsiDataGridViewTextBoxColumn";
            this.deskripsiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(Bromo.KodePromo);
            // 
            // MasterKodePromo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1032, 647);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(deskripsiLabel);
            this.Controls.Add(this.deskripsiTextBox);
            this.Controls.Add(persentaseDiskonLabel);
            this.Controls.Add(this.persentaseDiskonNumericUpDown);
            this.Controls.Add(maksimumDiskonLabel);
            this.Controls.Add(this.maksimumDiskonNumericUpDown);
            this.Controls.Add(berlakuSampaiLabel);
            this.Controls.Add(this.berlakuSampaiDateTimePicker);
            this.Controls.Add(kodeLabel);
            this.Controls.Add(this.kodeTextBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MasterKodePromo";
            this.Text = "MasterKodePromo";
            this.Load += new System.EventHandler(this.MasterKodePromo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maksimumDiskonNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.persentaseDiskonNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kodePromoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource kodePromoBindingSource;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TextBox kodeTextBox;
        private System.Windows.Forms.DateTimePicker berlakuSampaiDateTimePicker;
        private System.Windows.Forms.NumericUpDown maksimumDiskonNumericUpDown;
        private System.Windows.Forms.NumericUpDown persentaseDiskonNumericUpDown;
        private System.Windows.Forms.TextBox deskripsiTextBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn persentaseDiskonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maksimumDiskonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn berlakuSampaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deskripsiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn UbahColumn;
        private System.Windows.Forms.DataGridViewButtonColumn HapusColumn;
    }
}