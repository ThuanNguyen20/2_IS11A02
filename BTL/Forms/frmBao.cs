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
    public partial class frmBao : Form
    {
        public frmBao()
        {
            InitializeComponent();
        }
        DataTable tblB;
        private void frmBao_Load(object sender, EventArgs e)
        {
            txtMaBao.Enabled = false;
            btnLuu.Enabled = false;
            btnBoQua.Enabled = false;
            Load_DataGridView();
            Functions.FillCombo("SELECT MaChucNang, TenChucNang FROM tblChucNang",cboMaChucNang, "MaChucNang", "TenChucNang");
            cboMaChucNang.SelectedIndex = -1;
            ResetValues();

        }
        private void Load_DataGridView()
        {
                        string sql;
            sql = "SELECT*FROM tblBao";
            tblB = Functions.GetDataToTable(sql);
            DataGridView.DataSource = tblB;
            DataGridView.Columns[0].HeaderText = "Mã báo";
            DataGridView.Columns[1].HeaderText = "Tên báo";
            DataGridView.Columns[2].HeaderText = "Chức Năng";
            DataGridView.Columns[3].HeaderText = "Địa Chỉ";
            DataGridView.Columns[4].HeaderText = "Điện Thoại";
            DataGridView.Columns[5].HeaderText = "Email";
            DataGridView.Columns[0].Width = 80;
            DataGridView.Columns[1].Width = 140;
            DataGridView.Columns[2].Width = 80;
            DataGridView.Columns[3].Width = 80;
            DataGridView.Columns[4].Width = 100;
            DataGridView.Columns[5].Width = 100;
            DataGridView.AllowUserToAddRows = false;
            DataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;

        }
        private void ResetValues()
        {
            txtMaBao.Text = "";
            txtTenBao.Text = "";
            cboMaChucNang.Text = "";
            txtDiaChi.Text = "";
            txtDienThoai.Text = "0";
            txtEmail.Text = "";
            
            
        }

        private void DataGridView_Click(object sender, EventArgs e)
        {
            string ma;
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", 
MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaBao.Focus();
                return;
            }
            if (tblB.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, 
MessageBoxIcon.Information);
                return;
            }
            txtMaBao.Text = DataGridView.CurrentRow.Cells["MaBao"].Value.ToString();
            txtTenBao.Text = DataGridView.CurrentRow.Cells["TenBao"].Value.ToString();
            ma = DataGridView.CurrentRow.Cells["MaChucNang"].Value.ToString();
            cboMaChucNang.Text = Functions.GetFieldValues("SELECT TenChucNang FROM tblChucNang WHERE MaChucNang = N'" + ma + "'");
            txtDiaChi.Text = DataGridView.CurrentRow.Cells["DiaChi"].Value.ToString();
          txtDienThoai.Text = DataGridView.CurrentRow.Cells["DienThoai"].Value.ToString();
            txtEmail.Text = DataGridView.CurrentRow.Cells["Email"].Value.ToString();
            
            btnSua.Enabled = true;
            btnXoa.Enabled = true;	
            btnBoQua.Enabled = true;

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnBoQua.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            ResetValues();
            txtMaBao.Enabled = true;
            txtMaBao.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtMaBao.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã báo", "Thông báo", MessageBoxButtons.OK, 
MessageBoxIcon.Warning);
                txtMaBao.Focus();
                return;
            }
            if (txtTenBao.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên báo", "Thông báo", MessageBoxButtons.OK,
 MessageBoxIcon.Warning);
                txtTenBao.Focus();
                return;
            }
            if (cboMaChucNang.Text.Trim().Length == 0 )
            {
                MessageBox.Show("Bạn phải nhập chức năng", "Thông báo", 
MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboMaChucNang.Focus();
                return;
            }
            if (txtDiaChi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK,
 MessageBoxIcon.Warning);
                txtDiaChi.Focus();
                return;
            }
            if (txtDienThoai.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập điện thoại", "Thông báo", MessageBoxButtons.OK,
 MessageBoxIcon.Warning);
                txtDienThoai.Focus();
                return;
            }
            if (txtEmail.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên báo", "Thông báo", MessageBoxButtons.OK,
 MessageBoxIcon.Warning);
                txtEmail.Focus();
                return;
            }
           sql = "SELECT MaBao FROM tblBao WHERE MaBao=N'" + txtMaBao.Text.Trim() + "'";
            if (Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã báo này đã có, bạn phải nhập mã khác", "Thông báo", 
MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaBao.Focus();
                txtMaBao.Text = "";
                return;
            }
            sql = "INSERT INTO tblBao(MaBao,TenBao,MaChucNang,DiaChi,DienThoai,Email) VALUES(N'" + txtMaBao.Text.Trim() + "',N'" + txtTenBao.Text.Trim() + "',N'" + cboMaChucNang.SelectedValue.ToString() + "',N'" + txtDiaChi.Text + "',N'" + txtDienThoai.Text.Trim() + "',N'" + txtEmail.Text.Trim() + "')";
            Functions.RunSql(sql);
            Load_DataGridView();
            ResetValues();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnBoQua.Enabled = false;
            btnLuu.Enabled = false;
            txtMaBao.Enabled = false;  
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblB.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK,
MessageBoxIcon.Information);
                return;
            }
            if (txtMaBao.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTenBao.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên báo", "Thông báo", MessageBoxButtons.OK,
MessageBoxIcon.Warning);
                txtTenBao.Focus();
                return;
            }
            if (cboMaChucNang.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập chất liệu", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboMaChucNang.Focus();
                return;
            }

            sql = "UPDATE tblBao SET TenBao=N'" + txtTenBao.Text.Trim().ToString() +
                "',MaChucNang=N'" + cboMaChucNang.SelectedValue.ToString() +"',DiaChi=N'" + txtDiaChi.Text + "',DienThoai=N'" + txtDienThoai.Text+"',Email=N'" + txtEmail.Text + "' WHERE MaBao=N'" + txtMaBao.Text + "'";
            Functions.RunSql(sql);
            Load_DataGridView();
            ResetValues();
            btnBoQua.Enabled = false;

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblB.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK,
MessageBoxIcon.Information);
                return;
            }
            if (txtMaBao.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo",
MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE tblBao WHERE MaBao=N'" + txtMaBao.Text + "'";
                Functions.RunSqlDel(sql);
                Load_DataGridView();
                ResetValues();
            }

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            ResetValues();
            btnBoQua.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            txtMaBao.Enabled = false;

        }

        private void txtDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

    }
}
