using System;
using System.Xml.Serialization;

// Token: 0x020007F8 RID: 2040
public enum PrerequisiteRequiredType
{
	// Token: 0x04003258 RID: 12888
	[XmlEnum("1")]
	Member = 1,
	// Token: 0x04003259 RID: 12889
	[XmlEnum("2")]
	Accept,
	// Token: 0x0400325A RID: 12890
	[XmlEnum("3")]
	Mission,
	// Token: 0x0400325B RID: 12891
	[XmlEnum("4")]
	Rank,
	// Token: 0x0400325C RID: 12892
	[XmlEnum("5")]
	DateRange,
	// Token: 0x0400325D RID: 12893
	[XmlEnum("7")]
	Item = 7,
	// Token: 0x0400325E RID: 12894
	[XmlEnum("8")]
	Event
}
