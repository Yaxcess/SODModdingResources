using System;
using System.Xml.Serialization;

// Token: 0x020007B1 RID: 1969
[XmlRoot(ElementName = "BPDC", Namespace = "", IsNullable = true)]
[Serializable]
public class BluePrintDeductibleConfig
{
	// Token: 0x170004C8 RID: 1224
	// (get) Token: 0x0600311C RID: 12572 RVA: 0x00024089 File Offset: 0x00022289
	// (set) Token: 0x0600311D RID: 12573 RVA: 0x00024091 File Offset: 0x00022291
	[XmlElement(ElementName = "BPIID", IsNullable = false)]
	public int BluePrintItemID { get; set; }

	// Token: 0x170004C9 RID: 1225
	// (get) Token: 0x0600311E RID: 12574 RVA: 0x0002409A File Offset: 0x0002229A
	// (set) Token: 0x0600311F RID: 12575 RVA: 0x000240A2 File Offset: 0x000222A2
	[XmlElement(ElementName = "DT", IsNullable = false)]
	public DeductibleType DeductibleType { get; set; }

	// Token: 0x170004CA RID: 1226
	// (get) Token: 0x06003120 RID: 12576 RVA: 0x000240AB File Offset: 0x000222AB
	// (set) Token: 0x06003121 RID: 12577 RVA: 0x000240B3 File Offset: 0x000222B3
	[XmlElement(ElementName = "IID", IsNullable = true)]
	public int? ItemID { get; set; }

	// Token: 0x170004CB RID: 1227
	// (get) Token: 0x06003122 RID: 12578 RVA: 0x000240BC File Offset: 0x000222BC
	// (set) Token: 0x06003123 RID: 12579 RVA: 0x000240C4 File Offset: 0x000222C4
	[XmlElement(ElementName = "QTY", IsNullable = false)]
	public int Quantity { get; set; }
}
