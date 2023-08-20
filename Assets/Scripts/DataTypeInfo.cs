using System;
using System.Xml.Serialization;

// Token: 0x020007AC RID: 1964
[XmlRoot(ElementName = "DT")]
[Serializable]
public enum DataTypeInfo
{
	// Token: 0x040030FC RID: 12540
	[XmlEnum("I")]
	Int = 1,
	// Token: 0x040030FD RID: 12541
	[XmlEnum("2")]
	Float,
	// Token: 0x040030FE RID: 12542
	[XmlEnum("3")]
	Double,
	// Token: 0x040030FF RID: 12543
	[XmlEnum("4")]
	String
}
