using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
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
		public class LuuThongTin
		{
			public static int Id;
			public static string TenNV;
			public static string TuNgay;
			public static string DenNgay;
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
			string connectionString = @"Data Source=DESKTOP-2QKH5AF\SQLEXPRESS;Initial Catalog=Learning_QLBH;Integrated Security=True";
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
				string connectionString = @"Data Source=DESKTOP-2QKH5AF\SQLEXPRESS;Initial Catalog=Learning_QLBH;Integrated Security=True";
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
			string connectionString = @"Data Source=DESKTOP-2QKH5AF\SQLEXPRESS;Initial Catalog=Learning_QLBH;Integrated Security=True";
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
            System.Data.DataTable dataTable = this.QLDLManager.HienThiTimKiem(manv, lydo, date, denNgay, ref this.error);
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
                System.Data.DataTable dataTable2 = dataTable.Clone();
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
			this.dgDSQLDiLai.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Microsoft Yahei", 16f);
			float num = 0.1f;
			int num2 = this.dgDSQLDiLai.ClientSize.Height - this.dgDSQLDiLai.ColumnHeadersHeight;
			int height = (int)((float)num2 * num);
			for (int j = 0; j < this.dgDSQLDiLai.Rows.Count; j++)
			{
				this.dgDSQLDiLai.Rows[j].Height = height;
			}
			this.dgDSQLDiLai.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
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
			try
			{
				// Lấy dữ liệu từ giao diện
				int manv = 0;
				string lydo = "";

				if (cbNhanSu.SelectedItem is ucQLDiLai.ComboboxItem comboboxItemNhanSu)
				{
					manv = int.Parse(comboboxItemNhanSu.Value);
				}

				if (cbLoaiDangKy.SelectedItem is ucQLDiLai.ComboboxItem comboboxItemLyDo)
				{
					lydo = comboboxItemLyDo.Text;
				}

				DateTime fromDate = dtpTu.Value;
				DateTime toDate = dtpDen.Value;

				// Lấy dữ liệu từ database
				System.Data.DataTable dataTable = QLDLManager.HienThiTimKiem(manv, lydo, fromDate, toDate, ref error);
				if (dataTable == null || dataTable.Rows.Count == 0)
				{
					MessageBox.Show(dataTable == null ? $"没有数据: {error}" : "没有列 !");
					return;
				}

				// Xóa cột không cần thiết (nếu tồn tại)
				if (dataTable.Columns.Contains("Id"))
				{
					dataTable.Columns.Remove("Id");
				}

				// Tạo đối tượng Excel
				var excelApp = new Microsoft.Office.Interop.Excel.Application();
				Workbook workbook = excelApp.Workbooks.Open(templatePath);
				Worksheet worksheet = workbook.ActiveSheet as Worksheet;

				// Ghi dữ liệu vào mảng
				int startRow = 2; // Dòng bắt đầu ghi dữ liệu
				object[,] dataArray = new object[dataTable.Rows.Count, dataTable.Columns.Count];

				for (int i = 0; i < dataTable.Rows.Count; i++)
				{
					for (int j = 0; j < dataTable.Columns.Count; j++)
					{
						dataArray[i, j] = dataTable.Rows[i][j];
					}
				}

				// Ghi mảng vào Excel
				Range startCell = worksheet.Cells[startRow, 1];
				Range endCell = worksheet.Cells[startRow + dataTable.Rows.Count - 1, dataTable.Columns.Count];
				Range writeRange = worksheet.get_Range(startCell, endCell);
				writeRange.Value2 = dataArray;

				// Lưu và đóng workbook
				workbook.SaveAs(outputPath);
				workbook.Close(false);
				excelApp.Quit();

				// Giải phóng đối tượng COM
				Marshal.ReleaseComObject(writeRange);
				Marshal.ReleaseComObject(worksheet);
				Marshal.ReleaseComObject(workbook);
				Marshal.ReleaseComObject(excelApp);

				// Cập nhật thông tin lưu trữ
				ucQLDiLai.LuuThongTin.TuNgay = fromDate.ToString("dd/MM/yyyy");
				ucQLDiLai.LuuThongTin.DenNgay = toDate.ToString("dd/MM/yyyy");

				// Hiển thị thông báo
				frmThongBaoDiLai frmThongBaoDiLai = new frmThongBaoDiLai();
				frmThongBaoDiLai.ShowDialog();
			}
			catch (Exception ex)
			{
				MessageBox.Show($"发生错误: {ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
			try
			{
				// Lấy dữ liệu từ giao diện
				int manv = 0;
				string lydo = "";

				if (cbNhanSu.SelectedItem is ucQLDiLai.ComboboxItem comboboxItemNhanSu)
				{
					manv = int.Parse(comboboxItemNhanSu.Value);
				}

				if (cbLoaiDangKy.SelectedItem is ucQLDiLai.ComboboxItem comboboxItemLyDo)
				{
					lydo = comboboxItemLyDo.Text;
				}

				DateTime fromDate = dtpTu.Value;
				DateTime toDate = dtpDen.Value;

				// Lấy dữ liệu từ database
				System.Data.DataTable dataTable = QLDLManager.BaoCaoTongHop(manv, lydo, fromDate, toDate, ref error);
				if (dataTable == null || dataTable.Rows.Count == 0)
				{
					MessageBox.Show(dataTable == null ? $"没有数据: {error}" : "没有数据 !");
					return;
				}

				// Tạo đối tượng Excel
				var excelApp = new Microsoft.Office.Interop.Excel.Application();
				Workbook workbook = excelApp.Workbooks.Open(templatePath);
				Worksheet worksheet = workbook.ActiveSheet as Worksheet;

				// Ghi dữ liệu vào Excel
				for (int i = 0; i < dataTable.Rows.Count; i++)
				{
					for (int j = 0; j < dataTable.Columns.Count; j++)
					{
						worksheet.Cells[i + 2, j + 1] = dataTable.Rows[i][j];
					}
				}

				// Lưu và đóng workbook
				workbook.SaveAs(outputPath);
				workbook.Close(false);
				excelApp.Quit();

				// Giải phóng đối tượng COM
				Marshal.ReleaseComObject(worksheet);
				Marshal.ReleaseComObject(workbook);
				Marshal.ReleaseComObject(excelApp);

				// Cập nhật thông tin lưu trữ
				ucQLDiLai.LuuThongTin.TuNgay = fromDate.ToString("dd/MM/yyyy");
				ucQLDiLai.LuuThongTin.DenNgay = toDate.ToString("dd/MM/yyyy");

				// Hiển thị thông báo
				frmThongBaoDiLai frmThongBaoDiLai = new frmThongBaoDiLai();
				frmThongBaoDiLai.ShowDialog();
			}
			catch (Exception ex)
			{
				MessageBox.Show($"发生错误: {ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
