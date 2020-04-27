using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL.Forms
{
    public partial class frmThongTinQuangCao : Form
    {
        SqlConnection con = new SqlConnection();
        public frmThongTinQuangCao()
        {
            InitializeComponent();
        }
        DataTable tblThongTinQuangCao;
        private void frmThongTinQuangCao_Load(object sender, EventArgs e)
        {
            string ConnectionString = @"Data Source=.;Initial Catalog=QuangCao;Integrated Security=True";

            string sql = "select*from tblTTQuangCao";
            SqlDataAdapter adp = new SqlDataAdapter(sql, ConnectionString);
            DataTable tabletblTTQuangCao = new DataTable();
            adp.Fill(tabletblTTQuangCao);
            dataGridView.DataSource = tabletblTTQuangCao;
        }
        private void Hienthi_Luoi()
        {
            string sql;
           
            sql = "SELECT * FROM tblTTQuangCao";
            tblThongTinQuangCao = Class.Functions.GetDataToTable(sql);
            dataGridView.DataSource = tblThongTinQuangCao;
            dataGridView.Columns[0].HeaderText = "Mã quảng cáo";
            dataGridView.Columns[1].HeaderText = "Tên quảng cáo";

            dataGridView.Columns[0].Width = 50;
            dataGridView.Columns[1].Width = 100;

            dataGridView.AllowUserToAddRows = false;
            dataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
            tblThongTinQuangCao.Dispose();
        }
        private void XoaDuLieuTrongTextbox()
        {
            txtMaQuangCao.Text = "";
            txtTenQuangCao.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            XoaDuLieuTrongTextbox();
            txtMaQuangCao.Focus();
            txtMaQuangCao.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtMaQuangCao.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã quảng cáo !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaQuangCao.Focus();
                return;
            }
            if (txtTenQuangCao.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên quảng cáo !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenQuangCao.Focus();
                return;
            }

            sql = "SELECT MaQCao From tblTTQuangCao where MaQCao=N'" + txtMaQuangCao.Text.Trim() + "'";
            DataTable tblThongTinQuangCao = Class.Functions.GetDataToTable(sql);
            if (tblThongTinQuangCao.Rows.Count > 0)
            {
                MessageBox.Show("Mã nhân viên này đã có, bạn phải nhập mã khác", "Thông báo");
                txtMaQuangCao.Focus();
                txtMaQuangCao.Text = "";
                return;
            }
            sql = "INSERT INTO tblTTQuangCao(MaQCao,TenQCao) VALUES(N'" + txtMaQuangCao.Text + "',N'" + txtTenQuangCao.Text + "')";
            Class.Functions.RunSql(sql);
            Hienthi_Luoi();
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (dataGridView.CurrentRow.Cells["MaQCao"].Value.ToString() == "")
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo");
                return;
            }
            string mt;
            mt = dataGridView.CurrentRow.Cells["MaQCao"].Value.ToString();
            if (MessageBox.Show("Bạn có muốn xóa không ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "DELETE tblTTQuangCao WHERE MaQCao = N'" + mt + "'";
                Class.Functions.RunSql(sql);
                Hienthi_Luoi();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblThongTinQuangCao.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK,
MessageBoxIcon.Information);
                return;
            }
            if (txtMaQuangCao.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã quảng cáo !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaQuangCao.Focus();
                return;
            }
            if (txtTenQuangCao.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên quảng cáo !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenQuangCao.Focus();
                return;
            }
            sql = "UPDATE tblTTQuangCao SET TenQCao=N'" + txtTenQuangCao.Text.ToString() +
"' WHERE MaQCao=N'" + txtMaQuangCao.Text + "'";
            Class.Functions.RunSql(sql);
            Hienthi_Luoi();
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
        }
    }
}
