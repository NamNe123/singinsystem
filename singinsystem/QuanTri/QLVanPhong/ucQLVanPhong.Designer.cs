
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace singinsystem.QuanTri.QLVanPhong
{
    partial class ucQLVanPhong
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
		private TableLayoutPanel tableLayoutPanel1;
		private Panel panel3;
		private Label label1;
		private Panel panel1;
		private DataGridView dgDSQLVanPhong;
		private Button btnSua;
		private Button btnThem;
		private Button btnXoa;
		private TextBox txtId;
		private Label label3;
		private Label label2;
		private TextBox txtTenVP;
		private DataGridViewTextBoxColumn Id;
		private DataGridViewTextBoxColumn Ten;
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
			this.dgDSQLVanPhong = new DataGridView();
			this.panel3 = new Panel();
			this.txtId = new TextBox();
			this.label3 = new Label();
			this.label2 = new Label();
			this.txtTenVP = new TextBox();
			this.btnSua = new Button();
			this.btnThem = new Button();
			this.btnXoa = new Button();
			this.label1 = new Label();
			this.Id = new DataGridViewTextBoxColumn();
			this.Ten = new DataGridViewTextBoxColumn();
			this.tableLayoutPanel1.SuspendLayout();
			this.panel1.SuspendLayout();
			((ISupportInitialize)this.dgDSQLVanPhong).BeginInit();
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
			this.panel1.Controls.Add(this.dgDSQLVanPhong);
			this.panel1.Dock = DockStyle.Fill;
			this.panel1.Location = new Point(3, 166);
			this.panel1.Name = "panel1";
			this.panel1.Size = new Size(775, 303);
			this.panel1.TabIndex = 0;
			this.dgDSQLVanPhong.AllowUserToAddRows = false;
			this.dgDSQLVanPhong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgDSQLVanPhong.Columns.AddRange(new DataGridViewColumn[]
			{
				this.Id,
				this.Ten
			});
			this.dgDSQLVanPhong.Dock = DockStyle.Fill;
			this.dgDSQLVanPhong.Location = new Point(0, 0);
			this.dgDSQLVanPhong.Name = "dgDSQLVanPhong";
			this.dgDSQLVanPhong.RowHeadersWidth = 51;
			this.dgDSQLVanPhong.Size = new Size(775, 303);
			this.dgDSQLVanPhong.TabIndex = 1;
			this.dgDSQLVanPhong.CellClick += this.dgDSQLVanPhong_CellClick;
			this.panel3.BackColor = Color.White;
			this.panel3.Controls.Add(this.txtId);
			this.panel3.Controls.Add(this.label3);
			this.panel3.Controls.Add(this.label2);
			this.panel3.Controls.Add(this.txtTenVP);
			this.panel3.Controls.Add(this.btnSua);
			this.panel3.Controls.Add(this.btnThem);
			this.panel3.Controls.Add(this.btnXoa);
			this.panel3.Controls.Add(this.label1);
			this.panel3.Dock = DockStyle.Fill;
			this.panel3.Location = new Point(3, 3);
			this.panel3.Name = "panel3";
			this.panel3.Size = new Size(775, 149);
			this.panel3.TabIndex = 2;
			this.txtId.Location = new Point(46, 92);
			this.txtId.Name = "txtId";
			this.txtId.Size = new Size(74, 30);
			this.txtId.TabIndex = 20;
			this.label3.AutoSize = true;
			this.label3.Location = new Point(147, 64);
			this.label3.Name = "label3";
			this.label3.Size = new Size(72, 25);
			this.label3.TabIndex = 19;
			this.label3.Text = "办公室";
			this.label2.AutoSize = true;
			this.label2.Location = new Point(46, 64);
			this.label2.Name = "label2";
			this.label2.Size = new Size(28, 25);
			this.label2.TabIndex = 18;
			this.label2.Text = "Id";
			this.txtTenVP.Location = new Point(152, 92);
			this.txtTenVP.Name = "txtTenVP";
			this.txtTenVP.Size = new Size(150, 30);
			this.txtTenVP.TabIndex = 17;
			this.btnSua.BackColor = Color.FromArgb(0, 192, 192);
			this.btnSua.Location = new Point(573, 92);
			this.btnSua.Name = "btnSua";
			this.btnSua.Size = new Size(121, 30);
			this.btnSua.TabIndex = 16;
			this.btnSua.Text = "修改";
			this.btnSua.UseVisualStyleBackColor = false;
			this.btnSua.Click += this.btnSua_Click;
			this.btnThem.BackColor = Color.FromArgb(0, 192, 0);
			this.btnThem.Location = new Point(309, 92);
			this.btnThem.Name = "btnThem";
			this.btnThem.Size = new Size(121, 30);
			this.btnThem.TabIndex = 15;
			this.btnThem.Text = "添加";
			this.btnThem.UseVisualStyleBackColor = false;
			this.btnThem.Click += this.btnThem_Click;
			this.btnXoa.BackColor = Color.FromArgb(0, 192, 192);
			this.btnXoa.Location = new Point(444, 92);
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.Size = new Size(121, 30);
			this.btnXoa.TabIndex = 14;
			this.btnXoa.Text = "删除";
			this.btnXoa.UseVisualStyleBackColor = false;
			this.btnXoa.Click += this.btnXoa_Click;
			this.label1.AutoSize = true;
			this.label1.Font = new Font("Microsoft Sans Serif", 16f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.label1.ForeColor = Color.Black;
			this.label1.Location = new Point(266, 10);
			this.label1.Name = "label1";
			this.label1.Size = new Size(154, 31);
			this.label1.TabIndex = 0;
			this.label1.Text = "办公室管理";
			this.Id.DataPropertyName = "Id";
			this.Id.HeaderText = "ID";
			this.Id.MinimumWidth = 6;
			this.Id.Name = "Id";
			this.Id.Width = 125;
			this.Ten.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.Ten.DataPropertyName = "Ten";
			this.Ten.HeaderText = "办公室";
			this.Ten.MinimumWidth = 6;
			this.Ten.Name = "Ten";
			base.AutoScaleDimensions = new SizeF(12f, 25f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.CadetBlue;
			base.Controls.Add(this.tableLayoutPanel1);
			this.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			base.Margin = new Padding(4, 5, 4, 5);
			base.Name = "ucQLVanPhong";
			base.Size = new Size(781, 472);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			((ISupportInitialize)this.dgDSQLVanPhong).EndInit();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			base.ResumeLayout(false);
		}

		#endregion
	}
}
