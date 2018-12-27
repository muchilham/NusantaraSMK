using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NusantaraSMK
{
    class validasi
    {
        ErrorProvider eValidasi;
        Control.ControlCollection ctl;

        public validasi(ErrorProvider err, Control.ControlCollection ctl)
        {
            this.eValidasi = err;
            this.ctl = ctl;
        }

        public string pk { get; set; }

        public void clear(String skip)
        {
            foreach(Control ctl in this.ctl)
            {
                if(ctl.GetType() == typeof(TextBox) || ctl.GetType() == typeof(RichTextBox))
                {
                    if (ctl.Name == skip) continue;
                    ctl.Text = "";
                }

                if (ctl.GetType() == typeof(ComboBox))
                    ((ComboBox)ctl).Text = "";
                if (ctl.GetType() == typeof(NumericUpDown))
                    ((NumericUpDown)ctl).Value = 1;
                if (ctl.GetType() == typeof(DateTimePicker))
                    ((DateTimePicker)ctl).Value = DateTime.Now;
            }
        }

        public bool doValidation()
        {
            foreach(Control ctl in this.ctl)
            {
                if(ctl.GetType() == typeof(TextBox) || ctl.GetType() == typeof(RichTextBox))
                {
                    if(String.IsNullOrEmpty(ctl.Text))
                    {
                        MessageBox.Show("Semua harus terisi", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.eValidasi.SetError(ctl, "Must be filled");
                        return false;
                    }

                    else
                    {
                        this.eValidasi.SetError(ctl, "");
                    }
                }

                else if (ctl.GetType() == typeof(ComboBox))
                {
                    if (((ComboBox)ctl).SelectedIndex < 0)
                    {
                        MessageBox.Show("Semua harus terisi", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.eValidasi.SetError(ctl, "Must be filled");
                        return false;
                    }

                    else
                    {
                        this.eValidasi.SetError(ctl, "");
                    }
                }

                else if (ctl.GetType() == typeof(NumericUpDown))
                {
                    if (String.IsNullOrEmpty(((NumericUpDown)ctl).Value.ToString()) || ((NumericUpDown)ctl).Value == 0)
                    {
                        MessageBox.Show("Semua harus terisi", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.eValidasi.SetError(ctl, "Tidak boleh kosong");
                        return false;
                    }

                    else
                    {
                        this.eValidasi.SetError(ctl, "");
                    }
                }
            }
            return true;
        }

        public void numberFormat(KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if(!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }
        public void getRandom(int batas, Label q)
        {
            string kata = "";
            Random random = new Random();
            string[] data = "a,b,c,d,e,f,g,h,i,j,k,l,m,n,o,p,q,r,s,t,u,v,w,x,y,z,A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,V,W,X,Y,Z,0,1,2,3,4,5,6,7,8,9".Split(',');
            for (int i = 0; i <= batas; i++)
            {
                kata += data[random.Next(0, data.Length)];
            }
            q.Text = kata;
        }
        public void getRandomInt(int batas)
        {
            string kata = "";
            Random random = new Random();
            string[] data = "0,1,2,3,4,5,6,7,8,9".Split(',');
            for (int i = 0; i <= batas; i++)
            {
                kata += data[random.Next(0, data.Length)];
            }

            this.pk = kata;
        }


    }
}
