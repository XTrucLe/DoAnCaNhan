namespace _1055_LeXuanTruc
{
    partial class frm_themuonsach
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
            this.txt_MaSachMuon = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_MaThuVien = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtp_NgaySinh = new System.Windows.Forms.DateTimePicker();
            this.dtp_NgayHetHan = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_MaDocGia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_ViewInformation)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(356, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(314, 32);
            this.label6.TabIndex = 78;
            this.label6.Text = "Thông tin thẻ mượn sách";
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(966, 437);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(86, 32);
            this.btn_Close.TabIndex = 77;
            this.btn_Close.Text = "Đóng";
            this.btn_Close.UseVisualStyleBackColor = true;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(966, 144);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(86, 32);
            this.btn_Xoa.TabIndex = 76;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(722, 144);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(86, 32);
            this.btn_Sua.TabIndex = 75;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(487, 144);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(86, 32);
            this.btn_Them.TabIndex = 74;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // dtg_ViewInformation
            // 
            this.dtg_ViewInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_ViewInformation.Location = new System.Drawing.Point(487, 221);
            this.dtg_ViewInformation.Name = "dtg_ViewInformation";
            this.dtg_ViewInformation.RowHeadersWidth = 51;
            this.dtg_ViewInformation.RowTemplate.Height = 24;
            this.dtg_ViewInformation.Size = new System.Drawing.Size(565, 162);
            this.dtg_ViewInformation.TabIndex = 73;
            // 
            // txt_MaSachMuon
            // 
            this.txt_MaSachMuon.Location = new System.Drawing.Point(187, 221);
            this.txt_MaSachMuon.Name = "txt_MaSachMuon";
            this.txt_MaSachMuon.Size = new System.Drawing.Size(259, 22);
            this.txt_MaSachMuon.TabIndex = 67;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 19);
            this.label2.TabIndex = 66;
            this.label2.Text = "Mã sách mượn";
            // 
            // txt_MaThuVien
            // 
            this.txt_MaThuVien.Location = new System.Drawing.Point(187, 141);
            this.txt_MaThuVien.Name = "txt_MaThuVien";
            this.txt_MaThuVien.Size = new System.Drawing.Size(259, 22);
            this.txt_MaThuVien.TabIndex = 65;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 19);
            this.label1.TabIndex = 64;
            this.label1.Text = "Mã thẻ thư viện";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 19);
            this.label3.TabIndex = 68;
            this.label3.Text = "Ngày mượn";
            // 
            // dtp_NgaySinh
            // 
            this.dtp_NgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dtp_NgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_NgaySinh.Location = new System.Drawing.Point(187, 263);
            this.dtp_NgaySinh.Name = "dtp_NgaySinh";
            this.dtp_NgaySinh.Size = new System.Drawing.Size(259, 22);
            this.dtp_NgaySinh.TabIndex = 69;
            // 
            // dtp_NgayHetHan
            // 
            this.dtp_NgayHetHan.CustomFormat = "dd/MM/yyyy";
            this.dtp_NgayHetHan.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_NgayHetHan.Location = new System.Drawing.Point(187, 306);
            this.dtp_NgayHetHan.Name = "dtp_NgayHetHan";
            this.dtp_NgayHetHan.Size = new System.Drawing.Size(259, 22);
            this.dtp_NgayHetHan.TabIndex = 80;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(57, 306);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 19);
            this.label4.TabIndex = 79;
            this.label4.Text = "Ngày hết hạn";
            // 
            // txt_MaDocGia
            // 
            this.txt_MaDocGia.Location = new System.Drawing.Point(187, 184);
            this.txt_MaDocGia.Name = "txt_MaDocGia";
            this.txt_MaDocGia.Size = new System.Drawing.Size(259, 22);
            this.txt_MaDocGia.TabIndex = 82;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(57, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 19);
            this.label5.TabIndex = 81;
            this.label5.Text = "Mã đọc giả";
            // 
            // frm_themuonsach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 516);
            this.Controls.Add(this.txt_MaDocGia);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtp_NgayHetHan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.dtg_ViewInformation);
            this.Controls.Add(this.dtp_NgaySinh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_MaSachMuon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_MaThuVien);
            this.Controls.Add(this.label1);
            this.Name = "frm_themuonsach";
            this.Text = "frm_themuonsach";
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
        private System.Windows.Forms.TextBox txt_MaSachMuon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_MaThuVien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtp_NgaySinh;
        private System.Windows.Forms.DateTimePicker dtp_NgayHetHan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_MaDocGia;
        private System.Windows.Forms.Label label5;
    }
}