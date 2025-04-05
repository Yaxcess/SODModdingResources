using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

namespace JSGames.UI
{
	// Token: 0x02001B4C RID: 6988
	public class UIOptions : UI
	{
		// Token: 0x0400A840 RID: 43072
		public UnityAction OnClosed;

		// Token: 0x0400A841 RID: 43073
		public LocaleString _ServerErrorTitleText = new LocaleString("Error");

		// Token: 0x0400A842 RID: 43074
		public UI _HotKeysPopUp;

		// Token: 0x0400A843 RID: 43075
		public UI _GraphicSettingsUI;

		// Token: 0x0400A844 RID: 43076
		public UIButton _BtnClose;

		// Token: 0x0400A845 RID: 43077
		public UIWidget _BtnCredits;

		// Token: 0x0400A846 RID: 43078
		public UIWidget _BtnRestorePurchase;

		// Token: 0x0400A847 RID: 43079
		public UIButton _BtnLogout;

		// Token: 0x0400A848 RID: 43080
		public UIToggleButton _BtnMusic;

		// Token: 0x0400A849 RID: 43081
		public UIToggleButton _BtnSound;

		// Token: 0x0400A84A RID: 43082
		public UIToggleButton _BtnFullScreen;

		// Token: 0x0400A84B RID: 43083
		public bool _CanGuestPurchase;

		// Token: 0x0400A84C RID: 43084
		public static Action ShowPurchaseRestoreDB;

		// Token: 0x0400A84D RID: 43085
		public static Action PurchaseRestore;
	}
}
