using System;
using System.Data;
using System.Data.SqlClient;
using DataAccessLayer.Entity;

namespace DataAccessLayer.Reponsitories
{
	// Token: 0x0200000A RID: 10
	public class QLNhanSuResponsitory
	{
		// Token: 0x06000027 RID: 39 RVA: 0x000033A4 File Offset: 0x000015A4
		public DataTable HienThiDanhSachQLNhanSu(ref string error)
		{
			DataTable result;
			try
			{
				string sql = " select STT, Id, Ten  from QLNhanSu  ";
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

		// Token: 0x06000028 RID: 40 RVA: 0x000033FC File Offset: 0x000015FC
		public DataTable TenNhanSuById(int manv, ref string error)
		{
			DataTable result;
			try
			{
				string sql = " select Id, Ten  from QLNhanSu where Id=@Id ";
				DataTable dataFromDB = this.DB.GetDataFromDB(sql, CommandType.Text, ref error, new SqlParameter[]
				{
					new SqlParameter("@Id", manv)
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

		// Token: 0x06000029 RID: 41 RVA: 0x00003468 File Offset: 0x00001668
		public bool XoaQLNhanSu(string Id, ref string error)
		{
			bool result;
			try
			{
				string sql = " delete from QLNhanSu where Id like @Id";
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

		// Token: 0x0600002A RID: 42 RVA: 0x000034D0 File Offset: 0x000016D0
		public bool ThemQLNhanSu(QLNhanSuEntity Entity, ref string error)
		{
			bool result;
			try
			{
				string sql = " insert into QLNhanSu(Id,Ten,IdTen)  values( @Id,  @Ten, @IdTen)";
				bool flag = this.DB.ProcessData(sql, CommandType.Text, ref error, new SqlParameter[]
				{
					new SqlParameter("@Id", Entity.Id),
					new SqlParameter("@Ten", Entity.Ten),
					new SqlParameter("@IdTen", Entity.IdTen)
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

		// Token: 0x0600002B RID: 43 RVA: 0x00003568 File Offset: 0x00001768
		public bool ImportQLNhanSu(DataTable dataTable, ref string error)
		{
			bool result;
			try
			{
				foreach (object obj in dataTable.Rows)
				{
					DataRow dataRow = (DataRow)obj;
					int num = Convert.ToInt32(dataRow["代码"]);
					string text = dataRow["姓名"].ToString();
					string value = num.ToString() + " - " + text;
					int num2 = 0;
					DataTable dataTable2 = this.TenNhanSuById(num, ref error);
					bool flag = dataTable2.Rows.Count > 0;
					if (flag)
					{
						num2 = int.Parse(dataTable2.Rows[0]["Id"].ToString());
					}
					bool flag2 = num != num2;
					if (flag2)
					{
						string sql = "INSERT INTO QLNhanSu(Id, Ten, IdTen) VALUES(@Id, @Ten, @IdTen)";
						bool flag3 = this.DB.ProcessData(sql, CommandType.Text, ref error, new SqlParameter[]
						{
							new SqlParameter("@Id", num),
							new SqlParameter("@Ten", text),
							new SqlParameter("@IdTen", value)
						});
					}
					else
					{
						string sql2 = " update QLNhanSu set Ten=@Ten, IdTen=@IdTen  where  Id=@Id   ";
						bool flag4 = this.DB.ProcessData(sql2, CommandType.Text, ref error, new SqlParameter[]
						{
							new SqlParameter("@Id", num),
							new SqlParameter("@Ten", text),
							new SqlParameter("@IdTen", value)
						});
					}
				}
				result = true;
			}
			catch (Exception ex)
			{
				error = "Kết nối 错误 ！: test " + ex.Message + dataTable.ToString() + "test";
				result = false;
			}
			return result;
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00003748 File Offset: 0x00001948
		public bool SuaQLNhanSu(QLNhanSuEntity Entity, ref string error)
		{
			bool result;
			try
			{
				string sql = " update QLNhanSu set Ten=@Ten  where  Id=@Id   ";
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

		// Token: 0x0400000B RID: 11
		private Database DB = new Database();
	}
}
