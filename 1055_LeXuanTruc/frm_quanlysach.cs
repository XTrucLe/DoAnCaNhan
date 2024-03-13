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
    public partial class frm_quanlysach : Form
    {
        LOPDUNGCHUNG lopchung = new LOPDUNGCHUNG();
        public frm_quanlysach()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void loadSach()
        {
            string sql = "Select * from Sach";
            dtg_ViewInformation.DataSource = lopchung.LoadDL(sql);
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            string sql = "Insert into Sach values ('" + txt_Masach.Text + "', N'" + txt_TenSach.Text + "', N'" + txt_TacGia.Text + "',N'" + txt_MoTa.Text + "',N'" + cmb_theloai.Text + "',N'" + cmb_TinhTrangSach.Text+ "')";
            int kq = lopchung.ThemXoaSua(sql);
            if (kq > 0) MessageBox.Show("Them thanh cong");
            else MessageBox.Show("Them bi loi!!");
            loadSach();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            string sql = "Update Sach set TenSach = N'" + txt_TenSach.Text + "',TenTacGia = N'" + txt_TacGia.Text + "',MoTa =N,'" + txt_MoTa.Text + "',TheLoai = N'" + cmb_theloai.Text + "',TinhTrang = N'" + cmb_TinhTrangSach.Text + "'where MaSach = '" + txt_Masach.Text + "'";
            int kq = lopchung.ThemXoaSua(sql);
            if (kq >= 1) MessageBox.Show("Cập nhật nhân viên thành công");
            else MessageBox.Show("Cập nhật nhân viên thất bại");
            loadSach();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            DialogResult dt = MessageBox.Show("Bạn có muốn thoát", "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (dt == DialogResult.Yes)
                Application.Exit();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string sql = "Delete Sach where MaSach = '" + txt_Masach.Text + "'";
            DialogResult dt = MessageBox.Show("Bạn có muốn xoa nhan vien này", "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (dt == DialogResult.Yes)
            {

                int kq = lopchung.ThemXoaSua(sql);
                if (kq > 0) MessageBox.Show("Xoá nhân viên thành công");
                else MessageBox.Show("Xoá nhân viên thất bại");
                loadSach();
            }
        }

        private void frm_quanlysach_Load(object sender, EventArgs e)
        {
            loadSach();
        }
    }
}
