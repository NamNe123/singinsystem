using System;
using System.Drawing;
using System.Windows.Forms;

namespace singinsystem
{
	// Token: 0x02000004 RID: 4
	public static class CustomMessageBox
	{
		// Token: 0x06000003 RID: 3 RVA: 0x00002174 File Offset: 0x00000374
		public static void Show(string message, string title, MessageBoxButtons buttons, MessageBoxIcon icon)
		{
			Form form = new Form();
			Label label = new Label();
			Button button = new Button();
			form.BackColor = Color.Red;
			form.Text = title;
			label.Text = message;
			label.Font = new Font("Microsoft Yahei", 24f, FontStyle.Bold);
			label.ForeColor = Color.White;
			label.Dock = DockStyle.Fill;
			label.TextAlign = ContentAlignment.MiddleCenter;
			button.Text = "OK";
			button.DialogResult = DialogResult.OK;
			button.Dock = DockStyle.Bottom;
			button.BackColor = Color.Green;
			button.Font = new Font("Microsoft Yahei", 16f, FontStyle.Bold);
			button.Size = new Size(40, 40);
			form.StartPosition = FormStartPosition.CenterScreen;
			form.FormBorderStyle = FormBorderStyle.FixedDialog;
			form.Controls.AddRange(new Control[]
			{
				label,
				button
			});
			form.ClientSize = new Size(Math.Max(400, label.Width + 10), label.Height + 10);
			form.ShowDialog();
		}
	}
}
