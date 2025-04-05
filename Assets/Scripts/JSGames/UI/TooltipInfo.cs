using System;
using UnityEngine;

namespace JSGames.UI
{
	// Token: 0x02001B24 RID: 6948
	[Serializable]
	public class TooltipInfo
	{
		// Token: 0x0400A75B RID: 42843
		public bool _HideTooltip;

		// Token: 0x0400A75C RID: 42844
		public float _Duration = 0.5f;

		// Token: 0x0400A75D RID: 42845
		public float _InitialAlpha = 0.1f;

		// Token: 0x0400A75E RID: 42846
		public float _InitialScale = 0.1f;

		// Token: 0x0400A75F RID: 42847
		public float _FinalScale = 1f;

		// Token: 0x0400A760 RID: 42848
		public Vector2 _Offset = Vector2.zero;

		// Token: 0x0400A761 RID: 42849
		public LocaleString _Text = new LocaleString("");

		// Token: 0x0400A762 RID: 42850
		public Font _Font;

		// Token: 0x0400A763 RID: 42851
		public int _FontSize = 20;

		// Token: 0x0400A764 RID: 42852
		public Color _TextColor = Color.white;

		// Token: 0x0400A765 RID: 42853
		public SnSound _Sound;

		// Token: 0x0400A766 RID: 42854
		public Sprite _BackgroundImage;

		// Token: 0x0400A767 RID: 42855
		public Color _Color = Color.white;

		// Token: 0x0400A768 RID: 42856
		public TooltipStyle _Style;
	}
}
