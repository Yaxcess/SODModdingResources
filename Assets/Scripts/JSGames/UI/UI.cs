using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace JSGames.UI
{
	// Token: 0x02001B26 RID: 6950
	[RequireComponent(typeof(Canvas))]
	[RequireComponent(typeof(GraphicRaycaster))]
	[DisallowMultipleComponent]
	public class UI : UIBase
	{
		// Token: 0x170010A1 RID: 4257
		// (get) Token: 0x0600A3AB RID: 41899 RVA: 0x000662F1 File Offset: 0x000644F1
		// (set) Token: 0x0600A3AC RID: 41900 RVA: 0x000662F9 File Offset: 0x000644F9
		public UIEvents pEventReceiver { get; protected set; }

		// Token: 0x0400A773 RID: 42867
		public static UI _GlobalExclusiveUI = null;

		// Token: 0x0400A774 RID: 42868
		public UIButton _BackButton;

		// Token: 0x0400A775 RID: 42869
		protected List<UI> mChildUIs = new List<UI>();

		// Token: 0x0400A77B RID: 42875
		protected static int mOnClickFrameCount = -1;
	}
}
