using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x02000DE7 RID: 3559
[ExecuteInEditMode]
public class KAUIMenuGrid : UITable
{
	// Token: 0x04005761 RID: 22369
	public bool _IsGrid = true;

	// Token: 0x04005762 RID: 22370
	public bool _ArrangeItemsPagewise;

	// Token: 0x04005763 RID: 22371
	public UIGrid.Arrangement arrangement;

	// Token: 0x04005764 RID: 22372
	public int maxPerLine;

	// Token: 0x04005765 RID: 22373
	public float cellWidth = 200f;

	// Token: 0x04005766 RID: 22374
	public float cellHeight = 200f;

	// Token: 0x04005767 RID: 22375
	[NonSerialized]
	public Vector2 pDragDelta = Vector2.zero;

	// Token: 0x04005768 RID: 22376
	protected KAUIMenu mMenu;

	// Token: 0x04005769 RID: 22377
	public bool _AlignBottom;

	// Token: 0x0400576A RID: 22378
	public bool _DynamicSpacing;
}
