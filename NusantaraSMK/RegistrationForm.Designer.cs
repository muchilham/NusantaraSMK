namespace NusantaraSMK
{
    partial class RegistrationForm
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
            this.btnKembali = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbAsalsekolah = new System.Windows.Forms.TextBox();
            this.rbPerempuan = new System.Windows.Forms.RadioButton();
            this.rbLaki = new System.Windows.Forms.RadioButton();
            this.tbNotelp = new System.Windows.Forms.TextBox();
            this.dtpTgllahir = new System.Windows.Forms.DateTimePicker();
            this.rtbAlamat = new System.Windows.Forms.RichTextBox();
            this.tbNama = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbPrio3 = new System.Windows.Forms.ComboBox();
            this.cbPrio2 = new System.Windows.Forms.ComboBox();
            this.cbPrio1 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbKode = new System.Windows.Forms.TextBox();
            this.lblKode = new System.Windows.Forms.Label();
            this.btnDaftar = new System.Windows.Forms.Button();
            this.eValidasi = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eValidasi)).BeginInit();
            this.SuspendLayout();
            // 
            // btnKembali
            // 
            this.btnKembali.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnKembali.Location = new System.Drawing.Point(454, 12);
            this.btnKembali.Name = "btnKembali";
            this.btnKembali.Size = new System.Drawing.Size(75, 23);
            this.btnKembali.TabIndex = 7;
            this.btnKembali.Text = "Kembali";
            this.btnKembali.UseVisualStyleBackColor = true;
            this.btnKembali.Click += new System.EventHandler(this.btnKembali_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 31);
            this.label1.TabIndex = 8;
            this.label1.Text = "Pendaftaran Siswa Baru";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.tbEmail);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbAsalsekolah);
            this.groupBox1.Controls.Add(this.rbPerempuan);
            this.groupBox1.Controls.Add(this.rbLaki);
            this.groupBox1.Controls.Add(this.tbNotelp);
            this.groupBox1.Controls.Add(this.dtpTgllahir);
            this.groupBox1.Controls.Add(this.rtbAlamat);
            this.groupBox1.Controls.Add(this.tbNama);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(517, 275);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Biodata Siswa";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(19, 244);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 13);
            this.label11.TabIndex = 31;
            this.label11.Text = "Email";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(131, 241);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(350, 20);
            this.tbEmail.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Asal Sekolah";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Jenis Kelamin";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "No. Telepon";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Tanggal Lahir";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Alamat";
            // 
            // tbAsalsekolah
            // 
            this.tbAsalsekolah.Location = new System.Drawing.Point(131, 215);
            this.tbAsalsekolah.Name = "tbAsalsekolah";
            this.tbAsalsekolah.Size = new System.Drawing.Size(350, 20);
            this.tbAsalsekolah.TabIndex = 24;
            // 
            // rbPerempuan
            // 
            this.rbPerempuan.AutoSize = true;
            this.rbPerempuan.Location = new System.Drawing.Point(287, 192);
            this.rbPerempuan.Name = "rbPerempuan";
            this.rbPerempuan.Size = new System.Drawing.Size(79, 17);
            this.rbPerempuan.TabIndex = 23;
            this.rbPerempuan.TabStop = true;
            this.rbPerempuan.Text = "Perempuan";
            this.rbPerempuan.UseVisualStyleBackColor = true;
            // 
            // rbLaki
            // 
            this.rbLaki.AutoSize = true;
            this.rbLaki.Location = new System.Drawing.Point(131, 192);
            this.rbLaki.Name = "rbLaki";
            this.rbLaki.Size = new System.Drawing.Size(64, 17);
            this.rbLaki.TabIndex = 22;
            this.rbLaki.TabStop = true;
            this.rbLaki.Text = "Laki-laki";
            this.rbLaki.UseVisualStyleBackColor = true;
            // 
            // tbNotelp
            // 
            this.tbNotelp.Location = new System.Drawing.Point(131, 166);
            this.tbNotelp.Name = "tbNotelp";
            this.tbNotelp.Size = new System.Drawing.Size(350, 20);
            this.tbNotelp.TabIndex = 21;
            this.tbNotelp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNotelp_KeyPress);
            // 
            // dtpTgllahir
            // 
            this.dtpTgllahir.Location = new System.Drawing.Point(131, 140);
            this.dtpTgllahir.Name = "dtpTgllahir";
            this.dtpTgllahir.Size = new System.Drawing.Size(350, 20);
            this.dtpTgllahir.TabIndex = 20;
            // 
            // rtbAlamat
            // 
            this.rtbAlamat.Location = new System.Drawing.Point(131, 55);
            this.rtbAlamat.Name = "rtbAlamat";
            this.rtbAlamat.Size = new System.Drawing.Size(350, 68);
            this.rtbAlamat.TabIndex = 19;
            this.rtbAlamat.Text = "";
            // 
            // tbNama
            // 
            this.tbNama.Location = new System.Drawing.Point(131, 28);
            this.tbNama.Name = "tbNama";
            this.tbNama.Size = new System.Drawing.Size(350, 20);
            this.tbNama.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Nama Lengkap";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbPrio3);
            this.groupBox2.Controls.Add(this.cbPrio2);
            this.groupBox2.Controls.Add(this.cbPrio1);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(12, 337);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(517, 119);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pilihan Jurusan";
            // 
            // cbPrio3
            // 
            this.cbPrio3.FormattingEnabled = true;
            this.cbPrio3.Location = new System.Drawing.Point(131, 78);
            this.cbPrio3.Name = "cbPrio3";
            this.cbPrio3.Size = new System.Drawing.Size(350, 21);
            this.cbPrio3.TabIndex = 37;
            // 
            // cbPrio2
            // 
            this.cbPrio2.FormattingEnabled = true;
            this.cbPrio2.Location = new System.Drawing.Point(131, 52);
            this.cbPrio2.Name = "cbPrio2";
            this.cbPrio2.Size = new System.Drawing.Size(350, 21);
            this.cbPrio2.TabIndex = 36;
            // 
            // cbPrio1
            // 
            this.cbPrio1.FormattingEnabled = true;
            this.cbPrio1.Location = new System.Drawing.Point(131, 26);
            this.cbPrio1.Name = "cbPrio1";
            this.cbPrio1.Size = new System.Drawing.Size(350, 21);
            this.cbPrio1.TabIndex = 35;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 81);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 34;
            this.label10.Text = "Prioritas 3";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 33;
            this.label9.Text = "Prioritas 2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "Prioritas 1";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbKode);
            this.groupBox3.Controls.Add(this.lblKode);
            this.groupBox3.Location = new System.Drawing.Point(12, 462);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(383, 60);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Masukkan Kode berikut untuk melanjutkan pendaftaran";
            // 
            // tbKode
            // 
            this.tbKode.Location = new System.Drawing.Point(131, 25);
            this.tbKode.Name = "tbKode";
            this.tbKode.Size = new System.Drawing.Size(241, 20);
            this.tbKode.TabIndex = 32;
            this.tbKode.TextChanged += new System.EventHandler(this.tbKode_TextChanged);
            // 
            // lblKode
            // 
            this.lblKode.AutoSize = true;
            this.lblKode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKode.Location = new System.Drawing.Point(11, 25);
            this.lblKode.Name = "lblKode";
            this.lblKode.Size = new System.Drawing.Size(0, 18);
            this.lblKode.TabIndex = 31;
            // 
            // btnDaftar
            // 
            this.btnDaftar.Location = new System.Drawing.Point(401, 462);
            this.btnDaftar.Name = "btnDaftar";
            this.btnDaftar.Size = new System.Drawing.Size(128, 60);
            this.btnDaftar.TabIndex = 20;
            this.btnDaftar.Text = "DAFTAR";
            this.btnDaftar.UseVisualStyleBackColor = true;
            this.btnDaftar.Click += new System.EventHandler(this.btnDaftar_Click);
            // 
            // eValidasi
            // 
            this.eValidasi.ContainerControl = this;
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 548);
            this.Controls.Add(this.btnDaftar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnKembali);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(557, 587);
            this.MinimumSize = new System.Drawing.Size(557, 587);
            this.Name = "RegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PendaftaranForm";
            this.Load += new System.EventHandler(this.PendaftaranForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eValidasi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKembali;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbAsalsekolah;
        private System.Windows.Forms.RadioButton rbPerempuan;
        private System.Windows.Forms.RadioButton rbLaki;
        private System.Windows.Forms.TextBox tbNotelp;
        private System.Windows.Forms.DateTimePicker dtpTgllahir;
        private System.Windows.Forms.RichTextBox rtbAlamat;
        private System.Windows.Forms.TextBox tbNama;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbPrio3;
        private System.Windows.Forms.ComboBox cbPrio2;
        private System.Windows.Forms.ComboBox cbPrio1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbKode;
        private System.Windows.Forms.Label lblKode;
        private System.Windows.Forms.Button btnDaftar;
        private System.Windows.Forms.ErrorProvider eValidasi;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbEmail;
    }
}