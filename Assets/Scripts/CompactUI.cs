using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x02000A88 RID: 2696
public class CompactUI : MonoBehaviour
{
	
	// Token: 0x04003F3B RID: 16187
	public float _Radius = 4f;

	// Token: 0x04003F3C RID: 16188
	public Transform _TargetRef;

	// Token: 0x04003F3D RID: 16189
	public bool _EnableAutoRotTowardsTarget;

	// Token: 0x04003F3E RID: 16190
	public bool _DefaultClickEnabled = true;

	// Token: 0x04003F3F RID: 16191
	public bool _UseSavedState = true;

	// Token: 0x04003F42 RID: 16194
	public bool _AutoDistributeChild = true;

	// Token: 0x04003F43 RID: 16195
	public float _RotationAngle = 25f;

	// Token: 0x04003F44 RID: 16196
	public float _InitialRotation;

	// Token: 0x04003F45 RID: 16197
	public string _SaveKey = string.Empty;


	// Token: 0x04003F47 RID: 16199
	public KAWidget[] _ChildList;

}
