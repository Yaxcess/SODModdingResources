using System;
using UnityEngine;

namespace JSGames.Tween
{
	// Token: 0x02001B0E RID: 6926
	public class Alpha : TweenerF
	{
		// Token: 0x0600A31D RID: 41757 RVA: 0x00065BCC File Offset: 0x00063DCC
		public Alpha(GameObject tweenObject, Renderer renderer, float from, float to) : base(tweenObject, from, to)
		{
			this.mRenderer = renderer;
		}

		// Token: 0x0600A31E RID: 41758 RVA: 0x00065BDF File Offset: 0x00063DDF
		protected override void DoAnim(float val)
		{
			this.mRenderer.SetAlpha(base.CustomLerp(this.from, this.to, val));
		}

		// Token: 0x0600A31F RID: 41759 RVA: 0x00065BFF File Offset: 0x00063DFF
		protected override void DoAnimReverse(float val)
		{
			this.mRenderer.SetAlpha(base.CustomLerp(this.to, this.from, val));
		}

		// Token: 0x0400A708 RID: 42760
		private Renderer mRenderer;
	}
}
