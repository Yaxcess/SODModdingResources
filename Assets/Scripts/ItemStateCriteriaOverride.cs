using System;
using System.Xml.Serialization;

// Token: 0x020007A5 RID: 1957
[XmlRoot(ElementName = "ItemStateCriteriaOverride", Namespace = "")]
[Serializable]
public class ItemStateCriteriaOverride : ItemStateCriteria
{
	// Token: 0x170004B0 RID: 1200
	// (get) Token: 0x060030E2 RID: 12514 RVA: 0x00023EB9 File Offset: 0x000220B9
	// (set) Token: 0x060030E3 RID: 12515 RVA: 0x00023EC1 File Offset: 0x000220C1
	[XmlElement(ElementName = "ItemID")]
	public int ItemID { get; set; }

	// Token: 0x170004B1 RID: 1201
	// (get) Token: 0x060030E4 RID: 12516 RVA: 0x00023ECA File Offset: 0x000220CA
	// (set) Token: 0x060030E5 RID: 12517 RVA: 0x00023ED2 File Offset: 0x000220D2
	[XmlElement(ElementName = "ConsumeUses")]
	public bool ConsumeUses { get; set; }

	// Token: 0x170004B2 RID: 1202
	// (get) Token: 0x060030E6 RID: 12518 RVA: 0x00023EDB File Offset: 0x000220DB
	// (set) Token: 0x060030E7 RID: 12519 RVA: 0x00023EE3 File Offset: 0x000220E3
	[XmlElement(ElementName = "Amount")]
	public int Amount { get; set; }
}
