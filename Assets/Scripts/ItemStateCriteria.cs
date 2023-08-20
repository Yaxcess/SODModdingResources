using System;
using System.Xml.Serialization;

// Token: 0x0200079E RID: 1950
[XmlRoot(ElementName = "ItemStateCriteria", Namespace = "")]
[XmlInclude(typeof(ItemStateCriteriaLength))]
[XmlInclude(typeof(ItemStateCriteriaConsumable))]
[XmlInclude(typeof(ItemStateCriteriaReplenishable))]
[XmlInclude(typeof(ItemStateCriteriaOverride))]
[XmlInclude(typeof(ItemStateCriteriaSpeedUpItem))]
[XmlInclude(typeof(ItemStateCriteriaExpiry))]
[Serializable]
public class ItemStateCriteria
{
	// Token: 0x040030C9 RID: 12489
	[XmlElement(ElementName = "Type")]
	public ItemStateCriteriaType Type;
}
