using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
namespace singinsystem.QuanTri.QLNhanSu
{
    public partial class ucQLNhanSu : UserControl
    {
        private QLNhanSuManager QLNSManager;
        private string error = "";
        private QLNhanSuEntity QLNSDaChon = new QLNhanSuEntity();
        public ucQLNhanSu()
        {
            InitializeComponent();
            this.QLNSManager = new QLNhanSuManager();
            this.HienThiDanhSachQLNhanSu();
        }
        private void HienThiDanhSachQLNhanSu()
        {
            System.Data.DataTable dataTable = this.QLNSManager.HienThiDanhSachQLNhanSu(ref this.error);
            bool flag = dataTable == null;
            if (flag)
            {
                MessageBox.Show("Khong co du lieu: " + this.error);
            }
            else
            {
                this.dgDSQLNhanSu.DataSource = dataTable;
                this.dgDSQLNhanSu.Columns["STT"].Visible = false;
            }
        }
		private void btnThem_Click(object sender, EventArgs e)
		{
			bool flag = string.IsNullOrEmpty(this.txtId.Text) || string.IsNullOrEmpty(this.txtTenNS.Text);
			if (flag)
			{
				MessageBox.Show("请输入全部信息 ！");
			}
			else
			{
				QLNhanSuEntity qlnhanSuEntity = new QLNhanSuEntity();
				int id;
				bool flag2 = int.TryParse(this.txtId.Text, out id);
				if (flag2)
				{
					qlnhanSuEntity.Id = id;
					qlnhanSuEntity.Ten = this.txtTenNS.Text;
					qlnhanSuEntity.IdTen = id.ToString() + " - " + this.txtTenNS.Text;
					bool flag3 = this.QLNSManager.ThemQLNhanSu(qlnhanSuEntity, ref this.error);
					bool flag4 = flag3;
					if (flag4)
					{
						MessageBox.Show("添加成功 ! ");
						this.HienThiDanhSachQLNhanSu();
					}
					else
					{
						MessageBox.Show("添加失败 ! ");
					}
				}
				else
				{
					MessageBox.Show("ID必须是数号 !", "错误 ！", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				}
			}
		}
		private void dgDSQLNhanSu_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			bool flag = e.RowIndex >= 0 && e.RowIndex < this.dgDSQLNhanSu.RowCount;
			if (flag)
			{
				DataGridViewRow dataGridViewRow = this.dgDSQLNhanSu.Rows[e.RowIndex];
				this.txtId.Text = dataGridViewRow.Cells["Id"].Value.ToString();
				this.txtTenNS.Text = dataGridViewRow.Cells["Ten"].Value.ToString();
			}
		}
		private void btnXoa_Click(object sender, EventArgs e)
		{
			bool flag = this.QLNSManager.XoaQLNhanSu(this.txtId.Text, ref this.error);
			bool flag2 = flag;
			if (flag2)
			{
				this.HienThiDanhSachQLNhanSu();
			}
			else
			{
				MessageBox.Show(this.error);
			}
		}
		private void btnSua_Click(object sender, EventArgs e)
		{
			bool flag = string.IsNullOrEmpty(this.txtId.Text) || string.IsNullOrEmpty(this.txtTenNS.Text);
			if (flag)
			{
				MessageBox.Show(" 请输入全部信息 ！");
			}
			else
			{
				QLNhanSuEntity qlnhanSuEntity = new QLNhanSuEntity();
				int id;
				bool flag2 = int.TryParse(this.txtId.Text, out id);
				if (flag2)
				{
					qlnhanSuEntity.Id = id;
					qlnhanSuEntity.Ten = this.txtTenNS.Text;
					bool flag3 = this.QLNSManager.SuaQLNhanSu(qlnhanSuEntity, ref this.error);
					bool flag4 = flag3;
					if (flag4)
					{
						MessageBox.Show("修改成功 ! ");
						this.HienThiDanhSachQLNhanSu();
					}
					else
					{
						MessageBox.Show("修改失败 ! ");
					}
				}
				else
				{
					MessageBox.Show("ID必须是数号 !", "错误 ！", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				}
			}
		}
		private void btnTimKiem_Click(object sender, EventArgs e)
		{
		}
		private void btnXoaTimKiem_Click(object sender, EventArgs e)
		{
			this.txtId.Text = "";
			this.txtTenNS.Text = "";
			this.HienThiDanhSachQLNhanSu();
		}
		private void pictureBox1_Click(object sender, EventArgs e)
		{
		}
		private void DownloadExcel(string sourceFilePath, string path)
		{
			try
			{
				File.Copy(sourceFilePath, path, true);
				MessageBox.Show("下载成功 !");
			}
			catch (Exception ex)
			{
				MessageBox.Show("下载失败 !\n" + ex.Message);
			}
		}
		private void btnXuatFileMau_Click(object sender, EventArgs e)
		{
			string sourceFilePath = Path.Combine(System.Windows.Forms.Application.StartupPath, "Template/ImportNhanSu.xlsx");
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.Title = "Export Excel";
			saveFileDialog.FileName = "ImportNhanSu.xlsx";
			saveFileDialog.Filter = "All files (*.*)|*.*";
			bool flag = saveFileDialog.ShowDialog() == DialogResult.OK;
			if (flag)
			{
				try
				{
					this.DownloadExcel(sourceFilePath, saveFileDialog.FileName);
				}
				catch (Exception ex)
				{
				}
			}
		}
		private void ImportExcel(string path)
		{
			try
			{
				// Khởi tạo ứng dụng Excel
				var excelApp = new Microsoft.Office.Interop.Excel.Application();
				Workbook workbook = excelApp.Workbooks.Open(path);
				Worksheet worksheet = workbook.Sheets[1] as Worksheet;

				if (worksheet == null)
				{
					MessageBox.Show("不能收到文档的数据 ！");
					return;
				}

				// Lấy vùng dữ liệu được sử dụng trong sheet
				Range usedRange = worksheet.UsedRange;
				if (usedRange == null || usedRange.Rows.Count == 0 || usedRange.Columns.Count == 0)
				{
					MessageBox.Show("文档没有数据 ！");
					return;
				}

                // Tạo DataTable để chứa dữ liệu
                System.Data.DataTable dataTable = new System.Data.DataTable();

				// Đọc tên cột từ dòng đầu tiên
				for (int col = 1; col <= usedRange.Columns.Count; col++)
				{
					object columnValue = usedRange.Cells[1, col].Value2;
					string columnName = columnValue != null ? columnValue.ToString() : $"Column{col}";
					dataTable.Columns.Add(columnName);
				}

				// Đọc dữ liệu từ các dòng còn lại
				for (int row = 2; row <= usedRange.Rows.Count; row++) // Bắt đầu từ dòng thứ 2 (bỏ qua tiêu đề)
				{
					DataRow dataRow = dataTable.NewRow();
					bool isRowEmpty = true;

					for (int col = 1; col <= usedRange.Columns.Count; col++)
					{
						object cellValue = usedRange.Cells[row, col].Value2;
						if (cellValue != null)
						{
							isRowEmpty = false;
							dataRow[col - 1] = cellValue.ToString();
						}
						else
						{
							dataRow[col - 1] = string.Empty;
						}
					}

					// Thêm dòng vào DataTable nếu không rỗng
					if (!isRowEmpty)
					{
						dataTable.Rows.Add(dataRow);
					}
				}

				// Đóng workbook và ứng dụng Excel
				workbook.Close(false);
				excelApp.Quit();

				// Giải phóng tài nguyên COM
				Marshal.ReleaseComObject(usedRange);
				Marshal.ReleaseComObject(worksheet);
				Marshal.ReleaseComObject(workbook);
				Marshal.ReleaseComObject(excelApp);

				// Import dữ liệu vào hệ thống
				string errorMessage = string.Empty;
				bool importSuccess = QLNSManager.ImportQLNhanSu(dataTable, ref errorMessage);

				if (importSuccess)
				{
					MessageBox.Show("导入成功 ！");
					HienThiDanhSachQLNhanSu();
				}
				else
				{
					MessageBox.Show($"导入失败: {errorMessage}");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"错误 : {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnImport_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Title = "Import Excel";
			openFileDialog.Filter = "All files (*.*)|*.*";
			bool flag = openFileDialog.ShowDialog() == DialogResult.OK;
			if (flag)
			{
				try
				{
					this.ImportExcel(openFileDialog.FileName);
				}
				catch (Exception ex)
				{
				}
			}
		}
    }
}
