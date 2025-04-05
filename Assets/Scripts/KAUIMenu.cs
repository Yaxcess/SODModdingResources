using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x02000DE4 RID: 3556
public class KAUIMenu : KAUI
{

	// Token: 0x0400572A RID: 22314
	public KAUI _ParentUi;

	// Token: 0x0400572B RID: 22315
	public KAWidget _Template;

	// Token: 0x0400572C RID: 22316
	public KAUIMenuGrid _DefaultGrid;

	// Token: 0x0400572D RID: 22317
	public bool _CenterOnItem;

	// Token: 0x0400572E RID: 22318
	public bool _PageFlip;

	// Token: 0x0400572F RID: 22319
	public bool _ResetItemsOnVisibility = true;

	// Token: 0x04005730 RID: 22320
	public bool _PageFlipSnapOnRelease = true;

	// Token: 0x04005731 RID: 22321
	public float _PageSnapStrength = 10f;

	// Token: 0x04005732 RID: 22322
	public float _CenterSnapStrength = 10f;

	// Token: 0x04005733 RID: 22323
	public float _ScrollDelta = 0.1f;

	// Token: 0x04005734 RID: 22324
	public bool _AllowDrag = true;

	// Token: 0x04005735 RID: 22325
	public bool _OnlyUpdateWhenBecomingVisible;

	// Token: 0x04005736 RID: 22326
	public bool _EnableGridLayoutForDevices;

	// Token: 0x04005737 RID: 22327
	public KAUIMenu.GridLayoutProperties _GridLayoutSmallDevices;

	// Token: 0x04005738 RID: 22328
	public KAUIMenu.GridLayoutProperties _GridLayoutLargeDevices;

	// Token: 0x04005739 RID: 22329
	public KAWidget _HighlightWidget;

	// Token: 0x0400573A RID: 22330
	public KAWidget _SelectedWidget;

	// Token: 0x0400573B RID: 22331
	public KAWidget _PageNumberWidget;

	// Token: 0x0400573C RID: 22332
	public LocaleString _PageNumberText = new LocaleString("Page");

	// Token: 0x0400573D RID: 22333
	public GameObject _BackgroundObject;

	// Token: 0x0400573E RID: 22334
	public OptimizedMenu _OptimizedMenu;

	// Token: 0x0400573F RID: 22335
	public Collider _Collider;

	// Token: 0x04005740 RID: 22336
	[SerializeField]
	protected int _ItemPoolCount = 10;

	// Token: 0x04005741 RID: 22337
	[SerializeField]
	protected int _ItemPoolBaseCount;

	// Token: 0x04005742 RID: 22338
	protected bool mViewChanged = true;

	// Token: 0x04005743 RID: 22339
	protected KAUIDraggablePanel mDragPanel;

	// Token: 0x04005744 RID: 22340
	protected KAScrollBar mVerticalScrollbar;

	// Token: 0x04005745 RID: 22341
	protected KAScrollBar mHorizontalScrollbar;

	// Token: 0x04005746 RID: 22342
	protected UIPanel mPanel;

	// Token: 0x04005747 RID: 22343
	protected KAUIMenuGrid mCurrentGrid;

	// Token: 0x04005748 RID: 22344
	protected KAWidget mSelectedItem;

	// Token: 0x04005749 RID: 22345
	protected UICenterOnChild mCenterOnChild;

	// Token: 0x0400574A RID: 22346
	protected SpringPanel mSpringPanel;

	// Token: 0x0400574B RID: 22347
	protected bool mRecenterItem;

	// Token: 0x0400574C RID: 22348
	protected Stack mPoolWidgets = new Stack();

	// Token: 0x0400574D RID: 22349
	protected GameObject mPool;

	// Token: 0x0400574E RID: 22350
	protected int mPageCount = 1;

	// Token: 0x0400574F RID: 22351
	protected int mCurrentPage = 1;

	// Token: 0x04005752 RID: 22354
	protected Vector3 mInitialPosition;

	// Token: 0x04005755 RID: 22357
	protected Vector3 mLastPosition = Vector3.zero;

	// Token: 0x04005758 RID: 22360
	public KAUIMenu.OnPageChange onPageChange;

	// Token: 0x02000DE5 RID: 3557
	[Serializable]
	public class GridLayoutProperties
	{
		// Token: 0x0400575A RID: 22362
		public int _MaxItemsPerLine = 3;

		// Token: 0x0400575B RID: 22363
		public float _CellWidth = 165f;

		// Token: 0x0400575C RID: 22364
		public float _CellHeight = 200f;

		// Token: 0x0400575D RID: 22365
		public Vector3 _GridStartPosition = new Vector3(-398f, 382f, 0f);

		// Token: 0x0400575E RID: 22366
		public KAWidget _Template;

		// Token: 0x0400575F RID: 22367
		public KAWidget _HighlightWidget;

		// Token: 0x04005760 RID: 22368
		public KAWidget _SelectedWidget;
	}

	// Token: 0x02000DE6 RID: 3558
	// (Invoke) Token: 0x06005791 RID: 22417
	public delegate void OnPageChange(int pageNumber);
}
