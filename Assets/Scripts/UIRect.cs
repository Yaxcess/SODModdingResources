using System;
using UnityEngine;

// Token: 0x02000F59 RID: 3929
public abstract class UIRect : KAMonoBase
{
	
	// Token: 0x06006261 RID: 25185
	protected abstract void OnStart();

	// Token: 0x06006262 RID: 25186 RVA: 0x00006173 File Offset: 0x00004373
	protected virtual void OnUpdate()
	{
	}

	
	// Token: 0x04006048 RID: 24648
	public UIRect.AnchorUpdate updateAnchors = UIRect.AnchorUpdate.OnUpdate;

	// Token: 0x04006049 RID: 24649
	[NonSerialized]
	protected GameObject mGo;

	// Token: 0x0400604A RID: 24650
	[NonSerialized]
	protected Transform mTrans;

	// Token: 0x0400604B RID: 24651
	[NonSerialized]
	protected BetterList<UIRect> mChildren = new BetterList<UIRect>();

	// Token: 0x0400604C RID: 24652
	[NonSerialized]
	protected bool mChanged = true;

	// Token: 0x0400604D RID: 24653
	[NonSerialized]
	protected bool mParentFound;

	// Token: 0x0400604E RID: 24654
	[NonSerialized]
	private bool mUpdateAnchors = true;

	// Token: 0x0400604F RID: 24655
	[NonSerialized]
	private int mUpdateFrame = -1;

	// Token: 0x04006050 RID: 24656
	[NonSerialized]
	private bool mAnchorsCached;

	// Token: 0x04006051 RID: 24657
	[NonSerialized]
	private UIRoot mRoot;

	// Token: 0x04006052 RID: 24658
	[NonSerialized]
	private UIRect mParent;

	// Token: 0x04006053 RID: 24659
	[NonSerialized]
	private bool mRootSet;

	// Token: 0x04006054 RID: 24660
	[NonSerialized]
	protected Camera mCam;

	// Token: 0x04006055 RID: 24661
	protected bool mStarted;

	// Token: 0x04006056 RID: 24662
	[NonSerialized]
	public float finalAlpha = 1f;

	// Token: 0x04006057 RID: 24663
	protected static Vector3[] mSides = new Vector3[4];

	// Token: 0x02000F5A RID: 3930
	

	// Token: 0x02000F5B RID: 3931
	public enum AnchorUpdate
	{
		// Token: 0x0400605E RID: 24670
		OnEnable,
		// Token: 0x0400605F RID: 24671
		OnUpdate,
		// Token: 0x04006060 RID: 24672
		OnStart
	}
}
