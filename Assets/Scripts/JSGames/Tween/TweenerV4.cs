using System;
using UnityEngine;

namespace JSGames.Tween
{
	// Token: 0x02001B01 RID: 6913
	public abstract class TweenerV4 : Tweener
	{
		// Token: 0x0600A2FC RID: 41724 RVA: 0x00065905 File Offset: 0x00063B05
		public TweenerV4(GameObject tweenObject, Vector4 from, Vector4 to)
		{
			base.pTweenObject = tweenObject;
			this.from = from;
			this.to = to;
		}

		// Token: 0x0400A6FD RID: 42749
		protected Vector4 from;

		// Token: 0x0400A6FE RID: 42750
		protected Vector4 to;
	}
}
