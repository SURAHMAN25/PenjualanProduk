namespace PenjualanProduk.View
{
    partial class frmTransaksi
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
            this.label2 = new System.Windows.Forms.Label();
            this.btn_cari = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.btn_hapus = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Label();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_logout = new System.Windows.Forms.Button();
            this.btn_pelanggan = new System.Windows.Forms.Button();
            this.btn_tambah = new System.Windows.Forms.Button();
            this.btn_transaksi = new System.Windows.Forms.Button();
            this.btn_dashboard = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_produk = new System.Windows.Forms.Button();
            this.lvw_transaksi = new System.Windows.Forms.ListView();
            this.label9 = new System.Windows.Forms.Label();
            this.Nama_Produk = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(7, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(330, 75);
            this.label2.TabIndex = 25;
            this.label2.Text = "Transaksi";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_cari
            // 
            this.btn_cari.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cari.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_cari.Location = new System.Drawing.Point(711, 132);
            this.btn_cari.Name = "btn_cari";
            this.btn_cari.Size = new System.Drawing.Size(65, 26);
            this.btn_cari.TabIndex = 23;
            this.btn_cari.Text = "Cari";
            this.btn_cari.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button7.Location = new System.Drawing.Point(986, 107);
            this.button7.Name = "button7";
            this.button7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button7.Size = new System.Drawing.Size(0, 0);
            this.button7.TabIndex = 31;
            this.button7.Text = "Total Admin";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // btn_hapus
            // 
            this.btn_hapus.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_hapus.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_hapus.Location = new System.Drawing.Point(675, 24);
            this.btn_hapus.Name = "btn_hapus";
            this.btn_hapus.Size = new System.Drawing.Size(101, 78);
            this.btn_hapus.TabIndex = 24;
            this.btn_hapus.Text = "HAPUS";
            this.btn_hapus.UseVisualStyleBackColor = true;
            // 
            // close
            // 
            this.close.AutoSize = true;
            this.close.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.Location = new System.Drawing.Point(1059, 1);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(18, 19);
            this.close.TabIndex = 32;
            this.close.Text = "x";
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_edit.Location = new System.Drawing.Point(553, 24);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(101, 78);
            this.btn_edit.TabIndex = 24;
            this.btn_edit.Text = "EDIT";
            this.btn_edit.UseVisualStyleBackColor = true;
            // 
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_logout.FlatAppearance.BorderSize = 0;
            this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logout.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_logout.Location = new System.Drawing.Point(0, 722);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_logout.Size = new System.Drawing.Size(242, 46);
            this.btn_logout.TabIndex = 20;
            this.btn_logout.Text = "Log Out";
            this.btn_logout.UseVisualStyleBackColor = false;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // btn_pelanggan
            // 
            this.btn_pelanggan.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_pelanggan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_pelanggan.FlatAppearance.BorderSize = 0;
            this.btn_pelanggan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pelanggan.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pelanggan.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_pelanggan.Location = new System.Drawing.Point(34, 353);
            this.btn_pelanggan.Name = "btn_pelanggan";
            this.btn_pelanggan.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_pelanggan.Size = new System.Drawing.Size(208, 46);
            this.btn_pelanggan.TabIndex = 19;
            this.btn_pelanggan.Text = "Pelanggan";
            this.btn_pelanggan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_pelanggan.UseVisualStyleBackColor = false;
            this.btn_pelanggan.Click += new System.EventHandler(this.btn_pelanggan_Click);
            // 
            // btn_tambah
            // 
            this.btn_tambah.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tambah.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_tambah.Location = new System.Drawing.Point(428, 24);
            this.btn_tambah.Name = "btn_tambah";
            this.btn_tambah.Size = new System.Drawing.Size(101, 78);
            this.btn_tambah.TabIndex = 24;
            this.btn_tambah.Text = "TAMBAH";
            this.btn_tambah.UseVisualStyleBackColor = true;
            this.btn_tambah.Click += new System.EventHandler(this.btn_tambah_Click);
            // 
            // btn_transaksi
            // 
            this.btn_transaksi.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_transaksi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_transaksi.FlatAppearance.BorderSize = 0;
            this.btn_transaksi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_transaksi.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_transaksi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_transaksi.Location = new System.Drawing.Point(34, 414);
            this.btn_transaksi.Name = "btn_transaksi";
            this.btn_transaksi.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_transaksi.Size = new System.Drawing.Size(208, 46);
            this.btn_transaksi.TabIndex = 22;
            this.btn_transaksi.Text = "Transaksi";
            this.btn_transaksi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_transaksi.UseVisualStyleBackColor = false;
            // 
            // btn_dashboard
            // 
            this.btn_dashboard.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_dashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_dashboard.FlatAppearance.BorderSize = 0;
            this.btn_dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dashboard.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dashboard.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_dashboard.Location = new System.Drawing.Point(34, 225);
            this.btn_dashboard.Name = "btn_dashboard";
            this.btn_dashboard.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_dashboard.Size = new System.Drawing.Size(211, 46);
            this.btn_dashboard.TabIndex = 17;
            this.btn_dashboard.Text = "Dashboard";
            this.btn_dashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_dashboard.UseVisualStyleBackColor = false;
            this.btn_dashboard.Click += new System.EventHandler(this.btn_dashboard_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.btn_transaksi);
            this.panel1.Controls.Add(this.btn_dashboard);
            this.panel1.Controls.Add(this.btn_logout);
            this.panel1.Controls.Add(this.btn_pelanggan);
            this.panel1.Controls.Add(this.btn_produk);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(245, 791);
            this.panel1.TabIndex = 33;
            // 
            // btn_produk
            // 
            this.btn_produk.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_produk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_produk.FlatAppearance.BorderSize = 0;
            this.btn_produk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_produk.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_produk.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_produk.Location = new System.Drawing.Point(34, 291);
            this.btn_produk.Name = "btn_produk";
            this.btn_produk.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_produk.Size = new System.Drawing.Size(211, 46);
            this.btn_produk.TabIndex = 18;
            this.btn_produk.Text = "Produk";
            this.btn_produk.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_produk.UseVisualStyleBackColor = false;
            this.btn_produk.Click += new System.EventHandler(this.btn_produk_Click);
            // 
            // lvw_transaksi
            // 
            this.lvw_transaksi.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvw_transaksi.HideSelection = false;
            this.lvw_transaksi.Location = new System.Drawing.Point(20, 173);
            this.lvw_transaksi.Name = "lvw_transaksi";
            this.lvw_transaksi.Size = new System.Drawing.Size(754, 556);
            this.lvw_transaksi.TabIndex = 0;
            this.lvw_transaksi.UseCompatibleStateImageBehavior = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(13, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 37);
            this.label9.TabIndex = 10;
            this.label9.Text = "Data";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Nama_Produk
            // 
            this.Nama_Produk.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nama_Produk.Location = new System.Drawing.Point(20, 132);
            this.Nama_Produk.Name = "Nama_Produk";
            this.Nama_Produk.Size = new System.Drawing.Size(673, 26);
            this.Nama_Produk.TabIndex = 22;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.btn_hapus);
            this.panel4.Controls.Add(this.btn_cari);
            this.panel4.Controls.Add(this.btn_edit);
            this.panel4.Controls.Add(this.lvw_transaksi);
            this.panel4.Controls.Add(this.btn_tambah);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.Nama_Produk);
            this.panel4.Location = new System.Drawing.Point(264, 22);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(795, 746);
            this.panel4.TabIndex = 34;
            // 
            // pictureBox1
            // 
            this.pictureBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::PenjualanProduk.Properties.Resources.Proyek_Baru_85__E14C6A4_;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(-4, -28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(277, 277);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // frmTransaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 790);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.close);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTransaksi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormTransaksi";
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_cari;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_hapus;
        private System.Windows.Forms.Label close;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Button btn_pelanggan;
        private System.Windows.Forms.Button btn_tambah;
        private System.Windows.Forms.Button btn_transaksi;
        private System.Windows.Forms.Button btn_dashboard;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_produk;
        private System.Windows.Forms.ListView lvw_transaksi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Nama_Produk;
        private System.Windows.Forms.Panel panel4;
    }
}