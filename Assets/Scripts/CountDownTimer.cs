using System;
using UnityEngine;

// Token: 0x02001130 RID: 4400
public class CountDownTimer
{
	

	// Token: 0x04006AAE RID: 27310
	private double mTotalTime;

	// Token: 0x04006AAF RID: 27311
	private DateTime mEndTime = DateTime.MinValue;

	// Token: 0x04006AB0 RID: 27312
	private TimeSpan mTimeRemain = TimeSpan.MinValue;

	// Token: 0x04006AB1 RID: 27313
	private float mPercentRemain;

	// Token: 0x04006AB2 RID: 27314
	private bool mIsTimerRunning;

	// Token: 0x04006AB3 RID: 27315
	private bool mIsUINeedUpdate;

	// Token: 0x04006AB4 RID: 27316
	private CountDownEndCallBack mCallback;

	// Token: 0x04006AB5 RID: 27317
	private float mTickInterval;

	// Token: 0x04006AB6 RID: 27318
	private float mTimeCounter;
}
