using System;
using System.Data;
using System.Data.SqlClient;
using DataAccessLayer.Entity;

namespace DataAccessLayer.Reponsitories
{
	// Token: 0x02000006 RID: 6
	public class DonDatHangResponsitory
	{
		// Token: 0x06000013 RID: 19 RVA: 0x00002AAC File Offset: 0x00000CAC
		public DonDatHangResponsitory()
		{
			this.DB = new Database();
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002AC8 File Offset: 0x00000CC8
		public DataTable DonDatHang_LayDanhSach(ref string error)
		{
			DataTable result;
			try
			{
				result = this.DB.GetDataFromDB("select * from dondathang", CommandType.Text, ref error, new SqlParameter[0]);
			}
			catch (Exception ex)
			{
				error = ex.Message;
				result = null;
			}
			return result;
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002B14 File Offset: 0x00000D14
		public bool ThemDonDatHang(DonDatHangEntity Entity, ref string error)
		{
			bool result;
			try
			{
				string sql = " insert into DonDatHang(MaDatHang, NgayDatHang, MaKhachHang, MaBangGia, NgayTao, NguoiTao, NgayGiaoHang, TinhTrang, DaChotDon  )  values(@MaDatHang,  @NgayDatHang,  @MaKhachHang,  @MaBangGia,  @NgayTao,  @NguoiTao,  @NgayGiaoHang,  @TinhTrang,  @DaChotDon)";
				bool flag = this.DB.ProcessData(sql, CommandType.Text, ref error, new SqlParameter[]
				{
					new SqlParameter("@MaDatHang", Entity.MaDatHang),
					new SqlParameter("@NgayDatHang", Entity.NgayDatHang),
					new SqlParameter("@MaKhachHang", Entity.MaKhachHang),
					new SqlParameter("@MaBangGia", Entity.MaBangGia),
					new SqlParameter("@NgayTao", Entity.NgayTao),
					new SqlParameter("@NguoiTao", Entity.NguoiTao),
					new SqlParameter("@NgayGiaoHang", Entity.NgayGiaoHang),
					new SqlParameter("@TinhTrang", Entity.TinhTrang),
					new SqlParameter("@DaChotDon", Entity.DaChotDon)
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

		// Token: 0x06000016 RID: 22 RVA: 0x00002C2C File Offset: 0x00000E2C
		public bool DonDatHang_Xoa(string mamuonxoa, ref string error)
		{
			bool result;
			try
			{
				result = this.DB.ProcessData("delete from dondathang where madathang = @madathang", CommandType.Text, ref error, new SqlParameter[]
				{
					new SqlParameter("@madathang", mamuonxoa)
				});
			}
			catch (Exception ex)
			{
				error = ex.Message;
				result = false;
			}
			return result;
		}

		// Token: 0x04000007 RID: 7
		private Database DB = null;
	}
}
