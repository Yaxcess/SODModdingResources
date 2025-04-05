using System;
using System.Collections;
using UnityEngine;

namespace JSGames.UI
{
	// Token: 0x02001B50 RID: 6992
	public class UITimerWidget : UIWidget
	{
		// Token: 0x0400A867 RID: 43111
		public Action<UIWidget> OnCounterEnd;

		// Token: 0x0400A868 RID: 43112
		public Action<UIWidget> OnTimerEnd;
		// Token: 0x0400A870 RID: 43120
		[SerializeField]
		private bool m_OverrideVisibilityControl;

		// Token: 0x0400A871 RID: 43121
		[SerializeField]
		private UIProgressBar m_ProgressBar;

		// Token: 0x0400A872 RID: 43122
		[SerializeField]
		private bool m_ReverseFillDirection = true;
	}
}
