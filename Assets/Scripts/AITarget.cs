using System;
using UnityEngine;

// Token: 0x02000536 RID: 1334
[Serializable]
public class AITarget
{
	

	// Token: 0x04002275 RID: 8821
	public TargetTypes TargetType;

	// Token: 0x04002276 RID: 8822
	public Transform _Target;

	// Token: 0x04002277 RID: 8823
	public Vector3 _Offset = Vector3.zero;

	// Token: 0x04002278 RID: 8824
	public bool _ApplyRotationToOffset;

	// Token: 0x04002279 RID: 8825
	[HideInInspector]
	public AIActor Actor;
}
