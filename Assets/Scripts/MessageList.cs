using System;
using System.Xml.Serialization;

// Token: 0x020007DB RID: 2011
[XmlRoot(ElementName = "MessageList", IsNullable = true, Namespace = "")]
[Serializable]
public class MessageList
{
	// Token: 0x040031C9 RID: 12745
	public int? ID;

	// Token: 0x040031CA RID: 12746
	public string UserID;

	// Token: 0x040031CB RID: 12747
	public MessageListType Type;

	// Token: 0x040031CC RID: 12748
	public int LastMessageID;

	// Token: 0x040031CD RID: 12749
	public Message[] Messages;
}
