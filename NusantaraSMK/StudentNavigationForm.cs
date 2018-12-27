using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace NusantaraSMK
{
    public partial class StudentNavigationForm : Form
    {
        SMKDBDataContext db = new SMKDBDataContext();
        validasi va;
        public StudentNavigationForm()
        {
            InitializeComponent();
        }

        private void StudentNavigationForm_Load(object sender, EventArgs e)
        {
            lblNama.Text = "Selamat Datang," + session.nama;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            session.nama = "";
            session.role = "";
            this.Close();
            new MainForm().Show();
        }

        private void btnUnduh_Click(object sender, EventArgs e)
        {
            string path = @"files\\Formulir Pendaftaran - SNMPTN.pdf";
            string path2 = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.Desktop)) + "\\Formulir Pendaftaran - SNMPTN.pdf";
            if (File.Exists(path2))
                File.Delete(path2);
                File.Copy(path, path2);
                MessageBox.Show("Berhasil terunduh\nSilahkan lihat didesktop Anda!");
        }
    }
}
