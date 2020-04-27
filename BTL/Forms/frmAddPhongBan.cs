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
    public partial class frmAddPhongBan : Form
    {
        public frmAddPhongBan()
        {
            InitializeComponent();
        }

        private void frmAddPhongBan_Load(object sender, EventArgs e)
        {
            Class.Functions.FillCombo("SELECT MaBao, Tenbao FROM tblBao", cboMaBao, "MaBao", "TenBao");
            cboMaBao.SelectedIndex = -1;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtMaPhong.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã phòng", "Thông báo");
                txtMaPhong.Focus();
                return;
            }
            if (txtTenPhong.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên phòng", "Thông báo");
                txtTenPhong.Focus();
                return;
            }
            if (cboMaBao.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã báo", "Thông báo");
                cboMaBao.Focus();
                return;
            }
            if (txtDienThoai.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập điện thoại", "Thông báo");
                txtDienThoai.Focus();
                return;
            }

            sql = "SELECT MaPhong FROM tblPhongBan WHERE MaPhong=N' " + txtMaPhong.Text.Trim() + "'";
            DataTable tblPhongBan = Class.Functions.GetDataToTable(sql);
            if (tblPhongBan.Rows.Count > 0)
            {
                MessageBox.Show("Mã phòng này đã có, bạn phải nhập mã khác", "Thông báo");
                txtMaPhong.Focus();
                txtMaPhong.Text = "";
                return;
            }


            sql = "INSERT INTO tblPhongBan(MaPhong, TenPhong, MaBao, DienThoai) VALUES" +
                "(N'" + txtMaPhong.Text + "',N'" + txtTenPhong.Text + "',N'" + cboMaBao.SelectedValue.ToString() + "',N'" + txtDienThoai.Text + "')";
            Class.Functions.RunSql(sql);
            this.Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
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
