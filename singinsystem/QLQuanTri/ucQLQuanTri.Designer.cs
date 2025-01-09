
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace singinsystem.QLQuanTri
{
    partial class ucQLQuanTri
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
		private Panel pnMain;
		private TableLayoutPanel tableLayoutPanel1;
		private Panel pnMenu;
		private Button button5;
		private Button btnQLLoaiDangNhap;
		private Button btnMenuQuanLyNhanSu;
		private PictureBox pictureBox1;
		private Button btnMenuTaiKhoan;
		private Button btnQLTaiKhoan;
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
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(ucQLQuanTri));
			this.pnMain = new Panel();
			this.tableLayoutPanel1 = new TableLayoutPanel();
			this.pnMenu = new Panel();
			this.btnQLTaiKhoan = new Button();
			this.button5 = new Button();
			this.btnQLLoaiDangNhap = new Button();
			this.btnMenuQuanLyNhanSu = new Button();
			this.pictureBox1 = new PictureBox();
			this.btnMenuTaiKhoan = new Button();
			this.tableLayoutPanel1.SuspendLayout();
			this.pnMenu.SuspendLayout();
			((ISupportInitialize)this.pictureBox1).BeginInit();
			base.SuspendLayout();
			this.pnMain.Dock = DockStyle.Fill;
			this.pnMain.Location = new Point(318, 4);
			this.pnMain.Margin = new Padding(4);
			this.pnMain.Name = "pnMain";
			this.pnMain.Size = new Size(764, 600);
			this.pnMain.TabIndex = 1;
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 314f));
			this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel1.Controls.Add(this.pnMenu, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.pnMain, 1, 0);
			this.tableLayoutPanel1.Dock = DockStyle.Fill;
			this.tableLayoutPanel1.Location = new Point(0, 0);
			this.tableLayoutPanel1.Margin = new Padding(4);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel1.Size = new Size(1086, 608);
			this.tableLayoutPanel1.TabIndex = 2;
			this.pnMenu.BackColor = Color.FromArgb(255, 128, 128);
			this.pnMenu.Controls.Add(this.btnQLTaiKhoan);
			this.pnMenu.Controls.Add(this.button5);
			this.pnMenu.Controls.Add(this.btnQLLoaiDangNhap);
			this.pnMenu.Controls.Add(this.btnMenuQuanLyNhanSu);
			this.pnMenu.Controls.Add(this.pictureBox1);
			this.pnMenu.Controls.Add(this.btnMenuTaiKhoan);
			this.pnMenu.Dock = DockStyle.Fill;
			this.pnMenu.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.pnMenu.Location = new Point(4, 4);
			this.pnMenu.Margin = new Padding(4);
			this.pnMenu.Name = "pnMenu";
			this.pnMenu.Size = new Size(306, 600);
			this.pnMenu.TabIndex = 0;
			this.btnQLTaiKhoan.BackColor = Color.FromArgb(255, 128, 128);
			this.btnQLTaiKhoan.ForeColor = SystemColors.ButtonHighlight;
			this.btnQLTaiKhoan.Image = (Image)componentResourceManager.GetObject("btnQLTaiKhoan.Image");
			this.btnQLTaiKhoan.ImageAlign = ContentAlignment.MiddleLeft;
			this.btnQLTaiKhoan.Location = new Point(0, 493);
			this.btnQLTaiKhoan.Margin = new Padding(4);
			this.btnQLTaiKhoan.Name = "btnQLTaiKhoan";
			this.btnQLTaiKhoan.Size = new Size(306, 63);
			this.btnQLTaiKhoan.TabIndex = 12;
			this.btnQLTaiKhoan.Text = "账号管理";
			this.btnQLTaiKhoan.TextImageRelation = TextImageRelation.ImageBeforeText;
			this.btnQLTaiKhoan.UseVisualStyleBackColor = false;
			this.btnQLTaiKhoan.Click += this.btnQLTaiKhoan_Click;
			this.button5.BackColor = Color.FromArgb(255, 128, 128);
			this.button5.ForeColor = SystemColors.ButtonHighlight;
			this.button5.Image = (Image)componentResourceManager.GetObject("button5.Image");
			this.button5.ImageAlign = ContentAlignment.MiddleLeft;
			this.button5.Location = new Point(0, 422);
			this.button5.Margin = new Padding(4);
			this.button5.Name = "button5";
			this.button5.Size = new Size(306, 63);
			this.button5.TabIndex = 11;
			this.button5.Text = "规定管理";
			this.button5.TextImageRelation = TextImageRelation.ImageBeforeText;
			this.button5.UseVisualStyleBackColor = false;
			this.button5.Click += this.button5_Click;
			this.btnQLLoaiDangNhap.BackColor = Color.FromArgb(255, 128, 128);
			this.btnQLLoaiDangNhap.ForeColor = SystemColors.ButtonHighlight;
			this.btnQLLoaiDangNhap.Image = (Image)componentResourceManager.GetObject("btnQLLoaiDangNhap.Image");
			this.btnQLLoaiDangNhap.ImageAlign = ContentAlignment.MiddleLeft;
			this.btnQLLoaiDangNhap.Location = new Point(0, 354);
			this.btnQLLoaiDangNhap.Margin = new Padding(4);
			this.btnQLLoaiDangNhap.Name = "btnQLLoaiDangNhap";
			this.btnQLLoaiDangNhap.Size = new Size(306, 60);
			this.btnQLLoaiDangNhap.TabIndex = 8;
			this.btnQLLoaiDangNhap.Text = "打卡类型";
			this.btnQLLoaiDangNhap.TextImageRelation = TextImageRelation.ImageBeforeText;
			this.btnQLLoaiDangNhap.UseVisualStyleBackColor = false;
			this.btnQLLoaiDangNhap.Click += this.btnQLLoaiDangNhap_Click;
			this.btnMenuQuanLyNhanSu.BackColor = Color.FromArgb(255, 128, 128);
			this.btnMenuQuanLyNhanSu.ForeColor = SystemColors.ButtonHighlight;
			this.btnMenuQuanLyNhanSu.Image = (Image)componentResourceManager.GetObject("btnMenuQuanLyNhanSu.Image");
			this.btnMenuQuanLyNhanSu.ImageAlign = ContentAlignment.MiddleLeft;
			this.btnMenuQuanLyNhanSu.Location = new Point(0, 285);
			this.btnMenuQuanLyNhanSu.Margin = new Padding(4);
			this.btnMenuQuanLyNhanSu.Name = "btnMenuQuanLyNhanSu";
			this.btnMenuQuanLyNhanSu.Size = new Size(306, 61);
			this.btnMenuQuanLyNhanSu.TabIndex = 7;
			this.btnMenuQuanLyNhanSu.Text = "人事管理";
			this.btnMenuQuanLyNhanSu.TextImageRelation = TextImageRelation.ImageBeforeText;
			this.btnMenuQuanLyNhanSu.UseVisualStyleBackColor = false;
			this.btnMenuQuanLyNhanSu.Click += this.btnMenuQuanLyNhanSu_Click;
			this.pictureBox1.Image = (Image)componentResourceManager.GetObject("pictureBox1.Image");
			this.pictureBox1.Location = new Point(49, 5);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new Size(198, 201);
			this.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 3;
			this.pictureBox1.TabStop = false;
			this.btnMenuTaiKhoan.BackColor = Color.FromArgb(255, 128, 128);
			this.btnMenuTaiKhoan.ForeColor = SystemColors.ButtonHighlight;
			this.btnMenuTaiKhoan.Image = (Image)componentResourceManager.GetObject("btnMenuTaiKhoan.Image");
			this.btnMenuTaiKhoan.ImageAlign = ContentAlignment.BottomLeft;
			this.btnMenuTaiKhoan.Location = new Point(0, 213);
			this.btnMenuTaiKhoan.Margin = new Padding(4);
			this.btnMenuTaiKhoan.Name = "btnMenuTaiKhoan";
			this.btnMenuTaiKhoan.Size = new Size(306, 64);
			this.btnMenuTaiKhoan.TabIndex = 2;
			this.btnMenuTaiKhoan.Text = "办公室管理";
			this.btnMenuTaiKhoan.TextImageRelation = TextImageRelation.ImageBeforeText;
			this.btnMenuTaiKhoan.UseVisualStyleBackColor = false;
			this.btnMenuTaiKhoan.Click += this.btnMenuTaiKhoan_Click;
			base.AutoScaleDimensions = new SizeF(8f, 16f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.Controls.Add(this.tableLayoutPanel1);
			base.Name = "ucQLQuanTri";
			base.Size = new Size(1086, 608);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.pnMenu.ResumeLayout(false);
			((ISupportInitialize)this.pictureBox1).EndInit();
			base.ResumeLayout(false);
		}

		#endregion
	}
}
