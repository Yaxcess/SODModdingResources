using System;
using System.Collections.Generic;
using System.Linq;
using JSGames.UI.Util;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace JSGames.UI
{
	// Token: 0x02001B55 RID: 6997
	public class UIWidget : UIBase
	{

		// Token: 0x0400A892 RID: 43154
		public Vector3 _RotationPerSecond;

		// Token: 0x0400A893 RID: 43155
		public TooltipInfo _TooltipInfo;

		// Token: 0x0400A894 RID: 43156
		[Header("Unity Component References")]
		public Text _Text;

		// Token: 0x0400A895 RID: 43157
		public Image _Background;

		// Token: 0x0400A896 RID: 43158
		public RawImage _RawImageBackground;

		// Token: 0x0400A897 RID: 43159
		[Header("Effects")]
		public UIEffects _ClickEffects;

		// Token: 0x0400A898 RID: 43160
		public UIEffects _DisabledEffects;

		// Token: 0x0400A899 RID: 43161
		public UIEffects _HoverEffects;

		// Token: 0x0400A89A RID: 43162
		public UIEffects _PressEffects;

		// Token: 0x0400A89B RID: 43163
		protected Selectable mSelectable;

		// Token: 0x0400A8A1 RID: 43169
		protected bool mIsDragging;
	}
}
