using System;
using System.Xml.Serialization;

// Token: 0x0200083D RID: 2109
[XmlRoot(ElementName = "RPC", Namespace = "")]
[Serializable]
public class RaisedPetColor
{
	// Token: 0x04003444 RID: 13380
	[XmlElement(ElementName = "o")]
	public int Order;

	// Token: 0x04003445 RID: 13381
	[XmlElement(ElementName = "r")]
	public float Red;

	// Token: 0x04003446 RID: 13382
	[XmlElement(ElementName = "g")]
	public float Green;

	// Token: 0x04003447 RID: 13383
	[XmlElement(ElementName = "b")]
	public float Blue;
}
