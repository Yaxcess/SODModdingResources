using System;
using UnityEngine;

// Token: 0x0200055E RID: 1374
[Serializable]
public class AvAvatarBounceParams
{
	// Token: 0x040023B8 RID: 9144
	public string[] _BouncingAreas;

	// Token: 0x040023B9 RID: 9145
	public float _BounceDissipatingFactor = 0.7f;

	// Token: 0x040023BA RID: 9146
	public float _BouncingFactor = 1f;

	// Token: 0x040023BB RID: 9147
	public float _BounceStartThreshold = 1f;

	// Token: 0x040023BC RID: 9148
	public float _BounceStopThreshold = 1f;

	// Token: 0x040023BD RID: 9149
	public SnRandomSound _BounceSound;

	// Token: 0x040023BE RID: 9150
	public GameObject _BouncingObject;
}
