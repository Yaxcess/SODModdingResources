using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x02000FB1 RID: 4017
[ExecuteInEditMode]

public class UIPanel
{
	
	// Token: 0x0400629B RID: 25243
	public static List<UIPanel> list = new List<UIPanel>();

	// Token: 0x0400629C RID: 25244
	public UIPanel.OnGeometryUpdated onGeometryUpdated;

	// Token: 0x0400629D RID: 25245
	public bool showInPanelTool = true;

	// Token: 0x0400629E RID: 25246
	public bool generateNormals;

	// Token: 0x0400629F RID: 25247
	public bool generateUV2;

	// Token: 0x040062A0 RID: 25248
	public UIDrawCall.ShadowMode shadowMode;

	// Token: 0x040062A1 RID: 25249
	public bool widgetsAreStatic;

	// Token: 0x040062A2 RID: 25250
	public bool cullWhileDragging = true;

	// Token: 0x040062A3 RID: 25251
	public bool alwaysOnScreen;

	// Token: 0x040062A4 RID: 25252
	public bool anchorOffset;

	// Token: 0x040062A5 RID: 25253
	public bool softBorderPadding = true;

	// Token: 0x040062A6 RID: 25254
	public UIPanel.RenderQueue renderQueue;

	// Token: 0x040062A7 RID: 25255
	public int startingRenderQueue = 3000;

	// Token: 0x040062A8 RID: 25256
	[NonSerialized]
	public List<UIWidget> widgets = new List<UIWidget>();

	// Token: 0x040062A9 RID: 25257
	[NonSerialized]
	public List<UIDrawCall> drawCalls = new List<UIDrawCall>();

	// Token: 0x040062AA RID: 25258
	[NonSerialized]
	public Matrix4x4 worldToLocal = Matrix4x4.identity;

	// Token: 0x040062AB RID: 25259
	[NonSerialized]
	public Vector4 drawCallClipRange = new Vector4(0f, 0f, 1f, 1f);

	// Token: 0x040062AC RID: 25260
	public UIPanel.OnClippingMoved onClipMove;

	// Token: 0x040062AD RID: 25261
	public UIPanel.OnCreateMaterial onCreateMaterial;

	// Token: 0x040062AE RID: 25262
	public UIDrawCall.OnCreateDrawCall onCreateDrawCall;

	
	// Token: 0x040062B2 RID: 25266
	[HideInInspector]
	[SerializeField]
	public Vector4 mClipRange = new Vector4(0f, 0f, 300f, 200f);

	

	// Token: 0x02000FB2 RID: 4018
	public enum RenderQueue
	{
		// Token: 0x040062CA RID: 25290
		Automatic,
		// Token: 0x040062CB RID: 25291
		StartAt,
		// Token: 0x040062CC RID: 25292
		Explicit
	}

	// Token: 0x02000FB3 RID: 4019
	// (Invoke) Token: 0x060065BD RID: 26045
	public delegate void OnGeometryUpdated();

	// Token: 0x02000FB4 RID: 4020
	// (Invoke) Token: 0x060065C1 RID: 26049
	public delegate void OnClippingMoved(UIPanel panel);

	// Token: 0x02000FB5 RID: 4021
	// (Invoke) Token: 0x060065C5 RID: 26053
	public delegate Material OnCreateMaterial(UIWidget widget, Material mat);
}
