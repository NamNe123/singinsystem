using System;
using System.Data;
using System.Data.SqlClient;
using DataAccessLayer.Entity;

namespace DataAccessLayer.Reponsitories
{
	// Token: 0x0200000E RID: 14
	public class QLXuongCaResponsitory
	{
		// Token: 0x0600005B RID: 91 RVA: 0x00004DB4 File Offset: 0x00002FB4
		public DataTable HienThiDanhSachQLXuongCa(ref string error)
		{
			DataTable result;
			try
			{
				string sql = " select Id , MaNV , Ten , GioLamViec, GioXuongCa, TongGioLam  from QLXuongCa where TrangThai = N'Đã xuống ca' ORDER BY Id DESC ";
				DataTable dataFromDB = this.DB.GetDataFromDB(sql, CommandType.Text, ref error, new SqlParameter[0]);
				result = dataFromDB;
			}
			catch (Exception ex)
			{
				error = "连接失败: " + ex.Message;
				result = null;
			}
			return result;
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00004E0C File Offset: 0x0000300C
		public DataTable HienThiDanhSachQLXuongCaTheoTuNgayDenNgay(DateTime TuNgay, DateTime DenNgay, ref string error)
		{
			DataTable result;
			try
			{
				string sql = " select Id , MaNV , Ten , GioLamViec, GioXuongCa, TongGioLam  from QLXuongCa where TrangThai = N'Đã xuống ca' AND GioLamViec >= @TuNgay AND GioLamViec <= @DenNgay ORDER BY Id DESC ";
				DataTable dataFromDB = this.DB.GetDataFromDB(sql, CommandType.Text, ref error, new SqlParameter[]
				{
					new SqlParameter("@TuNgay", TuNgay),
					new SqlParameter("@DenNgay", DenNgay)
				});
				result = dataFromDB;
			}
			catch (Exception ex)
			{
				error = "连接失败: " + ex.Message;
				result = null;
			}
			return result;
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00004E8C File Offset: 0x0000308C
		public DataTable HienThiDanhSachQLXuongCaTheo3DieuKien(int manv, DateTime TuNgay, DateTime DenNgay, ref string error)
		{
			DataTable result;
			try
			{
				string sql = " select Id , MaNV , Ten , GioLamViec, GioXuongCa, TongGioLam  from QLXuongCa where TrangThai = N'Đã xuống ca' AND MaNV=@MaNV AND GioLamViec >= @TuNgay AND GioLamViec <= @DenNgay ORDER BY Id DESC ";
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
				error = "连接失败: " + ex.Message;
				result = null;
			}
			return result;
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00004F20 File Offset: 0x00003120
		public DataTable XuatExcel(ref string error)
		{
			DataTable result;
			try
			{
				string sql = " select MaNV , Ten , GioLamViec, GioXuongCa, TongGioLam  from QLXuongCa where TrangThai = N'Đã xuống ca' AND MONTH(GioXuongCa) = MONTH(GETDATE())  ORDER BY Id DESC ";
				DataTable dataFromDB = this.DB.GetDataFromDB(sql, CommandType.Text, ref error, new SqlParameter[0]);
				result = dataFromDB;
			}
			catch (Exception ex)
			{
				error = "连接失败: " + ex.Message;
				result = null;
			}
			return result;
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00004F78 File Offset: 0x00003178
		public DataTable BaoCao(ref string error)
		{
			DataTable result;
			try
			{
				string sql = " select Id , MaNV , Ten , GioLamViec, GioXuongCa, TongGioLam  from QLXuongCa where TrangThai = N'Đã xuống ca' AND MONTH(GioXuongCa) = MONTH(GETDATE()) ORDER BY Id DESC ";
				DataTable dataFromDB = this.DB.GetDataFromDB(sql, CommandType.Text, ref error, new SqlParameter[0]);
				result = dataFromDB;
			}
			catch (Exception ex)
			{
				error = "连接失败: " + ex.Message;
				result = null;
			}
			return result;
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00004FD0 File Offset: 0x000031D0
		public DataTable HienThiDanhSachQLDiLamTheoTimKiem(int manv, ref string error)
		{
			DataTable result;
			try
			{
				string sql = " select Id, MaNV, Ten, GioLamViec  from QLXuongCa where MaNV=@MaNV AND TrangThai = N'Đang làm việc' ORDER BY Id DESC";
				DataTable dataFromDB = this.DB.GetDataFromDB(sql, CommandType.Text, ref error, new SqlParameter[]
				{
					new SqlParameter("@MaNV", manv)
				});
				result = dataFromDB;
			}
			catch (Exception ex)
			{
				error = "连接失败: " + ex.Message;
				result = null;
			}
			return result;
		}

		// Token: 0x06000061 RID: 97 RVA: 0x0000503C File Offset: 0x0000323C
		public DataTable HienThiDanhSachQLXuongCaTheoTimKiem(int manv, ref string error)
		{
			DataTable result;
			try
			{
				string sql = " select  Id , MaNV , Ten , GioLamViec, GioXuongCa, TongGioLam, TrangThai   from QLXuongCa where MaNV=@MaNV AND  TrangThai = N'Đã xuống ca' ORDER BY Id DESC ";
				DataTable dataFromDB = this.DB.GetDataFromDB(sql, CommandType.Text, ref error, new SqlParameter[]
				{
					new SqlParameter("@MaNV", manv)
				});
				result = dataFromDB;
			}
			catch (Exception ex)
			{
				error = "连接失败: " + ex.Message;
				result = null;
			}
			return result;
		}

		// Token: 0x06000062 RID: 98 RVA: 0x000050A8 File Offset: 0x000032A8
		public DataTable HienThiDanhSachQLDiLam(ref string error)
		{
			DataTable result;
			try
			{
				string sql = " select Id, MaNV, Ten, GioLamViec  from QLXuongCa where TrangThai = N'Đang làm việc' ORDER BY Id DESC";
				DataTable dataFromDB = this.DB.GetDataFromDB(sql, CommandType.Text, ref error, new SqlParameter[0]);
				result = dataFromDB;
			}
			catch (Exception ex)
			{
				error = "连接失败: " + ex.Message;
				result = null;
			}
			return result;
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00005100 File Offset: 0x00003300
		public bool XoaQLXuongCa(string Id, ref string error)
		{
			bool result;
			try
			{
				string sql = " delete from QLXuongCa where Id like @Id";
				bool flag = this.DB.ProcessData(sql, CommandType.Text, ref error, new SqlParameter[]
				{
					new SqlParameter("@Id", Id)
				});
				result = flag;
			}
			catch (Exception ex)
			{
				error = "连接失败: " + ex.Message;
				result = false;
			}
			return result;
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00005168 File Offset: 0x00003368
		public bool ThemQLXuongCa(QLXuongCaEntity Entity, ref string error)
		{
			bool result;
			try
			{
				string sql = " insert into QLXuongCa(Id,Ten,GioLamViec,GioXuongCa,TongGioLam,TrangThai)  values( @Id,  @Ten,  @GioLamViec,  @GioXuongCa,  @TongGioLam,  @TrangThai)";
				bool flag = this.DB.ProcessData(sql, CommandType.Text, ref error, new SqlParameter[]
				{
					new SqlParameter("@Id", Entity.Id),
					new SqlParameter("@Ten", Entity.Ten),
					new SqlParameter("@GioLamViec", Entity.GioLamViec),
					new SqlParameter("@GioXuongCa", Entity.GioXuongCa),
					new SqlParameter("@TongGioLam", Entity.TongGioLam),
					new SqlParameter("@TrangThai", Entity.TrangThai)
				});
				result = flag;
			}
			catch (Exception ex)
			{
				error = "连接失败: " + ex.Message;
				result = false;
			}
			return result;
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00005248 File Offset: 0x00003448
		public bool ThemQLDiLam(QLXuongCaEntity Entity, ref string error)
		{
			bool result;
			try
			{
				string sql = " insert into QLXuongCa(MaNV,Ten,GioLamViec,TrangThai)  values( @MaNV, @Ten,  @GioLamViec,  @TrangThai)";
				bool flag = this.DB.ProcessData(sql, CommandType.Text, ref error, new SqlParameter[]
				{
					new SqlParameter("@Ten", Entity.Ten),
					new SqlParameter("@MaNV", Entity.MaNV),
					new SqlParameter("@GioLamViec", Entity.GioLamViec),
					new SqlParameter("@TrangThai", Entity.TrangThai)
				});
				result = flag;
			}
			catch (Exception ex)
			{
				error = "连接失败: " + ex.Message;
				result = false;
			}
			return result;
		}

		// Token: 0x06000066 RID: 102 RVA: 0x000052F8 File Offset: 0x000034F8
		public DataTable ThongTinById(int id, ref string error)
		{
			DataTable result;
			try
			{
				string sql = " SELECT * FROM QLXuongCa where Id=@Id  ";
				DataTable dataFromDB = this.DB.GetDataFromDB(sql, CommandType.Text, ref error, new SqlParameter[]
				{
					new SqlParameter("@Id", id)
				});
				result = dataFromDB;
			}
			catch (Exception ex)
			{
				error = "连接失败: " + ex.Message;
				result = null;
			}
			return result;
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00005364 File Offset: 0x00003564
		public DataTable ThongTinByMaNV(int MaNV, ref string error)
		{
			DataTable result;
			try
			{
				string sql = "   SELECT * FROM QLXuongCa WHERE MaNV=@MaNV ORDER BY GioXuongCa DESC  ";
				DataTable dataFromDB = this.DB.GetDataFromDB(sql, CommandType.Text, ref error, new SqlParameter[]
				{
					new SqlParameter("@MaNV", MaNV)
				});
				result = dataFromDB;
			}
			catch (Exception ex)
			{
				error = "连接失败: " + ex.Message;
				result = null;
			}
			return result;
		}

		// Token: 0x06000068 RID: 104 RVA: 0x000053D0 File Offset: 0x000035D0
		public DataTable ThongTinQLDiLaiByMaNV(int manv, ref string error)
		{
			DataTable result;
			try
			{
				string sql = "SELECT * FROM QLDiLai WHERE MaNV=@MaNV ";
				DataTable dataFromDB = this.DB.GetDataFromDB(sql, CommandType.Text, ref error, new SqlParameter[]
				{
					new SqlParameter("@MaNV", manv)
				});
				result = dataFromDB;
			}
			catch (Exception ex)
			{
				error = "连接失败: " + ex.Message;
				result = null;
			}
			return result;
		}

		// Token: 0x06000069 RID: 105 RVA: 0x0000543C File Offset: 0x0000363C
		public bool SuaQLXuongCa(QLXuongCaEntity Entity, ref string error)
		{
			DataTable dataTable = this.ThongTinById(Entity.Id, ref error);
			DateTime gioXuongCa = Entity.GioXuongCa;
			DateTime d = DateTime.Parse(dataTable.Rows[0]["GioLamViec"].ToString());
			double num = Math.Round((gioXuongCa - d).TotalHours, 1);
			bool result;
			try
			{
				string sql = " update QLXuongCa set GioXuongCa=@GioXuongCa , TrangThai=@TrangThai , TongGioLam=@TongGioLam  where  Id=@Id   ";
				bool flag = this.DB.ProcessData(sql, CommandType.Text, ref error, new SqlParameter[]
				{
					new SqlParameter("@Id", Entity.Id),
					new SqlParameter("@GioXuongCa", Entity.GioXuongCa),
					new SqlParameter("@TongGioLam", num),
					new SqlParameter("@TrangThai", Entity.TrangThai)
				});
				result = flag;
			}
			catch (Exception ex)
			{
				error = "连接失败: " + ex.Message;
				result = false;
			}
			return result;
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00005540 File Offset: 0x00003740
		public bool SuaQLXuongCaTroLaiLamViec(QLXuongCaEntity Entity, ref string error)
		{
			bool result;
			try
			{
				string sql = " update QLXuongCa set TrangThai=@TrangThai  where  Id=@Id   ";
				bool flag = this.DB.ProcessData(sql, CommandType.Text, ref error, new SqlParameter[]
				{
					new SqlParameter("@Id", Entity.Id),
					new SqlParameter("@TrangThai", Entity.TrangThai)
				});
				result = flag;
			}
			catch (Exception ex)
			{
				error = "连接失败: " + ex.Message;
				result = false;
			}
			return result;
		}
		public bool SuaQLXuongCaXuLyDuLieu(QLXuongCaEntity Entity, ref string error)
		{
			bool result;
			try
			{
				string sql = " update QLXuongCa set GioXuongCa=@GioXuongCa, TongGioLam=@TongGioLam  where  Id=@Id   ";
				bool flag = this.DB.ProcessData(sql, CommandType.Text, ref error, new SqlParameter[]
				{
					new SqlParameter("@Id", Entity.Id),
					new SqlParameter("@TongGioLam", 12),
					new SqlParameter("@GioXuongCa", Entity.GioXuongCa)
				});
				result = flag;
			}
			catch (Exception ex)
			{
				error = "连接失败: " + ex.Message;
				result = false;
			}
			return result;
		}

		// Token: 0x0600006B RID: 107 RVA: 0x000055C4 File Offset: 0x000037C4
		public bool SuaQLXuongCa123(QLXuongCaEntity Entity, ref string error)
		{
			bool result;
			try
			{
				string sql = " update QLXuongCa set GioXuongCa=@GioXuongCa , TrangThai=@TrangThai  where  Id=@Id   ";
				bool flag = this.DB.ProcessData(sql, CommandType.Text, ref error, new SqlParameter[]
				{
					new SqlParameter("@Id", Entity.Id),
					new SqlParameter("@GioXuongCa", Entity.GioXuongCa),
					new SqlParameter("@TrangThai", Entity.TrangThai)
				});
				result = flag;
			}
			catch (Exception ex)
			{
				error = "连接失败: " + ex.Message;
				result = false;
			}
			return result;
		}

		// Token: 0x0400000F RID: 15
		private Database DB = new Database();
	}
}
