﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BTL.Forms
{
    public partial class frmChucNang : Form
    {
        public frmChucNang()
        {
            InitializeComponent();
        }
        DataTable tblCN;
        private void frmChucNang_Load(object sender, EventArgs e)
        {
            string ConnectionString = @"Data Source=.;Initial Catalog=QuangCao;Integrated Security=True";

            string sql = "select*from tblChucNang";
            SqlDataAdapter adp = new SqlDataAdapter(sql, ConnectionString);
            DataTable tabletblChucNang = new DataTable();
            adp.Fill(tabletblChucNang);
            DataGridView.DataSource = tabletblChucNang;
        }
        private void Load_DataGridView()
        {
            string sql;
            sql = "SELECT MaChucNang, TenChucNang FROM tblChucNang";
            tblCN = Class.Functions.GetDataToTable(sql);
            DataGridView.DataSource = tblCN;
            DataGridView.Columns[0].HeaderText = "Mã thể loại";
            DataGridView.Columns[1].HeaderText = "Tên thể loại";
            DataGridView.Columns[0].Width = 200;
            DataGridView.Columns[1].Width = 500;
            // Không cho phép thêm mới dữ liệu trực tiếp trên lưới
            DataGridView.AllowUserToAddRows = false;
            // Không cho phép sửa dữ liệu trực tiếp trên lưới
            DataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void DataGridView_Click(object sender, EventArgs e)
        {
            txtMaChucNang.Text = DataGridView.CurrentRow.Cells["MaChucNang"].Value.ToString();
            txtTenChucNang.Text = DataGridView.CurrentRow.Cells["TenChucNang"].Value.ToString();

            txtMaChucNang.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnBoQua.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            ResetValues();
            txtMaChucNang.Enabled = true;
            txtMaChucNang.Focus();
        }
        private void ResetValues()
        {
            txtMaChucNang.Text = "";
            txtTenChucNang.Text = "";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtMaChucNang.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã thể loại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaChucNang.Focus();
                return;
            }
            if (txtTenChucNang.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên thể loại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenChucNang.Focus();
                return;
            }
            sql = "SELECT MaChucNang FROM tblChucNang WHERE MaChucNang=N'" + txtMaChucNang.Text.Trim() + "'";
            if (Class.Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã chức năng này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaChucNang.Focus();
                txtMaChucNang.Text = "";
                return;
            }
            sql = "INSERT INTO tblChucNang(MaChucNang,TenChucNang) VALUES(N'" + txtMaChucNang.Text + "',N'" + txtTenChucNang.Text + "')";
            Class.Functions.RunSql(sql);
            Load_DataGridView();
            ResetValues();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnBoQua.Enabled = false;
            btnLuu.Enabled = false;
            txtMaChucNang.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblCN.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK,
MessageBoxIcon.Information);
                return;
            }
            if (txtMaChucNang.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTenChucNang.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên chức năng", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenChucNang.Focus();
                return;
            }
            sql = "UPDATE tblChucNang SET TenChucNang=N'" + txtTenChucNang.Text.ToString() +
"' WHERE MaChucNang=N'" + txtMaChucNang.Text + "'";
            Class.Functions.RunSql(sql);
            Load_DataGridView();
            ResetValues();
            btnBoQua.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblCN.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK,
MessageBoxIcon.Information);
                return;
            }
            if (txtMaChucNang.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo",
MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE tblChucNang WHERE MaChucNang=N'" + txtMaChucNang.Text + "'";
                Class.Functions.RunSqlDel(sql);
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
            txtMaChucNang.Enabled = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void txtMaChucNang_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");

        }

        private void DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtMaChucNang_TextChanged(object sender, EventArgs e)
        {

        }
    }
}