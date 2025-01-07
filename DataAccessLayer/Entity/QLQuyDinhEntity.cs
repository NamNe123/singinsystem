using System;

namespace DataAccessLayer.Entity
{
	// Token: 0x0200001B RID: 27
	public class QLQuyDinhEntity
	{
		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060000E1 RID: 225 RVA: 0x00005EBC File Offset: 0x000040BC
		// (set) Token: 0x060000E2 RID: 226 RVA: 0x00005EC4 File Offset: 0x000040C4
		public int STT { get; set; }

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000E3 RID: 227 RVA: 0x00005ECD File Offset: 0x000040CD
		// (set) Token: 0x060000E4 RID: 228 RVA: 0x00005ED5 File Offset: 0x000040D5
		public int Id { get; set; }

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000E5 RID: 229 RVA: 0x00005EDE File Offset: 0x000040DE
		// (set) Token: 0x060000E6 RID: 230 RVA: 0x00005EE6 File Offset: 0x000040E6
		public string QuyDinh { get; set; }

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000E7 RID: 231 RVA: 0x00005EEF File Offset: 0x000040EF
		// (set) Token: 0x060000E8 RID: 232 RVA: 0x00005EF7 File Offset: 0x000040F7
		public int DiemBiTru { get; set; }

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000E9 RID: 233 RVA: 0x00005F00 File Offset: 0x00004100
		// (set) Token: 0x060000EA RID: 234 RVA: 0x00005F08 File Offset: 0x00004108
		public string Kieu { get; set; }
	}
}
