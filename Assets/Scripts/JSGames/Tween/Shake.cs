using System;
using UnityEngine;

namespace JSGames.Tween
{
	// Token: 0x02001B12 RID: 6930
	public class Shake : Tweener
	{
		// Token: 0x0600A32A RID: 41770 RVA: 0x00065CEB File Offset: 0x00063EEB
		public Shake(GameObject tweenObject, float shakeAmount)
		{
			base.pTweenObject = tweenObject;
			this.mOriginalPosition = base.pTweenObject.transform.localPosition;
			this.mShakeAmount = shakeAmount;
		}

		// Token: 0x0600A32B RID: 41771 RVA: 0x00396CF4 File Offset: 0x00394EF4
		protected override void DoAnim(float val)
		{
			base.pTweenObject.transform.SetLocalPosition(this.mOriginalPosition + UnityEngine.Random.insideUnitSphere * this.mShakeAmount);
			if (val == 1f)
			{
				base.pTweenObject.transform.localPosition = this.mOriginalPosition;
			}
		}

		// Token: 0x0600A32C RID: 41772 RVA: 0x0004E713 File Offset: 0x0004C913
		protected override void DoAnimReverse(float val)
		{
			throw new NotImplementedException();
		}

		// Token: 0x0400A70D RID: 42765
		private Vector3 mOriginalPosition;

		// Token: 0x0400A70E RID: 42766
		private float mShakeAmount;
	}
}
