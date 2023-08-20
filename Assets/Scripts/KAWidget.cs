using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x02000E11 RID: 3601
public class KAWidget : KAMonoBase
{
	// Token: 0x04005816 RID: 22550
	[HideInInspector]
	public int _MenuItemIndex = -1;

	// Token: 0x04005817 RID: 22551
	public bool _LogClickEvent;

	// Token: 0x0400581A RID: 22554
	public Vector3 _Pivot = Vector3.zero;

	// Token: 0x0400581B RID: 22555
	public string _RolloverCursorName;

	// Token: 0x0400581C RID: 22556
	public KATooltipInfo _TooltipInfo = new KATooltipInfo();

	// Token: 0x0400581D RID: 22557
	public KASkinInfo _HoverInfo = new KASkinInfo();

	// Token: 0x0400581E RID: 22558
	public KASkinInfo _DisabledInfo = new KASkinInfo();

	// Token: 0x0400581F RID: 22559
	public KASkinInfo _SelectedInfo = new KASkinInfo();

	// Token: 0x04005820 RID: 22560
	public Vector2 _AttachCursorOffset = Vector2.zero;

	// Token: 0x04005821 RID: 22561
	public KAOrientationInfo _ScreenInfo = new KAOrientationInfo();

	// Token: 0x04005822 RID: 22562
	public float _RotateSpeed;

	// Token: 0x04005823 RID: 22563
	public float _RotateAngle;

	// Token: 0x04005824 RID: 22564
	public Vector3 _RotationAxis = new Vector3(0f, 0f, 1f);

}
