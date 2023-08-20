using System;
using UnityEngine;

// Token: 0x02001140 RID: 4416
[Serializable]
public class PetAgeData
{
	// Token: 0x04006B0A RID: 27402
	public string _Name;

	// Token: 0x04006B0B RID: 27403
	public PetAgeBoneData[] _BoneInfo;

	// Token: 0x04006B0C RID: 27404
	public float _WalkSpeed = 1f;

	// Token: 0x04006B0D RID: 27405
	public float _RunSpeed = 1f;

	// Token: 0x04006B0E RID: 27406
	public float _BathScale;

	// Token: 0x04006B0F RID: 27407
	public float _PlayScale;

	// Token: 0x04006B10 RID: 27408
	public float _TPScale;

	// Token: 0x04006B11 RID: 27409
	public float _LabScale = 1f;

	// Token: 0x04006B12 RID: 27410
	public float _EelBlastScale = 1f;

	// Token: 0x04006B13 RID: 27411
	public float _UiScale = 1f;

	// Token: 0x04006B14 RID: 27412
	public float _ClickRadius;

	// Token: 0x04006B15 RID: 27413
	public float _ClickHeight = 1f;

	// Token: 0x04006B16 RID: 27414
	public Vector3 _ClickCenter = Vector3.zero;

	// Token: 0x04006B17 RID: 27415
	public PetSkillRequirements[] _SkillsRequired;

	// Token: 0x04006B18 RID: 27416
	public float _MinTotalSkillLevelToNextAge;

	// Token: 0x04006B19 RID: 27417
	public float _MaxTotalSkillLevelToNextAge;

	// Token: 0x04006B1A RID: 27418
	public float _MinHours;

	// Token: 0x04006B1B RID: 27419
	public float _MaxHours;

	// Token: 0x04006B1C RID: 27420
	public AudioClip _GrowVO;

	// Token: 0x04006B1D RID: 27421
	public bool _AgeSpecificAnim;

	// Token: 0x04006B1E RID: 27422
	public SantuayPetResourceInfo[] _PetResList;

	// Token: 0x04006B21 RID: 27425
	public PetAgeBoneData _PetPictureScaleData;

	// Token: 0x04006B22 RID: 27426
	public Vector3 _MountAvatarOffsetPos = Vector3.zero;

	// Token: 0x04006B23 RID: 27427
	public Vector3 _HUDPictureCameraOffset = new Vector3(2f, 5f, 5f);

	// Token: 0x04006B25 RID: 27429
	public bool _NewlyAdded;
}
