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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnMain = new System.Windows.Forms.Panel();
            this.pnMenu = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnQuanTri = new System.Windows.Forms.Button();
            this.btnQLDangKy = new System.Windows.Forms.Button();
            this.btnQLXuongCa = new System.Windows.Forms.Button();
            this.btnDangKyVao = new System.Windows.Forms.Button();
            this.btnDiLam = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.pnMain, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pnMenu, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1044, 645);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // pnMain
            // 
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMain.Location = new System.Drawing.Point(4, 60);
            this.pnMain.Margin = new System.Windows.Forms.Padding(4);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(1036, 581);
            this.pnMain.TabIndex = 1;
            // 
            // pnMenu
            // 
            this.pnMenu.Controls.Add(this.button1);
            this.pnMenu.Controls.Add(this.btnQuanTri);
            this.pnMenu.Controls.Add(this.btnQLDangKy);
            this.pnMenu.Controls.Add(this.btnQLXuongCa);
            this.pnMenu.Controls.Add(this.btnDangKyVao);
            this.pnMenu.Controls.Add(this.btnDiLam);
            this.pnMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMenu.Location = new System.Drawing.Point(3, 3);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Size = new System.Drawing.Size(1038, 50);
            this.pnMenu.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.Location = new System.Drawing.Point(1017, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(21, 50);
            this.button1.TabIndex = 6;
            this.button1.Text = " ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnQuanTri
            // 
            this.btnQuanTri.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnQuanTri.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanTri.Location = new System.Drawing.Point(664, 0);
            this.btnQuanTri.Name = "btnQuanTri";
            this.btnQuanTri.Size = new System.Drawing.Size(83, 50);
            this.btnQuanTri.TabIndex = 4;
            this.btnQuanTri.Text = "Admin";
            this.btnQuanTri.UseVisualStyleBackColor = true;
            this.btnQuanTri.Click += new System.EventHandler(this.btnQuanTri_Click);
            // 
            // btnQLDangKy
            // 
            this.btnQLDangKy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnQLDangKy.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLDangKy.Location = new System.Drawing.Point(482, 0);
            this.btnQLDangKy.Name = "btnQLDangKy";
            this.btnQLDangKy.Size = new System.Drawing.Size(176, 51);
            this.btnQLDangKy.TabIndex = 3;
            this.btnQLDangKy.Text = "Break Records";
            this.btnQLDangKy.UseVisualStyleBackColor = true;
            this.btnQLDangKy.Click += new System.EventHandler(this.btnKyLuc_Click);
            // 
            // btnQLXuongCa
            // 
            this.btnQLXuongCa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnQLXuongCa.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLXuongCa.Location = new System.Drawing.Point(293, 0);
            this.btnQLXuongCa.Name = "btnQLXuongCa";
            this.btnQLXuongCa.Size = new System.Drawing.Size(183, 51);
            this.btnQLXuongCa.TabIndex = 2;
            this.btnQLXuongCa.Text = "Clock Records";
            this.btnQLXuongCa.UseVisualStyleBackColor = true;
            this.btnQLXuongCa.Click += new System.EventHandler(this.btnQLXuongCa_Click);
            // 
            // btnDangKyVao
            // 
            this.btnDangKyVao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDangKyVao.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangKyVao.Location = new System.Drawing.Point(145, 0);
            this.btnDangKyVao.Name = "btnDangKyVao";
            this.btnDangKyVao.Size = new System.Drawing.Size(143, 51);
            this.btnDangKyVao.TabIndex = 1;
            this.btnDangKyVao.Text = "Break In/Out";
            this.btnDangKyVao.UseVisualStyleBackColor = true;
            this.btnDangKyVao.Click += new System.EventHandler(this.btnDangKyVao_Click);
            // 
            // btnDiLam
            // 
            this.btnDiLam.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDiLam.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiLam.Location = new System.Drawing.Point(0, 0);
            this.btnDiLam.Name = "btnDiLam";
            this.btnDiLam.Size = new System.Drawing.Size(140, 51);
            this.btnDiLam.TabIndex = 0;
            this.btnDiLam.Text = "Clock In/Out";
            this.btnDiLam.UseVisualStyleBackColor = true;
            this.btnDiLam.Click += new System.EventHandler(this.btnDiLam_Click);
            // 
            // frmMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 645);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMainForm";
            this.Text = "Quan ly ban hang";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMainForm_FormClosing);
            this.Load += new System.EventHandler(this.frmMainForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pnMenu.ResumeLayout(false);
            this.ResumeLayout(false);

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
