namespace BTL.Forms
{
    partial class frmTimKiem
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
            this.lblMaTheLoai = new System.Windows.Forms.Label();
            this.lblMaBao = new System.Windows.Forms.Label();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnlamlai = new System.Windows.Forms.Button();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.cboMaTheLoai = new System.Windows.Forms.ComboBox();
            this.cboMaBao = new System.Windows.Forms.ComboBox();
            this.btnInBaocao = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMaTheLoai
            // 
            this.lblMaTheLoai.AutoSize = true;
            this.lblMaTheLoai.Location = new System.Drawing.Point(106, 113);
            this.lblMaTheLoai.Name = "lblMaTheLoai";
            this.lblMaTheLoai.Size = new System.Drawing.Size(70, 13);
            this.lblMaTheLoai.TabIndex = 21;
            this.lblMaTheLoai.Text = "Mã Thể Loại:";
            // 
            // lblMaBao
            // 
            this.lblMaBao.AutoSize = true;
            this.lblMaBao.Location = new System.Drawing.Point(106, 72);
            this.lblMaBao.Name = "lblMaBao";
            this.lblMaBao.Size = new System.Drawing.Size(46, 13);
            this.lblMaBao.TabIndex = 22;
            this.lblMaBao.Text = "Mã báo:";
            // 
            // DataGridView
            // 
            this.DataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Location = new System.Drawing.Point(35, 150);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.Size = new System.Drawing.Size(438, 107);
            this.DataGridView.TabIndex = 20;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(382, 278);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(91, 23);
            this.btnThoat.TabIndex = 19;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnlamlai
            // 
            this.btnlamlai.BackColor = System.Drawing.Color.White;
            this.btnlamlai.Location = new System.Drawing.Point(142, 275);
            this.btnlamlai.Name = "btnlamlai";
            this.btnlamlai.Size = new System.Drawing.Size(91, 23);
            this.btnlamlai.TabIndex = 17;
            this.btnlamlai.Text = "Làm lại";
            this.btnlamlai.UseVisualStyleBackColor = false;
            this.btnlamlai.Click += new System.EventHandler(this.btnlamlai_Click);
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.BackColor = System.Drawing.Color.White;
            this.btnTimkiem.Location = new System.Drawing.Point(35, 275);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(91, 23);
            this.btnTimkiem.TabIndex = 18;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.UseVisualStyleBackColor = false;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // cboMaTheLoai
            // 
            this.cboMaTheLoai.FormattingEnabled = true;
            this.cboMaTheLoai.Location = new System.Drawing.Point(239, 110);
            this.cboMaTheLoai.Name = "cboMaTheLoai";
            this.cboMaTheLoai.Size = new System.Drawing.Size(121, 21);
            this.cboMaTheLoai.TabIndex = 15;
            // 
            // cboMaBao
            // 
            this.cboMaBao.FormattingEnabled = true;
            this.cboMaBao.Location = new System.Drawing.Point(239, 64);
            this.cboMaBao.Name = "cboMaBao";
            this.cboMaBao.Size = new System.Drawing.Size(121, 21);
            this.cboMaBao.TabIndex = 16;
            // 
            // btnInBaocao
            // 
            this.btnInBaocao.BackColor = System.Drawing.Color.White;
            this.btnInBaocao.Location = new System.Drawing.Point(257, 278);
            this.btnInBaocao.Name = "btnInBaocao";
            this.btnInBaocao.Size = new System.Drawing.Size(91, 23);
            this.btnInBaocao.TabIndex = 23;
            this.btnInBaocao.Text = "In Báo cáo";
            this.btnInBaocao.UseVisualStyleBackColor = false;
            this.btnInBaocao.Click += new System.EventHandler(this.btnInBaocao_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(71, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(352, 31);
            this.label1.TabIndex = 40;
            this.label1.Text = "TÌM KIẾM BÁO THỂ LOẠI";
            // 
            // frmTimKiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(527, 313);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnInBaocao);
            this.Controls.Add(this.lblMaTheLoai);
            this.Controls.Add(this.lblMaBao);
            this.Controls.Add(this.DataGridView);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnlamlai);
            this.Controls.Add(this.btnTimkiem);
            this.Controls.Add(this.cboMaTheLoai);
            this.Controls.Add(this.cboMaBao);
            this.Name = "frmTimKiem";
            this.Text = "frmTimKiem";
            this.Load += new System.EventHandler(this.frmTimKiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMaTheLoai;
        private System.Windows.Forms.Label lblMaBao;
        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnlamlai;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.ComboBox cboMaTheLoai;
        private System.Windows.Forms.ComboBox cboMaBao;
        private System.Windows.Forms.Button btnInBaocao;
        private System.Windows.Forms.Label label1;
    }
}