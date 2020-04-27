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
    public partial class frmPhongBan : Form
    {
        public frmPhongBan()
        {
            InitializeComponent();
        }

        private void Hienthi_Luoi()
        {
            string sql;
            DataTable tblPhongBan;
            sql = "SELECT MaPhong, TenPhong, MaBao, DienThoai FROM tblPhongBan";
            tblPhongBan = Class.Functions.GetDataToTable(sql);
            dataGridView.DataSource = tblPhongBan;
            dataGridView.Columns[0].HeaderText = "Mã phòng";
            dataGridView.Columns[1].HeaderText = "Tên phòng";
            dataGridView.Columns[2].HeaderText = "Mã báo";
            dataGridView.Columns[3].HeaderText = "Điện thoại";
            dataGridView.Columns[0].Width = 100;
            dataGridView.Columns[1].Width = 200;
            dataGridView.Columns[2].Width = 150;
            dataGridView.Columns[3].Width = 100;
            dataGridView.AllowUserToAddRows = false;
            dataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
            tblPhongBan.Dispose();
        }
        private void frmPhongBan_Load(object sender, EventArgs e)
        {
            Hienthi_Luoi();
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            Forms.frmAddPhongBan p = new Forms.frmAddPhongBan();
            p.StartPosition = FormStartPosition.CenterScreen;
            p.Show();
        }

        private void frmPhongBan_Activated(object sender, EventArgs e)
        {
            Hienthi_Luoi();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string ma;
            if(dataGridView.CurrentRow.Cells["MaPhong"].Value.ToString() == "")
            {
                MessageBox.Show("Không có dữ liệu", "Thông báo");
                return;
            }
            Forms.frmUpdatePhongBan p = new Forms.frmUpdatePhongBan();
            p.StartPosition = FormStartPosition.CenterScreen;
            p.txtMaPhong.Text = dataGridView.CurrentRow.Cells["MaPhong"].Value.ToString();
            p.txtTenPhong.Text = dataGridView.CurrentRow.Cells["TenPhong"].Value.ToString();
            ma = dataGridView.CurrentRow.Cells["MaBao"].Value.ToString();
            //f.cboLVHD.Text = Class.Functions.GetFieldValues("SELECT TenLVHĐ FROM tblLVHĐ WHERE MaLVHĐ = N'" + ma + "'");
            p.txtDienThoai.Text = dataGridView.CurrentRow.Cells["DienThoai"].Value.ToString();
            p.Show();
            Hienthi_Luoi();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (dataGridView.CurrentRow.Cells["MaPhong"].Value.ToString() == "")
            {
                MessageBox.Show("Không có dữ liệu !", "Thông báo");
                return;
            }
            string mt;
            mt = dataGridView.CurrentRow.Cells["MaPhong"].Value.ToString();
            if (MessageBox.Show("Bạn có muốn xóa không ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes)
            {
                sql = "DELETE tblPhongBan WHERE MaPhong = N'" + mt + "'";
                Class.Functions.RunSql(sql);
                Hienthi_Luoi();
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
