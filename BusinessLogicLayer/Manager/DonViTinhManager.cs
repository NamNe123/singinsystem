using System;
using System.Data;
using DataAccessLayer.Entity;
using DataAccessLayer.Reponsitories;

namespace BusinessLogicLayer.Manager
{
	// Token: 0x02000006 RID: 6
	public class DonViTinhManager
	{
		// Token: 0x06000013 RID: 19 RVA: 0x00002377 File Offset: 0x00000577
		public DonViTinhManager()
		{
			this.process = new DonViTinhResponsitory();
		}

		// Token: 0x06000014 RID: 20 RVA: 0x0000238C File Offset: 0x0000058C
		public DataTable HienThiDanhSachDonViTinh(ref string error)
		{
			return this.process.HienThiDanhSachDonViTinh(ref error);
		}

		// Token: 0x06000015 RID: 21 RVA: 0x000023AC File Offset: 0x000005AC
		public bool XoaDonViTinh(string MaDVT, ref string error)
		{
			bool flag = string.IsNullOrEmpty(MaDVT);
			bool result;
			if (flag)
			{
				error = "Ma don vi tinh chua co gia tri! khong the xoa";
				result = false;
			}
			else
			{
				result = this.process.XoaDonViTinh(MaDVT, ref error);
			}
			return result;
		}

		// Token: 0x06000016 RID: 22 RVA: 0x000023E4 File Offset: 0x000005E4
		public bool ThemDonViTinh(DonViTinhEntity Entity, ref string error)
		{
			bool flag = string.IsNullOrEmpty(Entity.MaDVT);
			bool result;
			if (flag)
			{
				error = "Phai nhap ma don vi tinh";
				result = false;
			}
			else
			{
				bool flag2 = string.IsNullOrEmpty(Entity.TenDVT);
				if (flag2)
				{
					error = "Phai nhap ten don vi tinh";
					result = false;
				}
				else
				{
					result = this.process.ThemDonViTinh(Entity, ref error);
				}
			}
			return result;
		}

		// Token: 0x06000017 RID: 23 RVA: 0x0000243C File Offset: 0x0000063C
		public bool SuaDonViTinh(DonViTinhEntity Entity, ref string error)
		{
			bool flag = string.IsNullOrEmpty(Entity.MaDVT);
			bool result;
			if (flag)
			{
				error = "Phai nhap ten don vi tinh";
				result = false;
			}
			else
			{
				bool flag2 = string.IsNullOrEmpty(Entity.TenDVT);
				if (flag2)
				{
					error = "Phai nhap ten don vi tinh";
					result = false;
				}
				else
				{
					result = this.process.SuaDonViTinh(Entity, ref error);
				}
			}
			return result;
		}

		// Token: 0x04000005 RID: 5
		private DonViTinhResponsitory process;
	}
}
