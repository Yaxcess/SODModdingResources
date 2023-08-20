using System;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

// Token: 0x02000F46 RID: 3910
public abstract class UIBasicSprite : UIWidget
{
	
	// Token: 0x04005FD2 RID: 24530
	[HideInInspector]
	[SerializeField]
	protected UIBasicSprite.Type mType;

	// Token: 0x04005FD3 RID: 24531
	[HideInInspector]
	[SerializeField]
	protected UIBasicSprite.FillDirection mFillDirection = UIBasicSprite.FillDirection.Radial360;

	// Token: 0x04005FD4 RID: 24532
	[Range(0f, 1f)]
	[HideInInspector]
	[SerializeField]
	protected float mFillAmount = 1f;

	// Token: 0x04005FD5 RID: 24533
	[HideInInspector]
	[SerializeField]
	protected bool mInvert;

	// Token: 0x04005FD6 RID: 24534
	[HideInInspector]
	[SerializeField]
	protected UIBasicSprite.Flip mFlip;

	// Token: 0x04005FD7 RID: 24535
	[HideInInspector]
	[SerializeField]
	protected bool mApplyGradient;

	// Token: 0x04005FD8 RID: 24536
	[HideInInspector]
	[SerializeField]
	protected Color mGradientTop = Color.white;

	// Token: 0x04005FD9 RID: 24537
	[HideInInspector]
	[SerializeField]
	protected Color mGradientBottom = new Color(0.7f, 0.7f, 0.7f);

	// Token: 0x04005FDA RID: 24538
	[NonSerialized]
	private Rect mInnerUV;

	// Token: 0x04005FDB RID: 24539
	[NonSerialized]
	private Rect mOuterUV;

	// Token: 0x04005FDC RID: 24540
	public UIBasicSprite.AdvancedType centerType = UIBasicSprite.AdvancedType.Sliced;

	// Token: 0x04005FDD RID: 24541
	public UIBasicSprite.AdvancedType leftType = UIBasicSprite.AdvancedType.Sliced;

	// Token: 0x04005FDE RID: 24542
	public UIBasicSprite.AdvancedType rightType = UIBasicSprite.AdvancedType.Sliced;

	// Token: 0x04005FDF RID: 24543
	public UIBasicSprite.AdvancedType bottomType = UIBasicSprite.AdvancedType.Sliced;

	// Token: 0x04005FE0 RID: 24544
	public UIBasicSprite.AdvancedType topType = UIBasicSprite.AdvancedType.Sliced;

	// Token: 0x04005FE1 RID: 24545
	protected static Vector2[] mTempPos = new Vector2[4];

	// Token: 0x04005FE2 RID: 24546
	protected static Vector2[] mTempUVs = new Vector2[4];

	// Token: 0x02000F47 RID: 3911
	public enum Type
	{
		// Token: 0x04005FE4 RID: 24548
		Simple,
		// Token: 0x04005FE5 RID: 24549
		Sliced,
		// Token: 0x04005FE6 RID: 24550
		Tiled,
		// Token: 0x04005FE7 RID: 24551
		Filled,
		// Token: 0x04005FE8 RID: 24552
		Advanced
	}

	// Token: 0x02000F48 RID: 3912
	public enum FillDirection
	{
		// Token: 0x04005FEA RID: 24554
		Horizontal,
		// Token: 0x04005FEB RID: 24555
		Vertical,
		// Token: 0x04005FEC RID: 24556
		Radial90,
		// Token: 0x04005FED RID: 24557
		Radial180,
		// Token: 0x04005FEE RID: 24558
		Radial360
	}

	// Token: 0x02000F49 RID: 3913
	public enum AdvancedType
	{
		// Token: 0x04005FF0 RID: 24560
		Invisible,
		// Token: 0x04005FF1 RID: 24561
		Sliced,
		// Token: 0x04005FF2 RID: 24562
		Tiled
	}

	// Token: 0x02000F4A RID: 3914
	public enum Flip
	{
		// Token: 0x04005FF4 RID: 24564
		Nothing,
		// Token: 0x04005FF5 RID: 24565
		Horizontally,
		// Token: 0x04005FF6 RID: 24566
		Vertically,
		// Token: 0x04005FF7 RID: 24567
		Both
	}
}
