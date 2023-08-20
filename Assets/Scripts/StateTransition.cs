using System;
using System.Xml.Serialization;

// Token: 0x020007A1 RID: 1953
[Serializable]
public enum StateTransition
{
	// Token: 0x040030D2 RID: 12498
	[XmlEnum("1")]
	NextState = 1,
	// Token: 0x040030D3 RID: 12499
	[XmlEnum("2")]
	Completion,
	// Token: 0x040030D4 RID: 12500
	[XmlEnum("3")]
	Deletion,
	// Token: 0x040030D5 RID: 12501
	[XmlEnum("4")]
	InitialState,
	// Token: 0x040030D6 RID: 12502
	[XmlEnum("5")]
	Expired
}
