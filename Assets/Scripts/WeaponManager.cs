using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x020012BF RID: 4799
public class WeaponManager : MonoBehaviour
{
	// Token: 0x17000BE7 RID: 3047
	// (get) Token: 0x06007966 RID: 31078 RVA: 0x000522EB File Offset: 0x000504EB
	public float pCooldownTimer
	{
		get
		{
			return this.mCooldownTimer;
		}
	}

	// Token: 0x17000BE8 RID: 3048
	// (get) Token: 0x06007967 RID: 31079 RVA: 0x000522F3 File Offset: 0x000504F3
	// (set) Token: 0x06007968 RID: 31080 RVA: 0x000522FB File Offset: 0x000504FB
	public bool pUserControlledWeapon
	{
		get
		{
			return this.mUserControlledWeapon;
		}
		set
		{
			this.mUserControlledWeapon = value;
		}
	}

	// Token: 0x17000BE9 RID: 3049
	// (get) Token: 0x06007969 RID: 31081 RVA: 0x00052304 File Offset: 0x00050504
	// (set) Token: 0x0600796A RID: 31082 RVA: 0x0005230C File Offset: 0x0005050C
	public Transform pCurrentTarget
	{
		get
		{
			return this.mCurrentTarget;
		}
		set
		{
			this.mCurrentTarget = value;
		}
	}

	// Token: 0x17000BEA RID: 3050
	// (set) Token: 0x0600796B RID: 31083 RVA: 0x00052315 File Offset: 0x00050515
	public GameObject pFiredMessageObject
	{
		set
		{
			this.mFiredMessageObject = value;
		}
	}

	

	// Token: 0x17000BEC RID: 3052
	// (get) Token: 0x0600796D RID: 31085 RVA: 0x0005231E File Offset: 0x0005051E
	// (set) Token: 0x0600796E RID: 31086 RVA: 0x00052326 File Offset: 0x00050526
	public List<Transform> pTargetList
	{
		get
		{
			return this.mTargetList;
		}
		set
		{
			this.mTargetList = value;
		}
	}

	// Token: 0x17000BED RID: 3053
	// (get) Token: 0x0600796F RID: 31087 RVA: 0x0005232F File Offset: 0x0005052F
	public Vector3 pShootPoint
	{
		get
		{
			if (!(this.ShootPointTrans == null))
			{
				return this.ShootPointTrans.position;
			}
			return base.transform.position;
		}
	}

	// Token: 0x0400742A RID: 29738
	private const char MESSAGE_SEPARATOR = ':';

	// Token: 0x0400742B RID: 29739
	private const string WEAPON_HIT = "WH";

	// Token: 0x0400742C RID: 29740
	private const string WEAPON_FIRED = "WF";

	// Token: 0x0400742D RID: 29741
	private const string WEAPON_FIRED_WITH_TARGET = "WFWT";

	// Token: 0x0400742E RID: 29742
	private const float CENTER_WEIGHT = 2f;

	// Token: 0x0400742F RID: 29743
	private const float TARGET_WINDOW_WIDTH = 0.8f;

	// Token: 0x04007430 RID: 29744
	private const float TARGET_WINDOW_HEIGHT = 0.8f;

	// Token: 0x04007431 RID: 29745
	private const float TARGET_WINDOW_CENTER = 0f;

	// Token: 0x04007432 RID: 29746
	public WeaponManager.WeaponChanged OnWeaponChanged;

	// Token: 0x04007433 RID: 29747
	public WeaponManager.AvailableShotUpdated OnAvailableShotUpdated;

	// Token: 0x04007434 RID: 29748
	public WeaponManager.WeaponData _MainWeapon = new WeaponManager.WeaponData("Fireball");

	// Token: 0x04007435 RID: 29749
	protected WeaponTuneData.Weapon CurrentWeapon;

	// Token: 0x04007436 RID: 29750
	public int _DefaultTotalShots = 4;

	// Token: 0x04007437 RID: 29751
	public float _DefaultCoolDown = 1.5f;

	// Token: 0x04007438 RID: 29752
	public MinMax _DefaultRechargeRate = new MinMax(1f, 4f);

	// Token: 0x04007439 RID: 29753
	protected float mCooldownTimer = -1f;

	// Token: 0x0400743A RID: 29754
	private bool mUserControlledWeapon;

	// Token: 0x0400743B RID: 29755
	public bool IsLocal;

	// Token: 0x0400743C RID: 29756
	public string _AmmoPoolName;

	// Token: 0x0400743E RID: 29758
	protected Transform mTarget;

	// Token: 0x0400743F RID: 29759
	protected List<Transform> mTargetList;

	// Token: 0x04007440 RID: 29760
	private Bounds mTargetWindowBounds;

	// Token: 0x04007441 RID: 29761
	private float mTargetEvalTimer;

	// Token: 0x04007442 RID: 29762
	private float mTargetEvalFreq;

	// Token: 0x04007443 RID: 29763
	private float mPrevShotTimer = 999f;

	// Token: 0x04007444 RID: 29764
	private Vector2 mReticleDrift = new Vector2(0f, 0f);

	// Token: 0x04007445 RID: 29765
	private Transform mSnapTransform;

	// Token: 0x04007446 RID: 29766
	private WeaponTuneData.ParticleInfo mParticleInfo;

	// Token: 0x04007448 RID: 29768
	public string _ShootPoint;

	// Token: 0x04007449 RID: 29769
	[HideInInspector]
	public Transform ShootPointTrans;

	// Token: 0x0400744A RID: 29770
	public int _NumShotsForNoTarget = 1;

	// Token: 0x0400744B RID: 29771
	public bool _EnableFireTowardsCenter;

	// Token: 0x0400744C RID: 29772
	public float _FireCoolDownRegenRate;

	// Token: 0x0400744D RID: 29773
	public Transform _ShootingPointController;

	// Token: 0x0400744E RID: 29774
	public List<Transform> _ShootingPoints = new List<Transform>();

	// Token: 0x0400744F RID: 29775
	public List<Transform> _SpecialAttackShootingPoints = new List<Transform>();

	// Token: 0x04007450 RID: 29776
	protected int mPhysicsLayerMask;

	// Token: 0x04007451 RID: 29777
	private bool mLoggedNullException;

	// Token: 0x04007452 RID: 29778
	private int mProjectileIndex;

	// Token: 0x04007453 RID: 29779
	protected Transform mCurrentTarget;

	// Token: 0x04007454 RID: 29780
	private GameObject mFiredMessageObject;

	// Token: 0x020012C0 RID: 4800
	[Serializable]
	public class WeaponData
	{
		// Token: 0x0600798E RID: 31118 RVA: 0x0005247F File Offset: 0x0005067F
		public WeaponData(string inName)
		{
			this.name = inName;
		}

		// Token: 0x04007455 RID: 29781
		public string name;
	}

	// Token: 0x020012C1 RID: 4801
	// (Invoke) Token: 0x06007990 RID: 31120
	public delegate void WeaponChanged();

	// Token: 0x020012C2 RID: 4802
	// (Invoke) Token: 0x06007994 RID: 31124
	public delegate void AvailableShotUpdated(int count);
}
