using System;
using UnityEngine;

// Token: 0x0200116C RID: 4460
[Serializable]
public class PetNameChange
{
	// Token: 0x04006C35 RID: 27701
	public int _TicketStoreID = 93;

	// Token: 0x04006C36 RID: 27702
	public int _TicketItemID = 13370;

	// Token: 0x04006C37 RID: 27703
	[HideInInspector]
	public int mTicketCost;

	// Token: 0x04006C38 RID: 27704
	[HideInInspector]
	public RaisedPetData mPetData;

	// Token: 0x04006C39 RID: 27705
	[HideInInspector]
	public GameObject mMessageObject;

	// Token: 0x04006C3A RID: 27706
	public LocaleString _NotEnoughVCashText = new LocaleString("You don't have enough Gems to change name of your dragon. Do you want to buy more Gems?");

	// Token: 0x04006C3B RID: 27707
	public LocaleString _UseGemsForNameChangeText = new LocaleString("Dragon name change will cost you {cost} Gems. Do you want to continue?");

	// Token: 0x04006C3C RID: 27708
	public LocaleString _TicketPurchaseFailedText = new LocaleString("Transaction failed. Please try again.");
}
