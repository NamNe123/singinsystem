using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicLayer.Manager;
using DataAccessLayer.Entity;

namespace singinsystem.QuanTri.QLTaiKhoan
{
    public partial class frmCapNhatTaiKhoan : Form
	{
		private TaiKhoanManager TKManager;
		private QuyenDangNhapManager QuyenManager;
		private DataTable QuyenDangNhapData;
		private string error = "";
		private TaiKhoanEntity TAIKHOANduocchon;
		private string QuyenLogin = "";
		public frmCapNhatTaiKhoan(TaiKhoanEntity taikhoanduocchon, string quyenlogin)
		{
			this.InitializeComponent();
			this.QuyenManager = new QuyenDangNhapManager();
			this.QuyenDangNhapData = new DataTable();
			this.TKManager = new TaiKhoanManager();
			this.HienThiQuyenNguoiNguoi();
			this.TAIKHOANduocchon = taikhoanduocchon;
			this.txtTenDangNhap.Text = this.TAIKHOANduocchon.TenDangNhap;
			this.txtTenDayDu.Text = this.TAIKHOANduocchon.TenDayDu;
			this.cboQuyenDangNhap.SelectedValue = this.TAIKHOANduocchon.MaQuyen;
			this.radSuDung.Checked = (this.TAIKHOANduocchon.TinhTrang == "Y");
			this.QuyenLogin = quyenlogin;
		}
		private void HienThiQuyenNguoiNguoi()
		{
			DataTable dataTable = this.QuyenManager.HienThiDanhSachQuyenDangNhap(ref this.error);
			bool flag = dataTable == null;
			if (flag)
			{
				MessageBox.Show(this.error);
			}
			else
			{
				this.QuyenDangNhapData = dataTable;
				this.cboQuyenDangNhap.DataSource = this.QuyenDangNhapData;
				this.cboQuyenDangNhap.DisplayMember = "MoTa";
				this.cboQuyenDangNhap.ValueMember = "MaQuyen";
			}
		}
		private void btnThoat_Click(object sender, EventArgs e)
		{
			base.Close();
		}
		private void btnCapNhat_Click(object sender, EventArgs e)
		{
			bool flag = this.QuyenLogin == "A";
			if (flag)
			{
				bool flag2 = string.IsNullOrEmpty(this.txtMatKhauMoi.Text) || this.txtMatKhauMoi.Text != this.txtNhapLaiMK.Text;
				if (flag2)
				{
					MessageBox.Show("密码错误 !");
					return;
				}
			}
			else
			{
				bool flag3 = clsCauHinhHeThong.TenDangNhap != this.txtTenDangNhap.Text || string.IsNullOrEmpty(this.txtMatKhauMoi.Text) || this.txtMatKhauMoi.Text != this.txtNhapLaiMK.Text;
				if (flag3)
				{
					MessageBox.Show("再检查要改的账号 ！");
					return;
				}
			}
			this.TAIKHOANduocchon.MatKhau = this.txtMatKhauMoi.Text.Replace(" ", "");
			this.TAIKHOANduocchon.TenDayDu = this.txtTenDayDu.Text.Trim();
			this.TAIKHOANduocchon.MaQuyen = this.cboQuyenDangNhap.SelectedValue.ToString();
			this.TAIKHOANduocchon.TinhTrang = (this.radSuDung.Checked ? "Y" : "N");
			this.TAIKHOANduocchon.NguoiTao = clsCauHinhHeThong.TenDangNhap;
			bool flag4 = this.TKManager.SuaTaiKhoan(this.TAIKHOANduocchon, ref this.error);
			bool flag5 = flag4;
			if (flag5)
			{
				MessageBox.Show("更新成功 ！");
				base.Close();
			}
			else
			{
				MessageBox.Show("Loi: " + this.error);
			}
		}
		private void frmCapNhatTaiKhoan_Load(object sender, EventArgs e)
		{
		}

	}
}
