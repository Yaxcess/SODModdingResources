using System;
using System.Xml.Serialization;

// Token: 0x0200079F RID: 1951
[Serializable]
public enum ItemStateCriteriaType
{
	// Token: 0x040030CB RID: 12491
	[XmlEnum("1")]
	Length = 1,
	// Token: 0x040030CC RID: 12492
	[XmlEnum("2")]
	ConsumableItem,
	// Token: 0x040030CD RID: 12493
	[XmlEnum("3")]
	ReplenishableItem,
	// Token: 0x040030CE RID: 12494
	[XmlEnum("4")]
	SpeedUpItem,
	// Token: 0x040030CF RID: 12495
	[XmlEnum("5")]
	StateExpiry
}
