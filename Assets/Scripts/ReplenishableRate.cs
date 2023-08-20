using System;
using System.Xml.Serialization;

// Token: 0x020007A4 RID: 1956
[XmlRoot(ElementName = "ReplenishableRate", Namespace = "")]
[Serializable]
public class ReplenishableRate
{
	// Token: 0x040030DB RID: 12507
	[XmlElement(ElementName = "Uses")]
	public int Uses;

	// Token: 0x040030DC RID: 12508
	[XmlElement(ElementName = "Rate")]
	public double Rate;

	// Token: 0x040030DD RID: 12509
	[XmlElement(ElementName = "MaxUses")]
	public int MaxUses;

	// Token: 0x040030DE RID: 12510
	[XmlElement(ElementName = "Rank", IsNullable = true)]
	public int? Rank;
}
