using System;
using System.Collections.Generic;
using System.Xml.Serialization;

// Token: 0x02000712 RID: 1810
[XmlRoot(ElementName = "pir", Namespace = "")]
[Serializable]
public class PrizeItemResponse
{
	// Token: 0x17000433 RID: 1075
	// (get) Token: 0x06002F08 RID: 12040 RVA: 0x000231A2 File Offset: 0x000213A2
	// (set) Token: 0x06002F09 RID: 12041 RVA: 0x000231AA File Offset: 0x000213AA
	[XmlElement(ElementName = "i")]
	public int ItemID { get; set; }

	// Token: 0x17000434 RID: 1076
	// (get) Token: 0x06002F0A RID: 12042 RVA: 0x000231B3 File Offset: 0x000213B3
	// (set) Token: 0x06002F0B RID: 12043 RVA: 0x000231BB File Offset: 0x000213BB
	[XmlElement(ElementName = "pi")]
	public int PrizeItemID { get; set; }

	// Token: 0x17000435 RID: 1077
	// (get) Token: 0x06002F0C RID: 12044 RVA: 0x000231C4 File Offset: 0x000213C4
	// (set) Token: 0x06002F0D RID: 12045 RVA: 0x000231CC File Offset: 0x000213CC
	[XmlElement(ElementName = "pis", IsNullable = true)]
	public List<ItemData> MysteryPrizeItems { get; set; }
}
