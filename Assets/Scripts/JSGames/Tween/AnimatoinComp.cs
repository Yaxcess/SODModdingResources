using System;
using UnityEngine;

namespace JSGames.Tween
{
	// Token: 0x02001B14 RID: 6932
	public class AnimatoinComp : Tweener
	{
		// Token: 0x0600A330 RID: 41776 RVA: 0x00065D48 File Offset: 0x00063F48
		public AnimatoinComp(GameObject tweenObject, Animation anim, string animName)
		{
			base.pTweenObject = tweenObject;
			this.mAnimName = animName;
			this.mAnim = anim;
			this.mAnim.Play(this.mAnimName);
		}

		// Token: 0x0600A331 RID: 41777 RVA: 0x00065D77 File Offset: 0x00063F77
		protected override void DoAnim(float val)
		{
			this.mValue = this.mAnim[this.mAnimName].normalizedTime;
		}

		// Token: 0x0600A332 RID: 41778 RVA: 0x0004E713 File Offset: 0x0004C913
		protected override void DoAnimReverse(float val)
		{
			throw new NotImplementedException();
		}

		// Token: 0x0400A711 RID: 42769
		private Animation mAnim;

		// Token: 0x0400A712 RID: 42770
		private Animator mAnimator;

		// Token: 0x0400A713 RID: 42771
		private string mAnimName;
	}
}
