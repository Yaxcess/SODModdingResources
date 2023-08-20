using System;
using System.Xml.Serialization;

// Token: 0x020007A7 RID: 1959
[XmlRoot(ElementName = "ItemStateCriteriaSpeedUpItem", Namespace = "")]
public class ItemStateCriteriaSpeedUpItem : ItemStateCriteria
{
	// Token: 0x170004B3 RID: 1203
	// (get) Token: 0x060030EA RID: 12522 RVA: 0x00023EEC File Offset: 0x000220EC
	// (set) Token: 0x060030EB RID: 12523 RVA: 0x00023EF4 File Offset: 0x000220F4
	[XmlElement(ElementName = "ItemID")]
	public int ItemID { get; set; }

	// Token: 0x170004B4 RID: 1204
	// (get) Token: 0x060030EC RID: 12524 RVA: 0x00023EFD File Offset: 0x000220FD
	// (set) Token: 0x060030ED RID: 12525 RVA: 0x00023F05 File Offset: 0x00022105
	[XmlElement(ElementName = "ConsumeUses")]
	public bool ConsumeUses { get; set; }

	// Token: 0x170004B5 RID: 1205
	// (get) Token: 0x060030EE RID: 12526 RVA: 0x00023F0E File Offset: 0x0002210E
	// (set) Token: 0x060030EF RID: 12527 RVA: 0x00023F16 File Offset: 0x00022116
	[XmlElement(ElementName = "Amount")]
	public int Amount { get; set; }

	// Token: 0x170004B6 RID: 1206
	// (get) Token: 0x060030F0 RID: 12528 RVA: 0x00023F1F File Offset: 0x0002211F
	// (set) Token: 0x060030F1 RID: 12529 RVA: 0x00023F27 File Offset: 0x00022127
	[XmlElement(ElementName = "ChangeState")]
	public bool ChangeState { get; set; }

	// Token: 0x170004B7 RID: 1207
	// (get) Token: 0x060030F2 RID: 12530 RVA: 0x00023F30 File Offset: 0x00022130
	// (set) Token: 0x060030F3 RID: 12531 RVA: 0x00023F38 File Offset: 0x00022138
	[XmlElement(ElementName = "EndStateID")]
	public int EndStateID { get; set; }

	// Token: 0x170004B8 RID: 1208
	// (get) Token: 0x060030F4 RID: 12532 RVA: 0x00023F41 File Offset: 0x00022141
	// (set) Token: 0x060030F5 RID: 12533 RVA: 0x00023F49 File Offset: 0x00022149
	[XmlElement(ElementName = "SpeedUpCapacity")]
	public int SpeedUpCapacity { get; set; }

	// Token: 0x170004B9 RID: 1209
	// (get) Token: 0x060030F6 RID: 12534 RVA: 0x00023F52 File Offset: 0x00022152
	// (set) Token: 0x060030F7 RID: 12535 RVA: 0x00023F5A File Offset: 0x0002215A
	[XmlElement(ElementName = "SpeedUpUses")]
	public bool SpeedUpUses { get; set; }
}
