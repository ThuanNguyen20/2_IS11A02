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
    public partial class frmUpdateTrinhDo : Form
    {
        public frmUpdateTrinhDo()
        {
            InitializeComponent();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtMaTĐ.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã trình độ", "Thông báo");
                txtMaTĐ.Focus();
                return;
            }
            if (txtTenTĐ.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên trình độ", "Thông báo");
                txtTenTĐ.Focus();
                return;
            }
            sql = "SELECT MaTĐ FROM tblTrinhDo WHERE MaTĐ=N'" + txtMaTĐ.Text.Trim() + "'";
            DataTable tblTrinhDo = Class.Functions.GetDataToTable(sql);
            if (tblTrinhDo.Rows.Count > 0)
            {
                sql = "UPDATE  tblTrinhDo  SET TenTĐ = N'" + txtTenTĐ.Text.Trim() + "' WHERE MaTĐ = N'"
                + txtMaTĐ.Text + "'";
                Class.Functions.RunSql(sql);
                this.Close();
            }
        }

        private void frmUpdateTrinhDo_Load(object sender, EventArgs e)
        {
            txtMaTĐ.Enabled = false;
        }
    }
}
