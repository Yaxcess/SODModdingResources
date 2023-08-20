using System;
using System.Xml.Serialization;

// Token: 0x0200079A RID: 1946
[XmlRoot(ElementName = "IRO", Namespace = "")]
[Serializable]
public class ItemDataRollover
{
	// Token: 0x040030BB RID: 12475
	[XmlElement(ElementName = "d")]
	public string DialogName;

	// Token: 0x040030BC RID: 12476
	[XmlElement(ElementName = "b")]
	public string Bundle;
}
