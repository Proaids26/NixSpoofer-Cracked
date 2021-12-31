using System;
using System.Windows.Forms;

namespace KeyAuth
{
	// Token: 0x02000007 RID: 7
	internal static class Program
	{
		// Token: 0x0600003E RID: 62 RVA: 0x0000663F File Offset: 0x0000483F
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Login());
		}
	}
}
