using System;
using System.Xml.Serialization;

// Token: 0x020007AD RID: 1965
[XmlRoot(ElementName = "IS", Namespace = "")]
[Serializable]
public class ItemStat
{
	// Token: 0x170004BA RID: 1210
	// (get) Token: 0x060030FB RID: 12539 RVA: 0x00023F63 File Offset: 0x00022163
	// (set) Token: 0x060030FC RID: 12540 RVA: 0x00023F6B File Offset: 0x0002216B
	[XmlElement(ElementName = "ID")]
	public int ItemStatID { get; set; }

	// Token: 0x170004BB RID: 1211
	// (get) Token: 0x060030FD RID: 12541 RVA: 0x00023F74 File Offset: 0x00022174
	// (set) Token: 0x060030FE RID: 12542 RVA: 0x00023F7C File Offset: 0x0002217C
	[XmlElement(ElementName = "N")]
	public string Name { get; set; }

	// Token: 0x170004BC RID: 1212
	// (get) Token: 0x060030FF RID: 12543 RVA: 0x00023F85 File Offset: 0x00022185
	// (set) Token: 0x06003100 RID: 12544 RVA: 0x00023F8D File Offset: 0x0002218D
	[XmlElement(ElementName = "V")]
	public string Value { get; set; }

	// Token: 0x170004BD RID: 1213
	// (get) Token: 0x06003101 RID: 12545 RVA: 0x00023F96 File Offset: 0x00022196
	// (set) Token: 0x06003102 RID: 12546 RVA: 0x00023F9E File Offset: 0x0002219E
	[XmlElement(ElementName = "DTI")]
	public DataTypeInfo DataType { get; set; }

	// Token: 0x06003103 RID: 12547 RVA: 0x000065ED File Offset: 0x000047ED
	public ItemStat()
	{
	}

	// Token: 0x06003104 RID: 12548 RVA: 0x00023FA7 File Offset: 0x000221A7
	public ItemStat(ItemStat stat)
	{
		this.ItemStatID = stat.ItemStatID;
		this.Name = stat.Name;
		this.Value = stat.Value;
		this.DataType = stat.DataType;
	}
}
