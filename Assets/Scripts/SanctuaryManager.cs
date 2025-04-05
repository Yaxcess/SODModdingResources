using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// Token: 0x0200116D RID: 4461
public class SanctuaryManager : MonoBehaviour
{
	public const int MAT_IDX_BODY = 0;

	// Token: 0x04006C3E RID: 27710
	public const int MAT_IDX_PATTERN = 0;

	// Token: 0x04006C3F RID: 27711
	public const int MAT_IDX_PATTERN_LUMINOSITY = 0;

	// Token: 0x04006C40 RID: 27712
	public const int MAT_IDX_SPIKES = 0;

	// Token: 0x04006C41 RID: 27713
	public const string ATTR_NAME_BODY_COLOR = "_PetBodyColor";

	// Token: 0x04006C42 RID: 27714
	public const string ATTR_NAME_PATTERN_COLOR = "_PetPatternColor";

	// Token: 0x04006C43 RID: 27715
	public const string ATTR_NAME_PATTERN_LUMINOSITY = "_PetPatternLuminosity";

	// Token: 0x04006C44 RID: 27716
	public const string ATTR_NAME_SPIKES_COLOR = "_PetSpikesColor";

	// Token: 0x04006C45 RID: 27717
	public const string COLOR_PARAM_BODY = "Color_Skin";

	// Token: 0x04006C46 RID: 27718
	public const string COLOR_PARAM_PATTERN = "Color_Belly";

	// Token: 0x04006C47 RID: 27719
	public const string PARAM_PATTERN_LUMINOSITY = "Hue_Belly";

	// Token: 0x04006C48 RID: 27720
	public const string COLOR_PARAM_SPIKES = "";

	// Token: 0x04006C49 RID: 27721
	public const string PARAM_PATTERN_TEXTURE = "_MainTex";

	// Token: 0x04006C4A RID: 27722
	public static string pPetStartMarkerName = "";

	// Token: 0x04006C4B RID: 27723
	public static SanctuaryManager pInstance = null;

	// Token: 0x04006C4C RID: 27724
	public static bool pCheckPetAge = false;

	// Token: 0x04006C4D RID: 27725
	public static bool pCheatGrowth = false;

	// Token: 0x04006C4E RID: 27726
	public static int pCurrentPetType = -1;

	// Token: 0x04006C4F RID: 27727
	public static SanctuaryPet pCurPetInstance = null;

	// Token: 0x04006C50 RID: 27728
	public static SanctuaryPet pPrevPetInstance = null;

	// Token: 0x04006C51 RID: 27729
	public static bool pRequestSkillSync = false;

	// Token: 0x04006C53 RID: 27731
	public static RaisedPetData mUnselectedPet = null;

	// Token: 0x04006C54 RID: 27732
	public static bool pLevelReady = false;

	// Token: 0x04006C55 RID: 27733
	public static int pNextRaisedPetIndex = 0;

	// Token: 0x04006C56 RID: 27734
	public static string pLevelName = "";

	// Token: 0x04006C57 RID: 27735
	public static bool pPendingMMOPetCheck = false;

	// Token: 0x04006C59 RID: 27737
	public bool _PoolingEnabled;

	// Token: 0x04006C5C RID: 27740
	public static bool mMountedState = false;

	// Token: 0x04006C5D RID: 27741
	public string _SanctuaryDataURL = "RS_DATA/PfSanctuaryData.unity3d/PfSanctuaryData";

	// Token: 0x04006C5E RID: 27742
	public bool _MeterPaused;

	// Token: 0x04006C5F RID: 27743
	public bool _CreateInstance = true;

	// Token: 0x04006C60 RID: 27744
	public Transform _PetStartMarker;

	// Token: 0x04006C61 RID: 27745
	public string _PetNameSelectBundlePath = "RS_DATA/PfUiDragonNameDO.unity3d/PfUiDragonNameDO";

	// Token: 0x04006C62 RID: 27746
	public string _PetCustomizationBundlePath = "RS_DATA/PfUiDragonCustomizationDO.unity3d/PfUiDragonCustomizationDO";

	// Token: 0x04006C63 RID: 27747
	public PetNameChange _PetNameChange;

	// Token: 0x04006C64 RID: 27748
	public Transform _PetSleepMarkerMale;

	// Token: 0x04006C65 RID: 27749
	public Transform _PetSleepMarkerFemale;

	// Token: 0x04006C66 RID: 27750
	public bool _AttachPetToBed = true;

	// Token: 0x04006C67 RID: 27751
	[HideInInspector]
	public UiPetMeter pPetMeter;

	// Token: 0x04006C68 RID: 27752
	public GameObject _PetClickActivateObject;

	// Token: 0x04006C69 RID: 27753
	public GameObject _NpcPetClickActivateObject;

	// Token: 0x04006C6A RID: 27754
	public GameObject _PetFlyUIObject;

	// Token: 0x04006C6B RID: 27755
	public bool _FollowAvatar = true;

	// Token: 0x04006C6C RID: 27756
	public Transform _PetZZZParticle;

	// Token: 0x04006C6D RID: 27757
	public Transform _PetSwimFx;

	// Token: 0x04006C6E RID: 27758
	public GameObject _PetSwimIdleFx;

	// Token: 0x04006C6F RID: 27759
	public Vector3 _PetOffScreenPosition = new Vector3(0f, -1000f, 0f);

	// Token: 0x04006C70 RID: 27760
	public bool _CanCheckPetAge;

	// Token: 0x04006C71 RID: 27761
	public bool _MultiPets;

	// Token: 0x04006C72 RID: 27762
	public bool _UseMeterAutoSaving;

	// Token: 0x04006C73 RID: 27763
	public float _MeterAutoSaveFrequency = 60f;

	// Token: 0x04006C74 RID: 27764
	public Vector3 _PicturePositionOffset = new Vector3(0f, 3f, 3f);

	// Token: 0x04006C75 RID: 27765
	public Vector3 _PictureLookAtOffset = new Vector3(0.05f, 1.5f, 0f);

	// Token: 0x04006C76 RID: 27766
	public int[] _NeedEnergyMeterTutorialTask;

	// Token: 0x04006C77 RID: 27767
	public int _TeenMission = 1044;

	// Token: 0x04006C78 RID: 27768
	public InteractiveTutManager _MountTutorial;

	// Token: 0x04006C79 RID: 27769
	public string _MountTutorialRes = "RS_DATA/PfMountInteractiveTut.unity3d/PfMountInteractiveTut";

	// Token: 0x04006C7A RID: 27770
	public int _PetCollectItemAchievementID = 201712;

	// Token: 0x04006C7B RID: 27771
	public int _FirePitFireAchievementID = 201711;

	// Token: 0x04006C7C RID: 27772
	public RaisedPetStage[] _BlockedStages;

	// Token: 0x04006C7D RID: 27773
	public RaisedPetStage[] _NurseryAges;

	// Token: 0x04006C7E RID: 27774
	public bool _NoHat;

	// Token: 0x04006C7F RID: 27775
	public bool _ForceLoadPetData;

	// Token: 0x04006C80 RID: 27776
	public AudioClip _LowEnergyVO;

	// Token: 0x04006C81 RID: 27777
	public LocaleString _LowEnergyText = new LocaleString("Your pet is tired");

	// Token: 0x04006C82 RID: 27778
	public AudioClip _LowHappinessVO;

	// Token: 0x04006C83 RID: 27779
	public LocaleString _LowHappinessText = new LocaleString("Your pet is angry");

	// Token: 0x04006C84 RID: 27780
	public PetNameSelectionDoneEvent OnNameSelectionDone;

	// Token: 0x04006C85 RID: 27781
	public int _DragonChampionAchievementID = 628;

	// Token: 0x04006C86 RID: 27782
	public int _DragonChampionAchievementLevel = 20;

	// Token: 0x04006C87 RID: 27783
	public int _DragonTitanAchievemetID = 2102;

	// Token: 0x04006C88 RID: 27784
	public LocaleString _CreatePetFailureText = new LocaleString("Create pet failed.");

	// Token: 0x04006C89 RID: 27785
	public string[] _MountStateIgnoreScenes;

	// Token: 0x04006C8A RID: 27786
	public string[] _FullAnimLevels;

	// Token: 0x04006C8B RID: 27787
	public string _PetMeterPrefab = "PfUiPetMeterDO";

	public delegate void PetChanged(SanctuaryPet pet);
}
