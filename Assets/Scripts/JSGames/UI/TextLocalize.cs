using System;
using System.Collections;
using JSGames.UI.Util;
using UnityEngine;
using UnityEngine.UI;

namespace JSGames.UI
{
	// Token: 0x02001B20 RID: 6944
	[RequireComponent(typeof(Text))]
	public class TextLocalize : KAMonoBase
	{

		// Token: 0x0400A74F RID: 42831
		[Tooltip("ID used for localization")]
		public int _TextID;

		// Token: 0x0400A750 RID: 42832
		private Text mText;
	}
}
