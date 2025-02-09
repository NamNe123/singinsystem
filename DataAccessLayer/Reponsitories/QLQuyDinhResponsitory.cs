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
		public DataTable TenQuyDinhById(int Id, ref string error)
		{
			DataTable result;
			try
			{
				string sql = " select Id, QuyDinh  from QLQuyDinh where Id=@Id ";
				DataTable dataFromDB = this.DB.GetDataFromDB(sql, CommandType.Text, ref error, new SqlParameter[]
				{
					new SqlParameter("@Id", Id)
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
		public bool ImportQLQuyDinh(DataTable dataTable, ref string error)
		{
			bool result;
			try
			{
				foreach (object obj in dataTable.Rows)
				{
					DataRow dataRow = (DataRow)obj;
					int id = Convert.ToInt32(dataRow["ID"]);
					string quydinh = dataRow["规定"].ToString();
					string diembitru = dataRow["扣分"].ToString();
					string kieu = dataRow["类型"].ToString();
					int num2 = 0;
					DataTable dataTable2 = this.TenQuyDinhById(id, ref error);
					bool flag = dataTable2.Rows.Count > 0;
					if (flag)
					{
						num2 = int.Parse(dataTable2.Rows[0]["Id"].ToString());
					}
					bool flag2 = id != num2;
					if (flag2)
					{
						string sql = "INSERT INTO QLQuyDinh(Id, QuyDinh, DiemBiTru, Kieu) VALUES(@Id, @QuyDinh, @DiemBiTru, @Kieu)";
						bool flag3 = this.DB.ProcessData(sql, CommandType.Text, ref error, new SqlParameter[]
						{
							new SqlParameter("@Id", id),
							new SqlParameter("@QuyDinh", quydinh),
							new SqlParameter("@DiemBiTru", diembitru),
							new SqlParameter("@Kieu", kieu)
						});
					}
					else
					{
						string sql2 = " update QLQuyDinh set QuyDinh=@QuyDinh, DiemBiTru=@DiemBiTru, Kieu=@Kieu  where  Id=@Id   ";
						bool flag4 = this.DB.ProcessData(sql2, CommandType.Text, ref error, new SqlParameter[]
						{
							new SqlParameter("@Id", id),
							new SqlParameter("@QuyDinh", quydinh),
							new SqlParameter("@DiemBiTru", diembitru),
							new SqlParameter("@Kieu", kieu)
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
		// Token: 0x0400000C RID: 12
		private Database DB = new Database();
	}
}
