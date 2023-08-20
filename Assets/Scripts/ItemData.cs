using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

// Token: 0x02000793 RID: 1939
[XmlRoot(ElementName = "I", Namespace = "", IsNullable = true)]
public class ItemData
{
	// Token: 0x1700049B RID: 1179
	// (get) Token: 0x0600308B RID: 12427 RVA: 0x00023C23 File Offset: 0x00021E23
	// (set) Token: 0x0600308C RID: 12428 RVA: 0x00023C2B File Offset: 0x00021E2B
	[XmlElement(ElementName = "is")]
	public List<ItemState> ItemStates { get; set; }

	// Token: 0x1700049C RID: 1180
	// (get) Token: 0x0600308D RID: 12429 RVA: 0x00023C34 File Offset: 0x00021E34
	// (set) Token: 0x0600308E RID: 12430 RVA: 0x00023C3C File Offset: 0x00021E3C
	[XmlElement(ElementName = "ir", IsNullable = true)]
	public ItemRarity? ItemRarity { get; set; }

	// Token: 0x1700049D RID: 1181
	// (get) Token: 0x0600308F RID: 12431 RVA: 0x00023C45 File Offset: 0x00021E45
	// (set) Token: 0x06003090 RID: 12432 RVA: 0x00023C4D File Offset: 0x00021E4D
	[XmlElement(ElementName = "ipsm", IsNullable = true)]
	public ItemPossibleStatsMap PossibleStatsMap { get; set; }

	// Token: 0x1700049E RID: 1182
	// (get) Token: 0x06003091 RID: 12433 RVA: 0x00023C56 File Offset: 0x00021E56
	// (set) Token: 0x06003092 RID: 12434 RVA: 0x00023C5E File Offset: 0x00021E5E
	[XmlElement(ElementName = "ism", IsNullable = true)]
	public ItemStatsMap ItemStatsMap { get; set; }

	// Token: 0x1700049F RID: 1183
	// (get) Token: 0x06003093 RID: 12435 RVA: 0x00023C67 File Offset: 0x00021E67
	// (set) Token: 0x06003094 RID: 12436 RVA: 0x00023C6F File Offset: 0x00021E6F
	[XmlElement(ElementName = "iscs", IsNullable = true)]
	public ItemSaleConfig[] ItemSaleConfigs { get; set; }

	// Token: 0x170004A0 RID: 1184
	// (get) Token: 0x06003095 RID: 12437 RVA: 0x00023C78 File Offset: 0x00021E78
	// (set) Token: 0x06003096 RID: 12438 RVA: 0x00023C80 File Offset: 0x00021E80
	[XmlElement(ElementName = "bp", IsNullable = true)]
	public BluePrint BluePrint { get; set; }

	// Token: 0x170004A1 RID: 1185
	// (get) Token: 0x06003097 RID: 12439 RVA: 0x00023C89 File Offset: 0x00021E89
	public RsResourceLoadEvent pLoadBundleItemsState
	{
		get
		{
			return this.mLoadBundleItemsState;
		}
	}

	// Token: 0x170004A2 RID: 1186
	// (get) Token: 0x06003098 RID: 12440 RVA: 0x00023C91 File Offset: 0x00021E91
	public List<ItemData> pBundledItems
	{
		get
		{
			return this.mBundledItems;
		}
	}

	// Token: 0x170004A3 RID: 1187
	// (get) Token: 0x06003099 RID: 12441 RVA: 0x00023C99 File Offset: 0x00021E99
	public static List<ItemData.ItemDataUserData> pLoadingList
	{
		get
		{
			return ItemData.mLoadingList;
		}
	}

	

	

	
	

	// Token: 0x04003081 RID: 12417
	[XmlElement(ElementName = "an")]
	public string AssetName;

	// Token: 0x04003082 RID: 12418
	[XmlElement(ElementName = "at", IsNullable = true)]
	public ItemAttribute[] Attribute;

	// Token: 0x04003083 RID: 12419
	[XmlElement(ElementName = "c")]
	public ItemDataCategory[] Category;

	// Token: 0x04003084 RID: 12420
	[XmlElement(ElementName = "ct")]
	public int Cost;

	// Token: 0x04003085 RID: 12421
	[XmlElement(ElementName = "ct2")]
	public int CashCost;

	// Token: 0x04003086 RID: 12422
	[XmlElement(ElementName = "cp")]
	public int CreativePoints;

	// Token: 0x04003087 RID: 12423
	[XmlElement(ElementName = "d")]
	public string Description;

	// Token: 0x04003088 RID: 12424
	[XmlElement(ElementName = "icn")]
	public string IconName;

	// Token: 0x04003089 RID: 12425
	[XmlElement(ElementName = "im")]
	public int InventoryMax;

	// Token: 0x0400308A RID: 12426
	[XmlElement(ElementName = "id")]
	public int ItemID;

	// Token: 0x0400308B RID: 12427
	[XmlElement(ElementName = "itn")]
	public string ItemName;

	// Token: 0x0400308C RID: 12428
	[XmlElement(ElementName = "itnp")]
	public string ItemNamePlural;

	// Token: 0x0400308D RID: 12429
	[XmlElement(ElementName = "l")]
	public bool Locked;

	// Token: 0x0400308E RID: 12430
	[XmlElement(ElementName = "g", IsNullable = true)]
	public string Geometry2;

	// Token: 0x0400308F RID: 12431
	[XmlElement(ElementName = "ro", IsNullable = true)]
	public ItemDataRollover Rollover;

	// Token: 0x04003090 RID: 12432
	[XmlElement(ElementName = "rid", IsNullable = true)]
	public int? RankId;

	// Token: 0x04003091 RID: 12433
	[XmlElement(ElementName = "r")]
	public ItemDataRelationship[] Relationship;

	// Token: 0x04003092 RID: 12434
	[XmlElement(ElementName = "s")]
	public bool Stackable;

	// Token: 0x04003093 RID: 12435
	[XmlElement(ElementName = "as")]
	public bool AllowStacking;

	// Token: 0x04003094 RID: 12436
	[XmlElement(ElementName = "sf")]
	public int SaleFactor;

	// Token: 0x04003095 RID: 12437
	[XmlElement(ElementName = "t")]
	public ItemDataTexture[] Texture;

	// Token: 0x04003096 RID: 12438
	[XmlElement(ElementName = "u")]
	public int Uses;

	// Token: 0x04003098 RID: 12440
	[XmlElement(ElementName = "av")]
	public ItemAvailability[] Availability;

	// Token: 0x04003099 RID: 12441
	[XmlElement(ElementName = "rtid")]
	public int RewardTypeID;

	// Token: 0x0400309A RID: 12442
	[XmlElement(ElementName = "p", IsNullable = true)]
	public int? Points;

	// Token: 0x040030A0 RID: 12448
	private static Dictionary<int, ItemData> mItemDataCache = new Dictionary<int, ItemData>();

	// Token: 0x040030A1 RID: 12449
	private static List<ItemData.ItemDataUserData> mLoadingList = new List<ItemData.ItemDataUserData>();

	// Token: 0x040030A2 RID: 12450
	private RsResourceLoadEvent mLoadBundleItemsState;

	// Token: 0x040030A3 RID: 12451
	private ItemDataListEventHandler mLoadBundleItemCallback;

	// Token: 0x040030A4 RID: 12452
	private List<ItemData> mBundledItems;

	// Token: 0x040030A5 RID: 12453
	[XmlIgnore]
	public bool IsNew;

	// Token: 0x040030A6 RID: 12454
	[XmlIgnore]
	public int PopularRank = -1;

	// Token: 0x040030A7 RID: 12455
	[XmlIgnore]
	public List<ItemsInStoreDataSale> SaleList;

	// Token: 0x040030A8 RID: 12456
	[XmlIgnore]
	public List<ItemsInStoreDataSale> MemberSaleList;

	// Token: 0x040030A9 RID: 12457
	[XmlIgnore]
	private bool mSetSaleCheat;

	// Token: 0x02000794 RID: 1940
	public class ItemSale
	{
		// Token: 0x040030AA RID: 12458
		public float mModifier;

		// Token: 0x040030AB RID: 12459
		public DateTime mEndDate = DateTime.MaxValue;

		// Token: 0x040030AC RID: 12460
		public string mIcon = string.Empty;
	}

	// Token: 0x02000795 RID: 1941
	public class ItemDataUserData
	{
		// Token: 0x040030AD RID: 12461
		public int mID;

		// Token: 0x040030AE RID: 12462
		public ItemDataEventHandler mCallback;

		// Token: 0x040030AF RID: 12463
		public object mUserData;
	}
}
