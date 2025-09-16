using BusinessLogicLayer.Manager;
using DataAccessLayer.Entity;
using singinsystem.MainForm;
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
using System.Speech.Synthesis;

namespace singinsystem.QLDangKyVao
{
    public partial class ucQLDangKyVao : UserControl
    {
		private QLDiLaiManager QLDLManager;
		private QLQuyDinhManager QLQDManager;
		private QLVanPhongManager QLVPManager;
		private string error = "";
		private bool isUpdating = false;
		private string currentText = "";
		public ucQLDangKyVao()
        {
			this.InitializeComponent();
			this.QLDLManager = new QLDiLaiManager();
			this.QLQDManager = new QLQuyDinhManager();
			this.QLVPManager = new QLVanPhongManager();
			this.HienThiDuLieuVao_combo_NhanSu();
			this.HienThiDuLieuVao_combo_LoaiDangKy();
			this.HienThiDanhSachQLDangKyVao();
			this.HienThiDanhSachQLQuyDinh();
			this.HienThiVanPhong();
		}
		public class LuuThongTin
		{
			public static string MaNV = "";
			public static string LyDo = "";
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
		public void HienThiVanPhong()
		{
			DataTable dataTable = this.QLVPManager.LayTenQLVanPhong(ref this.error);
			bool flag = dataTable == null;
			if (flag)
			{
				MessageBox.Show("Khong co du lieu: " + this.error);
			}
			else
			{
				this.txtPHC.Text = dataTable.Rows[0]["Ten"].ToString();
			}
		}
		public void HienThiDanhSachQLQuyDinh()
		{
			DataTable dataTable = this.QLQDManager.HienThiDanhSachQLQuyDinhMain(ref this.error);
			bool flag = dataTable == null;
			if (flag)
			{
				MessageBox.Show("Khong co du lieu: " + this.error);
			}
			else
			{
				this.dgDSQLQuyDinh.DataSource = dataTable;
			}
		}
		public void HienThiDuLieuVao_combo_NhanSu()
		{
			string connectionString = @"Data Source=NGUYENNAM;Initial Catalog=Learning_QLBH;Integrated Security=True";
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
						this.cbNhanSu.Items.Add(new ucQLDangKyVao.ComboboxItem
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
				string connectionString = @"Data Source=NGUYENNAM;Initial Catalog=Learning_QLBH;Integrated Security=True";
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
							this.cbNhanSu.Items.Add(new ucQLDangKyVao.ComboboxItem
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
						this.cbNhanSu.SelectionStart = this.currentText.Length;
					}
					catch (Exception ex)
					{
						MessageBox.Show("Error: " + ex.Message);
						this.cbNhanSu.DroppedDown = false;
					}
					finally
					{
						this.isUpdating = false;
						ucQLDangKyVao.LuuThongTin.MaNV = "";
						this.HienThiDanhSachQLDangKyVao();
						bool flag3 = this.cbNhanSu.Items.Count == 1;
						if (flag3)
						{
							object obj = this.cbNhanSu.Items[0];
							ucQLDangKyVao.ComboboxItem comboboxItem = obj as ucQLDangKyVao.ComboboxItem;
							bool flag4 = comboboxItem != null;
							if (flag4)
							{
								this.cbNhanSu.Text = comboboxItem.Text;
								this.cbNhanSu.SelectedValue = comboboxItem.Value;
								ucQLDangKyVao.LuuThongTin.MaNV = comboboxItem.Value;
								ucQLDangKyVao.LuuThongTin.LyDo = this.cbLoaiDangKy.Text;
								this.cbNhanSu.Select(this.cbNhanSu.Text.Length, 0);
								this.cbNhanSu.DroppedDown = false;
								this.HienThiDanhSachQLDangKyVao();
							}
							else
							{
								this.cbNhanSu.Text = obj.ToString();
								this.cbNhanSu.SelectedValue = obj;
								ucQLDangKyVao.LuuThongTin.MaNV = comboboxItem.Value;
								ucQLDangKyVao.LuuThongTin.LyDo = this.cbLoaiDangKy.Text;
								this.HienThiDanhSachQLDangKyVao();
							}
						}
					}
				}
			}
		}
		public void HienThiDuLieuVao_combo_LoaiDangKy()
		{
			string connectionString = @"Data Source=NGUYENNAM;Initial Catalog=Learning_QLBH;Integrated Security=True";
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
						this.cbLoaiDangKy.Items.Add(new ucQLDangKyVao.ComboboxItem
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
		public void HienThiDanhSachQLDangKyVao()
		{
			int manv = 0;
			bool flag = !string.IsNullOrEmpty(ucQLDangKyVao.LuuThongTin.MaNV.ToString());
			if (flag)
			{
				manv = int.Parse(ucQLDangKyVao.LuuThongTin.MaNV);
			}
			string lyDo = ucQLDangKyVao.LuuThongTin.LyDo;
			DataTable dataTable = this.QLDLManager.HienThiDanhSachQLDangKyVao(manv, lyDo, ref this.error);
			bool flag2 = dataTable == null;
			if (flag2)
			{
				MessageBox.Show("Khong co du lieu: " + this.error);
			}
			else
			{
				this.dgDSQLDangKyVao.DataSource = dataTable;
				this.dgDSQLDangKyVao.Columns["Id"].Visible = false;
				bool flag3 = this.dgDSQLDangKyVao.Columns.Contains("GhiChu");
				if (flag3)
				{
					this.dgDSQLDangKyVao.Columns["GhiChu"].Visible = false;
				}
				int checkHienThi = frmMainForm.LuuThongTin.CheckHienThi;
				bool flag4 = checkHienThi == 0;
				if (flag4)
				{
					this.dgDSQLDangKyVao.Columns["MaNV"].Visible = false;
				}
				else
				{
					this.dgDSQLDangKyVao.Columns["MaNV"].Visible = true;
				}
			}
		}
		private void btnDongHo_Click(object sender, EventArgs e)
		{
		}
		private void btnCheckOut_Click(object sender, EventArgs e)
		{
			bool flag = string.IsNullOrEmpty(ucQLDangKyVao.LuuThongTin.MaNV.ToString());
			if (!flag)
			{
				bool flag2 = string.IsNullOrEmpty(ucQLDangKyVao.LuuThongTin.LyDo.ToString());
				if (!flag2)
				{
					string lyDo = ucQLDangKyVao.LuuThongTin.LyDo;
					QLDiLaiEntity qldiLaiEntity = new QLDiLaiEntity();
					qldiLaiEntity.MaNV = int.Parse(ucQLDangKyVao.LuuThongTin.MaNV);
					qldiLaiEntity.LyDo = ucQLDangKyVao.LuuThongTin.LyDo;
					char[] brackets = { '(', '（' }; // Bao gồm cả ngoặc đơn bình thường và Unicode Trung Quốc
					int index = qldiLaiEntity.LyDo.IndexOfAny(brackets);

					qldiLaiEntity.TenLyDo = index > 0 ? qldiLaiEntity.LyDo.Substring(0, index).Trim(): qldiLaiEntity.LyDo;
					qldiLaiEntity.TimeOut = DateTime.Now;
					qldiLaiEntity.TrangThai = "Đã ra";
					bool flag3 = this.QLDLManager.ThemQLDangKyVao(qldiLaiEntity, ref this.error);
					bool flag4 = flag3;
					if (flag4)
					{
						CustomMessageBoxPhu.Show("开始出去 ！", "成功 ！", MessageBoxButtons.OK, MessageBoxIcon.Hand);
						string test = "开始出去"+ qldiLaiEntity.LyDo;
						SpeechSynthesizer reader = new SpeechSynthesizer();
						//reader.Rate = ; giá trị -10 đến 10 điều chỉnh tốc độ đọc
                        reader.Speak(test);

                    }
					else
					{
						bool flag5 = this.error == "=> 不能再选这个选项 <= 请选其他选项";
						if (flag5)
						{
							CustomMessageBox.Show(this.error, "失败 ！", MessageBoxButtons.OK, MessageBoxIcon.Hand);
						}
						else
						{
							CustomMessageBoxPhu.Show(this.error, "失败 ！", MessageBoxButtons.OK, MessageBoxIcon.Hand);
						}
					}
					this.cbNhanSu.Text = "";
					this.cbNhanSu.ValueMember = "";
					ucQLDangKyVao.LuuThongTin.MaNV = "";
					ucQLDangKyVao.LuuThongTin.LyDo = "";
					this.cbLoaiDangKy.Text = "";
					this.HienThiDanhSachQLDangKyVao();
				}
			}
		}
		private void dgDSQLDangKyVao_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			bool flag = this.dgDSQLDangKyVao.Columns[e.ColumnIndex].Name == "btnCheckIn";
			if (flag)
			{
				DataGridViewRow dataGridViewRow = this.dgDSQLDangKyVao.Rows[e.RowIndex];
				QLDiLaiEntity qldiLaiEntity = new QLDiLaiEntity();
				int id = int.Parse(dataGridViewRow.Cells["Id"].Value.ToString());
				int maNV = int.Parse(dataGridViewRow.Cells["MaNV"].Value.ToString());
				string tenNV = dataGridViewRow.Cells["TenNV"].Value.ToString();
				string lyDo = dataGridViewRow.Cells["LyDo"].Value.ToString();
				qldiLaiEntity.Id = id;
				qldiLaiEntity.MaNV = maNV;
				qldiLaiEntity.TenNV = tenNV;
				qldiLaiEntity.LyDo = lyDo;
				qldiLaiEntity.TimeIn = DateTime.Now;
				qldiLaiEntity.TrangThai = "Đã vào";
				bool flag2 = this.QLDLManager.SuaQLDiLai(qldiLaiEntity, ref this.error);
				bool flag3 = flag2;
				if (flag3)
				{
					CustomMessageBoxPhu.Show("进入成功 !", "成功", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					this.cbNhanSu.Text = "";
					this.cbNhanSu.ValueMember = "";
					ucQLDangKyVao.LuuThongTin.MaNV = "";
					ucQLDangKyVao.LuuThongTin.LyDo = "";
					this.cbLoaiDangKy.Text = "";
                    string test = "test new" ;
                    SpeechSynthesizer reader = new SpeechSynthesizer();
                    //reader.Rate = ; giá trị -10 đến 10 điều chỉnh tốc độ đọc
                    reader.Speak(test);
                    this.HienThiDanhSachQLDangKyVao();
				}
				else
				{
					MessageBox.Show(this.error);
				}
			}
		}
		private void dgDSQLDangKyVao_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
		{
			this.dgDSQLDangKyVao.EnableHeadersVisualStyles = false;
			this.dgDSQLDangKyVao.ColumnHeadersDefaultCellStyle.BackColor = Color.Red;
			this.dgDSQLDangKyVao.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
			for (int i = 0; i < this.dgDSQLDangKyVao.Rows.Count; i++)
			{
				bool flag = i % 2 == 0;
				if (flag)
				{
					this.dgDSQLDangKyVao.Rows[i].DefaultCellStyle.BackColor = Color.White;
				}
				else
				{
					this.dgDSQLDangKyVao.Rows[i].DefaultCellStyle.BackColor = Color.LightCoral;
				}
			}
			this.dgDSQLDangKyVao.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Yahei", 16f);
			float num = 0.1f;
			int num2 = this.dgDSQLDangKyVao.ClientSize.Height - this.dgDSQLDangKyVao.ColumnHeadersHeight;
			int height = (int)((float)num2 * num);
			for (int j = 0; j < this.dgDSQLDangKyVao.Rows.Count; j++)
			{
				this.dgDSQLDangKyVao.Rows[j].Height = height;
			}
			this.dgDSQLDangKyVao.ScrollBars = ScrollBars.Vertical;
		}
		private void cbNhanSu_SelectedValueChanged(object sender, EventArgs e)
		{
			ucQLDangKyVao.ComboboxItem comboboxItem = (ucQLDangKyVao.ComboboxItem)this.cbNhanSu.SelectedItem;
			bool flag = !string.IsNullOrEmpty(comboboxItem.ToString());
			if (flag)
			{
				ucQLDangKyVao.LuuThongTin.MaNV = comboboxItem.Value;
			}
			this.HienThiDanhSachQLDangKyVao();
		}
		private void cbLoaiDangKy_SelectedValueChanged(object sender, EventArgs e)
		{
			ucQLDangKyVao.LuuThongTin.LyDo = this.cbLoaiDangKy.Text;
			this.HienThiDanhSachQLDangKyVao();
		}
		private void cbLoaiDangKy_TextChanged(object sender, EventArgs e)
		{
		}
		private void cbLoaiDangKy_MouseClick(object sender, MouseEventArgs e)
		{
			this.cbLoaiDangKy.DroppedDown = true;
		}
		private void cbLoaiDangKy_TextUpdate(object sender, EventArgs e)
		{
			ucQLDangKyVao.LuuThongTin.LyDo = this.cbLoaiDangKy.Text;
			this.HienThiDanhSachQLDangKyVao();
		}
    }
}
