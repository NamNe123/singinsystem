using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using singinsystem.MainForm;

namespace singinsystem.Login
{
	// Token: 0x0200001C RID: 28
	public partial class frmLogin : Form
	{
		// Token: 0x060000C8 RID: 200 RVA: 0x00019ED4 File Offset: 0x000180D4
		public frmLogin()
		{
			this.InitializeComponent();
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x00003685 File Offset: 0x00001885
		private void btnThoat_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x060000CA RID: 202 RVA: 0x00019EEC File Offset: 0x000180EC
		private void btnDangNhap_Click(object sender, EventArgs e)
		{
			bool flag = string.IsNullOrEmpty(this.txtDangNhap.Text) || string.IsNullOrEmpty(this.txtMatKhau.Text);
			if (flag)
			{
				MessageBox.Show("Chua nhap ten dang nhap hoac mat khau!");
			}
			else
			{
				string connectionString = @"Data Source=DESKTOP-2QKH5AF\SQLEXPRESS;Initial Catalog=Learning_QLBH;Integrated Security=True";
				SqlConnection sqlConnection = null;
				try
				{
					sqlConnection = new SqlConnection(connectionString);
					sqlConnection.Open();
					string commandText = string.Concat(new string[]
					{
						"select tendaydu from TaiKhoan where TenDangNhap like '",
						this.txtDangNhap.Text,
						"' and MatKhau like '",
						this.txtMatKhau.Text,
						"'"
					});
					object obj = new SqlCommand
					{
						Connection = sqlConnection,
						CommandText = commandText,
						CommandType = CommandType.Text
					}.ExecuteScalar();
					bool flag2 = obj == null;
					if (flag2)
					{
						MessageBox.Show("登录失败 ！");
					}
					else
					{
						clsCauHinhHeThong.TenDangNhap = this.txtDangNhap.Text;
						clsCauHinhHeThong.TenDayDu = obj.ToString();
						frmMainForm frmMainForm = new frmMainForm(obj.ToString());
						base.Close();
						frmLogin.LuuThongTin.KiemTra = 1;
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("连接失败: " + ex.Message);
				}
				finally
				{
					sqlConnection.Close();
				}
			}
		}

		// Token: 0x0200003E RID: 62
		public class LuuThongTin
		{
			// Token: 0x040001F7 RID: 503
			public static int KiemTra;
		}
	}
}
