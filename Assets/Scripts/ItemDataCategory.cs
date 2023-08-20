using System;
using System.Xml.Serialization;

// Token: 0x02000798 RID: 1944
[XmlRoot(ElementName = "IC", Namespace = "")]
[Serializable]
public class ItemDataCategory
{
	// Token: 0x040030B4 RID: 12468
	[XmlElement(ElementName = "cid")]
	public int CategoryId;

	// Token: 0x040030B5 RID: 12469
	[XmlElement(ElementName = "cn")]
	public string CategoryName;

	// Token: 0x040030B6 RID: 12470
	[XmlElement(ElementName = "i", IsNullable = true)]
	public string IconName;
}
