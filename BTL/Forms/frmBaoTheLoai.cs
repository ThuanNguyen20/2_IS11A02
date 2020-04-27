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
    public partial class frmBaoTheLoai : Form
    {
        public frmBaoTheLoai()
        {
            InitializeComponent();
        }
        DataTable tblBTL;
        private void frmBaoTheLoai_Load(object sender, EventArgs e)
        {
            //cboMaBao.Enabled = false;
            btnLuu.Enabled = false;
            btnBoQua.Enabled = false;
            Load_DataGridView();
            Functions.FillCombo("SELECT MaTheLoai, TenTheLoai FROM tblTheLoai", cboMaTheLoai, "MaTheLoai", "TenTheLoai");
            cboMaTheLoai.SelectedIndex = -1;
            Functions.FillCombo("SELECT MaBao, TenBao FROM tblBao", cboMaBao, "MaBao", "TenBao");
            cboMaBao.SelectedIndex = -1;
            ResetValues();
        }
        private void Load_DataGridView()
        {
            string sql;
            sql = "SELECT*FROM tblBaoTheLoai";
            tblBTL = Functions.GetDataToTable(sql);
            DataGridView.DataSource = tblBTL;
            DataGridView.Columns[0].HeaderText = "Mã báo";
            DataGridView.Columns[1].HeaderText = "Mã Thể Loại";
            DataGridView.Columns[2].HeaderText = "Nhuận Bút";
           
            DataGridView.Columns[0].Width = 80;
            DataGridView.Columns[1].Width = 140;
            DataGridView.Columns[2].Width = 80;
            
            DataGridView.AllowUserToAddRows = false;
            DataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;

        }
        private void ResetValues()
        {
            cboMaBao.Text = "";
           
            cboMaTheLoai.Text = "";
           
            txtNhuanBut.Text = "0";
            
        }

        private void DataGridView_Click(object sender, EventArgs e)
        {
            string ma;
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboMaTheLoai.Focus();
                return;
            }
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboMaBao.Focus();
                return;
            }
            
            if (tblBTL.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK,
MessageBoxIcon.Information);
                return;
            }
            ma = DataGridView.CurrentRow.Cells["MaBao"].Value.ToString();
            cboMaBao.Text = Functions.GetFieldValues("SELECT TenBao FROM tblBao WHERE MaBao = N'" + ma + "'");
            ma = DataGridView.CurrentRow.Cells["MaTheLoai"].Value.ToString();
            cboMaTheLoai.Text = Functions.GetFieldValues("SELECT TenTheLoai FROM tblTheLoai WHERE MaTheLoai = N'" + ma + "'");
            txtNhuanBut.Text = DataGridView.CurrentRow.Cells["NhuanBut"].Value.ToString();
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
            cboMaBao.Enabled = true;
            cboMaBao.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if (cboMaBao.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã báo", "Thông báo", MessageBoxButtons.OK,
MessageBoxIcon.Warning);
                cboMaBao.Focus();
                return;
            }
            
            if (cboMaTheLoai.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập thể loại", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboMaTheLoai.Focus();
                return;
            }
            if (txtNhuanBut.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập nhuận bút", "Thông báo", MessageBoxButtons.OK,
 MessageBoxIcon.Warning);
                txtNhuanBut.Focus();
                return;
            }
            
            sql = "SELECT MaBao FROM tblBaoTheLoai WHERE MaBao=N'" + cboMaBao.Text.Trim() + "'";
            if (Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã báo này đã có, bạn phải nhập mã khác", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboMaBao.Focus();
                cboMaBao.Text = "";
                return;
            }
            sql = "INSERT INTO tblBaoTheLoai(MaBao,MaTheLoai,NhuanBut)  VALUES(N'" + cboMaBao.SelectedValue.ToString() + "',N'" + cboMaTheLoai.SelectedValue.ToString() + "',N'" + txtNhuanBut.Text + "')";
            Functions.RunSql(sql);
            Load_DataGridView();
            ResetValues();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnBoQua.Enabled = false;
            btnLuu.Enabled = false;
            cboMaBao.Enabled = false;  
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblBTL.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK,
MessageBoxIcon.Information);
                return;
            }
            if (cboMaBao.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (cboMaTheLoai.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtNhuanBut.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập nhuận bút", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNhuanBut.Focus();
                return;
            }

            sql = "UPDATE tblBaoTheLoai SET NhuanBut = N'" + txtNhuanBut.Text.ToString() + "' WHERE MaBao = N'" + cboMaBao.SelectedValue.ToString() + "' AND MaTheLoai=N'" + cboMaTheLoai.SelectedValue.ToString() + "'";
            Functions.RunSql(sql);
            Load_DataGridView();
            ResetValues();
            btnBoQua.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblBTL.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK,
MessageBoxIcon.Information);
                return;
            }
            if (cboMaBao.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo",
MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE tblBaoTheLoai WHERE MaBao=N'" + cboMaBao.Text + "'";
                Functions.RunSqlDel(sql);
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
            cboMaBao.Enabled = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNhuanBut_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

    }
}