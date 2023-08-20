using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x020001F3 RID: 499
public class HatcheryManager
{
	
	public int pSlotUnlockCost { get; private set; }



	// Token: 0x04000D06 RID: 3334
	public string _DefaultEggAssetName = "RS_DATA/DragonEgg.unity3d/PfDragonEgg";

	// Token: 0x04000D07 RID: 3335
	public string _AttachBone = "Shoulders_J";

	// Token: 0x04000D08 RID: 3336
	public Vector3 _EggPosition = new Vector3(-0.006f, -0.542f, 0.353f);

	// Token: 0x04000D0D RID: 3341
	[NonSerialized]
	public GameObject pEgg;

	// Token: 0x04000D0E RID: 3342
	public bool IsFromStables;

	// Token: 0x04000D12 RID: 3346
	public Action OnSlotUnlockCostUpdated;

	// Token: 0x04000D13 RID: 3347
	public static int pIncubatorHatchID;
}
