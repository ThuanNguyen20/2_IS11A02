namespace BTL.Forms
{
    partial class frmBao
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
            this.MaBao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenBao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaChucNang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.cboMaChucNang = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaBao = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenBao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBoQua
            // 
            this.btnBoQua.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBoQua.Location = new System.Drawing.Point(428, 300);
            this.btnBoQua.Name = "btnBoQua";
            this.btnBoQua.Size = new System.Drawing.Size(82, 23);
            this.btnBoQua.TabIndex = 85;
            this.btnBoQua.Text = "Bỏ Qua";
            this.btnBoQua.UseVisualStyleBackColor = false;
            this.btnBoQua.Click += new System.EventHandler(this.btnBoQua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLuu.Location = new System.Drawing.Point(325, 300);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(82, 23);
            this.btnLuu.TabIndex = 84;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThem.Location = new System.Drawing.Point(28, 300);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(82, 23);
            this.btnThem.TabIndex = 83;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnXoa.Location = new System.Drawing.Point(222, 300);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(82, 23);
            this.btnXoa.TabIndex = 82;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThoat.Location = new System.Drawing.Point(526, 300);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 81;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSua.Location = new System.Drawing.Point(133, 300);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 80;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // DataGridView
            // 
            this.DataGridView.BackgroundColor = System.Drawing.Color.White;
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaBao,
            this.TenBao,
            this.MaChucNang,
            this.DiaChi,
            this.DienThoai,
            this.Email});
            this.DataGridView.Location = new System.Drawing.Point(37, 139);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.Size = new System.Drawing.Size(555, 145);
            this.DataGridView.TabIndex = 79;
            this.DataGridView.Click += new System.EventHandler(this.DataGridView_Click);
            // 
            // MaBao
            // 
            this.MaBao.DataPropertyName = "MaBao";
            this.MaBao.HeaderText = "Mã Báo";
            this.MaBao.Name = "MaBao";
            // 
            // TenBao
            // 
            this.TenBao.DataPropertyName = "TenBao";
            this.TenBao.HeaderText = "Tên Báo";
            this.TenBao.Name = "TenBao";
            // 
            // MaChucNang
            // 
            this.MaChucNang.DataPropertyName = "MaChucNang";
            this.MaChucNang.HeaderText = "Mã Chức Năng";
            this.MaChucNang.Name = "MaChucNang";
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa Chỉ";
            this.DiaChi.Name = "DiaChi";
            // 
            // DienThoai
            // 
            this.DienThoai.DataPropertyName = "DienThoai";
            this.DienThoai.HeaderText = "Điện Thoại";
            this.DienThoai.Name = "DienThoai";
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.AntiqueWhite;
            this.label6.Location = new System.Drawing.Point(330, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 97;
            this.label6.Text = "Địa Chỉ";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(416, 107);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(121, 20);
            this.txtDiaChi.TabIndex = 96;
            // 
            // cboMaChucNang
            // 
            this.cboMaChucNang.FormattingEnabled = true;
            this.cboMaChucNang.Location = new System.Drawing.Point(143, 104);
            this.cboMaChucNang.Name = "cboMaChucNang";
            this.cboMaChucNang.Size = new System.Drawing.Size(121, 21);
            this.cboMaChucNang.TabIndex = 95;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.AntiqueWhite;
            this.label2.Location = new System.Drawing.Point(57, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 94;
            this.label2.Text = "Mã Chức Năng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.label1.Location = new System.Drawing.Point(57, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 93;
            this.label1.Text = "Mã Báo";
            // 
            // txtMaBao
            // 
            this.txtMaBao.Location = new System.Drawing.Point(143, 52);
            this.txtMaBao.Name = "txtMaBao";
            this.txtMaBao.Size = new System.Drawing.Size(121, 20);
            this.txtMaBao.TabIndex = 92;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.AntiqueWhite;
            this.label3.Location = new System.Drawing.Point(57, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 99;
            this.label3.Text = "Tên Báo";
            // 
            // txtTenBao
            // 
            this.txtTenBao.Location = new System.Drawing.Point(143, 78);
            this.txtTenBao.Name = "txtTenBao";
            this.txtTenBao.Size = new System.Drawing.Size(121, 20);
            this.txtTenBao.TabIndex = 98;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.AntiqueWhite;
            this.label4.Location = new System.Drawing.Point(330, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 101;
            this.label4.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(416, 81);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(121, 20);
            this.txtEmail.TabIndex = 100;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.AntiqueWhite;
            this.label5.Location = new System.Drawing.Point(330, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 103;
            this.label5.Text = "Điện Thoại";
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Location = new System.Drawing.Point(416, 54);
            this.txtDienThoai.MaxLength = 10;
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(121, 20);
            this.txtDienThoai.TabIndex = 102;
            this.txtDienThoai.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDienThoai_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(208, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(212, 32);
            this.label7.TabIndex = 104;
            this.label7.Text = "DANH MỤC BÁO";
            // 
            // frmBao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(641, 345);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDienThoai);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTenBao);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.cboMaChucNang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMaBao);
            this.Controls.Add(this.btnBoQua);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.DataGridView);
            this.Name = "frmBao";
            this.Text = "frmBao";
            this.Load += new System.EventHandler(this.frmBao_Load);
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.ComboBox cboMaChucNang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaBao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenBao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaBao;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenBao;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaChucNang;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn DienThoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
    }
}