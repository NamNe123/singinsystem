using System;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer.Reponsitories
{
	// Token: 0x02000012 RID: 18
	public class TinhThanhResponsitory
	{
		// Token: 0x06000079 RID: 121 RVA: 0x00005B34 File Offset: 0x00003D34
		public DataTable LayDanhSachTinhThanh(ref string error)
		{
			DataTable result;
			try
			{
				string sql = "select * from tinhthanh";
				result = this.DB.GetDataFromDB(sql, CommandType.Text, ref error, new SqlParameter[0]);
			}
			catch (Exception ex)
			{
				error = ex.Message;
				result = null;
			}
			return result;
		}

		// Token: 0x04000013 RID: 19
		private Database DB = new Database();
	}
}
