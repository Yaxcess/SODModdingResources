using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x02000F1D RID: 3869
[AddComponentMenu("NGUI/Interaction/Table")]
public class UITable : UIWidgetContainer
{

	// Token: 0x04005EE4 RID: 24292
	public int columns;

	// Token: 0x04005EE5 RID: 24293
	public UITable.Direction direction;

	// Token: 0x04005EE6 RID: 24294
	public UITable.Sorting sorting;

	// Token: 0x04005EE7 RID: 24295
	public UIWidget.Pivot pivot;

	// Token: 0x04005EE8 RID: 24296
	public UIWidget.Pivot cellAlignment;

	// Token: 0x04005EE9 RID: 24297
	public bool hideInactive = true;

	// Token: 0x04005EEA RID: 24298
	public bool keepWithinPanel;

	// Token: 0x04005EEB RID: 24299
	public Vector2 padding = Vector2.zero;

	// Token: 0x04005EEC RID: 24300
	public UITable.OnReposition onReposition;

	// Token: 0x04005EED RID: 24301
	public Comparison<Transform> onCustomSort;

	// Token: 0x04005EEE RID: 24302
	protected UIPanel mPanel;

	// Token: 0x04005EEF RID: 24303
	protected bool mInitDone;

	// Token: 0x04005EF0 RID: 24304
	protected bool mReposition;

	// Token: 0x02000F1E RID: 3870
	// (Invoke) Token: 0x06005FF3 RID: 24563
	public delegate void OnReposition();

	// Token: 0x02000F1F RID: 3871
	public enum Direction
	{
		// Token: 0x04005EF2 RID: 24306
		Down,
		// Token: 0x04005EF3 RID: 24307
		Up
	}

	// Token: 0x02000F20 RID: 3872
	public enum Sorting
	{
		// Token: 0x04005EF5 RID: 24309
		None,
		// Token: 0x04005EF6 RID: 24310
		Alphabetic,
		// Token: 0x04005EF7 RID: 24311
		Horizontal,
		// Token: 0x04005EF8 RID: 24312
		Vertical,
		// Token: 0x04005EF9 RID: 24313
		Custom
	}
}
