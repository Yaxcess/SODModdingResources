using System;
using UnityEngine;

// Token: 0x0200055B RID: 1371
[Serializable]
public class AvAvatarCamParams
{
	// Token: 0x04002393 RID: 9107
	public Vector3 _Polar = new Vector3(0f, 30f, -5f);

	// Token: 0x04002394 RID: 9108
	public float _FocusHeight = 2f;

	// Token: 0x04002395 RID: 9109
	public float _Speed = 5f;

	// Token: 0x04002396 RID: 9110
	public const float _MinCameraDistance = 2f;

	// Token: 0x04002397 RID: 9111
	public float _MaxCameraDistance = 15f;

	// Token: 0x04002398 RID: 9112
	public bool _IgnoreCollision;
}
