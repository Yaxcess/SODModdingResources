using System;

namespace UnityEngine.PostProcessing
{
	// Token: 0x02001B96 RID: 7062
	public sealed class GetSetAttribute : PropertyAttribute
	{
		// Token: 0x0600A71E RID: 42782 RVA: 0x00068746 File Offset: 0x00066946
		public GetSetAttribute(string name)
		{
			this.name = name;
		}

		// Token: 0x0400AA1E RID: 43550
		public readonly string name;

		// Token: 0x0400AA1F RID: 43551
		public bool dirty;
	}
}
