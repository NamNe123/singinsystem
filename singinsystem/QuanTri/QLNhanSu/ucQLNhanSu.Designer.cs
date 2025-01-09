
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace singinsystem.QuanTri.QLNhanSu
{
    partial class ucQLNhanSu
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
		private TableLayoutPanel tableLayoutPanel1;
		private Panel panel3;
		private Label label1;
		private Panel panel1;
		private DataGridView dgDSQLNhanSu;
		private Button btnThem;
		private Button btnXoa;
		private Button btnTimKiem;
		private TextBox txtTenNS;
		private TextBox txtId;
		private Label label3;
		private Label label2;
		private Button btnSua;
		private Button btnXoaTimKiem;
		private DataGridViewTextBoxColumn STT;
		private DataGridViewTextBoxColumn Id;
		private DataGridViewTextBoxColumn Ten;
		private Button btnImport;
		private Button btnXuatFileMau;
		private Label label4;
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
			this.dgDSQLNhanSu = new DataGridView();
			this.STT = new DataGridViewTextBoxColumn();
			this.Id = new DataGridViewTextBoxColumn();
			this.Ten = new DataGridViewTextBoxColumn();
			this.panel3 = new Panel();
			this.label4 = new Label();
			this.btnImport = new Button();
			this.btnXuatFileMau = new Button();
			this.btnXoaTimKiem = new Button();
			this.btnSua = new Button();
			this.txtId = new TextBox();
			this.label3 = new Label();
			this.label2 = new Label();
			this.btnThem = new Button();
			this.btnXoa = new Button();
			this.btnTimKiem = new Button();
			this.txtTenNS = new TextBox();
			this.label1 = new Label();
			this.tableLayoutPanel1.SuspendLayout();
			this.panel1.SuspendLayout();
			((ISupportInitialize)this.dgDSQLNhanSu).BeginInit();
			this.panel3.SuspendLayout();
			base.SuspendLayout();
			this.tableLayoutPanel1.BackColor = Color.White;
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 0);
			this.tableLayoutPanel1.Dock = DockStyle.Fill;
			this.tableLayoutPanel1.Location = new Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 3;
			this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 177f));
			this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 9f));
			this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel1.Size = new Size(781, 472);
			this.tableLayoutPanel1.TabIndex = 0;
			this.panel1.Controls.Add(this.dgDSQLNhanSu);
			this.panel1.Dock = DockStyle.Fill;
			this.panel1.Location = new Point(3, 189);
			this.panel1.Name = "panel1";
			this.panel1.Size = new Size(775, 280);
			this.panel1.TabIndex = 0;
			this.dgDSQLNhanSu.AllowUserToAddRows = false;
			this.dgDSQLNhanSu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgDSQLNhanSu.Columns.AddRange(new DataGridViewColumn[]
			{
				this.STT,
				this.Id,
				this.Ten
			});
			this.dgDSQLNhanSu.Dock = DockStyle.Fill;
			this.dgDSQLNhanSu.Location = new Point(0, 0);
			this.dgDSQLNhanSu.Name = "dgDSQLNhanSu";
			this.dgDSQLNhanSu.RowHeadersWidth = 51;
			this.dgDSQLNhanSu.Size = new Size(775, 280);
			this.dgDSQLNhanSu.TabIndex = 1;
			this.dgDSQLNhanSu.CellClick += this.dgDSQLNhanSu_CellClick;
			this.STT.DataPropertyName = "STT";
			this.STT.HeaderText = "序号";
			this.STT.MinimumWidth = 6;
			this.STT.Name = "STT";
			this.STT.Width = 125;
			this.Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
			this.Id.DataPropertyName = "Id";
			this.Id.HeaderText = "ID";
			this.Id.MinimumWidth = 6;
			this.Id.Name = "Id";
			this.Id.Width = 125;
			this.Ten.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.Ten.DataPropertyName = "Ten";
			this.Ten.HeaderText = "姓名";
			this.Ten.MinimumWidth = 6;
			this.Ten.Name = "Ten";
			this.panel3.BackColor = Color.White;
			this.panel3.Controls.Add(this.label4);
			this.panel3.Controls.Add(this.btnImport);
			this.panel3.Controls.Add(this.btnXuatFileMau);
			this.panel3.Controls.Add(this.btnXoaTimKiem);
			this.panel3.Controls.Add(this.btnSua);
			this.panel3.Controls.Add(this.txtId);
			this.panel3.Controls.Add(this.label3);
			this.panel3.Controls.Add(this.label2);
			this.panel3.Controls.Add(this.btnThem);
			this.panel3.Controls.Add(this.btnXoa);
			this.panel3.Controls.Add(this.btnTimKiem);
			this.panel3.Controls.Add(this.txtTenNS);
			this.panel3.Controls.Add(this.label1);
			this.panel3.Dock = DockStyle.Fill;
			this.panel3.Location = new Point(3, 3);
			this.panel3.Name = "panel3";
			this.panel3.Size = new Size(775, 171);
			this.panel3.TabIndex = 2;
			this.label4.AutoSize = true;
			this.label4.Location = new Point(3, 146);
			this.label4.Name = "label4";
			this.label4.Size = new Size(58, 25);
			this.label4.TabIndex = 17;
			this.label4.Text = "总共:";
			this.btnImport.BackColor = Color.FromArgb(0, 192, 192);
			this.btnImport.Font = new Font("Microsoft YaHei", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.btnImport.Location = new Point(607, 105);
			this.btnImport.Name = "btnImport";
			this.btnImport.Size = new Size(121, 30);
			this.btnImport.TabIndex = 16;
			this.btnImport.Text = "导入";
			this.btnImport.UseVisualStyleBackColor = false;
			this.btnImport.Click += this.btnImport_Click;
			this.btnXuatFileMau.BackColor = Color.FromArgb(0, 192, 192);
			this.btnXuatFileMau.Font = new Font("Microsoft YaHei", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.btnXuatFileMau.Location = new Point(434, 105);
			this.btnXuatFileMau.Name = "btnXuatFileMau";
			this.btnXuatFileMau.Size = new Size(152, 30);
			this.btnXuatFileMau.TabIndex = 15;
			this.btnXuatFileMau.Text = "原本";
			this.btnXuatFileMau.UseVisualStyleBackColor = false;
			this.btnXuatFileMau.Click += this.btnXuatFileMau_Click;
			this.btnXoaTimKiem.BackColor = Color.Aqua;
			this.btnXoaTimKiem.Location = new Point(465, 69);
			this.btnXoaTimKiem.Name = "btnXoaTimKiem";
			this.btnXoaTimKiem.Size = new Size(121, 30);
			this.btnXoaTimKiem.TabIndex = 14;
			this.btnXoaTimKiem.Text = "刷新";
			this.btnXoaTimKiem.UseVisualStyleBackColor = false;
			this.btnXoaTimKiem.Click += this.btnXoaTimKiem_Click;
			this.btnSua.BackColor = Color.FromArgb(0, 192, 192);
			this.btnSua.Location = new Point(307, 105);
			this.btnSua.Name = "btnSua";
			this.btnSua.Size = new Size(121, 30);
			this.btnSua.TabIndex = 13;
			this.btnSua.Text = "修改";
			this.btnSua.UseVisualStyleBackColor = false;
			this.btnSua.Click += this.btnSua_Click;
			this.txtId.Location = new Point(43, 69);
			this.txtId.Name = "txtId";
			this.txtId.Size = new Size(74, 30);
			this.txtId.TabIndex = 12;
			this.label3.AutoSize = true;
			this.label3.Location = new Point(144, 41);
			this.label3.Name = "label3";
			this.label3.Size = new Size(52, 25);
			this.label3.TabIndex = 11;
			this.label3.Text = "姓名";
			this.label2.AutoSize = true;
			this.label2.Location = new Point(43, 41);
			this.label2.Name = "label2";
			this.label2.Size = new Size(28, 25);
			this.label2.TabIndex = 10;
			this.label2.Text = "Id";
			this.btnThem.BackColor = Color.FromArgb(0, 192, 0);
			this.btnThem.Location = new Point(43, 105);
			this.btnThem.Name = "btnThem";
			this.btnThem.Size = new Size(121, 30);
			this.btnThem.TabIndex = 4;
			this.btnThem.Text = "添加";
			this.btnThem.UseVisualStyleBackColor = false;
			this.btnThem.Click += this.btnThem_Click;
			this.btnXoa.BackColor = Color.FromArgb(0, 192, 192);
			this.btnXoa.Location = new Point(178, 105);
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.Size = new Size(121, 30);
			this.btnXoa.TabIndex = 3;
			this.btnXoa.Text = "删除";
			this.btnXoa.UseVisualStyleBackColor = false;
			this.btnXoa.Click += this.btnXoa_Click;
			this.btnTimKiem.BackColor = Color.Aqua;
			this.btnTimKiem.Location = new Point(329, 69);
			this.btnTimKiem.Name = "btnTimKiem";
			this.btnTimKiem.Size = new Size(121, 30);
			this.btnTimKiem.TabIndex = 2;
			this.btnTimKiem.Text = "搜索";
			this.btnTimKiem.UseVisualStyleBackColor = false;
			this.btnTimKiem.Click += this.btnTimKiem_Click;
			this.txtTenNS.Location = new Point(149, 69);
			this.txtTenNS.Name = "txtTenNS";
			this.txtTenNS.Size = new Size(150, 30);
			this.txtTenNS.TabIndex = 1;
			this.label1.AutoSize = true;
			this.label1.Font = new Font("Microsoft Sans Serif", 16f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.label1.ForeColor = Color.Black;
			this.label1.Location = new Point(266, 10);
			this.label1.Name = "label1";
			this.label1.Size = new Size(126, 31);
			this.label1.TabIndex = 0;
			this.label1.Text = "人事管理";
			base.AutoScaleDimensions = new SizeF(12f, 25f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.CadetBlue;
			base.Controls.Add(this.tableLayoutPanel1);
			this.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			base.Margin = new Padding(4, 5, 4, 5);
			base.Name = "ucQLNhanSu";
			base.Size = new Size(781, 472);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			((ISupportInitialize)this.dgDSQLNhanSu).EndInit();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			base.ResumeLayout(false);
		}

		#endregion
	}
}
