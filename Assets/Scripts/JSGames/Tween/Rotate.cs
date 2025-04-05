using System;
using UnityEngine;

namespace JSGames.Tween
{
	// Token: 0x02001B08 RID: 6920
	public class Rotate : TweenerV3
	{
		// Token: 0x0600A30A RID: 41738 RVA: 0x00065979 File Offset: 0x00063B79
		public Rotate(GameObject tweenObject, Vector3 from, Vector3 to) : base(tweenObject, from, to)
		{
		}

		// Token: 0x0600A30B RID: 41739 RVA: 0x00065A2F File Offset: 0x00063C2F
		protected override void DoAnim(float val)
		{
			base.pTweenObject.transform.SetRotation(base.CustomLerp(this.from, this.to, val));
		}

		// Token: 0x0600A30C RID: 41740 RVA: 0x00065A54 File Offset: 0x00063C54
		protected override void DoAnimReverse(float val)
		{
			base.pTweenObject.transform.SetRotation(base.CustomLerp(this.to, this.from, val));
		}
	}
}
