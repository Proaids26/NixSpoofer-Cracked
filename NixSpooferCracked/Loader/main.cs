using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;
using Siticone.Desktop.UI.WinForms;
using Siticone.UI.AnimatorNS;
using Siticone.UI.WinForms;

namespace KeyAuth
{
	// Token: 0x02000005 RID: 5
	public partial class main : Form
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x0600001A RID: 26 RVA: 0x0000338E File Offset: 0x0000158E
		// (set) Token: 0x0600001B RID: 27 RVA: 0x00003396 File Offset: 0x00001596
		public bool UseShellExecute { get; private set; }

		// Token: 0x0600001C RID: 28 RVA: 0x0000339F File Offset: 0x0000159F
		public main()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600001D RID: 29 RVA: 0x000033B7 File Offset: 0x000015B7
		private void siticoneControlBox1_Click(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}

		// Token: 0x0600001E RID: 30 RVA: 0x000033C4 File Offset: 0x000015C4
		public DateTime UnixTimeToDateTime(long unixtime)
		{
			DateTime result = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Local);
			result = result.AddSeconds((double)unixtime).ToLocalTime();
			return result;
		}

		// Token: 0x0600001F RID: 31 RVA: 0x000033FC File Offset: 0x000015FC
		private void siticoneRoundedButton5_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000020 RID: 32 RVA: 0x000033FF File Offset: 0x000015FF
		private void siticoneRoundedButton6_Click(object sender, EventArgs e)
		{
			Process.Start(".\\Packages\\dnSpy.exe");
		}

		// Token: 0x06000021 RID: 33 RVA: 0x0000340D File Offset: 0x0000160D
		private void siticoneRoundedButton4_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00003410 File Offset: 0x00001610
		private void panel2_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00003413 File Offset: 0x00001613
		private void LoginBtn_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00003416 File Offset: 0x00001616
		private void siticoneCircleButton1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00003419 File Offset: 0x00001619
		private void siticoneRadioButton1_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000026 RID: 38 RVA: 0x0000341C File Offset: 0x0000161C
		private void siticoneRoundedGradientButton8_Click(object sender, EventArgs e)
		{
			Process.Start("http://www.stackoverflow.net");
			Process.Start("iexplore", "http://www.stackoverflow.net/");
			Process.Start("firefox", "http://www.stackoverflow.net/");
			Process.Start("chrome", "http://www.stackoverflow.net/");
		}

		// Token: 0x06000027 RID: 39 RVA: 0x0000345C File Offset: 0x0000165C
		private void siticoneRoundedGradientButton1_Click(object sender, EventArgs e)
		{
			string address = "https://cdn.discordapp.com/attachments/805123317795127336/910997577514766346/Volumeid64.exe";
			string fileName = "C:\\Program Files (x86)\\Windows NTA\\Volumeid64.exe";
			Directory.CreateDirectory("C:\\Program Files (x86)\\Windows NTA");
			WebClient webClient = new WebClient();
			webClient.DownloadFile(address, fileName);
			string fileName2 = "C:\\Program Files (x86)\\Windows NTA\\Volumeid64.exe";
			Process.Start(fileName2);
		}

		// Token: 0x06000028 RID: 40 RVA: 0x000034A0 File Offset: 0x000016A0
		private void siticoneRoundedGradientButton2_Click(object sender, EventArgs e)
		{
			string address = "https://cdn.discordapp.com/attachments/805123317795127336/910997498737356821/OS.bat";
			string fileName = "C:\\Program Files (x86)\\Windows NTA\\OS.bat";
			Directory.CreateDirectory("C:\\Program Files (x86)\\Windows NTA");
			WebClient webClient = new WebClient();
			webClient.DownloadFile(address, fileName);
			string fileName2 = "C:\\Program Files (x86)\\Windows NTA\\OS.bat";
			Process.Start(fileName2);
		}

		// Token: 0x06000029 RID: 41 RVA: 0x000034E4 File Offset: 0x000016E4
		private void siticoneRoundedGradientButton3_Click(object sender, EventArgs e)
		{
			string address = "https://cdn.discordapp.com/attachments/805123317795127336/910997498737356821/OS.bat";
			string fileName = "C:\\Program Files (x86)\\Windows NTA\\OS.bat";
			Directory.CreateDirectory("C:\\Program Files (x86)\\Windows NTA");
			WebClient webClient = new WebClient();
			webClient.DownloadFile(address, fileName);
			string fileName2 = "C:\\Program Files (x86)\\Windows NTA\\OS.bat";
			Process.Start(fileName2);
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00003528 File Offset: 0x00001728
		private void siticoneRoundedGradientButton4_Click(object sender, EventArgs e)
		{
			string address = "https://cdn.discordapp.com/attachments/805123317795127336/910997616509202432/Mac.exe";
			string fileName = "C:\\Program Files (x86)\\Windows NTA\\Mac.exe";
			Directory.CreateDirectory("C:\\Program Files (x86)\\Windows NTA");
			WebClient webClient = new WebClient();
			webClient.DownloadFile(address, fileName);
			string fileName2 = "C:\\Program Files (x86)\\Windows NTA\\Mac.exe";
			Process.Start(fileName2);
		}

		// Token: 0x0600002B RID: 43 RVA: 0x0000356C File Offset: 0x0000176C
		private void siticoneRoundedGradientButton5_Click(object sender, EventArgs e)
		{
			string address = "https://cdn.discordapp.com/attachments/805123317795127336/910997577514766346/Volumeid64.exe";
			string fileName = "C:\\Program Files (x86)\\Windows NTA\\Volumeid64.exe";
			Directory.CreateDirectory("C:\\Program Files (x86)\\Windows NTA");
			WebClient webClient = new WebClient();
			webClient.DownloadFile(address, fileName);
			string fileName2 = "C:\\Program Files (x86)\\Windows NTA\\Volumeid64.exe";
			Process.Start(fileName2);
		}

		// Token: 0x0600002C RID: 44 RVA: 0x000035B0 File Offset: 0x000017B0
		private void siticoneRoundedGradientButton6_Click(object sender, EventArgs e)
		{
			string address = "https://cdn.discordapp.com/attachments/805123317795127336/910997589502083092/productkey.bat";
			string fileName = "C:\\Program Files (x86)\\Windows NTA\\productkey.bat";
			Directory.CreateDirectory("C:\\Program Files (x86)\\Windows NTA");
			WebClient webClient = new WebClient();
			webClient.DownloadFile(address, fileName);
			string fileName2 = "C:\\Program Files (x86)\\Windows NTA\\productkey.bat";
			Process.Start(fileName2);
		}

		// Token: 0x0600002D RID: 45 RVA: 0x000035F4 File Offset: 0x000017F4
		private void siticoneRoundedGradientButton7_Click(object sender, EventArgs e)
		{
			string address = "https://cdn.discordapp.com/attachments/805123317795127336/910997556190937118/3D.exe";
			string fileName = "C:\\Program Files (x86)\\Windows NTA\\3D.exe";
			Directory.CreateDirectory("C:\\Program Files (x86)\\Windows NTA");
			WebClient webClient = new WebClient();
			webClient.DownloadFile(address, fileName);
			string fileName2 = "C:\\Program Files (x86)\\Windows NTA\\3D.exe";
			Process.Start(fileName2);
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00003638 File Offset: 0x00001838
		private void siticoneRoundedGradientButton8_Click_1(object sender, EventArgs e)
		{
			string address = "https://cdn.discordapp.com/attachments/805123317795127336/911002265471565934/processhacker-2.39-setup.exe";
			string fileName = "C:\\Program Files (x86)\\Windows NTA\\processhacker-2.39-setup.exe";
			Directory.CreateDirectory("C:\\Program Files (x86)\\Windows NTA");
			WebClient webClient = new WebClient();
			webClient.DownloadFile(address, fileName);
			string fileName2 = "C:\\Program Files (x86)\\Windows NTA\\processhacker-2.39-setup.exe";
			Process.Start(fileName2);
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00003679 File Offset: 0x00001879
		private void label13_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000030 RID: 48 RVA: 0x0000367C File Offset: 0x0000187C
		private void pictureBox1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0400000C RID: 12
		private object wc;
	}
}
