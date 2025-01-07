using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccessLayer.Entity
{
	// Token: 0x0200001D RID: 29
	public class QLDiLaiEntity
	{
		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000F3 RID: 243 RVA: 0x00005F44 File Offset: 0x00004144
		// (set) Token: 0x060000F4 RID: 244 RVA: 0x00005F4C File Offset: 0x0000414C
		public int Id { get; set; }

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000F5 RID: 245 RVA: 0x00005F55 File Offset: 0x00004155
		// (set) Token: 0x060000F6 RID: 246 RVA: 0x00005F5D File Offset: 0x0000415D
		public int MaNV { get; set; }

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000F7 RID: 247 RVA: 0x00005F66 File Offset: 0x00004166
		// (set) Token: 0x060000F8 RID: 248 RVA: 0x00005F6E File Offset: 0x0000416E
		public string TenNV { get; set; }

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000F9 RID: 249 RVA: 0x00005F77 File Offset: 0x00004177
		// (set) Token: 0x060000FA RID: 250 RVA: 0x00005F7F File Offset: 0x0000417F
		public string LyDo { get; set; }

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060000FB RID: 251 RVA: 0x00005F88 File Offset: 0x00004188
		// (set) Token: 0x060000FC RID: 252 RVA: 0x00005F90 File Offset: 0x00004190
		public DateTime TimeOut { get; set; }

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060000FD RID: 253 RVA: 0x00005F99 File Offset: 0x00004199
		// (set) Token: 0x060000FE RID: 254 RVA: 0x00005FA1 File Offset: 0x000041A1
		public DateTime TimeIn { get; set; }

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060000FF RID: 255 RVA: 0x00005FAA File Offset: 0x000041AA
		// (set) Token: 0x06000100 RID: 256 RVA: 0x00005FB2 File Offset: 0x000041B2
		public float TongTime { get; set; }

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x06000101 RID: 257 RVA: 0x00005FBB File Offset: 0x000041BB
		// (set) Token: 0x06000102 RID: 258 RVA: 0x00005FC3 File Offset: 0x000041C3
		public string GhiChu { get; set; }

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x06000103 RID: 259 RVA: 0x00005FCC File Offset: 0x000041CC
		// (set) Token: 0x06000104 RID: 260 RVA: 0x00005FD4 File Offset: 0x000041D4
		public string TrangThai { get; set; }

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x06000105 RID: 261 RVA: 0x00005FDD File Offset: 0x000041DD
		// (set) Token: 0x06000106 RID: 262 RVA: 0x00005FE5 File Offset: 0x000041E5
		[NotMapped]
		public DateTime GioVaoCa { get; set; }
	}
}
