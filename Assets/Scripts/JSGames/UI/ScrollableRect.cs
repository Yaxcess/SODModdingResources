using System;
using UnityEngine;
using UnityEngine.UI;

namespace JSGames.UI
{
	// Token: 0x02001B1E RID: 6942
	[RequireComponent(typeof(UIMenu))]
	public class ScrollableRect : ScrollRect
	{

		// Token: 0x0400A73A RID: 42810
		public UIWidget _Background;

		// Token: 0x0400A73B RID: 42811
		public UIWidget _ScrollUpButton;

		// Token: 0x0400A73C RID: 42812
		public UIWidget _ScrollDownButton;

		// Token: 0x0400A73D RID: 42813
		public UIWidget _ScrollRightButton;

		// Token: 0x0400A73E RID: 42814
		public UIWidget _ScrollLeftButton;

		// Token: 0x0400A73F RID: 42815
		[Tooltip("The scroll step value in pixels")]
		public float _ScrollStep = 10f;
	}
}
