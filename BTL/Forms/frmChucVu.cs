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
    public partial class frmChucVu : Form
    {
        public frmChucVu()
        {
            InitializeComponent();
        }
        DataTable tblCV;
        private void frmChucVu_Load(object sender, EventArgs e)
        {
            string ConnectionString = @"Data Source=.;Initial Catalog=QuangCao;Integrated Security=True";

            string sql = "select*from tblChucVu";
            SqlDataAdapter adp = new SqlDataAdapter(sql, ConnectionString);
            DataTable tabletblChucVu = new DataTable();
            adp.Fill(tabletblChucVu);
            DataGridView.DataSource = tabletblChucVu;
        }

        private void Load_DataGridView()
        {
            string sql;
            sql = "SELECT * FROM tblChucVu";
            tblCV = Class.Functions.GetDataToTable(sql);
            DataGridView.DataSource = tblCV;
            DataGridView.Columns[0].HeaderText = "Mã chức vụ";
            DataGridView.Columns[1].HeaderText = "Tên chức vụ";
            DataGridView.Columns[0].Width = 200;
            DataGridView.Columns[1].Width = 200;
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
            txtMaChucVu.Enabled = true;
            //txtTenChucVu.Focus();
            //matudong();
            btnThem.Enabled = false;
        }

        private void matudong()
        {
            string g;
            if (tblCV.Rows.Count == 0)
            {
                g = "CV01";
            }
            else
            {
                int k;
                g = "CV";
                k = Convert.ToInt32(tblCV.Rows[tblCV.Rows.Count - 1][0].ToString().Substring(2, 2));
                k = k + 1;
                if (k <= 10)
                {
                    g = g + "0";
                }
                g = g + k.ToString();
            }
            txtMaChucVu.Text = g;
        }


        private void DataGridView_Click(object sender, EventArgs e)
        {
            txtMaChucVu.Text = DataGridView.CurrentRow.Cells["MaChucVu"].Value.ToString();
            txtTenChucVu.Text = DataGridView.CurrentRow.Cells["TenChucVu"].Value.ToString();

            txtMaChucVu.Enabled = false;
        }

        private void ResetValues()
        {
            txtMaChucVu.Text = "";
            txtTenChucVu.Text = "";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblCV.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK,
MessageBoxIcon.Information);
                return;
            }
            if (txtMaChucVu.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTenChucVu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên chức năng", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenChucVu.Focus();
                return;
            }
            sql = "UPDATE tblChucVu SET TenChucVu=N'" + txtTenChucVu.Text.ToString() +
"' WHERE MaChucVu=N'" + txtMaChucVu.Text + "'";
            Class.Functions.RunSql(sql);
            Load_DataGridView();
            ResetValues();
            btnBoQua.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblCV.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK,
MessageBoxIcon.Information);
                return;
            }
            if (txtMaChucVu.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo",
MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE tblChucVu WHERE MaChucVu=N'" + txtMaChucVu.Text + "'";
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
            txtMaChucVu.Enabled = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtMaChucVu_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtMaChucVu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã chức vụ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaChucVu.Focus();
                return;
            }
            if (txtTenChucVu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên chức vụ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenChucVu.Focus();
                return;
            }
            sql = "SELECT MaChucVu FROM tblChucVu WHERE MaChucVu=N'" + txtMaChucVu.Text.Trim() + "'";
            if (Class.Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã chức năng này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaChucVu.Focus();
                txtMaChucVu.Text = "";
                return;
            }
            sql = "INSERT INTO tblChucVu(MaChucVu,TenChucVu) VALUES(N'" + txtMaChucVu.Text + "',N'" + txtTenChucVu.Text + "')";
            Class.Functions.RunSql(sql);
            Load_DataGridView();
            ResetValues();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnBoQua.Enabled = false;
            btnLuu.Enabled = false;
            txtMaChucVu.Enabled = false;
        }
    }
}
