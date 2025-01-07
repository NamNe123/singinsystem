using System;
using System.Data;
using System.Data.SqlClient;
using DataAccessLayer.Entity;

namespace DataAccessLayer.Reponsitories
{
	// Token: 0x02000002 RID: 2
	public class BangGiaChiTietResponsitory
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		public DataTable HienThiDanhSachBangGiaChiTiet(string tenbg, ref string error)
		{
			DataTable result;
			try
			{
				string sql = " select MaBangGia from BangGia   where TenBangGia = N'" + tenbg + " ' ";
				DataTable dataFromDB = this.DB.GetDataFromDB(sql, CommandType.Text, ref error, new SqlParameter[0]);
				string sql2 = " select bg.MaSanPham, sp.TenSanPham, dv.TenDVT, bg.DonGia  from BangGiaChiTiet bg   JOIN SanPham sp ON bg.MaSanPham = sp.MaSanPham   JOIN DonViTinh dv ON sp.MaDVT = dv.MaDVT   where MaBangGia = " + Convert.ToInt32(dataFromDB.Rows[0]["MaBangGia"]).ToString();
				DataTable dataFromDB2 = this.DB.GetDataFromDB(sql2, CommandType.Text, ref error, new SqlParameter[0]);
				result = dataFromDB2;
			}
			catch (Exception ex)
			{
				error = "Ket noi lôi: " + ex.Message;
				result = null;
			}
			return result;
		}

		// Token: 0x06000002 RID: 2 RVA: 0x000020FC File Offset: 0x000002FC
		public bool XoaBangGiaChiTiet(string tenbg, string TenSanPham, ref string error)
		{
			bool result;
			try
			{
				string sql = " select MaBangGia from BangGia   where TenBangGia = N'" + tenbg + " ' ";
				DataTable dataFromDB = this.DB.GetDataFromDB(sql, CommandType.Text, ref error, new SqlParameter[0]);
				object obj = dataFromDB.Rows[0]["MaBangGia"];
				string sql2 = " select MaSanPham from SanPham   where TenSanPham = N'" + TenSanPham + " ' ";
				DataTable dataFromDB2 = this.DB.GetDataFromDB(sql2, CommandType.Text, ref error, new SqlParameter[0]);
				object obj2 = dataFromDB2.Rows[0]["MaSanPham"];
				string sql3 = string.Concat(new string[]
				{
					" delete from BangGiaChiTiet where MaBangGia = N'",
					(obj != null) ? obj.ToString() : null,
					"'and MaSanPham = N'",
					(obj2 != null) ? obj2.ToString() : null,
					"'"
				});
				bool flag = this.DB.ProcessData(sql3, CommandType.Text, ref error, new SqlParameter[0]);
				result = flag;
			}
			catch (Exception ex)
			{
				error = "Ket noi lôi: " + ex.Message;
				result = false;
			}
			return result;
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002218 File Offset: 0x00000418
		public bool ThemBangGiaChiTiet(BangGiaChiTietEntity Entity, ref string error)
		{
			bool result;
			try
			{
				string sql = " select MaBangGia from BangGia   where TenBangGia = N'" + Entity.TenBangGia + " ' ";
				DataTable dataFromDB = this.DB.GetDataFromDB(sql, CommandType.Text, ref error, new SqlParameter[0]);
				object value = dataFromDB.Rows[0]["MaBangGia"];
				string sql2 = " select MaSanPham from SanPham   where TenSanPham = N'" + Entity.TenSanPham + " ' ";
				DataTable dataFromDB2 = this.DB.GetDataFromDB(sql2, CommandType.Text, ref error, new SqlParameter[0]);
				object value2 = dataFromDB2.Rows[0]["MaSanPham"];
				string sql3 = " insert into BangGiaChiTiet(MaBangGia, MaSanPham, DonGia)  values(@MaBangGia,  @MaSanPham,  @DonGia )";
				bool flag = this.DB.ProcessData(sql3, CommandType.Text, ref error, new SqlParameter[]
				{
					new SqlParameter("@MaBangGia", value),
					new SqlParameter("@MaSanPham", value2),
					new SqlParameter("@DonGia", Entity.DonGia)
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

		// Token: 0x06000004 RID: 4 RVA: 0x00002330 File Offset: 0x00000530
		public bool SuaBangGiaChiTiet(BangGiaChiTietEntity Entity, ref string error)
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

		// Token: 0x04000001 RID: 1
		private Database DB = new Database();
	}
}
