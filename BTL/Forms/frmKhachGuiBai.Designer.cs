namespace BTL.Forms
{
    partial class frmKhachGuiBai
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
            this.btnBoQua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTieuDe = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNoiDung = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaLanGui = new System.Windows.Forms.TextBox();
            this.cboMaBao = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboMaTheLoai = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNhuanBut = new System.Windows.Forms.TextBox();
            this.mskNgayDang = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMaKhachHang = new System.Windows.Forms.TextBox();
            this.txtMaNhanVien = new System.Windows.Forms.TextBox();
            this.MaLanGui = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaTheLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaBao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TieuDe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoiDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayDang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NhuanBut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBoQua
            // 
            this.btnBoQua.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBoQua.Location = new System.Drawing.Point(449, 352);
            this.btnBoQua.Name = "btnBoQua";
            this.btnBoQua.Size = new System.Drawing.Size(82, 23);
            this.btnBoQua.TabIndex = 92;
            this.btnBoQua.Text = "Bỏ Qua";
            this.btnBoQua.UseVisualStyleBackColor = false;
            this.btnBoQua.Click += new System.EventHandler(this.btnBoQua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLuu.Location = new System.Drawing.Point(346, 352);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(82, 23);
            this.btnLuu.TabIndex = 91;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThem.Location = new System.Drawing.Point(49, 352);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(82, 23);
            this.btnThem.TabIndex = 90;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnXoa.Location = new System.Drawing.Point(243, 352);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(82, 23);
            this.btnXoa.TabIndex = 89;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThoat.Location = new System.Drawing.Point(552, 352);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 88;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSua.Location = new System.Drawing.Point(154, 352);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 87;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // DataGridView
            // 
            this.DataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaLanGui,
            this.MaKH,
            this.MaTheLoai,
            this.MaBao,
            this.TieuDe,
            this.NoiDung,
            this.MaNV,
            this.NgayDang,
            this.NhuanBut});
            this.DataGridView.Location = new System.Drawing.Point(25, 201);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.Size = new System.Drawing.Size(649, 137);
            this.DataGridView.TabIndex = 86;
            this.DataGridView.Click += new System.EventHandler(this.DataGridView_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.AntiqueWhite;
            this.label5.Location = new System.Drawing.Point(343, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 115;
            this.label5.Text = "Tiêu đề";
            // 
            // txtTieuDe
            // 
            this.txtTieuDe.Location = new System.Drawing.Point(429, 45);
            this.txtTieuDe.Name = "txtTieuDe";
            this.txtTieuDe.Size = new System.Drawing.Size(121, 20);
            this.txtTieuDe.TabIndex = 114;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.AntiqueWhite;
            this.label4.Location = new System.Drawing.Point(343, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 113;
            this.label4.Text = "Nội dung";
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.Location = new System.Drawing.Point(429, 72);
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.Size = new System.Drawing.Size(121, 20);
            this.txtNoiDung.TabIndex = 112;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.AntiqueWhite;
            this.label3.Location = new System.Drawing.Point(87, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 111;
            this.label3.Text = "Mã Khách Hàng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.AntiqueWhite;
            this.label6.Location = new System.Drawing.Point(343, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 109;
            this.label6.Text = "Ngày Đăng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.label1.Location = new System.Drawing.Point(87, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 105;
            this.label1.Text = "Mã Lần Gửi";
            // 
            // txtMaLanGui
            // 
            this.txtMaLanGui.Location = new System.Drawing.Point(173, 48);
            this.txtMaLanGui.Name = "txtMaLanGui";
            this.txtMaLanGui.Size = new System.Drawing.Size(121, 20);
            this.txtMaLanGui.TabIndex = 104;
            // 
            // cboMaBao
            // 
            this.cboMaBao.FormattingEnabled = true;
            this.cboMaBao.Location = new System.Drawing.Point(173, 104);
            this.cboMaBao.Name = "cboMaBao";
            this.cboMaBao.Size = new System.Drawing.Size(121, 21);
            this.cboMaBao.TabIndex = 119;
            this.cboMaBao.TextChanged += new System.EventHandler(this.cboMaBao_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.AntiqueWhite;
            this.label7.Location = new System.Drawing.Point(87, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 118;
            this.label7.Text = "Mã Báo";
            // 
            // cboMaTheLoai
            // 
            this.cboMaTheLoai.FormattingEnabled = true;
            this.cboMaTheLoai.Location = new System.Drawing.Point(173, 135);
            this.cboMaTheLoai.Name = "cboMaTheLoai";
            this.cboMaTheLoai.Size = new System.Drawing.Size(121, 21);
            this.cboMaTheLoai.TabIndex = 117;
            this.cboMaTheLoai.TextChanged += new System.EventHandler(this.cboMaTheLoai_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.AntiqueWhite;
            this.label8.Location = new System.Drawing.Point(87, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 116;
            this.label8.Text = "Mã Thể Loại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.AntiqueWhite;
            this.label2.Location = new System.Drawing.Point(87, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 121;
            this.label2.Text = "Mã Nhân Viên";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.AntiqueWhite;
            this.label9.Location = new System.Drawing.Point(343, 153);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 123;
            this.label9.Text = "Nhuận Bút";
            // 
            // txtNhuanBut
            // 
            this.txtNhuanBut.Location = new System.Drawing.Point(423, 146);
            this.txtNhuanBut.Name = "txtNhuanBut";
            this.txtNhuanBut.Size = new System.Drawing.Size(121, 20);
            this.txtNhuanBut.TabIndex = 122;
            // 
            // mskNgayDang
            // 
            this.mskNgayDang.Location = new System.Drawing.Point(429, 110);
            this.mskNgayDang.Mask = "00/00/0000";
            this.mskNgayDang.Name = "mskNgayDang";
            this.mskNgayDang.Size = new System.Drawing.Size(100, 20);
            this.mskNgayDang.TabIndex = 124;
            this.mskNgayDang.ValidatingType = typeof(System.DateTime);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.AntiqueWhite;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(267, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(142, 24);
            this.label10.TabIndex = 125;
            this.label10.Text = "Khách Gửi Bài";
            // 
            // txtMaKhachHang
            // 
            this.txtMaKhachHang.Location = new System.Drawing.Point(173, 77);
            this.txtMaKhachHang.Name = "txtMaKhachHang";
            this.txtMaKhachHang.Size = new System.Drawing.Size(121, 20);
            this.txtMaKhachHang.TabIndex = 126;
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.Location = new System.Drawing.Point(173, 162);
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.Size = new System.Drawing.Size(121, 20);
            this.txtMaNhanVien.TabIndex = 127;
            // 
            // MaLanGui
            // 
            this.MaLanGui.DataPropertyName = "MaLanGui";
            this.MaLanGui.HeaderText = "Mã Lần Gửi";
            this.MaLanGui.Name = "MaLanGui";
            // 
            // MaKH
            // 
            this.MaKH.DataPropertyName = "MaKH";
            this.MaKH.HeaderText = "Mã Khách Hàng";
            this.MaKH.Name = "MaKH";
            // 
            // MaTheLoai
            // 
            this.MaTheLoai.DataPropertyName = "MaTheLoai";
            this.MaTheLoai.HeaderText = "Mã Thể Loại";
            this.MaTheLoai.Name = "MaTheLoai";
            // 
            // MaBao
            // 
            this.MaBao.DataPropertyName = "MaBao";
            this.MaBao.HeaderText = "Mã Báo";
            this.MaBao.Name = "MaBao";
            // 
            // TieuDe
            // 
            this.TieuDe.DataPropertyName = "TieuDe";
            this.TieuDe.HeaderText = "Tiêu Đề";
            this.TieuDe.Name = "TieuDe";
            // 
            // NoiDung
            // 
            this.NoiDung.DataPropertyName = "NoiDung";
            this.NoiDung.HeaderText = "Nội Dung";
            this.NoiDung.Name = "NoiDung";
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "Mã Nhân Viên";
            this.MaNV.Name = "MaNV";
            // 
            // NgayDang
            // 
            this.NgayDang.DataPropertyName = "NgayDang";
            this.NgayDang.HeaderText = "Ngày Đăng";
            this.NgayDang.Name = "NgayDang";
            // 
            // NhuanBut
            // 
            this.NhuanBut.DataPropertyName = "NhuanBut";
            this.NhuanBut.HeaderText = "Nhuận Bút";
            this.NhuanBut.Name = "NhuanBut";
            // 
            // frmKhachGuiBai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(704, 387);
            this.Controls.Add(this.txtMaNhanVien);
            this.Controls.Add(this.txtMaKhachHang);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.mskNgayDang);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtNhuanBut);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboMaBao);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cboMaTheLoai);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTieuDe);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNoiDung);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMaLanGui);
            this.Controls.Add(this.btnBoQua);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.DataGridView);
            this.Name = "frmKhachGuiBai";
            this.Text = "frmKhachGuiBai";
            this.Load += new System.EventHandler(this.frmKhachGuiBai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBoQua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTieuDe;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNoiDung;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaLanGui;
        private System.Windows.Forms.ComboBox cboMaBao;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboMaTheLoai;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNhuanBut;
        private System.Windows.Forms.MaskedTextBox mskNgayDang;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtMaKhachHang;
        private System.Windows.Forms.TextBox txtMaNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLanGui;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTheLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaBao;
        private System.Windows.Forms.DataGridViewTextBoxColumn TieuDe;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoiDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayDang;
        private System.Windows.Forms.DataGridViewTextBoxColumn NhuanBut;
    }
}