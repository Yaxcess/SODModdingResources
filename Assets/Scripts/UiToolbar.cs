using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

// Token: 0x02000D9F RID: 3487
public class UiToolbar : KAUI
{
	// Token: 0x14000050 RID: 80
	// (add) Token: 0x060054BA RID: 21690 RVA: 0x00244704 File Offset: 0x00242904
	// (remove) Token: 0x060054BB RID: 21691 RVA: 0x00244738 File Offset: 0x00242938
	public static event UiToolbar.OnAvatarUpdated AvatarUpdated;

	// Token: 0x04005579 RID: 21881
	public Vector3 _PicturePositionOffset = new Vector3(0.05f, 0.5f, 0.5f);

	// Token: 0x0400557A RID: 21882
	public Vector3 _PictureLookAtOffset = new Vector3(0.05f, 0.8f, 0f);

	// Token: 0x0400557E RID: 21886
	public Color _MaskColor = new Color(0.5f, 0.5f, 0.5f, 0.5f);

	// Token: 0x0400557F RID: 21887
	public int _CompassItemID = 12978;

	// Token: 0x04005580 RID: 21888
	public string _BackBtnLoadLevel = "";

	// Token: 0x04005581 RID: 21889
	public string _BackBtnMarker = "";

	// Token: 0x04005582 RID: 21890
	public int _BackBtnOffset = 100;

	// Token: 0x04005583 RID: 21891
	public GameObject _UiMessageLog;

	// Token: 0x04005584 RID: 21892
	public GameObject _UiChatHistoryMobile;

	// Token: 0x04005585 RID: 21893
	public GameObject _UiChatHistory;

	// Token: 0x04005586 RID: 21894
	public List<UiChatHistory.MessageAction> _MessageActions;

	// Token: 0x04005587 RID: 21895
	public UiAvatarCSM _UiAvatarCSM;

	// Token: 0x04005588 RID: 21896
	public KAUI[] _UiToolbars;

	// Token: 0x04005589 RID: 21897
	[NonSerialized]
	public CoIdleManager mIdleMgr;

	// Token: 0x0400558A RID: 21898
	public TextAsset _TutorialTextAsset;

	// Token: 0x0400558B RID: 21899
	public string _LongIntro;

	// Token: 0x0400558C RID: 21900
	public string _ShortIntro;

	// Token: 0x0400558D RID: 21901
	public string _RenewMemberLogEventText = "RenewMemberFromExpiryWarning";

	// Token: 0x0400558E RID: 21902
	public LocaleString _MembershipRenewText = new LocaleString("Membership expires soon! Renew now");

	// Token: 0x0400558F RID: 21903
	public LocaleString _MembershipLastDayText = new LocaleString("Membership expires today! Renew now");

	// Token: 0x04005590 RID: 21904
	public LocaleString _WarningDBText = new LocaleString("Do you want to quit?");

	// Token: 0x04005591 RID: 21905
	public string _WorldMapBundle = "";

	// Token: 0x04005592 RID: 21906
	public string _QuestBranchBundle = "";

	// Token: 0x04005593 RID: 21907
	public UiSceneMap _SceneMap;

	// Token: 0x04005594 RID: 21908
	public string _SceneMapBGTextureBundle = "RS_DATA/AniDWDragonsMapBerk.Unity3d/AniDWDragonsMapBerk";

	// Token: 0x04005595 RID: 21909
	[NonSerialized]
	public bool pAutoExit;

	// Token: 0x04005596 RID: 21910
	public StoreLoader.Selection _CoinsStoreInfo;

	// Token: 0x04005597 RID: 21911
	public string _Store = "Player Equipment";

	// Token: 0x04005598 RID: 21912
	public string _StoreCategory = "";

	// Token: 0x04005599 RID: 21913
	public int _InventoryCategory = -1;

	// Token: 0x0400559A RID: 21914
	public List<UiToolbar.BuyTaskStoreMapping> _BuyTaskStoreMapping;

	// Token: 0x0400559B RID: 21915
	public UiPetMeter _UiPetMeter;

	// Token: 0x0400559C RID: 21916
	[Header("Glow values")]
	public float _GlowFlashTime = 5f;

	// Token: 0x0400559D RID: 21917
	public float _GlowFlashInterval = 0.2f;

	public UIWidget[] _GlowColorTintChildList;

	// Token: 0x040055C7 RID: 21959
	public List<UiToolbar.RewardMultiplierUI> RewardMultiplierUIs = new List<UiToolbar.RewardMultiplierUI>();

	// Token: 0x02000DA0 RID: 3488
	// (Invoke) Token: 0x060054F8 RID: 21752
	public delegate void OnAvatarUpdated();

	// Token: 0x02000DA1 RID: 3489
	[Serializable]
	public class BuyTaskStoreMapping
	{
		// Token: 0x040055C8 RID: 21960
		public int _TaskID;

		// Token: 0x040055C9 RID: 21961
		public int _StoreID;

		// Token: 0x040055CA RID: 21962
		public int _CategoryID;
	}

	// Token: 0x02000DA2 RID: 3490
	[Serializable]
	public class RewardMultiplierUI
	{
		// Token: 0x040055CB RID: 21963
		public int _PointType;

		// Token: 0x040055CC RID: 21964
		public UIRewardMultiplier _UI;
	}
}
