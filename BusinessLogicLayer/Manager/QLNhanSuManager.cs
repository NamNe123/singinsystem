using System;
using System.Data;
using DataAccessLayer.Entity;
using DataAccessLayer.Reponsitories;

namespace BusinessLogicLayer.Manager
{
	// Token: 0x02000009 RID: 9
	public class QLNhanSuManager
	{
		// Token: 0x06000022 RID: 34 RVA: 0x00002679 File Offset: 0x00000879
		public QLNhanSuManager()
		{
			this.process = new QLNhanSuResponsitory();
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00002690 File Offset: 0x00000890
		public DataTable HienThiDanhSachQLNhanSu(ref string error)
		{
			return this.process.HienThiDanhSachQLNhanSu(ref error);
		}

		// Token: 0x06000024 RID: 36 RVA: 0x000026B0 File Offset: 0x000008B0
		public bool XoaQLNhanSu(string TenQLNhanSu, ref string error)
		{
			bool flag = string.IsNullOrEmpty(TenQLNhanSu);
			bool result;
			if (flag)
			{
				error = "Vui lòng chọn bảng giá cần xóa!";
				result = false;
			}
			else
			{
				result = this.process.XoaQLNhanSu(TenQLNhanSu, ref error);
			}
			return result;
		}

		// Token: 0x06000025 RID: 37 RVA: 0x000026E8 File Offset: 0x000008E8
		public bool ThemQLNhanSu(QLNhanSuEntity Entity, ref string error)
		{
			bool flag = string.IsNullOrEmpty(Entity.Ten.ToString());
			bool result;
			if (flag)
			{
				error = "Phai nhap ten nhân sự";
				result = false;
			}
			else
			{
				result = this.process.ThemQLNhanSu(Entity, ref error);
			}
			return result;
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00002728 File Offset: 0x00000928
		public bool ImportQLNhanSu(DataTable dataTable, ref string error)
		{
			bool flag = dataTable == null;
			bool result;
			if (flag)
			{
				error = "Phai nhap ten nhân sự";
				result = false;
			}
			else
			{
				result = this.process.ImportQLNhanSu(dataTable, ref error);
			}
			return result;
		}

		// Token: 0x06000027 RID: 39 RVA: 0x0000275C File Offset: 0x0000095C
		public bool SuaQLNhanSu(QLNhanSuEntity Entity, ref string error)
		{
			bool flag = string.IsNullOrEmpty(Entity.Id.ToString());
			bool result;
			if (flag)
			{
				error = "Phai nhap Id";
				result = false;
			}
			else
			{
				bool flag2 = string.IsNullOrEmpty(Entity.Ten);
				if (flag2)
				{
					error = "Phai nhap ten nhân sự";
					result = false;
				}
				else
				{
					result = this.process.SuaQLNhanSu(Entity, ref error);
				}
			}
			return result;
		}

		// Token: 0x04000008 RID: 8
		private QLNhanSuResponsitory process;
	}
}
