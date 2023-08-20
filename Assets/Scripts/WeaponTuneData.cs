using System;
using UnityEngine;

// Token: 0x020008F8 RID: 2296
public class WeaponTuneData : MonoBehaviour
{
	// Token: 0x06003694 RID: 13972 RVA: 0x0019CC48 File Offset: 0x0019AE48
	public string[] GetWeaponNames()
	{
		if ((this._Weapons != null && this.WeaponNames == null) || this.CachedLength != this._Weapons.Length)
		{
			this.WeaponNames = new string[this._Weapons.Length];
			for (int i = 0; i < this._Weapons.Length; i++)
			{
				this.WeaponNames[i] = this._Weapons[i]._Name;
			}
		}
		return this.WeaponNames;
	}

	// Token: 0x06003695 RID: 13973 RVA: 0x0019CCB8 File Offset: 0x0019AEB8
	public int FindWeaponIndex(string weaponName)
	{
		if (this._Weapons != null)
		{
			for (int i = 0; i < this._Weapons.Length; i++)
			{
				if (this._Weapons[i]._Name == weaponName)
				{
					return i;
				}
			}
		}
		return 0;
	}

	// Token: 0x06003696 RID: 13974 RVA: 0x0019CCF8 File Offset: 0x0019AEF8
	public WeaponTuneData.Weapon GetWeapon(string weaponName)
	{
		if (this._Weapons != null)
		{
			for (int i = 0; i < this._Weapons.Length; i++)
			{
				if (this._Weapons[i]._Name == weaponName)
				{
					return this._Weapons[i];
				}
			}
		}
		return null;
	}

	// Token: 0x06003697 RID: 13975 RVA: 0x0019CD40 File Offset: 0x0019AF40
	public static void InitializeWeaponShots(WeaponTuneData.Weapon[] weapons)
	{
		if (weapons == null)
		{
			return;
		}
		foreach (WeaponTuneData.Weapon weapon in weapons)
		{
			if (weapon != null)
			{
				weapon._AvailableShots = weapon._TotalShots;
			}
		}
	}


	// Token: 0x04003832 RID: 14386
	public WeaponTuneData.Weapon[] _Weapons;

	// Token: 0x04003833 RID: 14387
	public WeaponTuneData.WeaponEffect _SlowEffect;

	// Token: 0x04003834 RID: 14388
	public WeaponTuneData.AimedReticle _AimedReticle;

	// Token: 0x04003835 RID: 14389
	public bool _AimedShotForRacing;

	// Token: 0x04003836 RID: 14390
	public bool _ReticleDrift = true;

	// Token: 0x04003837 RID: 14391
	private string[] WeaponNames;

	// Token: 0x04003838 RID: 14392
	private int CachedLength;

	// Token: 0x04003839 RID: 14393
	private static WeaponTuneData mInstance;

	// Token: 0x020008F9 RID: 2297
	[Serializable]
	public enum AmmoType
	{
		// Token: 0x0400383B RID: 14395
		FIRE,
		// Token: 0x0400383C RID: 14396
		ICE,
		// Token: 0x0400383D RID: 14397
		ELECTRIC
	}

	// Token: 0x020008FA RID: 2298
	[Serializable]
	public class ParticleInfo
	{

		// Token: 0x0400383F RID: 14399
		public float _Scale = 1f;

		// Token: 0x04003840 RID: 14400
		public bool _UseHitPrefab;
	}

	// Token: 0x020008FB RID: 2299
	[Serializable]
	public class AdditionalProjectile
	{
		// Token: 0x04003841 RID: 14401
		public GameObject _ProjectilePrefab;

		// Token: 0x04003842 RID: 14402
		public GameObject _HitPrefab;
	}

	// Token: 0x020008FC RID: 2300
	[Serializable]
	public class Weapon
	{
		// Token: 0x170005F7 RID: 1527
		// (get) Token: 0x0600369C RID: 13980 RVA: 0x00026D87 File Offset: 0x00024F87
		// (set) Token: 0x0600369D RID: 13981 RVA: 0x00026D8F File Offset: 0x00024F8F
		public GameObject pHitPrefab { get; set; }

		// Token: 0x04003843 RID: 14403
		public string _Name;

		// Token: 0x04003844 RID: 14404
		public float _MinSpeed;

		// Token: 0x04003845 RID: 14405
		public float _MaxTimeToTarget;

		// Token: 0x04003846 RID: 14406
		public int _Damage;

		// Token: 0x04003847 RID: 14407
		public float _CriticalDamageMultiplier = 1f;

		// Token: 0x04003848 RID: 14408
		public int _CriticalDamageChance = 20;

		// Token: 0x04003849 RID: 14409
		public float _Energy;

		// Token: 0x0400384A RID: 14410
		public float _TouchRadius;

		// Token: 0x0400384B RID: 14411
		public float _Lifetime;

		// Token: 0x0400384C RID: 14412
		public int _TotalShots;

		// Token: 0x0400384D RID: 14413
		public float _Cooldown;

		// Token: 0x0400384E RID: 14414
		public float _Range;

		// Token: 0x0400384F RID: 14415
		public bool _Homing;

		// Token: 0x04003850 RID: 14416
		public bool _SlowEffect;

		// Token: 0x04003851 RID: 14417
		public GameObject _ProjectilePrefab;

		// Token: 0x04003852 RID: 14418
		public GameObject _HitPrefab;

		// Token: 0x04003853 RID: 14419
		public WeaponTuneData.AdditionalProjectile[] _AdditionalProjectile;

		// Token: 0x04003854 RID: 14420
		public bool _ProjectileRandom;

		// Token: 0x04003855 RID: 14421
		public AudioClip _HitSound;

		// Token: 0x04003856 RID: 14422
		public GameObject _HitSoundSourcePrefab;

		// Token: 0x04003857 RID: 14423
		public Color _FireTint;

		// Token: 0x04003859 RID: 14425
		public WeaponTuneData.AmmoType _AmmoType;

		// Token: 0x0400385A RID: 14426
		public MinMax _RechargeRange;

		// Token: 0x0400385B RID: 14427
		public WeaponTuneData.ParticleInfo[] _ParticleInfo;

		// Token: 0x0400385C RID: 14428
		[HideInInspector]
		public int _AvailableShots;
	}

	// Token: 0x020008FD RID: 2301
	[Serializable]
	public class AimedReticle
	{
		// Token: 0x0400385E RID: 14430
		public Vector2 _ScreenOffset = Vector2.zero;

		// Token: 0x0400385F RID: 14431
		public Vector2 _Limits = new Vector2(25f, 25f);

		// Token: 0x04003860 RID: 14432
		public Vector2 _Speed = new Vector2(250f, 250f);

		// Token: 0x04003861 RID: 14433
		public Vector2 _CenterSpeed = Vector2.zero;

		// Token: 0x04003862 RID: 14434
		public float _CenterSpring = 0.01f;

		// Token: 0x04003863 RID: 14435
		public float _SnapThreshold = 0.05f;
	}

	// Token: 0x020008FE RID: 2302
	[Serializable]
	public class WeaponEffect
	{
		// Token: 0x04003864 RID: 14436
		public float _Strength = 1f;

		// Token: 0x04003865 RID: 14437
		public float _Time = 3f;
	}
}
