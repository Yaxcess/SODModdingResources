using System;
using System.Xml.Serialization;

// Token: 0x0200079B RID: 1947
[XmlRoot(ElementName = "IT", Namespace = "")]
[Serializable]
public class ItemDataTexture
{
	// Token: 0x040030BD RID: 12477
	[XmlElement(ElementName = "n")]
	public string TextureName;

	// Token: 0x040030BE RID: 12478
	[XmlElement(ElementName = "t")]
	public string TextureTypeName;

	// Token: 0x040030BF RID: 12479
	[XmlElement(ElementName = "x", IsNullable = true)]
	public float? OffsetX;

	// Token: 0x040030C0 RID: 12480
	[XmlElement(ElementName = "y", IsNullable = true)]
	public float? OffsetY;
}
