using System;
using System.Xml.Serialization;

// Token: 0x020006D5 RID: 1749
[XmlRoot(ElementName = "MessageInfo", Namespace = "http://api.jumpstart.com/", IsNullable = true)]
[Serializable]
public class MessageInfo
{
	// Token: 0x04002CD8 RID: 11480
	[XmlElement(ElementName = "UserMessageQueueID", IsNullable = true)]
	public int? UserMessageQueueID;

	// Token: 0x04002CD9 RID: 11481
	[XmlElement(ElementName = "FromUserID", IsNullable = true)]
	public string FromUserID;

	// Token: 0x04002CDA RID: 11482
	[XmlElement(ElementName = "MessageID", IsNullable = true)]
	public int? MessageID;

	// Token: 0x04002CDB RID: 11483
	[XmlElement(ElementName = "MessageTypeID", IsNullable = true)]
	public int? MessageTypeID;

	// Token: 0x04002CDC RID: 11484
	[XmlElement(ElementName = "MessageTypeName")]
	public string MessageTypeName;

	// Token: 0x04002CDD RID: 11485
	[XmlElement(ElementName = "MemberMessage")]
	public string MemberMessage;

	// Token: 0x04002CDE RID: 11486
	[XmlElement(ElementName = "NonMemberMessage")]
	public string NonMemberMessage;

	// Token: 0x04002CDF RID: 11487
	[XmlElement(ElementName = "MemberImageUrl")]
	public string MemberImageUrl;

	// Token: 0x04002CE0 RID: 11488
	[XmlElement(ElementName = "NonMemberImageUrl")]
	public string NonMemberImageUrl;

	// Token: 0x04002CE1 RID: 11489
	[XmlElement(ElementName = "MemberLinkUrl")]
	public string MemberLinkUrl;

	// Token: 0x04002CE2 RID: 11490
	[XmlElement(ElementName = "NonMemberLinkUrl")]
	public string NonMemberLinkUrl;

	// Token: 0x04002CE3 RID: 11491
	[XmlElement(ElementName = "MemberAudioUrl")]
	public string MemberAudioUrl;

	// Token: 0x04002CE4 RID: 11492
	[XmlElement(ElementName = "NonMemberAudioUrl")]
	public string NonMemberAudioUrl;

	// Token: 0x04002CE5 RID: 11493
	[XmlElement(ElementName = "Data")]
	public string Data;

	// Token: 0x04002CE6 RID: 11494
	[XmlIgnore]
	public DateTime CreateDate;

	// Token: 0x04002CE7 RID: 11495
	[XmlIgnore]
	public bool ParentMessage;
}
