using System;

namespace DataAccessLayer.Entity
{
	// Token: 0x02000017 RID: 23
	public class DonViTinhEntity
	{
		// Token: 0x17000019 RID: 25
		// (get) Token: 0x060000AF RID: 175 RVA: 0x00005D35 File Offset: 0x00003F35
		// (set) Token: 0x060000B0 RID: 176 RVA: 0x00005D3D File Offset: 0x00003F3D
		public string MaDVT { get; set; }

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x060000B1 RID: 177 RVA: 0x00005D46 File Offset: 0x00003F46
		// (set) Token: 0x060000B2 RID: 178 RVA: 0x00005D4E File Offset: 0x00003F4E
		public string TenDVT { get; set; }

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x060000B3 RID: 179 RVA: 0x00005D57 File Offset: 0x00003F57
		// (set) Token: 0x060000B4 RID: 180 RVA: 0x00005D5F File Offset: 0x00003F5F
		public string TinhTrang { get; set; }

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x060000B5 RID: 181 RVA: 0x00005D68 File Offset: 0x00003F68
		// (set) Token: 0x060000B6 RID: 182 RVA: 0x00005D70 File Offset: 0x00003F70
		public DateTime NgayTao { get; set; }

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x060000B7 RID: 183 RVA: 0x00005D79 File Offset: 0x00003F79
		// (set) Token: 0x060000B8 RID: 184 RVA: 0x00005D81 File Offset: 0x00003F81
		public string NguoiTao { get; set; }
	}
}
