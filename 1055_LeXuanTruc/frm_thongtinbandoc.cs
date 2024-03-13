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
    public partial class frm_thongtinbandoc : Form
    {
        LOPDUNGCHUNG lopchung= new LOPDUNGCHUNG();
        public frm_thongtinbandoc()
        {
            InitializeComponent();
        }
        private void loadBD()
        {
            string sql = "Select * from BanDoc";
            dtg_ViewInformation.DataSource = lopchung.LoadDL(sql);
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            string sql = "Insert into BanDoc values ('" + txt_Madocgia.Text + "', N'" + txt_HoTen.Text  + "',Convert(datetime,'" + dtp_NgaySinh.Text + "',103),N'" + cmb_loaithanhvien.Text + "', N'" + txt_DiaChi.Text + "')";
            int kq = lopchung.ThemXoaSua(sql);
            if (kq > 0) MessageBox.Show("Them thanh cong");
            else MessageBox.Show("Them bi loi!!");
            loadBD();
        }

        private void frm_thongtinbandoc_Load(object sender, EventArgs e)
        {
            loadBD();
        }

        private void dtg_ViewInformation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_Madocgia.Text = dtg_ViewInformation.CurrentRow.Cells["MaDocGia"].Value.ToString();
            txt_HoTen.Text = dtg_ViewInformation.CurrentRow.Cells["HoTen"].Value.ToString();
            txt_DiaChi.Text = dtg_ViewInformation.CurrentRow.Cells["DiaChi"].Value.ToString();
            dtp_NgaySinh.Text = dtg_ViewInformation.CurrentRow.Cells["NgaySinh"].Value.ToString();
            cmb_loaithanhvien.Text = dtg_ViewInformation.CurrentRow.Cells["LoaiThanhVien"].Value.ToString();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            string sql = "Update BanDoc set TenBanDoc = N'" + txt_HoTen.Text + "',DiaChi = N'" + txt_DiaChi.Text + "',NgaySinh = Convert(datetime,'" + dtp_NgaySinh.Text + "',103),LoaiThanhVien = N'" + cmb_loaithanhvien.Text + "'where MaBanDoc= '" + txt_Madocgia.Text + "'";
            int kq = lopchung.ThemXoaSua(sql);
            if (kq >= 1) MessageBox.Show("Cập nhật nhân viên thành công");
            else MessageBox.Show("Cập nhật nhân viên thất bại");
            loadBD();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string sql = "Delete BanDoc where MaBanDoc = '" + txt_Madocgia.Text + "'";
            DialogResult dt = MessageBox.Show("Bạn có muốn xoa nhan vien này", "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (dt == DialogResult.Yes)
            {

                int kq = lopchung.ThemXoaSua(sql);
                if (kq > 0) MessageBox.Show("Xoá nhân viên thành công");
                else MessageBox.Show("Xoá nhân viên thất bại");
                loadBD();
            }
        }
    }
}
