using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using singinsystem.Login;
using singinsystem.QLXuongCa;
using singinsystem.QLDangKyVao;
using singinsystem.QLDiLai;
using singinsystem.QLDiLam;
using singinsystem.QLQuanTri;
using singinsystem.QLTaiKhoan;

namespace singinsystem.MainForm
{
	// Token: 0x0200001A RID: 26
	public partial class frmMainForm : Form
	{
		// Token: 0x060000B3 RID: 179 RVA: 0x000185CC File Offset: 0x000167CC
		public frmMainForm()
		{
			this.InitializeComponent();
			this.Text = "User: " + clsCauHinhHeThong.TenDangNhap + " Login: " + DateTime.Now.ToString("hh:mm:ss dd.MM.yyyy");
			this.btnDiLam.BackColor = Color.Red;
			this.btnDiLam.ForeColor = Color.White;
			this.btnDangKyVao.BackColor = Color.White;
			this.btnDangKyVao.ForeColor = Color.Blue;
			this.btnQLXuongCa.BackColor = Color.White;
			this.btnQLXuongCa.ForeColor = Color.Blue;
			this.btnQLDangKy.BackColor = Color.White;
			this.btnQLDangKy.ForeColor = Color.Blue;
			this.btnQuanTri.BackColor = Color.White;
			this.btnQuanTri.ForeColor = Color.Blue;
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x000186D0 File Offset: 0x000168D0
		public frmMainForm(string TenDangNhap)
		{
			this.InitializeComponent();
			this.Text = "User: " + TenDangNhap + " login: " + DateTime.Now.ToString("hh:mm:ss dd.MM.yyyy");
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x0000383A File Offset: 0x00001A3A
		private void label1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x0000383A File Offset: 0x00001A3A
		private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x00018723 File Offset: 0x00016923
		private void frmMainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x0001872C File Offset: 0x0001692C
		private void btnMenuTaiKhoan_Click(object sender, EventArgs e)
		{
			bool flag = !this.pnMain.Controls.Contains(this.ucQLTK);
			if (flag)
			{
				this.ucQLTK = new ucQuanLyTaiKhoan();
				this.ucQLTK.Dock = DockStyle.Fill;
				this.pnMain.Controls.Add(this.ucQLTK);
				this.ucQLTK.BringToFront();
			}
			else
			{
				this.ucQLTK.BringToFront();
			}
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x0000383A File Offset: 0x00001A3A
		private void button4_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060000BA RID: 186 RVA: 0x000187A4 File Offset: 0x000169A4
		private void btnDiLam_Click(object sender, EventArgs e)
		{
			this.btnDiLam.BackColor = Color.Red;
			this.btnDiLam.ForeColor = Color.White;
			this.btnDangKyVao.BackColor = Color.White;
			this.btnDangKyVao.ForeColor = Color.Blue;
			this.btnQLXuongCa.BackColor = Color.White;
			this.btnQLXuongCa.ForeColor = Color.Blue;
			this.btnQLDangKy.BackColor = Color.White;
			this.btnQLDangKy.ForeColor = Color.Blue;
			this.btnQuanTri.BackColor = Color.White;
			this.btnQuanTri.ForeColor = Color.Blue;
			bool flag = !this.pnMain.Controls.Contains(this.ucQLDL);
			if (flag)
			{
				this.ucQLDL = new ucQLDiLam();
				this.ucQLDL.Dock = DockStyle.Fill;
				this.pnMain.Controls.Add(this.ucQLDL);
				this.ucQLDL.BringToFront();
			}
			else
			{
				this.ucQLDL.HienThiDuLieuVao_combo_NhanSu();
				this.ucQLDL.HienThiDanhSachQLQuyDinh();
				this.ucQLDL.HienThiVanPhong();
				this.ucQLDL.BringToFront();
			}
		}

		// Token: 0x060000BB RID: 187 RVA: 0x000188EC File Offset: 0x00016AEC
		private void btnDangKyVao_Click(object sender, EventArgs e)
		{
			this.btnDangKyVao.BackColor = Color.Red;
			this.btnDangKyVao.ForeColor = Color.White;
			this.btnDiLam.BackColor = Color.White;
			this.btnDiLam.ForeColor = Color.Blue;
			this.btnQLXuongCa.BackColor = Color.White;
			this.btnQLXuongCa.ForeColor = Color.Blue;
			this.btnQLDangKy.BackColor = Color.White;
			this.btnQLDangKy.ForeColor = Color.Blue;
			this.btnQuanTri.BackColor = Color.White;
			this.btnQuanTri.ForeColor = Color.Blue;
			bool flag = !this.pnMain.Controls.Contains(this.ucQLDKV);
			if (flag)
			{
				this.ucQLDKV = new ucQLDangKyVao();
				this.ucQLDKV.Dock = DockStyle.Fill;
				this.pnMain.Controls.Add(this.ucQLDKV);
				this.ucQLDKV.BringToFront();
			}
			else
			{
				this.ucQLDKV.HienThiVanPhong();
				this.ucQLDKV.HienThiDanhSachQLQuyDinh();
				this.ucQLDKV.HienThiDuLieuVao_combo_LoaiDangKy();
				this.ucQLDKV.HienThiDuLieuVao_combo_NhanSu();
				this.ucQLDKV.BringToFront();
			}
		}

		// Token: 0x060000BC RID: 188 RVA: 0x00018A40 File Offset: 0x00016C40
		private void btnKyLuc_Click(object sender, EventArgs e)
		{
			this.btnQLDangKy.BackColor = Color.Red;
			this.btnQLDangKy.ForeColor = Color.White;
			this.btnDiLam.BackColor = Color.White;
			this.btnDiLam.ForeColor = Color.Blue;
			this.btnQLXuongCa.BackColor = Color.White;
			this.btnQLXuongCa.ForeColor = Color.Blue;
			this.btnDangKyVao.BackColor = Color.White;
			this.btnDangKyVao.ForeColor = Color.Blue;
			this.btnQuanTri.BackColor = Color.White;
			this.btnQuanTri.ForeColor = Color.Blue;
			bool flag = !this.pnMain.Controls.Contains(this.ucQLDLA);
			if (flag)
			{
				this.ucQLDLA = new ucQLDiLai();
				this.ucQLDLA.Dock = DockStyle.Fill;
				this.pnMain.Controls.Add(this.ucQLDLA);
				this.ucQLDLA.BringToFront();
			}
			else
			{
				this.ucQLDLA.HienThiDuLieuVao_combo_LoaiDangKy();
				this.ucQLDLA.HienThiDuLieuVao_combo_NhanSu();
				this.ucQLDLA.BringToFront();
			}
		}

		// Token: 0x060000BD RID: 189 RVA: 0x00018B7C File Offset: 0x00016D7C
		private void btnQuanTri_Click(object sender, EventArgs e)
		{
			this.btnQuanTri.BackColor = Color.Red;
			this.btnQuanTri.ForeColor = Color.White;
			this.btnDiLam.BackColor = Color.White;
			this.btnDiLam.ForeColor = Color.Blue;
			this.btnQLXuongCa.BackColor = Color.White;
			this.btnQLXuongCa.ForeColor = Color.Blue;
			this.btnDangKyVao.BackColor = Color.White;
			this.btnDangKyVao.ForeColor = Color.Blue;
			this.btnQLDangKy.BackColor = Color.White;
			this.btnQLDangKy.ForeColor = Color.Blue;
			frmLoginAdmin frmLoginAdmin = new frmLoginAdmin();
			frmLoginAdmin.ShowDialog();
			int kiemTra = frmLoginAdmin.LuuThongTin.KiemTra;
			bool flag = kiemTra == 1;
			if (flag)
			{
				bool flag2 = !this.pnMain.Controls.Contains(this.ucQLQT);
				if (flag2)
				{
					this.ucQLQT = new ucQLQuanTri();
					this.ucQLQT.Dock = DockStyle.Fill;
					this.pnMain.Controls.Add(this.ucQLQT);
					this.ucQLQT.BringToFront();
				}
				else
				{
					this.ucQLQT.BringToFront();
				}
				frmLoginAdmin.LuuThongTin.KiemTra = 0;
			}
		}

		// Token: 0x060000BE RID: 190 RVA: 0x00018CC4 File Offset: 0x00016EC4
		private void frmMainForm_Load(object sender, EventArgs e)
		{
			bool flag = !this.pnMain.Controls.Contains(this.ucQLDL);
			if (flag)
			{
				this.ucQLDL = new ucQLDiLam();
				this.ucQLDL.Dock = DockStyle.Fill;
				this.pnMain.Controls.Add(this.ucQLDL);
				this.ucQLDL.BringToFront();
			}
			else
			{
				this.ucQLDL.BringToFront();
			}
		}

		// Token: 0x060000BF RID: 191 RVA: 0x00018D3C File Offset: 0x00016F3C
		private void btnQLXuongCa_Click(object sender, EventArgs e)
		{
			this.btnQLXuongCa.BackColor = Color.Red;
			this.btnQLXuongCa.ForeColor = Color.White;
			this.btnDangKyVao.BackColor = Color.White;
			this.btnDangKyVao.ForeColor = Color.Blue;
			this.btnDiLam.BackColor = Color.White;
			this.btnDiLam.ForeColor = Color.Blue;
			this.btnQLDangKy.BackColor = Color.White;
			this.btnQLDangKy.ForeColor = Color.Blue;
			this.btnQuanTri.BackColor = Color.White;
			this.btnQuanTri.ForeColor = Color.Blue;
			bool flag = !this.pnMain.Controls.Contains(this.ucQLXC);
			if (flag)
			{
				this.ucQLXC = new ucQLXuongCa();
				this.ucQLXC.Dock = DockStyle.Fill;
				this.pnMain.Controls.Add(this.ucQLXC);
				this.ucQLXC.BringToFront();
			}
			else
			{
				this.ucQLXC.HienThiDuLieuVao_combo_NhanSu();
				this.ucQLXC.BringToFront();
			}
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x00018E6C File Offset: 0x0001706C
		private void button1_Click(object sender, EventArgs e)
		{
			bool flag = this.checkhienthi == 0;
			if (flag)
			{
				this.checkhienthi = 1;
				frmMainForm.LuuThongTin.CheckHienThi = 1;
				bool flag2 = this.pnMain.Controls.Contains(this.ucQLXC);
				if (flag2)
				{
					this.ucQLXC.HienThiDanhSachQLXuongCa();
				}
				bool flag3 = this.pnMain.Controls.Contains(this.ucQLDL);
				if (flag3)
				{
					this.ucQLDL.HienThiDanhSachQLDiLam();
				}
				bool flag4 = this.pnMain.Controls.Contains(this.ucQLDLA);
				if (flag4)
				{
					this.ucQLDLA.HienThiDanhSachQLDiLai();
				}
				bool flag5 = this.pnMain.Controls.Contains(this.ucQLDKV);
				if (flag5)
				{
					this.ucQLDKV.HienThiDanhSachQLDangKyVao();
				}
			}
			else
			{
				frmMainForm.LuuThongTin.CheckHienThi = 0;
				this.checkhienthi = 0;
				bool flag6 = this.pnMain.Controls.Contains(this.ucQLXC);
				if (flag6)
				{
					this.ucQLXC.HienThiDanhSachQLXuongCa();
				}
				bool flag7 = this.pnMain.Controls.Contains(this.ucQLDL);
				if (flag7)
				{
					this.ucQLDL.HienThiDanhSachQLDiLam();
				}
				bool flag8 = this.pnMain.Controls.Contains(this.ucQLDLA);
				if (flag8)
				{
					this.ucQLDLA.HienThiDanhSachQLDiLai();
				}
				bool flag9 = this.pnMain.Controls.Contains(this.ucQLDKV);
				if (flag9)
				{
					this.ucQLDKV.HienThiDanhSachQLDangKyVao();
				}
			}
		}

		// Token: 0x040001A7 RID: 423
		private ucQuanLyTaiKhoan ucQLTK;

		// Token: 0x040001A8 RID: 424
		private ucQLDiLam ucQLDL;

		// Token: 0x040001A9 RID: 425
		private ucQLDangKyVao ucQLDKV;

		// Token: 0x040001AA RID: 426
		private ucQLDiLai ucQLDLA;

		// Token: 0x040001AB RID: 427
		private ucQLQuanTri ucQLQT;

		// Token: 0x040001AC RID: 428
		private ucQLXuongCa ucQLXC;

		// Token: 0x040001AD RID: 429
		private int checkhienthi = 0;

		// Token: 0x0200003C RID: 60
		public class LuuThongTin
		{
			// Token: 0x040001F5 RID: 501
			public static int CheckHienThi;
		}
	}
}
