using System;
using UnityEngine;

// Token: 0x02000DEC RID: 3564
[Serializable]
public class KATooltipInfo
{
	// Token: 0x04005793 RID: 22419
	public bool _ShowUI;

	// Token: 0x04005794 RID: 22420
	public bool _UpdatePosition = true;

	// Token: 0x04005795 RID: 22421
	public float _Duration = 0.5f;

	// Token: 0x04005796 RID: 22422
	public float _InitialAlpha = 0.1f;

	// Token: 0x04005797 RID: 22423
	public float _InitialScale = 0.1f;

	// Token: 0x04005798 RID: 22424
	public float _FinalScale = 1f;

	// Token: 0x04005799 RID: 22425
	public LocaleString _Text = new LocaleString("");

	// Token: 0x0400579A RID: 22426
	public SnSound _Sound;

	// Token: 0x0400579B RID: 22427
	public Vector2 _Offset = Vector2.zero;

	// Token: 0x0400579C RID: 22428
	public Vector2 _Padding = Vector2.zero;

	// Token: 0x0400579D RID: 22429
	public UIAtlas _Atlas;

	// Token: 0x0400579E RID: 22430
	public string _BackgroundSprite;

	// Token: 0x0400579F RID: 22431
	public Color _Color = Color.white;

	// Token: 0x040057A0 RID: 22432
	public UIFont _Font;

	// Token: 0x040057A1 RID: 22433
	public Color _TextColor = Color.white;

}
