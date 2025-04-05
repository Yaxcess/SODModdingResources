using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x02000EF9 RID: 3833
[AddComponentMenu("NGUI/Interaction/Grid")]
public class UIGrid : UIWidgetContainer
{

	// Token: 0x04005DD2 RID: 24018
	public UIGrid.Arrangement arrangement;

	// Token: 0x04005DD3 RID: 24019
	public UIGrid.Sorting sorting;

	// Token: 0x04005DD4 RID: 24020
	public UIWidget.Pivot pivot;

	// Token: 0x04005DD5 RID: 24021
	public int maxPerLine;

	// Token: 0x04005DD6 RID: 24022
	public float cellWidth = 200f;

	// Token: 0x04005DD7 RID: 24023
	public float cellHeight = 200f;

	// Token: 0x04005DD8 RID: 24024
	public bool animateSmoothly;

	// Token: 0x04005DD9 RID: 24025
	public bool hideInactive;

	// Token: 0x04005DDA RID: 24026
	public bool keepWithinPanel;

	// Token: 0x04005DDB RID: 24027
	public UIGrid.OnReposition onReposition;

	// Token: 0x04005DDC RID: 24028
	public Comparison<Transform> onCustomSort;

	// Token: 0x04005DDD RID: 24029
	[HideInInspector]
	[SerializeField]
	private bool sorted;

	// Token: 0x04005DDE RID: 24030
	protected bool mReposition;

	// Token: 0x04005DDF RID: 24031
	protected UIPanel mPanel;

	// Token: 0x04005DE0 RID: 24032
	protected bool mInitDone;

	// Token: 0x02000EFA RID: 3834
	// (Invoke) Token: 0x06005EE5 RID: 24293
	public delegate void OnReposition();

	// Token: 0x02000EFB RID: 3835
	public enum Arrangement
	{
		// Token: 0x04005DE2 RID: 24034
		Horizontal,
		// Token: 0x04005DE3 RID: 24035
		Vertical,
		// Token: 0x04005DE4 RID: 24036
		CellSnap
	}

	// Token: 0x02000EFC RID: 3836
	public enum Sorting
	{
		// Token: 0x04005DE6 RID: 24038
		None,
		// Token: 0x04005DE7 RID: 24039
		Alphabetic,
		// Token: 0x04005DE8 RID: 24040
		Horizontal,
		// Token: 0x04005DE9 RID: 24041
		Vertical,
		// Token: 0x04005DEA RID: 24042
		Custom
	}
}
