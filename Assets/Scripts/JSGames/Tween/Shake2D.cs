using System;
using UnityEngine;

namespace JSGames.Tween
{
	// Token: 0x02001B13 RID: 6931
	public class Shake2D : Tweener
	{
		// Token: 0x0600A32D RID: 41773 RVA: 0x00065D17 File Offset: 0x00063F17
		public Shake2D(GameObject tweenObject, float shakeAmount)
		{
			base.pTweenObject = tweenObject;
			this.mOriginalPosition = base.pTweenObject.transform.localPosition;
			this.mShakeAmount = shakeAmount;
		}

		// Token: 0x0600A32E RID: 41774 RVA: 0x00396D4C File Offset: 0x00394F4C
		protected override void DoAnim(float val)
		{
			base.pTweenObject.transform.SetLocalPosition(this.mOriginalPosition + UnityEngine.Random.insideUnitCircle * this.mShakeAmount);
			if (val == 1f)
			{
				base.pTweenObject.transform.localPosition = this.mOriginalPosition;
			}
		}

		// Token: 0x0600A32F RID: 41775 RVA: 0x0004E713 File Offset: 0x0004C913
		protected override void DoAnimReverse(float val)
		{
			throw new NotImplementedException();
		}

		// Token: 0x0400A70F RID: 42767
		private Vector2 mOriginalPosition;

		// Token: 0x0400A710 RID: 42768
		private float mShakeAmount;
	}
}
