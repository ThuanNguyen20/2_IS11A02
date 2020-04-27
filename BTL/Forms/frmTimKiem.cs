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
    public partial class frmTimKiem : Form
    {
        public frmTimKiem()
        {
            InitializeComponent();
        }
        DataTable tblTimKiem;
        private void frmTimKiem_Load(object sender, EventArgs e)
        {
            DataGridView.DataSource = null;
            cboMaBao.DataSource = Class.Functions.GetDataToTable("SELECT MaBao FROM tblBao");
            cboMaBao.ValueMember = "MaBao";
            cboMaBao.SelectedIndex = -1;
            cboMaTheLoai.DataSource = Class.Functions.GetDataToTable("SELECT MaTheLoai FROM tblTheLoai");
            cboMaTheLoai.DisplayMember = "MaTheLoai";
            cboMaTheLoai.SelectedIndex = -1;
        }

        private void Load_DataGridView()
        {
            //string sql;
            //sql = "SELECT MaBao, MaTheLoai, NhuanBut FROM tblBTL";
            //tblTimKiem = Class.Function.DocBang(sql);
            DataGridView.DataSource = tblTimKiem;
            DataGridView.Columns[0].HeaderText = "Mã Báo";
            DataGridView.Columns[1].HeaderText = "Mã Thể Loại";
            DataGridView.Columns[2].HeaderText = "Nhuận Bút";
            DataGridView.Columns[0].Width = 120;
            DataGridView.Columns[1].Width = 120;
            DataGridView.Columns[2].Width = 120;
            DataGridView.AllowUserToAddRows = false;
            DataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
            // tblTimKiem.Dispose();
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            string sql;
            if ((cboMaBao.Text == "") && (cboMaTheLoai.Text == ""))
            {
                MessageBox.Show("Hãy nhập một điều kiện tìm kiếm!", "Yêu cầu ...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sql = "SELECT * FROM tblBaoTheLoai WHERE 1=1";
            if (cboMaBao.Text != "")
                sql = sql + " AND MaBao Like N'%" + cboMaBao.Text + "%'";
            if (cboMaTheLoai.Text != "")
                sql = sql + " AND MaTheLoai Like N'%" + cboMaTheLoai.Text + "%'";
            tblTimKiem = Class.Functions.GetDataToTable(sql);
            if (tblTimKiem.Rows.Count == 0)
            {
                MessageBox.Show("Không có bản ghi thỏa mãn điều kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                XoaDuLieuTrongTextbox();
            }
            else
                MessageBox.Show("Có " + tblTimKiem.Rows.Count + " Bản ghi thỏa mãn điều kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            DataGridView.DataSource = tblTimKiem;
            Load_DataGridView();
        }

        private void XoaDuLieuTrongTextbox()
        {
            cboMaBao.Text = "";
            cboMaTheLoai.Text = "";
        }

        private void btnlamlai_Click(object sender, EventArgs e)
        {
            XoaDuLieuTrongTextbox();
            DataGridView.DataSource = null;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private void btnInBaocao_Click_1(object sender, EventArgs e)
        {
            COMExcel.Application exApp = new COMExcel.Application();
            COMExcel.Workbook exBook; //Trong 1 chương trình Excel có nhiều Workbook
            COMExcel.Worksheet exSheet; //Trong 1 Workbook có nhiều Worksheet
            COMExcel.Range exRange;
            string sql;
            int hang = 0, cot = 0;
            DataTable tblTimKiem;
            exBook = exApp.Workbooks.Add(COMExcel.XlWBATemplate.xlWBATWorksheet);
            exSheet = exBook.Worksheets[1];
            // Định dạng chung
            exRange = exSheet.Cells[1, 1];
            exRange.Range["A1:B3"].Font.Size = 10;
            exRange.Range["A1:B3"].Font.Name = "Times new roman";
            exRange.Range["A1:B3"].Font.Bold = true;
            exRange.Range["A1:B3"].Font.ColorIndex = 5; //Màu xanh da trời
            exRange.Range["A1:A1"].ColumnWidth = 7;
            exRange.Range["B1:B1"].ColumnWidth = 15;
            exRange.Range["A1:B1"].MergeCells = true;
            exRange.Range["A1:B1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A1:B1"].Value = "Công ty Quảng cáo";
            exRange.Range["A2:B2"].MergeCells = true;
            exRange.Range["A2:B2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A2:B2"].Value = "Chùa Bộc - Hà Nội";
            exRange.Range["A3:B3"].MergeCells = true;
            exRange.Range["A3:B3"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A3:B3"].Value = "Điện thoại: (04)37562222";
            exRange.Range["C2:H2"].Font.Size = 16;
            exRange.Range["C2:H2"].Font.Name = "Times new roman";
            exRange.Range["C2:H2"].Font.Bold = true;
            exRange.Range["C2:H2"].Font.ColorIndex = 3; //Màu đỏ
            exRange.Range["C2:H2"].MergeCells = true;
            exRange.Range["C2:H2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C2:H2"].Value = "BÁO CÁO THỂ LOẠI CỦA TỪNG BÁO";

            sql = "SELECT tblBaoTheLoai.MaBao, tblBao.TenBao, tblBaoTheLoai.MaTheLoai, tblTheLoai.TenTheLoai, tblBaoTheLoai.NhuanBut FROM tblBao join tblBaoTheLoai on tblBao.MaBao = tblBaoTheLoai.MaBao  join tblTheLoai on tblBaoTheLoai.MaTheLoai = tblTheLoai.MaTheLoai WHERE tblBaoTheLoai.MaBao = N'" + cboMaBao.Text + "' AND tblBaoTheLoai.MaTheLoai = N'" + cboMaTheLoai.Text + "'";
            tblTimKiem = Class.Functions.GetDataToTable(sql);
            //Tạo dòng tiêu đề bảng
            exRange.Range["A6:F6"].Font.Bold = true;
            exRange.Range["A6:F6"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C6:F6"].ColumnWidth = 12;
            exRange.Range["A6:A6"].Value = "STT";
            exRange.Range["B6:B6"].Value = "Mã báo";
            exRange.Range["C6:C6"].Value = "Tên báo";
            exRange.Range["D6:D6"].Value = "Mã thể loại";
            exRange.Range["E6:E6"].Value = "Tên thể loại";
            exRange.Range["F6:F6"].Value = "Nhuận bút";
            for (hang = 0; hang <= tblTimKiem.Rows.Count - 1; hang++)
            {
                //Điền số thứ tự vào cột 1 từ dòng 12
                exSheet.Cells[1][hang + 7] = hang + 1;
                for (cot = 0; cot <= tblTimKiem.Columns.Count - 1; cot++)
                    //Điền thông tin hàng từ cột thứ 2, dòng 12
                    exSheet.Cells[cot + 2][hang + 7] = tblTimKiem.Rows[hang][cot].ToString();
            }


            exRange.Range["A1:C1"].MergeCells = true;
            exRange.Range["A1:C1"].Font.Italic = true;
            exRange.Range["A1:C1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;

            exSheet.Name = "Tìm kiếm";
            exApp.Visible = true;
        }
        }        
    }
