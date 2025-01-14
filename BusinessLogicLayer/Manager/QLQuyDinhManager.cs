using System;
using System.Data;
using DataAccessLayer.Entity;
using DataAccessLayer.Reponsitories;

namespace BusinessLogicLayer.Manager
{
	// Token: 0x0200000A RID: 10
	public class QLQuyDinhManager
	{
		// Token: 0x06000028 RID: 40 RVA: 0x000027B9 File Offset: 0x000009B9
		public QLQuyDinhManager()
		{
			this.process = new QLQuyDinhResponsitory();
		}

		// Token: 0x06000029 RID: 41 RVA: 0x000027D0 File Offset: 0x000009D0
		public DataTable HienThiDanhSachQLQuyDinh(ref string error)
		{
			return this.process.HienThiDanhSachQLQuyDinh(ref error);
		}

		// Token: 0x0600002A RID: 42 RVA: 0x000027F0 File Offset: 0x000009F0
		public DataTable HienThiDanhSachQLQuyDinhMainDiLam(ref string error)
		{
			return this.process.HienThiDanhSachQLQuyDinhMainDiLam(ref error);
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00002810 File Offset: 0x00000A10
		public DataTable HienThiDanhSachQLQuyDinhMain(ref string error)
		{
			return this.process.HienThiDanhSachQLQuyDinhMain(ref error);
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00002830 File Offset: 0x00000A30
		public bool XoaQLQuyDinh(string TenQLQuyDinh, ref string error)
		{
			bool flag = string.IsNullOrEmpty(TenQLQuyDinh);
			bool result;
			if (flag)
			{
				error = "请选择规定!";
				result = false;
			}
			else
			{
				result = this.process.XoaQLQuyDinh(TenQLQuyDinh, ref error);
			}
			return result;
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00002868 File Offset: 0x00000A68
		public bool ThemQLQuyDinh(QLQuyDinhEntity Entity, ref string error)
		{
			bool flag = string.IsNullOrEmpty(Entity.Kieu.ToString());
			bool result;
			if (flag)
			{
				error = "请输入规定!";
				result = false;
			}
			else
			{
				result = this.process.ThemQLQuyDinh(Entity, ref error);
			}
			return result;
		}

		// Token: 0x0600002E RID: 46 RVA: 0x000028A8 File Offset: 0x00000AA8
		public bool SuaQLQuyDinh(QLQuyDinhEntity Entity, ref string error)
		{
			bool flag = string.IsNullOrEmpty(Entity.Id.ToString());
			bool result;
			if (flag)
			{
				error = "输入ID!";
				result = false;
			}
			else
			{
				bool flag2 = string.IsNullOrEmpty(Entity.Kieu);
				if (flag2)
				{
					error = "请输入打卡类型!";
					result = false;
				}
				else
				{
					result = this.process.SuaQLQuyDinh(Entity, ref error);
				}
			}
			return result;
		}
		public bool ImportQLQuyDinh(DataTable dataTable, ref string error)
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
				result = this.process.ImportQLQuyDinh(dataTable, ref error);
			}
			return result;
		}
		// Token: 0x04000009 RID: 9
		private QLQuyDinhResponsitory process;
	}
}
