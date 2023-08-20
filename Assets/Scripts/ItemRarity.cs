using System;
using System.Xml.Serialization;

// Token: 0x020007AA RID: 1962
[XmlRoot(ElementName = "IR")]
[Serializable]
public enum ItemRarity
{
	// Token: 0x040030F1 RID: 12529
	[XmlEnum("0")]
	NonBattleCommon,
	// Token: 0x040030F2 RID: 12530
	[XmlEnum("1")]
	Common,
	// Token: 0x040030F3 RID: 12531
	[XmlEnum("2")]
	Rare,
	// Token: 0x040030F4 RID: 12532
	[XmlEnum("3")]
	Epic,
	// Token: 0x040030F5 RID: 12533
	[XmlEnum("4")]
	Legendary
}
