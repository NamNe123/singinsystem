
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace singinsystem.QuanTri.QLLoaiDangKy
{
    partial class ucQLLoaiDangKy
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
		private TableLayoutPanel tableLayoutPanel1;
		private Panel panel3;
		private Label label1;
		private Panel panel1;
		private DataGridView dgDSQLLoaiDangKy;
		private Button button1;
		private TextBox txtKieu;
		private Label label5;
		private Label label4;
		private Label label3;
		private TextBox txtThoiGian;
		private TextBox txtSoLan;
		private Button btnSua;
		private Button btnThem;
		private Button btnXoa;
		private Label label2;
		private TextBox txtId;
		private DataGridViewTextBoxColumn Id;
		private DataGridViewTextBoxColumn Kieu;
		private DataGridViewTextBoxColumn ThoiGian;
		private DataGridViewTextBoxColumn SoLan;
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
			this.dgDSQLLoaiDangKy = new DataGridView();
			this.panel3 = new Panel();
			this.label2 = new Label();
			this.txtId = new TextBox();
			this.label5 = new Label();
			this.label4 = new Label();
			this.label3 = new Label();
			this.txtThoiGian = new TextBox();
			this.txtSoLan = new TextBox();
			this.btnSua = new Button();
			this.btnThem = new Button();
			this.btnXoa = new Button();
			this.button1 = new Button();
			this.txtKieu = new TextBox();
			this.label1 = new Label();
			this.Id = new DataGridViewTextBoxColumn();
			this.Kieu = new DataGridViewTextBoxColumn();
			this.ThoiGian = new DataGridViewTextBoxColumn();
			this.SoLan = new DataGridViewTextBoxColumn();
			this.tableLayoutPanel1.SuspendLayout();
			this.panel1.SuspendLayout();
			((ISupportInitialize)this.dgDSQLLoaiDangKy).BeginInit();
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
			this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 155f));
			this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 8f));
			this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel1.Size = new Size(781, 472);
			this.tableLayoutPanel1.TabIndex = 0;
			this.panel1.Controls.Add(this.dgDSQLLoaiDangKy);
			this.panel1.Dock = DockStyle.Fill;
			this.panel1.Location = new Point(3, 166);
			this.panel1.Name = "panel1";
			this.panel1.Size = new Size(775, 303);
			this.panel1.TabIndex = 0;
			this.dgDSQLLoaiDangKy.AllowUserToAddRows = false;
			this.dgDSQLLoaiDangKy.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgDSQLLoaiDangKy.Columns.AddRange(new DataGridViewColumn[]
			{
				this.Id,
				this.Kieu,
				this.ThoiGian,
				this.SoLan
			});
			this.dgDSQLLoaiDangKy.Dock = DockStyle.Fill;
			this.dgDSQLLoaiDangKy.Location = new Point(0, 0);
			this.dgDSQLLoaiDangKy.Name = "dgDSQLLoaiDangKy";
			this.dgDSQLLoaiDangKy.RowHeadersWidth = 51;
			this.dgDSQLLoaiDangKy.Size = new Size(775, 303);
			this.dgDSQLLoaiDangKy.TabIndex = 1;
			this.dgDSQLLoaiDangKy.CellClick += this.dgDSQLLoaiDangKy_CellClick;
			this.panel3.BackColor = Color.White;
			this.panel3.Controls.Add(this.label2);
			this.panel3.Controls.Add(this.txtId);
			this.panel3.Controls.Add(this.label5);
			this.panel3.Controls.Add(this.label4);
			this.panel3.Controls.Add(this.label3);
			this.panel3.Controls.Add(this.txtThoiGian);
			this.panel3.Controls.Add(this.txtSoLan);
			this.panel3.Controls.Add(this.btnSua);
			this.panel3.Controls.Add(this.btnThem);
			this.panel3.Controls.Add(this.btnXoa);
			this.panel3.Controls.Add(this.button1);
			this.panel3.Controls.Add(this.txtKieu);
			this.panel3.Controls.Add(this.label1);
			this.panel3.Dock = DockStyle.Fill;
			this.panel3.Location = new Point(3, 3);
			this.panel3.Name = "panel3";
			this.panel3.Size = new Size(775, 149);
			this.panel3.TabIndex = 2;
			this.label2.AutoSize = true;
			this.label2.Location = new Point(31, 48);
			this.label2.Name = "label2";
			this.label2.Size = new Size(28, 25);
			this.label2.TabIndex = 28;
			this.label2.Text = "Id";
			this.txtId.Location = new Point(36, 80);
			this.txtId.Name = "txtId";
			this.txtId.Size = new Size(85, 30);
			this.txtId.TabIndex = 27;
			this.label5.AutoSize = true;
			this.label5.Location = new Point(468, 48);
			this.label5.Name = "label5";
			this.label5.Size = new Size(52, 25);
			this.label5.TabIndex = 26;
			this.label5.Text = "数次";
			this.label4.AutoSize = true;
			this.label4.Location = new Point(339, 48);
			this.label4.Name = "label4";
			this.label4.Size = new Size(52, 25);
			this.label4.TabIndex = 25;
			this.label4.Text = "时间";
			this.label3.AutoSize = true;
			this.label3.Location = new Point(122, 48);
			this.label3.Name = "label3";
			this.label3.Size = new Size(52, 25);
			this.label3.TabIndex = 24;
			this.label3.Text = "理由";
			this.txtThoiGian.Location = new Point(344, 80);
			this.txtThoiGian.Name = "txtThoiGian";
			this.txtThoiGian.Size = new Size(121, 30);
			this.txtThoiGian.TabIndex = 22;
			this.txtSoLan.Location = new Point(473, 80);
			this.txtSoLan.Name = "txtSoLan";
			this.txtSoLan.Size = new Size(121, 30);
			this.txtSoLan.TabIndex = 20;
			this.btnSua.BackColor = Color.FromArgb(0, 192, 192);
			this.btnSua.Location = new Point(473, 116);
			this.btnSua.Name = "btnSua";
			this.btnSua.Size = new Size(121, 30);
			this.btnSua.TabIndex = 19;
			this.btnSua.Text = "修改";
			this.btnSua.UseVisualStyleBackColor = false;
			this.btnSua.Click += this.btnSua_Click;
			this.btnThem.BackColor = Color.FromArgb(0, 192, 0);
			this.btnThem.Location = new Point(209, 116);
			this.btnThem.Name = "btnThem";
			this.btnThem.Size = new Size(121, 30);
			this.btnThem.TabIndex = 18;
			this.btnThem.Text = "添加";
			this.btnThem.UseVisualStyleBackColor = false;
			this.btnThem.Click += this.btnThem_Click;
			this.btnXoa.BackColor = Color.FromArgb(0, 192, 192);
			this.btnXoa.Location = new Point(344, 116);
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.Size = new Size(121, 30);
			this.btnXoa.TabIndex = 17;
			this.btnXoa.Text = "删除";
			this.btnXoa.UseVisualStyleBackColor = false;
			this.btnXoa.Click += this.btnXoa_Click;
			this.button1.BackColor = Color.Aqua;
			this.button1.Location = new Point(634, 80);
			this.button1.Name = "button1";
			this.button1.Size = new Size(121, 30);
			this.button1.TabIndex = 2;
			this.button1.Text = "搜索";
			this.button1.UseVisualStyleBackColor = false;
			this.txtKieu.Location = new Point(127, 80);
			this.txtKieu.Name = "txtKieu";
			this.txtKieu.Size = new Size(203, 30);
			this.txtKieu.TabIndex = 1;
			this.label1.AutoSize = true;
			this.label1.Font = new Font("Microsoft Sans Serif", 16f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.label1.ForeColor = Color.Black;
			this.label1.Location = new Point(274, 17);
			this.label1.Name = "label1";
			this.label1.Size = new Size(119, 31);
			this.label1.TabIndex = 0;
			this.label1.Text = "打卡类型";
			this.Id.DataPropertyName = "Id";
			this.Id.HeaderText = "ID";
			this.Id.MinimumWidth = 6;
			this.Id.Name = "Id";
			this.Id.Width = 125;
			this.Kieu.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.Kieu.DataPropertyName = "Kieu";
			this.Kieu.HeaderText = "理由";
			this.Kieu.MinimumWidth = 6;
			this.Kieu.Name = "Kieu";
			this.ThoiGian.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.ThoiGian.DataPropertyName = "ThoiGian";
			this.ThoiGian.HeaderText = "时间";
			this.ThoiGian.MinimumWidth = 6;
			this.ThoiGian.Name = "ThoiGian";
			this.SoLan.DataPropertyName = "SoLan";
			this.SoLan.HeaderText = "数次";
			this.SoLan.MinimumWidth = 6;
			this.SoLan.Name = "SoLan";
			this.SoLan.Width = 125;
			base.AutoScaleDimensions = new SizeF(12f, 25f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.CadetBlue;
			base.Controls.Add(this.tableLayoutPanel1);
			this.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			base.Margin = new Padding(4, 5, 4, 5);
			base.Name = "ucQLLoaiDangKy";
			base.Size = new Size(781, 472);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			((ISupportInitialize)this.dgDSQLLoaiDangKy).EndInit();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			base.ResumeLayout(false);
		}

		#endregion
	}
}
