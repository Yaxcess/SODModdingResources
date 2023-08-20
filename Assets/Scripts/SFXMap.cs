using System;
using UnityEngine;

// Token: 0x020005B0 RID: 1456
[Serializable]
public class SFXMap
{
	// Token: 0x0400268A RID: 9866
	public string _AnimName = "";

	// Token: 0x0400268B RID: 9867
	public string _ClipResName;

	// Token: 0x0400268C RID: 9868
	public AudioClip _ClipRes;

	// Token: 0x0400268D RID: 9869
	[Range(0f, 1f)]
	[Tooltip("Adjust the value to make SFX from full 2D to full 3D")]
	public float _SpatialBlend = 1f;
}
