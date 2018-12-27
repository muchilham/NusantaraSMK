using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NusantaraSMK
{
    public partial class TeacherNavigationForm : Form
    {
        SMKDBDataContext db = new SMKDBDataContext();
        validasi va;
        public TeacherNavigationForm()
        {
            InitializeComponent();
        }

        private void TeacherNavigationForm_Load(object sender, EventArgs e)
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
    }
}
