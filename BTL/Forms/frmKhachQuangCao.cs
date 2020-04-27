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
    public partial class frmKhachQuangCao : Form
    {
        public frmKhachQuangCao()
        {
            InitializeComponent();
        }
        DataTable tblKQC;
        private void frmKhachQuangCao_Load(object sender, EventArgs e)
        {
            txtMaLanQCao.Enabled = false;

            btnLuu.Enabled = false;
            btnBoQua.Enabled = false;
            Load_DataGridView();
            
            Functions.FillCombo("SELECT MaBao, TenBao FROM tblBao", cboMaBao, "MaBao", "TenBao");
            cboMaBao.SelectedIndex = -1;
            Functions.FillCombo("SELECT MaNV, TenNV FROM tblNhanVien", cboMaNV, "MaNV", "TenNV");
            cboMaNV.SelectedIndex = -1;
            Functions.FillCombo("SELECT MaKH, TenKH FROM tblKhachHang", cboMaKH, "MaKH", "TenKH");
            cboMaKH.SelectedIndex = -1;
            Functions.FillCombo("SELECT MaQCao, TenQCao FROM tblTTQuangCao", cboMaQCao, "MaQCao", "TenQCao");
            cboMaQCao.SelectedIndex = -1;
            ResetValues();
        }
        private void Load_DataGridView()
        {
            string sql;
            sql = "SELECT*FROM tblKhachQuangCao";
            tblKQC = Functions.GetDataToTable(sql);
            DataGridView.DataSource = tblKQC;
            DataGridView.Columns[0].HeaderText = "Mã lần QC";
            DataGridView.Columns[1].HeaderText = "Mã khách hàng";
            DataGridView.Columns[2].HeaderText = "Tên KH";
            DataGridView.Columns[3].HeaderText = "Mã Báo";
            DataGridView.Columns[4].HeaderText = "Mã NV";
            DataGridView.Columns[5].HeaderText = "Mã QCao";
            DataGridView.Columns[6].HeaderText = "Nội Dung";
            DataGridView.Columns[7].HeaderText = "Ngày BĐ";
            DataGridView.Columns[8].HeaderText = "Ngày KT";
            DataGridView.Columns[9].HeaderText = "Tổng Tiền";
            DataGridView.Columns[0].Width = 80;
            DataGridView.Columns[1].Width = 80;
            DataGridView.Columns[2].Width = 80;
            DataGridView.Columns[3].Width = 80;
            DataGridView.Columns[4].Width = 80;
            DataGridView.Columns[5].Width = 80;
            DataGridView.Columns[6].Width = 80;
            DataGridView.Columns[7].Width = 80;
            DataGridView.Columns[8].Width = 80;
            DataGridView.Columns[9].Width = 80;
            DataGridView.AllowUserToAddRows = false;
            DataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;

        }
        private void ResetValues()
        {
            txtMaLanQCao.Text = "";
            cboMaKH.Text = "";
            txtTenKH.Text = "";
            cboMaBao.Text = "";
            cboMaNV.Text = "";
            cboMaQCao.Text = "";
            txtNoiDung.Text = "";
            mskNgayBD.Text = "";
            mskNgayKT.Text = "";
            txtTongTien.Text = "0";

        }

        private void DataGridView_Click(object sender, EventArgs e)
        {
            string ma;
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaLanQCao.Focus();
                return;
            }
            if (tblKQC.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK,
MessageBoxIcon.Information);
                return;
            }
            txtMaLanQCao.Text = DataGridView.CurrentRow.Cells["MaLanQCao"].Value.ToString();
            txtTenKH.Text = DataGridView.CurrentRow.Cells["TenKH"].Value.ToString();
            ma = DataGridView.CurrentRow.Cells["MaKH"].Value.ToString();
            cboMaKH.Text = Functions.GetFieldValues("SELECT TenKH FROM tblKhachHang WHERE MaKH = N'" + ma + "'");
            ma = DataGridView.CurrentRow.Cells["MaBao"].Value.ToString();
            cboMaBao.Text = Functions.GetFieldValues("SELECT TenBao FROM tblBao WHERE MaBao = N'" + ma + "'");
            ma = DataGridView.CurrentRow.Cells["MaNV"].Value.ToString();
            cboMaNV.Text = Functions.GetFieldValues("SELECT TenNV FROM tblNhanVien WHERE MaNV = N'" + ma + "'");
            ma = DataGridView.CurrentRow.Cells["MaQCao"].Value.ToString();
            cboMaQCao.Text = Functions.GetFieldValues("SELECT TenQCao FROM tblTTQuangCao WHERE MaQCao = N'" + ma + "'");
            txtNoiDung.Text = DataGridView.CurrentRow.Cells["NoiDung"].Value.ToString();
            
            mskNgayBD.Text = DataGridView.CurrentRow.Cells["NgayBĐ"].Value.ToString();
            mskNgayKT.Text = DataGridView.CurrentRow.Cells["NgayKT"].Value.ToString();
            txtTongTien.Text = DataGridView.CurrentRow.Cells["TongTien"].Value.ToString();

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
            txtMaLanQCao.Enabled = true;
            txtMaLanQCao.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtMaLanQCao.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã lần gửi", "Thông báo", MessageBoxButtons.OK,
MessageBoxIcon.Warning);
                txtMaLanQCao.Focus();
                return;
            }
            if (cboMaKH.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã", "Thông báo", MessageBoxButtons.OK,
 MessageBoxIcon.Warning);
                cboMaKH.Focus();
                return;
            }
            if (txtTenKH.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên ", "Thông báo", MessageBoxButtons.OK,
 MessageBoxIcon.Warning);
                txtTenKH.Focus();
                return;
            }
            if (cboMaBao.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã báo", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboMaBao.Focus();
                return;
            }
            if (cboMaNV.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập nhân viên", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboMaNV.Focus();
                return;
            }
            if (cboMaQCao.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập Quảng Cáo", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboMaQCao.Focus();
                return;
            }
            if (txtNoiDung.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập nội dung", "Thông báo", MessageBoxButtons.OK,
 MessageBoxIcon.Warning);
                txtNoiDung.Focus();
                return;
            }
            if (mskNgayBD.Text == "  /  /")
            {
                MessageBox.Show("Bạn phải nhập ngày BĐ", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskNgayBD.Focus();
                return;
            }
            if (!Functions.IsDate(mskNgayBD.Text))
            {
                MessageBox.Show("Bạn phải nhập lại ngày BĐ", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskNgayBD.Text = "";
                mskNgayBD.Focus();
                return;
            }
            if (mskNgayKT.Text == "  /  /")
            {
                MessageBox.Show("Bạn phải nhập ngày KT", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskNgayKT.Focus();
                return;
            }
            if (!Functions.IsDate(mskNgayKT.Text))
            {
                MessageBox.Show("Bạn phải nhập lại ngày KT", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskNgayKT.Text = "";
                mskNgayKT.Focus();
                return;
            }
            


            sql = "SELECT MaLanQCao FROM tblKhachQuangCao  WHERE MaLanQCao = N'" + txtMaLanQCao.Text.Trim() + "' ";
            if (Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã báo này đã có, bạn phải nhập mã khác", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaLanQCao.Focus();
                txtMaLanQCao.Text = "";
                return;
            }

            sql = "INSERT INTO tblKhachQuangCao(MaLanQCao,MaKH,TenKH,MaBao,MaNV,MaQCao,NoiDung,NgayBĐ,NgayKT,TongTien) VALUES(N'" +
                txtMaLanQCao.Text.Trim() + "',N'" +
                cboMaKH.SelectedValue.ToString() + "',N'" + txtTenKH.Text.Trim() + "',N'" + cboMaBao.SelectedValue.ToString() + "',N'" +
                cboMaNV.SelectedValue.ToString() + "',N'" +
                cboMaQCao.SelectedValue.ToString() + "',N'" +
                txtNoiDung.Text + "','" +
                Functions.ConvertDateTime(mskNgayBD.Text.Trim()) + "','" +
                Functions.ConvertDateTime(mskNgayKT.Text.Trim()) + "',N'" + txtTongTien.Text.Trim() + "')";
            Functions.RunSql(sql);
            Load_DataGridView();
            ResetValues();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnBoQua.Enabled = false;
            btnLuu.Enabled = false;
            txtMaLanQCao.Enabled = false; 
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblKQC.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK,
MessageBoxIcon.Information);
                return;
            }
            if (txtMaLanQCao.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã lần gửi", "Thông báo", MessageBoxButtons.OK,
MessageBoxIcon.Warning);
                txtMaLanQCao.Focus();
                return;
            }
            if (cboMaKH.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã", "Thông báo", MessageBoxButtons.OK,
 MessageBoxIcon.Warning);
                cboMaKH.Focus();
                return;
            }
            if (txtTenKH.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên ", "Thông báo", MessageBoxButtons.OK,
 MessageBoxIcon.Warning);
                txtTenKH.Focus();
                return;
            }
            if (cboMaBao.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã báo", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboMaBao.Focus();
                return;
            }
            if (cboMaNV.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập nhân viên", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboMaNV.Focus();
                return;
            }
            if (cboMaQCao.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập Quảng Cáo", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboMaQCao.Focus();
                return;
            }
            if (txtNoiDung.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập nội dung", "Thông báo", MessageBoxButtons.OK,
 MessageBoxIcon.Warning);
                txtNoiDung.Focus();
                return;
            }
            if (mskNgayBD.Text == "  /  /")
            {
                MessageBox.Show("Bạn phải nhập ngày BĐ", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskNgayBD.Focus();
                return;
            }
            if (!Functions.IsDate(mskNgayBD.Text))
            {
                MessageBox.Show("Bạn phải nhập lại ngày BĐ", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskNgayBD.Text = "";
                mskNgayBD.Focus();
                return;
            }
            if (mskNgayKT.Text == "  /  /")
            {
                MessageBox.Show("Bạn phải nhập ngày KT", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskNgayKT.Focus();
                return;
            }
            if (!Functions.IsDate(mskNgayKT.Text))
            {
                MessageBox.Show("Bạn phải nhập lại ngày KT", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskNgayKT.Text = "";
                mskNgayKT.Focus();
                return;
            }
            sql = "UPDATE tblKhachQuangCao SET MaKH=N'" + cboMaKH.SelectedValue.ToString() + "',TenKH=N'" + txtTenKH.Text.Trim() + "',MaBao=N'" +
                cboMaBao.SelectedValue.ToString() + "',MaNV=N'" + cboMaNV.SelectedValue.ToString() + "',MaQCao=N'" + cboMaQCao.SelectedValue.ToString() + "',NoiDung=N'" + 
                txtNoiDung.Text.Trim() + "',NgayBĐ='" +
                Functions.ConvertDateTime(mskNgayBD.Text) + "',NgayKT='" +
                Functions.ConvertDateTime(mskNgayKT.Text) + "',TongTien=N'" +
                txtTongTien.Text.Trim() + "'WHERE MaLanQCao=N'" + txtMaLanQCao.Text + "'";


            Functions.RunSql(sql);
            Load_DataGridView();
            ResetValues();
            btnBoQua.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblKQC.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK,
MessageBoxIcon.Information);
                return;
            }
            if (txtMaLanQCao.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo",
MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE tblKhachQuangCao WHERE MaLanQCao=N'" + txtMaLanQCao.Text + "'";
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
            txtMaLanQCao.Enabled = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboMaKH_TextChanged(object sender, EventArgs e)
        {
            string str;
            if (cboMaKH.Text == "")
            {

                txtTenKH.Text = "";
            }
            str = "Select TenKH from tblKhachHang where MaKH= N'" + cboMaKH.SelectedValue + "'";
            txtTenKH.Text = Functions.GetFieldValues(str);
        }

        private void DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtTongTien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }


    }
}
