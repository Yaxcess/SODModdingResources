using System;
using UnityEngine.Rendering;

namespace UnityEngine.PostProcessing
{
	// Token: 0x02001C00 RID: 7168
	public abstract class PostProcessingComponentCommandBuffer<T> : PostProcessingComponent<T> where T : PostProcessingModel
	{
		// Token: 0x0600A843 RID: 43075
		public abstract CameraEvent GetCameraEvent();

		// Token: 0x0600A844 RID: 43076
		public abstract string GetName();

		// Token: 0x0600A845 RID: 43077
		public abstract void PopulateCommandBuffer(CommandBuffer cb);
	}
}
