namespace singinsystem.MainForm
{
	// Token: 0x0200001A RID: 26
	public partial class frmMainForm : global::System.Windows.Forms.Form
	{
		// Token: 0x060000C1 RID: 193 RVA: 0x00018FF8 File Offset: 0x000171F8
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x00019030 File Offset: 0x00017230
		private void InitializeComponent()
		{
			this.tableLayoutPanel1 = new global::System.Windows.Forms.TableLayoutPanel();
			this.pnMain = new global::System.Windows.Forms.Panel();
			this.pnMenu = new global::System.Windows.Forms.Panel();
			this.button1 = new global::System.Windows.Forms.Button();
			this.btnQuanTri = new global::System.Windows.Forms.Button();
			this.btnQLDangKy = new global::System.Windows.Forms.Button();
			this.btnQLXuongCa = new global::System.Windows.Forms.Button();
			this.btnDangKyVao = new global::System.Windows.Forms.Button();
			this.btnDiLam = new global::System.Windows.Forms.Button();
			this.tableLayoutPanel1.SuspendLayout();
			this.pnMenu.SuspendLayout();
			base.SuspendLayout();
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 100f));
			this.tableLayoutPanel1.Controls.Add(this.pnMain, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.pnMenu, 0, 0);
			this.tableLayoutPanel1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new global::System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Margin = new global::System.Windows.Forms.Padding(4);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Absolute, 56f));
			this.tableLayoutPanel1.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 100f));
			this.tableLayoutPanel1.Size = new global::System.Drawing.Size(1044, 645);
			this.tableLayoutPanel1.TabIndex = 0;
			this.tableLayoutPanel1.Paint += new global::System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
			this.pnMain.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.pnMain.Location = new global::System.Drawing.Point(4, 60);
			this.pnMain.Margin = new global::System.Windows.Forms.Padding(4);
			this.pnMain.Name = "pnMain";
			this.pnMain.Size = new global::System.Drawing.Size(1036, 581);
			this.pnMain.TabIndex = 1;
			this.pnMenu.Controls.Add(this.button1);
			this.pnMenu.Controls.Add(this.btnQuanTri);
			this.pnMenu.Controls.Add(this.btnQLDangKy);
			this.pnMenu.Controls.Add(this.btnQLXuongCa);
			this.pnMenu.Controls.Add(this.btnDangKyVao);
			this.pnMenu.Controls.Add(this.btnDiLam);
			this.pnMenu.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.pnMenu.Location = new global::System.Drawing.Point(3, 3);
			this.pnMenu.Name = "pnMenu";
			this.pnMenu.Size = new global::System.Drawing.Size(1038, 50);
			this.pnMenu.TabIndex = 2;
			this.button1.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.button1.Location = new global::System.Drawing.Point(1017, 0);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(21, 50);
			this.button1.TabIndex = 6;
			this.button1.Text = " ";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			this.btnQuanTri.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.btnQuanTri.Font = new global::System.Drawing.Font("Microsoft YaHei", 10.2f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnQuanTri.Location = new global::System.Drawing.Point(511, -1);
			this.btnQuanTri.Name = "btnQuanTri";
			this.btnQuanTri.Size = new global::System.Drawing.Size(121, 52);
			this.btnQuanTri.TabIndex = 4;
			this.btnQuanTri.Text = "后台";
			this.btnQuanTri.UseVisualStyleBackColor = true;
			this.btnQuanTri.Click += new global::System.EventHandler(this.btnQuanTri_Click);
			this.btnQLDangKy.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.btnQLDangKy.Font = new global::System.Drawing.Font("Microsoft YaHei", 10.2f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnQLDangKy.Location = new global::System.Drawing.Point(375, 0);
			this.btnQLDangKy.Name = "btnQLDangKy";
			this.btnQLDangKy.Size = new global::System.Drawing.Size(130, 51);
			this.btnQLDangKy.TabIndex = 3;
			this.btnQLDangKy.Text = "打卡记录";
			this.btnQLDangKy.UseVisualStyleBackColor = true;
			this.btnQLDangKy.Click += new global::System.EventHandler(this.btnKyLuc_Click);
			this.btnQLXuongCa.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.btnQLXuongCa.Font = new global::System.Drawing.Font("Microsoft YaHei", 10.2f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnQLXuongCa.Location = new global::System.Drawing.Point(228, 0);
			this.btnQLXuongCa.Name = "btnQLXuongCa";
			this.btnQLXuongCa.Size = new global::System.Drawing.Size(141, 51);
			this.btnQLXuongCa.TabIndex = 2;
			this.btnQLXuongCa.Text = "上下班记录";
			this.btnQLXuongCa.UseVisualStyleBackColor = true;
			this.btnQLXuongCa.Click += new global::System.EventHandler(this.btnQLXuongCa_Click);
			this.btnDangKyVao.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.btnDangKyVao.Font = new global::System.Drawing.Font("Microsoft YaHei", 10.2f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnDangKyVao.Location = new global::System.Drawing.Point(112, 0);
			this.btnDangKyVao.Name = "btnDangKyVao";
			this.btnDangKyVao.Size = new global::System.Drawing.Size(110, 51);
			this.btnDangKyVao.TabIndex = 1;
			this.btnDangKyVao.Text = "打卡";
			this.btnDangKyVao.UseVisualStyleBackColor = true;
			this.btnDangKyVao.Click += new global::System.EventHandler(this.btnDangKyVao_Click);
			this.btnDiLam.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.btnDiLam.Font = new global::System.Drawing.Font("Microsoft YaHei", 10.2f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnDiLam.Location = new global::System.Drawing.Point(0, 0);
			this.btnDiLam.Name = "btnDiLam";
			this.btnDiLam.Size = new global::System.Drawing.Size(106, 51);
			this.btnDiLam.TabIndex = 0;
			this.btnDiLam.Text = "上下班";
			this.btnDiLam.UseVisualStyleBackColor = true;
			this.btnDiLam.Click += new global::System.EventHandler(this.btnDiLam_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(8f, 16f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(1044, 645);
			base.Controls.Add(this.tableLayoutPanel1);
			base.Margin = new global::System.Windows.Forms.Padding(4);
			base.Name = "frmMainForm";
			this.Text = "Quan ly ban hang";
			base.WindowState = global::System.Windows.Forms.FormWindowState.Maximized;
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.frmMainForm_FormClosing);
			base.Load += new global::System.EventHandler(this.frmMainForm_Load);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.pnMenu.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x040001AE RID: 430
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x040001AF RID: 431
		private global::System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

		// Token: 0x040001B0 RID: 432
		private global::System.Windows.Forms.Panel pnMain;

		// Token: 0x040001B1 RID: 433
		private global::System.Windows.Forms.Panel pnMenu;

		// Token: 0x040001B2 RID: 434
		private global::System.Windows.Forms.Button btnDiLam;

		// Token: 0x040001B3 RID: 435
		private global::System.Windows.Forms.Button btnQuanTri;

		// Token: 0x040001B4 RID: 436
		private global::System.Windows.Forms.Button btnQLDangKy;

		// Token: 0x040001B5 RID: 437
		private global::System.Windows.Forms.Button btnQLXuongCa;

		// Token: 0x040001B6 RID: 438
		private global::System.Windows.Forms.Button btnDangKyVao;

		// Token: 0x040001B7 RID: 439
		private global::System.Windows.Forms.Button button1;
	}
}
