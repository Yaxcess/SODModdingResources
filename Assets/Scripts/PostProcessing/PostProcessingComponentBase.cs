using System;

namespace UnityEngine.PostProcessing
{
	// Token: 0x02001BFE RID: 7166
	public abstract class PostProcessingComponentBase
	{
		// Token: 0x0600A838 RID: 43064 RVA: 0x0000A66D File Offset: 0x0000886D
		public virtual DepthTextureMode GetCameraFlags()
		{
			return DepthTextureMode.None;
		}

		// Token: 0x17001149 RID: 4425
		// (get) Token: 0x0600A839 RID: 43065
		public abstract bool active { get; }

		// Token: 0x0600A83A RID: 43066 RVA: 0x00006173 File Offset: 0x00004373
		public virtual void OnEnable()
		{
		}

		// Token: 0x0600A83B RID: 43067 RVA: 0x00006173 File Offset: 0x00004373
		public virtual void OnDisable()
		{
		}

		// Token: 0x0600A83C RID: 43068
		public abstract PostProcessingModel GetModel();

		// Token: 0x0400AC00 RID: 44032
		public PostProcessingContext context;
	}
}
