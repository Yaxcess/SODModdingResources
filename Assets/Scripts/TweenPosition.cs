using System;
using UnityEngine;

// Token: 0x02000F72 RID: 3954
[AddComponentMenu("NGUI/Tween/Tween Position")]
public class TweenPosition : UITweener
{
	// Token: 0x040060E1 RID: 24801
	public Vector3 from;

	// Token: 0x040060E2 RID: 24802
	public Vector3 to;

	// Token: 0x040060E3 RID: 24803
	[HideInInspector]
	public bool worldSpace;

	// Token: 0x040060E4 RID: 24804
	private Transform mTrans;

	// Token: 0x040060E5 RID: 24805
	private UIRect mRect;
}
