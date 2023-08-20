using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x020001FC RID: 508
public class ObProximityHatch : ObProximity
{

	// Token: 0x04000D33 RID: 3379
	public static bool pIsHatching;

	// Token: 0x04000D34 RID: 3380
	public bool _LoadLastLevel;

	// Token: 0x04000D35 RID: 3381
	public int _DefaultStableItemID;

	// Token: 0x04000D36 RID: 3382
	public int _HatchingAchievementID = 201387;

	// Token: 0x04000D37 RID: 3383
	public HatcheryManager _HatcheryManager;

	// Token: 0x04000D38 RID: 3384
	public LocaleString _GrowDragonText = new LocaleString("Grow your dragon to the X stage?");

	// Token: 0x04000D39 RID: 3385
	public LocaleString _GrowDragonTitleText = new LocaleString("Grow your dragon");

	// Token: 0x04000D3A RID: 3386
	public LocaleString _PlaceEggTitleText = new LocaleString("Hatch Egg");

	// Token: 0x04000D3B RID: 3387
	public LocaleString _PublishHatchText = new LocaleString("Congratulations!  You hatched a {dragon type}.  Would you like to share this?");

	// Token: 0x04000D3C RID: 3388
	public LocaleString _PublishHatchTitleText = new LocaleString("Hatch");

	// Token: 0x04000D3D RID: 3389
	public LocaleString _PublishGrowthText = new LocaleString("Congratulations!  Your dragon grew to {age}.  Would you like to share this?");

	// Token: 0x04000D3E RID: 3390
	public LocaleString _PublishGrowthTitleText = new LocaleString("Growth");

	// Token: 0x04000D3F RID: 3391
	public Vector3 _DragonStartOffset = Vector3.zero;

	// Token: 0x04000D40 RID: 3392
	public string _DragonCustomizationAsset = "RS_DATA/PfUiDragonCustomizationDO.unity3d/PfUiDragonCustomizationDO";

	// Token: 0x04000D41 RID: 3393
	public string _DragonAgeUpCustomizationAsset = "RS_DATA/PfUiDragonCustomizationDO.unity3d/PfUiDragonCustomizationDO";

	// Token: 0x04000D42 RID: 3394
	public CutSceneData[] _BondingCutscenes;

	
}
