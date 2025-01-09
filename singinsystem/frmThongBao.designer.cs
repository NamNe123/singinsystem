namespace singinsystem
{
	// Token: 0x02000005 RID: 5
	public partial class frmThongBao : global::System.Windows.Forms.Form
	{
		// Token: 0x06000005 RID: 5 RVA: 0x000022A4 File Offset: 0x000004A4
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000006 RID: 6 RVA: 0x000022DC File Offset: 0x000004DC
		private void InitializeComponent()
		{
			this.tableLayoutPanel1 = new global::System.Windows.Forms.TableLayoutPanel();
			this.label1 = new global::System.Windows.Forms.Label();
			this.tableLayoutPanel2 = new global::System.Windows.Forms.TableLayoutPanel();
			this.button1 = new global::System.Windows.Forms.Button();
			this.tableLayoutPanel1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			base.SuspendLayout();
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 50f));
			this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
			this.tableLayoutPanel1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new global::System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 81.81818f));
			this.tableLayoutPanel1.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 18.18182f));
			this.tableLayoutPanel1.Size = new global::System.Drawing.Size(621, 242);
			this.tableLayoutPanel1.TabIndex = 0;
			this.label1.AutoSize = true;
			this.label1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.label1.Font = new global::System.Drawing.Font("Microsoft YaHei", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.Location = new global::System.Drawing.Point(3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(615, 197);
			this.label1.TabIndex = 0;
			this.label1.Text = "label1";
			this.label1.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.tableLayoutPanel2.ColumnCount = 2;
			this.tableLayoutPanel2.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 33.17073f));
			this.tableLayoutPanel2.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 66.82927f));
			this.tableLayoutPanel2.Controls.Add(this.button1, 1, 0);
			this.tableLayoutPanel2.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new global::System.Drawing.Point(3, 200);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 1;
			this.tableLayoutPanel2.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 50f));
			this.tableLayoutPanel2.Size = new global::System.Drawing.Size(615, 39);
			this.tableLayoutPanel2.TabIndex = 1;
			this.button1.Location = new global::System.Drawing.Point(206, 3);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(108, 32);
			this.button1.TabIndex = 2;
			this.button1.Text = "Ok";
			this.button1.UseVisualStyleBackColor = true;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(8f, 16f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(621, 242);
			base.Controls.Add(this.tableLayoutPanel1);
			base.Name = "frmThongBao";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "通知";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.tableLayoutPanel2.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x04000003 RID: 3
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000004 RID: 4
		private global::System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

		// Token: 0x04000005 RID: 5
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000006 RID: 6
		private global::System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;

		// Token: 0x04000007 RID: 7
		private global::System.Windows.Forms.Button button1;
	}
}
