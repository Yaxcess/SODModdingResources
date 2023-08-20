using System;
using System.Xml.Serialization;

// Token: 0x02000797 RID: 1943
[XmlRoot(ElementName = "AT", Namespace = "")]
[Serializable]
public class ItemAttribute
{
	// Token: 0x040030B2 RID: 12466
	[XmlElement(ElementName = "k")]
	public string Key;

	// Token: 0x040030B3 RID: 12467
	[XmlElement(ElementName = "v")]
	public string Value;
}
