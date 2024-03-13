using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1055_LeXuanTruc
{
    public partial class frm_quanlythuvien : Form
    {
        public frm_quanlythuvien()
        {
            InitializeComponent();
        }

        private void frm_quanlythuvien_Load(object sender, EventArgs e)
        {

        }

        private void thôngTinNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_QuanLyNhanVien"] == null)
            {

                frm_QuanLyNhanVien sv = new frm_QuanLyNhanVien();
                sv.MdiParent = this;
                sv.Show();

            }
            else Application.OpenForms["frm_QuanLyNhanVien"].Activate();
        }

        private void thôngTinBạnĐọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_thongtinbandoc"] == null)
            {

                frm_thongtinbandoc sv = new frm_thongtinbandoc();
                sv.MdiParent = this;
                sv.Show();

            }
            else Application.OpenForms["frm_thongtinbandoc"].Activate();
        }

        private void quảnLýSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_quanlysach"] == null)
            {

                frm_quanlysach sv = new frm_quanlysach();
                sv.MdiParent = this;
                sv.Show();

            }
            else Application.OpenForms["frm_quanlysach"].Activate();
        }
    }
}
