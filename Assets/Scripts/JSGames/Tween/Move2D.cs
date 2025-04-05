using System;
using UnityEngine;

namespace JSGames.Tween
{
	// Token: 0x02001B0A RID: 6922
	public class Move2D : TweenerV2
	{
		// Token: 0x0600A310 RID: 41744 RVA: 0x00065AC3 File Offset: 0x00063CC3
		public Move2D(GameObject tweenObject, Vector2 from, Vector2 to) : base(tweenObject, from, to)
		{
		}

		// Token: 0x0600A311 RID: 41745 RVA: 0x00065ACE File Offset: 0x00063CCE
		public Move2D(RectTransform rectTransform, Vector2 from, Vector2 to) : base(rectTransform.gameObject, from, to)
		{
			this.mRectTransform = rectTransform;
		}

		// Token: 0x0600A312 RID: 41746 RVA: 0x00396BD0 File Offset: 0x00394DD0
		protected override void DoAnim(float val)
		{
			if (this.mRectTransform != null)
			{
				this.mRectTransform.SetPosition(base.CustomLerp(this.from, this.to, val));
				return;
			}
			base.pTweenObject.transform.SetPosition(base.CustomLerp(this.from, this.to, val));
		}

		// Token: 0x0600A313 RID: 41747 RVA: 0x00396C30 File Offset: 0x00394E30
		protected override void DoAnimReverse(float val)
		{
			if (this.mRectTransform != null)
			{
				this.mRectTransform.SetPosition(base.CustomLerp(this.to, this.from, val));
				return;
			}
			base.pTweenObject.transform.SetPosition(base.CustomLerp(this.to, this.from, val));
		}

		// Token: 0x0400A706 RID: 42758
		private RectTransform mRectTransform;
	}
}
