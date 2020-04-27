namespace BTL.Forms
{
    partial class fXuatBaoCao
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbbKieuThongKe = new System.Windows.Forms.ComboBox();
            this.numbThangQuy = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.numbNam = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numbThangQuy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numbNam)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.Location = new System.Drawing.Point(3, 16);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(662, 299);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.reportViewer1);
            this.groupBox1.Location = new System.Drawing.Point(0, 174);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(668, 318);
            this.groupBox1.TabStop = false;
            // 
            // cbbKieuThongKe
            // 
            this.cbbKieuThongKe.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbKieuThongKe.FormattingEnabled = true;
            this.cbbKieuThongKe.Items.AddRange(new object[] {
            "(None)",
            "Thống kê theo năm",
            "Thống kê theo quý",
            "Thống kê theo tháng"});
            this.cbbKieuThongKe.Location = new System.Drawing.Point(76, 31);
            this.cbbKieuThongKe.Name = "cbbKieuThongKe";
            this.cbbKieuThongKe.Size = new System.Drawing.Size(247, 23);
            this.cbbKieuThongKe.TabIndex = 2;
            // 
            // numbThangQuy
            // 
            this.numbThangQuy.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numbThangQuy.Location = new System.Drawing.Point(76, 119);
            this.numbThangQuy.Name = "numbThangQuy";
            this.numbThangQuy.Size = new System.Drawing.Size(247, 22);
            this.numbThangQuy.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 15);
            this.label1.Text = "B1: Chọn kiểu thống kê";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(429, 15);
            this.label2.Text = "B3: Điền giá trị của tháng/quý (tháng trong khoảng 1-12, quý trong khoảng 1-4)";
            // 
            // btnThongKe
            // 
            this.btnThongKe.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnThongKe.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.Location = new System.Drawing.Point(560, 119);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(96, 49);
            this.btnThongKe.TabIndex = 5;
            this.btnThongKe.Text = "Xác nhận";
            this.btnThongKe.UseVisualStyleBackColor = false;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 15);
            this.label3.Text = "B2: Điền giá trị của năm";
            // 
            // numbNam
            // 
            this.numbNam.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numbNam.Location = new System.Drawing.Point(76, 75);
            this.numbNam.Name = "numbNam";
            this.numbNam.Size = new System.Drawing.Size(247, 22);
            this.numbNam.TabIndex = 3;
            // 
            // fXuatBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(668, 492);
            this.Controls.Add(this.numbNam);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numbThangQuy);
            this.Controls.Add(this.cbbKieuThongKe);
            this.Controls.Add(this.groupBox1);
            this.Name = "fXuatBaoCao";
            this.Text = "Xuất báo cáo";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fXuatBaoCao_FormClosed);
            this.Load += new System.EventHandler(this.fXuatBaoCao_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numbThangQuy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numbNam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbbKieuThongKe;
        private System.Windows.Forms.NumericUpDown numbThangQuy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numbNam;
    }
}