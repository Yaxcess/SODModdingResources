using System;
using System.Xml.Serialization;

// Token: 0x020008B9 RID: 2233
[XmlRoot(ElementName = "UserItem", Namespace = "")]
[Serializable]
public class UserItemData
{
	// Token: 0x170005C2 RID: 1474
	// (get) Token: 0x06003593 RID: 13715 RVA: 0x000264C7 File Offset: 0x000246C7
	// (set) Token: 0x06003594 RID: 13716 RVA: 0x000264CF File Offset: 0x000246CF
	[XmlElement(ElementName = "iid")]
	public int ItemID { get; set; }

	// Token: 0x170005C3 RID: 1475
	// (get) Token: 0x06003595 RID: 13717 RVA: 0x000264D8 File Offset: 0x000246D8
	// (set) Token: 0x06003596 RID: 13718 RVA: 0x000264E0 File Offset: 0x000246E0
	[XmlElement(ElementName = "md", IsNullable = true)]
	public DateTime? ModifiedDate { get; set; }

	// Token: 0x170005C4 RID: 1476
	// (get) Token: 0x06003597 RID: 13719 RVA: 0x000264E9 File Offset: 0x000246E9
	// (set) Token: 0x06003598 RID: 13720 RVA: 0x000264F1 File Offset: 0x000246F1
	[XmlElement(ElementName = "uia", IsNullable = true)]
	public PairData UserItemAttributes { get; set; }

	// Token: 0x170005C5 RID: 1477
	// (get) Token: 0x06003599 RID: 13721 RVA: 0x000264FA File Offset: 0x000246FA
	// (set) Token: 0x0600359A RID: 13722 RVA: 0x00026502 File Offset: 0x00024702
	[XmlElement(ElementName = "iss", IsNullable = true)]
	public ItemStat[] ItemStats { get; set; }

	// Token: 0x170005C6 RID: 1478
	// (get) Token: 0x0600359B RID: 13723 RVA: 0x0002650B File Offset: 0x0002470B
	// (set) Token: 0x0600359C RID: 13724 RVA: 0x00026513 File Offset: 0x00024713
	[XmlElement(ElementName = "IT", IsNullable = true)]
	public ItemTier? ItemTier { get; set; }

	// Token: 0x170005C7 RID: 1479
	// (get) Token: 0x0600359D RID: 13725 RVA: 0x0002651C File Offset: 0x0002471C
	// (set) Token: 0x0600359E RID: 13726 RVA: 0x00026524 File Offset: 0x00024724
	[XmlElement(ElementName = "cd", IsNullable = true)]
	public DateTime? CreatedDate { get; set; }

	// Token: 0x170005C8 RID: 1480
	// (get) Token: 0x0600359F RID: 13727 RVA: 0x0002652D File Offset: 0x0002472D
	public bool pIsBattleReady
	{
		get
		{
			return this.ItemStats != null && this.ItemStats.Length != 0;
		}
	}

	// Token: 0x040036F8 RID: 14072
	[XmlElement(ElementName = "uiid")]
	public int UserInventoryID;

	// Token: 0x040036FA RID: 14074
	[XmlElement(ElementName = "q")]
	public int Quantity;

	// Token: 0x040036FB RID: 14075
	[XmlElement(ElementName = "u")]
	public int Uses;

	// Token: 0x040036FC RID: 14076
	[XmlElement(ElementName = "i")]
	public ItemData Item;
}
