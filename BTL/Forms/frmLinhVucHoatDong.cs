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

namespace BTL.Forms
{
    public partial class frmLinhVucHoatDong : Form
    {

        public frmLinhVucHoatDong()
        {
            InitializeComponent();
        }
        DataTable tblLinhVucHoatDong;
        private void frmLinhVucHoatDong_Load(object sender, EventArgs e)
        {
            Hienthi_Luoi();

            string ConnectionString = @"Data Source=.;Initial Catalog=QuangCao;Integrated Security=True";

            string sql = "select*from tblLVHĐ";
            SqlDataAdapter adp = new SqlDataAdapter(sql, ConnectionString);
            DataTable tabletblLVHD = new DataTable();
            adp.Fill(tabletblLVHD);
            DataGridView.DataSource = tabletblLVHD;
        }

        private void Hienthi_Luoi()
        {
            string sql;
            
            sql = "SELECT * FROM tblLVHĐ";
            tblLinhVucHoatDong = Class.Functions.GetDataToTable(sql);
            DataGridView.DataSource = tblLinhVucHoatDong;
            DataGridView.Columns[0].HeaderText = "Mã lĩnh vực hoạt động";
            DataGridView.Columns[1].HeaderText = "Tên lĩnh vực hoạt động";

            DataGridView.Columns[0].Width = 150;
            DataGridView.Columns[1].Width = 150;

            DataGridView.AllowUserToAddRows = false;
            DataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
            tblLinhVucHoatDong.Dispose();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            XoaDuLieuTrongTextbox();
            txtMaLVHD.Focus();
            txtTenLVHD.Enabled = true;
        }

        private void XoaDuLieuTrongTextbox()
        {
            txtMaLVHD.Text = "";
            txtTenLVHD.Text = "";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtMaLVHD.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã lĩnh vực hoạt động !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaLVHD.Focus();
                return;
            }
            if (txtTenLVHD.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên lĩnh vực hoạt động !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenLVHD.Focus();
                return;
            }
            sql = "INSERT INTO tblLVHĐ(MaLVHĐ, TenLVHĐ) " +
               "VALUES(N'" + txtMaLVHD.Text.Trim() +
                "', N'" + txtTenLVHD.Text.Trim() + "')";

            Class.Functions.RunSqlDel(sql);
            Hienthi_Luoi();
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (DataGridView.CurrentRow.Cells["MaLVHĐ"].Value.ToString() == "")
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo");
                return;
            }
            string mt;
            mt = DataGridView.CurrentRow.Cells["MaLVHĐ"].Value.ToString();
            if (MessageBox.Show("Bạn có muốn xóa không ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "DELETE tblLVHĐ WHERE MaLVHĐ = N'" + mt + "'";
                Class.Functions.RunSqlDel(sql);
                Hienthi_Luoi();
            }
        }

        private void DataGridView_Click(object sender, EventArgs e)
        {
            txtMaLVHD.Text = DataGridView.CurrentRow.Cells["MaLVHĐ"].Value.ToString();
            txtTenLVHD.Text = DataGridView.CurrentRow.Cells["TenLVHĐ"].Value.ToString();

            txtMaLVHD.Enabled = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblLinhVucHoatDong.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK,
MessageBoxIcon.Information);
                return;
            }
            if (txtMaLVHD.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTenLVHD.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên lĩnh vực hoạt động", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenLVHD.Focus();
                return;
            }
            sql = "UPDATE tblLVHĐ SET TenLVHĐ=N'" + txtTenLVHD.Text.ToString() +
"' WHERE MaLVHĐ=N'" + txtMaLVHD.Text + "'";
            Class.Functions.RunSql(sql);
            Load_DataGridView();
            ResetValues();
            
        }
        private void Load_DataGridView()
        {
            string sql;
            sql = "SELECT * FROM tblLVHĐ";
            tblLinhVucHoatDong = Class.Functions.GetDataToTable(sql);
            DataGridView.DataSource = tblLinhVucHoatDong;
            DataGridView.Columns[0].HeaderText = "Mã LVHĐ";
            DataGridView.Columns[1].HeaderText = "Tên LVHĐ";
            DataGridView.Columns[0].Width = 200;
            DataGridView.Columns[1].Width = 500;
            // Không cho phép thêm mới dữ liệu trực tiếp trên lưới
            DataGridView.AllowUserToAddRows = false;
            // Không cho phép sửa dữ liệu trực tiếp trên lưới
            DataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void ResetValues()
        {
            txtMaLVHD.Text = "";
            txtTenLVHD.Text = "";
        }
    }
}
