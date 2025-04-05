using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace JSGames.UI
{
	// Token: 0x02001B4A RID: 6986
	public class UIMenu : UI
	{
		// Token: 0x0400A828 RID: 43048
		public Action<bool> OnVisibilityChanged;

		// Token: 0x0400A829 RID: 43049
		public Action<WidgetState> OnMenuStateChanged;

		// Token: 0x0400A82A RID: 43050
		public UIWidget _Template;

		// Token: 0x0400A82B RID: 43051
		public MinMax _WidgetPoolCount;

		// Token: 0x0400A82C RID: 43052
		public RectTransform _ViewPortRectTransform;

		// Token: 0x0400A82D RID: 43053
		public MaskableGraphic _SelectionHighlight;

		// Token: 0x0400A82E RID: 43054
		public MaskableGraphic _HoverHighlight;

		// Token: 0x0400A82F RID: 43055
		public bool _UpdateOnlyOnVisible;
	}
}
