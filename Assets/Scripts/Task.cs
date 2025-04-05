using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using UnityEngine;

// Token: 0x02000879 RID: 2169
[XmlRoot(ElementName = "Task", Namespace = "")]
[Serializable]
public class Task
{

	// Token: 0x04003593 RID: 13715
	[XmlElement(ElementName = "I")]
	public int TaskID;

	// Token: 0x04003594 RID: 13716
	[XmlElement(ElementName = "N")]
	public string Name;

	// Token: 0x04003595 RID: 13717
	[XmlElement(ElementName = "S")]
	public string Static;

	// Token: 0x04003596 RID: 13718
	[XmlElement(ElementName = "C")]
	public int Completed;

	// Token: 0x04003597 RID: 13719
	[XmlElement(ElementName = "F")]
	public bool Failed;

	// Token: 0x04003598 RID: 13720
	[XmlElement(ElementName = "P")]
	public string Payload;

	// Token: 0x04003599 RID: 13721
	[XmlIgnore]
	public Mission _Mission;

	// Token: 0x0400359A RID: 13722
	[XmlIgnore]
	public bool _Active;

	// Token: 0x0400359F RID: 13727
	public static Task.SetTaskFailed OnSetTaskFailed;

	// Token: 0x0200087A RID: 2170
	// (Invoke) Token: 0x060034EE RID: 13550
	public delegate void SetTaskFailed(Task task);
}
