using System;

namespace UnityEngine.PostProcessing
{
	// Token: 0x02001B97 RID: 7063
	public sealed class MinAttribute : PropertyAttribute
	{
		// Token: 0x0600A71F RID: 42783 RVA: 0x00068755 File Offset: 0x00066955
		public MinAttribute(float min)
		{
			this.min = min;
		}

		// Token: 0x0400AA20 RID: 43552
		public readonly float min;
	}
}
