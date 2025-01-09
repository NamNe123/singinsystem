using System;
using System.Drawing;
using System.Windows.Forms;

namespace singinsystem
{
	// Token: 0x02000003 RID: 3
	public static class CustomMessageBoxPhu
	{
		// Token: 0x06000002 RID: 2 RVA: 0x0000205C File Offset: 0x0000025C
		public static void Show(string message, string title, MessageBoxButtons buttons, MessageBoxIcon icon)
		{
			Form form = new Form();
			Label label = new Label();
			Button button = new Button();
			form.BackColor = Color.White;
			form.Text = title;
			label.Text = message;
			label.Font = new Font("Microsoft Yahei", 16f, FontStyle.Bold);
			label.ForeColor = Color.Black;
			label.Dock = DockStyle.Fill;
			label.TextAlign = ContentAlignment.MiddleCenter;
			button.Text = "OK";
			button.DialogResult = DialogResult.OK;
			button.Dock = DockStyle.Bottom;
			button.BackColor = Color.White;
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
