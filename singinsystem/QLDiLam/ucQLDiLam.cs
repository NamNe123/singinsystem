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
using singinsystem.MainForm;

namespace singinsystem.QLDiLam
{
    public partial class ucQLDiLam : UserControl
    {
        private QLXuongCaManager QLXCManager;
        private QLQuyDinhManager QLQDManager;
        private QLVanPhongManager QLVPManager;
		private bool isUpdating = false;
		private string currentText = "";
		private string error = "";
		private bool valueSelected = false;
		public ucQLDiLam()
        {
            InitializeComponent();
            this.QLXCManager = new QLXuongCaManager();
            this.QLQDManager = new QLQuyDinhManager();
            this.QLVPManager = new QLVanPhongManager();
            this.HienThiDuLieuVao_combo_NhanSu();
            this.HienThiDanhSachQLDiLam();
            this.HienThiDanhSachQLQuyDinh();
            this.HienThiVanPhong();
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
			public static string MaNV = "";
			public static string Ten = "";
			public static string ThongBao1 = "";
			public static string ThongBao2 = "";
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
						this.cbNhanSu.Items.Add(new ucQLDiLam.ComboboxItem
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
							this.cbNhanSu.Items.Add(new ucQLDiLam.ComboboxItem
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
						this.cbNhanSu.SelectionStart = text.Length;
					}
					catch (Exception ex)
					{
						MessageBox.Show("Error: " + ex.Message);
						this.cbNhanSu.DroppedDown = false;
					}
					finally
					{
						this.isUpdating = false;
						this.HienThiDanhSachQLDiLam();
						bool flag3 = this.cbNhanSu.Items.Count == 1;
						if (flag3)
						{
							object obj = this.cbNhanSu.Items[0];
							ucQLDiLam.ComboboxItem comboboxItem = obj as ucQLDiLam.ComboboxItem;
							bool flag4 = comboboxItem != null;
							if (flag4)
							{
								this.cbNhanSu.Text = comboboxItem.Text;
								this.cbNhanSu.SelectedValue = comboboxItem.Value;
								ucQLDiLam.LuuThongTin.MaNV = comboboxItem.Value;
								this.cbNhanSu.Select(this.cbNhanSu.Text.Length, 0);
								this.cbNhanSu.DroppedDown = false;
								int manv = int.Parse(comboboxItem.Value);
								DataTable dataTable = this.QLXCManager.HienThiDanhSachQLDiLamTheoTimKiem(manv, ref this.error);
								bool flag5 = dataTable == null;
								if (flag5)
								{
									CustomMessageBoxPhu.Show("没有数据 " + this.error, "失败 ！", MessageBoxButtons.OK, MessageBoxIcon.Hand);
								}
								else
								{
									this.dgDSQLDiLam.DataSource = dataTable;
									this.dgDSQLDiLam.Columns["Id"].Visible = false;
									int checkHienThi = frmMainForm.LuuThongTin.CheckHienThi;
									bool flag6 = checkHienThi == 0;
									if (flag6)
									{
										this.dgDSQLDiLam.Columns["MaNV"].Visible = false;
									}
									else
									{
										this.dgDSQLDiLam.Columns["MaNV"].Visible = true;
									}
								}
							}
							else
							{
								this.cbNhanSu.Text = obj.ToString();
								this.cbNhanSu.SelectedValue = obj;
								ucQLDiLam.LuuThongTin.MaNV = comboboxItem.Value;
								this.cbNhanSu.Select(this.cbNhanSu.Text.Length, 0);
								this.cbNhanSu.DroppedDown = false;
								int manv2 = int.Parse(comboboxItem.Value);
								DataTable dataTable2 = this.QLXCManager.HienThiDanhSachQLDiLamTheoTimKiem(manv2, ref this.error);
								bool flag7 = dataTable2 == null;
								if (flag7)
								{
									CustomMessageBoxPhu.Show("没有数据 " + this.error, "失败 ！", MessageBoxButtons.OK, MessageBoxIcon.Hand);
								}
								else
								{
									this.dgDSQLDiLam.DataSource = dataTable2;
									this.dgDSQLDiLam.Columns["Id"].Visible = false;
									int checkHienThi2 = frmMainForm.LuuThongTin.CheckHienThi;
									bool flag8 = checkHienThi2 == 0;
									if (flag8)
									{
										this.dgDSQLDiLam.Columns["MaNV"].Visible = false;
									}
									else
									{
										this.dgDSQLDiLam.Columns["MaNV"].Visible = true;
									}
								}
							}
						}
					}
				}
			}
		}
		private void ComboAutocompleteForm_Load(object sender, EventArgs e)
		{
		}
		public void HienThiVanPhong()
		{
			DataTable dataTable = this.QLVPManager.LayTenQLVanPhong(ref this.error);
			bool flag = dataTable == null;
			if (flag)
			{
				CustomMessageBoxPhu.Show("没有数据: " + this.error, "失败 ！", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
			else
			{
				this.txtPHC.Text = dataTable.Rows[0]["Ten"].ToString();
			}
		}
		public void HienThiDanhSachQLQuyDinh()
		{
			DataTable dataTable = this.QLQDManager.HienThiDanhSachQLQuyDinhMainDiLam(ref this.error);
			bool flag = dataTable == null;
			if (flag)
			{
				CustomMessageBoxPhu.Show("没有数据: " + this.error, "失败 ！", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
			else
			{
				this.dgDSQLQuyDinh.DataSource = dataTable;
			}
		}
		public void HienThiDanhSachQLDiLam()
		{
			DataTable dataTable = this.QLXCManager.HienThiDanhSachQLDiLam(ref this.error);
			bool flag = dataTable == null;
			if (flag)
			{
				CustomMessageBoxPhu.Show("没有数据: " + this.error, "失败 ！", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
			else
			{
				this.dgDSQLDiLam.DataSource = dataTable;
				this.dgDSQLDiLam.Columns["Id"].Visible = false;
				int checkHienThi = frmMainForm.LuuThongTin.CheckHienThi;
				bool flag2 = checkHienThi == 0;
				if (flag2)
				{
					this.dgDSQLDiLam.Columns["MaNV"].Visible = false;
				}
				else
				{
					this.dgDSQLDiLam.Columns["MaNV"].Visible = true;
				}
			}
		}
		private void dgDSQLDiLam_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
		{
			this.dgDSQLDiLam.EnableHeadersVisualStyles = false;
			this.dgDSQLDiLam.ColumnHeadersDefaultCellStyle.BackColor = Color.Red;
			this.dgDSQLDiLam.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
			for (int i = 0; i < this.dgDSQLDiLam.Rows.Count; i++)
			{
				bool flag = i % 2 == 0;
				if (flag)
				{
					this.dgDSQLDiLam.Rows[i].DefaultCellStyle.BackColor = Color.White;
				}
				else
				{
					this.dgDSQLDiLam.Rows[i].DefaultCellStyle.BackColor = Color.LightCoral;
				}
			}
			this.dgDSQLDiLam.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Yahei", 16f);
			float num = 0.1f;
			int num2 = this.dgDSQLDiLam.ClientSize.Height - this.dgDSQLDiLam.ColumnHeadersHeight;
			int height = (int)((float)num2 * num);
			for (int j = 0; j < this.dgDSQLDiLam.Rows.Count; j++)
			{
				this.dgDSQLDiLam.Rows[j].Height = height;
			}
			this.dgDSQLDiLam.ScrollBars = ScrollBars.Vertical;
		}
		private void btnBatDau_Click(object sender, EventArgs e)
		{
			bool flag = !string.IsNullOrEmpty(ucQLDiLam.LuuThongTin.MaNV.ToString());
			if (flag)
			{
				QLXuongCaEntity qlxuongCaEntity = new QLXuongCaEntity();
				qlxuongCaEntity.MaNV = int.Parse(ucQLDiLam.LuuThongTin.MaNV);
				qlxuongCaEntity.GioLamViec = DateTime.Now;
				qlxuongCaEntity.TrangThai = "Đang làm việc";
				bool flag2 = this.QLXCManager.ThemQLDiLam(qlxuongCaEntity, ref this.error);
				bool flag3 = flag2;
				if (flag3)
				{
					CustomMessageBoxPhu.Show("操作成功 !", "成功 ！", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					ucQLDiLam.LuuThongTin.MaNV = "";
					this.cbNhanSu.Text = "";
					this.cbNhanSu.ValueMember = "";
					this.HienThiDanhSachQLDiLam();
				}
				else
				{
					CustomMessageBox.Show(this.error, "失败 ！", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				}
			}
			else
			{
				bool flag4 = this.cbNhanSu.SelectedItem == null;
				if (flag4)
				{
					CustomMessageBoxPhu.Show("请输入ID或姓名 !", "失败 ！", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				}
				else
				{
					ucQLDiLam.ComboboxItem comboboxItem = (ucQLDiLam.ComboboxItem)this.cbNhanSu.SelectedItem;
					string value = comboboxItem.Value;
					QLXuongCaEntity qlxuongCaEntity2 = new QLXuongCaEntity();
					qlxuongCaEntity2.MaNV = int.Parse(value);
					qlxuongCaEntity2.GioLamViec = DateTime.Now;
					qlxuongCaEntity2.TrangThai = "Đang làm việc";
					bool flag5 = this.QLXCManager.ThemQLDiLam(qlxuongCaEntity2, ref this.error);
					bool flag6 = flag5;
					if (flag6)
					{
						CustomMessageBoxPhu.Show("操作成功 !", "成功 ！", MessageBoxButtons.OK, MessageBoxIcon.Hand);
						this.cbNhanSu.Text = "";
						this.cbNhanSu.ValueMember = "";
						this.HienThiDanhSachQLDiLam();
					}
					else
					{
						CustomMessageBox.Show(this.error, "失败 ！", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					}
				}
			}
		}
		private void dgDSQLDiLam_CellClick(object sender, DataGridViewCellEventArgs e)
		{
		}
		private void dgDSQLDiLam_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			bool flag = this.dgDSQLDiLam.Columns[e.ColumnIndex].Name == "btnXuongCa";
			if (flag)
			{
				DataGridViewRow dataGridViewRow = this.dgDSQLDiLam.Rows[e.RowIndex];
				QLXuongCaEntity qlxuongCaEntity = new QLXuongCaEntity();
				int id = int.Parse(dataGridViewRow.Cells["Id"].Value.ToString());
				int maNV = int.Parse(dataGridViewRow.Cells["MaNV"].Value.ToString());
				string text = dataGridViewRow.Cells["Ten"].Value.ToString();
				qlxuongCaEntity.Id = id;
				qlxuongCaEntity.MaNV = maNV;
				qlxuongCaEntity.Ten = text;
				qlxuongCaEntity.GioXuongCa = DateTime.Now;
				qlxuongCaEntity.TrangThai = "Đã xuống ca";
				ucQLDiLam.LuuThongTin.ThongBao1 = maNV.ToString() + " - " + text;
				ucQLDiLam.LuuThongTin.ThongBao2 = "你确定要下班？";
				frmDongYXuongCa frmDongYXuongCa = new frmDongYXuongCa();
				frmDongYXuongCa.ShowDialog();
				int kiemTra = frmDongYXuongCa.LuuThongTin.KiemTra;
				bool flag2 = kiemTra == 1;
				if (flag2)
				{
					bool flag3 = this.QLXCManager.SuaQLXuongCa(qlxuongCaEntity, ref this.error);
					bool flag4 = flag3;
					if (flag4)
					{
						this.cbNhanSu.Text = "";
						this.cbNhanSu.ValueMember = "";
						ucQLDiLam.LuuThongTin.MaNV = "";
						this.HienThiDanhSachQLDiLam();
					}
					else
					{
						CustomMessageBoxPhu.Show("下班失败: " + this.error, "失败 ！", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					}
				}
			}
		}
		private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
		{
		}
		private void cbNhanSu_SelectedValueChanged(object sender, EventArgs e)
		{
			this.valueSelected = true;
			bool flag = this.valueSelected;
			if (flag)
			{
				ucQLDiLam.ComboboxItem comboboxItem = (ucQLDiLam.ComboboxItem)this.cbNhanSu.SelectedItem;
				bool flag2 = comboboxItem != null;
				if (flag2)
				{
					string value = comboboxItem.Value;
					int manv = int.Parse(comboboxItem.Value);
					ucQLDiLam.LuuThongTin.MaNV = manv.ToString();
					DataTable dataTable = this.QLXCManager.HienThiDanhSachQLDiLamTheoTimKiem(manv, ref this.error);
					bool flag3 = dataTable == null;
					if (flag3)
					{
						CustomMessageBoxPhu.Show("没有数据 " + this.error, "失败 ！", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					}
					else
					{
						this.dgDSQLDiLam.DataSource = dataTable;
						this.dgDSQLDiLam.Columns["Id"].Visible = false;
						int checkHienThi = frmMainForm.LuuThongTin.CheckHienThi;
						bool flag4 = checkHienThi == 0;
						if (flag4)
						{
							this.dgDSQLDiLam.Columns["MaNV"].Visible = false;
						}
						else
						{
							this.dgDSQLDiLam.Columns["MaNV"].Visible = true;
						}
					}
				}
				else
				{
					this.HienThiDanhSachQLDiLam();
				}
			}
		}
    }
}
