using System;
using UnityEngine;

// Token: 0x020004F3 RID: 1267
public class AIBehavior_PlayAnim : AIBehavior
{
	

	// Token: 0x040020FA RID: 8442
	public string _AnimName;

	// Token: 0x040020FB RID: 8443
	public WrapMode _Mode = WrapMode.Once;

	// Token: 0x040020FC RID: 8444
	public float _CrossFadeTime = 0.1f;

	// Token: 0x040020FD RID: 8445
	public bool _Queue;

	// Token: 0x040020FE RID: 8446
	public bool _ResetAnim;

	// Token: 0x040020FF RID: 8447
	public bool _CompletedAfterPlay;

	// Token: 0x04002100 RID: 8448
	public bool _ClearAnimNameWhenCompleted;

	// Token: 0x04002101 RID: 8449
	public int _NumLoops;

	// Token: 0x04002102 RID: 8450
	private int mNumLoops;
}
