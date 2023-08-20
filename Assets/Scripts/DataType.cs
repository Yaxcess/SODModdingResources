using System;
using System.Xml.Serialization;

// Token: 0x02000841 RID: 2113
[Flags]
public enum DataType
{
	// Token: 0x04003452 RID: 13394
	[XmlEnum("1")]
	BOOL = 1,
	// Token: 0x04003453 RID: 13395
	[XmlEnum("2")]
	BYTE = 2,
	// Token: 0x04003454 RID: 13396
	[XmlEnum("3")]
	CHAR = 3,
	// Token: 0x04003455 RID: 13397
	[XmlEnum("4")]
	DECIMAL = 4,
	// Token: 0x04003456 RID: 13398
	[XmlEnum("5")]
	DOUBLE = 5,
	// Token: 0x04003457 RID: 13399
	[XmlEnum("6")]
	FLOAT = 6,
	// Token: 0x04003458 RID: 13400
	[XmlEnum("7")]
	INT = 7,
	// Token: 0x04003459 RID: 13401
	[XmlEnum("8")]
	LONG = 8,
	// Token: 0x0400345A RID: 13402
	[XmlEnum("9")]
	SBYTE = 9,
	// Token: 0x0400345B RID: 13403
	[XmlEnum("10")]
	SHORT = 10,
	// Token: 0x0400345C RID: 13404
	[XmlEnum("11")]
	STRING = 11,
	// Token: 0x0400345D RID: 13405
	[XmlEnum("12")]
	UINT = 12,
	// Token: 0x0400345E RID: 13406
	[XmlEnum("13")]
	ULONG = 13,
	// Token: 0x0400345F RID: 13407
	[XmlEnum("14")]
	USHORT = 14
}
