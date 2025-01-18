using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using singinsystem.MainForm;

namespace singinsystem.Login
{
	// Token: 0x0200001B RID: 27
	public partial class frmLoginAdmin : Form
	{
		// Token: 0x060000C3 RID: 195 RVA: 0x000197CD File Offset: 0x000179CD
		public frmLoginAdmin()
		{
			this.InitializeComponent();
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x00003685 File Offset: 0x00001885
		private void btnThoat_Click(object sender, EventArgs e)
		{
			base.Close();
		}

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
						"select MaQuyen,TenDayDu from TaiKhoan where TenDangNhap like '",
						this.txtDangNhap.Text,
						"' and MatKhau like '",
						this.txtMatKhau.Text,
						"'"
					});
					string text = new SqlCommand
					{
						Connection = sqlConnection,
						CommandText = commandText,
						CommandType = CommandType.Text
					}.ExecuteScalar().ToString();
					bool flag2 = text != "A";
					if (flag2)
					{
						MessageBox.Show("登录失败 ！");
					}
					else
					{
						clsCauHinhHeThong.TenDangNhap = this.txtDangNhap.Text;
						frmMainForm frmMainForm = new frmMainForm(text.ToString());
						base.Close();
						frmLoginAdmin.LuuThongTin.KiemTra = 1;
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
		public class LuuThongTin
		{
			// Token: 0x040001F6 RID: 502
			public static int KiemTra;
		}
	}
}
