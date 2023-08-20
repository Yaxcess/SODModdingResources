using System;
using System.Xml.Serialization;

// Token: 0x020007B4 RID: 1972
public class BluePrintSpecification
{
	// Token: 0x170004CC RID: 1228
	// (get) Token: 0x06003125 RID: 12581 RVA: 0x000240CD File Offset: 0x000222CD
	// (set) Token: 0x06003126 RID: 12582 RVA: 0x000240D5 File Offset: 0x000222D5
	[XmlElement(ElementName = "BPSID", IsNullable = false)]
	public int BluePrintSpecID { get; set; }

	// Token: 0x170004CD RID: 1229
	// (get) Token: 0x06003127 RID: 12583 RVA: 0x000240DE File Offset: 0x000222DE
	// (set) Token: 0x06003128 RID: 12584 RVA: 0x000240E6 File Offset: 0x000222E6
	[XmlElement(ElementName = "BPIID", IsNullable = false)]
	public int BluePrintItemID { get; set; }

	// Token: 0x170004CE RID: 1230
	// (get) Token: 0x06003129 RID: 12585 RVA: 0x000240EF File Offset: 0x000222EF
	// (set) Token: 0x0600312A RID: 12586 RVA: 0x000240F7 File Offset: 0x000222F7
	[XmlElement(ElementName = "IID", IsNullable = true)]
	public int? ItemID { get; set; }

	// Token: 0x170004CF RID: 1231
	// (get) Token: 0x0600312B RID: 12587 RVA: 0x00024100 File Offset: 0x00022300
	// (set) Token: 0x0600312C RID: 12588 RVA: 0x00024108 File Offset: 0x00022308
	[XmlElement(ElementName = "CID", IsNullable = true)]
	public int? CategoryID { get; set; }

	// Token: 0x170004D0 RID: 1232
	// (get) Token: 0x0600312D RID: 12589 RVA: 0x00024111 File Offset: 0x00022311
	// (set) Token: 0x0600312E RID: 12590 RVA: 0x00024119 File Offset: 0x00022319
	[XmlElement(ElementName = "IR", IsNullable = true)]
	public ItemRarity? ItemRarity { get; set; }

	// Token: 0x170004D1 RID: 1233
	// (get) Token: 0x0600312F RID: 12591 RVA: 0x00024122 File Offset: 0x00022322
	// (set) Token: 0x06003130 RID: 12592 RVA: 0x0002412A File Offset: 0x0002232A
	[XmlElement(ElementName = "T", IsNullable = true)]
	public ItemTier? Tier { get; set; }

	// Token: 0x170004D2 RID: 1234
	// (get) Token: 0x06003131 RID: 12593 RVA: 0x00024133 File Offset: 0x00022333
	// (set) Token: 0x06003132 RID: 12594 RVA: 0x0002413B File Offset: 0x0002233B
	[XmlElement(ElementName = "QTY", IsNullable = false)]
	public int Quantity { get; set; }

	// Token: 0x170004D3 RID: 1235
	// (get) Token: 0x06003133 RID: 12595 RVA: 0x00024144 File Offset: 0x00022344
	// (set) Token: 0x06003134 RID: 12596 RVA: 0x0002414C File Offset: 0x0002234C
	[XmlElement(ElementName = "ST", IsNullable = false)]
	public SpecificationType SpecificationType { get; set; }
}
