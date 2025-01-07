using System;

namespace DataAccessLayer.Entity
{
	// Token: 0x0200001A RID: 26
	public class QLNhanSuEntity
	{
		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060000D8 RID: 216 RVA: 0x00005E78 File Offset: 0x00004078
		// (set) Token: 0x060000D9 RID: 217 RVA: 0x00005E80 File Offset: 0x00004080
		public int STT { get; set; }

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060000DA RID: 218 RVA: 0x00005E89 File Offset: 0x00004089
		// (set) Token: 0x060000DB RID: 219 RVA: 0x00005E91 File Offset: 0x00004091
		public int Id { get; set; }

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060000DC RID: 220 RVA: 0x00005E9A File Offset: 0x0000409A
		// (set) Token: 0x060000DD RID: 221 RVA: 0x00005EA2 File Offset: 0x000040A2
		public string Ten { get; set; }

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060000DE RID: 222 RVA: 0x00005EAB File Offset: 0x000040AB
		// (set) Token: 0x060000DF RID: 223 RVA: 0x00005EB3 File Offset: 0x000040B3
		public string IdTen { get; set; }
	}
}
