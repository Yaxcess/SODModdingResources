using System;
using UnityEngine;

// Token: 0x02000F59 RID: 3929
public abstract class UIRect : KAMonoBase
{
    // Token: 0x04006042 RID: 24642
    public UIRect.AnchorPoint leftAnchor = new UIRect.AnchorPoint();

    // Token: 0x04006043 RID: 24643
    public UIRect.AnchorPoint rightAnchor = new UIRect.AnchorPoint(1f);

    // Token: 0x04006044 RID: 24644
    public UIRect.AnchorPoint bottomAnchor = new UIRect.AnchorPoint();

    // Token: 0x04006045 RID: 24645
    public UIRect.AnchorPoint topAnchor = new UIRect.AnchorPoint(1f);

    // Token: 0x04006046 RID: 24646
    public UIRect.AnchorUpdate updateAnchors = UIRect.AnchorUpdate.OnUpdate;

    // Token: 0x04006047 RID: 24647
    [NonSerialized]
    protected GameObject mGo;

    // Token: 0x04006048 RID: 24648
    [NonSerialized]
    protected Transform mTrans;

    // Token: 0x04006049 RID: 24649
    [NonSerialized]
    protected BetterList<UIRect> mChildren = new BetterList<UIRect>();

    // Token: 0x0400604A RID: 24650
    [NonSerialized]
    protected bool mChanged = true;

    // Token: 0x0400604B RID: 24651
    [NonSerialized]
    protected bool mParentFound;

    // Token: 0x0400604C RID: 24652
    [NonSerialized]
    private bool mUpdateAnchors = true;

    // Token: 0x0400604D RID: 24653
    [NonSerialized]
    private int mUpdateFrame = -1;

    // Token: 0x0400604E RID: 24654
    [NonSerialized]
    private bool mAnchorsCached;

    // Token: 0x0400604F RID: 24655
    [NonSerialized]
    private UIRoot mRoot;

    // Token: 0x04006050 RID: 24656
    [NonSerialized]
    private UIRect mParent;

    // Token: 0x04006051 RID: 24657
    [NonSerialized]
    private bool mRootSet;

    // Token: 0x04006052 RID: 24658
    [NonSerialized]
    protected Camera mCam;

    // Token: 0x04006053 RID: 24659
    protected bool mStarted;

    // Token: 0x04006054 RID: 24660
    [NonSerialized]
    public float finalAlpha = 1f;

    // Token: 0x04006055 RID: 24661
    protected static Vector3[] mSides = new Vector3[4];

    // Token: 0x02000F5A RID: 3930
    [Serializable]
    public class AnchorPoint
    {
        // Token: 0x06006265 RID: 25189 RVA: 0x000065ED File Offset: 0x000047ED
        public AnchorPoint()
        {
        }

        // Token: 0x06006266 RID: 25190 RVA: 0x000431B1 File Offset: 0x000413B1
        public AnchorPoint(float relative)
        {
            this.relative = relative;
        }

        // Token: 0x04006056 RID: 24662
        public Transform target;

        // Token: 0x04006057 RID: 24663
        public float relative;

        // Token: 0x04006058 RID: 24664
        public int absolute;

        // Token: 0x04006059 RID: 24665
        [NonSerialized]
        public UIRect rect;

        // Token: 0x0400605A RID: 24666
        [NonSerialized]
        public Camera targetCam;
    }

    // Token: 0x02000F5B RID: 3931
    public enum AnchorUpdate
    {
        // Token: 0x0400605C RID: 24668
        OnEnable,
        // Token: 0x0400605D RID: 24669
        OnUpdate,
        // Token: 0x0400605E RID: 24670
        OnStart
    }
}
