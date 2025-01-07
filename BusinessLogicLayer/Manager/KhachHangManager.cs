using System;
using System.Data;
using DataAccessLayer.Entity;
using DataAccessLayer.Reponsitories;

namespace BusinessLogicLayer.Manager
{
	// Token: 0x02000007 RID: 7
	public class KhachHangManager
	{
		// Token: 0x06000018 RID: 24 RVA: 0x00002491 File Offset: 0x00000691
		public KhachHangManager()
		{
			this.process = new KhachHangResponsitory();
		}

		// Token: 0x06000019 RID: 25 RVA: 0x000024A8 File Offset: 0x000006A8
		public DataTable LayDuLieuKhachHang(ref string error)
		{
			return this.process.LayDuLieuKhachHang(ref error);
		}

		// Token: 0x0600001A RID: 26 RVA: 0x000024C8 File Offset: 0x000006C8
		public bool ThemKhachHang(KhachHangEntity khachhang, ref string error)
		{
			string text = this.process.LayMaKhachHangLonNhat(ref error);
			string s = text.Replace("KH", "");
			khachhang.MaKhachHang = "KH" + (int.Parse(s) + 1).ToString().PadLeft(8, '0');
			return this.process.ThemKhachHang(khachhang, ref error);
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00002530 File Offset: 0x00000730
		public bool XoaKhachHang(KhachHangEntity khachhang, ref string error)
		{
			return this.process.XoaKhachHang(khachhang, ref error);
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002550 File Offset: 0x00000750
		public bool SuaKhachHang(KhachHangEntity khachhang, ref string error)
		{
			return this.process.SuaKhachHang(khachhang, ref error);
		}

		// Token: 0x04000006 RID: 6
		private KhachHangResponsitory process;
	}
}
