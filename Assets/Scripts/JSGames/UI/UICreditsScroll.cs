using System;
using UnityEngine;
using UnityEngine.EventSystems;

namespace JSGames.UI
{
	// Token: 0x02001B2F RID: 6959
	public class UICreditsScroll : UI
	{
		// Token: 0x0400A7B1 RID: 42929
		public Font _Font;

		// Token: 0x0400A7B2 RID: 42930
		public Vector2 _LabelSize;

		// Token: 0x0400A7B3 RID: 42931
		public UIWidget _labelTemplate;

		// Token: 0x0400A7B4 RID: 42932
		public float _TextScale = 50f;

		// Token: 0x0400A7B5 RID: 42933
		public float _BoldTextScale = 50f;

		// Token: 0x0400A7B6 RID: 42934
		public Color _BoldTextColor = Color.yellow;

		// Token: 0x0400A7B7 RID: 42935
		public Color _UnderlineTextColor = Color.cyan;

		// Token: 0x0400A7B8 RID: 42936
		public Color _TextColor = Color.white;

		// Token: 0x0400A7B9 RID: 42937
		public float _ScrollRate = 3f;

		// Token: 0x0400A7BA RID: 42938
		public GameObject _AnchorObject;

		// Token: 0x0400A7BB RID: 42939
		public GameObject _MessageObject;

		// Token: 0x0400A7BC RID: 42940
		public float _TextStartOffset;

		// Token: 0x0400A7BD RID: 42941
		public float _NextLineOffset = 2f;

		// Token: 0x0400A7BE RID: 42942
		public float _ResetOffset = 30f;
	}
}
