using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace KeyAuth.Properties
{
	// Token: 0x0200000B RID: 11
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
	[DebuggerNonUserCode]
	[CompilerGenerated]
	internal class Resources
	{
		// Token: 0x06000042 RID: 66 RVA: 0x00006675 File Offset: 0x00004875
		internal Resources()
		{
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000043 RID: 67 RVA: 0x00006680 File Offset: 0x00004880
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				bool flag = Resources.resourceMan == null;
				if (flag)
				{
					ResourceManager resourceManager = new ResourceManager("KeyAuth.Properties.Resources", typeof(Resources).Assembly);
					Resources.resourceMan = resourceManager;
				}
				return Resources.resourceMan;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000044 RID: 68 RVA: 0x000066C8 File Offset: 0x000048C8
		// (set) Token: 0x06000045 RID: 69 RVA: 0x000066DF File Offset: 0x000048DF
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo Culture
		{
			get
			{
				return Resources.resourceCulture;
			}
			set
			{
				Resources.resourceCulture = value;
			}
		}

		// Token: 0x04000047 RID: 71
		private static ResourceManager resourceMan;

		// Token: 0x04000048 RID: 72
		private static CultureInfo resourceCulture;
	}
}
