using System;
using System.Xml.Serialization;

// Token: 0x0200083E RID: 2110
[XmlRoot(ElementName = "RPGS", Namespace = "")]
[Serializable]
public class RaisedPetGrowthState
{
	// Token: 0x04003448 RID: 13384
	[XmlElement(ElementName = "id")]
	public int GrowthStateID;

	// Token: 0x04003449 RID: 13385
	[XmlElement(ElementName = "n")]
	public string Name;

	// Token: 0x0400344A RID: 13386
	[XmlElement(ElementName = "ptid")]
	public int PetTypeID;

	// Token: 0x0400344B RID: 13387
	[XmlElement(ElementName = "o")]
	public int Order;
}
