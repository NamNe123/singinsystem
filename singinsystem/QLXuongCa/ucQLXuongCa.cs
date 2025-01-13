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

namespace singinsystem.QLXuongCa
{
    public partial class ucQLXuongCa : UserControl
    {
		private QLXuongCaManager QLXCManager;
		private QLQuyDinhManager QLQDManager;
		private QLVanPhongManager QLVPManager;
		private string error = "";
		private bool isUpdating = false;
		private string currentText = "";
		public ucQLXuongCa()
        {
            InitializeComponent();
            this.ChayLaiNgay();
            this.QLXCManager = new QLXuongCaManager();
            this.QLQDManager = new QLQuyDinhManager();
            this.QLVPManager = new QLVanPhongManager();
            this.HienThiDuLieuVao_combo_NhanSu();
            this.HienThiDanhSachQLXuongCa();
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
			public static int Id = 0;
			public static string Ten = "";
		}
		public void ChayLaiNgay()
        {
            this.dtpDen.Value = DateTime.Now.Date.AddHours(23.0).AddMinutes(59.0);
            this.dtpTu.Value = DateTime.Now.Date;
        }
		public void HienThiDanhSachQLXuongCa()
		{
			int manv = 0;
			QLXuongCaEntity qlxuongCaEntity = new QLXuongCaEntity();
			ucQLXuongCa.ComboboxItem comboboxItem = (ucQLXuongCa.ComboboxItem)this.cbNhanSu.SelectedItem;
			bool flag = comboboxItem != null;
			if (flag)
			{
				manv = int.Parse(comboboxItem.Value);
			}
			DateTime date = this.dtpTu.Value.Date;
			DateTime denNgay = this.dtpDen.Value.Date.AddHours(23.0).AddMinutes(59.0);
            System.Data.DataTable dataTable = this.QLXCManager.HienThiTimKiem(manv, date, denNgay, ref this.error);
			bool flag2 = dataTable == null;
			if (flag2)
			{
				MessageBox.Show("没有数据 " + this.error);
			}
			else
			{
				int val = 10;
				bool flag3 = this.cbHienThi.SelectedItem != null;
				if (flag3)
				{
					bool flag4 = this.cbHienThi.SelectedItem is string;
					if (flag4)
					{
						val = int.Parse(this.cbHienThi.SelectedItem.ToString());
					}
					else
					{
						bool flag5 = this.cbHienThi.SelectedItem is ucQLXuongCa.ComboboxItem;
						if (flag5)
						{
							ucQLXuongCa.ComboboxItem comboboxItem2 = (ucQLXuongCa.ComboboxItem)this.cbHienThi.SelectedItem;
							val = int.Parse(comboboxItem2.Value);
						}
					}
				}
                System.Data.DataTable dataTable2 = dataTable.Clone();
				for (int i = 0; i < Math.Min(dataTable.Rows.Count, val); i++)
				{
					dataTable2.ImportRow(dataTable.Rows[i]);
				}
				this.dgDSQLXuongCa.DataSource = dataTable2;
				this.dgDSQLXuongCa.Columns["Id"].Visible = false;
				this.dgDSQLXuongCa.Columns["TrangThai"].Visible = false;
				int checkHienThi = frmMainForm.LuuThongTin.CheckHienThi;
				bool flag6 = checkHienThi == 0;
				if (flag6)
				{
					this.dgDSQLXuongCa.Columns["MaNV"].Visible = false;
				}
				else
				{
					this.dgDSQLXuongCa.Columns["MaNV"].Visible = true;
				}
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
						this.cbNhanSu.Items.Add(new ucQLXuongCa.ComboboxItem
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
							this.cbNhanSu.Items.Add(new ucQLXuongCa.ComboboxItem
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
					this.HienThiDanhSachQLXuongCa();
				}
			}
		}
		private void btnTimKiem_Click(object sender, EventArgs e)
		{
			QLXuongCaEntity qlxuongCaEntity = new QLXuongCaEntity();
			ucQLXuongCa.ComboboxItem comboboxItem = (ucQLXuongCa.ComboboxItem)this.cbNhanSu.SelectedItem;
			string value = comboboxItem.Value;
			int manv = int.Parse(comboboxItem.Value);
            System.Data.DataTable dataTable = this.QLXCManager.HienThiDanhSachQLXuongCaTheoTimKiem(manv, ref this.error);
			bool flag = dataTable == null;
			if (flag)
			{
				MessageBox.Show("没有数据 " + this.error);
			}
			else
			{
				this.dgDSQLXuongCa.DataSource = dataTable;
			}
		}
		private void dgDSQLXuongCa_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			bool flag = this.dgDSQLXuongCa.Columns[e.ColumnIndex].Name == "btnTroLaiLamViec";
			if (flag)
			{
				frmLogin frmLogin = new frmLogin();
				frmLogin.ShowDialog();
				int kiemTra = frmLogin.LuuThongTin.KiemTra;
				bool flag2 = kiemTra == 1;
				if (flag2)
				{
					DataGridViewRow dataGridViewRow = this.dgDSQLXuongCa.Rows[e.RowIndex];
					QLXuongCaEntity qlxuongCaEntity = new QLXuongCaEntity();
					int id = int.Parse(dataGridViewRow.Cells["Id"].Value.ToString());
					string ten = dataGridViewRow.Cells["Ten"].Value.ToString();
					qlxuongCaEntity.Id = id;
					qlxuongCaEntity.Ten = ten;
					qlxuongCaEntity.TrangThai = "Đang làm việc";
					bool flag3 = this.QLXCManager.SuaQLXuongCaTroLaiLamViec(qlxuongCaEntity, ref this.error);
					bool flag4 = flag3;
					if (flag4)
					{
						MessageBox.Show("回来上班成功 ！");
						this.HienThiDanhSachQLXuongCa();
					}
					else
					{
						MessageBox.Show("回来上班失败 : " + this.error);
					}
					frmLogin.LuuThongTin.KiemTra = 0;
				}
			}
		}
		private void dgDSQLXuongCa_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
		{
			this.dgDSQLXuongCa.EnableHeadersVisualStyles = false;
			this.dgDSQLXuongCa.ColumnHeadersDefaultCellStyle.BackColor = Color.Red;
			this.dgDSQLXuongCa.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
			for (int i = 0; i < this.dgDSQLXuongCa.Rows.Count; i++)
			{
				bool flag = i % 2 == 0;
				if (flag)
				{
					this.dgDSQLXuongCa.Rows[i].DefaultCellStyle.BackColor = Color.White;
				}
				else
				{
					this.dgDSQLXuongCa.Rows[i].DefaultCellStyle.BackColor = Color.LightCoral;
				}
			}
			this.dgDSQLXuongCa.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Microsoft Yahei", 16f);
			float num = 0.1f;
			int num2 = this.dgDSQLXuongCa.ClientSize.Height - this.dgDSQLXuongCa.ColumnHeadersHeight;
			int height = (int)((float)num2 * num);
			for (int j = 0; j < this.dgDSQLXuongCa.Rows.Count; j++)
			{
				this.dgDSQLXuongCa.Rows[j].Height = height;
			}
			this.dgDSQLXuongCa.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
		}
		private void cbNhanSu_SelectedValueChanged(object sender, EventArgs e)
		{
			this.HienThiDanhSachQLXuongCa();
		}
		private void ExportExcel(string templatePath, string outputPath)
		{
			try
			{
				// Lấy dữ liệu từ giao diện
				int manv = 0;
				if (cbNhanSu.SelectedItem is ucQLXuongCa.ComboboxItem comboboxItem)
				{
					manv = int.Parse(comboboxItem.Value);
				}

				DateTime fromDate = dtpTu.Value;
				DateTime toDate = dtpDen.Value;

				// Lấy dữ liệu từ database
				System.Data.DataTable dataTable = QLXCManager.HienThiTimKiem(manv, fromDate, toDate, ref error);
				if (dataTable == null || dataTable.Rows.Count == 0)
				{
					MessageBox.Show(dataTable == null ? $"没有数据: {error}" : "没有数据 !");
					return;
				}

				// Loại bỏ cột "Id" nếu tồn tại
				if (dataTable.Columns.Contains("Id"))
				{
					dataTable.Columns.Remove("Id");
				}

				// Tạo đối tượng Excel
				var excelApp = new Microsoft.Office.Interop.Excel.Application();
				Workbook workbook = excelApp.Workbooks.Open(templatePath);
				Worksheet worksheet = workbook.ActiveSheet as Worksheet;

				// Chuẩn bị dữ liệu để ghi
				object[,] array = new object[dataTable.Rows.Count, dataTable.Columns.Count];
				for (int i = 0; i < dataTable.Rows.Count; i++)
				{
					for (int j = 0; j < dataTable.Columns.Count; j++)
					{
						array[i, j] = dataTable.Rows[i][j];
					}
				}

				// Xác định phạm vi để ghi dữ liệu vào Excel
				int startRow = 2; // Dòng bắt đầu ghi dữ liệu
				Range startCell = worksheet.Cells[startRow, 1];
				Range endCell = worksheet.Cells[startRow + dataTable.Rows.Count - 1, dataTable.Columns.Count];
				Range writeRange = worksheet.Range[startCell, endCell];
				writeRange.Value2 = array;

				// Lưu và đóng file Excel
				workbook.SaveAs(outputPath);
				workbook.Close(false);
				excelApp.Quit();

				// Giải phóng đối tượng COM
				Marshal.ReleaseComObject(writeRange);
				Marshal.ReleaseComObject(startCell);
				Marshal.ReleaseComObject(endCell);
				Marshal.ReleaseComObject(worksheet);
				Marshal.ReleaseComObject(workbook);
				Marshal.ReleaseComObject(excelApp);

				MessageBox.Show("导出报告成功 ！");
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
				saveFileDialog.FileName = "上下班记录.xlsx";
				saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx";
				bool flag2 = saveFileDialog.ShowDialog() == DialogResult.OK;
				if (flag2)
				{
					try
					{
						string templatePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Template", "BaoCaoXuongCa.xlsx");
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
		private void dtpTu_ValueChanged(object sender, EventArgs e)
		{
			this.HienThiDanhSachQLXuongCa();
		}
		private void dtpDen_ValueChanged(object sender, EventArgs e)
		{
			this.HienThiDanhSachQLXuongCa();
		}
		private void cbHienThi_TextChanged(object sender, EventArgs e)
		{
			this.HienThiDanhSachQLXuongCa();
		}

    }
}
