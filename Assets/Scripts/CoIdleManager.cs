using System;
using UnityEngine;

// Token: 0x020005DE RID: 1502
public class CoIdleManager : MonoBehaviour
{
	// Token: 0x04002787 RID: 10119
	public bool _ShuffleVO = true;

	// Token: 0x04002788 RID: 10120
	public AudioClip[] _VOs;

	// Token: 0x04002789 RID: 10121
	public string _Pool = "VO_Pool";

	// Token: 0x0400278A RID: 10122
	public int _Priority;

	// Token: 0x0400278B RID: 10123
	public float _Interval = 30f;

	// Token: 0x0400278C RID: 10124
	public bool _ResetOnKeyInput = true;

	// Token: 0x0400278D RID: 10125
	public int _PlayProbabilty = 100;

	// Token: 0x0400278E RID: 10126
	protected float mTimer = 30f;

	// Token: 0x0400278F RID: 10127
	protected bool mStopped = true;

	// Token: 0x04002790 RID: 10128
	protected int mNextPlayIdx;

	// Token: 0x04002791 RID: 10129
	protected string mDoNotPlay = "";
}
