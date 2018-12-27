namespace NusantaraSMK
{
    partial class ExamEvalutionForm
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnKembali = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DownloadJawaban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KodePendaftaran = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamaLengkap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NilaiPG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NilaiEssay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NilaiKasus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pilih Kode Ujian:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(169, 22);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(275, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(450, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnKembali
            // 
            this.btnKembali.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnKembali.Location = new System.Drawing.Point(670, 25);
            this.btnKembali.Name = "btnKembali";
            this.btnKembali.Size = new System.Drawing.Size(75, 23);
            this.btnKembali.TabIndex = 7;
            this.btnKembali.Text = "Kembali";
            this.btnKembali.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Daftar Peserta Ujian";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(358, 75);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(136, 21);
            this.comboBox2.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(500, 76);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(245, 20);
            this.textBox1.TabIndex = 10;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DownloadJawaban,
            this.KodePendaftaran,
            this.NamaLengkap,
            this.NilaiPG,
            this.NilaiEssay,
            this.NilaiKasus});
            this.dataGridView1.Location = new System.Drawing.Point(42, 111);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(703, 248);
            this.dataGridView1.TabIndex = 11;
            // 
            // DownloadJawaban
            // 
            this.DownloadJawaban.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DownloadJawaban.HeaderText = "Download Jawaban";
            this.DownloadJawaban.Name = "DownloadJawaban";
            // 
            // KodePendaftaran
            // 
            this.KodePendaftaran.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.KodePendaftaran.HeaderText = "Kode Pendaftaran";
            this.KodePendaftaran.Name = "KodePendaftaran";
            // 
            // NamaLengkap
            // 
            this.NamaLengkap.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NamaLengkap.HeaderText = "Nama Lengkap";
            this.NamaLengkap.Name = "NamaLengkap";
            // 
            // NilaiPG
            // 
            this.NilaiPG.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NilaiPG.HeaderText = "Nilai PG";
            this.NilaiPG.Name = "NilaiPG";
            // 
            // NilaiEssay
            // 
            this.NilaiEssay.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NilaiEssay.HeaderText = "Nilai Essay";
            this.NilaiEssay.Name = "NilaiEssay";
            // 
            // NilaiKasus
            // 
            this.NilaiKasus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NilaiKasus.HeaderText = "Nilai Kasus";
            this.NilaiKasus.Name = "NilaiKasus";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(494, 362);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(251, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Terakhir di Update pada : 11 Desember 2015 21:45\r\n";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(317, 386);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 53);
            this.button2.TabIndex = 13;
            this.button2.Text = "Simpan Hasil Koreksi";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // ExamEvalutionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 455);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnKembali);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Name = "ExamEvalutionForm";
            this.Text = "ExamEvalutionForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnKembali;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn DownloadJawaban;
        private System.Windows.Forms.DataGridViewTextBoxColumn KodePendaftaran;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamaLengkap;
        private System.Windows.Forms.DataGridViewTextBoxColumn NilaiPG;
        private System.Windows.Forms.DataGridViewTextBoxColumn NilaiEssay;
        private System.Windows.Forms.DataGridViewTextBoxColumn NilaiKasus;
    }
}