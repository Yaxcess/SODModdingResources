using System;
using System.Xml.Serialization;

// Token: 0x0200083C RID: 2108
[XmlRoot(ElementName = "RPAT", Namespace = "")]
[Serializable]
public class RaisedPetAttribute
{
	// Token: 0x04003441 RID: 13377
	[XmlElement(ElementName = "k")]
	public string Key;

	// Token: 0x04003442 RID: 13378
	[XmlElement(ElementName = "v")]
	public string Value;

	// Token: 0x04003443 RID: 13379
	[XmlElement(ElementName = "dt")]
	public DataType Type;
}
