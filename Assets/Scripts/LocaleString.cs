using System;
using System.Xml.Serialization;
using UnityEngine;

// Token: 0x0200094B RID: 2379
[Serializable]
public class LocaleString
{
	// Token: 0x060037CD RID: 14285 RVA: 0x0002762A File Offset: 0x0002582A
	[Obsolete("For XML Serialization Only", true)]
	public LocaleString()
	{
	}

	// Token: 0x060037CE RID: 14286 RVA: 0x0002763D File Offset: 0x0002583D
	public LocaleString(string text)
	{
		this._Text = text;
	}


	// Token: 0x04003997 RID: 14743
	[TextArea]
	[XmlElement(ElementName = "Text")]
	public string _Text = "";

	// Token: 0x04003998 RID: 14744
	[XmlElement(ElementName = "ID")]
	public int _ID;
}
