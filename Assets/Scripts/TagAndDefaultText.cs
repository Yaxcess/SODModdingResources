using System;

// Token: 0x02000956 RID: 2390
[Serializable]
public class TagAndDefaultText
{
	// Token: 0x060037E9 RID: 14313 RVA: 0x000276F3 File Offset: 0x000258F3
	public TagAndDefaultText(string tagName, LocaleString defaultText)
	{
		this._Tag = tagName;
		this._DefaultText = defaultText;
	}

	// Token: 0x04003A33 RID: 14899
	public string _Tag;

	// Token: 0x04003A34 RID: 14900
	public LocaleString _DefaultText;
}
