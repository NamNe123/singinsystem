using System;
using System.Data;
using DataAccessLayer.Entity;
using DataAccessLayer.Reponsitories;

namespace BusinessLogicLayer.Manager
{
	// Token: 0x0200000D RID: 13
	public class QLXuongCaManager
	{
		// Token: 0x06000043 RID: 67 RVA: 0x0000305A File Offset: 0x0000125A
		public QLXuongCaManager()
		{
			this.process = new QLXuongCaResponsitory();
			this.processNhanSu = new QLNhanSuResponsitory();
		}

		// Token: 0x06000044 RID: 68 RVA: 0x0000307C File Offset: 0x0000127C
		public DataTable HienThiDanhSachQLXuongCa(ref string error)
		{
			return this.process.HienThiDanhSachQLXuongCa(ref error);
		}

		// Token: 0x06000045 RID: 69 RVA: 0x0000309C File Offset: 0x0000129C
		public DataTable HienThiTimKiem(int manv, DateTime TuNgay, DateTime DenNgay, ref string error)
		{
			bool flag = manv != 0 && !string.IsNullOrEmpty(TuNgay.ToString()) && !string.IsNullOrEmpty(DenNgay.ToString());
			DataTable result;
			if (flag)
			{
				result = this.process.HienThiDanhSachQLXuongCaTheo3DieuKien(manv, TuNgay, DenNgay, ref error);
			}
			else
			{
				bool flag2 = manv == 0 && !string.IsNullOrEmpty(TuNgay.ToString()) && !string.IsNullOrEmpty(DenNgay.ToString());
				if (flag2)
				{
					result = this.process.HienThiDanhSachQLXuongCaTheoTuNgayDenNgay(TuNgay, DenNgay, ref error);
				}
				else
				{
					error = "Không có điều kiện tìm kiếm hợp lệ.";
					result = null;
				}
			}
			return result;
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00003130 File Offset: 0x00001330
		public DataTable XuatExcel(ref string error)
		{
			return this.process.XuatExcel(ref error);
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00003150 File Offset: 0x00001350
		public DataTable BaoCao(ref string error)
		{
			return this.process.BaoCao(ref error);
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00003170 File Offset: 0x00001370
		public DataTable HienThiDanhSachQLXuongCaTheoTimKiem(int manv, ref string error)
		{
			return this.process.HienThiDanhSachQLXuongCaTheoTimKiem(manv, ref error);
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00003190 File Offset: 0x00001390
		public DataTable HienThiDanhSachQLDiLamTheoTimKiem(int manv, ref string error)
		{
			return this.process.HienThiDanhSachQLDiLamTheoTimKiem(manv, ref error);
		}

		// Token: 0x0600004A RID: 74 RVA: 0x000031B0 File Offset: 0x000013B0
		public DataTable HienThiDanhSachQLDiLam(ref string error)
		{
			return this.process.HienThiDanhSachQLDiLam(ref error);
		}

		// Token: 0x0600004B RID: 75 RVA: 0x000031D0 File Offset: 0x000013D0
		public bool XoaQLXuongCa(string TenQLXuongCa, ref string error)
		{
			bool flag = string.IsNullOrEmpty(TenQLXuongCa);
			bool result;
			if (flag)
			{
				error = "Vui lòng chọn bảng giá cần xóa!";
				result = false;
			}
			else
			{
				result = this.process.XoaQLXuongCa(TenQLXuongCa, ref error);
			}
			return result;
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00003208 File Offset: 0x00001408
		public bool ThemQLXuongCa(QLXuongCaEntity Entity, ref string error)
		{
			bool flag = string.IsNullOrEmpty(Entity.Ten.ToString());
			bool result;
			if (flag)
			{
				error = "请输入员工姓名!";
				result = false;
			}
			else
			{
				result = this.process.ThemQLXuongCa(Entity, ref error);
			}
			return result;
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00003248 File Offset: 0x00001448
		public bool ThemQLDiLam(QLXuongCaEntity Entity, ref string error)
		{
			DataTable dataTable = this.processNhanSu.TenNhanSuById(Entity.MaNV, ref error);
			bool flag = dataTable.Rows.Count > 0;
			if (flag)
			{
				string ten = dataTable.Rows[0]["Ten"].ToString();
				Entity.Ten = ten;
			}
			DataTable dataTable2 = this.process.ThongTinByMaNV(Entity.MaNV, ref error);
			bool flag2 = dataTable2.Rows.Count > 0;
			if (flag2)
			{
				DataRow dataRow = dataTable2.Rows[0];
				bool flag3 = !string.IsNullOrEmpty(dataRow["GioXuongCa"].ToString());
				if (flag3)
				{
					DateTime d = Convert.ToDateTime(dataRow["GioXuongCa"]);
					bool flag4 = (Entity.GioLamViec - d).TotalHours < 3.0;
					if (flag4)
					{
						error = "员工已经下班 !";
						return false;
					}
				}
			}
			for (int i = 0; i < dataTable2.Rows.Count; i++)
			{
				bool flag5 = dataTable2.Rows[i]["TrangThai"].ToString() == "Đang làm việc";
				if (flag5)
				{
					error = "员工已经上班 ！";
					return false;
				}
			}
			bool flag6 = string.IsNullOrEmpty(Entity.Ten.ToString());
			bool result;
			if (flag6)
			{
				error = "请输入ID或姓名 !";
				result = false;
			}
			else
			{
				result = this.process.ThemQLDiLam(Entity, ref error);
			}
			return result;
		}

		// Token: 0x0600004E RID: 78 RVA: 0x000033E0 File Offset: 0x000015E0
		public bool SuaQLXuongCa(QLXuongCaEntity Entity, ref string error)
		{
			DataTable dataTable = this.process.ThongTinQLDiLaiByMaNV(Entity.MaNV, ref error);
			bool flag = dataTable.Rows.Count > 0;
			if (flag)
			{
				for (int i = 0; i < dataTable.Rows.Count; i++)
				{
					bool flag2 = dataTable.Rows[i]["TrangThai"].ToString() == "Đã ra";
					if (flag2)
					{
						error = "你出去还没打入，先打入才可以下班 !";
						return false;
					}
				}
			}
			bool flag3 = string.IsNullOrEmpty(Entity.Id.ToString());
			bool result;
			if (flag3)
			{
				error = "Phai chọn người muốn xuống ca trong bảng";
				result = false;
			}
			else
			{
				result = this.process.SuaQLXuongCa(Entity, ref error);
			}
			return result;
		}

		// Token: 0x0600004F RID: 79 RVA: 0x000034A8 File Offset: 0x000016A8
		public bool SuaQLXuongCaTroLaiLamViec(QLXuongCaEntity Entity, ref string error)
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
				result = this.process.SuaQLXuongCaTroLaiLamViec(Entity, ref error);
			}
			return result;
		}
		public bool SuaQLXuongCaXuLyDuLieu(QLXuongCaEntity Entity, ref string error)
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
				result = this.process.SuaQLXuongCaXuLyDuLieu(Entity, ref error);
			}
			return result;
		}
		// Token: 0x0400000E RID: 14
		private QLXuongCaResponsitory process;

		// Token: 0x0400000F RID: 15
		private QLNhanSuResponsitory processNhanSu;
	}
}
