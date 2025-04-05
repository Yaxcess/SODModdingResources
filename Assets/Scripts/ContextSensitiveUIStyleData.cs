using System;
using UnityEngine;

// Token: 0x0200102A RID: 4138
[Serializable]
public class ContextSensitiveUIStyleData
{
	// Token: 0x04006574 RID: 25972
	public UI_STYLE_TYPE _Type;

	// Token: 0x04006575 RID: 25973
	public ContextSensitiveUIStyleData.SUBMENU_DIRECTION _SubMenuDirection;

	// Token: 0x04006576 RID: 25974
	public Vector2 _WidgetOffsetInPixels = new Vector2(0f, 10f);

	// Token: 0x04006577 RID: 25975
	public Vector2 _MenuBackgroundExtraScalePixels = new Vector2(40f, 10f);

	// Token: 0x0200102B RID: 4139
	public enum SUBMENU_DIRECTION
	{
		// Token: 0x04006579 RID: 25977
		BOTTOM,
		// Token: 0x0400657A RID: 25978
		TOP
	}
}
