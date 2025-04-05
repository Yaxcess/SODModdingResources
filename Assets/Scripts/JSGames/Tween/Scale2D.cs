using System;
using UnityEngine;

namespace JSGames.Tween
{
	// Token: 0x02001B0C RID: 6924
	public class Scale2D : TweenerV2
	{
		// Token: 0x0600A317 RID: 41751 RVA: 0x00065AC3 File Offset: 0x00063CC3
		public Scale2D(GameObject tweenObject, Vector2 from, Vector2 to) : base(tweenObject, from, to)
		{
		}

		// Token: 0x0600A318 RID: 41752 RVA: 0x00065B2F File Offset: 0x00063D2F
		protected override void DoAnim(float val)
		{
			base.pTweenObject.transform.SetLocalScale(base.CustomLerp(this.from, this.to, val));
		}

		// Token: 0x0600A319 RID: 41753 RVA: 0x00065B54 File Offset: 0x00063D54
		protected override void DoAnimReverse(float val)
		{
			base.pTweenObject.transform.SetLocalScale(base.CustomLerp(this.to, this.from, val));
		}
	}
}
