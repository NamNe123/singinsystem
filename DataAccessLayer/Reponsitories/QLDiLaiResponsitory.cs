using System;
using System.Data;
using System.Data.SqlClient;
using DataAccessLayer.Entity;

namespace DataAccessLayer.Reponsitories
{
	// Token: 0x0200000D RID: 13
	public class QLDiLaiResponsitory
	{
		// Token: 0x0600003B RID: 59 RVA: 0x00003CF8 File Offset: 0x00001EF8
		public DataTable HienThiDanhSachQLDiLai(ref string error)
		{
			DataTable result;
			try
			{
				string sql = " select Id, MaNV, TenNV, LyDo, TimeOut, TimeIn, TongTime, GhiChu  from QLDiLai where TrangThai = N'Đã vào' ORDER BY Id DESC ";
				DataTable dataFromDB = this.DB.GetDataFromDB(sql, CommandType.Text, ref error, new SqlParameter[0]);
				result = dataFromDB;
			}
			catch (Exception ex)
			{
				error = "Ket noi lôi: " + ex.Message;
				result = null;
			}
			return result;
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00003D50 File Offset: 0x00001F50
		public DataTable HienThiDanhSachQLDiLaiTheo4DieuKien(int manv, string LyDo, DateTime TuNgay, DateTime DenNgay, ref string error)
		{
			DataTable result;
			try
			{
				string sql = " select Id, MaNV, TenNV, LyDo, TimeOut, TimeIn, TongTime, GhiChu  from QLDiLai where TrangThai = N'Đã vào' AND MaNV=@MaNV AND LyDo=@LyDo AND TimeOut >= @TuNgay AND TimeOut <= @DenNgay ORDER BY Id DESC ";
				DataTable dataFromDB = this.DB.GetDataFromDB(sql, CommandType.Text, ref error, new SqlParameter[]
				{
					new SqlParameter("@TuNgay", TuNgay),
					new SqlParameter("@DenNgay", DenNgay),
					new SqlParameter("@LyDo", LyDo),
					new SqlParameter("@MaNV", manv)
				});
				result = dataFromDB;
			}
			catch (Exception ex)
			{
				error = "Ket noi lôi: " + ex.Message;
				result = null;
			}
			return result;
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00003DF4 File Offset: 0x00001FF4
		public DataTable BaoCaoTongHopTheo4DieuKien(int manv, string LyDo, DateTime TuNgay, DateTime DenNgay, ref string error)
		{
			DataTable result;
			try
			{
				string sql = " select MaNV, TenNV, SUM(CASE WHEN LyDo = N'早餐（35 分钟）- Breakfast (35 minutes)' THEN 1 ELSE 0 END) AS SoLanAnSang,SUM(CASE WHEN LyDo = N'午餐（35 分钟）- Lunch (35 minutes)' THEN 1 ELSE 0 END) AS SoLanAnTrua,SUM(CASE WHEN LyDo = N'晚餐（35 分钟）- Dinner (35 minutes)' THEN 1 ELSE 0 END) AS SoLanAnToi,SUM(CASE WHEN LyDo = N'抽烟（10 分钟）- Smoking (10 minutes)' THEN 1 ELSE 0 END) AS SoLanHutThuoc,SUM(CASE WHEN LyDo = N'厕所小（10 分钟）- CR (10 minutes)' THEN 1 ELSE 0 END) AS SoLanTieuTien,SUM(CASE WHEN LyDo = N'厕所大（15 分钟）- CR (15 minutes)' THEN 1 ELSE 0 END) AS SoLanDaiTien,SUM(CASE WHEN LyDo = N'其他（5 分钟）- Other (5 minutes)' THEN 1 ELSE 0 END) AS SoLanKhac,SUM(CASE WHEN TongTimeSuDung < 0 THEN -TongTimeSuDung ELSE 0 END) + SUM(CASE WHEN TongTimeSuDung > 0 THEN TongTimeSuDung ELSE 0 END) AS TongTime,SUM(CASE WHEN TongTime > 0 THEN TongTime ELSE 0 END) AS TongTimeQuaGio,COUNT(*) AS TongSoLan,SUM(CASE WHEN TongTime > 0 THEN 1 ELSE 0 END) AS TongSoLanQuaGio, COUNT(GhiChu) AS TongSoLanGhiChufrom QLDiLai where TrangThai = N'Đã vào' AND MaNV=@MaNV AND LyDo=@LyDo AND TimeOut >= @TuNgay AND TimeOut <= @DenNgay GROUP BY MaNV, TenNV";
				DataTable dataFromDB = this.DB.GetDataFromDB(sql, CommandType.Text, ref error, new SqlParameter[]
				{
					new SqlParameter("@TuNgay", TuNgay),
					new SqlParameter("@DenNgay", DenNgay),
					new SqlParameter("@LyDo", LyDo),
					new SqlParameter("@MaNV", manv)
				});
				result = dataFromDB;
			}
			catch (Exception ex)
			{
				error = "Ket noi lôi: " + ex.Message;
				result = null;
			}
			return result;
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00003E98 File Offset: 0x00002098
		public DataTable HienThiDanhSachQLDiLaiTheoNhamViemTuNgayDenNgay(int manv, DateTime TuNgay, DateTime DenNgay, ref string error)
		{
			DataTable result;
			try
			{
				string sql = " select Id, MaNV, TenNV, LyDo, TimeOut, TimeIn, TongTime, GhiChu  from QLDiLai where TrangThai = N'Đã vào' AND MaNV=@MaNV AND TimeOut >= @TuNgay AND TimeOut <= @DenNgay ORDER BY Id DESC ";
				DataTable dataFromDB = this.DB.GetDataFromDB(sql, CommandType.Text, ref error, new SqlParameter[]
				{
					new SqlParameter("@TuNgay", TuNgay),
					new SqlParameter("@DenNgay", DenNgay),
					new SqlParameter("@MaNV", manv)
				});
				result = dataFromDB;
			}
			catch (Exception ex)
			{
				error = "Ket noi lôi: " + ex.Message;
				result = null;
			}
			return result;
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00003F2C File Offset: 0x0000212C
		public DataTable BaoCaoTongHopTheoNhamViemTuNgayDenNgay(int manv, DateTime TuNgay, DateTime DenNgay, ref string error)
		{
			DataTable result;
			try
			{
				string sql = " select MaNV, TenNV, SUM(CASE WHEN LyDo = N'早餐（35 分钟）- Breakfast (35 minutes)' THEN 1 ELSE 0 END) AS SoLanAnSang, SUM(CASE WHEN LyDo = N'午餐（35 分钟）- Lunch (35 minutes)' THEN 1 ELSE 0 END) AS SoLanAnTrua, SUM(CASE WHEN LyDo = N'晚餐（35 分钟）- Dinner (35 minutes)' THEN 1 ELSE 0 END) AS SoLanAnToi, SUM(CASE WHEN LyDo = N'抽烟（10 分钟）- Smoking (10 minutes)' THEN 1 ELSE 0 END) AS SoLanHutThuoc, SUM(CASE WHEN LyDo = N'厕所小（10 分钟）- CR (10 minutes)' THEN 1 ELSE 0 END) AS SoLanTieuTien, SUM(CASE WHEN LyDo = N'厕所大（15 分钟）- CR (15 minutes)' THEN 1 ELSE 0 END) AS SoLanDaiTien, SUM(CASE WHEN LyDo = N'其他（5 分钟）- Other (5 minutes)' THEN 1 ELSE 0 END) AS SoLanKhac, SUM(CASE WHEN TongTimeSuDung < 0 THEN -TongTimeSuDung ELSE 0 END) + SUM(CASE WHEN TongTimeSuDung > 0 THEN TongTimeSuDung ELSE 0 END) AS TongTime, SUM(CASE WHEN TongTime > 0 THEN TongTime ELSE 0 END) AS TongTimeQuaGio, COUNT(*) AS TongSoLan, SUM(CASE WHEN TongTime > 0 THEN 1 ELSE 0 END) AS TongSoLanQuaGio, COUNT(GhiChu) AS TongSoLanGhiChu from QLDiLai where TrangThai = N'Đã vào' AND MaNV=@MaNV AND TimeOut >= @TuNgay AND TimeOut <= @DenNgay GROUP BY MaNV, TenNV ";
				DataTable dataFromDB = this.DB.GetDataFromDB(sql, CommandType.Text, ref error, new SqlParameter[]
				{
					new SqlParameter("@TuNgay", TuNgay),
					new SqlParameter("@DenNgay", DenNgay),
					new SqlParameter("@MaNV", manv)
				});
				result = dataFromDB;
			}
			catch (Exception ex)
			{
				error = "Ket noi lôi: " + ex.Message;
				result = null;
			}
			return result;
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00003FC0 File Offset: 0x000021C0
		public DataTable HienThiDanhSachQLDiLaiTheoLyDoTuNgayDenNgay(string LyDo, DateTime TuNgay, DateTime DenNgay, ref string error)
		{
			DataTable result;
			try
			{
				string sql = " select Id, MaNV, TenNV, LyDo, TimeOut, TimeIn, TongTime, GhiChu  from QLDiLai where TrangThai = N'Đã vào' AND LyDo=@LyDo AND TimeOut >= @TuNgay AND TimeOut <= @DenNgay ORDER BY Id DESC ";
				DataTable dataFromDB = this.DB.GetDataFromDB(sql, CommandType.Text, ref error, new SqlParameter[]
				{
					new SqlParameter("@TuNgay", TuNgay),
					new SqlParameter("@DenNgay", DenNgay),
					new SqlParameter("@LyDo", LyDo)
				});
				result = dataFromDB;
			}
			catch (Exception ex)
			{
				error = "Ket noi lôi: " + ex.Message;
				result = null;
			}
			return result;
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00004050 File Offset: 0x00002250
		public DataTable BaoCaoTongHopTheoLyDoTuNgayDenNgay(string LyDo, DateTime TuNgay, DateTime DenNgay, ref string error)
		{
			DataTable result;
			try
			{
				string sql = " select MaNV, TenNV, SUM(CASE WHEN LyDo = N'早餐（35 分钟）- Breakfast (35 minutes)' THEN 1 ELSE 0 END) AS SoLanAnSang, SUM(CASE WHEN LyDo = N'午餐（35 分钟）- Lunch (35 minutes)' THEN 1 ELSE 0 END) AS SoLanAnTrua, SUM(CASE WHEN LyDo = N'晚餐（35 分钟）- Dinner (35 minutes)' THEN 1 ELSE 0 END) AS SoLanAnToi, SUM(CASE WHEN LyDo = N'抽烟（10 分钟）- Smoking (10 minutes)' THEN 1 ELSE 0 END) AS SoLanHutThuoc, SUM(CASE WHEN LyDo = N'厕所小（10 分钟）- CR (10 minutes)' THEN 1 ELSE 0 END) AS SoLanTieuTien, SUM(CASE WHEN LyDo = N'厕所大（15 分钟）- CR (15 minutes)' THEN 1 ELSE 0 END) AS SoLanDaiTien, SUM(CASE WHEN LyDo = N'其他（5 分钟）- Other (5 minutes)' THEN 1 ELSE 0 END) AS SoLanKhac, SUM(CASE WHEN TongTimeSuDung < 0 THEN -TongTimeSuDung ELSE 0 END) + SUM(CASE WHEN TongTimeSuDung > 0 THEN TongTimeSuDung ELSE 0 END) AS TongTime, SUM(CASE WHEN TongTime > 0 THEN TongTime ELSE 0 END) AS TongTimeQuaGio, COUNT(*) AS TongSoLan, SUM(CASE WHEN TongTime > 0 THEN 1 ELSE 0 END) AS TongSoLanQuaGio, COUNT(GhiChu) AS TongSoLanGhiChu  from QLDiLai where TrangThai = N'Đã vào' AND LyDo=@LyDo AND TimeOut >= @TuNgay AND TimeOut <= @DenNgay GROUP BY MaNV, TenNV ";
				DataTable dataFromDB = this.DB.GetDataFromDB(sql, CommandType.Text, ref error, new SqlParameter[]
				{
					new SqlParameter("@TuNgay", TuNgay),
					new SqlParameter("@DenNgay", DenNgay),
					new SqlParameter("@LyDo", LyDo)
				});
				result = dataFromDB;
			}
			catch (Exception ex)
			{
				error = "Ket noi lôi: " + ex.Message;
				result = null;
			}
			return result;
		}

		// Token: 0x06000042 RID: 66 RVA: 0x000040E0 File Offset: 0x000022E0
		public DataTable HienThiDanhSachQLDiLaiTheoTuNgayDenNgay(DateTime TuNgay, DateTime DenNgay, ref string error)
		{
			DataTable result;
			try
			{
				string sql = " select Id, MaNV, TenNV, LyDo, TimeOut, TimeIn, TongTime, GhiChu  from QLDiLai where TrangThai = N'Đã vào' AND TimeOut >= @TuNgay AND TimeOut <= @DenNgay ORDER BY Id DESC ";
				DataTable dataFromDB = this.DB.GetDataFromDB(sql, CommandType.Text, ref error, new SqlParameter[]
				{
					new SqlParameter("@TuNgay", TuNgay),
					new SqlParameter("@DenNgay", DenNgay)
				});
				result = dataFromDB;
			}
			catch (Exception ex)
			{
				error = "Ket noi lôi: " + ex.Message;
				result = null;
			}
			return result;
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00004160 File Offset: 0x00002360
		public DataTable BaoCaoTongHopTheoTuNgayDenNgay(DateTime TuNgay, DateTime DenNgay, ref string error)
		{
			DataTable result;
			try
			{
				string sql = " select MaNV, TenNV, SUM(CASE WHEN LyDo = N'早餐（35 分钟）- Breakfast (35 minutes)' THEN 1 ELSE 0 END) AS SoLanAnSang, SUM(CASE WHEN LyDo = N'午餐（35 分钟）- Lunch (35 minutes)' THEN 1 ELSE 0 END) AS SoLanAnTrua, SUM(CASE WHEN LyDo = N'晚餐（35 分钟）- Dinner (35 minutes)' THEN 1 ELSE 0 END) AS SoLanAnToi, SUM(CASE WHEN LyDo = N'抽烟（10 分钟）- Smoking (10 minutes)' THEN 1 ELSE 0 END) AS SoLanHutThuoc, SUM(CASE WHEN LyDo = N'厕所小（10 分钟）- CR (10 minutes)' THEN 1 ELSE 0 END) AS SoLanTieuTien, SUM(CASE WHEN LyDo = N'厕所大（15 分钟）- CR (15 minutes)' THEN 1 ELSE 0 END) AS SoLanDaiTien, SUM(CASE WHEN LyDo = N'其他（5 分钟）- Other (5 minutes)' THEN 1 ELSE 0 END) AS SoLanKhac, SUM(CASE WHEN TongTimeSuDung < 0 THEN -TongTimeSuDung ELSE 0 END) + SUM(CASE WHEN TongTimeSuDung > 0 THEN TongTimeSuDung ELSE 0 END) AS TongTime, SUM(CASE WHEN TongTime > 0 THEN TongTime ELSE 0 END) AS TongTimeQuaGio, COUNT(*) AS TongSoLan, SUM(CASE WHEN TongTime > 0 THEN 1 ELSE 0 END) AS TongSoLanQuaGio, COUNT(GhiChu) AS TongSoLanGhiChu  from QLDiLai where TrangThai = N'Đã vào' AND TimeOut >= @TuNgay AND TimeOut <= @DenNgay GROUP BY MaNV, TenNV";
				DataTable dataFromDB = this.DB.GetDataFromDB(sql, CommandType.Text, ref error, new SqlParameter[]
				{
					new SqlParameter("@TuNgay", TuNgay),
					new SqlParameter("@DenNgay", DenNgay)
				});
				result = dataFromDB;
			}
			catch (Exception ex)
			{
				error = "Ket noi lôi: " + ex.Message;
				result = null;
			}
			return result;
		}

		// Token: 0x06000044 RID: 68 RVA: 0x000041E0 File Offset: 0x000023E0
		public DataTable XuatExcel(ref string error)
		{
			DataTable result;
			try
			{
				string sql = " select MaNV, TenNV, LyDo, TimeOut, TimeIn, TongTime, GhiChu  from QLDiLai where TrangThai = N'Đã vào' AND MONTH(TimeOut) = MONTH(GETDATE()) ORDER BY Id DESC ";
				DataTable dataFromDB = this.DB.GetDataFromDB(sql, CommandType.Text, ref error, new SqlParameter[0]);
				result = dataFromDB;
			}
			catch (Exception ex)
			{
				error = "Ket noi lôi: " + ex.Message;
				result = null;
			}
			return result;
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00004238 File Offset: 0x00002438
		public DataTable HienThiDanhSachBCTH(ref string error)
		{
			DataTable result;
			try
			{
				string sql = " SELECT MaNV, TenNV, SUM(CASE WHEN LyDo = N'早餐（35 分钟）- Breakfast (35 minutes)' THEN 1 ELSE 0 END) AS SoLanAnSang, SUM(CASE WHEN LyDo = N'午餐（35 分钟）- Lunch (35 minutes)' THEN 1 ELSE 0 END) AS SoLanAnTrua, SUM(CASE WHEN TongTime > 0 THEN TongTime ELSE 0 END) AS TongTimeQuaGio FROM QLDiLai GROUP BY MaNV, TenNV ";
				DataTable dataFromDB = this.DB.GetDataFromDB(sql, CommandType.Text, ref error, new SqlParameter[0]);
				result = dataFromDB;
			}
			catch (Exception ex)
			{
				error = "Ket noi lôi: " + ex.Message;
				result = null;
			}
			return result;
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00004290 File Offset: 0x00002490
		public DataTable BaoCao(ref string error)
		{
			DataTable result;
			try
			{
				string sql = " select MaNV, TenNV, LyDo, TimeOut, TimeIn, TongTime, GhiChu  from QLDiLai where TrangThai = N'Đã vào' AND MONTH(TimeOut) = MONTH(GETDATE()) ORDER BY Id DESC ";
				DataTable dataFromDB = this.DB.GetDataFromDB(sql, CommandType.Text, ref error, new SqlParameter[0]);
				result = dataFromDB;
			}
			catch (Exception ex)
			{
				error = "Ket noi lôi: " + ex.Message;
				result = null;
			}
			return result;
		}

		// Token: 0x06000047 RID: 71 RVA: 0x000042E8 File Offset: 0x000024E8
		public DataTable HienThiDanhSachQLDiLaiTheoTimKiem(int manv, ref string error)
		{
			DataTable result;
			try
			{
				string sql = " select Id, MaNV , TenNV, LyDo, TimeOut, TimeIn , TongTime, GhiChu, TrangThai  from QLDiLai where Manv=@MaNV AND TrangThai = N'Đã vào' ORDER BY Id DESC ";
				DataTable dataFromDB = this.DB.GetDataFromDB(sql, CommandType.Text, ref error, new SqlParameter[]
				{
					new SqlParameter("@MaNV", manv)
				});
				result = dataFromDB;
			}
			catch (Exception ex)
			{
				error = "Ket noi lôi: " + ex.Message;
				result = null;
			}
			return result;
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00004354 File Offset: 0x00002554
		public DataTable DanhSachSoLanTheoLyDo(string lydo, string ten, DateTime giovaoca, ref string error)
		{
			DataTable result;
			try
			{
				string sql = " SELECT LyDo, COUNT(*) AS SoLan  from QLDiLai where TenNV=@TenNV AND LyDo=@LyDo   AND TimeOut >= @giovaoca GROUP BY LyDo ";
				DataTable dataFromDB = this.DB.GetDataFromDB(sql, CommandType.Text, ref error, new SqlParameter[]
				{
					new SqlParameter("@LyDo", lydo),
					new SqlParameter("@giovaoca", giovaoca),
					new SqlParameter("@TenNV", ten)
				});
				result = dataFromDB;
			}
			catch (Exception ex)
			{
				error = "Ket noi lôi: " + ex.Message;
				result = null;
			}
			return result;
		}

		// Token: 0x06000049 RID: 73 RVA: 0x000043DC File Offset: 0x000025DC
		public DataTable DanhSachQLDiLaiTheoNV(int manv, ref string error)
		{
			DataTable result;
			try
			{
				string sql = " SELECT *  from QLDiLai where MaNV=@MaNV ORDER BY Id DESC ";
				DataTable dataFromDB = this.DB.GetDataFromDB(sql, CommandType.Text, ref error, new SqlParameter[]
				{
					new SqlParameter("@MaNV", manv)
				});
				result = dataFromDB;
			}
			catch (Exception ex)
			{
				error = "Ket noi lôi: " + ex.Message;
				result = null;
			}
			return result;
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00004448 File Offset: 0x00002648
		public DataTable DanhSachLoaiDangKy(string ten, ref string error)
		{
			DataTable result;
			try
			{
				string sql = " select LyDo , SoLan  from QLDiLai where TenNV=@TenNV ORDER BY Id DESC ";
				DataTable dataFromDB = this.DB.GetDataFromDB(sql, CommandType.Text, ref error, new SqlParameter[]
				{
					new SqlParameter("@TenNV", ten)
				});
				result = dataFromDB;
			}
			catch (Exception ex)
			{
				error = "Ket noi lôi: " + ex.Message;
				result = null;
			}
			return result;
		}

		// Token: 0x0600004B RID: 75 RVA: 0x000044B0 File Offset: 0x000026B0
		public DataTable HienThiDanhSachQLDangKyVao(ref string error)
		{
			DataTable result;
			try
			{
				string sql = " select Id, MaNV, TenNV, LyDo, TimeOut  from QLDiLai where TrangThai = N'Đã ra' ORDER BY Id DESC";
				DataTable dataFromDB = this.DB.GetDataFromDB(sql, CommandType.Text, ref error, new SqlParameter[0]);
				result = dataFromDB;
			}
			catch (Exception ex)
			{
				error = "Ket noi lôi: " + ex.Message;
				result = null;
			}
			return result;
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00004508 File Offset: 0x00002708
		public DataTable HienThiDanhSachQLDangKyVaoTheoTimKiem(int manv, ref string error)
		{
			DataTable result;
			try
			{
				string sql = " select Id, MaNV, TenNV, LyDo, TimeOut  from QLDiLai where MaNV=@MaNV AND TrangThai = N'Đã ra' ORDER BY Id DESC";
				DataTable dataFromDB = this.DB.GetDataFromDB(sql, CommandType.Text, ref error, new SqlParameter[]
				{
					new SqlParameter("@MaNV", manv)
				});
				result = dataFromDB;
			}
			catch (Exception ex)
			{
				error = "Ket noi lôi: " + ex.Message;
				result = null;
			}
			return result;
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00004574 File Offset: 0x00002774
		public DataTable HienThiDanhSachQLDangKyVaoTheoTimKiem2loai(int manv, string lydo, ref string error)
		{
			DataTable result;
			try
			{
				string sql = " select Id, MaNV, TenNV, LyDo, TimeOut  from QLDiLai where MaNV=@MaNV AND LyDo=@LyDo AND TrangThai = N'Đã ra' ORDER BY Id DESC";
				DataTable dataFromDB = this.DB.GetDataFromDB(sql, CommandType.Text, ref error, new SqlParameter[]
				{
					new SqlParameter("@MaNV", manv),
					new SqlParameter("@LyDo", lydo)
				});
				result = dataFromDB;
			}
			catch (Exception ex)
			{
				error = "Ket noi lôi: " + ex.Message;
				result = null;
			}
			return result;
		}

		// Token: 0x0600004E RID: 78 RVA: 0x000045EC File Offset: 0x000027EC
		public DataTable HienThiDanhSachQLDiLaiTheoTimKiem2loai(int manv, string lydo, ref string error)
		{
			DataTable result;
			try
			{
				string sql = " select Id, MaNV , TenNV, LyDo, TimeOut, TimeIn , TongTime, GhiChu, TrangThai  from QLDiLai where MaNV=@MaNV AND LyDo=@LyDo AND TrangThai = N'Đã vào' ORDER BY Id DESC";
				DataTable dataFromDB = this.DB.GetDataFromDB(sql, CommandType.Text, ref error, new SqlParameter[]
				{
					new SqlParameter("@MaNV", manv),
					new SqlParameter("@LyDo", lydo)
				});
				result = dataFromDB;
			}
			catch (Exception ex)
			{
				error = "Ket noi lôi: " + ex.Message;
				result = null;
			}
			return result;
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00004664 File Offset: 0x00002864
		public DataTable HienThiDanhSachQLDangKyVaoTheoTimKiemLyDo(string lydo, ref string error)
		{
			DataTable result;
			try
			{
				string sql = " select Id, MaNV, TenNV, LyDo, TimeOut  from QLDiLai where LyDo=@LyDo AND TrangThai = N'Đã ra' ORDER BY Id DESC";
				DataTable dataFromDB = this.DB.GetDataFromDB(sql, CommandType.Text, ref error, new SqlParameter[]
				{
					new SqlParameter("@LyDo", lydo)
				});
				result = dataFromDB;
			}
			catch (Exception ex)
			{
				error = "Ket noi lôi: " + ex.Message;
				result = null;
			}
			return result;
		}

		// Token: 0x06000050 RID: 80 RVA: 0x000046CC File Offset: 0x000028CC
		public DataTable HienThiDanhSachQLDiLaiTheoTimKiemLyDo(string lydo, ref string error)
		{
			DataTable result;
			try
			{
				string sql = " select Id, MaNV , TenNV, LyDo, TimeOut, TimeIn , TongTime, GhiChu, TrangThai from QLDiLai where LyDo=@LyDo AND TrangThai = N'Đã vào' ORDER BY Id DESC";
				DataTable dataFromDB = this.DB.GetDataFromDB(sql, CommandType.Text, ref error, new SqlParameter[]
				{
					new SqlParameter("@LyDo", lydo)
				});
				result = dataFromDB;
			}
			catch (Exception ex)
			{
				error = "Ket noi lôi: " + ex.Message;
				result = null;
			}
			return result;
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00004734 File Offset: 0x00002934
		public bool XoaQLDiLai(string Id, ref string error)
		{
			bool result;
			try
			{
				string sql = " delete from QLDiLai where Id like @Id";
				bool flag = this.DB.ProcessData(sql, CommandType.Text, ref error, new SqlParameter[]
				{
					new SqlParameter("@Id", Id)
				});
				result = flag;
			}
			catch (Exception ex)
			{
				error = "Ket noi lôi: " + ex.Message;
				result = false;
			}
			return result;
		}

		// Token: 0x06000052 RID: 82 RVA: 0x0000479C File Offset: 0x0000299C
		public bool cleardata(int month, ref string error)
		{
			bool result;
			try
			{
				string sql = " delete from QLDiLai WHERE MONTH(TimeOut) < @month delete from QLXuongCa WHERE MONTH(GioLamViec) < @month";
				bool flag = this.DB.ProcessData(sql, CommandType.Text, ref error, new SqlParameter[]
				{
					new SqlParameter("@month", month)
				});
				result = flag;
			}
			catch (Exception ex)
			{
				error = "Ket noi lôi: " + ex.Message;
				result = false;
			}
			return result;
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00004808 File Offset: 0x00002A08
		public bool ThemQLDangKyVao(QLDiLaiEntity Entity, ref string error)
		{
			DataTable dataTable = this.DanhSachSoLanTheoLyDo(Entity.LyDo, Entity.TenNV, Entity.GioVaoCa, ref error);
			int num = 0;
			bool flag = dataTable != null && dataTable.Rows.Count > 0;
			if (flag)
			{
				num = int.Parse(dataTable.Rows[0]["SoLan"].ToString());
			}
			DataTable dataTable2 = this.HienThiDanhSachQLLoaiDangKyTheoSoLanCaiDat(Entity.LyDo, ref error);
			int num2 = int.Parse(dataTable2.Rows[0]["SoLan"].ToString());
			DataTable dataTable3 = this.DanhSachQLDiLaiTheoNV(Entity.MaNV, ref error);
			bool flag2 = dataTable3 != null && dataTable3.Rows.Count > 0;
			if (flag2)
			{
				for (int i = 0; i < dataTable3.Rows.Count; i++)
				{
					string a = dataTable3.Rows[i]["TrangThai"].ToString();
					bool flag3 = a == "Đã ra";
					if (flag3)
					{
						error = "你还没进入，先打入 ！";
						return false;
					}
				}
			}
			bool flag4 = num >= num2;
			bool result;
			if (flag4)
			{
				error = "=> 不能再选这个选项 <= 请选其他选项";
				result = false;
			}
			else
			{
				try
				{
					string sql = " insert into QLDiLai( MaNV , TenNV, LyDo, TimeOut, TrangThai)  values( @MaNV, @TenNV,  @LyDo,  @TimeOut,  @TrangThai)";
					bool flag5 = this.DB.ProcessData(sql, CommandType.Text, ref error, new SqlParameter[]
					{
						new SqlParameter("@MaNV", Entity.MaNV),
						new SqlParameter("@TenNV", Entity.TenNV),
						new SqlParameter("@LyDo", Entity.LyDo),
						new SqlParameter("@TimeOut", Entity.TimeOut),
						new SqlParameter("@TrangThai", Entity.TrangThai)
					});
					result = flag5;
				}
				catch (Exception ex)
				{
					error = "Ket noi lôi: " + ex.Message;
					result = false;
				}
			}
			return result;
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00004A08 File Offset: 0x00002C08
		public DataTable ThongTinById(int id, ref string error)
		{
			DataTable result;
			try
			{
				string sql = " SELECT * FROM QLDiLai where Id=@Id  ";
				DataTable dataFromDB = this.DB.GetDataFromDB(sql, CommandType.Text, ref error, new SqlParameter[]
				{
					new SqlParameter("@Id", id)
				});
				result = dataFromDB;
			}
			catch (Exception ex)
			{
				error = "Ket noi lôi: " + ex.Message;
				result = null;
			}
			return result;
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00004A74 File Offset: 0x00002C74
		public DataTable ThongTinQLLoaiDangKyByName(string kieu, ref string error)
		{
			DataTable result;
			try
			{
				string sql = " SELECT * FROM QLLoaiDangKy where Kieu=@Kieu  ";
				DataTable dataFromDB = this.DB.GetDataFromDB(sql, CommandType.Text, ref error, new SqlParameter[]
				{
					new SqlParameter("@Kieu", kieu)
				});
				result = dataFromDB;
			}
			catch (Exception ex)
			{
				error = "Ket noi lôi: " + ex.Message;
				result = null;
			}
			return result;
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00004ADC File Offset: 0x00002CDC
		public DataTable HienThiDanhSachQLLoaiDangKyTheoSoLanCaiDat(string kieu, ref string error)
		{
			DataTable result;
			try
			{
				string sql = " SELECT Kieu,SoLan FROM QLLoaiDangKy where Kieu=@Kieu  ";
				DataTable dataFromDB = this.DB.GetDataFromDB(sql, CommandType.Text, ref error, new SqlParameter[]
				{
					new SqlParameter("@Kieu", kieu)
				});
				result = dataFromDB;
			}
			catch (Exception ex)
			{
				error = "Ket noi lôi: " + ex.Message;
				result = null;
			}
			return result;
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00004B44 File Offset: 0x00002D44
		public bool SuaQLDiLai(QLDiLaiEntity Entity, ref string error)
		{
			DataTable dataTable = this.ThongTinById(Entity.Id, ref error);
			DataTable dataTable2 = this.ThongTinQLLoaiDangKyByName(Entity.LyDo, ref error);
			DateTime timeIn = Entity.TimeIn;
			DateTime d = DateTime.Parse(dataTable.Rows[0]["TimeOut"].ToString());
			double num = Math.Round((timeIn - d).TotalMinutes, 0);
			int num2 = int.Parse(dataTable2.Rows[0]["ThoiGian"].ToString());
			double num3 = num - (double)num2;
			bool result;
			try
			{
				string sql = " update QLDiLai set TimeIn=@TimeIn , TrangThai=@TrangThai , TongTime=@TongTime , TongTimeSuDung=@TongTimeSuDung  where  Id=@Id   ";
				bool flag = this.DB.ProcessData(sql, CommandType.Text, ref error, new SqlParameter[]
				{
					new SqlParameter("@Id", Entity.Id),
					new SqlParameter("@TimeIn", Entity.TimeIn),
					new SqlParameter("@TongTime", num3),
					new SqlParameter("@TongTimeSuDung", num),
					new SqlParameter("@TrangThai", Entity.TrangThai)
				});
				result = flag;
			}
			catch (Exception ex)
			{
				error = "Ket noi lôi: " + ex.Message;
				result = false;
			}
			return result;
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00004C98 File Offset: 0x00002E98
		public bool ThemGhiChu(QLDiLaiEntity Entity, ref string error)
		{
			bool result;
			try
			{
				string sql = " update QLDiLai set GhiChu=@GhiChu where  Id=@Id   ";
				bool flag = this.DB.ProcessData(sql, CommandType.Text, ref error, new SqlParameter[]
				{
					new SqlParameter("@Id", Entity.Id),
					new SqlParameter("@GhiChu", Entity.GhiChu)
				});
				result = flag;
			}
			catch (Exception ex)
			{
				error = "Ket noi lôi: " + ex.Message;
				result = false;
			}
			return result;
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00004D1C File Offset: 0x00002F1C
		public bool SuaQLDiLaiTroLaiLamViec(QLDiLaiEntity Entity, ref string error)
		{
			bool result;
			try
			{
				string sql = " update QLDiLai set TrangThai=@TrangThai  where  Id=@Id   ";
				bool flag = this.DB.ProcessData(sql, CommandType.Text, ref error, new SqlParameter[]
				{
					new SqlParameter("@Id", Entity.Id),
					new SqlParameter("@TrangThai", Entity.TrangThai)
				});
				result = flag;
			}
			catch (Exception ex)
			{
				error = "Ket noi lôi: " + ex.Message;
				result = false;
			}
			return result;
		}

		// Token: 0x0400000E RID: 14
		private Database DB = new Database();
	}
}
