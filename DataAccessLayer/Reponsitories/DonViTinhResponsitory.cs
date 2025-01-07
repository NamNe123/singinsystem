using System;
using System.Data;
using System.Data.SqlClient;
using DataAccessLayer.Entity;

namespace DataAccessLayer.Reponsitories
{
	// Token: 0x02000007 RID: 7
	public class DonViTinhResponsitory
	{
		// Token: 0x06000017 RID: 23 RVA: 0x00002C84 File Offset: 0x00000E84
		public DataTable HienThiDanhSachDonViTinh(ref string error)
		{
			DataTable result;
			try
			{
				string sql = " select MaDVT, TenDVT, TinhTrang  from DonViTinh  ";
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

		// Token: 0x06000018 RID: 24 RVA: 0x00002CDC File Offset: 0x00000EDC
		public bool XoaDonViTinh(string MaDVT, ref string error)
		{
			bool result;
			try
			{
				string sql = " delete from DonViTinh where MaDVT like @MaDVT";
				bool flag = this.DB.ProcessData(sql, CommandType.Text, ref error, new SqlParameter[]
				{
					new SqlParameter("@MaDVT", MaDVT)
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

		// Token: 0x06000019 RID: 25 RVA: 0x00002D44 File Offset: 0x00000F44
		public bool ThemDonViTinh(DonViTinhEntity Entity, ref string error)
		{
			bool result;
			try
			{
				string sql = " insert into DonViTinh(MaDVT,TenDVT,TinhTrang, NGayTao,   NguoiTao)  values(@MaDVT,  @TenDVT,  'Y',  GETDATE(),  @NguoiTao)";
				bool flag = this.DB.ProcessData(sql, CommandType.Text, ref error, new SqlParameter[]
				{
					new SqlParameter("@MaDVT", Entity.MaDVT),
					new SqlParameter("@TenDVT", Entity.TenDVT),
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

		// Token: 0x0600001A RID: 26 RVA: 0x00002DD4 File Offset: 0x00000FD4
		public bool SuaDonViTinh(DonViTinhEntity Entity, ref string error)
		{
			bool result;
			try
			{
				string sql = " update DonViTinh set TenDVT=@TenDVT,         tinhtrang=@TinhTrang,         Ngaytao=getdate(),nguoitao=@NguoiTao   where MaDVT like @MaDVT";
				bool flag = this.DB.ProcessData(sql, CommandType.Text, ref error, new SqlParameter[]
				{
					new SqlParameter("@TenDVT", Entity.TenDVT),
					new SqlParameter("@TinhTrang", Entity.TinhTrang),
					new SqlParameter("@NguoiTao", Entity.NguoiTao),
					new SqlParameter("@MaDVT", Entity.MaDVT)
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

		// Token: 0x04000008 RID: 8
		private Database DB = new Database();
	}
}
