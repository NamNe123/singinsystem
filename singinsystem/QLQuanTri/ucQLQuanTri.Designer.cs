
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucQLQuanTri));
            this.pnMain = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnMenu = new System.Windows.Forms.Panel();
            this.btnQLTaiKhoan = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnQLLoaiDangNhap = new System.Windows.Forms.Button();
            this.btnMenuQuanLyNhanSu = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMenuTaiKhoan = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnMain
            // 
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMain.Location = new System.Drawing.Point(318, 4);
            this.pnMain.Margin = new System.Windows.Forms.Padding(4);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(764, 600);
            this.pnMain.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 314F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.pnMenu, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnMain, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1086, 608);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // pnMenu
            // 
            this.pnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.pnMenu.Controls.Add(this.btnQLTaiKhoan);
            this.pnMenu.Controls.Add(this.button5);
            this.pnMenu.Controls.Add(this.btnQLLoaiDangNhap);
            this.pnMenu.Controls.Add(this.btnMenuQuanLyNhanSu);
            this.pnMenu.Controls.Add(this.pictureBox1);
            this.pnMenu.Controls.Add(this.btnMenuTaiKhoan);
            this.pnMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnMenu.Location = new System.Drawing.Point(4, 4);
            this.pnMenu.Margin = new System.Windows.Forms.Padding(4);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Size = new System.Drawing.Size(306, 600);
            this.pnMenu.TabIndex = 0;
            // 
            // btnQLTaiKhoan
            // 
            this.btnQLTaiKhoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnQLTaiKhoan.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnQLTaiKhoan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLTaiKhoan.Location = new System.Drawing.Point(0, 493);
            this.btnQLTaiKhoan.Margin = new System.Windows.Forms.Padding(4);
            this.btnQLTaiKhoan.Name = "btnQLTaiKhoan";
            this.btnQLTaiKhoan.Size = new System.Drawing.Size(306, 63);
            this.btnQLTaiKhoan.TabIndex = 12;
            this.btnQLTaiKhoan.Text = "账号管理";
            this.btnQLTaiKhoan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQLTaiKhoan.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(0, 422);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(306, 63);
            this.button5.TabIndex = 11;
            this.button5.Text = "规定管理";
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // btnQLLoaiDangNhap
            // 
            this.btnQLLoaiDangNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnQLLoaiDangNhap.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnQLLoaiDangNhap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLLoaiDangNhap.Location = new System.Drawing.Point(0, 354);
            this.btnQLLoaiDangNhap.Margin = new System.Windows.Forms.Padding(4);
            this.btnQLLoaiDangNhap.Name = "btnQLLoaiDangNhap";
            this.btnQLLoaiDangNhap.Size = new System.Drawing.Size(306, 60);
            this.btnQLLoaiDangNhap.TabIndex = 8;
            this.btnQLLoaiDangNhap.Text = "打卡类型";
            this.btnQLLoaiDangNhap.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQLLoaiDangNhap.UseVisualStyleBackColor = false;
            // 
            // btnMenuQuanLyNhanSu
            // 
            this.btnMenuQuanLyNhanSu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnMenuQuanLyNhanSu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMenuQuanLyNhanSu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuQuanLyNhanSu.Location = new System.Drawing.Point(0, 285);
            this.btnMenuQuanLyNhanSu.Margin = new System.Windows.Forms.Padding(4);
            this.btnMenuQuanLyNhanSu.Name = "btnMenuQuanLyNhanSu";
            this.btnMenuQuanLyNhanSu.Size = new System.Drawing.Size(306, 61);
            this.btnMenuQuanLyNhanSu.TabIndex = 7;
            this.btnMenuQuanLyNhanSu.Text = "人事管理";
            this.btnMenuQuanLyNhanSu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMenuQuanLyNhanSu.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(49, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(198, 201);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btnMenuTaiKhoan
            // 
            this.btnMenuTaiKhoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnMenuTaiKhoan.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMenuTaiKhoan.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnMenuTaiKhoan.Location = new System.Drawing.Point(0, 213);
            this.btnMenuTaiKhoan.Margin = new System.Windows.Forms.Padding(4);
            this.btnMenuTaiKhoan.Name = "btnMenuTaiKhoan";
            this.btnMenuTaiKhoan.Size = new System.Drawing.Size(306, 64);
            this.btnMenuTaiKhoan.TabIndex = 2;
            this.btnMenuTaiKhoan.Text = "办公室管理";
            this.btnMenuTaiKhoan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMenuTaiKhoan.UseVisualStyleBackColor = false;
            // 
            // ucQLQuanTri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ucQLQuanTri";
            this.Size = new System.Drawing.Size(1086, 608);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pnMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion
	}
}
