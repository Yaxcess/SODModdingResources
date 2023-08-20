using System;
using System.Xml.Serialization;

// Token: 0x020007BA RID: 1978
[XmlRoot(ElementName = "ISC", Namespace = "", IsNullable = true)]
[Serializable]
public class ItemSaleConfig
{
	// Token: 0x170004E2 RID: 1250
	// (get) Token: 0x06003155 RID: 12629 RVA: 0x00024243 File Offset: 0x00022443
	// (set) Token: 0x06003156 RID: 12630 RVA: 0x0002424B File Offset: 0x0002244B
	[XmlElement(ElementName = "IID", IsNullable = true)]
	public int? ItemID { get; set; }

	// Token: 0x170004E3 RID: 1251
	// (get) Token: 0x06003157 RID: 12631 RVA: 0x00024254 File Offset: 0x00022454
	// (set) Token: 0x06003158 RID: 12632 RVA: 0x0002425C File Offset: 0x0002245C
	[XmlElement(ElementName = "CID", IsNullable = true)]
	public int? CategoryID { get; set; }

	// Token: 0x170004E4 RID: 1252
	// (get) Token: 0x06003159 RID: 12633 RVA: 0x00024265 File Offset: 0x00022465
	// (set) Token: 0x0600315A RID: 12634 RVA: 0x0002426D File Offset: 0x0002246D
	[XmlElement(ElementName = "RID", IsNullable = true)]
	public int? RarityID { get; set; }

	// Token: 0x170004E5 RID: 1253
	// (get) Token: 0x0600315B RID: 12635 RVA: 0x00024276 File Offset: 0x00022476
	// (set) Token: 0x0600315C RID: 12636 RVA: 0x0002427E File Offset: 0x0002247E
	[XmlElement(ElementName = "QTY", IsNullable = false)]
	public int Quantity { get; set; }

	// Token: 0x170004E6 RID: 1254
	// (get) Token: 0x0600315D RID: 12637 RVA: 0x00024287 File Offset: 0x00022487
	// (set) Token: 0x0600315E RID: 12638 RVA: 0x0002428F File Offset: 0x0002248F
	[XmlElement(ElementName = "RIID", IsNullable = false)]
	public int RewardItemID { get; set; }
}
