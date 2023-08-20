using System;
using System.Collections.Generic;
using System.Xml.Serialization;

// Token: 0x020007B6 RID: 1974
[XmlRoot(ElementName = "STAT", Namespace = "", IsNullable = false)]
[Serializable]
public class Stat
{
	// Token: 0x170004D9 RID: 1241
	// (get) Token: 0x06003141 RID: 12609 RVA: 0x000241AA File Offset: 0x000223AA
	// (set) Token: 0x06003142 RID: 12610 RVA: 0x000241B2 File Offset: 0x000223B2
	[XmlElement(ElementName = "IID", IsNullable = false)]
	public int ItemID { get; set; }

	// Token: 0x170004DA RID: 1242
	// (get) Token: 0x06003143 RID: 12611 RVA: 0x000241BB File Offset: 0x000223BB
	// (set) Token: 0x06003144 RID: 12612 RVA: 0x000241C3 File Offset: 0x000223C3
	[XmlElement(ElementName = "ISID", IsNullable = false)]
	public int ItemStatsID { get; set; }

	// Token: 0x170004DB RID: 1243
	// (get) Token: 0x06003145 RID: 12613 RVA: 0x000241CC File Offset: 0x000223CC
	// (set) Token: 0x06003146 RID: 12614 RVA: 0x000241D4 File Offset: 0x000223D4
	[XmlElement(ElementName = "SID", IsNullable = false)]
	public int SetID { get; set; }

	// Token: 0x170004DC RID: 1244
	// (get) Token: 0x06003147 RID: 12615 RVA: 0x000241DD File Offset: 0x000223DD
	// (set) Token: 0x06003148 RID: 12616 RVA: 0x000241E5 File Offset: 0x000223E5
	[XmlElement(ElementName = "PROB", IsNullable = false)]
	public int Probability { get; set; }

	// Token: 0x170004DD RID: 1245
	// (get) Token: 0x06003149 RID: 12617 RVA: 0x000241EE File Offset: 0x000223EE
	// (set) Token: 0x0600314A RID: 12618 RVA: 0x000241F6 File Offset: 0x000223F6
	[XmlElement(ElementName = "ISRM", IsNullable = false)]
	public List<StatRangeMap> ItemStatsRangeMaps { get; set; }
}
