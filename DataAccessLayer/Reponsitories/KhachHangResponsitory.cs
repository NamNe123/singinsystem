using System;
using System.Data;
using System.Data.SqlClient;
using DataAccessLayer.Entity;

namespace DataAccessLayer.Reponsitories
{
	// Token: 0x02000008 RID: 8
	public class KhachHangResponsitory
	{
		// Token: 0x0600001C RID: 28 RVA: 0x00002E8C File Offset: 0x0000108C
		public DataTable LayDuLieuKhachHang(ref string error)
		{
			DataTable result;
			try
			{
				string sql = " select kh.*, tt.TenTinhThanh  from KhachHang kh inner join TinhThanh tt on kh.MaTinhThanh=tt.MaTinhThanh  where kh.TinhTrang='Y'";
				result = this.DB.GetDataFromDB(sql, CommandType.Text, ref error, new SqlParameter[0]);
			}
			catch (Exception ex)
			{
				error = ex.Message;
				result = null;
			}
			return result;
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00002ED8 File Offset: 0x000010D8
		public bool ThemKhachHang(KhachHangEntity khachhang, ref string error)
		{
			bool result;
			try
			{
				string sql = "insert into KhachHang(MaKhachHang,TenKhachHang,DiaChi,CCCD,MaSoThue,TinhTrang,NgayTao,NguoiTao,MaTinhThanh)  values(@MaKhachHang,@TenKhachHang,@DiaChi,@CCCD,@MaSoThue,'Y',getdate(),@NguoiTao,@MaTinhThanh) ";
				bool flag = this.DB.ProcessData(sql, CommandType.Text, ref error, new SqlParameter[]
				{
					new SqlParameter("@MaKhachHang", khachhang.MaKhachHang),
					new SqlParameter("@TenKhachHang", khachhang.TenKhachHang),
					new SqlParameter("@DiaChi", khachhang.DiaChi),
					new SqlParameter("@CCCD", khachhang.CCCD),
					new SqlParameter("@MaSoThue", khachhang.MaSoThue),
					new SqlParameter("@NguoiTao", khachhang.NguoiTao),
					new SqlParameter("@MaTinhThanh", khachhang.MaTinhThanh)
				});
				result = flag;
			}
			catch (Exception ex)
			{
				error = ex.Message;
				result = false;
			}
			return result;
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00002FAC File Offset: 0x000011AC
		public bool XoaKhachHang(KhachHangEntity khachhang, ref string error)
		{
			bool result;
			try
			{
				string sql = "delete from khachhang where MaKhachHang = @makhachhang ";
				bool flag = this.DB.ProcessData(sql, CommandType.Text, ref error, new SqlParameter[]
				{
					new SqlParameter("@makhachhang", khachhang.MaKhachHang)
				});
				result = flag;
			}
			catch (Exception ex)
			{
				error = ex.Message;
				result = false;
			}
			return result;
		}

		// Token: 0x0600001F RID: 31 RVA: 0x0000300C File Offset: 0x0000120C
		public bool SuaKhachHang(KhachHangEntity khachhang, ref string error)
		{
			bool result;
			try
			{
				string sql = " update KhachHang  set TenKhachHang = @tenkhachhang,     DiaChi = @diachi, CCCD = @cccd, MaSoThue = @masothue, TinhTrang = @tinhtrang,     NgayTao = GETDATE(), NguoiTao = @nguoitao, MaTinhThanh = @matinthanh where MaKhachHang = @makhachhang";
				bool flag = this.DB.ProcessData(sql, CommandType.Text, ref error, new SqlParameter[]
				{
					new SqlParameter("@tenkhachhang", khachhang.TenKhachHang),
					new SqlParameter("@diachi", khachhang.DiaChi),
					new SqlParameter("@cccd", khachhang.CCCD),
					new SqlParameter("@masothue", khachhang.MaSoThue),
					new SqlParameter("@tinhtrang", khachhang.TinhTrang),
					new SqlParameter("@nguoitao", khachhang.NguoiTao),
					new SqlParameter("@matinthanh", khachhang.MaTinhThanh)
				});
				result = flag;
			}
			catch (Exception ex)
			{
				error = ex.Message;
				result = false;
			}
			return result;
		}

		// Token: 0x06000020 RID: 32 RVA: 0x000030E0 File Offset: 0x000012E0
		public string LayMaKhachHangLonNhat(ref string error)
		{
			string result;
			try
			{
				string sql = "select max(makhachhang)from KhachHang";
				object valueFromDB = this.DB.GetValueFromDB(sql, CommandType.Text, ref error, new SqlParameter[0]);
				bool flag = valueFromDB == null || Convert.IsDBNull(valueFromDB);
				if (flag)
				{
					result = "KH00000000";
				}
				else
				{
					result = valueFromDB.ToString();
				}
			}
			catch (Exception ex)
			{
				error = ex.Message;
				result = "";
			}
			return result;
		}

		// Token: 0x04000009 RID: 9
		private Database DB = new Database();
	}
}
