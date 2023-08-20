using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x0200115E RID: 4446
[Serializable]
public class SanctuaryPetTypeInfo
{
	

	// Token: 0x04006BCA RID: 27594
	public string _Name;

	// Token: 0x04006BCB RID: 27595
	public LocaleString _NameText;

	// Token: 0x04006BCC RID: 27596
	public LocaleString _DescriptionText;

	// Token: 0x04006BCD RID: 27597
	public string _Settings = "Default";

	// Token: 0x04006BCE RID: 27598
	public int _TypeID;

	// Token: 0x04006BCF RID: 27599
	public RaisedPetGrowthState[] _GrowthStates;

	// Token: 0x04006BD0 RID: 27600
	public float _HatchDuration = 60f;

	// Token: 0x04006BD1 RID: 27601
	public int _InstantHatchTicketItemStoreID = 93;

	// Token: 0x04006BD2 RID: 27602
	public int _InstantHatchTicketItemID = 8227;

	// Token: 0x04006BD3 RID: 27603
	public float _BirthScale = 0.25f;

	// Token: 0x04006BD4 RID: 27604
	public PetAgeData[] _AgeData;

	// Token: 0x04006BD5 RID: 27605
	public LocaleString[] _SleepText;

	// Token: 0x04006BD6 RID: 27606
	public AudioClip[] _SleepMsgVO;

	// Token: 0x04006BD7 RID: 27607
	public string[] _GlowColors;

	// Token: 0x04006BD8 RID: 27608
	public CustomSkinData[] _CustomSkinData;

	// Token: 0x04006BD9 RID: 27609
	public LocaleString _WakeupText;

	// Token: 0x04006BDA RID: 27610
	public AudioClip _WakeMsgVO;

	// Token: 0x04006BDB RID: 27611
	public string _EggIconPath = string.Empty;

	// Token: 0x04006BDC RID: 27612
	public string _DragonEggAssetpath = "RS_DATA/DragonEgg/PfDragonEgg";

	// Token: 0x04006BDD RID: 27613
	public SFXMap[] _SoundMapper;

	// Token: 0x04006BDE RID: 27614
	public string _PilotAnimRes = "RS_SHARED/DragonFlyAvatar";

	// Token: 0x04006BDF RID: 27615
	public string _PetTextureRes = "RS_SHARED/PetDragonTextures";

	// Token: 0x04006BE0 RID: 27616
	public SanctuaryPetAccInfo[] _AccTypeInfo;

	// Token: 0x04006BE1 RID: 27617
	public string _NameSelectPrefabName = "PfUiPetNameSelect";

	// Token: 0x04006BE2 RID: 27618
	public PetSpecialSkillType _SpecialSkill;

	// Token: 0x04006BE3 RID: 27619
	public bool _AllowAccessToMemberOnlyFeatures;

	// Token: 0x04006BE4 RID: 27620
	public float _Weight = 30f;

	// Token: 0x04006BE5 RID: 27621
	public SanctuaryPetStats _Stats;

	// Token: 0x04006BE6 RID: 27622
	public DragonClass _DragonClass;

	// Token: 0x04006BE7 RID: 27623
	private PrimaryTypeInfo mPrimaryType;

	// Token: 0x04006BE8 RID: 27624
	private SecondaryTypeInfo mSecondaryType;

	// Token: 0x04006BE9 RID: 27625
	public float _MountedMinCameraDistance = 2f;

	// Token: 0x04006BEA RID: 27626
	public int _MinAgeToMount = 2;

	// Token: 0x04006BEB RID: 27627
	public int _MinAgeToFly = 3;

	// Token: 0x04006BEC RID: 27628
	public AchievementTitle[] _AchievementTitle;

	// Token: 0x04006BED RID: 27629
	public int _AgeUpMissionID;

	// Token: 0x04006BEE RID: 27630
	public bool _IsUniquePet;

	// Token: 0x04006BEF RID: 27631
	public List<string> _TicketItemIDList;

	// Token: 0x04006BF0 RID: 27632
	public bool _Flightless;

	// Token: 0x04006BF1 RID: 27633
	public int _Health = 50;

	// Token: 0x04006BF2 RID: 27634
	public bool _CanMoodChangeColor;

	// Token: 0x04006BF3 RID: 27635
	public bool _CanBecomeInvisible;

	// Token: 0x04006BF4 RID: 27636
	public bool _IsGoodSwimmer;
}
