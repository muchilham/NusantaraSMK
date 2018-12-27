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
    public partial class RegistrationForm : Form
    {
        SMKDBDataContext db = new SMKDBDataContext();
        validasi va;
        tbl_CalonSiswa cs;
        String pk = "";
        public RegistrationForm()
        {
            InitializeComponent();
            va = new validasi(this.eValidasi, this.Controls);
        }

        private void data(ComboBox c)
        {
            c.DataSource = from b in db.tbl_Jurusans select b;
            c.ValueMember = "kode_jurusan";
            c.DisplayMember = "nama_jurusan";
        }

        private void PendaftaranForm_Load(object sender, EventArgs e)
        {
            btnDaftar.Enabled = false;
            data(cbPrio1);
            data(cbPrio2);
            data(cbPrio3);
            va.getRandom(10, lblKode);
            va.getRandomInt(8);
            pk = va.pk;
            var query = from cs in db.tbl_CalonSiswas
                        where cs.no_pendaftaran == int.Parse(pk)
                        select cs.no_pendaftaran;
        }

        private void tbKode_TextChanged(object sender, EventArgs e)
        {
            btnDaftar.Enabled = true;
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.Close();
            new MainForm().Show();
        }

        private void btnDaftar_Click(object sender, EventArgs e)
        {
            String jenkel;
            if (tbKode.Text != lblKode.Text)
            {
                MessageBox.Show("Kode yang anda masukkan salah, silahkan coba lagi!");
                return;
            }
            if (va.doValidation() == false) return;
            if (rbLaki.Checked == true) { jenkel = rbLaki.Text; }
            else { jenkel = rbPerempuan.Text; }
            cs = new tbl_CalonSiswa
            {
                no_pendaftaran = int.Parse(pk),
                nama = tbNama.Text,
                tgl_lahir = dtpTgllahir.Value,
                alamat = rtbAlamat.Text,
                email = tbEmail.Text,
                jenis_kelamin = jenkel,
                asal_sekolah = tbAsalsekolah.Text
            };



            tbl_Pilihan pl = new tbl_Pilihan
            {
                no_pendaftaran = int.Parse(pk),
                prioritas1 = cbPrio1.SelectedValue.ToString(),
                prioritas2 = cbPrio2.SelectedValue.ToString(),
                prioritas3 = cbPrio3.SelectedValue.ToString()
            };

            db.tbl_CalonSiswas.InsertOnSubmit(cs);
            db.SubmitChanges();
            db.tbl_Pilihans.InsertOnSubmit(pl);
            db.SubmitChanges();

            this.Hide();
            new RegistrationConfirmForm(cs.no_pendaftaran).Show();
        }

        private void tbNotelp_KeyPress(object sender, KeyPressEventArgs e)
        {
            va.numberFormat(e);
        }
    }
}
