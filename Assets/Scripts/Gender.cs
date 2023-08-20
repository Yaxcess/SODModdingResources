using System;
using System.Xml.Serialization;

// Token: 0x02000842 RID: 2114
[Flags]
public enum Gender
{
	// Token: 0x04003461 RID: 13409
	[XmlEnum("0")]
	Unknown = 0,
	// Token: 0x04003462 RID: 13410
	[XmlEnum("1")]
	Male = 1,
	// Token: 0x04003463 RID: 13411
	[XmlEnum("2")]
	Female = 2
}
