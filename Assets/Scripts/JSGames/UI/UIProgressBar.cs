using System;
using UnityEngine;
using UnityEngine.UI;

namespace JSGames.UI
{
	// Token: 0x02001B4D RID: 6989
	public class UIProgressBar : UIWidget
	{

		// Token: 0x0400A855 RID: 43093
		public Image _FillImage;

		// Token: 0x0400A856 RID: 43094
		public UIProgressBar.FillDirection _FillDirection;

		// Token: 0x02001B4E RID: 6990
		public enum FillDirection
		{
			// Token: 0x0400A858 RID: 43096
			LeftToRight,
			// Token: 0x0400A859 RID: 43097
			RightToLeft,
			// Token: 0x0400A85A RID: 43098
			BottomToTop,
			// Token: 0x0400A85B RID: 43099
			TopToBottom
		}
	}
}
