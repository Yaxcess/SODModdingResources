using System;
using System.Xml.Serialization;

// Token: 0x020007A8 RID: 1960
[XmlRoot(ElementName = "ItemStateCriteriaExpiry", Namespace = "")]
[Serializable]
public class ItemStateCriteriaExpiry : ItemStateCriteria
{
	// Token: 0x040030EC RID: 12524
	[XmlElement(ElementName = "Period")]
	public int Period;

	// Token: 0x040030ED RID: 12525
	[XmlElement(ElementName = "EndStateID")]
	public int EndStateID;
}
