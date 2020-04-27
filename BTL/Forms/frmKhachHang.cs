using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BTL.Class;

namespace BTL.Forms
{
    public partial class frmKhachHang : Form
    {
        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            Hienthi_Luoi();
        }

        private void Hienthi_Luoi()
        {
            string sql;
            DataTable tblKhachHang;
            sql = "SELECT MaKH, TenKH, DiaChi , DienThoai, DiDong, Email, MaLVHĐ FROM tblKhachHang";
            tblKhachHang = Class.Functions.GetDataToTable(sql);
            dataGridView.DataSource = tblKhachHang;
            dataGridView.Columns[0].HeaderText = "Mã Khách hàng";
            dataGridView.Columns[1].HeaderText = "Tên khách hàng";
            dataGridView.Columns[2].HeaderText = "Địa chỉ";
            dataGridView.Columns[3].HeaderText = "Điện thoại";
            dataGridView.Columns[4].HeaderText = "Di Động";
            dataGridView.Columns[5].HeaderText = "Email";
            dataGridView.Columns[6].HeaderText = "Mã LVHĐ";
            dataGridView.Columns[0].Width = 100;
            dataGridView.Columns[1].Width = 200;
            dataGridView.Columns[2].Width = 150;
            dataGridView.Columns[3].Width = 100;
            dataGridView.Columns[4].Width = 150;
            dataGridView.Columns[5].Width = 150;
            dataGridView.Columns[6].Width = 150;
            dataGridView.AllowUserToAddRows = false;
            dataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
            tblKhachHang.Dispose();
        }

        private void frmKhachHang_Activated(object sender, EventArgs e)
        {
            Hienthi_Luoi();
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            Forms.frmAddKhachHang v = new Forms.frmAddKhachHang();
            v.StartPosition = FormStartPosition.CenterScreen;
            v.Show();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string ma;
            if (dataGridView.CurrentRow.Cells["MaKH"].Value.ToString() == "")
            {
                MessageBox.Show("Không có dữ liệu", "Thông báo");
                return;
            }
            Forms.frmUpdateKhachHang f = new Forms.frmUpdateKhachHang();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.txtMaKH.Text = dataGridView.CurrentRow.Cells["MaKH"].Value.ToString();
            f.txtTenKH.Text = dataGridView.CurrentRow.Cells["TenKH"].Value.ToString();
            f.txtDiaChi.Text = dataGridView.CurrentRow.Cells["DiaChi"].Value.ToString();
            f.txtDienThoai.Text = dataGridView.CurrentRow.Cells["DienThoai"].Value.ToString();
            f.txtDiDong.Text = dataGridView.CurrentRow.Cells["DiDong"].Value.ToString();
            f.txtEmail.Text = dataGridView.CurrentRow.Cells["Email"].Value.ToString();
            ma = dataGridView.CurrentRow.Cells["MaLVHĐ"].Value.ToString();
            //f.cboLVHD.Text = Class.Functions.GetFieldValues("SELECT TenLVHĐ FROM tblLVHĐ WHERE MaLVHĐ = N'" + ma + "'");
            f.Show();
            Hienthi_Luoi();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (dataGridView.CurrentRow.Cells["MaKH"].Value.ToString() == "")
            {
                MessageBox.Show("Không có dữ liệu !", "Thông báo");
                return;
            }
            string mt;
            mt = dataGridView.CurrentRow.Cells["MaKH"].Value.ToString();
            if (MessageBox.Show("Bạn có muốn xóa không ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes)
            {
                sql = "DELETE tblKhachHang WHERE MaKH = N'" + mt + "'";
                Class.Functions.RunSql(sql);
                Hienthi_Luoi();
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            Forms.frmTimKiemKhachHang f = new Forms.frmTimKiemKhachHang();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
