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
    public partial class JurusanForm : Form
    {
        SMKDBDataContext db = new SMKDBDataContext();
        int kode;
        public JurusanForm(int kode)
        {
            InitializeComponent();
            this.kode = kode;
        }

        private void JurusanForm_Load(object sender, EventArgs e)
        {

            var query = (from b in db.tbl_Jurusans where b.kode_jurusan == kode select b).FirstOrDefault();
            lblNamajurusan.Text = query.nama_jurusan;
            rtbDescription.Text = query.deskripsi_jurusan;
            pictureBox1.ImageLocation = @"photos\\" + query.foto_jurusan;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.Hide();
            new InformationForm().Show();
        }
    }
}
