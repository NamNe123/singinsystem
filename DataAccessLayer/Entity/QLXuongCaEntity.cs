using System;

namespace DataAccessLayer.Entity
{
	// Token: 0x0200001E RID: 30
	public class QLXuongCaEntity
	{
		// Token: 0x17000042 RID: 66
		// (get) Token: 0x06000108 RID: 264 RVA: 0x00005FEE File Offset: 0x000041EE
		// (set) Token: 0x06000109 RID: 265 RVA: 0x00005FF6 File Offset: 0x000041F6
		public int Id { get; set; }

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x0600010A RID: 266 RVA: 0x00005FFF File Offset: 0x000041FF
		// (set) Token: 0x0600010B RID: 267 RVA: 0x00006007 File Offset: 0x00004207
		public int MaNV { get; set; }

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x0600010C RID: 268 RVA: 0x00006010 File Offset: 0x00004210
		// (set) Token: 0x0600010D RID: 269 RVA: 0x00006018 File Offset: 0x00004218
		public string Ten { get; set; }

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x0600010E RID: 270 RVA: 0x00006021 File Offset: 0x00004221
		// (set) Token: 0x0600010F RID: 271 RVA: 0x00006029 File Offset: 0x00004229
		public DateTime GioLamViec { get; set; }

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x06000110 RID: 272 RVA: 0x00006032 File Offset: 0x00004232
		// (set) Token: 0x06000111 RID: 273 RVA: 0x0000603A File Offset: 0x0000423A
		public DateTime GioXuongCa { get; set; }

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x06000112 RID: 274 RVA: 0x00006043 File Offset: 0x00004243
		// (set) Token: 0x06000113 RID: 275 RVA: 0x0000604B File Offset: 0x0000424B
		public float TongGioLam { get; set; }

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x06000114 RID: 276 RVA: 0x00006054 File Offset: 0x00004254
		// (set) Token: 0x06000115 RID: 277 RVA: 0x0000605C File Offset: 0x0000425C
		public string TrangThai { get; set; }
	}
}
