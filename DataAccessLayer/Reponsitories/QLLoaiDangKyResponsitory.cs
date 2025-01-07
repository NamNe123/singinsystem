using System;
using System.Data;
using System.Data.SqlClient;
using DataAccessLayer.Entity;

namespace DataAccessLayer.Reponsitories
{
	// Token: 0x02000009 RID: 9
	public class QLLoaiDangKyResponsitory
	{
		// Token: 0x06000022 RID: 34 RVA: 0x00003168 File Offset: 0x00001368
		public DataTable HienThiDanhSachQLLoaiDangKy(ref string error)
		{
			DataTable result;
			try
			{
				string sql = " select Id, Kieu, ThoiGian, SoLan  from QLLoaiDangKy  ";
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

		// Token: 0x06000023 RID: 35 RVA: 0x000031C0 File Offset: 0x000013C0
		public bool XoaQLLoaiDangKy(string Id, ref string error)
		{
			bool result;
			try
			{
				string sql = " delete from QLLoaiDangKy where Id like @Id";
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

		// Token: 0x06000024 RID: 36 RVA: 0x00003228 File Offset: 0x00001428
		public bool ThemQLLoaiDangKy(QLLoaiDangKyEntity Entity, ref string error)
		{
			bool result;
			try
			{
				string sql = " insert into QLLoaiDangKy(Id,Kieu,ThoiGian,SoLan)  values( @Id,  @Kieu,  @ThoiGian,  @SoLan)";
				bool flag = this.DB.ProcessData(sql, CommandType.Text, ref error, new SqlParameter[]
				{
					new SqlParameter("@Id", Entity.Id),
					new SqlParameter("@Kieu", Entity.Kieu),
					new SqlParameter("@ThoiGian", Entity.ThoiGian),
					new SqlParameter("@SoLan", Entity.SoLan)
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

		// Token: 0x06000025 RID: 37 RVA: 0x000032DC File Offset: 0x000014DC
		public bool SuaQLLoaiDangKy(QLLoaiDangKyEntity Entity, ref string error)
		{
			bool result;
			try
			{
				string sql = " update QLLoaiDangKy set Kieu=@Kieu , ThoiGian=@ThoiGian, SoLan=@SoLan where  Id=@Id   ";
				bool flag = this.DB.ProcessData(sql, CommandType.Text, ref error, new SqlParameter[]
				{
					new SqlParameter("@Id", Entity.Id),
					new SqlParameter("@Kieu", Entity.Kieu),
					new SqlParameter("@ThoiGian", Entity.ThoiGian),
					new SqlParameter("@SoLan", Entity.SoLan)
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

		// Token: 0x0400000A RID: 10
		private Database DB = new Database();
	}
}
