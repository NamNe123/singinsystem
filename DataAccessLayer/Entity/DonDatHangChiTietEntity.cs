using System;

namespace DataAccessLayer.Entity
{
	// Token: 0x02000015 RID: 21
	public class DonDatHangChiTietEntity
	{
		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000091 RID: 145 RVA: 0x00005C47 File Offset: 0x00003E47
		// (set) Token: 0x06000092 RID: 146 RVA: 0x00005C4F File Offset: 0x00003E4F
		public string MaDatHang { get; set; }

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000093 RID: 147 RVA: 0x00005C58 File Offset: 0x00003E58
		// (set) Token: 0x06000094 RID: 148 RVA: 0x00005C60 File Offset: 0x00003E60
		public string MaSanPham { get; set; }

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000095 RID: 149 RVA: 0x00005C69 File Offset: 0x00003E69
		// (set) Token: 0x06000096 RID: 150 RVA: 0x00005C71 File Offset: 0x00003E71
		public int SoLuongDat { get; set; }

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000097 RID: 151 RVA: 0x00005C7A File Offset: 0x00003E7A
		// (set) Token: 0x06000098 RID: 152 RVA: 0x00005C82 File Offset: 0x00003E82
		public int DonGia { get; set; }

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000099 RID: 153 RVA: 0x00005C8B File Offset: 0x00003E8B
		// (set) Token: 0x0600009A RID: 154 RVA: 0x00005C93 File Offset: 0x00003E93
		public int ThanhTien { get; set; }
	}
}
