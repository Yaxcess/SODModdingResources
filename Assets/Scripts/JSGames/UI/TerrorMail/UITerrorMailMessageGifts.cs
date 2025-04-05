using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JSGames.UI.TerrorMail
{
	// Token: 0x02001B76 RID: 7030
	public class UITerrorMailMessageGifts : UIMessagePopulator
	{
		// Token: 0x0400A965 RID: 43365
		public UIMenu _GiftMenu;

		// Token: 0x0400A966 RID: 43366
		public InventoryTab _BattleReadyTab;

		// Token: 0x0400A967 RID: 43367
		public LocaleString _UpsellText = new LocaleString("Your gift cannot be claimed as your inventory is full!\nDo you want to purchase more slots?");

		// Token: 0x0400A968 RID: 43368
		public int _BackpackSlotUpsellItemID = 13717;

		// Token: 0x0400A969 RID: 43369
		public int _BackpackSlotUpsellItemStoreID = 91;

		public Texture _GemImage;

		// Token: 0x0400A96F RID: 43375
		public Texture _CoinImage;

		// Token: 0x0400A970 RID: 43376
		public UIWidget _ClaimBtn;

		// Token: 0x0400A971 RID: 43377
		public UIWidget _DeleteBtn;

		// Token: 0x0400A974 RID: 43380
		public Action<MessageInfo> OnClaim;
	}
}
