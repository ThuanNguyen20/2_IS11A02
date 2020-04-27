namespace BTL.Forms
{
    partial class frmKhachQuangCao
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
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.txtNoiDung = new System.Windows.Forms.TextBox();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.txtMaLanQCao = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboMaKH = new System.Windows.Forms.ComboBox();
            this.cboMaBao = new System.Windows.Forms.ComboBox();
            this.cboMaNV = new System.Windows.Forms.ComboBox();
            this.cboMaQCao = new System.Windows.Forms.ComboBox();
            this.mskNgayBD = new System.Windows.Forms.MaskedTextBox();
            this.mskNgayKT = new System.Windows.Forms.MaskedTextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnBoQua = new System.Windows.Forms.Button();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(157, 306);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 45;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(263, 306);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 44;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(371, 306);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 43;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(47, 306);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 42;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // DataGridView
            // 
            this.DataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Location = new System.Drawing.Point(47, 171);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.Size = new System.Drawing.Size(661, 116);
            this.DataGridView.TabIndex = 41;
            this.DataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_CellContentClick);
            this.DataGridView.Click += new System.EventHandler(this.DataGridView_Click);
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.Location = new System.Drawing.Point(371, 115);
            this.txtNoiDung.Multiline = true;
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.Size = new System.Drawing.Size(121, 47);
            this.txtNoiDung.TabIndex = 39;
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(610, 127);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(100, 20);
            this.txtTongTien.TabIndex = 38;
            this.txtTongTien.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTongTien_KeyPress);
            // 
            // txtMaLanQCao
            // 
            this.txtMaLanQCao.Location = new System.Drawing.Point(132, 49);
            this.txtMaLanQCao.Name = "txtMaLanQCao";
            this.txtMaLanQCao.Size = new System.Drawing.Size(121, 20);
            this.txtMaLanQCao.TabIndex = 32;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(528, 134);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 31;
            this.label9.Text = "Tổng tiền";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(528, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "Ngày kết thúc";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(528, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Ngày bắt đầu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(279, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Mã quảng cáo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(279, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Nội dung";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(279, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Mã nhân viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Mã báo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Mã khách hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Mã lần QC";
            // 
            // cboMaKH
            // 
            this.cboMaKH.FormattingEnabled = true;
            this.cboMaKH.Location = new System.Drawing.Point(132, 85);
            this.cboMaKH.Name = "cboMaKH";
            this.cboMaKH.Size = new System.Drawing.Size(121, 21);
            this.cboMaKH.TabIndex = 46;
            this.cboMaKH.TextChanged += new System.EventHandler(this.cboMaKH_TextChanged);
            // 
            // cboMaBao
            // 
            this.cboMaBao.FormattingEnabled = true;
            this.cboMaBao.Location = new System.Drawing.Point(132, 141);
            this.cboMaBao.Name = "cboMaBao";
            this.cboMaBao.Size = new System.Drawing.Size(121, 21);
            this.cboMaBao.TabIndex = 47;
            // 
            // cboMaNV
            // 
            this.cboMaNV.FormattingEnabled = true;
            this.cboMaNV.Location = new System.Drawing.Point(371, 49);
            this.cboMaNV.Name = "cboMaNV";
            this.cboMaNV.Size = new System.Drawing.Size(121, 21);
            this.cboMaNV.TabIndex = 48;
            // 
            // cboMaQCao
            // 
            this.cboMaQCao.FormattingEnabled = true;
            this.cboMaQCao.Location = new System.Drawing.Point(371, 88);
            this.cboMaQCao.Name = "cboMaQCao";
            this.cboMaQCao.Size = new System.Drawing.Size(121, 21);
            this.cboMaQCao.TabIndex = 49;
            // 
            // mskNgayBD
            // 
            this.mskNgayBD.Location = new System.Drawing.Point(610, 46);
            this.mskNgayBD.Mask = "00/00/0000";
            this.mskNgayBD.Name = "mskNgayBD";
            this.mskNgayBD.Size = new System.Drawing.Size(100, 20);
            this.mskNgayBD.TabIndex = 50;
            this.mskNgayBD.ValidatingType = typeof(System.DateTime);
            // 
            // mskNgayKT
            // 
            this.mskNgayKT.Location = new System.Drawing.Point(608, 89);
            this.mskNgayKT.Mask = "00/00/0000";
            this.mskNgayKT.Name = "mskNgayKT";
            this.mskNgayKT.Size = new System.Drawing.Size(100, 20);
            this.mskNgayKT.TabIndex = 51;
            this.mskNgayKT.ValidatingType = typeof(System.DateTime);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(608, 306);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 52;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnBoQua
            // 
            this.btnBoQua.BackColor = System.Drawing.Color.White;
            this.btnBoQua.Location = new System.Drawing.Point(486, 306);
            this.btnBoQua.Name = "btnBoQua";
            this.btnBoQua.Size = new System.Drawing.Size(75, 23);
            this.btnBoQua.TabIndex = 53;
            this.btnBoQua.Text = "Bỏ Qua";
            this.btnBoQua.UseVisualStyleBackColor = false;
            this.btnBoQua.Click += new System.EventHandler(this.btnBoQua_Click);
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(132, 116);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(121, 20);
            this.txtTenKH.TabIndex = 55;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(40, 119);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 13);
            this.label10.TabIndex = 54;
            this.label10.Text = "Tên khách hàng";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(201, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(321, 29);
            this.label11.TabIndex = 106;
            this.label11.Text = "Danh Mục Khách Quảng Cáo";
            // 
            // frmKhachQuangCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(736, 341);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtTenKH);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnBoQua);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.mskNgayKT);
            this.Controls.Add(this.mskNgayBD);
            this.Controls.Add(this.cboMaQCao);
            this.Controls.Add(this.cboMaNV);
            this.Controls.Add(this.cboMaBao);
            this.Controls.Add(this.cboMaKH);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.DataGridView);
            this.Controls.Add(this.txtNoiDung);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.txtMaLanQCao);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmKhachQuangCao";
            this.Text = "frmKhachQuangCao";
            this.Load += new System.EventHandler(this.frmKhachQuangCao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.TextBox txtNoiDung;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.TextBox txtMaLanQCao;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboMaKH;
        private System.Windows.Forms.ComboBox cboMaBao;
        private System.Windows.Forms.ComboBox cboMaNV;
        private System.Windows.Forms.ComboBox cboMaQCao;
        private System.Windows.Forms.MaskedTextBox mskNgayBD;
        private System.Windows.Forms.MaskedTextBox mskNgayKT;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnBoQua;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}