using System;
using System.Xml.Serialization;

// Token: 0x020007A6 RID: 1958
[XmlRoot(ElementName = "ItemStateCriteriaConsumable", Namespace = "")]
[Serializable]
public class ItemStateCriteriaConsumable : ItemStateCriteria
{
	// Token: 0x040030E2 RID: 12514
	[XmlElement(ElementName = "ItemID")]
	public int ItemID;

	// Token: 0x040030E3 RID: 12515
	[XmlElement(ElementName = "ConsumeUses")]
	public bool ConsumeUses;

	// Token: 0x040030E4 RID: 12516
	[XmlElement(ElementName = "Amount")]
	public int Amount;
}
