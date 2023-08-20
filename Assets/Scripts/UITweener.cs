using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x02000F78 RID: 3960
public abstract class UITweener : KAMonoBase
{
	

	// Token: 0x040060FE RID: 24830
	public static UITweener current;

	// Token: 0x040060FF RID: 24831
	[HideInInspector]
	public UITweener.Method method;

	// Token: 0x04006100 RID: 24832
	[HideInInspector]
	public UITweener.Style style;

	// Token: 0x04006101 RID: 24833
	[HideInInspector]
	public AnimationCurve animationCurve = new AnimationCurve(new Keyframe[]
	{
		new Keyframe(0f, 0f, 0f, 1f),
		new Keyframe(1f, 1f, 1f, 0f)
	});

	// Token: 0x04006102 RID: 24834
	[HideInInspector]
	public bool ignoreTimeScale = true;

	// Token: 0x04006103 RID: 24835
	[HideInInspector]
	public float delay;

	// Token: 0x04006104 RID: 24836
	[HideInInspector]
	public float duration = 1f;

	// Token: 0x04006105 RID: 24837
	[HideInInspector]
	public bool steeperCurves;

	// Token: 0x04006106 RID: 24838
	[HideInInspector]
	public int tweenGroup;

	// Token: 0x04006107 RID: 24839
	[Tooltip("By default, Update() will be used for tweening. Setting this to 'true' will make the tween happen in FixedUpdate() insted.")]
	public bool useFixedUpdate;

	// Token: 0x04006108 RID: 24840
	[HideInInspector]
	public List<EventDelegate> onFinished = new List<EventDelegate>();

	// Token: 0x04006109 RID: 24841
	[HideInInspector]
	public GameObject eventReceiver;

	// Token: 0x0400610A RID: 24842
	[HideInInspector]
	public string callWhenFinished;

	// Token: 0x0400610B RID: 24843
	private bool mStarted;

	// Token: 0x0400610C RID: 24844
	private float mStartTime;

	// Token: 0x0400610D RID: 24845
	private float mDuration;

	// Token: 0x0400610E RID: 24846
	private float mAmountPerDelta = 1000f;

	// Token: 0x0400610F RID: 24847
	private float mFactor;

	// Token: 0x04006110 RID: 24848
	private List<EventDelegate> mTemp;

	// Token: 0x02000F79 RID: 3961
	public enum Method
	{
		// Token: 0x04006112 RID: 24850
		Linear,
		// Token: 0x04006113 RID: 24851
		EaseIn,
		// Token: 0x04006114 RID: 24852
		EaseOut,
		// Token: 0x04006115 RID: 24853
		EaseInOut,
		// Token: 0x04006116 RID: 24854
		BounceIn,
		// Token: 0x04006117 RID: 24855
		BounceOut
	}

	// Token: 0x02000F7A RID: 3962
	public enum Style
	{
		// Token: 0x04006119 RID: 24857
		Once,
		// Token: 0x0400611A RID: 24858
		Loop,
		// Token: 0x0400611B RID: 24859
		PingPong
	}
}
