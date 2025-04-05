using System;
using System.Xml.Serialization;

// Token: 0x020007F9 RID: 2041
[XmlRoot(ElementName = "PrerequisiteItem", Namespace = "")]
[Serializable]
public class PrerequisiteItem
{
	// Token: 0x0600322D RID: 12845 RVA: 0x000065ED File Offset: 0x000047ED
	public PrerequisiteItem()
	{
	}

	// Token: 0x0600322E RID: 12846 RVA: 0x00024927 File Offset: 0x00022B27
	public PrerequisiteItem(PrerequisiteRequiredType type, object value)
	{
		this.Type = type;
		this.Value = value.ToString();
	}

	// Token: 0x0400325F RID: 12895
	[XmlElement(ElementName = "Type")]
	public PrerequisiteRequiredType Type;

	// Token: 0x04003260 RID: 12896
	[XmlElement(ElementName = "Value")]
	public string Value;

	// Token: 0x04003261 RID: 12897
	[XmlElement(ElementName = "Quantity")]
	public short Quantity;

	// Token: 0x04003262 RID: 12898
	[XmlElement(ElementName = "ClientRule")]
	public bool ClientRule;
}
