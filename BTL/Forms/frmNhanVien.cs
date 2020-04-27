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
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            Hienthi_Luoi();
        }

        private void frmNhanVien_Activated(object sender, EventArgs e)
        {
            Hienthi_Luoi();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Hienthi_Luoi()
        {
            string sql;
            DataTable tblNhanVien;
            sql = "SELECT MaNV, TenNV, MaBao, MaPhong, MaChucVu, MaTĐ, MaCM, DiaChi, NgaySinh, GioiTinh, DienThoai, Mobile, Email FROM tblNhanVien";
            tblNhanVien = Class.Functions.GetDataToTable(sql);
            dataGridView.DataSource = tblNhanVien;
            dataGridView.Columns[0].HeaderText = "Mã Nhân Viên";
            dataGridView.Columns[1].HeaderText = "Tên Nhân Viên";
            dataGridView.Columns[2].HeaderText = "Mã Báo";
            dataGridView.Columns[3].HeaderText = "Mã Phòng";
            dataGridView.Columns[4].HeaderText = "Mã Chức Vụ";
            dataGridView.Columns[5].HeaderText = "Mã Trình Độ";
            dataGridView.Columns[6].HeaderText = "Mã Chuyên Môn";
            dataGridView.Columns[7].HeaderText = "Địa Chỉ";
            dataGridView.Columns[8].HeaderText = "Ngày Sinh";
            dataGridView.Columns[9].HeaderText = "Giới Tính";
            dataGridView.Columns[10].HeaderText = "Điện Thoại";
            dataGridView.Columns[11].HeaderText = "Mobile";
            dataGridView.Columns[12].HeaderText = "Email";
            dataGridView.Columns[0].Width = 100;
            dataGridView.Columns[1].Width = 100;
            dataGridView.Columns[2].Width = 100;
            dataGridView.Columns[3].Width = 100;
            dataGridView.Columns[4].Width = 150;
            dataGridView.Columns[5].Width = 100;
            dataGridView.Columns[6].Width = 100;
            dataGridView.Columns[7].Width = 100;
            dataGridView.Columns[8].Width = 100;
            dataGridView.Columns[9].Width = 100;
            dataGridView.Columns[10].Width = 100;
            dataGridView.Columns[11].Width = 100;
            dataGridView.Columns[12].Width = 100;
            dataGridView.AllowUserToAddRows = false;
            dataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
            tblNhanVien.Dispose();
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            Forms.frmAddNhanVien v = new Forms.frmAddNhanVien();
            v.StartPosition = FormStartPosition.CenterScreen;
            v.Show();
            Hienthi_Luoi();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow.Cells["MaNV"].Value.ToString() == "")
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo");
                return;
            }
            else
            {
                Forms.frmUpdateNhanVien v = new Forms.frmUpdateNhanVien();
                v.StartPosition = FormStartPosition.CenterScreen;
                v.txtMaNV.Text = dataGridView.CurrentRow.Cells["MaNV"].Value.ToString();
                v.txtTenNV.Text = dataGridView.CurrentRow.Cells["TenNV"].Value.ToString();
                v.cboGioiTinh.Text = dataGridView.CurrentRow.Cells["GioiTinh"].Value.ToString();
                v.txtDiaChi.Text = dataGridView.CurrentRow.Cells["DiaChi"].Value.ToString();
                v.txtDienThoai.Text = dataGridView.CurrentRow.Cells["DienThoai"].Value.ToString();
                v.txtMobile.Text = dataGridView.CurrentRow.Cells["Mobile"].Value.ToString();
                //v.txtMaBao.Text = dataGridView.CurrentRow.Cells["MaBao"].Value.ToString();
                //v.txtMaPhong.Text = dataGridView.CurrentRow.Cells["MaPhong"].Value.ToString();
                //v.txtMaChucVu.Text = dataGridView.CurrentRow.Cells["MaChucVu"].Value.ToString();
                //v.txtMaTĐ.Text = dataGridView.CurrentRow.Cells["MaTĐ"].Value.ToString();
                //v.txtMaCM.Text = dataGridView.CurrentRow.Cells["MaCM"].Value.ToString();
                
                v.txtEmail.Text = dataGridView.CurrentRow.Cells["Email"].Value.ToString();
                string[] date = dataGridView.CurrentRow.Cells["NgaySinh"].Value.ToString().Split('/');
                string[] Year = date[2].Split('/');
                v.cboNgay.Text = date[0];
                v.cboThang.Text = date[1];
                v.cboNam.Text = Year[0];
                Hienthi_Luoi();
                v.Show();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (dataGridView.CurrentRow.Cells["MaNV"].Value.ToString() == "")
            {
                MessageBox.Show("Không có dữ liệu !", "Thông báo");
                return;
            }
            string mt;
            mt = dataGridView.CurrentRow.Cells["MaNV"].Value.ToString();
            if (MessageBox.Show("Bạn có muốn xóa không ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "DELETE tblNhanVien WHERE MaNV = N'" + mt + "'";
                Class.Functions.RunSql(sql);
                Hienthi_Luoi();
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            Forms.frmTimKiemNhanVien f = new Forms.frmTimKiemNhanVien();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

 
    }
}
