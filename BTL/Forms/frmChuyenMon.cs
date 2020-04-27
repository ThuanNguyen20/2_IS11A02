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
    public partial class frmChuyenMon : Form
    {
        public frmChuyenMon()
        {
            InitializeComponent();
        }
        DataTable tblCM;
        private void frmChuyenMon_Load(object sender, EventArgs e)
        {
            string ConnectionString = @"Data Source=.;Initial Catalog=QuangCao;Integrated Security=True";

            string sql = "select*from tblChuyenMon";
            SqlDataAdapter adp = new SqlDataAdapter(sql, ConnectionString);
            DataTable tabletblChuyenMon = new DataTable();
            adp.Fill(tabletblChuyenMon);
            DataGridView.DataSource = tabletblChuyenMon;
        }

        private void Load_DataGridView()
        {
            string sql;
            sql = "SELECT MaCM, TenCM FROM tblChuyenMon";
            tblCM = Class.Functions.GetDataToTable(sql);
            DataGridView.DataSource = tblCM;
            DataGridView.Columns[0].HeaderText = "Mã chuyên môn";
            DataGridView.Columns[1].HeaderText = "Tên chuyên môn";
            DataGridView.Columns[0].Width = 200;
            DataGridView.Columns[1].Width = 500;
            // Không cho phép thêm mới dữ liệu trực tiếp trên lưới
            DataGridView.AllowUserToAddRows = false;
            // Không cho phép sửa dữ liệu trực tiếp trên lưới
            DataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnBoQua.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            ResetValues();
            txtMaChuyenMon.Enabled = true;
            txtMaChuyenMon.Focus();
        }

        private void DataGridView_Click(object sender, EventArgs e)
        {
            txtMaChuyenMon.Text = DataGridView.CurrentRow.Cells["MaCM"].Value.ToString();
            txtTenChuyenMon.Text = DataGridView.CurrentRow.Cells["TenCM"].Value.ToString();

            txtMaChuyenMon.Enabled = false;
        }

        private void ResetValues()
        {
            txtMaChuyenMon.Text = "";
            txtTenChuyenMon.Text = "";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtMaChuyenMon.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã chuyên môn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaChuyenMon.Focus();
                return;
            }
            if (txtTenChuyenMon.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên chuyên môn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenChuyenMon.Focus();
                return;
            }
            sql = "SELECT MaCM FROM tblChuyenMon WHERE MaCM=N'" + txtMaChuyenMon.Text.Trim() + "'";
            if (Class.Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã chức năng này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaChuyenMon.Focus();
                txtMaChuyenMon.Text = "";
                return;
            }
            sql = "INSERT INTO tblChuyenMon(MaCM,TenCM) VALUES(N'" + txtMaChuyenMon.Text + "',N'" + txtTenChuyenMon.Text + "')";
            Class.Functions.RunSql(sql);
            Load_DataGridView();
            ResetValues();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnBoQua.Enabled = false;
            btnLuu.Enabled = false;
            txtMaChuyenMon.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblCM.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK,
MessageBoxIcon.Information);
                return;
            }
            if (txtMaChuyenMon.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTenChuyenMon.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên chức năng", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenChuyenMon.Focus();
                return;
            }
            sql = "UPDATE tblChuyenMon SET TenCM=N'" + txtTenChuyenMon.Text.ToString() +
"' WHERE MaCM=N'" + txtMaChuyenMon.Text + "'";
            Class.Functions.RunSql(sql);
            Load_DataGridView();
            ResetValues();
            btnBoQua.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblCM.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK,
MessageBoxIcon.Information);
                return;
            }
            if (txtMaChuyenMon.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo",
MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE tblChuyenMon WHERE MaCM=N'" + txtMaChuyenMon.Text + "'";
                Class.Functions.RunSqlDel(sql);
                Load_DataGridView();
                ResetValues();
            }
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            ResetValues();
            btnBoQua.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            txtMaChuyenMon.Enabled = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtMaChuyenMon_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }
    }
}
