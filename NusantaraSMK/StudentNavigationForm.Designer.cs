namespace NusantaraSMK
{
    partial class StudentNavigationForm
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
            this.lblNama = new System.Windows.Forms.Label();
            this.btnUnduh = new System.Windows.Forms.Button();
            this.btnLihat = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNama.Location = new System.Drawing.Point(12, 34);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(195, 16);
            this.lblNama.TabIndex = 0;
            this.lblNama.Text = "Selamat Datang, [Nama Siswa]";
            // 
            // btnUnduh
            // 
            this.btnUnduh.Location = new System.Drawing.Point(15, 64);
            this.btnUnduh.Name = "btnUnduh";
            this.btnUnduh.Size = new System.Drawing.Size(269, 72);
            this.btnUnduh.TabIndex = 1;
            this.btnUnduh.Text = "Unduh Soal Test";
            this.btnUnduh.UseVisualStyleBackColor = true;
            this.btnUnduh.Click += new System.EventHandler(this.btnUnduh_Click);
            // 
            // btnLihat
            // 
            this.btnLihat.Location = new System.Drawing.Point(15, 142);
            this.btnLihat.Name = "btnLihat";
            this.btnLihat.Size = new System.Drawing.Size(269, 72);
            this.btnLihat.TabIndex = 2;
            this.btnLihat.Text = "Lihat Hasil Test";
            this.btnLihat.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(209, 233);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // StudentNavigationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 279);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnLihat);
            this.Controls.Add(this.btnUnduh);
            this.Controls.Add(this.lblNama);
            this.Name = "StudentNavigationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Beranda Siswa";
            this.Load += new System.EventHandler(this.StudentNavigationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.Button btnUnduh;
        private System.Windows.Forms.Button btnLihat;
        private System.Windows.Forms.Button btnLogout;
    }
}