using BTL.Class;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL.Forms
{
    public partial class fXuatBaoCao : Form
    {
        string nametable;
        string reportPath;
        public fXuatBaoCao()
        {
            InitializeComponent();
        }

        public fXuatBaoCao(string nametable, string reportPath)
        {
            InitializeComponent();
            this.nametable = nametable;
            this.reportPath = reportPath;
            this.numbNam.Maximum = 2100;
            this.numbNam.Minimum = 1950;
            this.numbThangQuy.Maximum = 12;
            this.numbThangQuy.Minimum = 1;
        }

        private void fXuatBaoCao_Load(object sender, EventArgs e)
        {
            btnThongKe_Click(sender, e);
        }

        #region Event closed form
        private void fXuatBaoCao_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                this.Owner.Show();
                this.Owner.Enabled = true;
                this.Owner = null;
                this.Dispose();
            }
            catch (Exception) { }
        }
        #endregion

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            // Chạy lệnh cập nhật các bản ghi liên quan đến nghiệp vụ
            Connection.ExecuteSQL(@"execute pUpdate_tblKhachGuiBai");
            Connection.ExecuteSQL(@"execute pUpdate_tblKhachQuangCao");


            // Bắt đầu thực hiện truy vấn
            string query = string.Format("select * from {0}", nametable);
            switch (this.cbbKieuThongKe.Text)
            {
                case "Thống kê theo năm":
                    if (nametable == "vBaoCaoChiPhiKhachGuiBai")
                        query = string.Format("select * from {0} where year(NgayDang) = {1}", nametable, numbNam.Value);
                    else if (nametable == "vBaoCaoDoanhThuQuangCao")
                        query = string.Format("select * from {0} where year(NgayKT) = {1}", nametable, numbNam.Value);
                    break;
                case "Thống kê theo quý":
                    if (nametable == "vBaoCaoChiPhiKhachGuiBai")
                        query = string.Format("select * from {0} where Month(NgayDang) >= (({1} - 1) * 3 + 1) and Month(NgayDang) <= ({1} * 3) and Year(NgayDang) = {2}", nametable, numbThangQuy.Value, numbNam.Value);
                    else if (nametable == "vBaoCaoDoanhThuQuangCao")
                        query = string.Format("select * from {0} where Month(NgayKT) >= (({1} - 1) * 3 + 1) and Month(NgayKT) <= ({1} * 3) and Year(NgayKT) = {2}", nametable, numbThangQuy.Value, numbNam.Value);
                    break;
                case "Thống kê theo tháng":
                    if (nametable == "vBaoCaoChiPhiKhachGuiBai")
                        query = string.Format("select * from {0} where Month(NgayDang) = {1} and year(NgayDang) = {2}", nametable, numbThangQuy.Value, numbNam.Value);
                    else if (nametable == "vBaoCaoDoanhThuQuangCao")
                        query = string.Format("select * from {0} where Month(NgayKT) = {1} and year(NgayKT) = {2}", nametable, numbThangQuy.Value, numbNam.Value);
                    break;
                default:
                    break;
            }

            // thực hiện truy vấn với câu lệnh ở biến "query"
            this.reportViewer1.LocalReport.DataSources.Clear();
            var datatable = Connection.ExecuteQuery(query);
            var rprtDTSource = new ReportDataSource("DataSet1", datatable);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = reportPath;
            this.reportViewer1.LocalReport.DataSources.Add(rprtDTSource);
            this.reportViewer1.RefreshReport();
        }
    }
}
