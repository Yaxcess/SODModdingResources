using System;
using UnityEngine;

namespace JSGames.UI
{
	// Token: 0x02001B24 RID: 6948
	[Serializable]
	public class TooltipInfo
	{
		// Token: 0x0400A764 RID: 42852
		public bool _HideTooltip;

		// Token: 0x0400A765 RID: 42853
		public float _Duration = 0.5f;

		// Token: 0x0400A766 RID: 42854
		public float _InitialAlpha = 0.1f;

		// Token: 0x0400A767 RID: 42855
		public float _InitialScale = 0.1f;

		// Token: 0x0400A768 RID: 42856
		public float _FinalScale = 1f;

		// Token: 0x0400A769 RID: 42857
		public Vector2 _Offset = Vector2.zero;

		// Token: 0x0400A76A RID: 42858
		public LocaleString _Text = new LocaleString("");

		// Token: 0x0400A76B RID: 42859
		public Font _Font;

		// Token: 0x0400A76C RID: 42860
		public int _FontSize = 20;

		// Token: 0x0400A76D RID: 42861
		public Color _TextColor = Color.white;

		// Token: 0x0400A76E RID: 42862
		public SnSound _Sound;

		// Token: 0x0400A76F RID: 42863
		public Sprite _BackgroundImage;

		// Token: 0x0400A770 RID: 42864
		public Color _Color = Color.white;

	
	}
}
