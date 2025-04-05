using System;
using System.Xml.Serialization;

// Token: 0x020007DE RID: 2014
[Serializable]
public class CombinedListMessage
{
	// Token: 0x040031D6 RID: 12758
	[XmlElement(ElementName = "MessageType")]
	public int MessageType;

	// Token: 0x040031D7 RID: 12759
	[XmlElement(ElementName = "MessageDate")]
	public DateTime MessageDate;

	// Token: 0x040031D8 RID: 12760
	[XmlElement(ElementName = "Body", IsNullable = true)]
	public string MessageBody;
}
