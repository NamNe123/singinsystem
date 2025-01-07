using System;
using System.Data;
using DataAccessLayer.Reponsitories;

namespace BusinessLogicLayer.Manager
{
	// Token: 0x02000011 RID: 17
	public class TinhThanhManager
	{
		// Token: 0x0600005C RID: 92 RVA: 0x0000376C File Offset: 0x0000196C
		public TinhThanhManager()
		{
			this.process = new TinhThanhResponsitory();
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00003784 File Offset: 0x00001984
		public DataTable LayDanhSachTinhThanh(ref string error)
		{
			return this.process.LayDanhSachTinhThanh(ref error);
		}

		// Token: 0x04000013 RID: 19
		private TinhThanhResponsitory process;
	}
}
