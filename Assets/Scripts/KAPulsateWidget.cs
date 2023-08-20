using System;
using UnityEngine;

// Token: 0x02000DC4 RID: 3524
[RequireComponent(typeof(KAWidget))]
public class KAPulsateWidget : KAMonoBase
{
	

	// Token: 0x0400565F RID: 22111
	[SerializeField]
	private bool m_PlayOnVisible;

	// Token: 0x04005660 RID: 22112
	[SerializeField]
	private bool m_StopOnClick;

	// Token: 0x04005661 RID: 22113
	[SerializeField]
	private int m_PulseCount = -1;

	// Token: 0x04005662 RID: 22114
	private float mDeltaTime;

	// Token: 0x04005663 RID: 22115
	private float mWaitTime;

	// Token: 0x04005664 RID: 22116
	private int mLoopCount;

	// Token: 0x04005665 RID: 22117
	private bool mIsPlaying;

	// Token: 0x04005666 RID: 22118
	private KAWidget mWidget;
}
