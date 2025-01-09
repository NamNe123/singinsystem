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
    public partial class ucQuanLyTaiKhoan : UserControl
    {
		private TaiKhoanManager manager = null;
		private DataTable dataTaiKhoan = null;
		private string error = "";
		private string QuyenCuaNguoiLogin = "";
		private TaiKhoanEntity TaiKhoanDaChon = new TaiKhoanEntity();
		private int check = 0;
		public ucQuanLyTaiKhoan()
        {
            InitializeComponent();
			this.manager = new TaiKhoanManager();
			this.dataTaiKhoan = new DataTable();
			this.HienThiDanhSachTaiKhoan();
			this.HienThiSoLuongTaiKhoan();
		}
		private void HienThiDanhSachTaiKhoan()
		{
			this.dataTaiKhoan = this.manager.HienThiDanhSachTaiKhoan(ref this.error);
			bool flag = this.dataTaiKhoan == null;
			if (flag)
			{
				MessageBox.Show(this.error);
			}
			else
			{
				this.dgDSTaiKhoan.DataSource = this.dataTaiKhoan;
				bool flag2 = this.dataTaiKhoan.Rows.Count > 0;
				if (flag2)
				{
					DataGridViewRow dataGridViewRow = this.dgDSTaiKhoan.Rows[0];
					this.lblTenDangNhap.Text = dataGridViewRow.Cells["tendangnhap"].Value.ToString();
					this.lblTenDayDu.Text = dataGridViewRow.Cells["tendaydu"].Value.ToString();
					this.lblQuyenDN.Text = dataGridViewRow.Cells["quyen"].Value.ToString();
				}
				for (int i = 0; i < this.dgDSTaiKhoan.RowCount; i++)
				{
					bool flag3 = this.dgDSTaiKhoan.Rows[i].Cells["tendangnhap"].Value.ToString() == clsCauHinhHeThong.TenDangNhap;
					if (flag3)
					{
						this.QuyenCuaNguoiLogin = this.dgDSTaiKhoan.Rows[i].Cells["quyen"].Value.ToString();
					}
				}
			}
		}
		private void HienThiSoLuongTaiKhoan()
		{
			this.lblSoLuong.Text = this.dgDSTaiKhoan.Rows.Count.ToString();
		}
		private void btnSua_Click(object sender, EventArgs e)
		{
			bool flag = this.check == 0;
			if (flag)
			{
				MessageBox.Show("请选择要修改的账号 ！");
			}
			new frmCapNhatTaiKhoan(this.TaiKhoanDaChon, this.QuyenCuaNguoiLogin)
			{
				StartPosition = FormStartPosition.CenterScreen
			}.ShowDialog();
			this.HienThiDanhSachTaiKhoan();
		}
		private void dgDSTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			bool flag = e.RowIndex >= 0 && e.RowIndex < this.dgDSTaiKhoan.RowCount;
			if (flag)
			{
				DataGridViewRow dataGridViewRow = this.dgDSTaiKhoan.Rows[e.RowIndex];
				this.lblTenDangNhap.Text = dataGridViewRow.Cells["tendangnhap"].Value.ToString();
				this.lblTenDayDu.Text = dataGridViewRow.Cells["tendaydu"].Value.ToString();
				this.lblQuyenDN.Text = dataGridViewRow.Cells["quyen"].Value.ToString();
				this.TaiKhoanDaChon.MaQuyen = dataGridViewRow.Cells["quyen"].Value.ToString();
				this.TaiKhoanDaChon.MatKhau = dataGridViewRow.Cells["matkhau"].Value.ToString();
				this.TaiKhoanDaChon.TenDangNhap = dataGridViewRow.Cells["tendangnhap"].Value.ToString();
				this.TaiKhoanDaChon.TenDayDu = dataGridViewRow.Cells["tendaydu"].Value.ToString();
				this.TaiKhoanDaChon.TinhTrang = dataGridViewRow.Cells["tinhtrang"].Value.ToString();
				this.check = 1;
			}
		}
		private void btnXoa_Click(object sender, EventArgs e)
		{
			bool flag = this.manager.XoaTaiKhoan(this.lblTenDangNhap.Text, ref this.error);
			bool flag2 = flag;
			if (flag2)
			{
				this.HienThiDanhSachTaiKhoan();
			}
			else
			{
				MessageBox.Show(this.error);
			}
		}
		private void btnThem_Click(object sender, EventArgs e)
		{
			new frmThemTaiKhoan
			{
				StartPosition = FormStartPosition.CenterScreen
			}.ShowDialog();
			this.HienThiDanhSachTaiKhoan();
		}

	}
}
