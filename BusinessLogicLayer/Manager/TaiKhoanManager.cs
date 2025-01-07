using System;
using System.Data;
using DataAccessLayer.Entity;
using DataAccessLayer.Reponsitories;

namespace BusinessLogicLayer.Manager
{
	// Token: 0x02000010 RID: 16
	public class TaiKhoanManager
	{
		// Token: 0x06000057 RID: 87 RVA: 0x0000361D File Offset: 0x0000181D
		public TaiKhoanManager()
		{
			this.process = new TaiKhoanResponsitory();
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00003634 File Offset: 0x00001834
		public DataTable HienThiDanhSachTaiKhoan(ref string error)
		{
			return this.process.HienThiDanhSachTaiKhoan(ref error);
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00003654 File Offset: 0x00001854
		public bool XoaTaiKhoan(string tendangnhap, ref string error)
		{
			bool flag = string.IsNullOrEmpty(tendangnhap);
			bool result;
			if (flag)
			{
				error = "请选要删除的账号 ！";
				result = false;
			}
			else
			{
				result = this.process.XoaTaiKhoan(tendangnhap, ref error);
			}
			return result;
		}

		// Token: 0x0600005A RID: 90 RVA: 0x0000368C File Offset: 0x0000188C
		public bool ThemTaiKhoan(TaiKhoanEntity Entity, ref string error)
		{
			bool flag = string.IsNullOrEmpty(Entity.TenDangNhap);
			bool result;
			if (flag)
			{
				error = "输入账号 ！";
				result = false;
			}
			else
			{
				bool flag2 = string.IsNullOrEmpty(Entity.TenDayDu);
				if (flag2)
				{
					error = "输入整个账号名称 !";
					result = false;
				}
				else
				{
					bool flag3 = string.IsNullOrEmpty(Entity.MatKhau);
					if (flag3)
					{
						error = "输入密码 ！";
						result = false;
					}
					else
					{
						result = this.process.ThemTaiKhoan(Entity, ref error);
					}
				}
			}
			return result;
		}

		// Token: 0x0600005B RID: 91 RVA: 0x000036FC File Offset: 0x000018FC
		public bool SuaTaiKhoan(TaiKhoanEntity Entity, ref string error)
		{
			bool flag = string.IsNullOrEmpty(Entity.TenDangNhap);
			bool result;
			if (flag)
			{
				error = "输入账号 ！";
				result = false;
			}
			else
			{
				bool flag2 = string.IsNullOrEmpty(Entity.TenDayDu);
				if (flag2)
				{
					error = "输入整个账号名称 !";
					result = false;
				}
				else
				{
					bool flag3 = string.IsNullOrEmpty(Entity.MatKhau);
					if (flag3)
					{
						error = "输入密码 ！";
						result = false;
					}
					else
					{
						result = this.process.SuaTaiKhoan(Entity, ref error);
					}
				}
			}
			return result;
		}

		// Token: 0x04000012 RID: 18
		private TaiKhoanResponsitory process;
	}
}
