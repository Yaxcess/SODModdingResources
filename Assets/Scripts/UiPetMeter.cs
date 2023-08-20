using System;
using UnityEngine;

// Token: 0x02000CC5 RID: 3269
public class UiPetMeter : KAUI
{
	
	// Token: 0x04004FCD RID: 20429
	public InteractiveTutManager _EnergyTutorial;

	// Token: 0x04004FCE RID: 20430
	public string _PetMeterAnchorName = "PetMeterAnchor";

	// Token: 0x04004FCF RID: 20431
	public Vector3 _PositionOffset = new Vector3(-130f, 50f, 0f);

	// Token: 0x04004FD0 RID: 20432
	private KAWidget mPetMoodBkg;

	// Token: 0x04004FD1 RID: 20433
	private KAWidget mPetXpMeterProgress;

	// Token: 0x04004FD2 RID: 20434
	private KAWidget mMeterBarEnergyProgress;

	// Token: 0x04004FD3 RID: 20435
	private KAWidget mMeterBarEnergyBkg;

	// Token: 0x04004FD4 RID: 20436
	private KAWidget mMeterBarEnergyTxt;

	// Token: 0x04004FD5 RID: 20437
	private KAWidget mPetLevelTxt;

	// Token: 0x04004FD6 RID: 20438
	private KAWidget mPetNameTxt;

	// Token: 0x04004FD7 RID: 20439
	private GameObject mPetCSM;

	// Token: 0x04004FD8 RID: 20440
	private KAWidget mAniPointer;

	// Token: 0x04004FD9 RID: 20441
	private KAWidget mPetPortrait;

	// Token: 0x04004FDA RID: 20442
	private CompactUI mCompactUI;

	// Token: 0x04004FDB RID: 20443
	private bool mIsPetPicTaken;

	// Token: 0x04004FDC RID: 20444
	private bool mUpdateRankUi;
}
