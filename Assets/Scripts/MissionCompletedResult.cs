using System;
using System.Xml.Serialization;

// Token: 0x020007FD RID: 2045
[XmlRoot(ElementName = "MissionCompletedResult", Namespace = "")]
[Serializable]
public class MissionCompletedResult
{
	// Token: 0x0400326F RID: 12911
	[XmlElement(ElementName = "M")]
	public int MissionID;

	// Token: 0x04003270 RID: 12912
	[XmlElement(ElementName = "A")]
	public AchievementReward[] Rewards;
}
