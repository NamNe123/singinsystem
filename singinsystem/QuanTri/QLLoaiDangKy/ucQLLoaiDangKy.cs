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

namespace singinsystem.QuanTri.QLLoaiDangKy
{
    public partial class ucQLLoaiDangKy : UserControl
	{
		private QLLoaiDangKyManager QLLDKManager;
		private string error = "";
		public ucQLLoaiDangKy()
        {
            InitializeComponent();
            this.QLLDKManager = new QLLoaiDangKyManager();
            this.HienThiDanhSachQLLoaiDangKy();
        }
		private void HienThiDanhSachQLLoaiDangKy()
		{
			DataTable dataTable = this.QLLDKManager.HienThiDanhSachQLLoaiDangKy(ref this.error);
			bool flag = dataTable == null;
			if (flag)
			{
				MessageBox.Show("Khong co du lieu: " + this.error);
			}
			else
			{
				this.dgDSQLLoaiDangKy.DataSource = dataTable;
			}
		}
		private void btnThem_Click(object sender, EventArgs e)
		{
			bool flag = string.IsNullOrEmpty(this.txtId.Text) || string.IsNullOrEmpty(this.txtKieu.Text) || string.IsNullOrEmpty(this.txtSoLan.Text) || string.IsNullOrEmpty(this.txtThoiGian.Text);
			if (flag)
			{
				MessageBox.Show("请输入全部信息 ！");
			}
			else
			{
				QLLoaiDangKyEntity qlloaiDangKyEntity = new QLLoaiDangKyEntity();
				int id;
				bool flag2 = int.TryParse(this.txtId.Text, out id);
				if (flag2)
				{
					qlloaiDangKyEntity.Id = id;
					qlloaiDangKyEntity.Kieu = this.txtKieu.Text;
					int soLan;
					int.TryParse(this.txtSoLan.Text, out soLan);
					qlloaiDangKyEntity.SoLan = soLan;
					int thoiGian;
					int.TryParse(this.txtThoiGian.Text, out thoiGian);
					qlloaiDangKyEntity.ThoiGian = thoiGian;
					bool flag3 = this.QLLDKManager.ThemQLLoaiDangKy(qlloaiDangKyEntity, ref this.error);
					bool flag4 = flag3;
					if (flag4)
					{
						MessageBox.Show("添加成功 ! ");
						this.HienThiDanhSachQLLoaiDangKy();
					}
					else
					{
						MessageBox.Show("添加失败 ! ");
					}
				}
				else
				{
					MessageBox.Show("ID必须是数号 !", "错误 ！", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				}
			}
		}
		private void btnXoa_Click(object sender, EventArgs e)
		{
			bool flag = this.QLLDKManager.XoaQLLoaiDangKy(this.txtId.Text, ref this.error);
			bool flag2 = flag;
			if (flag2)
			{
				this.HienThiDanhSachQLLoaiDangKy();
			}
			else
			{
				MessageBox.Show(this.error);
			}
		}
		private void btnSua_Click(object sender, EventArgs e)
		{
			bool flag = string.IsNullOrEmpty(this.txtId.Text) || string.IsNullOrEmpty(this.txtKieu.Text) || string.IsNullOrEmpty(this.txtSoLan.Text) || string.IsNullOrEmpty(this.txtThoiGian.Text);
			if (flag)
			{
				MessageBox.Show("请输入全部信息 ！");
			}
			else
			{
				QLLoaiDangKyEntity qlloaiDangKyEntity = new QLLoaiDangKyEntity();
				int id;
				bool flag2 = int.TryParse(this.txtId.Text, out id);
				if (flag2)
				{
					qlloaiDangKyEntity.Id = id;
					qlloaiDangKyEntity.Kieu = this.txtKieu.Text;
					int soLan;
					int.TryParse(this.txtSoLan.Text, out soLan);
					qlloaiDangKyEntity.SoLan = soLan;
					int thoiGian;
					int.TryParse(this.txtThoiGian.Text, out thoiGian);
					qlloaiDangKyEntity.ThoiGian = thoiGian;
					bool flag3 = this.QLLDKManager.SuaQLLoaiDangKy(qlloaiDangKyEntity, ref this.error);
					bool flag4 = flag3;
					if (flag4)
					{
						MessageBox.Show("修改成功 ! ");
						this.HienThiDanhSachQLLoaiDangKy();
					}
					else
					{
						MessageBox.Show("修改失败 ! ");
					}
				}
				else
				{
					MessageBox.Show("ID必须是数号 !", "错误 ！", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				}
			}
		}
		private void dgDSQLLoaiDangKy_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			bool flag = e.RowIndex >= 0 && e.RowIndex < this.dgDSQLLoaiDangKy.RowCount;
			if (flag)
			{
				DataGridViewRow dataGridViewRow = this.dgDSQLLoaiDangKy.Rows[e.RowIndex];
				this.txtId.Text = dataGridViewRow.Cells["Id"].Value.ToString();
				this.txtKieu.Text = dataGridViewRow.Cells["Kieu"].Value.ToString();
				this.txtThoiGian.Text = dataGridViewRow.Cells["ThoiGian"].Value.ToString();
				this.txtSoLan.Text = dataGridViewRow.Cells["SoLan"].Value.ToString();
			}
		}

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
