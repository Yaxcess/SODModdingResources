using System;
using System.Xml.Serialization;

// Token: 0x0200083F RID: 2111
[XmlRoot(ElementName = "RPSK", Namespace = "")]
[Serializable]
public class RaisedPetSkill
{
	// Token: 0x0400344C RID: 13388
	[XmlElement(ElementName = "k")]
	public string Key;

	// Token: 0x0400344D RID: 13389
	[XmlElement(ElementName = "v")]
	public float Value;

	// Token: 0x0400344E RID: 13390
	[XmlElement(ElementName = "ud")]
	public DateTime UpdateDate;
}
