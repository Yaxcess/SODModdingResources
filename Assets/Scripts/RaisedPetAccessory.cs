using System;
using System.Xml.Serialization;

// Token: 0x0200083B RID: 2107
[XmlRoot(ElementName = "RPAC", Namespace = "")]
[Serializable]
public class RaisedPetAccessory
{
	// Token: 0x0400343C RID: 13372
	[XmlElement(ElementName = "tp")]
	public string Type;

	// Token: 0x0400343D RID: 13373
	[XmlElement(ElementName = "g")]
	public string Geometry;

	// Token: 0x0400343E RID: 13374
	[XmlElement(ElementName = "t")]
	public string Texture;

	// Token: 0x0400343F RID: 13375
	[XmlElement(ElementName = "uiid", IsNullable = true)]
	public int? UserInventoryCommonID;

	// Token: 0x04003440 RID: 13376
	[XmlElement(ElementName = "uid", IsNullable = true)]
	public UserItemData UserItemData;
}
