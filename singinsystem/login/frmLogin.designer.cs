namespace singinsystem.Login
{
    // Token: 0x0200001C RID: 28
    public partial class frmLogin : global::System.Windows.Forms.Form
    {
        // Token: 0x060000CB RID: 203 RVA: 0x0001A054 File Offset: 0x00018254
        protected override void Dispose(bool disposing)
        {
            bool flag = disposing && this.components != null;
            if (flag)
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        // Token: 0x060000CC RID: 204 RVA: 0x0001A08C File Offset: 0x0001828C
        private void InitializeComponent()
        {
            this.label1 = new global::System.Windows.Forms.Label();
            this.panel1 = new global::System.Windows.Forms.Panel();
            this.btnThoat = new global::System.Windows.Forms.Button();
            this.btnDangNhap = new global::System.Windows.Forms.Button();
            this.txtMatKhau = new global::System.Windows.Forms.TextBox();
            this.txtDangNhap = new global::System.Windows.Forms.TextBox();
            this.label3 = new global::System.Windows.Forms.Label();
            this.label2 = new global::System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            base.SuspendLayout();
            this.label1.AutoSize = true;
            this.label1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 20f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
            this.label1.Location = new global::System.Drawing.Point(257, 24);
            this.label1.Name = "label1";
            this.label1.Size = new global::System.Drawing.Size(87, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "登录";
            this.panel1.BackColor = global::System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.btnThoat);
            this.panel1.Controls.Add(this.btnDangNhap);
            this.panel1.Controls.Add(this.txtMatKhau);
            this.panel1.Controls.Add(this.txtDangNhap);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new global::System.Drawing.Point(31, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new global::System.Drawing.Size(524, 164);
            this.panel1.TabIndex = 1;
            this.btnThoat.Location = new global::System.Drawing.Point(309, 112);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new global::System.Drawing.Size(117, 34);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "取消";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new global::System.EventHandler(this.btnThoat_Click);
            this.btnDangNhap.Location = new global::System.Drawing.Point(168, 112);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new global::System.Drawing.Size(117, 34);
            this.btnDangNhap.TabIndex = 3;
            this.btnDangNhap.Text = "登录";
            this.btnDangNhap.UseVisualStyleBackColor = true;
            this.btnDangNhap.Click += new global::System.EventHandler(this.btnDangNhap_Click);
            this.txtMatKhau.Location = new global::System.Drawing.Point(152, 57);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '*';
            this.txtMatKhau.Size = new global::System.Drawing.Size(330, 30);
            this.txtMatKhau.TabIndex = 2;
            this.txtDangNhap.Location = new global::System.Drawing.Point(152, 19);
            this.txtDangNhap.Name = "txtDangNhap";
            this.txtDangNhap.Size = new global::System.Drawing.Size(330, 30);
            this.txtDangNhap.TabIndex = 1;
            this.label3.AutoSize = true;
            this.label3.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new global::System.Drawing.Point(25, 60);
            this.label3.Name = "label3";
            this.label3.Size = new global::System.Drawing.Size(58, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "密码:";
            this.label2.AutoSize = true;
            this.label2.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new global::System.Drawing.Point(25, 20);
            this.label2.Name = "label2";
            this.label2.Size = new global::System.Drawing.Size(58, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "账号:";
            base.AutoScaleDimensions = new global::System.Drawing.SizeF(12f, 25f);
            base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
            base.ClientSize = new global::System.Drawing.Size(594, 281);
            base.Controls.Add(this.panel1);
            base.Controls.Add(this.label1);
            this.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
            base.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
            base.Name = "frmLogin";
            base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLogin";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        // Token: 0x040001C1 RID: 449
        private global::System.ComponentModel.IContainer components = null;

        // Token: 0x040001C2 RID: 450
        private global::System.Windows.Forms.Label label1;

        // Token: 0x040001C3 RID: 451
        private global::System.Windows.Forms.Panel panel1;

        // Token: 0x040001C4 RID: 452
        private global::System.Windows.Forms.Button btnThoat;

        // Token: 0x040001C5 RID: 453
        private global::System.Windows.Forms.Button btnDangNhap;

        // Token: 0x040001C6 RID: 454
        private global::System.Windows.Forms.TextBox txtMatKhau;

        // Token: 0x040001C7 RID: 455
        private global::System.Windows.Forms.TextBox txtDangNhap;

        // Token: 0x040001C8 RID: 456
        private global::System.Windows.Forms.Label label3;

        // Token: 0x040001C9 RID: 457
        private global::System.Windows.Forms.Label label2;
    }
}
