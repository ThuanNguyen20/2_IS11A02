﻿using System;
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
    public partial class frmAddNhanVien : Form
    {
        public frmAddNhanVien()
        {
            InitializeComponent();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtMaNV.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã nhân viên", "Thông báo");
                txtMaNV.Focus();
                return;
            }
            if (txtTenNV.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên nhân viên", "Thông báo");
                txtTenNV.Focus();
                return;
            }
            if (cboMaBao.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã báo", "Thông báo");
                cboMaBao.Focus();
                return;
            }
            if (cboMaPhong.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã phòng", "Thông báo");
                cboMaPhong.Focus();
                return;
            }
            if (cboMaCV.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã chức vụ", "Thông báo");
                cboMaCV.Focus();
                return;
            }
            if (cboTrinhDo.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã trình độ", "Thông báo");
                cboTrinhDo.Focus();
                return;
            }
            if (cboMaCM.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã chuyên môn", "Thông báo");
                cboMaCM.Focus();
                return;
            }
            if (txtDiaChi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo");
                txtDiaChi.Focus();
                return;
            }
            if (cboNgay.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập ngày sinh", "Thông báo");
                cboNgay.Focus();
                return;
            }
            if (cboThang.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tháng sinh ", "Thông báo");
                cboThang.Focus();
                return;
            }
            if (cboNam.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập năm sinh", "Thông báo");
                cboNam.Focus();
                return;
            }
            if (cboGioiTinh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập giới tính", "Thông báo");
                cboGioiTinh.Focus();
                return;
            }

            if (txtDienThoai.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập điện thoại", "Thông báo");
                txtDienThoai.Focus();
                return;
            }
            if (txtMobile.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập Mobile", "Thông báo");
                txtMobile.Focus();
                return;
            }
            if (txtEmail.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập Email", "Thông báo");
                txtEmail.Focus();
                return;
            }
            sql = "SELECT MaNV FROM tblNhanvien WHERE MaNV=N' " + txtMaNV.Text.Trim() + "'";
            DataTable tblNhanVien = Class.Functions.GetDataToTable(sql);
            if (tblNhanVien.Rows.Count > 0)
            {
                MessageBox.Show("Mã nhân viên này đã có, bạn phải nhập mã khác", "Thông báo");
                txtMaNV.Focus();
                txtMaNV.Text = "";
                return;
            }

            string NgaySinh;
            NgaySinh = String.Format("{1}/{0}/{2}", cboNgay.Text, cboThang.Text, cboNam.Text);

            //sql = "SELECT MaNV FROM tblNhanVien WHERE MaNV = N' " + txtMaNV.Text.Trim() + "'";
            //DataTable tblNhanVien = Class.Functions.GetDataToTable(sql);
            //if (tblNhanVien.Rows.Count > 0)
            //{
            //    MessageBox.Show("Mã nhân viên này đã có, bạn phải nhập mã khác", "Thông báo");
            //    txtMaNV.Focus();
            //    txtMaNV.Text = "";
            //    return;
            //}

            sql = "INSERT INTO tblNhanVien(MaNV, TenNV, MaBao, MaPhong, MaChucVu, MaTĐ, MaCM, DiaChi, NgaySinh, GioiTinh, DienThoai, Mobile, Email ) VALUES" +
                "(N'" + txtMaNV.Text + "',N'" + txtTenNV.Text + "',N'" + cboMaBao.SelectedValue.ToString() + "',N'" + cboMaPhong.SelectedValue.ToString() + "',N'" + cboMaCV.SelectedValue.ToString() + "',N'" + cboTrinhDo.SelectedValue.ToString() + "',N'" + cboMaCM.SelectedValue.ToString() + "',N'" + txtDiaChi.Text + "',N'" + NgaySinh + "',N'" + cboGioiTinh.Text + "',N'" + txtDienThoai.Text + "',N'" + txtMobile.Text + "',N'" + txtEmail.Text + "')";
            Class.Functions.RunSql(sql);
            this.Close();
        }

        private void frmAddNhanVien_Load(object sender, EventArgs e)
        {
            txtMaNV.Enabled = true;
            cboGioiTinh.Items.Add("Nam");
            cboGioiTinh.Items.Add("Nữ");
            cboGioiTinh.Items.Add("Giới tính khác");
            for (int i = 1; i <= 31; i++)
            {
                cboNgay.Items.Add(i.ToString());
            }
            for (int i = 1; i <= 12; i++)
            {
                cboThang.Items.Add(i.ToString());
            }
            for (int i = 1970; i <= 2100; i++)
            {
                cboNam.Items.Add(i.ToString());
            }
            cboNgay.SelectedIndex = -1;
            cboThang.SelectedIndex = -1;
            cboNam.SelectedIndex = -1;
            Class.Functions.FillCombo("SELECT MaBao, TenBao FROM tblBao", cboMaBao, "MaBao", "TenBao");
            cboMaBao.SelectedIndex = -1;
            Class.Functions.FillCombo("SELECT MaTĐ, TenTĐ FROM tblTrinhDo", cboTrinhDo, "MaTĐ", "TenTĐ");
            cboTrinhDo.SelectedIndex = -1;
            Class.Functions.FillCombo("SELECT MaPhong, TenPhong FROM tblPhongBan", cboMaPhong, "MaPhong", "TenPhong");
            cboMaPhong.SelectedIndex = -1;
            Class.Functions.FillCombo("SELECT MaChucVu, TenChucVu FROM tblChucVu", cboMaCV, "MaChucVu", "TenChucVu");
            cboMaCV.SelectedIndex = -1;
            Class.Functions.FillCombo("SELECT MaCM, TenCM FROM tblChuyenMon", cboMaCM, "MaCM", "TenCM");
            cboMaCM.SelectedIndex = -1;
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

        private void txtMobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
