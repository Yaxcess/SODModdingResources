using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x02000DB5 RID: 3509
public class FontManager : MonoBehaviour
{

	// Token: 0x0400561D RID: 22045
	public bool _UseDynamicFonts;

	// Token: 0x0400561E RID: 22046
	public FontManager.FontMappingInfo[] _FontMappingInfo;

	// Token: 0x02000DB6 RID: 3510
	public class FontData
	{
		
	}

	// Token: 0x02000DB7 RID: 3511
	[Serializable]
	public class FontBundleMapping
	{
		// Token: 0x04005629 RID: 22057
		public string _FontBundleName;

		// Token: 0x0400562A RID: 22058
		public List<UIFont> _Font;
	}

	// Token: 0x02000DB8 RID: 3512
	[Serializable]
	public class FontMappingInfo
	{
		// Token: 0x0400562B RID: 22059
		public List<string> _LocaleKeys;

		// Token: 0x0400562C RID: 22060
		public FontManager.FontBundleMapping[] _BundleInfo;
	}
}
