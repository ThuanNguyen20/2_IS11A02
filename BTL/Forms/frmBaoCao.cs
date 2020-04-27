using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using COMExcel = Microsoft.Office.Interop.Excel;

namespace BTL.Forms
{
    public partial class frmBaoCao : Form
    {
        public frmBaoCao()
        {
            InitializeComponent();
        }

        private void frmBaoCao_Load(object sender, EventArgs e)
        {
            Hienthi_Luoi();
        }

        private void Hienthi_Luoi()
        {
            string sql;
            DataTable tblBaocao;
            sql = "SELECT tblNhanVien.MaNV, tblNhanVien.TenNV, count(tblKhachGuiBai.MaLanGui), count(tblKhachQuangCao.MaLanQCao) from tblNhanVien left join tblKhachGuiBai on tblNhanVien.MaNV=tblKhachGuiBai.MaNV left join tblKhachQuangCao on tblNhanVien.MaNV=tblKhachQuangCao.MaNV group by tblNhanVien.MaNV, tblNhanVien.TenNV ";
            tblBaocao = Class.Functions.GetDataToTable(sql);
            dataGridView.DataSource = tblBaocao;
            dataGridView.Columns[0].HeaderText = "Mã nhân viên";
            dataGridView.Columns[1].HeaderText = "Tên nhân viên";
            dataGridView.Columns[2].HeaderText = "Số lần nhận";
            dataGridView.Columns[3].HeaderText = "Số lần quảng cáo";
            dataGridView.Columns[0].Width = 50;
            dataGridView.Columns[1].Width = 150;
            dataGridView.Columns[2].Width = 100;
            dataGridView.Columns[3].Width = 100;
            dataGridView.AllowUserToAddRows = false;
            dataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
            tblBaocao.Dispose();
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaNV.Text = dataGridView.CurrentRow.Cells[0].Value.ToString();
            txtTenNV.Text = dataGridView.CurrentRow.Cells[1].Value.ToString();
            txtNhan.Text = dataGridView.CurrentRow.Cells[2].Value.ToString();
            txtQC.Text = dataGridView.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            // Khởi động chương trình Excel
            COMExcel.Application exApp = new COMExcel.Application();
            COMExcel.Workbook exBook; //Trong 1 chương trình Excel có nhiều Workbook
            COMExcel.Worksheet exSheet; //Trong 1 Workbook có nhiều Worksheet
            COMExcel.Range exRange; 
            string sql;
            int hang=0, cot=0;
            DataTable tblThongtinHang;
            exBook = exApp.Workbooks.Add(COMExcel.XlWBATemplate.xlWBATWorksheet);
            exSheet = exBook.Worksheets[1];
            // Định dạng chung
            exRange = exSheet.Cells[1, 1];
            exRange.Range["B2:E2"].Font.Size = 16;
            exRange.Range["B2:E2"].Font.Name = "Times new roman";
            exRange.Range["B2:E2"].Font.Bold = true;
            exRange.Range["B2:E2"].Font.ColorIndex = 3; //Màu đỏ
            exRange.Range["B2:E2"].MergeCells = true;
            exRange.Range["B2:E2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["B2:E2"].Value = "Báo cáo Quảng Cáo";
           
            sql = "SELECT tblNhanVien.MaNV, tblNhanVien.TenNV, count(tblKhachGuiBai.MaLanGui), count(tblKhachQuangCao.MaLanQCao) from tblNhanVien left join tblKhachGuiBai on tblNhanVien.MaNV=tblKhachGuiBai.MaNV left join tblKhachQuangCao on tblNhanVien.MaNV=tblKhachQuangCao.MaNV group by tblNhanVien.MaNV, tblNhanVien.TenNV ";
            tblThongtinHang = Class.Functions.GetDataToTable(sql);
            //Tạo dòng tiêu đề bảng
            exRange.Range["A5:E5"].Font.Bold = true;
            exRange.Range["A5:E5"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C5:E5"].ColumnWidth = 12;
            exRange.Range["A5:A5"].Value = "STT";
            exRange.Range["B5:B5"].Value = "Mã nhân viên";
            exRange.Range["C5:C5"].Value = "Tên nhân viên";
            exRange.Range["D5:D5"].Value = "Số lần nhận quảng cáo";
            exRange.Range["E5:E5"].Value = "Số lần nhận bài gửi";
            for (hang = 0 ; hang <= tblThongtinHang.Rows.Count - 1; hang ++)
            {
                //Điền số thứ tự vào cột 1 từ dòng 12
                exSheet.Cells[1][hang + 6] = hang + 1;
                for (cot = 0 ; cot <= tblThongtinHang.Columns.Count - 1; cot++)
                    //Điền thông tin hàng từ cột thứ 2, dòng 12
              exSheet.Cells[cot + 2][hang + 6]= tblThongtinHang.Rows[hang][cot].ToString();
            }
            
            exRange = exSheet.Cells[4][hang + 8]; //Ô A1 
            exRange.Range["A1:C1"].MergeCells = true;
            exRange.Range["A1:C1"].Font.Italic = true;
            exRange.Range["A1:C1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            DateTime d = Convert.ToDateTime(DateTime.Now);
            exRange.Range["A1:C1"].Value = "Hà Nội, ngày " + d.Day + " tháng " + d.Month + " năm " + d.Year;
            exRange.Range["A2:C2"].MergeCells = true;
            exRange.Range["A2:C2"].Font.Italic = true;
            exRange.Range["A2:C2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A2:C2"].Value = "Người lập báo cáo";
            
            exApp.Visible = true;

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
