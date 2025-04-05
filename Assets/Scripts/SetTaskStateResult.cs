using System;
using System.Xml.Serialization;

// Token: 0x02000889 RID: 2185
[XmlRoot(ElementName = "SetTaskStateResult", Namespace = "")]
[Serializable]
public class SetTaskStateResult
{
	// Token: 0x040035EB RID: 13803
	[XmlElement(ElementName = "S")]
	public bool Success;

	// Token: 0x040035EC RID: 13804
	[XmlElement(ElementName = "T")]
	public SetTaskStateStatus Status;

	// Token: 0x040035ED RID: 13805
	[XmlElement(ElementName = "A")]
	public string AdditionalStatusParams;

	// Token: 0x040035EE RID: 13806
	[XmlElement(ElementName = "R")]
	public MissionCompletedResult[] MissionsCompleted;

	// Token: 0x040035EF RID: 13807
	[XmlElement(ElementName = "C")]
	public CommonInventoryResponse CommonInvRes;
}
