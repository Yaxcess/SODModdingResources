using System;
using System.Xml.Serialization;

// Token: 0x02000840 RID: 2112
[XmlRoot(ElementName = "RPST", Namespace = "")]
[Serializable]
public class RaisedPetState
{
	// Token: 0x0400344F RID: 13391
	[XmlElement(ElementName = "k")]
	public string Key;

	// Token: 0x04003450 RID: 13392
	[XmlElement(ElementName = "v")]
	public float Value;
}
