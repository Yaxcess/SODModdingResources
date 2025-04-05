using System;
using System.Xml.Serialization;

// Token: 0x020007FC RID: 2044
[XmlRoot(ElementName = "RuleItem", Namespace = "")]
[Serializable]
public class RuleItem
{
	// Token: 0x0400326B RID: 12907
	[XmlElement(ElementName = "Type")]
	public RuleItemType Type;

	// Token: 0x0400326C RID: 12908
	[XmlElement(ElementName = "MissionID")]
	public int MissionID;

	// Token: 0x0400326D RID: 12909
	[XmlElement(ElementName = "ID")]
	public int ID;

	// Token: 0x0400326E RID: 12910
	[XmlElement(ElementName = "Complete")]
	public int Complete;
}
