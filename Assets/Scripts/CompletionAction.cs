using System;
using System.Xml.Serialization;

// Token: 0x020007A0 RID: 1952
[Serializable]
public class CompletionAction
{
	// Token: 0x040030D0 RID: 12496
	[XmlElement(ElementName = "Transition")]
	public StateTransition Transition;
}
