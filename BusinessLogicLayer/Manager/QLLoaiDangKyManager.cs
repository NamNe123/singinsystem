using System;
using System.Data;
using DataAccessLayer.Entity;
using DataAccessLayer.Reponsitories;

namespace BusinessLogicLayer.Manager
{
	// Token: 0x02000008 RID: 8
	public class QLLoaiDangKyManager
	{
		// Token: 0x0600001D RID: 29 RVA: 0x0000256F File Offset: 0x0000076F
		public QLLoaiDangKyManager()
		{
			this.process = new QLLoaiDangKyResponsitory();
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00002584 File Offset: 0x00000784
		public DataTable HienThiDanhSachQLLoaiDangKy(ref string error)
		{
			return this.process.HienThiDanhSachQLLoaiDangKy(ref error);
		}

		// Token: 0x0600001F RID: 31 RVA: 0x000025A4 File Offset: 0x000007A4
		public bool XoaQLLoaiDangKy(string TenQLLoaiDangKy, ref string error)
		{
			bool flag = string.IsNullOrEmpty(TenQLLoaiDangKy);
			bool result;
			if (flag)
			{
				error = "Vui lòng chọn bảng giá cần xóa!";
				result = false;
			}
			else
			{
				result = this.process.XoaQLLoaiDangKy(TenQLLoaiDangKy, ref error);
			}
			return result;
		}

		// Token: 0x06000020 RID: 32 RVA: 0x000025DC File Offset: 0x000007DC
		public bool ThemQLLoaiDangKy(QLLoaiDangKyEntity Entity, ref string error)
		{
			bool flag = string.IsNullOrEmpty(Entity.Kieu.ToString());
			bool result;
			if (flag)
			{
				error = "Phai nhap ten nhân sự";
				result = false;
			}
			else
			{
				result = this.process.ThemQLLoaiDangKy(Entity, ref error);
			}
			return result;
		}

		// Token: 0x06000021 RID: 33 RVA: 0x0000261C File Offset: 0x0000081C
		public bool SuaQLLoaiDangKy(QLLoaiDangKyEntity Entity, ref string error)
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
				bool flag2 = string.IsNullOrEmpty(Entity.Kieu);
				if (flag2)
				{
					error = "Phai nhap ten Kiểu đăng ký";
					result = false;
				}
				else
				{
					result = this.process.SuaQLLoaiDangKy(Entity, ref error);
				}
			}
			return result;
		}

		// Token: 0x04000007 RID: 7
		private QLLoaiDangKyResponsitory process;
	}
}
