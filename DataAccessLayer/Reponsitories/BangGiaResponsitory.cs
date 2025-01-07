using System;
using System.Data;
using System.Data.SqlClient;
using DataAccessLayer.Entity;

namespace DataAccessLayer.Reponsitories
{
	// Token: 0x02000003 RID: 3
	public class BangGiaResponsitory
	{
		// Token: 0x06000006 RID: 6 RVA: 0x000023C4 File Offset: 0x000005C4
		public DataTable HienThiDanhSachBangGia(ref string error)
		{
			DataTable result;
			try
			{
				string sql = " select MaBangGia, TenBangGia from BangGia  ";
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

		// Token: 0x06000007 RID: 7 RVA: 0x0000241C File Offset: 0x0000061C
		public bool XoaBangGia(string TenBangGia, ref string error)
		{
			bool result;
			try
			{
				string sql = " delete from BangGia where TenBangGia like @TenBangGia";
				bool flag = this.DB.ProcessData(sql, CommandType.Text, ref error, new SqlParameter[]
				{
					new SqlParameter("@TenBangGia", TenBangGia)
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

		// Token: 0x06000008 RID: 8 RVA: 0x00002484 File Offset: 0x00000684
		public bool ThemBangGia(BangGiaEntity Entity, ref string error)
		{
			bool result;
			try
			{
				string sql = " insert into BangGia(TenBangGia, TinhTrang, NgayTao, NguoiTao)  values(@TenBangGia,  @TinhTrang,  @NgayTao,  @NguoiTao)";
				bool flag = this.DB.ProcessData(sql, CommandType.Text, ref error, new SqlParameter[]
				{
					new SqlParameter("@TenBangGia", Entity.TenBangGia),
					new SqlParameter("@TinhTrang", Entity.TinhTrang),
					new SqlParameter("@NgayTao", Entity.NgayTao),
					new SqlParameter("@NguoiTao", Entity.NguoiTao)
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

		// Token: 0x06000009 RID: 9 RVA: 0x0000252C File Offset: 0x0000072C
		public bool SuaBangGia(BangGiaEntity Entity, ref string error)
		{
			bool result;
			try
			{
				string sql = " update BangGia set TenBangGia=@TenBangGia,   where MaBangGia like @MaBangGia";
				bool flag = this.DB.ProcessData(sql, CommandType.Text, ref error, new SqlParameter[]
				{
					new SqlParameter("@TenBangGia", Entity.TenBangGia),
					new SqlParameter("@MaBangGia", Entity.MaBangGia)
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

		// Token: 0x04000002 RID: 2
		private Database DB = new Database();
	}
}
