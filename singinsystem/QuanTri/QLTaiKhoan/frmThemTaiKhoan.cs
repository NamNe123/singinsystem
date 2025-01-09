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
    public partial class frmThemTaiKhoan : Form
	{
		private TaiKhoanManager TKManager;
		private QuyenDangNhapManager QuyenManager;
		private DataTable QuyenDangNhapData;
		private string error = "";
		public frmThemTaiKhoan()
        {
            InitializeComponent();
            this.QuyenManager = new QuyenDangNhapManager();
            this.QuyenDangNhapData = new DataTable();
            this.TKManager = new TaiKhoanManager();
            this.HienThiQuyenNguoiNguoi();
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
		private void btnThem_Click(object sender, EventArgs e)
		{
			bool flag = this.txtMatKhau.Text != this.txtNhapLaiMK.Text;
			if (flag)
			{
				MessageBox.Show("密码不一致 ！");
			}
			else
			{
				TaiKhoanEntity taiKhoanEntity = new TaiKhoanEntity();
				taiKhoanEntity.TenDangNhap = this.txtTenDangNhap.Text.Replace(" ", "");
				taiKhoanEntity.MatKhau = this.txtMatKhau.Text.Replace(" ", "");
				taiKhoanEntity.TenDayDu = this.txtTenDayDu.Text.Trim();
				taiKhoanEntity.MaQuyen = this.cboQuyenDangNhap.SelectedValue.ToString();
				taiKhoanEntity.NguoiTao = clsCauHinhHeThong.TenDangNhap;
				bool flag2 = this.TKManager.ThemTaiKhoan(taiKhoanEntity, ref this.error);
				bool flag3 = flag2;
				if (flag3)
				{
					MessageBox.Show("添加成功 ! ");
					base.Close();
				}
				else
				{
					MessageBox.Show("Loi: " + this.error);
				}
			}
		}

	}
}
