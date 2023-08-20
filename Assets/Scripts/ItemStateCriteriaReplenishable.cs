using System;
using System.Collections.Generic;
using System.Xml.Serialization;

// Token: 0x020007A3 RID: 1955
[XmlRoot(ElementName = "ItemStateCriteriaReplenishable", Namespace = "")]
[Serializable]
public class ItemStateCriteriaReplenishable : ItemStateCriteria
{
	// Token: 0x040030D8 RID: 12504
	[XmlElement(ElementName = "ApplyRank")]
	public bool ApplyRank;

	// Token: 0x040030D9 RID: 12505
	[XmlElement(ElementName = "PointTypeID", IsNullable = true)]
	public int? PointTypeID;

	// Token: 0x040030DA RID: 12506
	[XmlElement(ElementName = "ReplenishableRates")]
	public List<ReplenishableRate> ReplenishableRates;
}
