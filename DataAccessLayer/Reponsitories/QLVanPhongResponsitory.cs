using System;
using System.Data;
using System.Data.SqlClient;
using DataAccessLayer.Entity;

namespace DataAccessLayer.Reponsitories
{
	// Token: 0x0200000C RID: 12
	public class QLVanPhongResponsitory
	{
		// Token: 0x06000035 RID: 53 RVA: 0x00003AC4 File Offset: 0x00001CC4
		public DataTable HienThiDanhSachQLVanPhong(ref string error)
		{
			DataTable result;
			try
			{
				string sql = " select Id, Ten  from QLVanPhong  ";
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

		// Token: 0x06000036 RID: 54 RVA: 0x00003B1C File Offset: 0x00001D1C
		public DataTable LayTenQLVanPhong(ref string error)
		{
			DataTable result;
			try
			{
				string sql = " SELECT TOP 1 Ten FROM QLVanPhong  ";
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

		// Token: 0x06000037 RID: 55 RVA: 0x00003B74 File Offset: 0x00001D74
		public bool XoaQLVanPhong(string Id, ref string error)
		{
			bool result;
			try
			{
				string sql = " delete from QLVanPhong where Id like @Id";
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

		// Token: 0x06000038 RID: 56 RVA: 0x00003BDC File Offset: 0x00001DDC
		public bool ThemQLVanPhong(QLVanPhongEntity Entity, ref string error)
		{
			bool result;
			try
			{
				string sql = " insert into QLVanPhong(Id,Ten)  values( @Id,  @Ten)";
				bool flag = this.DB.ProcessData(sql, CommandType.Text, ref error, new SqlParameter[]
				{
					new SqlParameter("@Id", Entity.Id),
					new SqlParameter("@Ten", Entity.Ten)
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

		// Token: 0x06000039 RID: 57 RVA: 0x00003C60 File Offset: 0x00001E60
		public bool SuaQLVanPhong(QLVanPhongEntity Entity, ref string error)
		{
			bool result;
			try
			{
				string sql = " update QLVanPhong set Ten=@Ten  where  Id=@Id   ";
				bool flag = this.DB.ProcessData(sql, CommandType.Text, ref error, new SqlParameter[]
				{
					new SqlParameter("@Id", Entity.Id),
					new SqlParameter("@Ten", Entity.Ten)
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

		// Token: 0x0400000D RID: 13
		private Database DB = new Database();
	}
}
