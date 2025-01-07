using System;
using System.Data;
using System.Data.SqlClient;
using DataAccessLayer.Entity;

namespace DataAccessLayer.Reponsitories
{
	// Token: 0x02000005 RID: 5
	public class DonDatHangChiTietResponsitory
	{
		// Token: 0x0600000F RID: 15 RVA: 0x0000290C File Offset: 0x00000B0C
		public DonDatHangChiTietResponsitory()
		{
			this.DB = new Database();
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002928 File Offset: 0x00000B28
		public DataTable DonDatHangChiTiet_LayDanhSach(string madh, ref string error)
		{
			DataTable result;
			try
			{
				result = this.DB.GetDataFromDB("select * from DonDatHangChiTiet where MaDatHang = N'" + madh + "'", CommandType.Text, ref error, new SqlParameter[0]);
			}
			catch (Exception ex)
			{
				error = ex.Message;
				result = null;
			}
			return result;
		}

		// Token: 0x06000011 RID: 17 RVA: 0x0000297C File Offset: 0x00000B7C
		public bool ThemDonDatHangChiTiet(DonDatHangChiTietEntity Entity, ref string error)
		{
			bool result;
			try
			{
				string sql = " insert into DonDatHangChiTiet(MaDatHang, MaSanPham, SoLuongDat, DonGia, ThanhTien)  values(@MaDatHang,  @MaSanPham,  @SoLuongDat,  @DonGia,  @ThanhTien)";
				bool flag = this.DB.ProcessData(sql, CommandType.Text, ref error, new SqlParameter[]
				{
					new SqlParameter("@MaDatHang", Entity.MaDatHang),
					new SqlParameter("@MaSanPham", Entity.MaSanPham),
					new SqlParameter("@SoLuongDat", Entity.SoLuongDat),
					new SqlParameter("@DonGia", Entity.DonGia),
					new SqlParameter("@ThanhTien", Entity.ThanhTien)
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

		// Token: 0x06000012 RID: 18 RVA: 0x00002A44 File Offset: 0x00000C44
		public bool DonDatHangChiTiet_Xoa(string madathang, string masanpham, ref string error)
		{
			bool result;
			try
			{
				result = this.DB.ProcessData("delete from DonDatHangChiTiet where madathang = @madathang and masanpham = @masanpham", CommandType.Text, ref error, new SqlParameter[]
				{
					new SqlParameter("@madathang", madathang),
					new SqlParameter("@masanpham", masanpham)
				});
			}
			catch (Exception ex)
			{
				error = ex.Message;
				result = false;
			}
			return result;
		}

		// Token: 0x04000006 RID: 6
		private Database DB = null;
	}
}
