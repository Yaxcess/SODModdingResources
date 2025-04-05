using System;
using UnityEngine;

namespace JSGames.Tween
{
	// Token: 0x02001B03 RID: 6915
	public abstract class TweenerV2 : Tweener
	{
		// Token: 0x0600A2FE RID: 41726 RVA: 0x0006593F File Offset: 0x00063B3F
		public TweenerV2(GameObject tweenObject, Vector2 from, Vector2 to)
		{
			base.pTweenObject = tweenObject;
			this.from = from;
			this.to = to;
		}

		// Token: 0x0400A701 RID: 42753
		protected Vector2 from;

		// Token: 0x0400A702 RID: 42754
		protected Vector2 to;
	}
}
