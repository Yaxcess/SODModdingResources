using System;
using System.Xml.Serialization;

// Token: 0x020007AB RID: 1963
[XmlRoot(ElementName = "IT")]
[Serializable]
public enum ItemTier
{
	// Token: 0x040030F7 RID: 12535
	[XmlEnum("1")]
	Tier1 = 1,
	// Token: 0x040030F8 RID: 12536
	[XmlEnum("2")]
	Tier2,
	// Token: 0x040030F9 RID: 12537
	[XmlEnum("3")]
	Tier3,
	// Token: 0x040030FA RID: 12538
	[XmlEnum("4")]
	Tier4
}
