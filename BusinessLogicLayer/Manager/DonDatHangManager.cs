using System;
using System.Data;
using DataAccessLayer.Entity;
using DataAccessLayer.Reponsitories;

namespace BusinessLogicLayer.Manager
{
	// Token: 0x02000005 RID: 5
	public class DonDatHangManager
	{
		// Token: 0x0600000F RID: 15 RVA: 0x000022E4 File Offset: 0x000004E4
		public DonDatHangManager()
		{
			this.process = new DonDatHangResponsitory();
		}

		// Token: 0x06000010 RID: 16 RVA: 0x000022FC File Offset: 0x000004FC
		public DataTable DonDatHang_LayDanhSach(ref string error)
		{
			return this.process.DonDatHang_LayDanhSach(ref error);
		}

		// Token: 0x06000011 RID: 17 RVA: 0x0000231C File Offset: 0x0000051C
		public bool ThemDonDatHang(DonDatHangEntity Entity, ref string error)
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
				result = this.process.ThemDonDatHang(Entity, ref error);
			}
			return result;
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002358 File Offset: 0x00000558
		public bool DonDatHang_Xoa(string mamuonxoa, ref string error)
		{
			return this.process.DonDatHang_Xoa(mamuonxoa, ref error);
		}

		// Token: 0x04000004 RID: 4
		private DonDatHangResponsitory process;
	}
}
