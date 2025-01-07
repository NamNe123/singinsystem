using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccessLayer.Entity
{
	// Token: 0x02000013 RID: 19
	public class BangGiaChiTietEntity
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x0600007B RID: 123 RVA: 0x00005B94 File Offset: 0x00003D94
		// (set) Token: 0x0600007C RID: 124 RVA: 0x00005B9C File Offset: 0x00003D9C
		public string MaBangGia { get; set; }

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600007D RID: 125 RVA: 0x00005BA5 File Offset: 0x00003DA5
		// (set) Token: 0x0600007E RID: 126 RVA: 0x00005BAD File Offset: 0x00003DAD
		public string MaSanPham { get; set; }

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600007F RID: 127 RVA: 0x00005BB6 File Offset: 0x00003DB6
		// (set) Token: 0x06000080 RID: 128 RVA: 0x00005BBE File Offset: 0x00003DBE
		public string DonGia { get; set; }

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000081 RID: 129 RVA: 0x00005BC7 File Offset: 0x00003DC7
		// (set) Token: 0x06000082 RID: 130 RVA: 0x00005BCF File Offset: 0x00003DCF
		[NotMapped]
		public string TenBangGia { get; set; }

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000083 RID: 131 RVA: 0x00005BD8 File Offset: 0x00003DD8
		// (set) Token: 0x06000084 RID: 132 RVA: 0x00005BE0 File Offset: 0x00003DE0
		[NotMapped]
		public string TenSanPham { get; set; }
	}
}
