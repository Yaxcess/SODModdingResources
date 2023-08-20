using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x02000DCD RID: 3533
public class KAUI : KAMonoBase
{
	

	// Token: 0x0400568A RID: 22154
	public static KAUI _GlobalExclusiveUI = null;




	// Token: 0x04005692 RID: 22162
	public KAUI[] _UiList;

	// Token: 0x04005693 RID: 22163
	public string _BackButtonName;



	// Token: 0x04005695 RID: 22165
	public bool _AllowSafeAreaScale;

	// Token: 0x04005696 RID: 22166
	public static Action OnUIDisabled;

	// Token: 0x02000DCE RID: 3534
	public enum SwipeDirection
	{
		// Token: 0x040056A9 RID: 22185
		LEFT,
		// Token: 0x040056AA RID: 22186
		RIGHT,
		// Token: 0x040056AB RID: 22187
		UP,
		// Token: 0x040056AC RID: 22188
		DOWN,
		// Token: 0x040056AD RID: 22189
		NONE
	}
}
