namespace BTL.Forms
{
    partial class frmBaoCao
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
            this.txtNhan = new System.Windows.Forms.TextBox();
            this.txtQC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.btnIn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNhan
            // 
            this.txtNhan.Location = new System.Drawing.Point(493, 80);
            this.txtNhan.Name = "txtNhan";
            this.txtNhan.Size = new System.Drawing.Size(99, 20);
            this.txtNhan.TabIndex = 17;
            // 
            // txtQC
            // 
            this.txtQC.Location = new System.Drawing.Point(493, 114);
            this.txtQC.Name = "txtQC";
            this.txtQC.Size = new System.Drawing.Size(99, 20);
            this.txtQC.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(369, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Số lần nhận bài gửi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(369, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Số lần nhận quảng cáo";
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(178, 114);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(100, 20);
            this.txtTenNV.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Tên nhân viên";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(178, 84);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(100, 20);
            this.txtMaNV.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Mã nhân viên";
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(38, 157);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(645, 109);
            this.dataGridView.TabIndex = 9;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(239, 272);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(75, 23);
            this.btnIn.TabIndex = 18;
            this.btnIn.Text = "In Báo Cáo";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(191, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(259, 29);
            this.label5.TabIndex = 19;
            this.label5.Text = "Báo Cáo Nhận Gửi Bài ";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(375, 272);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 20;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(695, 316);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.txtNhan);
            this.Controls.Add(this.txtQC);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTenNV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView);
            this.Name = "frmBaoCao";
            this.Text = "frmBaoCao";
            this.Load += new System.EventHandler(this.frmBaoCao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNhan;
        private System.Windows.Forms.TextBox txtQC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnThoat;
    }
}