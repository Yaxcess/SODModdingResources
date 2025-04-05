using System;
using UnityEngine;

namespace JSGames.Tween
{
	// Token: 0x02001B02 RID: 6914
	public abstract class TweenerV3 : Tweener
	{
		// Token: 0x0600A2FD RID: 41725 RVA: 0x00065922 File Offset: 0x00063B22
		public TweenerV3(GameObject tweenObject, Vector3 from, Vector3 to)
		{
			base.pTweenObject = tweenObject;
			this.from = from;
			this.to = to;
		}

		// Token: 0x0400A6FF RID: 42751
		protected Vector3 from;

		// Token: 0x0400A700 RID: 42752
		protected Vector3 to;
	}
}
