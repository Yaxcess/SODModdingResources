using System;
using UnityEngine;

// Token: 0x02000DBD RID: 3517
public class KAAnim2D : KAMonoBase
{
	
	// Token: 0x0400563D RID: 22077
	public KAAnimInfo[] _Anims;

	// Token: 0x0400563E RID: 22078
	public int _StartUpIndex = -1;

	// Token: 0x0400563F RID: 22079
	private KAAnimInfo mCurrentAnimInfo;

	// Token: 0x04005640 RID: 22080
	private int mSpriteIndex;

	// Token: 0x04005641 RID: 22081
	private bool mPlaying;

	// Token: 0x04005642 RID: 22082
	private float mLastTime;

	// Token: 0x04005643 RID: 22083
	private float mNextDuration;

	// Token: 0x04005644 RID: 22084
	private int mLoopCount;

	// Token: 0x04005645 RID: 22085
	private KAWidget mWidget;
}
