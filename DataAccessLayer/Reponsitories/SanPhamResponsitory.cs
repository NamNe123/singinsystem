using System;
using System.Data;
using System.Data.SqlClient;
using DataAccessLayer.Entity;

namespace DataAccessLayer.Reponsitories
{
	// Token: 0x02000010 RID: 16
	public class SanPhamResponsitory
	{
		// Token: 0x0600006F RID: 111 RVA: 0x000056E0 File Offset: 0x000038E0
		public DataTable HienThiDanhSachSanPham(ref string error)
		{
			DataTable result;
			try
			{
				string sql = " select sp.MaSanPham, sp.TenSanPham, dv.TenDVT from SanPham sp   join DonViTinh dv ON sp.MaDVT = dv.MaDVT ";
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

		// Token: 0x06000070 RID: 112 RVA: 0x00005738 File Offset: 0x00003938
		public bool XoaSanPham(string MaSanPham, ref string error)
		{
			bool result;
			try
			{
				string sql = " delete from SanPham where MaSanPham like @MaSanPham";
				bool flag = this.DB.ProcessData(sql, CommandType.Text, ref error, new SqlParameter[]
				{
					new SqlParameter("@MaSanPham", MaSanPham)
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

		// Token: 0x06000071 RID: 113 RVA: 0x000057A0 File Offset: 0x000039A0
		public bool ThemSanPham(SanPhamEntity Entity, ref string error)
		{
			bool result;
			try
			{
				string sql = " insert into SanPham(TenSanPham, TinhTrang, NgayTao, NguoiTao)  values(@TenSanPham,  @TinhTrang,  @NgayTao,  @NguoiTao)";
				bool flag = this.DB.ProcessData(sql, CommandType.Text, ref error, new SqlParameter[]
				{
					new SqlParameter("@TenSanPham", Entity.TenSanPham),
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

		// Token: 0x06000072 RID: 114 RVA: 0x00005848 File Offset: 0x00003A48
		public bool SuaSanPham(SanPhamEntity Entity, ref string error)
		{
			bool result;
			try
			{
				string sql = " update SanPham set TenSanPham=@TenSanPham,   where MaSanPham like @MaSanPham";
				bool flag = this.DB.ProcessData(sql, CommandType.Text, ref error, new SqlParameter[]
				{
					new SqlParameter("@TenSanPham", Entity.TenSanPham),
					new SqlParameter("@MaSanPham", Entity.MaSanPham)
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

		// Token: 0x04000011 RID: 17
		private Database DB = new Database();
	}
}
