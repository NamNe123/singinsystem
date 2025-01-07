using System;
using System.Data;
using DataAccessLayer.Entity;
using DataAccessLayer.Reponsitories;

namespace BusinessLogicLayer.Manager
{
	// Token: 0x0200000B RID: 11
	public class QLVanPhongManager
	{
		// Token: 0x0600002F RID: 47 RVA: 0x00002905 File Offset: 0x00000B05
		public QLVanPhongManager()
		{
			this.process = new QLVanPhongResponsitory();
		}

		// Token: 0x06000030 RID: 48 RVA: 0x0000291C File Offset: 0x00000B1C
		public DataTable HienThiDanhSachQLVanPhong(ref string error)
		{
			return this.process.HienThiDanhSachQLVanPhong(ref error);
		}

		// Token: 0x06000031 RID: 49 RVA: 0x0000293C File Offset: 0x00000B3C
		public DataTable LayTenQLVanPhong(ref string error)
		{
			return this.process.LayTenQLVanPhong(ref error);
		}

		// Token: 0x06000032 RID: 50 RVA: 0x0000295C File Offset: 0x00000B5C
		public bool XoaQLVanPhong(string TenQLVanPhong, ref string error)
		{
			bool flag = string.IsNullOrEmpty(TenQLVanPhong);
			bool result;
			if (flag)
			{
				error = "请选择办公室!";
				result = false;
			}
			else
			{
				result = this.process.XoaQLVanPhong(TenQLVanPhong, ref error);
			}
			return result;
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00002994 File Offset: 0x00000B94
		public bool ThemQLVanPhong(QLVanPhongEntity Entity, ref string error)
		{
			bool flag = string.IsNullOrEmpty(Entity.Ten.ToString());
			bool result;
			if (flag)
			{
				error = "请输入办公室名称";
				result = false;
			}
			else
			{
				result = this.process.ThemQLVanPhong(Entity, ref error);
			}
			return result;
		}

		// Token: 0x06000034 RID: 52 RVA: 0x000029D4 File Offset: 0x00000BD4
		public bool SuaQLVanPhong(QLVanPhongEntity Entity, ref string error)
		{
			bool flag = string.IsNullOrEmpty(Entity.Id.ToString());
			bool result;
			if (flag)
			{
				error = "输入ID";
				result = false;
			}
			else
			{
				bool flag2 = string.IsNullOrEmpty(Entity.Ten);
				if (flag2)
				{
					error = "必须输入办公室名称";
					result = false;
				}
				else
				{
					result = this.process.SuaQLVanPhong(Entity, ref error);
				}
			}
			return result;
		}

		// Token: 0x0400000A RID: 10
		private QLVanPhongResponsitory process;
	}
}
