using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL.Forms
{
    public partial class frmUpdateKhachHang : Form
    {
        public frmUpdateKhachHang()
        {
            InitializeComponent();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtMaKH.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã khách hàng", "Thông báo");
                txtMaKH.Focus();
                return;
            }
            if (txtTenKH.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên khách hàng", "Thông báo");
                txtTenKH.Focus();
                return;
            }
            if (txtDiaChi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo");
                txtDiaChi.Focus();
                return;
            }
            if (txtDienThoai.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập điện thoại", "Thông báo");
                txtDienThoai.Focus();
                return;
            }
            if (txtDiDong.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập di động", "Thông báo");
                txtDiDong.Focus();
                return;
            }
            if (txtEmail.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập Email", "Thông báo");
                txtEmail.Focus();
                return;
            }
            if (cboLVHD.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã LVHĐ", "Thông báo");
                cboLVHD.Focus();
                return;
            }

            sql = "SELECT MaKH FROM tblKhachHang WHERE MaKH=N' " + txtMaKH.Text.Trim() + "'";
            DataTable tblKhachHang = Class.Functions.GetDataToTable(sql);
            if (tblKhachHang.Rows.Count > 0)
            {
                MessageBox.Show("Mã khách hàng này đã có, bạn phải nhập mã khác", "Thông báo");
                txtMaKH.Focus();
                txtMaKH.Text = "";
                return;
            }


            sql = "UPDATE  tblKhachHang  SET TenKH=N'" + txtTenKH.Text.Trim()
               + "', DiaChi=N'" + txtDiaChi.Text.Trim() + "',DienThoai=N'" + txtDienThoai.Text.Trim()
               + "',DiDong=N'" + txtDiDong.Text.Trim() + "', Email=N'" + txtEmail.Text.Trim() + "', MaLVHĐ= N'" + cboLVHD.SelectedValue.ToString() + "' WHERE MaKH = N'"
               + txtMaKH.Text + "'";
            Class.Functions.RunSql(sql);
            this.Close();
        }

        private void frmUpdateKhachHang_Load(object sender, EventArgs e)
        {

            Class.Functions.FillCombo("SELECT MaLVHĐ, TenLVHĐ FROM tblLVHĐ", cboLVHD, "MaLVHĐ", "TenLVHĐ");
            cboLVHD.SelectedIndex = -1;
            txtMaKH.Enabled = false;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtDiDong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
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
