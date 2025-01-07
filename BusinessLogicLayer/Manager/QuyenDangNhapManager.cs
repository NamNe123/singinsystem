using System;
using System.Data;
using DataAccessLayer.Reponsitories;

namespace BusinessLogicLayer.Manager
{
	// Token: 0x0200000E RID: 14
	public class QuyenDangNhapManager
	{
		// Token: 0x06000050 RID: 80 RVA: 0x000034EA File Offset: 0x000016EA
		public QuyenDangNhapManager()
		{
			this.process = new QuyenDangNhapResponsitory();
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00003500 File Offset: 0x00001700
		public DataTable HienThiDanhSachQuyenDangNhap(ref string error)
		{
			return this.process.HienThiDanhSachQuyenDangNhap(ref error);
		}

		// Token: 0x04000010 RID: 16
		private QuyenDangNhapResponsitory process;
	}
}
