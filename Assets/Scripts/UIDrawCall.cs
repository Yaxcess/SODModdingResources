using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

// Token: 0x02000F4B RID: 3915
[ExecuteInEditMode]

public class UIDrawCall : MonoBehaviour
{
	
	// Token: 0x04005FF8 RID: 24568
	private static BetterList<UIDrawCall> mActiveList = new BetterList<UIDrawCall>();

	// Token: 0x04005FF9 RID: 24569
	private static BetterList<UIDrawCall> mInactiveList = new BetterList<UIDrawCall>();

	// Token: 0x04005FFA RID: 24570
	[HideInInspector]
	[NonSerialized]
	public int widgetCount;

	// Token: 0x04005FFB RID: 24571
	[HideInInspector]
	[NonSerialized]
	public int depthStart = int.MaxValue;

	// Token: 0x04005FFC RID: 24572
	[HideInInspector]
	[NonSerialized]
	public int depthEnd = int.MinValue;

	// Token: 0x04005FFD RID: 24573
	[HideInInspector]
	[NonSerialized]
	public UIPanel manager;

	// Token: 0x04005FFE RID: 24574
	[HideInInspector]
	[NonSerialized]
	public UIPanel panel;

	// Token: 0x04005FFF RID: 24575
	[HideInInspector]
	[NonSerialized]
	public Texture2D clipTexture;

	// Token: 0x04006000 RID: 24576
	[HideInInspector]
	[NonSerialized]
	public bool alwaysOnScreen;

	// Token: 0x04006001 RID: 24577
	[HideInInspector]
	[NonSerialized]
	public List<Vector3> verts = new List<Vector3>();

	// Token: 0x04006002 RID: 24578
	[HideInInspector]
	[NonSerialized]
	public List<Vector3> norms = new List<Vector3>();

	// Token: 0x04006003 RID: 24579
	[HideInInspector]
	[NonSerialized]
	public List<Vector4> tans = new List<Vector4>();

	// Token: 0x04006004 RID: 24580
	[HideInInspector]
	[NonSerialized]
	public List<Vector2> uvs = new List<Vector2>();

	// Token: 0x04006005 RID: 24581
	[HideInInspector]
	[NonSerialized]
	public List<Vector4> uv2 = new List<Vector4>();

	// Token: 0x04006006 RID: 24582
	[HideInInspector]
	[NonSerialized]
	public List<Color> cols = new List<Color>();

	// Token: 0x04006007 RID: 24583
	[NonSerialized]
	private Material mMaterial;

	// Token: 0x04006008 RID: 24584
	[NonSerialized]
	private Texture mTexture;

	// Token: 0x04006009 RID: 24585
	[NonSerialized]
	private Shader mShader;

	// Token: 0x0400600A RID: 24586
	[NonSerialized]
	private int mClipCount;

	// Token: 0x0400600B RID: 24587
	[NonSerialized]
	private Transform mTrans;

	// Token: 0x0400600C RID: 24588
	[NonSerialized]
	private Mesh mMesh;

	// Token: 0x0400600D RID: 24589
	[NonSerialized]
	private MeshFilter mFilter;

	// Token: 0x0400600E RID: 24590
	[NonSerialized]
	private MeshRenderer mRenderer;

	// Token: 0x0400600F RID: 24591
	[NonSerialized]
	private Material mDynamicMat;

	// Token: 0x04006010 RID: 24592
	[NonSerialized]
	private int[] mIndices;

	// Token: 0x04006011 RID: 24593
	[NonSerialized]
	private UIDrawCall.ShadowMode mShadowMode;

	// Token: 0x04006012 RID: 24594
	[NonSerialized]
	private bool mRebuildMat = true;

	// Token: 0x04006013 RID: 24595
	[NonSerialized]
	private bool mLegacyShader;

	// Token: 0x04006014 RID: 24596
	[NonSerialized]
	private int mRenderQueue = 3000;

	// Token: 0x04006015 RID: 24597
	[NonSerialized]
	private int mTriangles;

	// Token: 0x04006016 RID: 24598
	[NonSerialized]
	public bool isDirty;

	// Token: 0x04006017 RID: 24599
	[NonSerialized]
	private bool mTextureClip;

	// Token: 0x04006018 RID: 24600
	[NonSerialized]
	private bool mIsNew = true;

	// Token: 0x04006019 RID: 24601
	public UIDrawCall.OnRenderCallback onRender;

	// Token: 0x0400601A RID: 24602
	public UIDrawCall.OnCreateDrawCall onCreateDrawCall;

	// Token: 0x0400601B RID: 24603
	[NonSerialized]
	private string mSortingLayerName;

	// Token: 0x0400601C RID: 24604
	[NonSerialized]
	private int mSortingOrder;

	// Token: 0x0400601D RID: 24605
	private static ColorSpace mColorSpace = ColorSpace.Uninitialized;

	// Token: 0x0400601E RID: 24606
	private const int maxIndexBufferCache = 10;

	// Token: 0x0400601F RID: 24607
	private static List<int[]> mCache = new List<int[]>(10);

	// Token: 0x04006020 RID: 24608
	protected MaterialPropertyBlock mBlock;

	// Token: 0x04006021 RID: 24609
	private static int[] ClipRange = null;

	// Token: 0x04006022 RID: 24610
	private static int[] ClipArgs = null;

	// Token: 0x04006023 RID: 24611
	private static int dx9BugWorkaround = -1;

	// Token: 0x02000F4C RID: 3916
	public enum Clipping
	{
		// Token: 0x04006025 RID: 24613
		None,
		// Token: 0x04006026 RID: 24614
		TextureMask,
		// Token: 0x04006027 RID: 24615
		SoftClip = 3,
		// Token: 0x04006028 RID: 24616
		ConstrainButDontClip
	}

	// Token: 0x02000F4D RID: 3917
	// (Invoke) Token: 0x060061FD RID: 25085
	public delegate void OnRenderCallback(Material mat);

	// Token: 0x02000F4E RID: 3918
	// (Invoke) Token: 0x06006201 RID: 25089
	public delegate void OnCreateDrawCall(UIDrawCall dc, MeshFilter filter, MeshRenderer ren);

	// Token: 0x02000F4F RID: 3919
	public enum ShadowMode
	{
		// Token: 0x0400602A RID: 24618
		None,
		// Token: 0x0400602B RID: 24619
		Receive,
		// Token: 0x0400602C RID: 24620
		CastAndReceive
	}
}
