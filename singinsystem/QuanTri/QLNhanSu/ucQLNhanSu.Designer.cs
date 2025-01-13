
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgDSQLNhanSu = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnXuatFileMau = new System.Windows.Forms.Button();
            this.btnXoaTimKiem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTenNS = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDSQLNhanSu)).BeginInit();
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
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 177F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 9F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(781, 472);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgDSQLNhanSu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 189);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(775, 280);
            this.panel1.TabIndex = 0;
            // 
            // dgDSQLNhanSu
            // 
            this.dgDSQLNhanSu.AllowUserToAddRows = false;
            this.dgDSQLNhanSu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDSQLNhanSu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.Id,
            this.Ten});
            this.dgDSQLNhanSu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgDSQLNhanSu.Location = new System.Drawing.Point(0, 0);
            this.dgDSQLNhanSu.Name = "dgDSQLNhanSu";
            this.dgDSQLNhanSu.RowHeadersWidth = 51;
            this.dgDSQLNhanSu.Size = new System.Drawing.Size(775, 280);
            this.dgDSQLNhanSu.TabIndex = 1;
            this.dgDSQLNhanSu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDSQLNhanSu_CellClick);
            // 
            // STT
            // 
            this.STT.DataPropertyName = "STT";
            this.STT.HeaderText = "序号";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            this.STT.Width = 125;
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "ID";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.Width = 125;
            // 
            // Ten
            // 
            this.Ten.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ten.DataPropertyName = "Ten";
            this.Ten.HeaderText = "姓名";
            this.Ten.MinimumWidth = 6;
            this.Ten.Name = "Ten";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
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
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(775, 171);
            this.panel3.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 25);
            this.label4.TabIndex = 17;
            this.label4.Text = "总共:";
            // 
            // btnImport
            // 
            this.btnImport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnImport.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImport.Location = new System.Drawing.Point(607, 105);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(121, 30);
            this.btnImport.TabIndex = 16;
            this.btnImport.Text = "导入";
            this.btnImport.UseVisualStyleBackColor = false;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnXuatFileMau
            // 
            this.btnXuatFileMau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnXuatFileMau.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatFileMau.Location = new System.Drawing.Point(434, 105);
            this.btnXuatFileMau.Name = "btnXuatFileMau";
            this.btnXuatFileMau.Size = new System.Drawing.Size(152, 30);
            this.btnXuatFileMau.TabIndex = 15;
            this.btnXuatFileMau.Text = "原本";
            this.btnXuatFileMau.UseVisualStyleBackColor = false;
            this.btnXuatFileMau.Click += new System.EventHandler(this.btnXuatFileMau_Click);
            // 
            // btnXoaTimKiem
            // 
            this.btnXoaTimKiem.BackColor = System.Drawing.Color.Aqua;
            this.btnXoaTimKiem.Location = new System.Drawing.Point(465, 69);
            this.btnXoaTimKiem.Name = "btnXoaTimKiem";
            this.btnXoaTimKiem.Size = new System.Drawing.Size(121, 30);
            this.btnXoaTimKiem.TabIndex = 14;
            this.btnXoaTimKiem.Text = "刷新";
            this.btnXoaTimKiem.UseVisualStyleBackColor = false;
            this.btnXoaTimKiem.Click += new System.EventHandler(this.btnXoaTimKiem_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSua.Location = new System.Drawing.Point(307, 105);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(121, 30);
            this.btnSua.TabIndex = 13;
            this.btnSua.Text = "修改";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(43, 69);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(74, 30);
            this.txtId.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(144, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "姓名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Id";
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnThem.Location = new System.Drawing.Point(43, 105);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(121, 30);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "添加";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnXoa.Location = new System.Drawing.Point(178, 105);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(121, 30);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "删除";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.Aqua;
            this.btnTimKiem.Location = new System.Drawing.Point(329, 69);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(121, 30);
            this.btnTimKiem.TabIndex = 2;
            this.btnTimKiem.Text = "搜索";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTenNS
            // 
            this.txtTenNS.Location = new System.Drawing.Point(149, 69);
            this.txtTenNS.Name = "txtTenNS";
            this.txtTenNS.Size = new System.Drawing.Size(150, 30);
            this.txtTenNS.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(266, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "人事管理";
            // 
            // ucQLNhanSu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ucQLNhanSu";
            this.Size = new System.Drawing.Size(781, 472);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgDSQLNhanSu)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion
	}
}
