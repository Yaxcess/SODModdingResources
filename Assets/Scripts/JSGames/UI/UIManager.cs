using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace JSGames.UI
{
	// Token: 0x02001B45 RID: 6981
	[RequireComponent(typeof(EventSystem))]
	[RequireComponent(typeof(StandaloneInputModule))]
	public class UIManager : Singleton<UIManager>
	{
		// Token: 0x0400A81A RID: 43034
		public bool _UpdatePixelDragThresold = true;

		// Token: 0x0400A81B RID: 43035
		public float _ReferenceDPI = 115f;

		// Token: 0x0400A81C RID: 43036
		public Action<UI> OnSetExclusive;

		// Token: 0x0400A81D RID: 43037
		public Action<UI> OnRemoveExclusive;

		// Token: 0x0400A81F RID: 43039
		public static Action OnExclusiveListUpdated;

		// Token: 0x02001B46 RID: 6982
		public struct ExclusiveData
		{
			// Token: 0x0400A821 RID: 43041
			public UI _UI;

			// Token: 0x0400A822 RID: 43042
			public int _PreviousSortingOrder;

			// Token: 0x0400A823 RID: 43043
			public bool _PreviousOverrideSorting;
		}
	}
}
