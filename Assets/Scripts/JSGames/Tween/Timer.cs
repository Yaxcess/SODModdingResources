using System;
using UnityEngine;

namespace JSGames.Tween
{
	// Token: 0x02001B15 RID: 6933
	public class Timer : Tweener
	{
		// Token: 0x0600A333 RID: 41779 RVA: 0x00396DA8 File Offset: 0x00394FA8
		public Timer()
		{
			GameObject pTweenObject = new GameObject("Timer");
			base.pTweenObject = pTweenObject;
		}

		// Token: 0x0600A334 RID: 41780 RVA: 0x00065D95 File Offset: 0x00063F95
		protected override void DoAnim(float val)
		{
			if (val >= 1f)
			{
				UnityEngine.Object.Destroy(base.pTweenObject);
			}
		}

		// Token: 0x0600A335 RID: 41781 RVA: 0x0004E713 File Offset: 0x0004C913
		protected override void DoAnimReverse(float val)
		{
			throw new NotImplementedException();
		}
	}
}
