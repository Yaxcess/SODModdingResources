using System;
using UnityEngine;

// Token: 0x02000F7D RID: 3965
[ExecuteInEditMode]

public class UIAnchor : KAMonoBase
{
	
	// Token: 0x0400612B RID: 24875
	public Camera uiCamera;

	// Token: 0x0400612C RID: 24876
	public GameObject container;

	// Token: 0x0400612D RID: 24877
	public UIAnchor.Side side = UIAnchor.Side.Center;

	// Token: 0x0400612E RID: 24878
	public bool runOnlyOnce = true;

	// Token: 0x0400612F RID: 24879
	public Vector2 relativeOffset = Vector2.zero;

	// Token: 0x04006130 RID: 24880
	public Vector2 pixelOffset = Vector2.zero;

	// Token: 0x04006131 RID: 24881
	[HideInInspector]
	[SerializeField]
	private UIWidget widgetContainer;

	// Token: 0x04006132 RID: 24882
	private Transform mTrans;

	// Token: 0x04006133 RID: 24883
	private Animation mAnim;

	// Token: 0x04006134 RID: 24884
	private Rect mRect;

	// Token: 0x04006135 RID: 24885
	private UIRoot mRoot;

	// Token: 0x04006136 RID: 24886
	private bool mStarted;

	// Token: 0x02000F7E RID: 3966
	public enum Side
	{
		// Token: 0x04006138 RID: 24888
		BottomLeft,
		// Token: 0x04006139 RID: 24889
		Left,
		// Token: 0x0400613A RID: 24890
		TopLeft,
		// Token: 0x0400613B RID: 24891
		Top,
		// Token: 0x0400613C RID: 24892
		TopRight,
		// Token: 0x0400613D RID: 24893
		Right,
		// Token: 0x0400613E RID: 24894
		BottomRight,
		// Token: 0x0400613F RID: 24895
		Bottom,
		// Token: 0x04006140 RID: 24896
		Center
	}
}
