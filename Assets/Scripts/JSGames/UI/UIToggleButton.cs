using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace JSGames.UI
{
	// Token: 0x02001B53 RID: 6995
	public class UIToggleButton : UIButton
	{
		// Token: 0x0400A87B RID: 43131
		public bool _Checked;

		// Token: 0x0400A87C RID: 43132
		public bool _Grouped;

		// Token: 0x0400A87D RID: 43133
		public string _GroupName;

		// Token: 0x0400A87E RID: 43134
		[Header("Unity Component References")]
		public Image _Checkmark;

		// Token: 0x0400A87F RID: 43135
		[Header("Effects")]
		public UIEffects _CheckedEffects;

		// Token: 0x0400A880 RID: 43136
		public UIEffects _CheckedDisabledEffects;
	}
}
