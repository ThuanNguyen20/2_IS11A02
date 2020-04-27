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
    public partial class frmTimKiemNhanVien : Form
    {
        public frmTimKiemNhanVien()
        {
            InitializeComponent();
        }

        private void frmTimKiemNhanVien_Load(object sender, EventArgs e)
        {
            cboGioiTinh.Items.Add("Nam");
            cboGioiTinh.Items.Add("Nữ");
            cboGioiTinh.Items.Add("Giới tính khác");
            ResetValues();
            dataGridView.DataSource = null;
            cboTenNV.DataSource = Class.Functions.GetDataToTable("SELECT TenNV FROM tblNhanVien");
            cboTenNV.ValueMember = "TenNV";
            cboTenNV.SelectedIndex = -1;
            cboMaTĐ.DataSource = Class.Functions.GetDataToTable("SELECT MaTĐ FROM tblNhanVien");
            cboMaTĐ.ValueMember = "MaTĐ";
            cboMaTĐ.SelectedIndex = -1;
            cboMaPhong.DataSource = Class.Functions.GetDataToTable("SELECT MaPhong FROM tblNhanVien");
            cboMaPhong.ValueMember = "MaPhong";
            cboMaPhong.SelectedIndex = -1;
        }

        private void ResetValues()
        {
            foreach (Control Ctl in this.Controls)
                if (Ctl is TextBox)
                    Ctl.Text = "";
            cboTenNV.Text = "";
            cboGioiTinh.Text = "";
            cboMaTĐ.Text = "";
            cboMaPhong.Text = "";
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string sql;
            DataTable tblNhanVien;
            if ((cboTenNV.Text == "") && (cboGioiTinh.Text == "") && (cboMaTĐ.Text == "") && (cboMaPhong.Text == ""))
            {
                MessageBox.Show("Hãy nhập một điều kiện tìm kiếm!!!", "Yêu cầu ...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sql = "SELECT * FROM tblNhanVien WHERE 1=1";

            if (cboTenNV.Text != "")
                sql = sql + " AND TenNV Like N'%" + cboTenNV.Text.Trim() + "%'";

            if (cboGioiTinh.Text != "")
                sql = sql + " AND GioiTinh Like N'%" + cboGioiTinh.Text.Trim() + "%'";
            if (cboMaTĐ.Text != "")
            {
                sql = sql + " AND MaTĐ LIKE N'%" + cboMaTĐ.Text.Trim() + "%'";
            }
            if (cboMaPhong.Text != "")
            {
                sql = sql + " AND MaPhong Like N'%" + cboMaPhong.Text.Trim() + "%'";
            }
            tblNhanVien = Class.Functions.GetDataToTable(sql);
            if (tblNhanVien.Rows.Count == 0)
                MessageBox.Show("Không có bản ghi thỏa mãn điều kiện!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                MessageBox.Show("Có " + tblNhanVien.Rows.Count + " bản ghi thỏa mãn điều kiện!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            dataGridView.DataSource = tblNhanVien;
            Hienthi_Luoi();
        }

        private void Hienthi_Luoi()
        {
            dataGridView.Columns[0].HeaderText = "Tên Nhân Viên";
            dataGridView.Columns[1].HeaderText = "Giới Tính";
            dataGridView.Columns[2].HeaderText = "Trình Độ";
            dataGridView.Columns[3].HeaderText = "Phòng Ban";
            dataGridView.Columns[0].Width = 150;
            dataGridView.Columns[1].Width = 180;
            dataGridView.Columns[2].Width = 120;
            dataGridView.Columns[3].Width = 100;
            dataGridView.AllowUserToAddRows = false;
            dataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void btnTimLai_Click(object sender, EventArgs e)
        {
            ResetValues();
            dataGridView.DataSource = null;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
