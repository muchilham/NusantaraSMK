namespace NusantaraSMK
{
    partial class TeacherNavigationForm
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
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnHasil = new System.Windows.Forms.Button();
            this.btnKoreksi = new System.Windows.Forms.Button();
            this.lblNama = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(209, 233);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnHasil
            // 
            this.btnHasil.Location = new System.Drawing.Point(15, 142);
            this.btnHasil.Name = "btnHasil";
            this.btnHasil.Size = new System.Drawing.Size(269, 72);
            this.btnHasil.TabIndex = 6;
            this.btnHasil.Text = "Lihat Hasil Ujian";
            this.btnHasil.UseVisualStyleBackColor = true;
            // 
            // btnKoreksi
            // 
            this.btnKoreksi.Location = new System.Drawing.Point(15, 64);
            this.btnKoreksi.Name = "btnKoreksi";
            this.btnKoreksi.Size = new System.Drawing.Size(269, 72);
            this.btnKoreksi.TabIndex = 5;
            this.btnKoreksi.Text = "Koreksi Hasil Ujian";
            this.btnKoreksi.UseVisualStyleBackColor = true;
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNama.Location = new System.Drawing.Point(12, 34);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(187, 16);
            this.lblNama.TabIndex = 4;
            this.lblNama.Text = "Selamat Datang, [Nama Guru]";
            // 
            // TeacherNavigationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 279);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnHasil);
            this.Controls.Add(this.btnKoreksi);
            this.Controls.Add(this.lblNama);
            this.Name = "TeacherNavigationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Beranda Guru";
            this.Load += new System.EventHandler(this.TeacherNavigationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnHasil;
        private System.Windows.Forms.Button btnKoreksi;
        private System.Windows.Forms.Label lblNama;
    }
}