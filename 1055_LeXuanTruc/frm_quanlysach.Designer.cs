namespace _1055_LeXuanTruc
{
    partial class frm_quanlysach
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
            this.cmb_TinhTrangSach = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.dtg_ViewInformation = new System.Windows.Forms.DataGridView();
            this.txt_MoTa = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_TenSach = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Masach = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_TacGia = new System.Windows.Forms.TextBox();
            this.cmb_theloai = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_ViewInformation)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_TinhTrangSach
            // 
            this.cmb_TinhTrangSach.FormattingEnabled = true;
            this.cmb_TinhTrangSach.Items.AddRange(new object[] {
            "Hết",
            "Số lượng ít",
            "Bình thường",
            "Còn nhiều"});
            this.cmb_TinhTrangSach.Location = new System.Drawing.Point(166, 325);
            this.cmb_TinhTrangSach.Name = "cmb_TinhTrangSach";
            this.cmb_TinhTrangSach.Size = new System.Drawing.Size(259, 24);
            this.cmb_TinhTrangSach.TabIndex = 79;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(440, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 32);
            this.label6.TabIndex = 78;
            this.label6.Text = "Quản lý sách";
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(945, 454);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(86, 32);
            this.btn_Close.TabIndex = 77;
            this.btn_Close.Text = "Đóng";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(945, 155);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(86, 32);
            this.btn_Xoa.TabIndex = 76;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(701, 155);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(86, 32);
            this.btn_Sua.TabIndex = 75;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(466, 155);
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
            this.dtg_ViewInformation.Location = new System.Drawing.Point(466, 238);
            this.dtg_ViewInformation.Name = "dtg_ViewInformation";
            this.dtg_ViewInformation.RowHeadersWidth = 51;
            this.dtg_ViewInformation.RowTemplate.Height = 24;
            this.dtg_ViewInformation.Size = new System.Drawing.Size(565, 206);
            this.dtg_ViewInformation.TabIndex = 73;
            // 
            // txt_MoTa
            // 
            this.txt_MoTa.Location = new System.Drawing.Point(166, 366);
            this.txt_MoTa.Multiline = true;
            this.txt_MoTa.Name = "txt_MoTa";
            this.txt_MoTa.Size = new System.Drawing.Size(259, 78);
            this.txt_MoTa.TabIndex = 72;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(66, 369);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 19);
            this.label5.TabIndex = 71;
            this.label5.Text = "Mô tả";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(66, 325);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 19);
            this.label4.TabIndex = 70;
            this.label4.Text = "Tình trạng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(66, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 19);
            this.label3.TabIndex = 68;
            this.label3.Text = "Tác giả";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txt_TenSach
            // 
            this.txt_TenSach.Location = new System.Drawing.Point(166, 196);
            this.txt_TenSach.Name = "txt_TenSach";
            this.txt_TenSach.Size = new System.Drawing.Size(259, 22);
            this.txt_TenSach.TabIndex = 67;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(66, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 19);
            this.label2.TabIndex = 66;
            this.label2.Text = "Tên sách";
            // 
            // txt_Masach
            // 
            this.txt_Masach.Location = new System.Drawing.Point(166, 158);
            this.txt_Masach.Name = "txt_Masach";
            this.txt_Masach.Size = new System.Drawing.Size(259, 22);
            this.txt_Masach.TabIndex = 65;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 19);
            this.label1.TabIndex = 64;
            this.label1.Text = "Mã sách";
            // 
            // txt_TacGia
            // 
            this.txt_TacGia.Location = new System.Drawing.Point(166, 238);
            this.txt_TacGia.Name = "txt_TacGia";
            this.txt_TacGia.Size = new System.Drawing.Size(259, 22);
            this.txt_TacGia.TabIndex = 80;
            // 
            // cmb_theloai
            // 
            this.cmb_theloai.FormattingEnabled = true;
            this.cmb_theloai.Items.AddRange(new object[] {
            "Danh tac",
            "tieu thuyet",
            "tien hiep",
            "truyen "});
            this.cmb_theloai.Location = new System.Drawing.Point(166, 283);
            this.cmb_theloai.Name = "cmb_theloai";
            this.cmb_theloai.Size = new System.Drawing.Size(259, 24);
            this.cmb_theloai.TabIndex = 82;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(66, 283);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 19);
            this.label7.TabIndex = 81;
            this.label7.Text = "Thể loại";
            // 
            // frm_quanlysach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 551);
            this.Controls.Add(this.cmb_theloai);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_TacGia);
            this.Controls.Add(this.cmb_TinhTrangSach);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.dtg_ViewInformation);
            this.Controls.Add(this.txt_MoTa);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_TenSach);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Masach);
            this.Controls.Add(this.label1);
            this.Name = "frm_quanlysach";
            this.Text = "frm_quanlysach";
            this.Load += new System.EventHandler(this.frm_quanlysach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_ViewInformation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_TinhTrangSach;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.DataGridView dtg_ViewInformation;
        private System.Windows.Forms.TextBox txt_MoTa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_TenSach;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Masach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_TacGia;
        private System.Windows.Forms.ComboBox cmb_theloai;
        private System.Windows.Forms.Label label7;
    }
}