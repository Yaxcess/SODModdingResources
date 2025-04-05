using System;
using UnityEngine;

// Token: 0x02000EC3 RID: 3779
public class SplineControl : KAMonoBase
{

	// Token: 0x04005C79 RID: 23673
	public Transform SplineObject;

	// Token: 0x04005C7A RID: 23674
	public bool _Draw;

	// Token: 0x04005C7B RID: 23675
	public float[] ControlTime;

	// Token: 0x04005C7C RID: 23676
	public bool Looping;

	// Token: 0x04005C7D RID: 23677
	public bool ConstantSpeed = true;

	// Token: 0x04005C7E RID: 23678
	public bool AlignTangent;

	// Token: 0x04005C7F RID: 23679
	public float CurrentPos;

	// Token: 0x04005C80 RID: 23680
	public float Speed;

	// Token: 0x04005C81 RID: 23681
	public bool SmoothMovement = true;

	// Token: 0x04005C82 RID: 23682
	public float SmoothFactor = 0.1f;

	// Token: 0x04005C83 RID: 23683
	public bool GroundCheck;

	// Token: 0x04005C84 RID: 23684
	public float GroundCheckStartHeight = 2f;

	// Token: 0x04005C85 RID: 23685
	public float GroundCheckDist = 20f;

	// Token: 0x04005C86 RID: 23686
	public bool FlipDirOnBackward = true;

	// Token: 0x04005C87 RID: 23687
	public float LinearLength;

	// Token: 0x04005C88 RID: 23688
	public bool IsLocal;

	// Token: 0x04005C89 RID: 23689
	public Spline mSpline;

	// Token: 0x04005C8A RID: 23690
	[NonSerialized]
	public bool mEndReached;
}
