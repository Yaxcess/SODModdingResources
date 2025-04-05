using System;
using System.Collections.Generic;
using System.Xml.Serialization;

// Token: 0x020007F5 RID: 2037
[XmlRoot(ElementName = "MissionRule", Namespace = "")]
[Serializable]
public class MissionRule
{
	// Token: 0x06003225 RID: 12837 RVA: 0x000248E9 File Offset: 0x00022AE9
	public MissionRule()
	{
		this.Prerequisites = new List<PrerequisiteItem>();
		this.Criteria = new MissionCriteria();
	}


	// Token: 0x06003228 RID: 12840 RVA: 0x0018FCF8 File Offset: 0x0018DEF8
	public void Reset()
	{
		foreach (RuleItem ruleItem in this.Criteria.RuleItems)
		{
			ruleItem.Complete = 0;
		}
	}

	// Token: 0x04003253 RID: 12883
	[XmlElement(ElementName = "Prerequisites")]
	public List<PrerequisiteItem> Prerequisites;

	// Token: 0x04003254 RID: 12884
	[XmlElement(ElementName = "Criteria")]
	public MissionCriteria Criteria;
}
