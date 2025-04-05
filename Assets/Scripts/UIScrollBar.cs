using System;
using UnityEngine;

// Token: 0x02000F12 RID: 3858
[ExecuteInEditMode]
[AddComponentMenu("NGUI/Interaction/NGUI Scroll Bar")]
public class UIScrollBar : UISlider
{
	// Token: 0x04005E9E RID: 24222
	[HideInInspector]
	[SerializeField]
	protected float mSize = 1f;

	// Token: 0x04005E9F RID: 24223
	[HideInInspector]
	[SerializeField]
	private float mScroll;

	// Token: 0x04005EA0 RID: 24224
	[HideInInspector]
	[SerializeField]
	public UIScrollBar.Direction mDir = UIScrollBar.Direction.Upgraded;

	// Token: 0x02000F13 RID: 3859
	public enum Direction
	{
		// Token: 0x04005EA2 RID: 24226
		Horizontal,
		// Token: 0x04005EA3 RID: 24227
		Vertical,
		// Token: 0x04005EA4 RID: 24228
		Upgraded
	}
}
