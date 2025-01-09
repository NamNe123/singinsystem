
namespace singinsystem.QuanTri.QLTaiKhoan
{
    partial class frmThemTaiKhoan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
		private global::System.Windows.Forms.Label lblTitle;
		private global::System.Windows.Forms.Label label1;
		private global::System.Windows.Forms.TextBox txtTenDangNhap;
		private global::System.Windows.Forms.Label label2;
		private global::System.Windows.Forms.TextBox txtMatKhau;
		private global::System.Windows.Forms.Label label3;
		private global::System.Windows.Forms.TextBox txtNhapLaiMK;
		private global::System.Windows.Forms.Label label4;
		private global::System.Windows.Forms.TextBox txtTenDayDu;
		private global::System.Windows.Forms.Label label5;
		private global::System.Windows.Forms.ComboBox cboQuyenDangNhap;
		private global::System.Windows.Forms.Button btnThem;
		private global::System.Windows.Forms.Button btnThoat;
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
			this.lblTitle = new global::System.Windows.Forms.Label();
			this.label1 = new global::System.Windows.Forms.Label();
			this.txtTenDangNhap = new global::System.Windows.Forms.TextBox();
			this.label2 = new global::System.Windows.Forms.Label();
			this.txtMatKhau = new global::System.Windows.Forms.TextBox();
			this.label3 = new global::System.Windows.Forms.Label();
			this.txtNhapLaiMK = new global::System.Windows.Forms.TextBox();
			this.label4 = new global::System.Windows.Forms.Label();
			this.txtTenDayDu = new global::System.Windows.Forms.TextBox();
			this.label5 = new global::System.Windows.Forms.Label();
			this.cboQuyenDangNhap = new global::System.Windows.Forms.ComboBox();
			this.btnThem = new global::System.Windows.Forms.Button();
			this.btnThoat = new global::System.Windows.Forms.Button();
			base.SuspendLayout();
			this.lblTitle.AutoSize = true;
			this.lblTitle.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 16f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblTitle.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
			this.lblTitle.Location = new global::System.Drawing.Point(220, 19);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new global::System.Drawing.Size(95, 31);
			this.lblTitle.TabIndex = 0;
			this.lblTitle.Text = "新帐号";
			this.label1.AutoSize = true;
			this.label1.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
			this.label1.Location = new global::System.Drawing.Point(24, 75);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(52, 25);
			this.label1.TabIndex = 1;
			this.label1.Text = "账号";
			this.txtTenDangNhap.Location = new global::System.Drawing.Point(181, 75);
			this.txtTenDangNhap.Name = "txtTenDangNhap";
			this.txtTenDangNhap.Size = new global::System.Drawing.Size(294, 30);
			this.txtTenDangNhap.TabIndex = 2;
			this.label2.AutoSize = true;
			this.label2.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
			this.label2.Location = new global::System.Drawing.Point(24, 107);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(52, 25);
			this.label2.TabIndex = 1;
			this.label2.Text = "密码";
			this.txtMatKhau.Location = new global::System.Drawing.Point(181, 107);
			this.txtMatKhau.Name = "txtMatKhau";
			this.txtMatKhau.Size = new global::System.Drawing.Size(294, 30);
			this.txtMatKhau.TabIndex = 2;
			this.label3.AutoSize = true;
			this.label3.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
			this.label3.Location = new global::System.Drawing.Point(24, 139);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(152, 25);
			this.label3.TabIndex = 1;
			this.label3.Text = "再次输入新密码";
			this.txtNhapLaiMK.Location = new global::System.Drawing.Point(181, 139);
			this.txtNhapLaiMK.Name = "txtNhapLaiMK";
			this.txtNhapLaiMK.Size = new global::System.Drawing.Size(294, 30);
			this.txtNhapLaiMK.TabIndex = 2;
			this.label4.AutoSize = true;
			this.label4.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
			this.label4.Location = new global::System.Drawing.Point(24, 171);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(52, 25);
			this.label4.TabIndex = 1;
			this.label4.Text = "姓名";
			this.txtTenDayDu.Location = new global::System.Drawing.Point(181, 171);
			this.txtTenDayDu.Name = "txtTenDayDu";
			this.txtTenDayDu.Size = new global::System.Drawing.Size(294, 30);
			this.txtTenDayDu.TabIndex = 2;
			this.label5.AutoSize = true;
			this.label5.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
			this.label5.Location = new global::System.Drawing.Point(24, 207);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(52, 25);
			this.label5.TabIndex = 1;
			this.label5.Text = "状态";
			this.cboQuyenDangNhap.FormattingEnabled = true;
			this.cboQuyenDangNhap.Location = new global::System.Drawing.Point(181, 207);
			this.cboQuyenDangNhap.Name = "cboQuyenDangNhap";
			this.cboQuyenDangNhap.Size = new global::System.Drawing.Size(294, 33);
			this.cboQuyenDangNhap.TabIndex = 3;
			this.btnThem.BackColor = global::System.Drawing.Color.LightSeaGreen;
			this.btnThem.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnThem.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
			this.btnThem.Location = new global::System.Drawing.Point(181, 261);
			this.btnThem.Name = "btnThem";
			this.btnThem.Size = new global::System.Drawing.Size(127, 33);
			this.btnThem.TabIndex = 4;
			this.btnThem.Text = "添加";
			this.btnThem.UseVisualStyleBackColor = false;
			this.btnThem.Click += new global::System.EventHandler(this.btnThem_Click);
			this.btnThoat.BackColor = global::System.Drawing.Color.LightSeaGreen;
			this.btnThoat.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnThoat.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
			this.btnThoat.Location = new global::System.Drawing.Point(324, 261);
			this.btnThoat.Name = "btnThoat";
			this.btnThoat.Size = new global::System.Drawing.Size(127, 33);
			this.btnThoat.TabIndex = 4;
			this.btnThoat.Text = "取消";
			this.btnThoat.UseVisualStyleBackColor = false;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(12f, 25f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.LightSeaGreen;
			base.ClientSize = new global::System.Drawing.Size(515, 359);
			base.Controls.Add(this.btnThoat);
			base.Controls.Add(this.btnThem);
			base.Controls.Add(this.cboQuyenDangNhap);
			base.Controls.Add(this.txtTenDayDu);
			base.Controls.Add(this.label5);
			base.Controls.Add(this.label4);
			base.Controls.Add(this.txtNhapLaiMK);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.txtMatKhau);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.txtTenDangNhap);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.lblTitle);
			this.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			base.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			base.Name = "frmThemTaiKhoan";
			this.Text = " 账号";
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		#endregion
	}
}