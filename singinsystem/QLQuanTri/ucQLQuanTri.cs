using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using singinsystem.QLDiLai;
using singinsystem.QuanTri.QLLoaiDangKy;
using singinsystem.QuanTri.QLNhanSu;
using singinsystem.QuanTri.QLQuyDinh;
using singinsystem.QuanTri.QLTaiKhoan;
using singinsystem.QuanTri.QLVanPhong;

namespace singinsystem.QLQuanTri
{
    public partial class ucQLQuanTri : UserControl
    {
		private ucQLVanPhong ucQLVP;
		private ucQLLoaiDangKy QLLDK;
		private ucQLDiLai QLDL;
		private ucQLQuyDinh QLQD;
		private ucQLNhanSu QLNS;
		private ucQuanLyTaiKhoan QLTK;
		public ucQLQuanTri()
        {
            InitializeComponent();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }
		private void btnMenuTaiKhoan_Click(object sender, EventArgs e)
		{
			bool flag = !this.pnMain.Controls.Contains(this.ucQLVP);
			if (flag)
			{
				this.ucQLVP = new ucQLVanPhong();
				this.ucQLVP.Dock = DockStyle.Fill;
				this.pnMain.Controls.Add(this.ucQLVP);
				this.ucQLVP.BringToFront();
			}
			else
			{
				this.ucQLVP.BringToFront();
			}
		}
		private void btnQLLoaiDangNhap_Click(object sender, EventArgs e)
		{
			bool flag = !this.pnMain.Controls.Contains(this.QLLDK);
			if (flag)
			{
				this.QLLDK = new ucQLLoaiDangKy();
				this.QLLDK.Dock = DockStyle.Fill;
				this.pnMain.Controls.Add(this.QLLDK);
				this.QLLDK.BringToFront();
			}
			else
			{
				this.QLLDK.BringToFront();
			}
		}
		private void btnQuanLyDiLai_Click(object sender, EventArgs e)
		{
			bool flag = !this.pnMain.Controls.Contains(this.QLDL);
			if (flag)
			{
				this.QLDL = new ucQLDiLai();
				this.QLDL.Dock = DockStyle.Fill;
				this.pnMain.Controls.Add(this.QLDL);
				this.QLDL.BringToFront();
			}
			else
			{
				this.QLDL.BringToFront();
			}
		}
		private void button5_Click(object sender, EventArgs e)
		{
			bool flag = !this.pnMain.Controls.Contains(this.QLQD);
			if (flag)
			{
				this.QLQD = new ucQLQuyDinh();
				this.QLQD.Dock = DockStyle.Fill;
				this.pnMain.Controls.Add(this.QLQD);
				this.QLQD.BringToFront();
			}
			else
			{
				this.QLQD.BringToFront();
			}
		}
		private void btnMenuQuanLyNhanSu_Click(object sender, EventArgs e)
		{
			bool flag = !this.pnMain.Controls.Contains(this.QLNS);
			if (flag)
			{
				this.QLNS = new ucQLNhanSu();
				this.QLNS.Dock = DockStyle.Fill;
				this.pnMain.Controls.Add(this.QLNS);
				this.QLNS.BringToFront();
			}
			else
			{
				this.QLNS.BringToFront();
			}
		}
		private void btnQLTaiKhoan_Click(object sender, EventArgs e)
		{
			bool flag = !this.pnMain.Controls.Contains(this.QLTK);
			if (flag)
			{
				this.QLTK = new ucQuanLyTaiKhoan();
				this.QLTK.Dock = DockStyle.Fill;
				this.pnMain.Controls.Add(this.QLTK);
				this.QLTK.BringToFront();
			}
			else
			{
				this.QLTK.BringToFront();
			}
		}
    }
}
