using System;
using System.Data;
using DataAccessLayer.Entity;
using DataAccessLayer.Reponsitories;

namespace BusinessLogicLayer.Manager
{
	// Token: 0x02000003 RID: 3
	public class BangGiaManager
	{
		// Token: 0x06000006 RID: 6 RVA: 0x00002151 File Offset: 0x00000351
		public BangGiaManager()
		{
			this.process = new BangGiaResponsitory();
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002168 File Offset: 0x00000368
		public DataTable HienThiDanhSachBangGia(ref string error)
		{
			return this.process.HienThiDanhSachBangGia(ref error);
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002188 File Offset: 0x00000388
		public bool XoaBangGia(string TenBangGia, ref string error)
		{
			bool flag = string.IsNullOrEmpty(TenBangGia);
			bool result;
			if (flag)
			{
				error = "Vui lòng chọn bảng giá cần xóa!";
				result = false;
			}
			else
			{
				result = this.process.XoaBangGia(TenBangGia, ref error);
			}
			return result;
		}

		// Token: 0x06000009 RID: 9 RVA: 0x000021C0 File Offset: 0x000003C0
		public bool ThemBangGia(BangGiaEntity Entity, ref string error)
		{
			bool flag = string.IsNullOrEmpty(Entity.TenBangGia);
			bool result;
			if (flag)
			{
				error = "Phai nhap ten bảng giá";
				result = false;
			}
			else
			{
				result = this.process.ThemBangGia(Entity, ref error);
			}
			return result;
		}

		// Token: 0x0600000A RID: 10 RVA: 0x000021FC File Offset: 0x000003FC
		public bool SuaBangGia(BangGiaEntity Entity, ref string error)
		{
			bool flag = string.IsNullOrEmpty(Entity.MaBangGia);
			bool result;
			if (flag)
			{
				error = "Phai nhap ten don vi tinh";
				result = false;
			}
			else
			{
				bool flag2 = string.IsNullOrEmpty(Entity.TenBangGia);
				if (flag2)
				{
					error = "Phai nhap ten don vi tinh";
					result = false;
				}
				else
				{
					result = this.process.SuaBangGia(Entity, ref error);
				}
			}
			return result;
		}

		// Token: 0x04000002 RID: 2
		private BangGiaResponsitory process;
	}
}
