
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace singinsystem.QuanTri.QLTaiKhoan
{
    partial class ucQuanLyTaiKhoan
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
		private TableLayoutPanel tableLayoutPanel1;
		private Panel panel1;
		private DataGridView dgDSTaiKhoan;
		private Panel panel3;
		private Label lblQuyenDN;
		private Label lblTenDayDu;
		private Label label6;
		private Label lblTenDangNhap;
		private Label label4;
		private Label label2;
		private Label label1;
		private TableLayoutPanel tableLayoutPanel2;
		private Panel panel2;
		private Button btnXoa;
		private Button btnSua;
		private Button btnThem;
		private Panel panel4;
		private Label label9;
		private Label lblSoLuong;
		private DataGridViewTextBoxColumn tendangnhap;
		private DataGridViewTextBoxColumn tendaydu;
		private DataGridViewTextBoxColumn quyen;
		private DataGridViewTextBoxColumn tinhtrang;
		private DataGridViewTextBoxColumn matkhau;
		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.tableLayoutPanel1 = new TableLayoutPanel();
			this.panel1 = new Panel();
			this.dgDSTaiKhoan = new DataGridView();
			this.tendangnhap = new DataGridViewTextBoxColumn();
			this.tendaydu = new DataGridViewTextBoxColumn();
			this.quyen = new DataGridViewTextBoxColumn();
			this.tinhtrang = new DataGridViewTextBoxColumn();
			this.matkhau = new DataGridViewTextBoxColumn();
			this.panel3 = new Panel();
			this.lblQuyenDN = new Label();
			this.lblTenDayDu = new Label();
			this.label6 = new Label();
			this.lblTenDangNhap = new Label();
			this.label4 = new Label();
			this.label2 = new Label();
			this.label1 = new Label();
			this.tableLayoutPanel2 = new TableLayoutPanel();
			this.panel2 = new Panel();
			this.btnXoa = new Button();
			this.btnSua = new Button();
			this.btnThem = new Button();
			this.panel4 = new Panel();
			this.lblSoLuong = new Label();
			this.label9 = new Label();
			this.tableLayoutPanel1.SuspendLayout();
			this.panel1.SuspendLayout();
			((ISupportInitialize)this.dgDSTaiKhoan).BeginInit();
			this.panel3.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel4.SuspendLayout();
			base.SuspendLayout();
			this.tableLayoutPanel1.BackColor = Color.LightSeaGreen;
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
			this.tableLayoutPanel1.Dock = DockStyle.Fill;
			this.tableLayoutPanel1.Location = new Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 3;
			this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 150f));
			this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40f));
			this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel1.Size = new Size(781, 472);
			this.tableLayoutPanel1.TabIndex = 0;
			this.panel1.Controls.Add(this.dgDSTaiKhoan);
			this.panel1.Dock = DockStyle.Fill;
			this.panel1.Location = new Point(3, 193);
			this.panel1.Name = "panel1";
			this.panel1.Size = new Size(775, 276);
			this.panel1.TabIndex = 0;
			this.dgDSTaiKhoan.AllowUserToAddRows = false;
			this.dgDSTaiKhoan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgDSTaiKhoan.Columns.AddRange(new DataGridViewColumn[]
			{
				this.tendangnhap,
				this.tendaydu,
				this.quyen,
				this.tinhtrang,
				this.matkhau
			});
			this.dgDSTaiKhoan.Dock = DockStyle.Fill;
			this.dgDSTaiKhoan.Location = new Point(0, 0);
			this.dgDSTaiKhoan.Name = "dgDSTaiKhoan";
			this.dgDSTaiKhoan.RowHeadersWidth = 51;
			this.dgDSTaiKhoan.Size = new Size(775, 276);
			this.dgDSTaiKhoan.TabIndex = 0;
			this.dgDSTaiKhoan.CellClick += this.dgDSTaiKhoan_CellClick;
			this.tendangnhap.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.tendangnhap.DataPropertyName = "tendangnhap";
			this.tendangnhap.HeaderText = "账号";
			this.tendangnhap.MinimumWidth = 6;
			this.tendangnhap.Name = "tendangnhap";
			this.tendangnhap.Width = 81;
			this.tendaydu.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.tendaydu.DataPropertyName = "tendaydu";
			this.tendaydu.HeaderText = "姓名";
			this.tendaydu.MinimumWidth = 6;
			this.tendaydu.Name = "tendaydu";
			this.tendaydu.Width = 81;
			this.quyen.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			this.quyen.DataPropertyName = "maquyen";
			this.quyen.HeaderText = "账号类型";
			this.quyen.MinimumWidth = 6;
			this.quyen.Name = "quyen";
			this.quyen.Width = 116;
			this.tinhtrang.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.tinhtrang.DataPropertyName = "tinhtrang";
			this.tinhtrang.HeaderText = "状态";
			this.tinhtrang.MinimumWidth = 6;
			this.tinhtrang.Name = "tinhtrang";
			this.matkhau.DataPropertyName = "matkhau";
			this.matkhau.HeaderText = "密码";
			this.matkhau.MinimumWidth = 6;
			this.matkhau.Name = "matkhau";
			this.matkhau.Visible = false;
			this.matkhau.Width = 125;
			this.panel3.BackColor = Color.FromArgb(0, 192, 192);
			this.panel3.Controls.Add(this.lblQuyenDN);
			this.panel3.Controls.Add(this.lblTenDayDu);
			this.panel3.Controls.Add(this.label6);
			this.panel3.Controls.Add(this.lblTenDangNhap);
			this.panel3.Controls.Add(this.label4);
			this.panel3.Controls.Add(this.label2);
			this.panel3.Controls.Add(this.label1);
			this.panel3.Dock = DockStyle.Fill;
			this.panel3.Location = new Point(3, 3);
			this.panel3.Name = "panel3";
			this.panel3.Size = new Size(775, 144);
			this.panel3.TabIndex = 2;
			this.lblQuyenDN.AutoSize = true;
			this.lblQuyenDN.ForeColor = SystemColors.ButtonHighlight;
			this.lblQuyenDN.Location = new Point(323, 114);
			this.lblQuyenDN.Name = "lblQuyenDN";
			this.lblQuyenDN.Size = new Size(32, 25);
			this.lblQuyenDN.TabIndex = 1;
			this.lblQuyenDN.Text = "....";
			this.lblTenDayDu.AutoSize = true;
			this.lblTenDayDu.ForeColor = SystemColors.ButtonHighlight;
			this.lblTenDayDu.Location = new Point(322, 88);
			this.lblTenDayDu.Name = "lblTenDayDu";
			this.lblTenDayDu.Size = new Size(32, 25);
			this.lblTenDayDu.TabIndex = 1;
			this.lblTenDayDu.Text = "....";
			this.label6.AutoSize = true;
			this.label6.ForeColor = SystemColors.ButtonHighlight;
			this.label6.Location = new Point(197, 114);
			this.label6.Name = "label6";
			this.label6.Size = new Size(93, 25);
			this.label6.TabIndex = 1;
			this.label6.Text = "账号类型:";
			this.lblTenDangNhap.AutoSize = true;
			this.lblTenDangNhap.ForeColor = SystemColors.ButtonHighlight;
			this.lblTenDangNhap.Location = new Point(322, 59);
			this.lblTenDangNhap.Name = "lblTenDangNhap";
			this.lblTenDangNhap.Size = new Size(32, 25);
			this.lblTenDangNhap.TabIndex = 1;
			this.lblTenDangNhap.Text = "....";
			this.label4.AutoSize = true;
			this.label4.ForeColor = SystemColors.ButtonHighlight;
			this.label4.Location = new Point(196, 88);
			this.label4.Name = "label4";
			this.label4.Size = new Size(58, 25);
			this.label4.TabIndex = 1;
			this.label4.Text = "姓名:";
			this.label2.AutoSize = true;
			this.label2.ForeColor = SystemColors.ButtonHighlight;
			this.label2.Location = new Point(196, 59);
			this.label2.Name = "label2";
			this.label2.Size = new Size(58, 25);
			this.label2.TabIndex = 1;
			this.label2.Text = "账号:";
			this.label1.AutoSize = true;
			this.label1.Font = new Font("Microsoft Sans Serif", 16f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.label1.ForeColor = SystemColors.ButtonHighlight;
			this.label1.Location = new Point(266, 10);
			this.label1.Name = "label1";
			this.label1.Size = new Size(126, 31);
			this.label1.TabIndex = 0;
			this.label1.Text = "账号管理";
			this.tableLayoutPanel2.ColumnCount = 2;
			this.tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200f));
			this.tableLayoutPanel2.Controls.Add(this.panel2, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.panel4, 1, 0);
			this.tableLayoutPanel2.Dock = DockStyle.Fill;
			this.tableLayoutPanel2.Location = new Point(3, 153);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 1;
			this.tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel2.Size = new Size(775, 34);
			this.tableLayoutPanel2.TabIndex = 3;
			this.panel2.BackColor = Color.LightSeaGreen;
			this.panel2.Controls.Add(this.btnXoa);
			this.panel2.Controls.Add(this.btnSua);
			this.panel2.Controls.Add(this.btnThem);
			this.panel2.Dock = DockStyle.Fill;
			this.panel2.Location = new Point(3, 3);
			this.panel2.Name = "panel2";
			this.panel2.Size = new Size(569, 28);
			this.panel2.TabIndex = 2;
			this.btnXoa.BackColor = Color.LightSeaGreen;
			this.btnXoa.ForeColor = SystemColors.ButtonHighlight;
			this.btnXoa.Location = new Point(199, 0);
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.Size = new Size(92, 28);
			this.btnXoa.TabIndex = 1;
			this.btnXoa.Text = "删除";
			this.btnXoa.UseVisualStyleBackColor = false;
			this.btnXoa.Click += this.btnXoa_Click;
			this.btnSua.BackColor = Color.LightSeaGreen;
			this.btnSua.ForeColor = SystemColors.ButtonHighlight;
			this.btnSua.Location = new Point(101, 0);
			this.btnSua.Name = "btnSua";
			this.btnSua.Size = new Size(92, 28);
			this.btnSua.TabIndex = 1;
			this.btnSua.Text = "修改";
			this.btnSua.UseVisualStyleBackColor = false;
			this.btnSua.Click += this.btnSua_Click;
			this.btnThem.BackColor = Color.LightSeaGreen;
			this.btnThem.ForeColor = SystemColors.ButtonHighlight;
			this.btnThem.Location = new Point(3, 0);
			this.btnThem.Name = "btnThem";
			this.btnThem.Size = new Size(92, 28);
			this.btnThem.TabIndex = 1;
			this.btnThem.Text = "添加";
			this.btnThem.UseVisualStyleBackColor = false;
			this.btnThem.Click += this.btnThem_Click;
			this.panel4.BackColor = Color.LightSeaGreen;
			this.panel4.Controls.Add(this.lblSoLuong);
			this.panel4.Controls.Add(this.label9);
			this.panel4.Dock = DockStyle.Fill;
			this.panel4.Location = new Point(578, 3);
			this.panel4.Name = "panel4";
			this.panel4.Size = new Size(194, 28);
			this.panel4.TabIndex = 3;
			this.lblSoLuong.AutoSize = true;
			this.lblSoLuong.ForeColor = SystemColors.ButtonHighlight;
			this.lblSoLuong.Location = new Point(85, 4);
			this.lblSoLuong.Name = "lblSoLuong";
			this.lblSoLuong.Size = new Size(27, 25);
			this.lblSoLuong.TabIndex = 2;
			this.lblSoLuong.Text = "...";
			this.label9.AutoSize = true;
			this.label9.ForeColor = SystemColors.ButtonHighlight;
			this.label9.Location = new Point(3, 4);
			this.label9.Name = "label9";
			this.label9.Size = new Size(52, 25);
			this.label9.TabIndex = 2;
			this.label9.Text = "数量";
			base.AutoScaleDimensions = new SizeF(12f, 25f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.CadetBlue;
			base.Controls.Add(this.tableLayoutPanel1);
			this.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			base.Margin = new Padding(4, 5, 4, 5);
			base.Name = "ucQuanLyTaiKhoan";
			base.Size = new Size(781, 472);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			((ISupportInitialize)this.dgDSTaiKhoan).EndInit();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.tableLayoutPanel2.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			base.ResumeLayout(false);
		}

		#endregion
	}
}
