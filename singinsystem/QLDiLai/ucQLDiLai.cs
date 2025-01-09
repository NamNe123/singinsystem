using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicLayer.Manager;
using DataAccessLayer.Entity;
using Microsoft.CSharp.RuntimeBinder;
using Microsoft.Office.Interop.Excel;
using singinsystem.Login;
using singinsystem.MainForm;
using singinsystem.Properties;


namespace singinsystem.QLDiLai
{
    public partial class ucQLDiLai : UserControl
    {
		private QLDiLaiManager QLDLManager;
		private QLQuyDinhManager QLQDManager;
		private QLVanPhongManager QLVPManager;
		private string error = "";
		private bool isUpdating = false;
		private string currentText = "";
		public ucQLDiLai()
        {
            InitializeComponent();
			this.ChayLaiNgay();
			this.QLDLManager = new QLDiLaiManager();
			this.QLQDManager = new QLQuyDinhManager();
			this.QLVPManager = new QLVanPhongManager();
			this.HienThiDuLieuVao_combo_NhanSu();
			this.HienThiDuLieuVao_combo_LoaiDangKy();
			this.HienThiDanhSachQLDiLai();
			this.cleardata();
		}
		public class ComboboxItem
		{
			public string Text { get; set; }
			public string Value { get; set; }
			public override string ToString()
			{
				return this.Text;
			}
		}
		public void ChayLaiNgay()
		{
			this.dtpDen.Value = DateTime.Now.Date.AddHours(23.0).AddMinutes(59.0);
			this.dtpTu.Value = DateTime.Now.Date;
		}
		public void cleardata()
		{
			DateTime now = DateTime.Now;
			bool flag = now.Day == 15;
			if (flag)
			{
				this.QLDLManager.cleardata(now.Month, ref this.error);
			}
		}
		public void HienThiDuLieuVao_combo_NhanSu()
		{
			string connectionString = "Data Source=DESKTOP-FQPDVRO\\SQLEXPRESS;Initial Catalog=Learning_QLBH;Integrated Security=True";
			using (SqlConnection sqlConnection = new SqlConnection(connectionString))
			{
				try
				{
					sqlConnection.Open();
					string cmdText = "SELECT Id, Ten FROM QLNhanSu";
					SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
					SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
					List<string> list = new List<string>();
					this.cbNhanSu.Items.Clear();
					while (sqlDataReader.Read())
					{
						string text = sqlDataReader["Id"].ToString() + " - " + sqlDataReader["Ten"].ToString();
						list.Add(text);
						string value = sqlDataReader["Id"].ToString();
						this.cbNhanSu.Items.Add(new ucQLDiLai.ComboboxItem
						{
							Text = text,
							Value = value
						});
					}
					sqlDataReader.Close();
					this.cbNhanSu.AutoCompleteMode = AutoCompleteMode.None;
					this.cbNhanSu.AutoCompleteSource = AutoCompleteSource.None;
					this.cbNhanSu.AutoCompleteCustomSource = null;
					AutoCompleteStringCollection autoCompleteCustomSource = this.cbNhanSu.AutoCompleteCustomSource;
					if (autoCompleteCustomSource != null)
					{
						autoCompleteCustomSource.Clear();
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Error: " + ex.Message);
				}
			}
		}
		private void cbNhanSu_TextUpdate(object sender, EventArgs e)
		{
			bool flag = !this.isUpdating;
			if (flag)
			{
				this.isUpdating = true;
				string connectionString = "Data Source=DESKTOP-FQPDVRO\\SQLEXPRESS;Initial Catalog=Learning_QLBH;Integrated Security=True";
				using (SqlConnection sqlConnection = new SqlConnection(connectionString))
				{
					try
					{
						sqlConnection.Open();
						string text = this.cbNhanSu.Text;
						string cmdText = "SELECT Id, Ten FROM QLNhanSu WHERE IdTen LIKE @IdTen";
						SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
						sqlCommand.Parameters.AddWithValue("@IdTen", "%" + text + "%");
						SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
						this.currentText = this.cbNhanSu.Text;
						this.cbNhanSu.Items.Clear();
						while (sqlDataReader.Read())
						{
							string text2 = sqlDataReader["Id"].ToString();
							string str = sqlDataReader["Ten"].ToString();
							string text3 = text2 + " - " + str;
							this.cbNhanSu.Items.Add(new ucQLDiLai.ComboboxItem
							{
								Text = text3,
								Value = text2
							});
						}
						sqlDataReader.Close();
						bool flag2 = !this.cbNhanSu.DroppedDown;
						if (flag2)
						{
							this.cbNhanSu.DroppedDown = true;
						}
						this.cbNhanSu.SelectionStart = this.cbNhanSu.Text.Length;
					}
					catch (Exception ex)
					{
						MessageBox.Show("Error: " + ex.Message);
						this.cbNhanSu.DroppedDown = false;
					}
					finally
					{
						this.isUpdating = false;
						this.cbNhanSu.Text = this.currentText;
					}
					this.HienThiDanhSachQLDiLai();
				}
			}
		}
		public void HienThiDuLieuVao_combo_LoaiDangKy()
		{
			string connectionString = "Data Source=DESKTOP-FQPDVRO\\SQLEXPRESS;Initial Catalog=Learning_QLBH;Integrated Security=True";
			using (SqlConnection sqlConnection = new SqlConnection(connectionString))
			{
				try
				{
					sqlConnection.Open();
					string cmdText = "SELECT Id, Kieu FROM QLLoaiDangKy";
					SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
					SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
					List<string> list = new List<string>();
					this.cbLoaiDangKy.Items.Clear();
					while (sqlDataReader.Read())
					{
						string text = sqlDataReader["Kieu"].ToString();
						list.Add(text);
						string value = sqlDataReader["Id"].ToString();
						this.cbLoaiDangKy.Items.Add(new ucQLDiLai.ComboboxItem
						{
							Text = text,
							Value = value
						});
					}
					sqlDataReader.Close();
					this.cbLoaiDangKy.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
					this.cbLoaiDangKy.AutoCompleteSource = AutoCompleteSource.CustomSource;
					this.cbLoaiDangKy.AutoCompleteCustomSource = new AutoCompleteStringCollection();
					this.cbLoaiDangKy.AutoCompleteCustomSource.AddRange(list.ToArray());
				}
				catch (Exception ex)
				{
					MessageBox.Show("Error: " + ex.Message);
				}
			}
		}
		public void HienThiDanhSachQLDiLai()
		{
			int manv = 0;
			string lydo = "";
			QLXuongCaEntity qlxuongCaEntity = new QLXuongCaEntity();
			ucQLDiLai.ComboboxItem comboboxItem = (ucQLDiLai.ComboboxItem)this.cbNhanSu.SelectedItem;
			bool flag = comboboxItem != null;
			if (flag)
			{
				manv = int.Parse(comboboxItem.Value);
			}
			ucQLDiLai.ComboboxItem comboboxItem2 = (ucQLDiLai.ComboboxItem)this.cbLoaiDangKy.SelectedItem;
			bool flag2 = comboboxItem2 != null;
			if (flag2)
			{
				lydo = comboboxItem2.Text;
			}
			DateTime date = this.dtpTu.Value.Date;
			DateTime denNgay = this.dtpDen.Value.Date.AddHours(23.0).AddMinutes(59.0);
			DataTable dataTable = this.QLDLManager.HienThiTimKiem(manv, lydo, date, denNgay, ref this.error);
			bool flag3 = dataTable == null;
			if (flag3)
			{
				MessageBox.Show("没有数据 " + this.error);
			}
			else
			{
				int val = 10;
				bool flag4 = this.cbHienThi.SelectedItem != null;
				if (flag4)
				{
					bool flag5 = this.cbHienThi.SelectedItem is string;
					if (flag5)
					{
						val = int.Parse(this.cbHienThi.SelectedItem.ToString());
					}
					else
					{
						bool flag6 = this.cbHienThi.SelectedItem is ucQLDiLai.ComboboxItem;
						if (flag6)
						{
							ucQLDiLai.ComboboxItem comboboxItem3 = (ucQLDiLai.ComboboxItem)this.cbHienThi.SelectedItem;
							val = int.Parse(comboboxItem3.Value);
						}
					}
				}
				DataTable dataTable2 = dataTable.Clone();
				for (int i = 0; i < Math.Min(dataTable.Rows.Count, val); i++)
				{
					dataTable2.ImportRow(dataTable.Rows[i]);
				}
				this.dgDSQLDiLai.DataSource = dataTable2;
				this.dgDSQLDiLai.Columns["Id"].Visible = false;
				int checkHienThi = frmMainForm.LuuThongTin.CheckHienThi;
				bool flag7 = checkHienThi == 0;
				if (flag7)
				{
					this.dgDSQLDiLai.Columns["MaNV"].Visible = false;
				}
				else
				{
					this.dgDSQLDiLai.Columns["MaNV"].Visible = true;
				}
			}
		}
		private void dgDSQLDiLai_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			bool flag = this.dgDSQLDiLai.Columns[e.ColumnIndex].Name == "btnThemGhiChu";
			if (flag)
			{
				frmLogin frmLogin = new frmLogin();
				frmLogin.ShowDialog();
				int kiemTra = frmLogin.LuuThongTin.KiemTra;
				bool flag2 = kiemTra == 1;
				if (flag2)
				{
					DataGridViewRow dataGridViewRow = this.dgDSQLDiLai.Rows[e.RowIndex];
					QLDiLaiEntity qldiLaiEntity = new QLDiLaiEntity();
					ucQLDiLai.LuuThongTin.Id = int.Parse(dataGridViewRow.Cells["Id"].Value.ToString());
					ucQLDiLai.LuuThongTin.TenNV = dataGridViewRow.Cells["MaNV"].Value.ToString() + " - " + dataGridViewRow.Cells["TenNV"].Value.ToString();
					frmGhiChu frmGhiChu = new frmGhiChu();
					frmGhiChu.ShowDialog();
					int kiemTra2 = frmGhiChu.LuuThongTin.KiemTra;
					bool flag3 = kiemTra2 == 1;
					if (flag3)
					{
						this.HienThiDanhSachQLDiLai();
					}
					frmLogin.LuuThongTin.KiemTra = 0;
				}
			}
		}
		private void dgDSQLDiLai_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
		{
			this.dgDSQLDiLai.EnableHeadersVisualStyles = false;
			this.dgDSQLDiLai.ColumnHeadersDefaultCellStyle.BackColor = Color.Red;
			this.dgDSQLDiLai.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
			for (int i = 0; i < this.dgDSQLDiLai.Rows.Count; i++)
			{
				bool flag = i % 2 == 0;
				if (flag)
				{
					this.dgDSQLDiLai.Rows[i].DefaultCellStyle.BackColor = Color.White;
				}
				else
				{
					this.dgDSQLDiLai.Rows[i].DefaultCellStyle.BackColor = Color.LightCoral;
				}
			}
			this.dgDSQLDiLai.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Yahei", 16f);
			float num = 0.1f;
			int num2 = this.dgDSQLDiLai.ClientSize.Height - this.dgDSQLDiLai.ColumnHeadersHeight;
			int height = (int)((float)num2 * num);
			for (int j = 0; j < this.dgDSQLDiLai.Rows.Count; j++)
			{
				this.dgDSQLDiLai.Rows[j].Height = height;
			}
			this.dgDSQLDiLai.ScrollBars = ScrollBars.Vertical;
		}
		private void cbNhanSu_SelectedValueChanged(object sender, EventArgs e)
		{
			this.HienThiDanhSachQLDiLai();
		}
		private void cbLoaiDangKy_SelectedValueChanged(object sender, EventArgs e)
		{
			this.HienThiDanhSachQLDiLai();
		}
		private void ExportExcel(string templatePath, string outputPath)
		{
			int manv = 0;
			string lydo = "";
			QLXuongCaEntity qlxuongCaEntity = new QLXuongCaEntity();
			ucQLDiLai.ComboboxItem comboboxItem = (ucQLDiLai.ComboboxItem)this.cbNhanSu.SelectedItem;
			bool flag = comboboxItem != null;
			if (flag)
			{
				manv = int.Parse(comboboxItem.Value);
			}
			ucQLDiLai.ComboboxItem comboboxItem2 = (ucQLDiLai.ComboboxItem)this.cbLoaiDangKy.SelectedItem;
			bool flag2 = comboboxItem2 != null;
			if (flag2)
			{
				lydo = comboboxItem2.Text;
			}
			DateTime value = this.dtpTu.Value;
			DateTime value2 = this.dtpDen.Value;
			DataTable dataTable = this.QLDLManager.HienThiTimKiem(manv, lydo, value, value2, ref this.error);
			bool flag3 = dataTable == null;
			if (flag3)
			{
				MessageBox.Show("没有数据 : " + this.error);
			}
			else
			{
				bool flag4 = dataTable.Columns.Count == 0;
				if (flag4)
				{
					MessageBox.Show("没有列 !");
				}
				else
				{
					bool flag5 = dataTable.Columns.Contains("Id");
					if (flag5)
					{
						dataTable.Columns.Remove("Id");
					}
					Microsoft.Office.Interop.Excel.Application application = (Microsoft.Office.Interop.Excel.Application)Activator.CreateInstance(Marshal.GetTypeFromCLSID(new Guid("00024500-0000-0000-C000-000000000046")));
					Workbook workbook = application.Workbooks.Open(templatePath, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
					if (ucQLDiLai.<> o__19.<> p__0 == null)
					{
						ucQLDiLai.<> o__19.<> p__0 = CallSite<Func<CallSite, object, Worksheet>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(Worksheet), typeof(ucQLDiLai)));
					}
					Worksheet worksheet = ucQLDiLai.<> o__19.<> p__0.Target(ucQLDiLai.<> o__19.<> p__0, workbook.ActiveSheet);
					int num = 2;
					object[,] array = new object[dataTable.Rows.Count, dataTable.Columns.Count];
					for (int i = 0; i < dataTable.Rows.Count; i++)
					{
						int num2 = 1;
						for (int j = 0; j < dataTable.Columns.Count; j++)
						{
							array[i, num2 - 1] = dataTable.Rows[i][j];
							num2++;
						}
					}
					if (ucQLDiLai.<> o__19.<> p__1 == null)
					{
						ucQLDiLai.<> o__19.<> p__1 = CallSite<Func<CallSite, object, Range>>.Create(Binder.Convert(CSharpBinderFlags.ConvertExplicit, typeof(Range), typeof(ucQLDiLai)));
					}
					Range range = ucQLDiLai.<> o__19.<> p__1.Target(ucQLDiLai.<> o__19.<> p__1, worksheet.Cells[num, 1]);
					if (ucQLDiLai.<> o__19.<> p__2 == null)
					{
						ucQLDiLai.<> o__19.<> p__2 = CallSite<Func<CallSite, object, Range>>.Create(Binder.Convert(CSharpBinderFlags.ConvertExplicit, typeof(Range), typeof(ucQLDiLai)));
					}
					Range range2 = ucQLDiLai.<> o__19.<> p__2.Target(ucQLDiLai.<> o__19.<> p__2, worksheet.Cells[num + dataTable.Rows.Count - 1, dataTable.Columns.Count]);
					Range range3 = worksheet.get_Range(range, range2);
					range3.set_Value(Type.Missing, array);
					workbook.SaveAs(outputPath, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, XlSaveAsAccessMode.xlNoChange, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
					workbook.Close(Type.Missing, Type.Missing, Type.Missing);
					application.Quit();
					Marshal.ReleaseComObject(range3);
					Marshal.ReleaseComObject(range);
					Marshal.ReleaseComObject(range2);
					Marshal.ReleaseComObject(worksheet);
					Marshal.ReleaseComObject(workbook);
					Marshal.ReleaseComObject(application);
					ucQLDiLai.LuuThongTin.TuNgay = this.dtpTu.Value.Date.ToString("dd/MM/yyyy");
					ucQLDiLai.LuuThongTin.DenNgay = this.dtpDen.Value.Date.ToString("dd/MM/yyyy");
					frmThongBaoDiLai frmThongBaoDiLai = new frmThongBaoDiLai();
					frmThongBaoDiLai.ShowDialog();
				}
			}
		}
		private void pictureBox1_Click(object sender, EventArgs e)
		{
			frmLogin frmLogin = new frmLogin();
			frmLogin.ShowDialog();
			int kiemTra = frmLogin.LuuThongTin.KiemTra;
			bool flag = kiemTra == 1;
			if (flag)
			{
				SaveFileDialog saveFileDialog = new SaveFileDialog();
				saveFileDialog.Title = "Export Excel";
				saveFileDialog.FileName = "打卡记录.xlsx";
				saveFileDialog.Filter = "All files (*.*)|*.*";
				bool flag2 = saveFileDialog.ShowDialog() == DialogResult.OK;
				if (flag2)
				{
					try
					{
						string templatePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Template", "BaoCaoDiLai.xlsx");
						this.ExportExcel(templatePath, saveFileDialog.FileName);
					}
					catch (Exception ex)
					{
						MessageBox.Show("导出报告失败 ！\n" + ex.Message);
					}
				}
				frmLogin.LuuThongTin.KiemTra = 0;
			}
		}
		private void ExportExcelBCTH(string templatePath, string outputPath)
		{
			int manv = 0;
			string lydo = "";
			QLXuongCaEntity qlxuongCaEntity = new QLXuongCaEntity();
			ucQLDiLai.ComboboxItem comboboxItem = (ucQLDiLai.ComboboxItem)this.cbNhanSu.SelectedItem;
			bool flag = comboboxItem != null;
			if (flag)
			{
				manv = int.Parse(comboboxItem.Value);
			}
			ucQLDiLai.ComboboxItem comboboxItem2 = (ucQLDiLai.ComboboxItem)this.cbLoaiDangKy.SelectedItem;
			bool flag2 = comboboxItem2 != null;
			if (flag2)
			{
				lydo = comboboxItem2.Text;
			}
			DateTime value = this.dtpTu.Value;
			DateTime value2 = this.dtpDen.Value;
			DataTable dataTable = this.QLDLManager.BaoCaoTongHop(manv, lydo, value, value2, ref this.error);
			bool flag3 = dataTable == null;
			if (flag3)
			{
				MessageBox.Show("没有数据 : " + this.error);
			}
			else
			{
				bool flag4 = dataTable.Columns.Count == 0;
				if (flag4)
				{
					MessageBox.Show("没有列 !");
				}
				else
				{
					Microsoft.Office.Interop.Excel.Application application = (Microsoft.Office.Interop.Excel.Application)Activator.CreateInstance(Marshal.GetTypeFromCLSID(new Guid("00024500-0000-0000-C000-000000000046")));
					Workbook workbook = application.Workbooks.Open(templatePath, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
					if (ucQLDiLai.<> o__21.<> p__0 == null)
					{
						ucQLDiLai.<> o__21.<> p__0 = CallSite<Func<CallSite, object, Worksheet>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(Worksheet), typeof(ucQLDiLai)));
					}
					Worksheet worksheet = ucQLDiLai.<> o__21.<> p__0.Target(ucQLDiLai.<> o__21.<> p__0, workbook.ActiveSheet);
					for (int i = 0; i < dataTable.Rows.Count; i++)
					{
						for (int j = 0; j < dataTable.Columns.Count; j++)
						{
							worksheet.Cells[i + 2, j + 1] = dataTable.Rows[i][j];
						}
					}
					workbook.SaveAs(outputPath, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, XlSaveAsAccessMode.xlNoChange, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
					workbook.Close(Type.Missing, Type.Missing, Type.Missing);
					application.Quit();
					Marshal.ReleaseComObject(worksheet);
					Marshal.ReleaseComObject(workbook);
					Marshal.ReleaseComObject(application);
					ucQLDiLai.LuuThongTin.TuNgay = this.dtpTu.Value.Date.ToString("dd/MM/yyyy");
					ucQLDiLai.LuuThongTin.DenNgay = this.dtpDen.Value.Date.ToString("dd/MM/yyyy");
					frmThongBaoDiLai frmThongBaoDiLai = new frmThongBaoDiLai();
					frmThongBaoDiLai.ShowDialog();
				}
			}
		}
		private void btnBCTH_Click(object sender, EventArgs e)
		{
			frmLogin frmLogin = new frmLogin();
			frmLogin.ShowDialog();
			int kiemTra = frmLogin.LuuThongTin.KiemTra;
			bool flag = kiemTra == 1;
			if (flag)
			{
				SaveFileDialog saveFileDialog = new SaveFileDialog();
				saveFileDialog.Title = "Xuất Excel";
				saveFileDialog.FileName = "综合报告.xlsx";
				saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx";
				bool flag2 = saveFileDialog.ShowDialog() == DialogResult.OK;
				if (flag2)
				{
					try
					{
						string templatePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Template", "BaoCaoTongHop.xlsx");
						this.ExportExcelBCTH(templatePath, saveFileDialog.FileName);
					}
					catch (Exception ex)
					{
						MessageBox.Show("导出报告失败 ！\n" + ex.Message);
					}
				}
				frmLogin.LuuThongTin.KiemTra = 0;
			}
		}
		private void dtpTu_ValueChanged(object sender, EventArgs e)
		{
			this.HienThiDanhSachQLDiLai();
		}
		private void dtpDen_ValueChanged(object sender, EventArgs e)
		{
			this.HienThiDanhSachQLDiLai();
		}
		private void cbLoaiDangKy_TextUpdate(object sender, EventArgs e)
		{
			this.HienThiDanhSachQLDiLai();
		}
		private void cbHienThi_TextChanged(object sender, EventArgs e)
		{
			this.HienThiDanhSachQLDiLai();
		}
	

	}
}
