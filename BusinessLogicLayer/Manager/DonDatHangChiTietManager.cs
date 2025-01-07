using System;
using System.Data;
using DataAccessLayer.Entity;
using DataAccessLayer.Reponsitories;

namespace BusinessLogicLayer.Manager
{
	// Token: 0x02000004 RID: 4
	public class DonDatHangChiTietManager
	{
		// Token: 0x0600000B RID: 11 RVA: 0x00002251 File Offset: 0x00000451
		public DonDatHangChiTietManager()
		{
			this.process = new DonDatHangChiTietResponsitory();
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002268 File Offset: 0x00000468
		public DataTable DonDatHangChiTiet_LayDanhSach(string madh, ref string error)
		{
			return this.process.DonDatHangChiTiet_LayDanhSach(madh, ref error);
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002288 File Offset: 0x00000488
		public bool ThemDonDatHangChiTiet(DonDatHangChiTietEntity Entity, ref string error)
		{
			bool flag = string.IsNullOrEmpty(Entity.MaDatHang);
			bool result;
			if (flag)
			{
				error = "Phai nhap MaDatHang";
				result = false;
			}
			else
			{
				result = this.process.ThemDonDatHangChiTiet(Entity, ref error);
			}
			return result;
		}

		// Token: 0x0600000E RID: 14 RVA: 0x000022C4 File Offset: 0x000004C4
		public bool DonDatHangChiTiet_Xoa(string madathang, string masanpham, ref string error)
		{
			return this.process.DonDatHangChiTiet_Xoa(madathang, masanpham, ref error);
		}

		// Token: 0x04000003 RID: 3
		private DonDatHangChiTietResponsitory process;
	}
}
