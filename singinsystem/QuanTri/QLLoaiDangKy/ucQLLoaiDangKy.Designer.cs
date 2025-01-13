
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgDSQLLoaiDangKy = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiGian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtThoiGian = new System.Windows.Forms.TextBox();
            this.txtSoLan = new System.Windows.Forms.TextBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtKieu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDSQLLoaiDangKy)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 155F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(781, 472);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgDSQLLoaiDangKy);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 166);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(775, 303);
            this.panel1.TabIndex = 0;
            // 
            // dgDSQLLoaiDangKy
            // 
            this.dgDSQLLoaiDangKy.AllowUserToAddRows = false;
            this.dgDSQLLoaiDangKy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDSQLLoaiDangKy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Kieu,
            this.ThoiGian,
            this.SoLan});
            this.dgDSQLLoaiDangKy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgDSQLLoaiDangKy.Location = new System.Drawing.Point(0, 0);
            this.dgDSQLLoaiDangKy.Name = "dgDSQLLoaiDangKy";
            this.dgDSQLLoaiDangKy.RowHeadersWidth = 51;
            this.dgDSQLLoaiDangKy.Size = new System.Drawing.Size(775, 303);
            this.dgDSQLLoaiDangKy.TabIndex = 1;
            this.dgDSQLLoaiDangKy.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDSQLLoaiDangKy_CellClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "ID";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.Width = 125;
            // 
            // Kieu
            // 
            this.Kieu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Kieu.DataPropertyName = "Kieu";
            this.Kieu.HeaderText = "理由";
            this.Kieu.MinimumWidth = 6;
            this.Kieu.Name = "Kieu";
            // 
            // ThoiGian
            // 
            this.ThoiGian.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ThoiGian.DataPropertyName = "ThoiGian";
            this.ThoiGian.HeaderText = "时间";
            this.ThoiGian.MinimumWidth = 6;
            this.ThoiGian.Name = "ThoiGian";
            // 
            // SoLan
            // 
            this.SoLan.DataPropertyName = "SoLan";
            this.SoLan.HeaderText = "数次";
            this.SoLan.MinimumWidth = 6;
            this.SoLan.Name = "SoLan";
            this.SoLan.Width = 125;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
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
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(775, 149);
            this.panel3.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 25);
            this.label2.TabIndex = 28;
            this.label2.Text = "Id";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(36, 80);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(85, 30);
            this.txtId.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(468, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 25);
            this.label5.TabIndex = 26;
            this.label5.Text = "数次";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(339, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 25);
            this.label4.TabIndex = 25;
            this.label4.Text = "时间";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(122, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 25);
            this.label3.TabIndex = 24;
            this.label3.Text = "理由";
            // 
            // txtThoiGian
            // 
            this.txtThoiGian.Location = new System.Drawing.Point(344, 80);
            this.txtThoiGian.Name = "txtThoiGian";
            this.txtThoiGian.Size = new System.Drawing.Size(121, 30);
            this.txtThoiGian.TabIndex = 22;
            // 
            // txtSoLan
            // 
            this.txtSoLan.Location = new System.Drawing.Point(473, 80);
            this.txtSoLan.Name = "txtSoLan";
            this.txtSoLan.Size = new System.Drawing.Size(121, 30);
            this.txtSoLan.TabIndex = 20;
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSua.Location = new System.Drawing.Point(473, 116);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(121, 30);
            this.btnSua.TabIndex = 19;
            this.btnSua.Text = "修改";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnThem.Location = new System.Drawing.Point(209, 116);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(121, 30);
            this.btnThem.TabIndex = 18;
            this.btnThem.Text = "添加";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnXoa.Location = new System.Drawing.Point(344, 116);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(121, 30);
            this.btnXoa.TabIndex = 17;
            this.btnXoa.Text = "删除";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Aqua;
            this.button1.Location = new System.Drawing.Point(634, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 30);
            this.button1.TabIndex = 2;
            this.button1.Text = "搜索";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtKieu
            // 
            this.txtKieu.Location = new System.Drawing.Point(127, 80);
            this.txtKieu.Name = "txtKieu";
            this.txtKieu.Size = new System.Drawing.Size(203, 30);
            this.txtKieu.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(274, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "打卡类型";
            // 
            // ucQLLoaiDangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ucQLLoaiDangKy";
            this.Size = new System.Drawing.Size(781, 472);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgDSQLLoaiDangKy)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion
	}
}
