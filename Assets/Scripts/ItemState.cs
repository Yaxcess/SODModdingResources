using System;
using System.Xml.Serialization;

// Token: 0x0200079C RID: 1948
[XmlRoot(ElementName = "ItemState", Namespace = "")]
[Serializable]
public class ItemState
{
	// Token: 0x040030C1 RID: 12481
	[XmlElement(ElementName = "ItemStateID")]
	public int ItemStateID;

	// Token: 0x040030C2 RID: 12482
	[XmlElement(ElementName = "Name")]
	public string Name;

	// Token: 0x040030C3 RID: 12483
	[XmlElement(ElementName = "Rule")]
	public ItemStateRule Rule;

	// Token: 0x040030C4 RID: 12484
	[XmlElement(ElementName = "Order")]
	public int Order;

	// Token: 0x040030C5 RID: 12485
	[XmlElement(ElementName = "AchievementID", IsNullable = true)]
	public int? AchievementID;

	// Token: 0x040030C6 RID: 12486
	[XmlElement(ElementName = "Rewards")]
	public AchievementReward[] Rewards;
}
