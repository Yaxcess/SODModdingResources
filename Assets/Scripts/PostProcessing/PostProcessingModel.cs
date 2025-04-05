using System;

namespace UnityEngine.PostProcessing
{
	// Token: 0x02001C03 RID: 7171
	[Serializable]
	public abstract class PostProcessingModel
	{
		// Token: 0x17001151 RID: 4433
		// (get) Token: 0x0600A853 RID: 43091 RVA: 0x000693D8 File Offset: 0x000675D8
		// (set) Token: 0x0600A854 RID: 43092 RVA: 0x000693E0 File Offset: 0x000675E0
		public bool enabled
		{
			get
			{
				return this.m_Enabled;
			}
			set
			{
				this.m_Enabled = value;
				if (value)
				{
					this.OnValidate();
				}
			}
		}

		// Token: 0x0600A855 RID: 43093
		public abstract void Reset();

		// Token: 0x0600A856 RID: 43094 RVA: 0x00006173 File Offset: 0x00004373
		public virtual void OnValidate()
		{
		}

		// Token: 0x0400AC07 RID: 44039
		[SerializeField]
		[GetSet("enabled")]
		private bool m_Enabled;
	}
}
