using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x02000CF7 RID: 3319
public class UIRewardMultiplier : KAUI
{
	// Token: 0x040050F3 RID: 20723
	public KAWidget _UIXPDial;

	// Token: 0x040050F4 RID: 20724
	public KAWidget _UISingleTimer;

	// Token: 0x040050F5 RID: 20725
	public KAWidget _UIMultiplierText;

	// Token: 0x040050F6 RID: 20726
	public string _FlashHexColor = "[FF0000]";

	// Token: 0x040050F7 RID: 20727
	public float _FlashDelay = 0.2f;

	// Token: 0x040050F8 RID: 20728
	public KAUIMenu _UIMultiTimerMenu;

	// Token: 0x040050F9 RID: 20729
	public KAWidget _UIMultiTimerTemplate;

	// Token: 0x040050FA RID: 20730
	public LocaleString _MultiplierSymbolText = new LocaleString("{0}x");

	// Token: 0x040050FE RID: 20734
	[SerializeField]
	private UITable m_UITable;

}
