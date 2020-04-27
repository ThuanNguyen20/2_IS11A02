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
    public partial class frmTheLoai : Form
    {
        public frmTheLoai()
        {
            InitializeComponent();
        }
        DataTable tblTL;
        private void frmTheLoai_Load(object sender, EventArgs e)
        {
            string ConnectionString = @"Data Source=.;Initial Catalog=QuangCao;Integrated Security=True";
           
                string sql = "select*from tblTheLoai";
                SqlDataAdapter adp = new SqlDataAdapter(sql,ConnectionString);
                DataTable tabletblTheLoai = new DataTable();
                adp.Fill(tabletblTheLoai);
                DataGridView.DataSource = tabletblTheLoai;

        }
        private void Load_DataGridView()
        {
            string sql;
            sql = "SELECT MaTheLoai, TenTheLoai FROM tblTheLoai";
            tblTL = Class.Functions.GetDataToTable(sql);
            DataGridView.DataSource = tblTL;
            DataGridView.Columns[0].HeaderText = "Mã thể loại";
            DataGridView.Columns[1].HeaderText = "Tên thể loại";
            DataGridView.Columns[0].Width = 200;
            DataGridView.Columns[1].Width = 500;
            // Không cho phép thêm mới dữ liệu trực tiếp trên lưới
            DataGridView.AllowUserToAddRows = false;
            // Không cho phép sửa dữ liệu trực tiếp trên lưới
            DataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void DataGridView_Click(object sender, EventArgs e)
        {
  //          if (btnThem.Enabled == false)
  //          {
  //              MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo",
  //      MessageBoxButtons.OK, MessageBoxIcon.Information);
  //              txtMaTheLoai.Focus();
  //              return;
  //          }
  //          if (tblTL.Rows.Count == 0)
  //          {
  //              MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK,
  //MessageBoxIcon.Information);
  //              return;
  //          }
  //          txtMaTheLoai.Text = DataGridView.CurrentRow.Cells["MaTheLoai"].Value.ToString();
  //          txtTenTheLoai.Text = DataGridView.CurrentRow.Cells["TenTheLoai"].Value.ToString();
  //          btnSua.Enabled = true;
  //          btnXoa.Enabled = true;
  //          btnBoQua.Enabled = true;
            txtMaTheLoai.Text = DataGridView.CurrentRow.Cells["MaTheLoai"].Value.ToString();
            txtTenTheLoai.Text = DataGridView.CurrentRow.Cells["TenTheLoai"].Value.ToString();
           
            txtMaTheLoai.Enabled = false;

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnBoQua.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            ResetValues();
            txtMaTheLoai.Enabled = true;
            txtMaTheLoai.Focus();

        }
        private void ResetValues()
        {
            txtMaTheLoai.Text = "";
            txtTenTheLoai.Text = "";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtMaTheLoai.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã thể loại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaTheLoai.Focus();
                return;
            }
            if (txtTenTheLoai.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên thể loại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenTheLoai.Focus();
                return ;
            }
            sql = "SELECT MaTheLoai FROM tblTheLoai WHERE MaTheLoai=N'" + txtMaTheLoai.Text.Trim()  + "'";
            if (Class.Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã thể loại này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaTheLoai.Focus();
                txtMaTheLoai.Text = "";
                return;
            }
            sql = "INSERT INTO tblTheLoai(MaTheLoai,TenTheLoai) VALUES(N'" + txtMaTheLoai.Text + "',N'" + txtTenTheLoai.Text + "')";
            Class.Functions.RunSql(sql);
            Load_DataGridView();
            ResetValues();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnBoQua.Enabled = false;
            btnLuu.Enabled = false;
            txtMaTheLoai.Enabled = false;

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblTL.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK,
MessageBoxIcon.Information);
                return;
            }
            if (txtMaTheLoai.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTenTheLoai.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên thể loại", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenTheLoai.Focus();
                return;
            }
            sql = "UPDATE tblTheLoai SET TenTheLoai=N'" + txtTenTheLoai.Text.ToString() +
"' WHERE MaTheLoai=N'" + txtMaTheLoai.Text + "'";
            Class.Functions.RunSql(sql);
            Load_DataGridView();
            ResetValues();
            btnBoQua.Enabled = false;

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblTL.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK,
MessageBoxIcon.Information);
                return;
            }
            if (txtMaTheLoai.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo",
MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE tblTheLoai WHERE MaTheLoai=N'" + txtMaTheLoai.Text + "'";
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
            txtMaTheLoai.Enabled = false;

        }

        private void txtMaTheLoai_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    }
}
