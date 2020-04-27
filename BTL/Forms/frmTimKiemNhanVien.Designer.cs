namespace BTL.Forms
{
    partial class frmTimKiemNhanVien
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
            this.cboMaPhong = new System.Windows.Forms.ComboBox();
            this.cboTenNV = new System.Windows.Forms.ComboBox();
            this.cboMaTĐ = new System.Windows.Forms.ComboBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnTimLai = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.cboGioiTinh = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaBao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaTĐ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaCM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // cboMaPhong
            // 
            this.cboMaPhong.BackColor = System.Drawing.Color.LavenderBlush;
            this.cboMaPhong.FormattingEnabled = true;
            this.cboMaPhong.Location = new System.Drawing.Point(593, 86);
            this.cboMaPhong.Margin = new System.Windows.Forms.Padding(2);
            this.cboMaPhong.Name = "cboMaPhong";
            this.cboMaPhong.Size = new System.Drawing.Size(195, 21);
            this.cboMaPhong.TabIndex = 53;
            // 
            // cboTenNV
            // 
            this.cboTenNV.BackColor = System.Drawing.Color.LavenderBlush;
            this.cboTenNV.FormattingEnabled = true;
            this.cboTenNV.Location = new System.Drawing.Point(206, 34);
            this.cboTenNV.Margin = new System.Windows.Forms.Padding(2);
            this.cboTenNV.Name = "cboTenNV";
            this.cboTenNV.Size = new System.Drawing.Size(195, 21);
            this.cboTenNV.TabIndex = 52;
            // 
            // cboMaTĐ
            // 
            this.cboMaTĐ.BackColor = System.Drawing.Color.LavenderBlush;
            this.cboMaTĐ.FormattingEnabled = true;
            this.cboMaTĐ.Location = new System.Drawing.Point(593, 34);
            this.cboMaTĐ.Margin = new System.Windows.Forms.Padding(2);
            this.cboMaTĐ.Name = "cboMaTĐ";
            this.cboMaTĐ.Size = new System.Drawing.Size(195, 21);
            this.cboMaTĐ.TabIndex = 51;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(611, 400);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(99, 28);
            this.btnThoat.TabIndex = 50;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnTimLai
            // 
            this.btnTimLai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnTimLai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimLai.Location = new System.Drawing.Point(425, 400);
            this.btnTimLai.Margin = new System.Windows.Forms.Padding(2);
            this.btnTimLai.Name = "btnTimLai";
            this.btnTimLai.Size = new System.Drawing.Size(103, 28);
            this.btnTimLai.TabIndex = 49;
            this.btnTimLai.Text = "Tìm Lại";
            this.btnTimLai.UseVisualStyleBackColor = false;
            this.btnTimLai.Click += new System.EventHandler(this.btnTimLai_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnTimKiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Location = new System.Drawing.Point(229, 400);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(112, 28);
            this.btnTimKiem.TabIndex = 48;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // cboGioiTinh
            // 
            this.cboGioiTinh.BackColor = System.Drawing.Color.LavenderBlush;
            this.cboGioiTinh.FormattingEnabled = true;
            this.cboGioiTinh.Location = new System.Drawing.Point(206, 86);
            this.cboGioiTinh.Margin = new System.Windows.Forms.Padding(2);
            this.cboGioiTinh.Name = "cboGioiTinh";
            this.cboGioiTinh.Size = new System.Drawing.Size(195, 21);
            this.cboGioiTinh.TabIndex = 47;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(117, 85);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 19);
            this.label5.TabIndex = 46;
            this.label5.Text = "Giới Tính";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(491, 36);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 19);
            this.label10.TabIndex = 45;
            this.label10.Text = " Trình Độ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(491, 86);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 19);
            this.label11.TabIndex = 44;
            this.label11.Text = " Phòng Ban";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(81, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 19);
            this.label2.TabIndex = 43;
            this.label2.Text = "Tên Nhân Viên";
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNV,
            this.TenNV,
            this.MaBao,
            this.MaPhong,
            this.MaChucVu,
            this.MaTĐ,
            this.MaCM,
            this.DiaChi,
            this.NgaySinh,
            this.GioiTinh,
            this.DienThoai,
            this.Mobile,
            this.Email});
            this.dataGridView.Location = new System.Drawing.Point(30, 154);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 28;
            this.dataGridView.Size = new System.Drawing.Size(893, 222);
            this.dataGridView.TabIndex = 42;
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "Mã Nhân Viên";
            this.MaNV.Name = "MaNV";
            // 
            // TenNV
            // 
            this.TenNV.DataPropertyName = "TenNV";
            this.TenNV.HeaderText = "Tên Nhân Viên";
            this.TenNV.Name = "TenNV";
            // 
            // MaBao
            // 
            this.MaBao.DataPropertyName = "MaBao";
            this.MaBao.HeaderText = "Mã Báo";
            this.MaBao.Name = "MaBao";
            // 
            // MaPhong
            // 
            this.MaPhong.DataPropertyName = "MaPhong";
            this.MaPhong.HeaderText = "Mã Phòng";
            this.MaPhong.Name = "MaPhong";
            // 
            // MaChucVu
            // 
            this.MaChucVu.DataPropertyName = "MaChucVu";
            this.MaChucVu.HeaderText = "Mã Chức Vụ";
            this.MaChucVu.Name = "MaChucVu";
            // 
            // MaTĐ
            // 
            this.MaTĐ.DataPropertyName = "MaTĐ";
            this.MaTĐ.HeaderText = "Mã Trình Độ";
            this.MaTĐ.Name = "MaTĐ";
            // 
            // MaCM
            // 
            this.MaCM.DataPropertyName = "MaCM";
            this.MaCM.HeaderText = "Mã Chuyên Môn";
            this.MaCM.Name = "MaCM";
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa Chỉ";
            this.DiaChi.Name = "DiaChi";
            // 
            // NgaySinh
            // 
            this.NgaySinh.DataPropertyName = "NgaySinh";
            this.NgaySinh.HeaderText = "Ngày Sinh";
            this.NgaySinh.Name = "NgaySinh";
            // 
            // GioiTinh
            // 
            this.GioiTinh.DataPropertyName = "GioiTinh";
            this.GioiTinh.HeaderText = "Giới Tính";
            this.GioiTinh.Name = "GioiTinh";
            // 
            // DienThoai
            // 
            this.DienThoai.DataPropertyName = "DienThoai";
            this.DienThoai.HeaderText = "Điện Thoại";
            this.DienThoai.Name = "DienThoai";
            // 
            // Mobile
            // 
            this.Mobile.DataPropertyName = "Mobile";
            this.Mobile.HeaderText = "Mobile";
            this.Mobile.Name = "Mobile";
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            // 
            // frmTimKiemNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(959, 450);
            this.Controls.Add(this.cboMaPhong);
            this.Controls.Add(this.cboTenNV);
            this.Controls.Add(this.cboMaTĐ);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTimLai);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.cboGioiTinh);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView);
            this.Name = "frmTimKiemNhanVien";
            this.Text = "frmTimKiemNhanVien";
            this.Load += new System.EventHandler(this.frmTimKiemNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox cboMaPhong;
        public System.Windows.Forms.ComboBox cboTenNV;
        public System.Windows.Forms.ComboBox cboMaTĐ;
        public System.Windows.Forms.Button btnThoat;
        public System.Windows.Forms.Button btnTimLai;
        public System.Windows.Forms.Button btnTimKiem;
        public System.Windows.Forms.ComboBox cboGioiTinh;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.Label label11;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaBao;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaChucVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTĐ;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCM;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn DienThoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mobile;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
    }
}