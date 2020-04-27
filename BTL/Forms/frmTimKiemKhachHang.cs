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
    public partial class frmTimKiemKhachHang : Form
    {
        public frmTimKiemKhachHang()
        {
            InitializeComponent();
        }

        private void frmTimKiemKhachHang_Load(object sender, EventArgs e)
        {
            ResetValues();
            dataGridView1.DataSource = null;

            cboTieuDe.DataSource = Class.Functions.GetDataToTable("SELECT TieuDe FROM tblKhachGuiBai");
            cboTieuDe.ValueMember = "TieuDe";
            cboTieuDe.SelectedIndex = -1;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string sql;
            DataTable tblKhachGuiBai;
            if ((cboTieuDe.Text == "") && (cboTieuDe.Text == ""))
            {
                MessageBox.Show("Hãy nhập một điều kiện tìm kiếm!!!", "Yêu cầu ...",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sql = "SELECT TenKH, DiaChi, DienThoai, DiDong, Email FROM tblKhachHang INNER JOIN tblKhachGuiBai ON tblKhachHang.MaKH = tblKhachGuiBai.MaKH WHERE 1=1";


            if (cboTieuDe.Text != "")
                sql = sql + " AND TieuDe Like N'%" + cboTieuDe.Text + "%'";

            tblKhachGuiBai = Class.Functions.GetDataToTable(sql);
            if (tblKhachGuiBai.Rows.Count == 0)
                MessageBox.Show("Không có bản ghi thỏa mãn điều kiện!!!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                MessageBox.Show("Có " + tblKhachGuiBai.Rows.Count + " bản ghi thỏa mãn điều kiện!!!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            dataGridView1.DataSource = tblKhachGuiBai;
        }

        private void btnTimLai_Click(object sender, EventArgs e)
        {
            ResetValues();
            dataGridView1.DataSource = null;
        }

        private void Hienthi_Luoi()
        {
            dataGridView1.Columns[0].HeaderText = "Mã khách hàng";
            dataGridView1.Columns[1].HeaderText = "Tên khách hàng";
            dataGridView1.Columns[2].HeaderText = "Địa chỉ";
            dataGridView1.Columns[3].HeaderText = "Điện thoại";
            dataGridView1.Columns[4].HeaderText = "Di Động";
            dataGridView1.Columns[5].HeaderText = "Email";
            dataGridView1.Columns[6].HeaderText = "Mã LVHĐ";
            dataGridView1.Columns[0].Width = 200;
            dataGridView1.Columns[1].Width = 150;
            dataGridView1.Columns[2].Width = 120;
            dataGridView1.Columns[3].Width = 100;
            dataGridView1.Columns[4].Width = 100;
            dataGridView1.Columns[5].Width = 100;
            dataGridView1.Columns[6].Width = 100;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void ResetValues()
        {
            foreach (Control Ctl in this.Controls)
                if (Ctl is TextBox)
                    Ctl.Text = "";

            cboTieuDe.Text = "";

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
