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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Class.Functions.Connect();
        }

        private void mnuTongTien_Click(object sender, EventArgs e)
        {

        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void lĩnhVựcHoạtĐộngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.frmLinhVucHoatDong k = new Forms.frmLinhVucHoatDong();
            k.StartPosition = FormStartPosition.CenterScreen;
            k.Show();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.frmNhanVien k = new Forms.frmNhanVien();
            k.StartPosition = FormStartPosition.CenterScreen;
            k.Show();
        }

        private void báoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.frmBao f = new Forms.frmBao();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void kháchGửiBàiToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void thểLoạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.frmTheLoai f = new Forms.frmTheLoai();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void chứcNăngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.frmChucNang f = new Forms.frmChucNang();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void quảngCáoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.frmQCao f = new Forms.frmQCao();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void báoThểLoạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.frmBaoTheLoai f = new Forms.frmBaoTheLoai();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.frmKhachHang k = new Forms.frmKhachHang();
            k.StartPosition = FormStartPosition.CenterScreen;
            k.Show();
        }

        private void trìnhĐộToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.frmTrinhDo f = new Forms.frmTrinhDo();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        //private void tìmKiếmToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    Forms.frmTimKiem f = new Forms.frmTimKiem();
        //    f.StartPosition = FormStartPosition.CenterScreen;
        //    f.Show();
        //}

        private void phòngBanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.frmPhongBan f = new Forms.frmPhongBan();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void chuyênMônToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.frmChuyenMon f = new Forms.frmChuyenMon();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void chứcVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.frmChucVu f = new Forms.frmChucVu();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void kháchGửiBàiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.frmKhachGuiBai f = new Forms.frmKhachGuiBai();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void kháchQuảngCáoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.frmKhachQuangCao f = new Forms.frmKhachQuangCao();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        //private void báoCáoToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    Forms.frmBaoCao f = new Forms.frmBaoCao();
        //    f.StartPosition = FormStartPosition.CenterScreen;
        //    f.Show();
        //}

        #region Như Vũ
        private void moFormXuatBieuMau(string nametable, string reportPath)
        {
            var child = new fXuatBaoCao(nametable, reportPath);
            child.Show();
            child.Owner = this;
            this.Hide();
        }

        private void btnChiPhiDoanhThuNhuanBut_Click(object sender, EventArgs e)
        {
            moFormXuatBieuMau("vBaoCaoChiPhiKhachGuiBai", "BTL.ReportViews.rThongKeChiPhiNhuanBut.rdlc");
        }

        private void btnBaoCaoDoanhThuQC_Click(object sender, EventArgs e)
        {
            moFormXuatBieuMau("vBaoCaoDoanhThuQuangCao", "BTL.ReportViews.rThongKeDoanhThuTuQuangCao.rdlc");
        }
        #endregion

        private void mnuBaoCaoNhanGuiBai_Click(object sender, EventArgs e)
        {
            Forms.frmBaoCao f = new Forms.frmBaoCao();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void báoCáoThểLoạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.frmTimKiem f = new Forms.frmTimKiem();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

    }
}