using System;
using System.Collections.Generic;
using System.Xml.Serialization;

// Token: 0x020007AF RID: 1967
[XmlRoot(ElementName = "IPSM", Namespace = "", IsNullable = false)]
[Serializable]
public class ItemPossibleStatsMap
{
	// Token: 0x170004C1 RID: 1217
	// (get) Token: 0x0600310C RID: 12556 RVA: 0x00024012 File Offset: 0x00022212
	// (set) Token: 0x0600310D RID: 12557 RVA: 0x0002401A File Offset: 0x0002221A
	[XmlElement(ElementName = "IID", IsNullable = false)]
	public int ItemID { get; set; }

	// Token: 0x170004C2 RID: 1218
	// (get) Token: 0x0600310E RID: 12558 RVA: 0x00024023 File Offset: 0x00022223
	// (set) Token: 0x0600310F RID: 12559 RVA: 0x0002402B File Offset: 0x0002222B
	[XmlElement(ElementName = "SC", IsNullable = false)]
	public int ItemStatsCount { get; set; }

	// Token: 0x170004C3 RID: 1219
	// (get) Token: 0x06003110 RID: 12560 RVA: 0x00024034 File Offset: 0x00022234
	// (set) Token: 0x06003111 RID: 12561 RVA: 0x0002403C File Offset: 0x0002223C
	[XmlElement(ElementName = "SID", IsNullable = false)]
	public int SetID { get; set; }

	// Token: 0x170004C4 RID: 1220
	// (get) Token: 0x06003112 RID: 12562 RVA: 0x00024045 File Offset: 0x00022245
	// (set) Token: 0x06003113 RID: 12563 RVA: 0x0002404D File Offset: 0x0002224D
	[XmlElement(ElementName = "SS", IsNullable = false)]
	public List<Stat> Stats { get; set; }
}
