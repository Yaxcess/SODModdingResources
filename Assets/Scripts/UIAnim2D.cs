using System;
using UnityEngine;

namespace JSGames.UI
{
	// Token: 0x02001B29 RID: 6953
	public class UIAnim2D : KAMonoBase
	{

		// Token: 0x0400A793 RID: 42899
		public Action OnAnimationComplete;



		// Token: 0x0400A795 RID: 42901
		public int _StartUpIndex = -1;

		// Token: 0x0400A796 RID: 42902
		private bool mPlaying;

		// Token: 0x0400A797 RID: 42903
		private float mLastTime;

		// Token: 0x0400A798 RID: 42904
		private float mNextDuration;

		// Token: 0x0400A799 RID: 42905
		private int mLoopCount;

		// Token: 0x0400A79A RID: 42906
		private UIWidget mWidget;
	}
}
