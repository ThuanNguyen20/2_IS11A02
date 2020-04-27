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
    public partial class frmQCao : Form
    {
        public frmQCao()
        {
            InitializeComponent();
        }
        DataTable tblQC;
        private void frmQCao_Load(object sender, EventArgs e)
        {
            string ConnectionString = @"Data Source=.;Initial Catalog=QuangCao;Integrated Security=True";

            string sql = "select*from tblTTQuangCao";
            SqlDataAdapter adp = new SqlDataAdapter(sql, ConnectionString);
            DataTable tabletblTTQuangCao = new DataTable();
            adp.Fill(tabletblTTQuangCao);
            DataGridView.DataSource = tabletblTTQuangCao;
        }
        private void Load_DataGridView()
        {
            string sql;
            sql = "SELECT MaQCao, TenQCao FROM tblTTQuangCao";
            tblQC = Class.Functions.GetDataToTable(sql);
            DataGridView.DataSource = tblQC;
            DataGridView.Columns[0].HeaderText = "Mã quảng cáo";
            DataGridView.Columns[1].HeaderText = "Tên quảng cáo";
            DataGridView.Columns[0].Width = 200;
            DataGridView.Columns[1].Width = 500;
            // Không cho phép thêm mới dữ liệu trực tiếp trên lưới
            DataGridView.AllowUserToAddRows = false;
            // Không cho phép sửa dữ liệu trực tiếp trên lưới
            DataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void DataGridView_Click(object sender, EventArgs e)
        {
            txtMaQCao.Text = DataGridView.CurrentRow.Cells["MaQCao"].Value.ToString();
            txtTenQCao.Text = DataGridView.CurrentRow.Cells["TenQCao"].Value.ToString();

            txtMaQCao.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnBoQua.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            ResetValues();
            txtMaQCao.Enabled = true;
            txtMaQCao.Focus();
        }
        private void ResetValues()
        {
            txtMaQCao.Text = "";
            txtTenQCao.Text = "";
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblQC.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK,
MessageBoxIcon.Information);
                return;
            }
            if (txtMaQCao.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTenQCao.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên quảng cáo", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenQCao.Focus();
                return;
            }
            sql = "UPDATE tblTTQuangCao SET TenQCao=N'" + txtTenQCao.Text.ToString() +
"' WHERE MaQCao=N'" + txtMaQCao.Text + "'";
            Class.Functions.RunSql(sql);
            Load_DataGridView();
            ResetValues();
            btnBoQua.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtMaQCao.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã quảng cáo", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaQCao.Focus();
                return;
            }
            if (txtTenQCao.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên quảng cáo", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenQCao.Focus();
                return;
            }
            sql = "SELECT MaQCao FROM tblTTQuangCao WHERE MaQCao=N'" + txtMaQCao.Text.Trim() + "'";
            if (Class.Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã quảng cáo này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaQCao.Focus();
                txtMaQCao.Text = "";
                return;
            }
            sql = "INSERT INTO tblTTQuangCao(MaQCao,TenQCao) VALUES(N'" + txtMaQCao.Text + "',N'" + txtTenQCao.Text + "')";
            Class.Functions.RunSql(sql);
            Load_DataGridView();
            ResetValues();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnBoQua.Enabled = false;
            btnLuu.Enabled = false;
            txtMaQCao.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblQC.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK,
MessageBoxIcon.Information);
                return;
            }
            if (txtMaQCao.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo",
MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE tblTTQuangCao WHERE MaQCao=N'" + txtMaQCao.Text + "'";
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
            txtMaQCao.Enabled = false;
        }

        private void txtMaQCao_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
