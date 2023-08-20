using System;
using System.Xml.Serialization;

// Token: 0x020007AE RID: 1966
[XmlRoot(ElementName = "ISM", Namespace = "", IsNullable = false)]
[Serializable]
public class ItemStatsMap
{
	// Token: 0x170004BE RID: 1214
	// (get) Token: 0x06003105 RID: 12549 RVA: 0x00023FDF File Offset: 0x000221DF
	// (set) Token: 0x06003106 RID: 12550 RVA: 0x00023FE7 File Offset: 0x000221E7
	[XmlElement(ElementName = "IID", IsNullable = false)]
	public int ItemID { get; set; }

	// Token: 0x170004BF RID: 1215
	// (get) Token: 0x06003107 RID: 12551 RVA: 0x00023FF0 File Offset: 0x000221F0
	// (set) Token: 0x06003108 RID: 12552 RVA: 0x00023FF8 File Offset: 0x000221F8
	[XmlElement(ElementName = "IT", IsNullable = false)]
	public ItemTier ItemTier { get; set; }

	// Token: 0x170004C0 RID: 1216
	// (get) Token: 0x06003109 RID: 12553 RVA: 0x00024001 File Offset: 0x00022201
	// (set) Token: 0x0600310A RID: 12554 RVA: 0x00024009 File Offset: 0x00022209
	[XmlElement(ElementName = "ISS", IsNullable = false)]
	public ItemStat[] ItemStats { get; set; }
}
