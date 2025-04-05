using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace JSGames.UI
{
	// Token: 0x02001B1D RID: 6941
	[RequireComponent(typeof(UIMenu))]
	public class PageFlip : UIBehaviour, IEventSystemHandler
	{
		// Token: 0x0400A72C RID: 42796
		public UIWidget _Previous;

		// Token: 0x0400A72D RID: 42797
		public UIWidget _Next;

		// Token: 0x0400A72E RID: 42798
		public float _SnapDuration = 0.5f;
	}
}
