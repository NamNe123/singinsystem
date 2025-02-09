using System;
using System.Data;
using DataAccessLayer.Entity;
using DataAccessLayer.Reponsitories;

namespace BusinessLogicLayer.Manager
{
	// Token: 0x0200000C RID: 12
	public class QLDiLaiManager
	{
		// Token: 0x06000035 RID: 53 RVA: 0x00002A31 File Offset: 0x00000C31
		public QLDiLaiManager()
		{
			this.process = new QLDiLaiResponsitory();
			this.processNhanSu = new QLNhanSuResponsitory();
			this.processXuongCa = new QLXuongCaResponsitory();
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00002A5C File Offset: 0x00000C5C
		public DataTable HienThiDanhSachQLDiLai(ref string error)
		{
			return this.process.HienThiDanhSachQLDiLai(ref error);
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00002A7C File Offset: 0x00000C7C
		public DataTable XuatExcel(ref string error)
		{
			return this.process.XuatExcel(ref error);
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00002A9C File Offset: 0x00000C9C
		public DataTable HienThiTimKiem(int manv, string lydo, DateTime TuNgay, DateTime DenNgay, bool CaNgay, bool CaDem, ref string error)
		{
			bool flag = manv != 0 && !string.IsNullOrEmpty(lydo.ToString()) && !string.IsNullOrEmpty(TuNgay.ToString()) && !string.IsNullOrEmpty(DenNgay.ToString());
			DataTable result;
			if (flag)
			{
                if (CaNgay && !CaDem)
                {
                    result = this.process.HienThiDanhSachQLDiLaiTheo4DieuKienCaNgay(manv, lydo, TuNgay, DenNgay, ref error);
                }
                else if (!CaNgay && CaDem)
                {
                    result = this.process.HienThiDanhSachQLDiLaiTheo4DieuKienCaDem(manv, lydo, TuNgay, DenNgay, ref error);
                }
                else
                {
				result = this.process.HienThiDanhSachQLDiLaiTheo4DieuKien(manv, lydo, TuNgay, DenNgay, ref error);
                }
			}
			else
			{
				bool flag2 = manv != 0 && string.IsNullOrEmpty(lydo.ToString()) && !string.IsNullOrEmpty(TuNgay.ToString()) && !string.IsNullOrEmpty(DenNgay.ToString());
				if (flag2)
				{
					if (CaNgay && !CaDem)
					{
						result = this.process.HienThiDanhSachQLDiLaiTheoNhamViemTuNgayDenNgayCaNgay(manv, TuNgay, DenNgay, ref error);
					}
					else if (!CaNgay && CaDem)
					{
						result = this.process.HienThiDanhSachQLDiLaiTheoNhamViemTuNgayDenNgayCaDem(manv, TuNgay, DenNgay, ref error);
					}
					else
					{
						result = this.process.HienThiDanhSachQLDiLaiTheoNhamViemTuNgayDenNgay(manv, TuNgay, DenNgay, ref error);
					}
					
				}
				else
				{
					bool flag3 = manv == 0 && !string.IsNullOrEmpty(lydo.ToString()) && !string.IsNullOrEmpty(TuNgay.ToString()) && !string.IsNullOrEmpty(DenNgay.ToString());
					if (flag3)
					{
						if (CaNgay && !CaDem)
						{
							result = this.process.HienThiDanhSachQLDiLaiTheoLyDoTuNgayDenNgayCaNgay(lydo, TuNgay, DenNgay, ref error);
						}
						else if (!CaNgay && CaDem)
						{
							result = this.process.HienThiDanhSachQLDiLaiTheoLyDoTuNgayDenNgayCaDem(lydo, TuNgay, DenNgay, ref error);
						}
						else
						{
							result = this.process.HienThiDanhSachQLDiLaiTheoLyDoTuNgayDenNgay(lydo, TuNgay, DenNgay, ref error);
						}
						
					}
					else
					{
						bool flag4 = manv == 0 && string.IsNullOrEmpty(lydo.ToString()) && !string.IsNullOrEmpty(TuNgay.ToString()) && !string.IsNullOrEmpty(DenNgay.ToString());
						if (flag4)
						{
							if (CaNgay && !CaDem)
							{
								result = this.process.HienThiDanhSachQLDiLaiTheoTuNgayDenNgayCaNgay(TuNgay, DenNgay, ref error);
							}
							else if (!CaNgay && CaDem)
							{
								result = this.process.HienThiDanhSachQLDiLaiTheoTuNgayDenNgayCaDem(TuNgay, DenNgay, ref error);
							}
							else
							{
								result = this.process.HienThiDanhSachQLDiLaiTheoTuNgayDenNgay(TuNgay, DenNgay, ref error);
							}
						}
						else
						{
							error = "Không có điều kiện tìm kiếm hợp lệ.";
							result = null;
						}
					}
				}
			}
			return result;
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00002BE4 File Offset: 0x00000DE4
		public DataTable BaoCaoTongHop(int manv, string lydo, DateTime TuNgay, DateTime DenNgay, bool CaNgay, bool CaDem, ref string error)
		{
			bool flag = manv != 0 && !string.IsNullOrEmpty(lydo.ToString()) && !string.IsNullOrEmpty(TuNgay.ToString()) && !string.IsNullOrEmpty(DenNgay.ToString());
			DataTable result;
			if (flag)
			{
				if (CaNgay && !CaDem)
				{
					result = this.process.BaoCaoTongHopTheo4DieuKienCaNgay(manv, lydo, TuNgay, DenNgay, ref error);
				}
				else if (!CaNgay && CaDem)
				{
					result = this.process.BaoCaoTongHopTheo4DieuKienCaDem(manv, lydo, TuNgay, DenNgay, ref error);
				}
				else
				{
					result = this.process.BaoCaoTongHopTheo4DieuKien(manv, lydo, TuNgay, DenNgay, ref error);
				}
			}
			else
			{
				bool flag2 = manv != 0 && string.IsNullOrEmpty(lydo.ToString()) && !string.IsNullOrEmpty(TuNgay.ToString()) && !string.IsNullOrEmpty(DenNgay.ToString());
				if (flag2)
				{
					if (CaNgay && !CaDem)
					{
						result = this.process.BaoCaoTongHopTheoNhamViemTuNgayDenNgayCaNgay(manv, TuNgay, DenNgay, ref error);
					}
					else if (!CaNgay && CaDem)
					{
						result = this.process.BaoCaoTongHopTheoNhamViemTuNgayDenNgayCaDem(manv, TuNgay, DenNgay, ref error);
					}
					else
					{
						result = this.process.BaoCaoTongHopTheoNhamViemTuNgayDenNgay(manv, TuNgay, DenNgay, ref error);
					}
				}
				else
				{
					bool flag3 = manv == 0 && !string.IsNullOrEmpty(lydo.ToString()) && !string.IsNullOrEmpty(TuNgay.ToString()) && !string.IsNullOrEmpty(DenNgay.ToString());
					if (flag3)
					{
						if (CaNgay && !CaDem)
						{
							result = this.process.BaoCaoTongHopTheoLyDoTuNgayDenNgayCaNgay(lydo, TuNgay, DenNgay, ref error);
						}
						else if (!CaNgay && CaDem)
						{
							result = this.process.BaoCaoTongHopTheoLyDoTuNgayDenNgayCaDem(lydo, TuNgay, DenNgay, ref error);
						}
						else
						{
							result = this.process.BaoCaoTongHopTheoLyDoTuNgayDenNgay(lydo, TuNgay, DenNgay, ref error);
						}
					}
					else
					{
						bool flag4 = manv == 0 && string.IsNullOrEmpty(lydo.ToString()) && !string.IsNullOrEmpty(TuNgay.ToString()) && !string.IsNullOrEmpty(DenNgay.ToString());
						if (flag4)
						{
							if (CaNgay && !CaDem)
							{
								result = this.process.BaoCaoTongHopTheoTuNgayDenNgayCaNgay(TuNgay, DenNgay, ref error);
							}
							else if (!CaNgay && CaDem)
							{
								result = this.process.BaoCaoTongHopTheoTuNgayDenNgayCaDem(TuNgay, DenNgay, ref error);
							}
							else
							{
								result = this.process.BaoCaoTongHopTheoTuNgayDenNgay(TuNgay, DenNgay, ref error);
							}
						}
						else
						{
							error = "Không có điều kiện tìm kiếm hợp lệ.";
							result = null;
						}
					}
				}
			}
			return result;
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00002D2C File Offset: 0x00000F2C
		public DataTable HienThiDanhSachBCTH(ref string error)
		{
			return this.process.HienThiDanhSachBCTH(ref error);
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00002D4C File Offset: 0x00000F4C
		public DataTable BaoCao(ref string error)
		{
			return this.process.BaoCao(ref error);
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00002D6C File Offset: 0x00000F6C
		public DataTable HienThiDanhSachQLDangKyVao(int manv, string lydo, ref string error)
		{
			bool flag = manv != 0 && !string.IsNullOrEmpty(lydo.ToString());
			DataTable result;
			if (flag)
			{
				result = this.process.HienThiDanhSachQLDangKyVaoTheoTimKiem2loai(manv, lydo, ref error);
			}
			else
			{
				bool flag2 = manv != 0 && string.IsNullOrEmpty(lydo.ToString());
				if (flag2)
				{
					result = this.process.HienThiDanhSachQLDangKyVaoTheoTimKiem(manv, ref error);
				}
				else
				{
					bool flag3 = manv == 0 && !string.IsNullOrEmpty(lydo.ToString());
					if (flag3)
					{
						result = this.process.HienThiDanhSachQLDangKyVaoTheoTimKiemLyDo(lydo, ref error);
					}
					else
					{
						result = this.process.HienThiDanhSachQLDangKyVao(ref error);
					}
				}
			}
			return result;
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00002E04 File Offset: 0x00001004
		public bool XoaQLDiLai(string TenQLDiLai, ref string error)
		{
			bool flag = string.IsNullOrEmpty(TenQLDiLai);
			bool result;
			if (flag)
			{
				error = "Vui lòng chọn bảng giá cần xóa!";
				result = false;
			}
			else
			{
				result = this.process.XoaQLDiLai(TenQLDiLai, ref error);
			}
			return result;
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00002E3C File Offset: 0x0000103C
		public bool cleardata(int month, ref string error)
		{
			return this.process.cleardata(month, ref error);
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00002E5C File Offset: 0x0000105C
		public bool ThemQLDangKyVao(QLDiLaiEntity Entity, ref string error)
		{
			DataTable dataTable = this.processNhanSu.TenNhanSuById(Entity.MaNV, ref error);
			bool flag = dataTable.Rows.Count > 0;
			if (flag)
			{
				string tenNV = dataTable.Rows[0]["Ten"].ToString();
				Entity.TenNV = tenNV;
			}
			bool flag2 = string.IsNullOrEmpty(Entity.TenNV.ToString());
			bool result;
			if (flag2)
			{
				error = "请输入员工姓名!";
				result = false;
			}
			else
			{
				DataTable dataTable2 = this.processXuongCa.ThongTinByMaNV(Entity.MaNV, ref error);
				int num = 0;
				bool flag3 = dataTable2.Rows.Count > 0;
				if (flag3)
				{
					for (int i = 0; i < dataTable2.Rows.Count; i++)
					{
						string a = dataTable2.Rows[i]["TrangThai"].ToString();
						bool flag4 = a == "Đang làm việc";
						if (flag4)
						{
							Entity.GioVaoCa = DateTime.Parse(dataTable2.Rows[i]["GioLamViec"].ToString());
							DateTime GioBatDauLam = DateTime.Today.Add(DateTime.Parse(dataTable2.Rows[i]["GioLamViec"].ToString()).TimeOfDay);
							if (GioBatDauLam.TimeOfDay > new TimeSpan(5, 0, 0) && GioBatDauLam.TimeOfDay < new TimeSpan(18, 0, 0))
							{
								Entity.CaLam = "Ca Ngày";
							}
							else
							{
								Entity.CaLam = "Ca Đêm";
							}
							num = 1;
						}

					}
				}
				bool flag5 = num == 0;
				if (flag5)
				{
					error = "员工还没上班，请先打上班 ！";
					result = false;
				}
				else
				{
					result = this.process.ThemQLDangKyVao(Entity, ref error);
				}
			}
			return result;
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00002FB4 File Offset: 0x000011B4
		public bool SuaQLDiLai(QLDiLaiEntity Entity, ref string error)
		{
			bool flag = string.IsNullOrEmpty(Entity.Id.ToString());
			bool result;
			if (flag)
			{
				error = "Phai chọn người muốn xuống ca trong bảng";
				result = false;
			}
			else
			{
				result = this.process.SuaQLDiLai(Entity, ref error);
			}
			return result;
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00002FF8 File Offset: 0x000011F8
		public bool ThemGhiChu(QLDiLaiEntity Entity, ref string error)
		{
			return this.process.ThemGhiChu(Entity, ref error);
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00003018 File Offset: 0x00001218
		public bool SuaQLDiLaiTroLaiLamViec(QLDiLaiEntity Entity, ref string error)
		{
			bool flag = string.IsNullOrEmpty(Entity.Id.ToString());
			bool result;
			if (flag)
			{
				error = "Phai chọn người muốn xuống ca trong bảng";
				result = false;
			}
			else
			{
				result = this.process.SuaQLDiLaiTroLaiLamViec(Entity, ref error);
			}
			return result;
		}

		// Token: 0x0400000B RID: 11
		private QLDiLaiResponsitory process;

		// Token: 0x0400000C RID: 12
		private QLNhanSuResponsitory processNhanSu;

		// Token: 0x0400000D RID: 13
		private QLXuongCaResponsitory processXuongCa;
	}
}
