using System;
using System.Collections.Generic;
using System.Xml.Serialization;

// Token: 0x020007FA RID: 2042
[XmlRoot(ElementName = "MissionCriteria", Namespace = "")]
[Serializable]
public class MissionCriteria
{
	// Token: 0x0600322F RID: 12847 RVA: 0x00024942 File Offset: 0x00022B42
	public MissionCriteria()
	{
		this.Type = "all";
		this.Ordered = false;
		this.Min = 1;
		this.Repeat = 1;
		this.RuleItems = new List<RuleItem>();
	}

	// Token: 0x04003263 RID: 12899
	[XmlElement(ElementName = "Type")]
	public string Type;

	// Token: 0x04003264 RID: 12900
	[XmlElement(ElementName = "Ordered")]
	public bool Ordered;

	// Token: 0x04003265 RID: 12901
	[XmlElement(ElementName = "Min")]
	public int Min;

	// Token: 0x04003266 RID: 12902
	[XmlElement(ElementName = "Repeat")]
	public int Repeat;

	// Token: 0x04003267 RID: 12903
	[XmlElement(ElementName = "RuleItems")]
	public List<RuleItem> RuleItems;
}
