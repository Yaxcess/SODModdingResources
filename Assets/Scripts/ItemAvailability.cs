using System;
using System.Xml.Serialization;

// Token: 0x020007A9 RID: 1961
[XmlRoot(ElementName = "Availability", Namespace = "")]
[Serializable]
public class ItemAvailability
{
	// Token: 0x040030EE RID: 12526
	[XmlElement(ElementName = "sdate", IsNullable = true)]
	public DateTime? StartDate;

	// Token: 0x040030EF RID: 12527
	[XmlElement(ElementName = "edate", IsNullable = true)]
	public DateTime? EndDate;
}
