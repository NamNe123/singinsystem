
namespace singinsystem.QLDiLai
{
    partial class frmGhiChu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
		private global::System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private global::System.Windows.Forms.Panel panel1;
		private global::System.Windows.Forms.Label lbTenNV;
		private global::System.Windows.Forms.Label label2;
		private global::System.Windows.Forms.RichTextBox txtGhiChu;
		private global::System.Windows.Forms.Label label1;
		private global::System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private global::System.Windows.Forms.Button btnKhongDongY;
		private global::System.Windows.Forms.Button btnDongY;
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.tableLayoutPanel1 = new global::System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel2 = new global::System.Windows.Forms.TableLayoutPanel();
			this.btnKhongDongY = new global::System.Windows.Forms.Button();
			this.btnDongY = new global::System.Windows.Forms.Button();
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.lbTenNV = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.txtGhiChu = new global::System.Windows.Forms.RichTextBox();
			this.label1 = new global::System.Windows.Forms.Label();
			this.tableLayoutPanel1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.panel1.SuspendLayout();
			base.SuspendLayout();
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 50f));
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
			this.tableLayoutPanel1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new global::System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Margin = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 79.79094f));
			this.tableLayoutPanel1.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 20.20906f));
			this.tableLayoutPanel1.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Absolute, 24f));
			this.tableLayoutPanel1.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Absolute, 24f));
			this.tableLayoutPanel1.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Absolute, 24f));
			this.tableLayoutPanel1.Size = new global::System.Drawing.Size(468, 278);
			this.tableLayoutPanel1.TabIndex = 0;
			this.tableLayoutPanel2.ColumnCount = 2;
			this.tableLayoutPanel2.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 50.21645f));
			this.tableLayoutPanel2.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 49.78355f));
			this.tableLayoutPanel2.Controls.Add(this.btnKhongDongY, 1, 0);
			this.tableLayoutPanel2.Controls.Add(this.btnDongY, 0, 0);
			this.tableLayoutPanel2.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new global::System.Drawing.Point(3, 225);
			this.tableLayoutPanel2.Margin = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 1;
			this.tableLayoutPanel2.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 50f));
			this.tableLayoutPanel2.Size = new global::System.Drawing.Size(462, 49);
			this.tableLayoutPanel2.TabIndex = 2;
			this.btnKhongDongY.Font = new global::System.Drawing.Font("Microsoft YaHei", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnKhongDongY.Location = new global::System.Drawing.Point(234, 4);
			this.btnKhongDongY.Margin = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btnKhongDongY.Name = "btnKhongDongY";
			this.btnKhongDongY.Size = new global::System.Drawing.Size(125, 41);
			this.btnKhongDongY.TabIndex = 1;
			this.btnKhongDongY.Text = "取消";
			this.btnKhongDongY.UseVisualStyleBackColor = true;
			this.btnKhongDongY.Click += new global::System.EventHandler(this.btnKhongDongY_Click);
			this.btnDongY.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnDongY.Font = new global::System.Drawing.Font("Microsoft YaHei", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnDongY.Location = new global::System.Drawing.Point(104, 4);
			this.btnDongY.Margin = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btnDongY.Name = "btnDongY";
			this.btnDongY.Size = new global::System.Drawing.Size(124, 41);
			this.btnDongY.TabIndex = 0;
			this.btnDongY.Text = "确定";
			this.btnDongY.UseVisualStyleBackColor = true;
			this.btnDongY.Click += new global::System.EventHandler(this.btnDongY_Click);
			this.panel1.Controls.Add(this.lbTenNV);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.txtGhiChu);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new global::System.Drawing.Point(3, 4);
			this.panel1.Margin = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(462, 213);
			this.panel1.TabIndex = 0;
			this.lbTenNV.AutoSize = true;
			this.lbTenNV.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 13.8f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lbTenNV.Location = new global::System.Drawing.Point(174, 54);
			this.lbTenNV.Name = "lbTenNV";
			this.lbTenNV.Size = new global::System.Drawing.Size(89, 29);
			this.lbTenNV.TabIndex = 9;
			this.lbTenNV.Text = "TenNV";
			this.label2.AutoSize = true;
			this.label2.Font = new global::System.Drawing.Font("Microsoft YaHei", 13.8f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label2.Location = new global::System.Drawing.Point(9, 5);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(182, 31);
			this.label2.TabIndex = 8;
			this.label2.Text = "添加备注给员工";
			this.txtGhiChu.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.txtGhiChu.Location = new global::System.Drawing.Point(103, 98);
			this.txtGhiChu.Margin = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtGhiChu.Name = "txtGhiChu";
			this.txtGhiChu.Size = new global::System.Drawing.Size(257, 95);
			this.txtGhiChu.TabIndex = 7;
			this.txtGhiChu.Text = "";
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Microsoft YaHei", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.Location = new global::System.Drawing.Point(22, 98);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(63, 27);
			this.label1.TabIndex = 5;
			this.label1.Text = "备注 :";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(8f, 19f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(468, 278);
			base.Controls.Add(this.tableLayoutPanel1);
			this.Font = new global::System.Drawing.Font("Microsoft YaHei", 7.8f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			base.Margin = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
			base.Name = "frmGhiChu";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "备注";
			base.Load += new global::System.EventHandler(this.frmGhiChu_Load);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			base.ResumeLayout(false);
		}

		#endregion
	}
}