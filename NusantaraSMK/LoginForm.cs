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
    public partial class LoginForm : Form
    {
        SMKDBDataContext db = new SMKDBDataContext();
        validasi va;
        tbl_CalonSiswa cs;
        tbl_Staf st;
        tbl_Staf_Tu tu;
        tbl_Guru gr;
        public LoginForm()
        {
            InitializeComponent();
            va = new validasi(this.eValidasi, this.Controls);
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.Close();
            new MainForm().Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (va.doValidation() == false) return;
            cs = db.tbl_CalonSiswas.FirstOrDefault(x => x.no_pendaftaran == int.Parse(tbUsername.Text) && x.password == tbPassword.Text);
            st = db.tbl_Stafs.FirstOrDefault(x => x.nip == int.Parse(tbUsername.Text) && x.password == tbPassword.Text);
            if(cs != null)            
            {
                session.role = cbRole.Text;
                var query = (from css in db.tbl_CalonSiswas
                            where css.no_pendaftaran == int.Parse(tbUsername.Text)
                            select css.nama).FirstOrDefault();
                session.nama = query;
                this.Hide();
                new StudentNavigationForm().Show();
            }

            else if(st != null)
            {
                tu = db.tbl_Staf_Tus.FirstOrDefault(i => i.nip == int.Parse(tbUsername.Text));
                gr = db.tbl_Gurus.FirstOrDefault(i => i.nip == int.Parse(tbUsername.Text));
                if(tu != null)
                {
                    session.role = "Staf - TU";
                    session.nama = tbUsername.Text;
                }

                else if(gr != null)
                {
                    session.role = "Guru";
                    session.nama = tbUsername.Text;
                }

                else
                {
                    lblError.Text = "Bukan " + cbRole.Text;
                    return;
                }

                this.Close();
                new TeacherNavigationForm().Show();
            }

            else
            {
                lblError.Text = "Login Failed";
            }
        }

        private void tbUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            va.numberFormat(e);
        }
    }
}
