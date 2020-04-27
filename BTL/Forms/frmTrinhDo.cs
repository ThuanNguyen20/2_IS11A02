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
    public partial class frmTrinhDo : Form
    {
        public frmTrinhDo()
        {
            InitializeComponent();
        }

        private void Hienthi_Luoi()
        {
            string sql;
            DataTable tblTrinhDo;
            sql = "SELECT MaTĐ, TenTĐ FROM tblTrinhDo";
            tblTrinhDo = Class.Functions.GetDataToTable(sql);
            dataGridView.DataSource = tblTrinhDo;
            dataGridView.Columns[0].HeaderText = "Mã trình độ";
            dataGridView.Columns[1].HeaderText = "Tên trình độ";
            dataGridView.Columns[0].Width = 100;
            dataGridView.Columns[1].Width = 200;
            dataGridView.AllowUserToAddRows = false;
            dataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
            tblTrinhDo.Dispose();
        }

        private void frmTrinhDo_Load(object sender, EventArgs e)
        {
            Hienthi_Luoi();
        }

        private void frmTrinhDo_Activated(object sender, EventArgs e)
        {
            Hienthi_Luoi();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow.Cells["MaTĐ"].Value.ToString() == "")
            {
                MessageBox.Show("Không có dữ liệu", "Thông báo");
                return;
            }
            Forms.frmUpdateTrinhDo t = new Forms.frmUpdateTrinhDo();
            t.StartPosition = FormStartPosition.CenterScreen;
            t.txtMaTĐ.Text = dataGridView.CurrentRow.Cells["MaTĐ"].Value.ToString();
            t.txtTenTĐ.Text = dataGridView.CurrentRow.Cells["TenTĐ"].Value.ToString();
            t.Show();
            Hienthi_Luoi();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (dataGridView.CurrentRow.Cells["MaTĐ"].Value.ToString() == "")
            {
                MessageBox.Show("Không có dữ liệu !", "Thông báo");
                return;
            }
            string mt;
            mt = dataGridView.CurrentRow.Cells["MaTĐ"].Value.ToString();
            if (MessageBox.Show("Bạn có muốn xóa không ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes)
            {
                sql = "DELETE tblTrinhDo WHERE MaTĐ = N'" + mt + "'";
                Class.Functions.RunSql(sql);
                Hienthi_Luoi();
            }
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            Forms.frmAddTrinhDo t = new Forms.frmAddTrinhDo();
            t.StartPosition = FormStartPosition.CenterScreen;
            t.Show();
        }
    }
}
