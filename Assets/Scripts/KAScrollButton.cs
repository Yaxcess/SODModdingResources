using System;

// Token: 0x02000DC7 RID: 3527
public class KAScrollButton : KAButton
{

	// Token: 0x0400566E RID: 22126
	public KAScrollBar _ScrollBar;

	// Token: 0x0400566F RID: 22127
	public bool _DirectionUp;

	// Token: 0x04005670 RID: 22128
	public KAScrollButton.OnScrollButtonClicked onButtonClicked;

	// Token: 0x02000DC8 RID: 3528
	// (Invoke) Token: 0x060055FF RID: 22015
	public delegate void OnScrollButtonClicked(KAScrollBar scrollBar, KAScrollButton scrollButton, bool isRepeated);
}
