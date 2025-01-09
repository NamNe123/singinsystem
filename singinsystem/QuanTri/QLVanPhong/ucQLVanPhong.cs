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

namespace singinsystem.QuanTri.QLVanPhong
{
    public partial class ucQLVanPhong : UserControl
    {
		private QLVanPhongManager QLVPManager;
		private string error = "";
		private QLVanPhongEntity QLVPDaChon = new QLVanPhongEntity();
		public ucQLVanPhong()
        {
            InitializeComponent();
            this.QLVPManager = new QLVanPhongManager();
            this.HienThiDanhSachQLVanPhong();
        }
		private void HienThiDanhSachQLVanPhong()
		{
			DataTable dataTable = this.QLVPManager.HienThiDanhSachQLVanPhong(ref this.error);
			bool flag = dataTable == null;
			if (flag)
			{
				MessageBox.Show("Khong co du lieu: " + this.error);
			}
			else
			{
				this.dgDSQLVanPhong.DataSource = dataTable;
			}
		}
		private void btnThem_Click(object sender, EventArgs e)
		{
			bool flag = string.IsNullOrEmpty(this.txtId.Text) || string.IsNullOrEmpty(this.txtTenVP.Text);
			if (flag)
			{
				MessageBox.Show("请输入全部信息 ！");
			}
			else
			{
				QLVanPhongEntity qlvanPhongEntity = new QLVanPhongEntity();
				int id;
				bool flag2 = int.TryParse(this.txtId.Text, out id);
				if (flag2)
				{
					qlvanPhongEntity.Id = id;
					qlvanPhongEntity.Ten = this.txtTenVP.Text;
					bool flag3 = this.QLVPManager.ThemQLVanPhong(qlvanPhongEntity, ref this.error);
					bool flag4 = flag3;
					if (flag4)
					{
						MessageBox.Show("添加成功 ! ");
						this.HienThiDanhSachQLVanPhong();
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
			bool flag = this.QLVPManager.XoaQLVanPhong(this.txtId.Text, ref this.error);
			bool flag2 = flag;
			if (flag2)
			{
				this.HienThiDanhSachQLVanPhong();
			}
			else
			{
				MessageBox.Show(this.error);
			}
		}
		private void btnSua_Click(object sender, EventArgs e)
		{
			bool flag = string.IsNullOrEmpty(this.txtId.Text) || string.IsNullOrEmpty(this.txtTenVP.Text);
			if (flag)
			{
				MessageBox.Show("请输入全部信息 ！");
			}
			else
			{
				QLVanPhongEntity qlvanPhongEntity = new QLVanPhongEntity();
				int id;
				bool flag2 = int.TryParse(this.txtId.Text, out id);
				if (flag2)
				{
					qlvanPhongEntity.Id = id;
					qlvanPhongEntity.Ten = this.txtTenVP.Text;
					bool flag3 = this.QLVPManager.SuaQLVanPhong(qlvanPhongEntity, ref this.error);
					bool flag4 = flag3;
					if (flag4)
					{
						MessageBox.Show("修改成功 ! ");
						this.HienThiDanhSachQLVanPhong();
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
		private void dgDSQLVanPhong_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			bool flag = e.RowIndex >= 0 && e.RowIndex < this.dgDSQLVanPhong.RowCount;
			if (flag)
			{
				DataGridViewRow dataGridViewRow = this.dgDSQLVanPhong.Rows[e.RowIndex];
				this.txtId.Text = dataGridViewRow.Cells["Id"].Value.ToString();
				this.txtTenVP.Text = dataGridViewRow.Cells["Ten"].Value.ToString();
			}
		}

	}
}
