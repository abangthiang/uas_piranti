namespace UAS_Kelompok5.GUI
{
    partial class Transaksi
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbNama = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbPembayaran = new System.Windows.Forms.ComboBox();
            this.panelBarang = new System.Windows.Forms.Panel();
            this.nudQty = new System.Windows.Forms.NumericUpDown();
            this.btnHapus = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnTambah = new System.Windows.Forms.Button();
            this.lblDisc = new System.Windows.Forms.Label();
            this.cbBarang = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvBarang = new System.Windows.Forms.DataGridView();
            this.KodeBarang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamaBarang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JumlahBarang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Harga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSub = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvTransaksi = new System.Windows.Forms.DataGridView();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnUbah = new System.Windows.Forms.Button();
            this.btnHapusTrans = new System.Windows.Forms.Button();
            this.txtCari = new System.Windows.Forms.TextBox();
            this.btnCari = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panelBarang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBarang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransaksi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nama Customer :";
            // 
            // cbNama
            // 
            this.cbNama.FormattingEnabled = true;
            this.cbNama.Location = new System.Drawing.Point(140, 11);
            this.cbNama.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbNama.Name = "cbNama";
            this.cbNama.Size = new System.Drawing.Size(141, 28);
            this.cbNama.TabIndex = 2;
            this.cbNama.TextChanged += new System.EventHandler(this.cbNama_TextChanged);
            this.cbNama.Click += new System.EventHandler(this.cbNama_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cara Pembayaran :";
            // 
            // cbPembayaran
            // 
            this.cbPembayaran.FormattingEnabled = true;
            this.cbPembayaran.Items.AddRange(new object[] {
            "BCA",
            "OVO",
            "GOPAY"});
            this.cbPembayaran.Location = new System.Drawing.Point(139, 230);
            this.cbPembayaran.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbPembayaran.Name = "cbPembayaran";
            this.cbPembayaran.Size = new System.Drawing.Size(141, 28);
            this.cbPembayaran.TabIndex = 2;
            this.cbPembayaran.Click += new System.EventHandler(this.cbNama_Click);
            // 
            // panelBarang
            // 
            this.panelBarang.Controls.Add(this.nudQty);
            this.panelBarang.Controls.Add(this.btnHapus);
            this.panelBarang.Controls.Add(this.lblTotal);
            this.panelBarang.Controls.Add(this.btnTambah);
            this.panelBarang.Controls.Add(this.lblDisc);
            this.panelBarang.Controls.Add(this.cbBarang);
            this.panelBarang.Controls.Add(this.label10);
            this.panelBarang.Controls.Add(this.label11);
            this.panelBarang.Controls.Add(this.label3);
            this.panelBarang.Controls.Add(this.label7);
            this.panelBarang.Controls.Add(this.dgvBarang);
            this.panelBarang.Controls.Add(this.lblSub);
            this.panelBarang.Controls.Add(this.label5);
            this.panelBarang.Controls.Add(this.label6);
            this.panelBarang.Controls.Add(this.label4);
            this.panelBarang.Controls.Add(this.cbPembayaran);
            this.panelBarang.Controls.Add(this.label2);
            this.panelBarang.Location = new System.Drawing.Point(12, 57);
            this.panelBarang.Name = "panelBarang";
            this.panelBarang.Size = new System.Drawing.Size(890, 385);
            this.panelBarang.TabIndex = 3;
            this.panelBarang.Visible = false;
            // 
            // nudQty
            // 
            this.nudQty.Location = new System.Drawing.Point(700, 89);
            this.nudQty.Name = "nudQty";
            this.nudQty.ReadOnly = true;
            this.nudQty.Size = new System.Drawing.Size(140, 27);
            this.nudQty.TabIndex = 6;
            this.nudQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(765, 130);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(75, 31);
            this.btnHapus.TabIndex = 5;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(120, 344);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(42, 20);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "Rp. 0";
            // 
            // btnTambah
            // 
            this.btnTambah.Location = new System.Drawing.Point(672, 130);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(75, 31);
            this.btnTambah.TabIndex = 5;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // lblDisc
            // 
            this.lblDisc.AutoSize = true;
            this.lblDisc.Location = new System.Drawing.Point(120, 300);
            this.lblDisc.Name = "lblDisc";
            this.lblDisc.Size = new System.Drawing.Size(42, 20);
            this.lblDisc.TabIndex = 5;
            this.lblDisc.Text = "Rp. 0";
            // 
            // cbBarang
            // 
            this.cbBarang.FormattingEnabled = true;
            this.cbBarang.Location = new System.Drawing.Point(700, 54);
            this.cbBarang.Name = "cbBarang";
            this.cbBarang.Size = new System.Drawing.Size(140, 28);
            this.cbBarang.TabIndex = 4;
            this.cbBarang.TextChanged += new System.EventHandler(this.cbBarang_TextChanged);
            this.cbBarang.Click += new System.EventHandler(this.cbBarang_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 321);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(267, 20);
            this.label10.TabIndex = 5;
            this.label10.Text = "-------------------------------------------";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 344);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 20);
            this.label11.TabIndex = 5;
            this.label11.Text = "Total";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 28);
            this.label3.TabIndex = 1;
            this.label3.Text = "Barang yang dibeli";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 300);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "Diskon";
            // 
            // dgvBarang
            // 
            this.dgvBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBarang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KodeBarang,
            this.NamaBarang,
            this.JumlahBarang,
            this.Harga});
            this.dgvBarang.Location = new System.Drawing.Point(8, 54);
            this.dgvBarang.Name = "dgvBarang";
            this.dgvBarang.RowHeadersWidth = 51;
            this.dgvBarang.Size = new System.Drawing.Size(557, 165);
            this.dgvBarang.TabIndex = 0;
            // 
            // KodeBarang
            // 
            this.KodeBarang.HeaderText = "Kode Barang";
            this.KodeBarang.MinimumWidth = 6;
            this.KodeBarang.Name = "KodeBarang";
            this.KodeBarang.Width = 125;
            // 
            // NamaBarang
            // 
            this.NamaBarang.HeaderText = "Nama Barang";
            this.NamaBarang.MinimumWidth = 6;
            this.NamaBarang.Name = "NamaBarang";
            this.NamaBarang.Width = 125;
            // 
            // JumlahBarang
            // 
            this.JumlahBarang.HeaderText = "Jumlah Barang";
            this.JumlahBarang.MinimumWidth = 6;
            this.JumlahBarang.Name = "JumlahBarang";
            this.JumlahBarang.Width = 125;
            // 
            // Harga
            // 
            this.Harga.HeaderText = "Harga";
            this.Harga.MinimumWidth = 6;
            this.Harga.Name = "Harga";
            this.Harga.Width = 125;
            // 
            // lblSub
            // 
            this.lblSub.AutoSize = true;
            this.lblSub.Location = new System.Drawing.Point(120, 275);
            this.lblSub.Name = "lblSub";
            this.lblSub.Size = new System.Drawing.Size(42, 20);
            this.lblSub.TabIndex = 5;
            this.lblSub.Text = "Rp. 0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(579, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Jumlah Barang :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 275);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Sub Total";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(629, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Barang :";
            // 
            // dgvTransaksi
            // 
            this.dgvTransaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransaksi.Location = new System.Drawing.Point(12, 514);
            this.dgvTransaksi.Name = "dgvTransaksi";
            this.dgvTransaksi.RowHeadersWidth = 51;
            this.dgvTransaksi.Size = new System.Drawing.Size(885, 260);
            this.dgvTransaksi.TabIndex = 6;
            this.dgvTransaksi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTransaksi_CellClick);
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(12, 458);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(75, 32);
            this.btnSimpan.TabIndex = 7;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnUbah
            // 
            this.btnUbah.Location = new System.Drawing.Point(93, 458);
            this.btnUbah.Name = "btnUbah";
            this.btnUbah.Size = new System.Drawing.Size(75, 32);
            this.btnUbah.TabIndex = 7;
            this.btnUbah.Text = "Ubah";
            this.btnUbah.UseVisualStyleBackColor = true;
            this.btnUbah.Click += new System.EventHandler(this.btnUbah_Click);
            // 
            // btnHapusTrans
            // 
            this.btnHapusTrans.Location = new System.Drawing.Point(174, 458);
            this.btnHapusTrans.Name = "btnHapusTrans";
            this.btnHapusTrans.Size = new System.Drawing.Size(75, 32);
            this.btnHapusTrans.TabIndex = 7;
            this.btnHapusTrans.Text = "Hapus";
            this.btnHapusTrans.UseVisualStyleBackColor = true;
            this.btnHapusTrans.Click += new System.EventHandler(this.btnHapusTrans_Click);
            // 
            // txtCari
            // 
            this.txtCari.Location = new System.Drawing.Point(659, 472);
            this.txtCari.Name = "txtCari";
            this.txtCari.Size = new System.Drawing.Size(162, 27);
            this.txtCari.TabIndex = 8;
            // 
            // btnCari
            // 
            this.btnCari.Location = new System.Drawing.Point(827, 467);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(75, 32);
            this.btnCari.TabIndex = 9;
            this.btnCari.Text = "Cari";
            this.btnCari.UseVisualStyleBackColor = true;
            this.btnCari.Click += new System.EventHandler(this.btnCari_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(265, 458);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 32);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Transaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 789);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCari);
            this.Controls.Add(this.txtCari);
            this.Controls.Add(this.btnHapusTrans);
            this.Controls.Add(this.btnUbah);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.dgvTransaksi);
            this.Controls.Add(this.panelBarang);
            this.Controls.Add(this.cbNama);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Transaksi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Transaksi";
            this.Load += new System.EventHandler(this.Transaksi_Load);
            this.panelBarang.ResumeLayout(false);
            this.panelBarang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBarang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransaksi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbNama;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbPembayaran;
        private System.Windows.Forms.Panel panelBarang;
        private System.Windows.Forms.DataGridView dgvBarang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbBarang;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.DataGridViewTextBoxColumn KodeBarang;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamaBarang;
        private System.Windows.Forms.DataGridViewTextBoxColumn JumlahBarang;
        private System.Windows.Forms.DataGridViewTextBoxColumn Harga;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblSub;
        private System.Windows.Forms.Label lblDisc;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DataGridView dgvTransaksi;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnUbah;
        private System.Windows.Forms.Button btnHapusTrans;
        private System.Windows.Forms.NumericUpDown nudQty;
        private System.Windows.Forms.TextBox txtCari;
        private System.Windows.Forms.Button btnCari;
        private System.Windows.Forms.Button btnCancel;
    }
}