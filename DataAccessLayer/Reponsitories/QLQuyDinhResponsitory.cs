using System;
using System.Data;
using System.Data.SqlClient;
using DataAccessLayer.Entity;

namespace DataAccessLayer.Reponsitories
{
	// Token: 0x0200000B RID: 11
	public class QLQuyDinhResponsitory
	{
		// Token: 0x0600002E RID: 46 RVA: 0x000037E0 File Offset: 0x000019E0
		public DataTable HienThiDanhSachQLQuyDinh(ref string error)
		{
			DataTable result;
			try
			{
				string sql = " select Id, QuyDinh, DiemBiTru, Kieu  from QLQuyDinh  ";
				DataTable dataFromDB = this.DB.GetDataFromDB(sql, CommandType.Text, ref error, new SqlParameter[0]);
				result = dataFromDB;
			}
			catch (Exception ex)
			{
				error = "连接失败 : " + ex.Message;
				result = null;
			}
			return result;
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00003838 File Offset: 0x00001A38
		public DataTable HienThiDanhSachQLQuyDinhMain(ref string error)
		{
			DataTable result;
			try
			{
				string sql = " select QuyDinh, DiemBiTru  from QLQuyDinh where Kieu = N'打卡 - Punch in/out'";
				DataTable dataFromDB = this.DB.GetDataFromDB(sql, CommandType.Text, ref error, new SqlParameter[0]);
				result = dataFromDB;
			}
			catch (Exception ex)
			{
				error = "连接失败 : " + ex.Message;
				result = null;
			}
			return result;
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00003890 File Offset: 0x00001A90
		public DataTable HienThiDanhSachQLQuyDinhMainDiLam(ref string error)
		{
			DataTable result;
			try
			{
				string sql = " select QuyDinh, DiemBiTru  from QLQuyDinh where Kieu = N'上班 - Clock - in' ";
				DataTable dataFromDB = this.DB.GetDataFromDB(sql, CommandType.Text, ref error, new SqlParameter[0]);
				result = dataFromDB;
			}
			catch (Exception ex)
			{
				error = "连接失败 : " + ex.Message;
				result = null;
			}
			return result;
		}

		// Token: 0x06000031 RID: 49 RVA: 0x000038E8 File Offset: 0x00001AE8
		public bool XoaQLQuyDinh(string Id, ref string error)
		{
			bool result;
			try
			{
				string sql = " delete from QLQuyDinh where Id like @Id";
				bool flag = this.DB.ProcessData(sql, CommandType.Text, ref error, new SqlParameter[]
				{
					new SqlParameter("@Id", Id)
				});
				result = flag;
			}
			catch (Exception ex)
			{
				error = "连接失败 : " + ex.Message;
				result = false;
			}
			return result;
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00003950 File Offset: 0x00001B50
		public bool ThemQLQuyDinh(QLQuyDinhEntity Entity, ref string error)
		{
			bool result;
			try
			{
				string sql = " insert into QLQuyDinh(Id,QuyDinh,DiemBiTru,Kieu)  values( @Id,  @QuyDinh,  @DiemBiTru,  @Kieu)";
				bool flag = this.DB.ProcessData(sql, CommandType.Text, ref error, new SqlParameter[]
				{
					new SqlParameter("@Id", Entity.Id),
					new SqlParameter("@QuyDinh", Entity.QuyDinh),
					new SqlParameter("@DiemBiTru", Entity.DiemBiTru),
					new SqlParameter("@Kieu", Entity.Kieu)
				});
				result = flag;
			}
			catch (Exception ex)
			{
				error = "连接失败 : " + ex.Message;
				result = false;
			}
			return result;
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00003A00 File Offset: 0x00001C00
		public bool SuaQLQuyDinh(QLQuyDinhEntity Entity, ref string error)
		{
			bool result;
			try
			{
				string sql = " update QLQuyDinh set QuyDinh=@QuyDinh , DiemBiTru=@DiemBiTru, Kieu=@Kieu where  Id=@Id   ";
				bool flag = this.DB.ProcessData(sql, CommandType.Text, ref error, new SqlParameter[]
				{
					new SqlParameter("@Id", Entity.Id),
					new SqlParameter("@QuyDinh", Entity.QuyDinh),
					new SqlParameter("@DiemBiTru", Entity.DiemBiTru),
					new SqlParameter("@Kieu", Entity.Kieu)
				});
				result = flag;
			}
			catch (Exception ex)
			{
				error = "连接失败 : " + ex.Message;
				result = false;
			}
			return result;
		}

		// Token: 0x0400000C RID: 12
		private Database DB = new Database();
	}
}
