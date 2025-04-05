using System;
using UnityEngine;

// Token: 0x02000DC5 RID: 3525
[RequireComponent(typeof(UIScrollBar))]
public class KAScrollBar : KAWidget
{
	
	// Token: 0x04005665 RID: 22117
	public KAScrollBar.OnPressBackground onScrollbarBackgroundPress;

	// Token: 0x04005666 RID: 22118
	public KAScrollButton _UpArrow;

	// Token: 0x04005667 RID: 22119
	public KAScrollButton _DownArrow;

	// Token: 0x04005668 RID: 22120
	public float _ScrollRepeatedDelay = 0.8f;

	// Token: 0x04005669 RID: 22121
	public bool _DisableArrowOnScroll = true;

	// Token: 0x02000DC6 RID: 3526
	// (Invoke) Token: 0x060055F8 RID: 22008
	public delegate void OnPressBackground(KAScrollBar inScrollBar, bool inPressed);
}
