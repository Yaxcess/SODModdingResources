using System;
using System.Xml.Serialization;

// Token: 0x020007B5 RID: 1973
[XmlRoot(ElementName = "SRM", Namespace = "", IsNullable = false)]
[Serializable]
public class StatRangeMap
{
	// Token: 0x170004D4 RID: 1236
	// (get) Token: 0x06003136 RID: 12598 RVA: 0x00024155 File Offset: 0x00022355
	// (set) Token: 0x06003137 RID: 12599 RVA: 0x0002415D File Offset: 0x0002235D
	[XmlElement(ElementName = "ISID", IsNullable = false)]
	public int ItemStatsID { get; set; }

	// Token: 0x170004D5 RID: 1237
	// (get) Token: 0x06003138 RID: 12600 RVA: 0x00024166 File Offset: 0x00022366
	// (set) Token: 0x06003139 RID: 12601 RVA: 0x0002416E File Offset: 0x0002236E
	[XmlElement(ElementName = "ISN", IsNullable = false)]
	public string ItemStatsName { get; set; }

	// Token: 0x170004D6 RID: 1238
	// (get) Token: 0x0600313A RID: 12602 RVA: 0x00024177 File Offset: 0x00022377
	// (set) Token: 0x0600313B RID: 12603 RVA: 0x0002417F File Offset: 0x0002237F
	[XmlElement(ElementName = "ITID", IsNullable = false)]
	public int ItemTierID { get; set; }

	// Token: 0x170004D7 RID: 1239
	// (get) Token: 0x0600313C RID: 12604 RVA: 0x00024188 File Offset: 0x00022388
	// (set) Token: 0x0600313D RID: 12605 RVA: 0x00024190 File Offset: 0x00022390
	[XmlElement(ElementName = "SR", IsNullable = false)]
	public int StartRange { get; set; }

	// Token: 0x170004D8 RID: 1240
	// (get) Token: 0x0600313E RID: 12606 RVA: 0x00024199 File Offset: 0x00022399
	// (set) Token: 0x0600313F RID: 12607 RVA: 0x000241A1 File Offset: 0x000223A1
	[XmlElement(ElementName = "ER", IsNullable = false)]
	public int EndRange { get; set; }
}
