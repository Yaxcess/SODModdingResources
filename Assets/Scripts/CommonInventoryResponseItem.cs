using System;
using System.Xml.Serialization;

// Token: 0x02000710 RID: 1808
[XmlRoot(ElementName = "CIRI", Namespace = "")]
[Serializable]
public class CommonInventoryResponseItem
{
	// Token: 0x04002E17 RID: 11799
	[XmlElement(ElementName = "iid")]
	public int ItemID;

	// Token: 0x04002E18 RID: 11800
	[XmlElement(ElementName = "cid")]
	public int CommonInventoryID;

	// Token: 0x04002E19 RID: 11801
	[XmlElement(ElementName = "qty")]
	public int Quantity;
}
