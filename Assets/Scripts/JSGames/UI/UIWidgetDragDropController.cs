using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace JSGames.UI
{
	// Token: 0x02001B57 RID: 6999
	public class UIWidgetDragDropController : MonoBehaviour
	{

		// Token: 0x0400A8AC RID: 43180
		public UIWidgetDragDropController.WidgetDropEventHandler OnWidgetDropped;

		// Token: 0x0400A8AD RID: 43181
		public UIWidgetDragDropController.WidgetSelectEventHandler OnWidgetSelected;

		// Token: 0x0400A8AE RID: 43182
		public Vector2 _Offset;

		// Token: 0x0400A8AF RID: 43183
		public string _PlaceHolderTag;

		// Token: 0x0400A8B0 RID: 43184
		public string _DragableObjectTag;

		// Token: 0x0400A8B1 RID: 43185
		public AudioClip _PickupSFX;

		// Token: 0x0400A8B2 RID: 43186
		public bool _UpdateSiblingIndex;

		// Token: 0x0400A8B3 RID: 43187
		public bool _AllowUIBlock = true;

		// (Invoke) Token: 0x0600A59D RID: 42397
		public delegate void WidgetDropEventHandler(UIWidget droppedWidget, UIWidget backgroudWidget, Vector3 localPosition);

		// Token: 0x02001B59 RID: 7001
		// (Invoke) Token: 0x0600A5A1 RID: 42401
		public delegate void WidgetSelectEventHandler(UIWidget selectedWidget);
	}
}
