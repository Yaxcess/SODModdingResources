using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;



public class UIWidget : UIRect
{

    // Token: 0x04006065 RID: 24677
    [HideInInspector]
    [SerializeField]
    protected Color mColor = Color.white;

    // Token: 0x04006066 RID: 24678
    [HideInInspector]
    [SerializeField]
    protected UIWidget.Pivot mPivot = UIWidget.Pivot.Center;

    // Token: 0x04006067 RID: 24679
    [HideInInspector]
    [SerializeField]
    protected int mWidth = 100;

    // Token: 0x04006068 RID: 24680
    [HideInInspector]
    [SerializeField]
    protected int mHeight = 100;

    // Token: 0x04006069 RID: 24681
    [HideInInspector]
    [SerializeField]
    protected int mDepth;

    // Token: 0x0400606A RID: 24682
    [Tooltip("Custom material, if desired")]
    [HideInInspector]
    [SerializeField]
    protected Material mMat;

    // Token: 0x0400606B RID: 24683
    public UIWidget.OnDimensionsChanged onChange;

    // Token: 0x0400606C RID: 24684
    public UIWidget.OnPostFillCallback onPostFill;

    // Token: 0x0400606D RID: 24685
    public UIDrawCall.OnRenderCallback mOnRender;

    // Token: 0x0400606E RID: 24686
    public bool autoResizeBoxCollider;

    // Token: 0x0400606F RID: 24687
    public bool hideIfOffScreen;

    // Token: 0x04006070 RID: 24688
    public UIWidget.AspectRatioSource keepAspectRatio;

    // Token: 0x04006071 RID: 24689
    public float aspectRatio = 1f;

    // Token: 0x04006072 RID: 24690
    public UIWidget.HitCheck hitCheck;

    // Token: 0x04006073 RID: 24691
    [NonSerialized]
    public UIPanel panel;

    // Token: 0x04006074 RID: 24692
    [NonSerialized]
    public UIGeometry geometry = new UIGeometry();

    // Token: 0x04006075 RID: 24693
    [NonSerialized]
    public bool fillGeometry = true;

    // Token: 0x04006076 RID: 24694
    [NonSerialized]
    protected bool mPlayMode = true;

    // Token: 0x04006077 RID: 24695
    [NonSerialized]
    protected Vector4 mDrawRegion = new Vector4(0f, 0f, 1f, 1f);

    // Token: 0x04006078 RID: 24696
    [NonSerialized]
    private Matrix4x4 mLocalToPanel;

    // Token: 0x04006079 RID: 24697
    [NonSerialized]
    private bool mIsVisibleByAlpha = true;

    // Token: 0x0400607A RID: 24698
    [NonSerialized]
    private bool mIsVisibleByPanel = true;

    // Token: 0x0400607B RID: 24699
    [NonSerialized]
    private bool mIsInFront = true;

    // Token: 0x0400607C RID: 24700
    [NonSerialized]
    private float mLastAlpha;

    // Token: 0x0400607D RID: 24701
    [NonSerialized]
    private bool mMoved;

    // Token: 0x0400607E RID: 24702
    private Vector3 mOrgPosition;

    // Token: 0x0400607F RID: 24703
    private Vector3 mOrgScale;

    // Token: 0x04006080 RID: 24704
    private Color mOrgColorTint;

    // Token: 0x04006081 RID: 24705
    private int mOrgDepth;

    // Token: 0x04006082 RID: 24706
    [NonSerialized]
    public UIDrawCall drawCall;

    // Token: 0x04006083 RID: 24707
    [NonSerialized]
    protected Vector3[] mCorners = new Vector3[4];

    // Token: 0x04006084 RID: 24708
    [NonSerialized]
    private int mAlphaFrameID = -1;

    // Token: 0x04006085 RID: 24709
    private int mMatrixFrame = -1;

    // Token: 0x04006086 RID: 24710
    private Vector3 mOldV0;

    // Token: 0x04006087 RID: 24711
    private Vector3 mOldV1;

    // Token: 0x02000F5E RID: 3934
    public enum Pivot
    {
        // Token: 0x04006089 RID: 24713
        TopLeft,
        // Token: 0x0400608A RID: 24714
        Top,
        // Token: 0x0400608B RID: 24715
        TopRight,
        // Token: 0x0400608C RID: 24716
        Left,
        // Token: 0x0400608D RID: 24717
        Center,
        // Token: 0x0400608E RID: 24718
        Right,
        // Token: 0x0400608F RID: 24719
        BottomLeft,
        // Token: 0x04006090 RID: 24720
        Bottom,
        // Token: 0x04006091 RID: 24721
        BottomRight
    }

    // Token: 0x02000F5F RID: 3935
    // (Invoke) Token: 0x060062C3 RID: 25283
    public delegate void OnDimensionsChanged();

    // Token: 0x02000F60 RID: 3936
    // (Invoke) Token: 0x060062C7 RID: 25287
    public delegate void OnPostFillCallback(UIWidget widget, int bufferOffset, List<Vector3> verts, List<Vector2> uvs, List<Color> cols);

    // Token: 0x02000F61 RID: 3937
    public enum AspectRatioSource
    {
        // Token: 0x04006093 RID: 24723
        Free,
        // Token: 0x04006094 RID: 24724
        BasedOnWidth,
        // Token: 0x04006095 RID: 24725
        BasedOnHeight
    }

    // Token: 0x02000F62 RID: 3938
    // (Invoke) Token: 0x060062CB RID: 25291
    public delegate bool HitCheck(Vector3 worldPos);
}

