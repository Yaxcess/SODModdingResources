using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// Token: 0x02001174 RID: 4468
public class SanctuaryPet : Pet
{

	
    // Token: 0x1400006E RID: 110
    // (add) Token: 0x06006EBF RID: 28351 RVA: 0x002C34B8 File Offset: 0x002C16B8
    // (remove) Token: 0x06006EC0 RID: 28352 RVA: 0x002C34F0 File Offset: 0x002C16F0
    public event SanctuaryPet.PetMount OnPetMount;

	// Token: 0x1400006F RID: 111
	// (add) Token: 0x06006EC1 RID: 28353 RVA: 0x002C3528 File Offset: 0x002C1728
	// (remove) Token: 0x06006EC2 RID: 28354 RVA: 0x002C3560 File Offset: 0x002C1760
	public event SanctuaryPet.PetJump OnPetJump;

	// Token: 0x17000AB4 RID: 2740
	// (get) Token: 0x06006EC3 RID: 28355 RVA: 0x0004BE05 File Offset: 0x0004A005
	// (set) Token: 0x06006EC4 RID: 28356 RVA: 0x0004BE0D File Offset: 0x0004A00D
	public UiPetMeter pUiPetMeter { get; set; }

    public PetMeterActionData[] _ActionMeterData;

    public GameObject _ActionDoneMessageObject;

    // Token: 0x04006CBC RID: 27836
    public const uint LOG_MASK = 32U;

	// Token: 0x04006CBD RID: 27837
	public static bool pSkillNoDateCheck = true;

	// Token: 0x04006CBE RID: 27838
	public static SanctuaryPet pLastClickedPet = null;

	// Token: 0x04006CC1 RID: 27841
	[NonSerialized]
	public Transform pFlyCollider;

	// Token: 0x04006CC2 RID: 27842
	[NonSerialized]
	public CapsuleCollider pClickCollider;

	// Token: 0x04006CC3 RID: 27843
	[HideInInspector]
	public RaisedPetData pData;

	// Token: 0x04006CC7 RID: 27847
	[HideInInspector]
	public List<AssetBundle> _AnimBundles;

	// Token: 0x04006CC8 RID: 27848
	public Texture2D[] _ColorMasks;

	// Token: 0x04006CC9 RID: 27849
	public Texture2D _ShadowTex;

	// Token: 0x04006CCA RID: 27850
	public Texture2D _HighLightTex;

	// Token: 0x04006CCB RID: 27851
	public bool _PlayMoodParticleInLab;

	// Token: 0x04006CCC RID: 27852
	public string[] _FidgetAnim;

	// Token: 0x04006CCD RID: 27853
	public string _PettingLieDownAnim = "LieDownPetting01";

	// Token: 0x04006CCE RID: 27854
	public string[] _PettingPartAnim;

	// Token: 0x04006CCF RID: 27855
	public float _PettingHeadSize = 0.09f;

	// Token: 0x04006CD0 RID: 27856
	public float _PettingBodySize = 0.18f;

	// Token: 0x04006CD1 RID: 27857
	public string _PounceAnim = "Pounce";

	// Token: 0x04006CD2 RID: 27858
	public string _RunSadAnim = "RunSad";

	// Token: 0x04006CD3 RID: 27859
	public string _WalkSadAnim = "WalkSad";

	// Token: 0x04006CD4 RID: 27860
	public string _RunAngryAnim = "RunAngry";

	// Token: 0x04006CD5 RID: 27861
	public string _WalkAngryAnim = "WalkAngry";

	// Token: 0x04006CD6 RID: 27862
	public string _MountIdleAnim = "IdleStand";

	// Token: 0x04006CD7 RID: 27863
	public string _MountRunAnim = "Run";

	// Token: 0x04006CD8 RID: 27864
	public string _AttackAnim = "Attack01";

	// Token: 0x04006CD9 RID: 27865
	public string _FlyAttackAnim = "FlyAttackAdd";

	// Token: 0x04006CDA RID: 27866
	public AudioClip _BreatheFireSound;

	// Token: 0x04006CDC RID: 27868
	[NonSerialized]
	public int pAge;

	// Token: 0x04006CDD RID: 27869
	public AIActor_Pet AIActor;

	// Token: 0x04006CDE RID: 27870
	public List<GameObject> _DisabledWhenMounted;

	// Token: 0x04006CE7 RID: 27879
	public PetAgeData pCurAgeData;

	// Token: 0x04006CEA RID: 27882
	public Transform _HatObj;

	// Token: 0x04006CEB RID: 27883
	public Vector3 _HatOffset = new Vector3(0f, 0f, 0f);

	// Token: 0x04006CEC RID: 27884
	public Vector3 _FlyScale = new Vector3(1.4f, 1.4f, 1.4f);

	// Token: 0x04006CEE RID: 27886
	public bool pMeterPaused;

	// Token: 0x04006CF0 RID: 27888
	protected int mFlySkillLevel;

	// Token: 0x04006CF1 RID: 27889
	public bool _NoWalk;

	// Token: 0x04006CF6 RID: 27894
	public float _MinPetMeterValue = 0.01f;

	// Token: 0x04006CFE RID: 27902
	[HideInInspector]
	public bool pIsGlowDisabled;

	// Token: 0x04006D00 RID: 27904
	[HideInInspector]
	public bool mMountDisabled;

	// Token: 0x04006D01 RID: 27905
	[HideInInspector]
	public bool pIsFlying;

	// Token: 0x04006D02 RID: 27906
	[HideInInspector]
	public bool mNPC;

	// Token: 0x04006D13 RID: 27923
	public CountDownTimer mGlowTimer = new CountDownTimer();

	// Token: 0x04006D15 RID: 27925
	[NonSerialized]
	public bool _UseMeterAutoSaving;

	// Token: 0x04006D16 RID: 27926
	[NonSerialized]
	public float _MeterAutoSaveFrequency = 60f;

	// Token: 0x04006D19 RID: 27929
	[NonSerialized]
	public bool pIsMounted;

	// Token: 0x04006D1A RID: 27930
	public GameObject _BreathAttackBall;

	// Token: 0x04006D1B RID: 27931
	[NonSerialized]
	public AssetBundle mAvatarAnimBundle;

	// Token: 0x04006D1C RID: 27932
	public string _RideAssetName;

	// Token: 0x04006D1D RID: 27933
	public bool _NoFlyingLanding;

	// Token: 0x04006D21 RID: 27937
	public int _SyncFrameOffset;

	// Token: 0x04006D23 RID: 27939
	[NonSerialized]
	public string _CustomPettingAnim;

	// Token: 0x04006D24 RID: 27940
	[NonSerialized]
	public bool pCanBreatheAttackNow;

	// Token: 0x04006D25 RID: 27941
	public string _RootBone = "Main_Root";

	// Token: 0x04006D26 RID: 27942
	public string _Bone_Nose = "Head_J";

	// Token: 0x04006D27 RID: 27943
	public string[] _BoneHeads = new string[]
	{
		"Head_J"
	};

	// Token: 0x04006D28 RID: 27944
	public string _Bone_Seat = "AvatarConstraint_J";

	// Token: 0x04006D29 RID: 27945
	public string _Bone_Hip = "Hip_J";

	// Token: 0x04006D2A RID: 27946
	public Vector3 _Head_LookAt_Offset = Vector3.zero;

	// Token: 0x04006D2B RID: 27947
	public Vector3 _PillionOffset = Vector3.zero;

	// Token: 0x04006D2C RID: 27948
	public string _PictureTargetTransformName = "";

	// Token: 0x04006D2D RID: 27949
	public string[] _DirtTextures = new string[]
	{
		"BlasterPetDirt01",
		"BlasterPetDirt02",
		"BlasterPetDirt03",
		"BlasterPetDirt04"
	};

	// Token: 0x04006D2E RID: 27950
	public GameObject _MessageObject;
	// Token: 0x04006D30 RID: 27952
	public SanctuaryPowerUpData[] _PowerUpData;

	// Token: 0x04006D31 RID: 27953
	public float _MaxJumpInterval = 1.5f;

	// Token: 0x04006D32 RID: 27954
	public int _JumpCountToFly = 2;

	// Token: 0x04006D33 RID: 27955
	public float _FireDelay = 0.1f;

	// Token: 0x04006D3F RID: 27967
	public List<GameObject> pEquippedItems = new List<GameObject>();

    public float mFlyGlideTimer = 4f;

    // Token: 0x04006D48 RID: 27976
    [HideInInspector]
	public int mPrevAnimState = -1;

	// Token: 0x04006D4D RID: 27981
	public float _FlightClubHandicap;

	// Token: 0x04006D53 RID: 27987
	public float _WaterSplashSpawnInterval = 0.2f;

	// Token: 0x04006D58 RID: 27992
	public ParticleSystem _SleepingParticleSystem;

	// Token: 0x04006D5A RID: 27994
	public SanctuaryPetTypeInfo[] _PetTypes;

	// Token: 0x02001175 RID: 4469
	// (Invoke) Token: 0x06006FCD RID: 28621
	public delegate void PetMount(bool mount, PetSpecialSkillType skill);

	// Token: 0x02001176 RID: 4470
	// (Invoke) Token: 0x06006FD1 RID: 28625
	public delegate void PetJump(bool isJump);

    private struct FlightAnimState
    {
        // Token: 0x04006D5E RID: 27998
        public string[] FlapAnim;

        // Token: 0x04006D5F RID: 27999
        public string[] GlideAnim;
    }


}
