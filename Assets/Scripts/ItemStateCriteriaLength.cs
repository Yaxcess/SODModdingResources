using System;
using System.Xml.Serialization;

// Token: 0x020007A2 RID: 1954
[XmlRoot(ElementName = "ItemStateCriteriaLength", Namespace = "")]
[Serializable]
public class ItemStateCriteriaLength : ItemStateCriteria
{
	// Token: 0x040030D7 RID: 12503
	[XmlElement(ElementName = "Period")]
	public int Period;
}
