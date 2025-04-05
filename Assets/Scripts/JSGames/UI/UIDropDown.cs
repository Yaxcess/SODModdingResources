using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace JSGames.UI
{
	// Token: 0x02001B30 RID: 6960
	public class UIDropDown : UI
	{
		// Token: 0x0400A7C1 RID: 42945
		public LocaleString _DefaultText;

		// Token: 0x0400A7C2 RID: 42946
		public UIWidget _DisplayWidget;

		// Token: 0x0400A7C3 RID: 42947
		public UIMenu _Menu;

		// Token: 0x0400A7C4 RID: 42948
		public bool _IsDropped;

		// Token: 0x0400A7C5 RID: 42949
		public bool _UpdateDisplayWidgetBackground;

		// Token: 0x0400A7C6 RID: 42950
		public bool _OverrideSorting = true;

		// Token: 0x02001B31 RID: 6961
		public class CanvasSortInfo
		{
			// Token: 0x0400A7CE RID: 42958
			public bool _OverrideSorting;

			// Token: 0x0400A7CF RID: 42959
			public int _SortingLayerID;

			// Token: 0x0400A7D0 RID: 42960
			public int _SortingOrder;
		}
	}
}
