using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace JSGames.UI
{
	// Token: 0x02001B54 RID: 6996
	public class UIUpsell : UI
	{
		// Token: 0x0400A882 RID: 43138
		public LocaleString pUpsellText;

		// Token: 0x0400A883 RID: 43139
		public int pUpsellItemID;

		// Token: 0x0400A884 RID: 43140
		public int pUpsellItemStoreID;

		// Token: 0x0400A886 RID: 43142
		public InputField _TxtQuantityInput;

		// Token: 0x0400A887 RID: 43143
		public Action<bool, int> OnClose;

		// Token: 0x0400A888 RID: 43144
		public LocaleString _CurrentAmtText = new LocaleString("{0} needed: {1}");

		// Token: 0x0400A889 RID: 43145
		public int pUpsellCurrentItemAmount;

		// Token: 0x0400A88A RID: 43146
		[SerializeField]
		private UIWidget m_TxtCurrentAmt;

		// Token: 0x0400A88C RID: 43148
		[SerializeField]
		private UIWidget m_TxtDialog;

		// Token: 0x0400A88D RID: 43149
		[SerializeField]
		private UIWidget m_TotalPrice;

		// Token: 0x0400A88E RID: 43150
		[SerializeField]
		private UIWidget m_BtnNegative;

		// Token: 0x0400A88F RID: 43151
		[SerializeField]
		private UIWidget m_BtnPositive;

		// Token: 0x0400A890 RID: 43152
		[SerializeField]
		private UIWidget m_BtnBuy;

		// Token: 0x0400A891 RID: 43153
		[SerializeField]
		private UIWidget m_BtnClose;
	}
}
