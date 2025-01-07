using System;

namespace DataAccessLayer.Entity
{
	// Token: 0x02000016 RID: 22
	public class DonDatHangEntity
	{
		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600009C RID: 156 RVA: 0x00005C9C File Offset: 0x00003E9C
		// (set) Token: 0x0600009D RID: 157 RVA: 0x00005CA4 File Offset: 0x00003EA4
		public string MaDatHang { get; set; }

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600009E RID: 158 RVA: 0x00005CAD File Offset: 0x00003EAD
		// (set) Token: 0x0600009F RID: 159 RVA: 0x00005CB5 File Offset: 0x00003EB5
		public DateTime NgayDatHang { get; set; }

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x060000A0 RID: 160 RVA: 0x00005CBE File Offset: 0x00003EBE
		// (set) Token: 0x060000A1 RID: 161 RVA: 0x00005CC6 File Offset: 0x00003EC6
		public string MaKhachHang { get; set; }

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x060000A2 RID: 162 RVA: 0x00005CCF File Offset: 0x00003ECF
		// (set) Token: 0x060000A3 RID: 163 RVA: 0x00005CD7 File Offset: 0x00003ED7
		public int MaBangGia { get; set; }

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x060000A4 RID: 164 RVA: 0x00005CE0 File Offset: 0x00003EE0
		// (set) Token: 0x060000A5 RID: 165 RVA: 0x00005CE8 File Offset: 0x00003EE8
		public DateTime NgayTao { get; set; }

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x060000A6 RID: 166 RVA: 0x00005CF1 File Offset: 0x00003EF1
		// (set) Token: 0x060000A7 RID: 167 RVA: 0x00005CF9 File Offset: 0x00003EF9
		public string NguoiTao { get; set; }

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x060000A8 RID: 168 RVA: 0x00005D02 File Offset: 0x00003F02
		// (set) Token: 0x060000A9 RID: 169 RVA: 0x00005D0A File Offset: 0x00003F0A
		public DateTime NgayGiaoHang { get; set; }

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x060000AA RID: 170 RVA: 0x00005D13 File Offset: 0x00003F13
		// (set) Token: 0x060000AB RID: 171 RVA: 0x00005D1B File Offset: 0x00003F1B
		public string TinhTrang { get; set; }

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x060000AC RID: 172 RVA: 0x00005D24 File Offset: 0x00003F24
		// (set) Token: 0x060000AD RID: 173 RVA: 0x00005D2C File Offset: 0x00003F2C
		public string DaChotDon { get; set; }
	}
}
