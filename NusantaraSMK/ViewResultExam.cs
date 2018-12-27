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
    public partial class ViewResultExam : Form
    {
        SMKDBDataContext db = new SMKDBDataContext();
        public ViewResultExam()
        {
            InitializeComponent();
        }

        private void ViewResultExam_Load(object sender, EventArgs e)
        {
            var lulus = (from b in db.tbl_Nilais
                         where ((0.3 * b.nilaiessay) + (0.3 * b.nilaipg) + (0.4 * b.nilaikasus)) >= 65
                         select b);
            var tidaklulus = (from b in db.tbl_Nilais
                         where ((0.3 * b.nilaiessay) + (0.3 * b.nilaipg) + (0.4 * b.nilaikasus)) < 65
                         select b);

            int[] total = new int[2]{(int)lulus.Count(), tidaklulus.Count()};
            string[] status = "Lulus,Tidak Lulus".Split(',');
            for (int i = 0; i < 2; i++)
            {
                chart1.Series["Nilai"].Points.AddXY(status[i], total[i]);
            }
        }
    }
}
