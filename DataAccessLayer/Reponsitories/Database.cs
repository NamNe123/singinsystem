using System;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer.Reponsitories
{
	// Token: 0x02000004 RID: 4
	public class Database
	{
		// Token: 0x0600000B RID: 11 RVA: 0x000025C0 File Offset: 0x000007C0
		public Database()
		{
			try
			{
				this.connString = @"Data Source=DESKTOP-2QKH5AF\SQLEXPRESS;Initial Catalog=Learning_QLBH;Integrated Security=True";
				this.connect = new SqlConnection(this.connString);
				this.command = new SqlCommand();
				this.command.Connection = this.connect;
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}

		// Token: 0x0600000C RID: 12 RVA: 0x0000264C File Offset: 0x0000084C
		public DataTable GetDataFromDB(string sql, CommandType commandtype, ref string error, params SqlParameter[] paramlist)
		{
			DataTable result;
			try
			{
				this.connect.Open();
				this.command.CommandText = sql;
				this.command.CommandType = commandtype;
				this.command.Parameters.Clear();
				bool flag = paramlist != null;
				if (flag)
				{
					foreach (SqlParameter value in paramlist)
					{
						this.command.Parameters.Add(value);
					}
				}
				SqlDataReader reader = this.command.ExecuteReader();
				DataTable dataTable = new DataTable();
				dataTable.Load(reader);
				error = "";
				result = dataTable;
			}
			catch (Exception ex)
			{
				error = "Ket noi lôi: " + ex.Message;
				result = null;
			}
			finally
			{
				this.connect.Close();
			}
			return result;
		}

		// Token: 0x0600000D RID: 13 RVA: 0x0000273C File Offset: 0x0000093C
		public object GetValueFromDB(string sql, CommandType commandtype, ref string error, params SqlParameter[] paramlist)
		{
			object result;
			try
			{
				this.connect.Open();
				this.command.CommandText = sql;
				this.command.CommandType = commandtype;
				this.command.Parameters.Clear();
				bool flag = paramlist != null;
				if (flag)
				{
					foreach (SqlParameter value in paramlist)
					{
						this.command.Parameters.Add(value);
					}
				}
				object obj = this.command.ExecuteScalar();
				error = "";
				result = obj;
			}
			catch (Exception ex)
			{
				error = "Ket noi lôi: " + ex.Message;
				result = null;
			}
			finally
			{
				this.connect.Close();
			}
			return result;
		}

		// Token: 0x0600000E RID: 14 RVA: 0x0000281C File Offset: 0x00000A1C
		public bool ProcessData(string sql, CommandType commandtype, ref string error, params SqlParameter[] paramlist)
		{
			bool result;
			try
			{
				this.connect.Open();
				this.command.CommandText = sql;
				this.command.CommandType = commandtype;
				this.command.Parameters.Clear();
				bool flag = paramlist != null;
				if (flag)
				{
					foreach (SqlParameter value in paramlist)
					{
						this.command.Parameters.Add(value);
					}
				}
				int num = this.command.ExecuteNonQuery();
				bool flag2 = num == 0;
				if (flag2)
				{
					error = "";
					result = false;
				}
				else
				{
					result = true;
				}
			}
			catch (Exception ex)
			{
				error = "Ket noi lôi: " + ex.Message;
				result = false;
			}
			finally
			{
				this.connect.Close();
			}
			return result;
		}

		// Token: 0x04000003 RID: 3
		private SqlConnection connect = null;

		// Token: 0x04000004 RID: 4
		private SqlCommand command = null;

		// Token: 0x04000005 RID: 5
		private string connString = "";
	}
}
