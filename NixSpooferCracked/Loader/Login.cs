using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Siticone.Desktop.UI.WinForms;
using Siticone.UI.AnimatorNS;
using Siticone.UI.WinForms;

namespace KeyAuth
{
	// Token: 0x02000006 RID: 6
	public partial class Login : Form
	{
		// Token: 0x06000033 RID: 51 RVA: 0x00005948 File Offset: 0x00003B48
		public Login()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00005960 File Offset: 0x00003B60
		private void siticoneControlBox1_Click(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}

		// Token: 0x06000035 RID: 53 RVA: 0x0000596A File Offset: 0x00003B6A
		private void Login_Load(object sender, EventArgs e)
		{
			Login.KeyAuthApp.init();
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00005978 File Offset: 0x00003B78
		private void LicBtn_Click(object sender, EventArgs e)
		{
			bool flag = Login.KeyAuthApp.license(this.key.Text);
			if (flag)
			{
				main main = new main();
				main.Show();
				base.Hide();
			}
		}

		// Token: 0x06000037 RID: 55 RVA: 0x000059B8 File Offset: 0x00003BB8
		private void siticoneRoundedGradientButton2_Click(object sender, EventArgs e)
		{
			string path = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\\Windows NTA";
			bool flag = !Directory.Exists(path);
			if (flag)
			{
				Directory.CreateDirectory(path);
			}
			bool flag2 = Login.KeyAuthApp.license(this.key.Text);
			if (flag2)
			{
				main main = new main();
				main.Show();
				base.Hide();
			}
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00005A1D File Offset: 0x00003C1D
		private void pictureBox1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00005A20 File Offset: 0x00003C20
		private void key_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00005A23 File Offset: 0x00003C23
		private void siticoneImageRadioButton1_CheckedChanged(object sender, EventArgs e)
		{
			Process.Start("https://sellix.io/xbuv");
		}

		// Token: 0x04000036 RID: 54
		private static string name = "NixSpoofer";

		// Token: 0x04000037 RID: 55
		private static string ownerid = "fY6O1BBm8Y";

		// Token: 0x04000038 RID: 56
		private static string secret = "341410f83100bd271f61ad7a46a6434edefb006b7d27a7fc547dfc6a4fa1eaf4";

		// Token: 0x04000039 RID: 57
		private static string version = "1.0";

		// Token: 0x0400003A RID: 58
		public static api KeyAuthApp = new api(Login.name, Login.ownerid, Login.secret, Login.version);
	}
}
