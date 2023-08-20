using System;
using System.Collections.Generic;
using System.Xml.Serialization;

// Token: 0x0200079D RID: 1949
[XmlRoot(ElementName = "ItemStateRule", Namespace = "")]
[Serializable]
public class ItemStateRule
{
	// Token: 0x040030C7 RID: 12487
	[XmlElement(ElementName = "Criterias")]
	public List<ItemStateCriteria> Criterias;

	// Token: 0x040030C8 RID: 12488
	[XmlElement(ElementName = "CompletionAction")]
	public CompletionAction CompletionAction;
}
