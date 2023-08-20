using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x020001F8 RID: 504
public class ObClickableDragonEgg : ObClickableCommon
{
	

	// Token: 0x04000D21 RID: 3361
	public LocaleString _PicksUpEggText = new LocaleString("");

	// Token: 0x04000D22 RID: 3362
	public LocaleString _ChooseEggText = new LocaleString("Do you want to choose this egg?");

	// Token: 0x04000D23 RID: 3363
	public int _DragonType = 5;

	// Token: 0x04000D24 RID: 3364
	public HatcheryManager _HatcheryManager;

	// Token: 0x04000D25 RID: 3365
	public ObProximityHatch _ObProximityHatch;
}
