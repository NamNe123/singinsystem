using System;
using System.Data;
using System.Data.SqlClient;
using DataAccessLayer.Entity;

namespace DataAccessLayer.Reponsitories
{
	// Token: 0x02000011 RID: 17
	public class TaiKhoanResponsitory
	{
		// Token: 0x06000074 RID: 116 RVA: 0x000058DC File Offset: 0x00003ADC
		public DataTable HienThiDanhSachTaiKhoan(ref string error)
		{
			DataTable result;
			try
			{
				string sql = " select tendaydu,tendangnhap, maquyen,tinhtrang,matkhau  from TaiKhoan where tinhtrang='Y' ";
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

		// Token: 0x06000075 RID: 117 RVA: 0x00005934 File Offset: 0x00003B34
		public bool XoaTaiKhoan(string tendangnhap, ref string error)
		{
			bool result;
			try
			{
				string sql = " delete from TaiKhoan where TenDangNhap like @tenDN";
				bool flag = this.DB.ProcessData(sql, CommandType.Text, ref error, new SqlParameter[]
				{
					new SqlParameter("@tenDN", tendangnhap)
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

		// Token: 0x06000076 RID: 118 RVA: 0x0000599C File Offset: 0x00003B9C
		public bool ThemTaiKhoan(TaiKhoanEntity Entity, ref string error)
		{
			bool result;
			try
			{
				string sql = " insert into taikhoan(TenDangNhap,MatKhau,TenDayDu,TinhTrang, NGayTao,   MaQuyen,NguoiTao)  values(@TenDangNhap,  @MatKhau,  @TenDayDu,  'Y',  GETDATE(),  @MaQuyen,  @NguoiTao)";
				bool flag = this.DB.ProcessData(sql, CommandType.Text, ref error, new SqlParameter[]
				{
					new SqlParameter("@TenDangNhap", Entity.TenDangNhap),
					new SqlParameter("@MatKhau", Entity.MatKhau),
					new SqlParameter("@TenDayDu", Entity.TenDayDu),
					new SqlParameter("@MaQuyen", Entity.MaQuyen),
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

		// Token: 0x06000077 RID: 119 RVA: 0x00005A54 File Offset: 0x00003C54
		public bool SuaTaiKhoan(TaiKhoanEntity Entity, ref string error)
		{
			bool result;
			try
			{
				string sql = " update taikhoan set tendaydu=@TenDayDu,         matkhau=@MatKhau,tinhtrang=@TinhTrang,         maquyen=@MaQuyen,Ngaytao=getdate(),nguoitao=@NguoiTao   where tendangnhap like @TenDangNhap";
				bool flag = this.DB.ProcessData(sql, CommandType.Text, ref error, new SqlParameter[]
				{
					new SqlParameter("@TenDayDu", Entity.TenDayDu),
					new SqlParameter("@MatKhau", Entity.MatKhau),
					new SqlParameter("@TinhTrang", Entity.TinhTrang),
					new SqlParameter("@MaQuyen", Entity.MaQuyen),
					new SqlParameter("@NguoiTao", Entity.NguoiTao),
					new SqlParameter("@TenDangNhap", Entity.TenDangNhap)
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

		// Token: 0x04000012 RID: 18
		private Database DB = new Database();
	}
}
