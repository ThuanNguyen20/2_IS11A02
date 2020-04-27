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
    public partial class frmKhachGuiBai : Form
    {
        public frmKhachGuiBai()
        {
            InitializeComponent();
        }
        DataTable tblKGB;
        private void frmKhachGuiBai_Load(object sender, EventArgs e)
        {
            txtMaLanGui.Enabled = false;
            txtNhuanBut.ReadOnly = true;
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
            sql = "SELECT*FROM tblKhachGuiBai";
            tblKGB = Functions.GetDataToTable(sql);
            DataGridView.DataSource = tblKGB;
            DataGridView.Columns[0].HeaderText = "Mã lần gửi";
            DataGridView.Columns[1].HeaderText = "Mã khách hàng";
            DataGridView.Columns[2].HeaderText = "Mã Báo";
            DataGridView.Columns[3].HeaderText = "Mã Thể Loại";
            DataGridView.Columns[4].HeaderText = "Tiêu Đề";
            DataGridView.Columns[5].HeaderText = "Nội Dung";
            DataGridView.Columns[6].HeaderText = "Mã Nhân Viên";
            DataGridView.Columns[7].HeaderText = "Ngày Đăng";
            DataGridView.Columns[8].HeaderText = "Nhuận Bút";
            DataGridView.Columns[0].Width = 80;
            DataGridView.Columns[1].Width = 80;
            DataGridView.Columns[2].Width = 80;
            DataGridView.Columns[3].Width = 80;
            DataGridView.Columns[4].Width = 80;
            DataGridView.Columns[5].Width = 80;
            DataGridView.Columns[6].Width = 80;
            DataGridView.Columns[7].Width = 80;
            DataGridView.Columns[8].Width = 80;
            DataGridView.AllowUserToAddRows = false;
            DataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;

        }
        private void ResetValues()
        {
            txtMaLanGui.Text = "";
            txtMaKhachHang.Text = "";
            cboMaTheLoai.Text = "";
            cboMaBao.Text = "";
            txtTieuDe.Text = "";
            txtNoiDung.Text = "";
            txtMaNhanVien.Text = "";
            mskNgayDang.Text = "";
            txtNhuanBut.Text = "0";

        }

        private void DataGridView_Click(object sender, EventArgs e)
        {
            string ma;
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaLanGui.Focus();
                return;
            }
            if (tblKGB.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK,
MessageBoxIcon.Information);
                return;
            }
            txtMaLanGui.Text = DataGridView.CurrentRow.Cells["MaLanGui"].Value.ToString();
            txtMaKhachHang.Text = DataGridView.CurrentRow.Cells["MaKH"].Value.ToString();
            ma = DataGridView.CurrentRow.Cells["MaTheLoai"].Value.ToString();
            cboMaTheLoai.Text = Functions.GetFieldValues("SELECT TenTheLoai FROM tblTheLoai WHERE MaTheLoai = N'" + ma + "'");
            ma = DataGridView.CurrentRow.Cells["MaBao"].Value.ToString();
            cboMaBao.Text = Functions.GetFieldValues("SELECT TenBao FROM tblBao WHERE MaBao = N'" + ma + "'");
            txtTieuDe.Text = DataGridView.CurrentRow.Cells["TieuDe"].Value.ToString();
            txtNoiDung.Text = DataGridView.CurrentRow.Cells["NoiDung"].Value.ToString();
            txtMaNhanVien.Text = DataGridView.CurrentRow.Cells["MaNV"].Value.ToString();
            mskNgayDang.Text = DataGridView.CurrentRow.Cells["NgayDang"].Value.ToString();
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
            txtMaLanGui.Enabled = true;
            txtMaLanGui.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtMaLanGui.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã lần gửi", "Thông báo", MessageBoxButtons.OK,
MessageBoxIcon.Warning);
                txtMaLanGui.Focus();
                return;
            }
            if (txtMaKhachHang.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên khách", "Thông báo", MessageBoxButtons.OK,
 MessageBoxIcon.Warning);
                txtMaKhachHang.Focus();
                return;
            }
            if (txtMaNhanVien.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập nhân viên", "Thông báo", MessageBoxButtons.OK,
 MessageBoxIcon.Warning);
                txtMaNhanVien.Focus();
                return;
            }
            if (cboMaBao.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã báo", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            if (txtTieuDe.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tiêu đề", "Thông báo", MessageBoxButtons.OK,
 MessageBoxIcon.Warning);
                txtNoiDung.Focus();
                return;
            }
            if (mskNgayDang.Text == "  /  /")
            {
                MessageBox.Show("Bạn phải nhập ngày đăng", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskNgayDang.Focus();
                return;
            }
            if (!Functions.IsDate(mskNgayDang.Text))
            {
                MessageBox.Show("Bạn phải nhập lại ngày đăng", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskNgayDang.Text = "";
                mskNgayDang.Focus();
                return;
            }


            sql = "SELECT MaLanGui FROM tblKhachGuiBai  WHERE MaLanGui = N'" + txtMaLanGui.Text.Trim() + "' ";
            if (Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã báo này đã có, bạn phải nhập mã khác", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaLanGui.Focus();
                txtMaLanGui.Text = "";
                return;
            }

            sql = "INSERT INTO tblKhachGuiBai(MaLanGui,MaKH,MaTheLoai,MaBao,TieuDe,NoiDung,MaNV,NgayDang,NhuanBut) VALUES(N'" +
                txtMaLanGui.Text.Trim() + "',N'" + txtMaKhachHang.Text.Trim() + "',N'" +
                cboMaTheLoai.SelectedValue.ToString() + "',N'" + cboMaBao.SelectedValue.ToString() + "',N'" +
                txtTieuDe.Text + "',N'" + txtNoiDung.Text.Trim() + "',N'" + txtMaNhanVien.Text + "','" +
                Functions.ConvertDateTime(mskNgayDang.Text.Trim()) + "',N'" + txtNhuanBut.Text.Trim() + "')";
            Functions.RunSql(sql);
            Load_DataGridView();
            ResetValues();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnBoQua.Enabled = false;
            btnLuu.Enabled = false;
            txtMaLanGui.Enabled = false;  
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblKGB.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK,
MessageBoxIcon.Information);
                return;
            }
            if (txtMaLanGui.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã lần gửi", "Thông báo", MessageBoxButtons.OK,
MessageBoxIcon.Warning);
                txtMaLanGui.Focus();
                return;
            }
            if (txtMaKhachHang.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên khách", "Thông báo", MessageBoxButtons.OK,
 MessageBoxIcon.Warning);
                txtMaKhachHang.Focus();
                return;
            }
            if (txtMaNhanVien.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập nhân viên", "Thông báo", MessageBoxButtons.OK,
 MessageBoxIcon.Warning);
                txtMaNhanVien.Focus();
                return;
            }
            if (cboMaBao.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã báo", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            if (txtTieuDe.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tiêu đề", "Thông báo", MessageBoxButtons.OK,
 MessageBoxIcon.Warning);
                txtNoiDung.Focus();
                return;
            }
            if (mskNgayDang.Text == "  /  /")
            {
                MessageBox.Show("Bạn phải nhập ngày đăng", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskNgayDang.Focus();
                return;
            }
            if (!Functions.IsDate(mskNgayDang.Text))
            {
                MessageBox.Show("Bạn phải nhập lại ngày đăng", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskNgayDang.Text = "";
                mskNgayDang.Focus();
                return;
            }
            sql = "UPDATE tblKhachGuiBai SET MaKH=N'" + txtMaKhachHang.Text.Trim() + "',MaTheLoai=N'" +
                cboMaTheLoai.SelectedValue.ToString() + "',MaBao=N'" + cboMaBao.SelectedValue.ToString() + "',TieuDe=N'" +
                txtTieuDe.Text + "',NoiDung=N'" + txtNoiDung.Text.Trim() + "',MaNV=N'" + txtMaNhanVien.Text + "',NgayDang='" +
                Functions.ConvertDateTime(mskNgayDang.Text) + "',NhuanBut=N'" +
                txtNhuanBut.Text.Trim() + "'WHERE MaLanGui=N'" + txtMaLanGui.Text + "'";


            Functions.RunSql(sql);
            Load_DataGridView();
            ResetValues();
            btnBoQua.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblKGB.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK,
MessageBoxIcon.Information);
                return;
            }
            if (txtMaLanGui.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo",
MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE tblKhachGuiBai WHERE MaLanGui=N'" + txtMaLanGui.Text + "'";
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
            txtMaLanGui.Enabled = false;

        }

        private void cboMaBao_TextChanged(object sender, EventArgs e)
        {
            string str;
            if (cboMaBao.Text == "")
            {
                cboMaTheLoai.Text = "";
                txtNhuanBut.Text = "";
            }
            str = "Select MaTheLoai from tblBaoTheLoai where MaBao = N'" + cboMaBao.SelectedValue + "'";
            cboMaTheLoai.Text = Functions.GetFieldValues(str);
            str = "Select NhuanBut from tblBaoTheLoai where MaBao = N'" + cboMaBao.SelectedValue + "'";
            txtNhuanBut.Text = Functions.GetFieldValues(str);
        }

        private void cboMaTheLoai_TextChanged(object sender, EventArgs e)
        {
            string str;
            if (cboMaTheLoai.Text == "")
            {
                
                txtNhuanBut.Text = "";
            }
            str = "Select NhuanBut from tblBaoTheLoai where MaTheLoai= N'" + cboMaTheLoai.SelectedValue + "'";
            txtNhuanBut.Text = Functions.GetFieldValues(str);
        }


    }
}
