using System;

namespace UnityEngine.PostProcessing
{
	// Token: 0x02001B98 RID: 7064
	public sealed class TrackballAttribute : PropertyAttribute
	{
		// Token: 0x0600A720 RID: 42784 RVA: 0x00068764 File Offset: 0x00066964
		public TrackballAttribute(string method)
		{
			this.method = method;
		}

		// Token: 0x0400AA21 RID: 43553
		public readonly string method;
	}
}
