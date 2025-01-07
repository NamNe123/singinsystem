using System;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer.Reponsitories
{
	// Token: 0x0200000F RID: 15
	public class QuyenDangNhapResponsitory
	{
		// Token: 0x0600006D RID: 109 RVA: 0x00005674 File Offset: 0x00003874
		public DataTable HienThiDanhSachQuyenDangNhap(ref string error)
		{
			DataTable result;
			try
			{
				string sql = " select *  from QuyenDangNhap where tinhtrang='Y'";
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

		// Token: 0x04000010 RID: 16
		private Database DB = new Database();
	}
}
