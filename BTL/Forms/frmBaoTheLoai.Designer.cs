namespace BTL.Forms
{
    partial class frmBaoTheLoai
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
            this.label6 = new System.Windows.Forms.Label();
            this.txtNhuanBut = new System.Windows.Forms.TextBox();
            this.cboMaTheLoai = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboMaBao = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBoQua
            // 
            this.btnBoQua.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBoQua.Location = new System.Drawing.Point(434, 298);
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
            this.btnLuu.Location = new System.Drawing.Point(331, 298);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(82, 23);
            this.btnLuu.TabIndex = 91;
            this.btnLuu.Text = "Luu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThem.Location = new System.Drawing.Point(34, 298);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(82, 23);
            this.btnThem.TabIndex = 90;
            this.btnThem.Text = "Them";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnXoa.Location = new System.Drawing.Point(228, 298);
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
            this.btnThoat.Location = new System.Drawing.Point(537, 298);
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
            this.btnSua.Location = new System.Drawing.Point(139, 298);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 87;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // DataGridView
            // 
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Location = new System.Drawing.Point(32, 185);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.Size = new System.Drawing.Size(580, 95);
            this.DataGridView.TabIndex = 86;
            this.DataGridView.Click += new System.EventHandler(this.DataGridView_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(184, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 101;
            this.label6.Text = "Nhuận Bút";
            // 
            // txtNhuanBut
            // 
            this.txtNhuanBut.Location = new System.Drawing.Point(270, 142);
            this.txtNhuanBut.Name = "txtNhuanBut";
            this.txtNhuanBut.Size = new System.Drawing.Size(121, 20);
            this.txtNhuanBut.TabIndex = 100;
            this.txtNhuanBut.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNhuanBut_KeyPress);
            // 
            // cboMaTheLoai
            // 
            this.cboMaTheLoai.FormattingEnabled = true;
            this.cboMaTheLoai.Location = new System.Drawing.Point(270, 115);
            this.cboMaTheLoai.Name = "cboMaTheLoai";
            this.cboMaTheLoai.Size = new System.Drawing.Size(121, 21);
            this.cboMaTheLoai.TabIndex = 99;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(184, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 98;
            this.label2.Text = "Mã Thể Loại";
            // 
            // cboMaBao
            // 
            this.cboMaBao.FormattingEnabled = true;
            this.cboMaBao.Location = new System.Drawing.Point(270, 79);
            this.cboMaBao.Name = "cboMaBao";
            this.cboMaBao.Size = new System.Drawing.Size(121, 21);
            this.cboMaBao.TabIndex = 103;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(184, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 102;
            this.label1.Text = "Mã Báo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(214, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 33);
            this.label3.TabIndex = 104;
            this.label3.Text = "Báo Thể Loại";
            // 
            // frmBaoTheLoai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 339);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboMaBao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNhuanBut);
            this.Controls.Add(this.cboMaTheLoai);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBoQua);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.DataGridView);
            this.Name = "frmBaoTheLoai";
            this.Text = "frmBaoTheLoai";
            this.Load += new System.EventHandler(this.frmBaoTheLoai_Load);
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
        private System.Windows.Forms.TextBox txtNhuanBut;
        private System.Windows.Forms.ComboBox cboMaTheLoai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboMaBao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}