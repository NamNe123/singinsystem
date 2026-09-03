namespace singinsystem.Login
{
	// Token: 0x0200001B RID: 27
	public partial class frmLoginAdmin : global::System.Windows.Forms.Form
	{
		// Token: 0x060000C6 RID: 198 RVA: 0x00019950 File Offset: 0x00017B50
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00019988 File Offset: 0x00017B88
		private void InitializeComponent()
		{
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.txtDangNhap = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(257, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Log-in";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.btnThoat);
            this.panel1.Controls.Add(this.btnDangNhap);
            this.panel1.Controls.Add(this.txtMatKhau);
            this.panel1.Controls.Add(this.txtDangNhap);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(31, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(524, 164);
            this.panel1.TabIndex = 1;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(309, 112);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(117, 34);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Cancel";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Location = new System.Drawing.Point(168, 112);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(117, 34);
            this.btnDangNhap.TabIndex = 3;
            this.btnDangNhap.Text = "Login";
            this.btnDangNhap.UseVisualStyleBackColor = true;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(152, 57);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '*';
            this.txtMatKhau.Size = new System.Drawing.Size(330, 30);
            this.txtMatKhau.TabIndex = 2;
            // 
            // txtDangNhap
            // 
            this.txtDangNhap.Location = new System.Drawing.Point(152, 19);
            this.txtDangNhap.Name = "txtDangNhap";
            this.txtDangNhap.Size = new System.Drawing.Size(330, 30);
            this.txtDangNhap.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(25, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(25, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Username:";
            // 
            // frmLoginAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 281);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmLoginAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLoginAdmin";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		// Token: 0x040001B8 RID: 440
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x040001B9 RID: 441
		private global::System.Windows.Forms.Label label1;

		// Token: 0x040001BA RID: 442
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x040001BB RID: 443
		private global::System.Windows.Forms.Button btnThoat;

		// Token: 0x040001BC RID: 444
		private global::System.Windows.Forms.Button btnDangNhap;

		// Token: 0x040001BD RID: 445
		private global::System.Windows.Forms.TextBox txtMatKhau;

		// Token: 0x040001BE RID: 446
		private global::System.Windows.Forms.TextBox txtDangNhap;

		// Token: 0x040001BF RID: 447
		private global::System.Windows.Forms.Label label3;

		// Token: 0x040001C0 RID: 448
		private global::System.Windows.Forms.Label label2;
	}
}
