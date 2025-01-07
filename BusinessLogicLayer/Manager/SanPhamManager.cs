using System;
using System.Data;
using DataAccessLayer.Entity;
using DataAccessLayer.Reponsitories;

namespace BusinessLogicLayer.Manager
{
	// Token: 0x0200000F RID: 15
	public class SanPhamManager
	{
		// Token: 0x06000052 RID: 82 RVA: 0x0000351E File Offset: 0x0000171E
		public SanPhamManager()
		{
			this.process = new SanPhamResponsitory();
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00003534 File Offset: 0x00001734
		public DataTable HienThiDanhSachSanPham(ref string error)
		{
			return this.process.HienThiDanhSachSanPham(ref error);
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00003554 File Offset: 0x00001754
		public bool XoaSanPham(string TenSanPham, ref string error)
		{
			bool flag = string.IsNullOrEmpty(TenSanPham);
			bool result;
			if (flag)
			{
				error = "Vui lòng chọn bảng giá cần xóa!";
				result = false;
			}
			else
			{
				result = this.process.XoaSanPham(TenSanPham, ref error);
			}
			return result;
		}

		// Token: 0x06000055 RID: 85 RVA: 0x0000358C File Offset: 0x0000178C
		public bool ThemSanPham(SanPhamEntity Entity, ref string error)
		{
			bool flag = string.IsNullOrEmpty(Entity.TenSanPham);
			bool result;
			if (flag)
			{
				error = "Phai nhap ten bảng giá";
				result = false;
			}
			else
			{
				result = this.process.ThemSanPham(Entity, ref error);
			}
			return result;
		}

		// Token: 0x06000056 RID: 86 RVA: 0x000035C8 File Offset: 0x000017C8
		public bool SuaSanPham(SanPhamEntity Entity, ref string error)
		{
			bool flag = string.IsNullOrEmpty(Entity.MaSanPham);
			bool result;
			if (flag)
			{
				error = "Phai nhap ten don vi tinh";
				result = false;
			}
			else
			{
				bool flag2 = string.IsNullOrEmpty(Entity.TenSanPham);
				if (flag2)
				{
					error = "Phai nhap ten don vi tinh";
					result = false;
				}
				else
				{
					result = this.process.SuaSanPham(Entity, ref error);
				}
			}
			return result;
		}

		// Token: 0x04000011 RID: 17
		private SanPhamResponsitory process;
	}
}
