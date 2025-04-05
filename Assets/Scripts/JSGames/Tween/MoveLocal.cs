using System;
using UnityEngine;

namespace JSGames.Tween
{
	// Token: 0x02001B06 RID: 6918
	public class MoveLocal : TweenerV3
	{
		// Token: 0x0600A304 RID: 41732 RVA: 0x00065979 File Offset: 0x00063B79
		public MoveLocal(GameObject tweenObject, Vector3 from, Vector3 to) : base(tweenObject, from, to)
		{
		}

		// Token: 0x0600A305 RID: 41733 RVA: 0x0006599B File Offset: 0x00063B9B
		protected override void DoAnim(float val)
		{
			base.pTweenObject.transform.SetLocalPosition(base.CustomLerp(this.from, this.to, val));
		}

		// Token: 0x0600A306 RID: 41734 RVA: 0x000659C0 File Offset: 0x00063BC0
		protected override void DoAnimReverse(float val)
		{
			base.pTweenObject.transform.SetLocalPosition(base.CustomLerp(this.to, this.from, val));
		}
	}
}
