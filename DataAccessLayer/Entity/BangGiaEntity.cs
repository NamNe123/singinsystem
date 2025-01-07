using System;

namespace DataAccessLayer.Entity
{
	// Token: 0x02000014 RID: 20
	public class BangGiaEntity
	{
		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000086 RID: 134 RVA: 0x00005BF2 File Offset: 0x00003DF2
		// (set) Token: 0x06000087 RID: 135 RVA: 0x00005BFA File Offset: 0x00003DFA
		public string MaBangGia { get; set; }

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000088 RID: 136 RVA: 0x00005C03 File Offset: 0x00003E03
		// (set) Token: 0x06000089 RID: 137 RVA: 0x00005C0B File Offset: 0x00003E0B
		public string TenBangGia { get; set; }

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600008A RID: 138 RVA: 0x00005C14 File Offset: 0x00003E14
		// (set) Token: 0x0600008B RID: 139 RVA: 0x00005C1C File Offset: 0x00003E1C
		public string TinhTrang { get; set; }

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600008C RID: 140 RVA: 0x00005C25 File Offset: 0x00003E25
		// (set) Token: 0x0600008D RID: 141 RVA: 0x00005C2D File Offset: 0x00003E2D
		public DateTime NgayTao { get; set; }

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600008E RID: 142 RVA: 0x00005C36 File Offset: 0x00003E36
		// (set) Token: 0x0600008F RID: 143 RVA: 0x00005C3E File Offset: 0x00003E3E
		public string NguoiTao { get; set; }
	}
}
