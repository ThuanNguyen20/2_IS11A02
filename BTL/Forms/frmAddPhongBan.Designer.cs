namespace BTL.Forms
{
    partial class frmAddPhongBan
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
            this.btnHuy = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTenPhong = new System.Windows.Forms.TextBox();
            this.txtMaPhong = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboMaBao = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(181, 156);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(94, 33);
            this.btnLuu.TabIndex = 97;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHuy.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Location = new System.Drawing.Point(334, 156);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(2);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(92, 33);
            this.btnHuy.TabIndex = 96;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.AntiqueWhite;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(330, 83);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 19);
            this.label7.TabIndex = 94;
            this.label7.Text = "Mã Báo";
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtDienThoai.Location = new System.Drawing.Point(427, 120);
            this.txtDienThoai.Margin = new System.Windows.Forms.Padding(2);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(181, 20);
            this.txtDienThoai.TabIndex = 93;
            this.txtDienThoai.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDienThoai_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.AntiqueWhite;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(330, 119);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 19);
            this.label6.TabIndex = 92;
            this.label6.Text = "Điện Thoại";
            // 
            // txtTenPhong
            // 
            this.txtTenPhong.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtTenPhong.Location = new System.Drawing.Point(109, 118);
            this.txtTenPhong.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenPhong.Name = "txtTenPhong";
            this.txtTenPhong.Size = new System.Drawing.Size(181, 20);
            this.txtTenPhong.TabIndex = 91;
            // 
            // txtMaPhong
            // 
            this.txtMaPhong.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtMaPhong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaPhong.Location = new System.Drawing.Point(109, 83);
            this.txtMaPhong.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaPhong.Name = "txtMaPhong";
            this.txtMaPhong.Size = new System.Drawing.Size(181, 20);
            this.txtMaPhong.TabIndex = 90;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.AntiqueWhite;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 117);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 19);
            this.label2.TabIndex = 89;
            this.label2.Text = "Tên Phòng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 82);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 19);
            this.label1.TabIndex = 88;
            this.label1.Text = "Mã Phòng";
            // 
            // cboMaBao
            // 
            this.cboMaBao.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cboMaBao.FormattingEnabled = true;
            this.cboMaBao.Location = new System.Drawing.Point(427, 81);
            this.cboMaBao.Name = "cboMaBao";
            this.cboMaBao.Size = new System.Drawing.Size(181, 21);
            this.cboMaBao.TabIndex = 109;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(148, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(353, 31);
            this.label3.TabIndex = 110;
            this.label3.Text = "Danh Mục Thêm Phòng Ban";
            // 
            // frmAddPhongBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(635, 231);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboMaBao);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDienThoai);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTenPhong);
            this.Controls.Add(this.txtMaPhong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmAddPhongBan";
            this.Text = "frmAddPhongBan";
            this.Load += new System.EventHandler(this.frmAddPhongBan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnLuu;
        public System.Windows.Forms.Button btnHuy;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txtDienThoai;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtTenPhong;
        public System.Windows.Forms.TextBox txtMaPhong;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboMaBao;
        private System.Windows.Forms.Label label3;
    }
}