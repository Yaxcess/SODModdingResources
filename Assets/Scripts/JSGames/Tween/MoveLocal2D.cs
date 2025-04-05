using System;
using UnityEngine;

namespace JSGames.Tween
{
	// Token: 0x02001B0B RID: 6923
	public class MoveLocal2D : TweenerV2
	{
		// Token: 0x0600A314 RID: 41748 RVA: 0x00065AC3 File Offset: 0x00063CC3
		public MoveLocal2D(GameObject tweenObject, Vector2 from, Vector2 to) : base(tweenObject, from, to)
		{
		}

		// Token: 0x0600A315 RID: 41749 RVA: 0x00065AE5 File Offset: 0x00063CE5
		protected override void DoAnim(float val)
		{
			base.pTweenObject.transform.SetLocalPosition(base.CustomLerp(this.from, this.to, val));
		}

		// Token: 0x0600A316 RID: 41750 RVA: 0x00065B0A File Offset: 0x00063D0A
		protected override void DoAnimReverse(float val)
		{
			base.pTweenObject.transform.SetLocalPosition(base.CustomLerp(this.to, this.from, val));
		}
	}
}
