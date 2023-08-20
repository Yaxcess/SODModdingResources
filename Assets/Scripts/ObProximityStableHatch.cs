using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x020000E9 RID: 233
public class ObProximityStableHatch : ObProximity
{
	// Token: 0x170000AB RID: 171
	// (get) Token: 0x060005FB RID: 1531 RVA: 0x00009DA3 File Offset: 0x00007FA3
	// (set) Token: 0x060005FC RID: 1532 RVA: 0x00009DAB File Offset: 0x00007FAB
	public GameObject pPedestalObject { get; set; }

	

	// Token: 0x04000572 RID: 1394
	public static bool pIsHatching;

	// Token: 0x04000573 RID: 1395
	public int _HatchingAchievementID = 201387;

	// Token: 0x04000574 RID: 1396
	public int _AssignToNestAchievementID = 627;

	// Token: 0x04000575 RID: 1397
	public int _NestAllocationAchievementID = 201713;

	// Token: 0x04000576 RID: 1398
	public HatcheryManager _HatcheryManager;

	// Token: 0x04000577 RID: 1399
	public LocaleString _AssignPetText = new LocaleString("Do you want to assign the Pet to Nest?");

	// Token: 0x04000578 RID: 1400
	public LocaleString _BuyStablesText = new LocaleString("You dont have any available Nests.DO you want to buy a Stable ?");

	// Token: 0x04000579 RID: 1401
	public LocaleString _AssignPetTitleText = new LocaleString("Assign Nest");

	// Token: 0x0400057A RID: 1402
	public LocaleString _BuyStablesTitleText = new LocaleString("Buy Stable");

	// Token: 0x0400057B RID: 1403
	public string _DragonCustomizationAsset = "RS_DATA/PfUiDragonCustomizationDO.unity3d/PfUiDragonCustomizationDO";

	// Token: 0x0400057C RID: 1404
	public CutSceneData[] _BondingCutscenes;

	// Token: 0x0400057E RID: 1406
	public StoreLoader.Selection _StoreInfo;

	
}
