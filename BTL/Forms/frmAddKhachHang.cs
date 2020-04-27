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
    public partial class frmAddKhachHang : Form
    {
        public frmAddKhachHang()
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


            sql = "INSERT INTO tblKhachHang(MaKH, TenKH, DiaChi, DienThoai, DiDong, Email, MaLVHĐ) VALUES" +
                "(N'" + txtMaKH.Text + "',N'" + txtTenKH.Text + "',N'" + txtDiaChi.Text + "',N'" + txtDienThoai.Text + "',N'" + txtDiDong.Text + "',N'" + txtEmail.Text + "', N'" + cboLVHD.SelectedValue.ToString() + "')";
            Class.Functions.RunSql(sql);
            this.Close();

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddKhachHang_Load(object sender, EventArgs e)
        {
            Class.Functions.FillCombo("SELECT MaLVHĐ, TenLVHĐ FROM tblLVHĐ", cboLVHD, "MaLVHĐ", "TenLVHĐ");
            cboLVHD.SelectedIndex = -1;
        }

        private void txtDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
