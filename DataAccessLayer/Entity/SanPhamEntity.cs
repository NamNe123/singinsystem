using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccessLayer.Entity
{
	// Token: 0x0200001F RID: 31
	public class SanPhamEntity
	{
		// Token: 0x17000049 RID: 73
		// (get) Token: 0x06000117 RID: 279 RVA: 0x00006065 File Offset: 0x00004265
		// (set) Token: 0x06000118 RID: 280 RVA: 0x0000606D File Offset: 0x0000426D
		public string MaSanPham { get; set; }

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x06000119 RID: 281 RVA: 0x00006076 File Offset: 0x00004276
		// (set) Token: 0x0600011A RID: 282 RVA: 0x0000607E File Offset: 0x0000427E
		public string TenSanPham { get; set; }

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x0600011B RID: 283 RVA: 0x00006087 File Offset: 0x00004287
		// (set) Token: 0x0600011C RID: 284 RVA: 0x0000608F File Offset: 0x0000428F
		public string MaDVT { get; set; }

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x0600011D RID: 285 RVA: 0x00006098 File Offset: 0x00004298
		// (set) Token: 0x0600011E RID: 286 RVA: 0x000060A0 File Offset: 0x000042A0
		public string TinhTrang { get; set; }

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x0600011F RID: 287 RVA: 0x000060A9 File Offset: 0x000042A9
		// (set) Token: 0x06000120 RID: 288 RVA: 0x000060B1 File Offset: 0x000042B1
		public DateTime NgayTao { get; set; }

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x06000121 RID: 289 RVA: 0x000060BA File Offset: 0x000042BA
		// (set) Token: 0x06000122 RID: 290 RVA: 0x000060C2 File Offset: 0x000042C2
		public string NguoiTao { get; set; }

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x06000123 RID: 291 RVA: 0x000060CB File Offset: 0x000042CB
		// (set) Token: 0x06000124 RID: 292 RVA: 0x000060D3 File Offset: 0x000042D3
		[NotMapped]
		public string TenDVT { get; set; }
	}
}
