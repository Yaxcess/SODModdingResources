using System;
using UnityEngine;

// Token: 0x020012BD RID: 4797
public class PetWeaponManager : WeaponManager
{

	// Token: 0x04007419 RID: 29721
	public GameObject _WeaponPfOverride;

	// Token: 0x0400741A RID: 29722
	public GameObject _WeaponHitPfOverride;

	// Token: 0x0400741B RID: 29723
	public ParticleSystem[] _DragonOnFireParticles;

	// Token: 0x0400741C RID: 29724
	public float _ReticleRotZSpeed = -30f;

	// Token: 0x0400741D RID: 29725
	public bool _ShowTargetWindow;

	// Token: 0x0400741E RID: 29726
	public string _PowerUpWeapon;

	// Token: 0x0400741F RID: 29727
	private string mModifiedWeaponName;

	// Token: 0x04007420 RID: 29728
	[HideInInspector]
	public SanctuaryPet SanctuaryPet;

	// Token: 0x04007421 RID: 29729
	[HideInInspector]
	public bool mAltFireActive = true;
}
