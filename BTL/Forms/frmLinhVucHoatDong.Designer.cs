namespace BTL.Forms
{
    partial class frmLinhVucHoatDong
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
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.txtTenLVHD = new System.Windows.Forms.TextBox();
            this.txtMaLVHD = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.Snow;
            this.btnLuu.Location = new System.Drawing.Point(295, 244);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(74, 34);
            this.btnLuu.TabIndex = 21;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // DataGridView
            // 
            this.DataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Location = new System.Drawing.Point(12, 130);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.Size = new System.Drawing.Size(466, 89);
            this.DataGridView.TabIndex = 20;
            this.DataGridView.Click += new System.EventHandler(this.DataGridView_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Snow;
            this.btnXoa.Location = new System.Drawing.Point(205, 244);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(74, 34);
            this.btnXoa.TabIndex = 19;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.Snow;
            this.btnSua.Location = new System.Drawing.Point(115, 244);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(74, 34);
            this.btnSua.TabIndex = 18;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // txtTenLVHD
            // 
            this.txtTenLVHD.Location = new System.Drawing.Point(346, 79);
            this.txtTenLVHD.Name = "txtTenLVHD";
            this.txtTenLVHD.Size = new System.Drawing.Size(100, 20);
            this.txtTenLVHD.TabIndex = 17;
            // 
            // txtMaLVHD
            // 
            this.txtMaLVHD.Location = new System.Drawing.Point(114, 79);
            this.txtMaLVHD.Name = "txtMaLVHD";
            this.txtMaLVHD.Size = new System.Drawing.Size(100, 20);
            this.txtMaLVHD.TabIndex = 16;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Snow;
            this.btnThem.Location = new System.Drawing.Point(25, 244);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(74, 34);
            this.btnThem.TabIndex = 15;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(271, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Tên LVHD";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Mã LVHD";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(71, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(321, 25);
            this.label3.TabIndex = 22;
            this.label3.Text = "Danh Mục Lĩnh Vực Hoạt Động";
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Snow;
            this.btnThoat.Location = new System.Drawing.Point(388, 244);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(74, 34);
            this.btnThoat.TabIndex = 23;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmLinhVucHoatDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(553, 310);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.DataGridView);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.txtTenLVHD);
            this.Controls.Add(this.txtMaLVHD);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmLinhVucHoatDong";
            this.Text = "frmLinhVucHoatDong";
            this.Load += new System.EventHandler(this.frmLinhVucHoatDong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.TextBox txtTenLVHD;
        private System.Windows.Forms.TextBox txtMaLVHD;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnThoat;
    }
}