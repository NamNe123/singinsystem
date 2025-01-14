
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgDSQLQuyDinh = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuyDinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemBiTru = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbKieu = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDiemBiTru = new System.Windows.Forms.TextBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtQuyDinh = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnXuatFileMau = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDSQLQuyDinh)).BeginInit();
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
            this.panel1.Controls.Add(this.dgDSQLQuyDinh);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 166);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(775, 303);
            this.panel1.TabIndex = 0;
            // 
            // dgDSQLQuyDinh
            // 
            this.dgDSQLQuyDinh.AllowUserToAddRows = false;
            this.dgDSQLQuyDinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDSQLQuyDinh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.QuyDinh,
            this.DiemBiTru,
            this.Kieu});
            this.dgDSQLQuyDinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgDSQLQuyDinh.Location = new System.Drawing.Point(0, 0);
            this.dgDSQLQuyDinh.Name = "dgDSQLQuyDinh";
            this.dgDSQLQuyDinh.RowHeadersWidth = 51;
            this.dgDSQLQuyDinh.Size = new System.Drawing.Size(775, 303);
            this.dgDSQLQuyDinh.TabIndex = 1;
            this.dgDSQLQuyDinh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDSQLQuyDinh_CellClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "ID";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.Width = 125;
            // 
            // QuyDinh
            // 
            this.QuyDinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.QuyDinh.DataPropertyName = "QuyDinh";
            this.QuyDinh.HeaderText = "规定";
            this.QuyDinh.MinimumWidth = 6;
            this.QuyDinh.Name = "QuyDinh";
            // 
            // DiemBiTru
            // 
            this.DiemBiTru.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DiemBiTru.DataPropertyName = "DiemBiTru";
            this.DiemBiTru.HeaderText = "扣分";
            this.DiemBiTru.MinimumWidth = 6;
            this.DiemBiTru.Name = "DiemBiTru";
            // 
            // Kieu
            // 
            this.Kieu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Kieu.DataPropertyName = "Kieu";
            this.Kieu.HeaderText = "类型";
            this.Kieu.MinimumWidth = 6;
            this.Kieu.Name = "Kieu";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.btnImport);
            this.panel3.Controls.Add(this.btnXuatFileMau);
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
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(775, 149);
            this.panel3.TabIndex = 2;
            // 
            // cbKieu
            // 
            this.cbKieu.FormattingEnabled = true;
            this.cbKieu.Items.AddRange(new object[] {
            "上班 - Clock - in",
            "打卡 - Punch in/out"});
            this.cbKieu.Location = new System.Drawing.Point(466, 77);
            this.cbKieu.Name = "cbKieu";
            this.cbKieu.Size = new System.Drawing.Size(121, 33);
            this.cbKieu.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 25);
            this.label2.TabIndex = 40;
            this.label2.Text = "Id";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(29, 80);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(85, 30);
            this.txtId.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(461, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 25);
            this.label5.TabIndex = 38;
            this.label5.Text = "类型";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(332, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 25);
            this.label4.TabIndex = 37;
            this.label4.Text = "扣分";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(115, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 25);
            this.label3.TabIndex = 36;
            this.label3.Text = "规定";
            // 
            // txtDiemBiTru
            // 
            this.txtDiemBiTru.Location = new System.Drawing.Point(337, 80);
            this.txtDiemBiTru.Name = "txtDiemBiTru";
            this.txtDiemBiTru.Size = new System.Drawing.Size(121, 30);
            this.txtDiemBiTru.TabIndex = 35;
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSua.Location = new System.Drawing.Point(337, 116);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(121, 30);
            this.btnSua.TabIndex = 33;
            this.btnSua.Text = "修改";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnThem.Location = new System.Drawing.Point(65, 116);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(121, 30);
            this.btnThem.TabIndex = 32;
            this.btnThem.Text = "添加";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnXoa.Location = new System.Drawing.Point(202, 116);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(121, 30);
            this.btnXoa.TabIndex = 31;
            this.btnXoa.Text = "删除";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Aqua;
            this.button1.Location = new System.Drawing.Point(627, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 30);
            this.button1.TabIndex = 30;
            this.button1.Text = "搜索";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // txtQuyDinh
            // 
            this.txtQuyDinh.Location = new System.Drawing.Point(120, 80);
            this.txtQuyDinh.Name = "txtQuyDinh";
            this.txtQuyDinh.Size = new System.Drawing.Size(203, 30);
            this.txtQuyDinh.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(294, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "规定管理";
            // 
            // btnImport
            // 
            this.btnImport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnImport.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImport.Location = new System.Drawing.Point(627, 116);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(112, 30);
            this.btnImport.TabIndex = 43;
            this.btnImport.Text = "导入";
            this.btnImport.UseVisualStyleBackColor = false;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnXuatFileMau
            // 
            this.btnXuatFileMau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnXuatFileMau.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatFileMau.Location = new System.Drawing.Point(466, 116);
            this.btnXuatFileMau.Name = "btnXuatFileMau";
            this.btnXuatFileMau.Size = new System.Drawing.Size(143, 30);
            this.btnXuatFileMau.TabIndex = 42;
            this.btnXuatFileMau.Text = "原本";
            this.btnXuatFileMau.UseVisualStyleBackColor = false;
            this.btnXuatFileMau.Click += new System.EventHandler(this.btnXuatFileMau_Click);
            // 
            // ucQLQuyDinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ucQLQuyDinh";
            this.Size = new System.Drawing.Size(781, 472);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgDSQLQuyDinh)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

		}

        #endregion

        private Button btnImport;
        private Button btnXuatFileMau;
    }
}
