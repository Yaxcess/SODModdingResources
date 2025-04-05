using System;
using UnityEngine;

namespace JSGames.Tween
{
	// Token: 0x02001B0D RID: 6925
	public class Colour : TweenerV4
	{
		// Token: 0x0600A31A RID: 41754 RVA: 0x00065B79 File Offset: 0x00063D79
		public Colour(GameObject tweenObject, Renderer renderer, Vector4 from, Vector4 to) : base(tweenObject, from, to)
		{
			this.mRenderer = renderer;
		}

		// Token: 0x0600A31B RID: 41755 RVA: 0x00065B8C File Offset: 0x00063D8C
		protected override void DoAnim(float val)
		{
			this.mRenderer.SetColor(base.CustomLerp(this.from, this.to, val));
		}

		// Token: 0x0600A31C RID: 41756 RVA: 0x00065BAC File Offset: 0x00063DAC
		protected override void DoAnimReverse(float val)
		{
			this.mRenderer.SetColor(base.CustomLerp(this.to, this.from, val));
		}

		// Token: 0x0400A707 RID: 42759
		private Renderer mRenderer;
	}
}
