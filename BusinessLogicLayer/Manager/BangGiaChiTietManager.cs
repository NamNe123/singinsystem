using System;
using System.Data;
using DataAccessLayer.Entity;
using DataAccessLayer.Reponsitories;

namespace BusinessLogicLayer.Manager
{
	// Token: 0x02000002 RID: 2
	public class BangGiaChiTietManager
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		public BangGiaChiTietManager()
		{
			this.process = new BangGiaChiTietResponsitory();
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002068 File Offset: 0x00000268
		public DataTable HienThiDanhSachBangGiaChiTiet(string tenbg, ref string error)
		{
			return this.process.HienThiDanhSachBangGiaChiTiet(tenbg, ref error);
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002088 File Offset: 0x00000288
		public bool XoaBangGiaChiTiet(string tenbg, string TenSanPham, ref string error)
		{
			bool flag = string.IsNullOrEmpty(TenSanPham);
			bool result;
			if (flag)
			{
				error = "Vui lòng chọn sản phẩm cần xóa!";
				result = false;
			}
			else
			{
				result = this.process.XoaBangGiaChiTiet(tenbg, TenSanPham, ref error);
			}
			return result;
		}

		// Token: 0x06000004 RID: 4 RVA: 0x000020C0 File Offset: 0x000002C0
		public bool ThemBangGiaChiTiet(BangGiaChiTietEntity Entity, ref string error)
		{
			bool flag = string.IsNullOrEmpty(Entity.DonGia);
			bool result;
			if (flag)
			{
				error = "Phai nhap giá";
				result = false;
			}
			else
			{
				result = this.process.ThemBangGiaChiTiet(Entity, ref error);
			}
			return result;
		}

		// Token: 0x06000005 RID: 5 RVA: 0x000020FC File Offset: 0x000002FC
		public bool SuaBangGiaChiTiet(BangGiaChiTietEntity Entity, ref string error)
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
					result = this.process.SuaBangGiaChiTiet(Entity, ref error);
				}
			}
			return result;
		}

		// Token: 0x04000001 RID: 1
		private BangGiaChiTietResponsitory process;
	}
}
