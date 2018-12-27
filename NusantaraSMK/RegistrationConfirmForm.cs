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
    public partial class RegistrationConfirmForm : Form
    {
        SMKDBDataContext db = new SMKDBDataContext();
        validasi va;
        int no;
        public RegistrationConfirmForm(int no)
        {
            InitializeComponent();
            this.no = no;
            va = new validasi(this.eValidasi, this.Controls);
        }

        private void RegistrationConfirmForm_Load(object sender, EventArgs e)
        {
            var query = (from cs in db.tbl_CalonSiswas
                        join p in db.tbl_Pilihans
                        on cs.no_pendaftaran equals p.no_pendaftaran
                        where cs.no_pendaftaran == no
                        select new { cs, p }).FirstOrDefault();

            lblNoPendaftar.Text = query.cs.no_pendaftaran.ToString();
            lblNamaPendaftar.Text = query.cs.nama;
            var prio = (from pil in db.tbl_Pilihans
                        where pil.no_pendaftaran == int.Parse(lblNoPendaftar.Text)
                        select pil).FirstOrDefault();
            var prio1 = (from jr in db.tbl_Jurusans
                        where jr.kode_jurusan == int.Parse(prio.prioritas1)
                        select jr.nama_jurusan).FirstOrDefault();
            var prio2 = (from jr in db.tbl_Jurusans
                         where jr.kode_jurusan == int.Parse(prio.prioritas2)
                         select jr.nama_jurusan).FirstOrDefault();
            var prio3 = (from jr in db.tbl_Jurusans
                         where jr.kode_jurusan == int.Parse(prio.prioritas3)
                         select jr.nama_jurusan).FirstOrDefault();
            lblPrioritas1.Text = prio1;
            lblPrioritas2.Text = prio2;
            lblPrioritas3.Text = prio3;
            lblUsername.Text = query.cs.no_pendaftaran.ToString();
            va.getRandom(8, lblPassword);
            tbl_CalonSiswa q = db.tbl_CalonSiswas.FirstOrDefault(x => x.no_pendaftaran == int.Parse(lblUsername.Text));
            q.password = lblPassword.Text;
            db.SubmitChanges();

        }

        private void btnSelesai_Click(object sender, EventArgs e)
        {
            this.Close();
            new LoginForm().Show();
        }
    }
}
