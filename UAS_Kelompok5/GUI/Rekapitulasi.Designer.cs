namespace UAS_Kelompok5.GUI
{
    partial class Rekapitulasi
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
            this.crvRekap = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.btnUser = new System.Windows.Forms.Button();
            this.btnBarang = new System.Windows.Forms.Button();
            this.btnTransaksi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // crvRekap
            // 
            this.crvRekap.ActiveViewIndex = -1;
            this.crvRekap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvRekap.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvRekap.Location = new System.Drawing.Point(17, 124);
            this.crvRekap.Name = "crvRekap";
            this.crvRekap.Size = new System.Drawing.Size(873, 416);
            this.crvRekap.TabIndex = 1;
            this.crvRekap.ToolPanelWidth = 175;
            // 
            // btnUser
            // 
            this.btnUser.Location = new System.Drawing.Point(17, 32);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(267, 41);
            this.btnUser.TabIndex = 2;
            this.btnUser.Text = "User";
            this.btnUser.UseVisualStyleBackColor = true;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btnBarang
            // 
            this.btnBarang.Location = new System.Drawing.Point(324, 32);
            this.btnBarang.Name = "btnBarang";
            this.btnBarang.Size = new System.Drawing.Size(267, 41);
            this.btnBarang.TabIndex = 2;
            this.btnBarang.Text = "Barang";
            this.btnBarang.UseVisualStyleBackColor = true;
            this.btnBarang.Click += new System.EventHandler(this.btnBarang_Click);
            // 
            // btnTransaksi
            // 
            this.btnTransaksi.Location = new System.Drawing.Point(640, 32);
            this.btnTransaksi.Name = "btnTransaksi";
            this.btnTransaksi.Size = new System.Drawing.Size(267, 41);
            this.btnTransaksi.TabIndex = 2;
            this.btnTransaksi.Text = "Transaksi";
            this.btnTransaksi.UseVisualStyleBackColor = true;
            this.btnTransaksi.Click += new System.EventHandler(this.btnTransaksi_Click);
            // 
            // Rekapitulasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 610);
            this.Controls.Add(this.btnTransaksi);
            this.Controls.Add(this.btnBarang);
            this.Controls.Add(this.btnUser);
            this.Controls.Add(this.crvRekap);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Rekapitulasi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Rekapitulasi";
            this.ResumeLayout(false);

        }

        #endregion
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvRekap;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Button btnBarang;
        private System.Windows.Forms.Button btnTransaksi;
    }
}