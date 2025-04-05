using System;

namespace UnityEngine.PostProcessing
{
	// Token: 0x02001C01 RID: 7169
	public abstract class PostProcessingComponentRenderTexture<T> : PostProcessingComponent<T> where T : PostProcessingModel
	{
		// Token: 0x0600A847 RID: 43079 RVA: 0x00006173 File Offset: 0x00004373
		public virtual void Prepare(Material material)
		{
		}
	}
}
