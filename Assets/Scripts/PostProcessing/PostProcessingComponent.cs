using System;

namespace UnityEngine.PostProcessing
{
	// Token: 0x02001BFF RID: 7167
	public abstract class PostProcessingComponent<T> : PostProcessingComponentBase where T : PostProcessingModel
	{
		// Token: 0x1700114A RID: 4426
		// (get) Token: 0x0600A83E RID: 43070 RVA: 0x00069316 File Offset: 0x00067516
		// (set) Token: 0x0600A83F RID: 43071 RVA: 0x0006931E File Offset: 0x0006751E
		public T model { get; internal set; }

		// Token: 0x0600A840 RID: 43072 RVA: 0x00069327 File Offset: 0x00067527
		public virtual void Init(PostProcessingContext pcontext, T pmodel)
		{
			this.context = pcontext;
			this.model = pmodel;
		}

		// Token: 0x0600A841 RID: 43073 RVA: 0x00069337 File Offset: 0x00067537
		public override PostProcessingModel GetModel()
		{
			return this.model;
		}
	}
}
