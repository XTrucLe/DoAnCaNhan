namespace _1055_LeXuanTruc
{
    partial class frm_thongtinbandoc
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label6 = new System.Windows.Forms.Label();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.dtg_ViewInformation = new System.Windows.Forms.DataGridView();
            this.txt_DiaChi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtp_NgaySinh = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_HoTen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Madocgia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_loaithanhvien = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_ViewInformation)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(403, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(234, 32);
            this.label6.TabIndex = 62;
            this.label6.Text = "Thông tin bạn đọc";
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(944, 420);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(86, 32);
            this.btn_Close.TabIndex = 61;
            this.btn_Close.Text = "Đóng";
            this.btn_Close.UseVisualStyleBackColor = true;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(944, 127);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(86, 32);
            this.btn_Xoa.TabIndex = 60;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(700, 127);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(86, 32);
            this.btn_Sua.TabIndex = 59;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(465, 127);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(86, 32);
            this.btn_Them.TabIndex = 58;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // dtg_ViewInformation
            // 
            this.dtg_ViewInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_ViewInformation.Location = new System.Drawing.Point(465, 204);
            this.dtg_ViewInformation.Name = "dtg_ViewInformation";
            this.dtg_ViewInformation.RowHeadersWidth = 51;
            this.dtg_ViewInformation.RowTemplate.Height = 24;
            this.dtg_ViewInformation.Size = new System.Drawing.Size(565, 162);
            this.dtg_ViewInformation.TabIndex = 57;
            this.dtg_ViewInformation.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_ViewInformation_CellContentClick);
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.Location = new System.Drawing.Point(165, 288);
            this.txt_DiaChi.Multiline = true;
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Size = new System.Drawing.Size(259, 78);
            this.txt_DiaChi.TabIndex = 56;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 291);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 19);
            this.label5.TabIndex = 55;
            this.label5.Text = "Địa chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 19);
            this.label4.TabIndex = 53;
            this.label4.Text = "Loại thành viên";
            // 
            // dtp_NgaySinh
            // 
            this.dtp_NgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dtp_NgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_NgaySinh.Location = new System.Drawing.Point(165, 204);
            this.dtp_NgaySinh.Name = "dtp_NgaySinh";
            this.dtp_NgaySinh.Size = new System.Drawing.Size(259, 22);
            this.dtp_NgaySinh.TabIndex = 52;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 19);
            this.label3.TabIndex = 51;
            this.label3.Text = "Ngày sinh";
            // 
            // txt_HoTen
            // 
            this.txt_HoTen.Location = new System.Drawing.Point(165, 162);
            this.txt_HoTen.Name = "txt_HoTen";
            this.txt_HoTen.Size = new System.Drawing.Size(259, 22);
            this.txt_HoTen.TabIndex = 50;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 19);
            this.label2.TabIndex = 49;
            this.label2.Text = "Họ tên:";
            // 
            // txt_Madocgia
            // 
            this.txt_Madocgia.Location = new System.Drawing.Point(165, 124);
            this.txt_Madocgia.Name = "txt_Madocgia";
            this.txt_Madocgia.Size = new System.Drawing.Size(259, 22);
            this.txt_Madocgia.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 19);
            this.label1.TabIndex = 47;
            this.label1.Text = "Mã đọc giả";
            // 
            // cmb_loaithanhvien
            // 
            this.cmb_loaithanhvien.FormattingEnabled = true;
            this.cmb_loaithanhvien.Items.AddRange(new object[] {
            "Bình thường",
            "Thành viên 1 năm",
            "Bạn đọc thâm niên",
            "Bạn đọc kim cương"});
            this.cmb_loaithanhvien.Location = new System.Drawing.Point(165, 248);
            this.cmb_loaithanhvien.Name = "cmb_loaithanhvien";
            this.cmb_loaithanhvien.Size = new System.Drawing.Size(259, 24);
            this.cmb_loaithanhvien.TabIndex = 63;
            // 
            // frm_thongtinbandoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 518);
            this.Controls.Add(this.cmb_loaithanhvien);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.dtg_ViewInformation);
            this.Controls.Add(this.txt_DiaChi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtp_NgaySinh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_HoTen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Madocgia);
            this.Controls.Add(this.label1);
            this.Name = "frm_thongtinbandoc";
            this.Text = "frm_thongtinbandoc";
            this.Load += new System.EventHandler(this.frm_thongtinbandoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_ViewInformation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.DataGridView dtg_ViewInformation;
        private System.Windows.Forms.TextBox txt_DiaChi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtp_NgaySinh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_HoTen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Madocgia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_loaithanhvien;
    }
}