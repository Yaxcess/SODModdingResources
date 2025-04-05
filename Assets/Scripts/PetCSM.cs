using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x020010EB RID: 4331
public class PetCSM : ObContextSensitive
{
	// Token: 0x04006942 RID: 26946
	public ContextSensitiveState[] _Menus;

	// Token: 0x04006943 RID: 26947
	public string _FeedInventoryCSItemName = "Feed";

	// Token: 0x04006944 RID: 26948
	public string _CSIconTemplateName = "IconTemplate";

	// Token: 0x04006945 RID: 26949
	public string _CSFeedItemTemplateName = "FeedItemTemplate";

	// Token: 0x04006946 RID: 26950
	public LocaleString _StoreCSItemName = new LocaleString("Store");

	// Token: 0x04006947 RID: 26951
	public string _StoreIconName = "IcoDWDragonsHUDStore";

	// Token: 0x04006948 RID: 26952
	public string _StableCSItemName = "Stable";

	// Token: 0x04006949 RID: 26953
	public string _AgeUpCSItemName = "AgeUp";

	// Token: 0x0400694A RID: 26954
	public string _CustomizeCSItemName = "Customize";

	// Token: 0x0400694B RID: 26955
	public LocaleString _FullEnergyText = new LocaleString("Your dragon's full. You cannot feed it anymore.");

	// Token: 0x0400694C RID: 26956
	public int _EatFishAchievementTaskID = 177;

	// Token: 0x0400694D RID: 26957
	public int _DragonsFeedCategoryID = 415;

	// Token: 0x0400694E RID: 26958
	public int _FishCategoryID = 408;

	// Token: 0x0400694F RID: 26959
	public GameObject _FeedFX;

	// Token: 0x04006950 RID: 26960
	public string _FeedAnim = "Gulp";

	// Token: 0x04006951 RID: 26961
	public StoreLoader.Selection _StoreInfo;

	// Token: 0x04006952 RID: 26962
	public List<PetCSM.ItemUseAchievement> _ItemUseAchievement;

	// Token: 0x04006953 RID: 26963
	public string _MultipleDragonTutorialName = "PfMultipleDragonsTutorialDO";

	// Token: 0x04006954 RID: 26964
	protected KAUIGenericDB mGenericDBUi;

	// Token: 0x04006955 RID: 26965
	private bool mIsFeedCSMOpened;

	// Token: 0x020010EC RID: 4332
	[Serializable]
	public class ItemUseAchievement
	{
		// Token: 0x04006956 RID: 26966
		public int _ItemID;

		// Token: 0x04006957 RID: 26967
		public int _AchievementID;

		// Token: 0x04006958 RID: 26968
		public bool _ShowReward;
	}
}
