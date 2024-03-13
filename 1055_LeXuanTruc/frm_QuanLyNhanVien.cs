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
    public partial class frm_QuanLyNhanVien : Form
    {
        LOPDUNGCHUNG lopchung= new LOPDUNGCHUNG();
        public frm_QuanLyNhanVien()
        {
            InitializeComponent();
        }
        private void loadNV()
        {
            string sql = "Select * from NHANVIEN";
            dtg_ViewInformation.DataSource = lopchung.LoadDL(sql);
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            string sql = "Insert into NHANVIEN values ('" + txt_MaNV.Text + "', N'" + txt_HoTen.Text + "', N'" + txt_DiaChi.Text + "',Convert(datetime,'" + dtp_NgaySinh.Text + "',103),N'" + txt_ChucVu.Text + "')";
            int kq = lopchung.ThemXoaSua(sql);
            if (kq > 0) MessageBox.Show("Them thanh cong");
            else MessageBox.Show("Them bi loi!!");
            loadNV();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            string sql = "Update NHANVIEN set HOTEN = N'" + txt_HoTen.Text + "',DIACHI = N'" + txt_DiaChi.Text + "',NGAYSINH = Convert(datetime,'" + dtp_NgaySinh.Text + "',103),CHUCVU = N'" + txt_ChucVu.Text + "'where MSNV= '" + txt_MaNV.Text + "'";
            int kq = lopchung.ThemXoaSua(sql);
            if (kq >= 1) MessageBox.Show("Cập nhật nhân viên thành công");
            else MessageBox.Show("Cập nhật nhân viên thất bại");
            loadNV();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string sql = "Delete NHANVIEN where MSNV = '" + txt_MaNV.Text + "'";
            DialogResult dt = MessageBox.Show("Bạn có muốn xoa nhan vien này", "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (dt == DialogResult.Yes)
            {

                int kq = lopchung.ThemXoaSua(sql);
                if (kq > 0) MessageBox.Show("Xoá nhân viên thành công");
                else MessageBox.Show("Xoá nhân viên thất bại");
                loadNV();
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            DialogResult dt = MessageBox.Show("Bạn có muốn thoát", "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (dt == DialogResult.Yes)
                Application.Exit();
        }

        private void frm_QuanLyNhanVien_Load(object sender, EventArgs e)
        {
            loadNV();
        }

        private void dtg_ViewInformation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MaNV.Text = dtg_ViewInformation.CurrentRow.Cells["MSNV"].Value.ToString();
            txt_HoTen.Text = dtg_ViewInformation.CurrentRow.Cells["HOTEN"].Value.ToString();
            txt_DiaChi.Text = dtg_ViewInformation.CurrentRow.Cells["DIACHI"].Value.ToString();
            dtp_NgaySinh.Text = dtg_ViewInformation.CurrentRow.Cells["NGAYSINH"].Value.ToString();
        }
    }
}
