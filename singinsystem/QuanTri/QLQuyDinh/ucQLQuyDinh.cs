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

namespace singinsystem.QuanTri.QLQuyDinh
{
    public partial class ucQLQuyDinh : UserControl
	{
		private QLQuyDinhManager QLQDManager;
		private string error = "";
		public ucQLQuyDinh()
        {
            InitializeComponent();
            this.QLQDManager = new QLQuyDinhManager();
            this.HienThiDanhSachQLQuyDinh();
        }
		private void HienThiDanhSachQLQuyDinh()
		{
			DataTable dataTable = this.QLQDManager.HienThiDanhSachQLQuyDinh(ref this.error);
			bool flag = dataTable == null;
			if (flag)
			{
				MessageBox.Show("Khong co du lieu: " + this.error);
			}
			else
			{
				this.dgDSQLQuyDinh.DataSource = dataTable;
			}
		}
		private void btnThem_Click(object sender, EventArgs e)
		{
			bool flag = string.IsNullOrEmpty(this.txtId.Text) || string.IsNullOrEmpty(this.txtQuyDinh.Text) || string.IsNullOrEmpty(this.txtDiemBiTru.Text) || string.IsNullOrEmpty(this.cbKieu.Text);
			if (flag)
			{
				MessageBox.Show("请输入全部信息 ！");
			}
			else
			{
				QLQuyDinhEntity qlquyDinhEntity = new QLQuyDinhEntity();
				int id;
				bool flag2 = int.TryParse(this.txtId.Text, out id);
				if (flag2)
				{
					qlquyDinhEntity.Id = id;
					qlquyDinhEntity.QuyDinh = this.txtQuyDinh.Text;
					int diemBiTru;
					int.TryParse(this.txtDiemBiTru.Text, out diemBiTru);
					qlquyDinhEntity.DiemBiTru = diemBiTru;
					qlquyDinhEntity.Kieu = this.cbKieu.Text;
					bool flag3 = this.QLQDManager.ThemQLQuyDinh(qlquyDinhEntity, ref this.error);
					bool flag4 = flag3;
					if (flag4)
					{
						MessageBox.Show("添加成功 ! ");
						this.HienThiDanhSachQLQuyDinh();
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
			bool flag = this.QLQDManager.XoaQLQuyDinh(this.txtId.Text, ref this.error);
			bool flag2 = flag;
			if (flag2)
			{
				this.HienThiDanhSachQLQuyDinh();
			}
			else
			{
				MessageBox.Show(this.error);
			}
		}
		private void btnSua_Click(object sender, EventArgs e)
		{
			bool flag = string.IsNullOrEmpty(this.txtId.Text) || string.IsNullOrEmpty(this.txtQuyDinh.Text) || string.IsNullOrEmpty(this.txtDiemBiTru.Text) || string.IsNullOrEmpty(this.cbKieu.Text);
			if (flag)
			{
				MessageBox.Show("请输入全部信息 ！");
			}
			else
			{
				QLQuyDinhEntity qlquyDinhEntity = new QLQuyDinhEntity();
				int id;
				bool flag2 = int.TryParse(this.txtId.Text, out id);
				if (flag2)
				{
					qlquyDinhEntity.Id = id;
					qlquyDinhEntity.QuyDinh = this.txtQuyDinh.Text;
					int diemBiTru;
					int.TryParse(this.txtDiemBiTru.Text, out diemBiTru);
					qlquyDinhEntity.DiemBiTru = diemBiTru;
					qlquyDinhEntity.Kieu = this.cbKieu.Text;
					bool flag3 = this.QLQDManager.SuaQLQuyDinh(qlquyDinhEntity, ref this.error);
					bool flag4 = flag3;
					if (flag4)
					{
						MessageBox.Show("修改成功 ! ");
						this.HienThiDanhSachQLQuyDinh();
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
		private void dgDSQLQuyDinh_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			bool flag = e.RowIndex >= 0 && e.RowIndex < this.dgDSQLQuyDinh.RowCount;
			if (flag)
			{
				DataGridViewRow dataGridViewRow = this.dgDSQLQuyDinh.Rows[e.RowIndex];
				this.txtId.Text = dataGridViewRow.Cells["Id"].Value.ToString();
				this.txtQuyDinh.Text = dataGridViewRow.Cells["QuyDinh"].Value.ToString();
				this.txtDiemBiTru.Text = dataGridViewRow.Cells["DiemBiTru"].Value.ToString();
				this.cbKieu.Text = dataGridViewRow.Cells["Kieu"].Value.ToString();
			}
		}

	}
}
