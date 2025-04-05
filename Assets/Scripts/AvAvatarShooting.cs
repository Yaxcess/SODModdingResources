using System;
using UnityEngine;

// Token: 0x0200055D RID: 1373
[Serializable]
public class AvAvatarShooting
{
	// Token: 0x040023AF RID: 9135
	public Vector3 _ProjectileStartOffset = Vector3.zero;

	// Token: 0x040023B0 RID: 9136
	public GameObject _Projectile;

	// Token: 0x040023B1 RID: 9137
	public int _ShotsFiredUntilReload = 5;

	// Token: 0x040023B2 RID: 9138
	public float _ReloadTime = 5f;

	// Token: 0x040023B3 RID: 9139
	public float _RateOfFire = 5f;

	// Token: 0x040023B4 RID: 9140
	public string _Animation;

	// Token: 0x040023B5 RID: 9141
	public float _FireDelay;

	// Token: 0x040023B6 RID: 9142
	public bool _MembersOnly = true;

	// Token: 0x040023B7 RID: 9143
	public AudioClip _MembersOnlyVO;
}
