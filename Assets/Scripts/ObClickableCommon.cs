using System;
using UnityEngine;

// Token: 0x0200100E RID: 4110
public class ObClickableCommon : ObClickable
{
	

	// Token: 0x040064DE RID: 25822
	public int _StoreID;

	// Token: 0x040064DF RID: 25823
	public StoreLoader.Selection _CoinsStoreInfo;

	// Token: 0x040064E0 RID: 25824
	public int _ItemID;

	// Token: 0x040064E1 RID: 25825
	public int _RedeemTicketItemID;

	// Token: 0x040064E2 RID: 25826
	public bool _ForMembersOnly;

	// Token: 0x040064E3 RID: 25827
	public bool _AllowMultiple;

	// Token: 0x040064E4 RID: 25828
	public LocaleString _BecomeAMemberText = new LocaleString("You need to become a member to interact with this item.");

	// Token: 0x040064E5 RID: 25829
	public LocaleString _PurchaseItemText = new LocaleString("Would you like to purchase this object for xxxx gems?");

	// Token: 0x040064E6 RID: 25830
	public LocaleString _BuyFundsText = new LocaleString("Would you like to buy funds?");

	// Token: 0x040064E7 RID: 25831
	public LocaleString _ItemPurchaseFailedText = new LocaleString("Item purchase failed.");

	// Token: 0x040064E8 RID: 25832
	public LocaleString _ItemPurchaseSuccessText = new LocaleString("Item purchased! Please check your inventory.");

	// Token: 0x040064E9 RID: 25833
	public LocaleString _PointLockedText = new LocaleString("You need to have {{Points}} points to buy this {{Item}}.");

	
}
