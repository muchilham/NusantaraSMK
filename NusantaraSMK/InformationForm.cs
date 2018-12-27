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
    public partial class InformationForm : Form
    {
        SMKDBDataContext db = new SMKDBDataContext();
        public InformationForm()
        {
            InitializeComponent();
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.Close();
            new MainForm().Show();
        }

        private void InformationForm_Load(object sender, EventArgs e)
        {
            cmbJurusan.DataSource = from b in db.tbl_Jurusans select b;
            cmbJurusan.ValueMember = "kode_jurusan";
            cmbJurusan.DisplayMember = "nama_jurusan";
        }

        private void btnLihatInfo_Click(object sender, EventArgs e)
        {
            this.Hide();
            new JurusanForm(int.Parse(cmbJurusan.SelectedValue.ToString())).Show();
        }
    }
}
