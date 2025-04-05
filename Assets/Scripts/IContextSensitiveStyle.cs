using System;
using UnityEngine;

// Token: 0x02000B13 RID: 2835
public interface IContextSensitiveStyle
{
	// Token: 0x060041A7 RID: 16807
	void UpdatePositionData(ContextData[] inDataList);

	// Token: 0x060041A8 RID: 16808
	Vector2 GetCloseButtonPosition();

	// Token: 0x060041A9 RID: 16809
	Rect GetMenuBackgroundRect();
}
