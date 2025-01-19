namespace PenjualanProduk
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Label();
            this.login_showpwd = new System.Windows.Forms.CheckBox();
            this.login_btnmasuk = new System.Windows.Forms.Button();
            this.login_pwd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.login_nama = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(245, 411);
            this.panel1.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(30, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 44);
            this.label5.TabIndex = 10;
            this.label5.Text = "Barang";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(30, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 44);
            this.label4.TabIndex = 9;
            this.label4.Text = "Penjualan";
            // 
            // close
            // 
            this.close.AutoSize = true;
            this.close.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.Location = new System.Drawing.Point(574, -18);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(18, 19);
            this.close.TabIndex = 18;
            this.close.Text = "x";
            // 
            // login_showpwd
            // 
            this.login_showpwd.AutoSize = true;
            this.login_showpwd.Location = new System.Drawing.Point(276, 251);
            this.login_showpwd.Name = "login_showpwd";
            this.login_showpwd.Size = new System.Drawing.Size(93, 17);
            this.login_showpwd.TabIndex = 17;
            this.login_showpwd.Text = "Lihat Pasword";
            this.login_showpwd.UseVisualStyleBackColor = true;
            this.login_showpwd.CheckedChanged += new System.EventHandler(this.login_showpwd_CheckedChanged);
            // 
            // login_btnmasuk
            // 
            this.login_btnmasuk.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.login_btnmasuk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login_btnmasuk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_btnmasuk.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_btnmasuk.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.login_btnmasuk.Location = new System.Drawing.Point(276, 354);
            this.login_btnmasuk.Name = "login_btnmasuk";
            this.login_btnmasuk.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.login_btnmasuk.Size = new System.Drawing.Size(139, 33);
            this.login_btnmasuk.TabIndex = 16;
            this.login_btnmasuk.Text = "Masuk";
            this.login_btnmasuk.UseVisualStyleBackColor = false;
            this.login_btnmasuk.Click += new System.EventHandler(this.login_btnmasuk_Click);
            // 
            // login_pwd
            // 
            this.login_pwd.BackColor = System.Drawing.SystemColors.Menu;
            this.login_pwd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.login_pwd.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_pwd.Location = new System.Drawing.Point(276, 211);
            this.login_pwd.Name = "login_pwd";
            this.login_pwd.PasswordChar = '*';
            this.login_pwd.Size = new System.Drawing.Size(223, 29);
            this.login_pwd.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(272, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 18);
            this.label3.TabIndex = 14;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(272, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 18);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nama";
            // 
            // login_nama
            // 
            this.login_nama.BackColor = System.Drawing.SystemColors.Menu;
            this.login_nama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.login_nama.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_nama.Location = new System.Drawing.Point(276, 144);
            this.login_nama.Name = "login_nama";
            this.login_nama.Size = new System.Drawing.Size(223, 29);
            this.login_nama.TabIndex = 12;
            this.login_nama.TextChanged += new System.EventHandler(this.login_nama_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(270, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 32);
            this.label1.TabIndex = 11;
            this.label1.Text = "Login";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(575, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 19);
            this.label6.TabIndex = 19;
            this.label6.Text = "x";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 411);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.close);
            this.Controls.Add(this.login_showpwd);
            this.Controls.Add(this.login_btnmasuk);
            this.Controls.Add(this.login_pwd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.login_nama);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label close;
        private System.Windows.Forms.CheckBox login_showpwd;
        private System.Windows.Forms.Button login_btnmasuk;
        private System.Windows.Forms.TextBox login_pwd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox login_nama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
    }
}

