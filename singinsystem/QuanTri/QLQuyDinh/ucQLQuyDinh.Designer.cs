
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace singinsystem.QuanTri.QLQuyDinh
{
    partial class ucQLQuyDinh
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
		private TableLayoutPanel tableLayoutPanel1;
		private Panel panel3;
		private Label label1;
		private Panel panel1;
		private DataGridView dgDSQLQuyDinh;
		private Label label2;
		private TextBox txtId;
		private Label label5;
		private Label label4;
		private Label label3;
		private TextBox txtDiemBiTru;
		private Button btnSua;
		private Button btnThem;
		private Button btnXoa;
		private Button button1;
		private TextBox txtQuyDinh;
		private ComboBox cbKieu;
		private DataGridViewTextBoxColumn Id;
		private DataGridViewTextBoxColumn QuyDinh;
		private DataGridViewTextBoxColumn DiemBiTru;
		private DataGridViewTextBoxColumn Kieu;
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
			this.dgDSQLQuyDinh = new DataGridView();
			this.panel3 = new Panel();
			this.cbKieu = new ComboBox();
			this.label2 = new Label();
			this.txtId = new TextBox();
			this.label5 = new Label();
			this.label4 = new Label();
			this.label3 = new Label();
			this.txtDiemBiTru = new TextBox();
			this.btnSua = new Button();
			this.btnThem = new Button();
			this.btnXoa = new Button();
			this.button1 = new Button();
			this.txtQuyDinh = new TextBox();
			this.label1 = new Label();
			this.Id = new DataGridViewTextBoxColumn();
			this.QuyDinh = new DataGridViewTextBoxColumn();
			this.DiemBiTru = new DataGridViewTextBoxColumn();
			this.Kieu = new DataGridViewTextBoxColumn();
			this.tableLayoutPanel1.SuspendLayout();
			this.panel1.SuspendLayout();
			((ISupportInitialize)this.dgDSQLQuyDinh).BeginInit();
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
			this.panel1.Controls.Add(this.dgDSQLQuyDinh);
			this.panel1.Dock = DockStyle.Fill;
			this.panel1.Location = new Point(3, 166);
			this.panel1.Name = "panel1";
			this.panel1.Size = new Size(775, 303);
			this.panel1.TabIndex = 0;
			this.dgDSQLQuyDinh.AllowUserToAddRows = false;
			this.dgDSQLQuyDinh.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgDSQLQuyDinh.Columns.AddRange(new DataGridViewColumn[]
			{
				this.Id,
				this.QuyDinh,
				this.DiemBiTru,
				this.Kieu
			});
			this.dgDSQLQuyDinh.Dock = DockStyle.Fill;
			this.dgDSQLQuyDinh.Location = new Point(0, 0);
			this.dgDSQLQuyDinh.Name = "dgDSQLQuyDinh";
			this.dgDSQLQuyDinh.RowHeadersWidth = 51;
			this.dgDSQLQuyDinh.Size = new Size(775, 303);
			this.dgDSQLQuyDinh.TabIndex = 1;
			this.dgDSQLQuyDinh.CellClick += this.dgDSQLQuyDinh_CellClick;
			this.panel3.BackColor = Color.White;
			this.panel3.Controls.Add(this.cbKieu);
			this.panel3.Controls.Add(this.label2);
			this.panel3.Controls.Add(this.txtId);
			this.panel3.Controls.Add(this.label5);
			this.panel3.Controls.Add(this.label4);
			this.panel3.Controls.Add(this.label3);
			this.panel3.Controls.Add(this.txtDiemBiTru);
			this.panel3.Controls.Add(this.btnSua);
			this.panel3.Controls.Add(this.btnThem);
			this.panel3.Controls.Add(this.btnXoa);
			this.panel3.Controls.Add(this.button1);
			this.panel3.Controls.Add(this.txtQuyDinh);
			this.panel3.Controls.Add(this.label1);
			this.panel3.Dock = DockStyle.Fill;
			this.panel3.Location = new Point(3, 3);
			this.panel3.Name = "panel3";
			this.panel3.Size = new Size(775, 149);
			this.panel3.TabIndex = 2;
			this.cbKieu.FormattingEnabled = true;
			this.cbKieu.Items.AddRange(new object[]
			{
				"上班 - Clock - in",
				"打卡 - Punch in/out"
			});
			this.cbKieu.Location = new Point(466, 77);
			this.cbKieu.Name = "cbKieu";
			this.cbKieu.Size = new Size(121, 33);
			this.cbKieu.TabIndex = 41;
			this.label2.AutoSize = true;
			this.label2.Location = new Point(24, 48);
			this.label2.Name = "label2";
			this.label2.Size = new Size(28, 25);
			this.label2.TabIndex = 40;
			this.label2.Text = "Id";
			this.txtId.Location = new Point(29, 80);
			this.txtId.Name = "txtId";
			this.txtId.Size = new Size(85, 30);
			this.txtId.TabIndex = 39;
			this.label5.AutoSize = true;
			this.label5.Location = new Point(461, 48);
			this.label5.Name = "label5";
			this.label5.Size = new Size(47, 25);
			this.label5.TabIndex = 38;
			this.label5.Text = "类型";
			this.label4.AutoSize = true;
			this.label4.Location = new Point(332, 48);
			this.label4.Name = "label4";
			this.label4.Size = new Size(52, 25);
			this.label4.TabIndex = 37;
			this.label4.Text = "扣分";
			this.label3.AutoSize = true;
			this.label3.Location = new Point(115, 48);
			this.label3.Name = "label3";
			this.label3.Size = new Size(52, 25);
			this.label3.TabIndex = 36;
			this.label3.Text = "规定";
			this.txtDiemBiTru.Location = new Point(337, 80);
			this.txtDiemBiTru.Name = "txtDiemBiTru";
			this.txtDiemBiTru.Size = new Size(121, 30);
			this.txtDiemBiTru.TabIndex = 35;
			this.btnSua.BackColor = Color.FromArgb(0, 192, 192);
			this.btnSua.Location = new Point(466, 116);
			this.btnSua.Name = "btnSua";
			this.btnSua.Size = new Size(121, 30);
			this.btnSua.TabIndex = 33;
			this.btnSua.Text = "修改";
			this.btnSua.UseVisualStyleBackColor = false;
			this.btnSua.Click += this.btnSua_Click;
			this.btnThem.BackColor = Color.FromArgb(0, 192, 0);
			this.btnThem.Location = new Point(202, 116);
			this.btnThem.Name = "btnThem";
			this.btnThem.Size = new Size(121, 30);
			this.btnThem.TabIndex = 32;
			this.btnThem.Text = "添加";
			this.btnThem.UseVisualStyleBackColor = false;
			this.btnThem.Click += this.btnThem_Click;
			this.btnXoa.BackColor = Color.FromArgb(0, 192, 192);
			this.btnXoa.Location = new Point(337, 116);
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.Size = new Size(121, 30);
			this.btnXoa.TabIndex = 31;
			this.btnXoa.Text = "删除";
			this.btnXoa.UseVisualStyleBackColor = false;
			this.btnXoa.Click += this.btnXoa_Click;
			this.button1.BackColor = Color.Aqua;
			this.button1.Location = new Point(627, 80);
			this.button1.Name = "button1";
			this.button1.Size = new Size(121, 30);
			this.button1.TabIndex = 30;
			this.button1.Text = "搜索";
			this.button1.UseVisualStyleBackColor = false;
			this.txtQuyDinh.Location = new Point(120, 80);
			this.txtQuyDinh.Name = "txtQuyDinh";
			this.txtQuyDinh.Size = new Size(203, 30);
			this.txtQuyDinh.TabIndex = 29;
			this.label1.AutoSize = true;
			this.label1.Font = new Font("Microsoft Sans Serif", 16f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.label1.ForeColor = Color.Black;
			this.label1.Location = new Point(294, 17);
			this.label1.Name = "label1";
			this.label1.Size = new Size(126, 31);
			this.label1.TabIndex = 0;
			this.label1.Text = "规定管理";
			this.Id.DataPropertyName = "Id";
			this.Id.HeaderText = "ID";
			this.Id.MinimumWidth = 6;
			this.Id.Name = "Id";
			this.Id.Width = 125;
			this.QuyDinh.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.QuyDinh.DataPropertyName = "QuyDinh";
			this.QuyDinh.HeaderText = "规定";
			this.QuyDinh.MinimumWidth = 6;
			this.QuyDinh.Name = "QuyDinh";
			this.DiemBiTru.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.DiemBiTru.DataPropertyName = "DiemBiTru";
			this.DiemBiTru.HeaderText = "扣分";
			this.DiemBiTru.MinimumWidth = 6;
			this.DiemBiTru.Name = "DiemBiTru";
			this.Kieu.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.Kieu.DataPropertyName = "Kieu";
			this.Kieu.HeaderText = "类型";
			this.Kieu.MinimumWidth = 6;
			this.Kieu.Name = "Kieu";
			base.AutoScaleDimensions = new SizeF(12f, 25f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.CadetBlue;
			base.Controls.Add(this.tableLayoutPanel1);
			this.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			base.Margin = new Padding(4, 5, 4, 5);
			base.Name = "ucQLQuyDinh";
			base.Size = new Size(781, 472);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			((ISupportInitialize)this.dgDSQLQuyDinh).EndInit();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			base.ResumeLayout(false);
		}

		#endregion
	}
}
