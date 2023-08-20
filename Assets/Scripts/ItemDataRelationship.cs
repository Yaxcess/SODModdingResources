using System;
using System.Xml.Serialization;

// Token: 0x02000799 RID: 1945
[XmlRoot(ElementName = "IRE", Namespace = "")]
[Serializable]
public class ItemDataRelationship
{
	// Token: 0x040030B7 RID: 12471
	[XmlElement(ElementName = "t")]
	public string Type;

	// Token: 0x040030B8 RID: 12472
	[XmlElement(ElementName = "id")]
	public int ItemId;

	// Token: 0x040030B9 RID: 12473
	[XmlElement(ElementName = "wt")]
	public int Weight;

	// Token: 0x040030BA RID: 12474
	[XmlElement(ElementName = "q")]
	public int Quantity;
}
