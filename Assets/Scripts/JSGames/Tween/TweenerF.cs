using System;
using UnityEngine;

namespace JSGames.Tween
{
	// Token: 0x02001B04 RID: 6916
	public abstract class TweenerF : Tweener
	{
		// Token: 0x0600A2FF RID: 41727 RVA: 0x0006595C File Offset: 0x00063B5C
		public TweenerF(GameObject tweenObject, float from, float to)
		{
			base.pTweenObject = tweenObject;
			this.from = from;
			this.to = to;
		}

		// Token: 0x0400A703 RID: 42755
		protected float from;

		// Token: 0x0400A704 RID: 42756
		protected float to;
	}
}
