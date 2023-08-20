using System;
using System.Xml.Serialization;

// Token: 0x02000813 RID: 2067
[XmlRoot(ElementName = "Pair", Namespace = "")]
[Serializable]
public class Pair
{
	// Token: 0x040032B9 RID: 12985
	[XmlElement(ElementName = "PairKey")]
	public string PairKey;

	// Token: 0x040032BA RID: 12986
	[XmlElement(ElementName = "PairValue")]
	public string PairValue;

	// Token: 0x040032BB RID: 12987
	[XmlElement(ElementName = "UpdateDate")]
	public DateTime UpdateDate;
}
