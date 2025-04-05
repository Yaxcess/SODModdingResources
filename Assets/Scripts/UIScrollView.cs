using System;
using UnityEngine;
using JSGames.UI;

// Token: 0x02000F14 RID: 3860
[ExecuteInEditMode]
[RequireComponent(typeof(UIPanel))]
[AddComponentMenu("NGUI/Interaction/Scroll View")]
public class UIScrollView : MonoBehaviour
{

	// Token: 0x04005EA5 RID: 24229
	public static BetterList<UIScrollView> list = new BetterList<UIScrollView>();

	// Token: 0x04005EA6 RID: 24230
	public UIScrollView.Movement movement;

	// Token: 0x04005EA7 RID: 24231
	public UIScrollView.DragEffect dragEffect = UIScrollView.DragEffect.MomentumAndSpring;

	// Token: 0x04005EA8 RID: 24232
	public bool restrictWithinPanel = true;

	// Token: 0x04005EA9 RID: 24233
	[Tooltip("Whether the scroll view will execute its constrain within bounds logic on every drag operation")]
	public bool constrainOnDrag;

	// Token: 0x04005EAA RID: 24234
	public bool disableDragIfFits;

	// Token: 0x04005EAB RID: 24235
	public bool smoothDragStart = true;

	// Token: 0x04005EAC RID: 24236
	public bool iOSDragEmulation = true;

	// Token: 0x04005EAD RID: 24237
	public float scrollWheelFactor = 0.25f;

	// Token: 0x04005EAE RID: 24238
	public float momentumAmount = 35f;

	// Token: 0x04005EAF RID: 24239
	public float dampenStrength = 9f;

	// Token: 0x04005EB0 RID: 24240
	public UIProgressBar horizontalScrollBar;

	// Token: 0x04005EB1 RID: 24241
	public UIProgressBar verticalScrollBar;

	// Token: 0x04005EB2 RID: 24242
	public UIScrollView.ShowCondition showScrollBars = UIScrollView.ShowCondition.OnlyIfNeeded;

	// Token: 0x04005EB3 RID: 24243
	public Vector2 customMovement = new Vector2(1f, 0f);

	// Token: 0x04005EB4 RID: 24244
	public UIWidget.Pivot contentPivot;

	// Token: 0x04005EB5 RID: 24245
	public UIScrollView.OnDragNotification onDragStarted;

	// Token: 0x04005EB6 RID: 24246
	public UIScrollView.OnDragNotification onDragFinished;

	// Token: 0x04005EB7 RID: 24247
	public UIScrollView.OnDragNotification onMomentumMove;

	// Token: 0x04005EB8 RID: 24248
	public UIScrollView.OnDragNotification onStoppedMoving;

	// Token: 0x04005EBB RID: 24251
	protected Transform mTrans;

	// Token: 0x04005EBC RID: 24252
	protected UIPanel mPanel;

	// Token: 0x04005EBD RID: 24253
	protected Plane mPlane;

	// Token: 0x04005EBE RID: 24254
	protected Vector3 mLastPos;

	// Token: 0x04005EBF RID: 24255
	protected bool mPressed;

	// Token: 0x04005EC0 RID: 24256
	protected Vector3 mMomentum = Vector3.zero;

	// Token: 0x04005EC1 RID: 24257
	protected float mScroll;

	// Token: 0x04005EC2 RID: 24258
	protected Bounds mBounds;

	// Token: 0x04005EC3 RID: 24259
	protected bool mCalculatedBounds;

	// Token: 0x04005EC4 RID: 24260
	protected bool mShouldMove;

	// Token: 0x04005EC5 RID: 24261
	protected bool mIgnoreCallbacks;

	// Token: 0x04005EC6 RID: 24262
	protected int mDragID = -10;

	// Token: 0x04005EC7 RID: 24263
	protected Vector2 mDragStartOffset = Vector2.zero;

	// Token: 0x04005EC8 RID: 24264
	protected bool mDragStarted;

	// Token: 0x04005EC9 RID: 24265
	[NonSerialized]
	private bool mStarted;

	// Token: 0x04005ECA RID: 24266
	[HideInInspector]
	public UICenterOnChild centerOnChild;

	// Token: 0x02000F15 RID: 3861
	public enum Movement
	{
		// Token: 0x04005ECC RID: 24268
		Horizontal,
		// Token: 0x04005ECD RID: 24269
		Vertical,
		// Token: 0x04005ECE RID: 24270
		Unrestricted,
		// Token: 0x04005ECF RID: 24271
		Custom
	}

	// Token: 0x02000F16 RID: 3862
	public enum DragEffect
	{
		// Token: 0x04005ED1 RID: 24273
		None,
		// Token: 0x04005ED2 RID: 24274
		Momentum,
		// Token: 0x04005ED3 RID: 24275
		MomentumAndSpring
	}

	// Token: 0x02000F17 RID: 3863
	public enum ShowCondition
	{
		// Token: 0x04005ED5 RID: 24277
		Always,
		// Token: 0x04005ED6 RID: 24278
		OnlyIfNeeded,
		// Token: 0x04005ED7 RID: 24279
		WhenDragging
	}

	// Token: 0x02000F18 RID: 3864
	// (Invoke) Token: 0x06005FD1 RID: 24529
	public delegate void OnDragNotification();
}
