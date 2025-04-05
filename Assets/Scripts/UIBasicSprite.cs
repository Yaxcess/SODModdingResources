using System;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

// Token: 0x02000F46 RID: 3910
public abstract class UIBasicSprite : UIWidget
{
	// Token: 0x170008EA RID: 2282
	// (get) Token: 0x060061B3 RID: 25011 RVA: 0x000429E7 File Offset: 0x00040BE7
	// (set) Token: 0x060061B4 RID: 25012 RVA: 0x000429EF File Offset: 0x00040BEF
	

	// Token: 0x170008EC RID: 2284
	// (get) Token: 0x060061B7 RID: 25015 RVA: 0x00042A27 File Offset: 0x00040C27
	// (set) Token: 0x060061B8 RID: 25016 RVA: 0x00042A2F File Offset: 0x00040C2F
	public UIBasicSprite.FillDirection fillDirection
	{
		get
		{
			return this.mFillDirection;
		}
		set
		{
			if (this.mFillDirection != value)
			{
				this.mFillDirection = value;
				this.mChanged = true;
			}
		}
	}

	

	// Token: 0x04005FD0 RID: 24528
	[HideInInspector]
	[SerializeField]
	protected UIBasicSprite.Type mType;

	// Token: 0x04005FD1 RID: 24529
	[HideInInspector]
	[SerializeField]
	protected UIBasicSprite.FillDirection mFillDirection = UIBasicSprite.FillDirection.Radial360;

	// Token: 0x04005FD2 RID: 24530
	[Range(0f, 1f)]
	[HideInInspector]
	[SerializeField]
	protected float mFillAmount = 1f;

	// Token: 0x04005FD3 RID: 24531
	[HideInInspector]
	[SerializeField]
	protected bool mInvert;

	// Token: 0x04005FD4 RID: 24532
	[HideInInspector]
	[SerializeField]
	protected UIBasicSprite.Flip mFlip;

	// Token: 0x04005FD5 RID: 24533
	[HideInInspector]
	[SerializeField]
	protected bool mApplyGradient;

	// Token: 0x04005FD6 RID: 24534
	[HideInInspector]
	[SerializeField]
	protected Color mGradientTop = Color.white;

	// Token: 0x04005FD7 RID: 24535
	[HideInInspector]
	[SerializeField]
	protected Color mGradientBottom = new Color(0.7f, 0.7f, 0.7f);

	// Token: 0x04005FD8 RID: 24536
	[NonSerialized]
	private Rect mInnerUV;

	// Token: 0x04005FD9 RID: 24537
	[NonSerialized]
	private Rect mOuterUV;

	// Token: 0x04005FDA RID: 24538
	public UIBasicSprite.AdvancedType centerType = UIBasicSprite.AdvancedType.Sliced;

	// Token: 0x04005FDB RID: 24539
	public UIBasicSprite.AdvancedType leftType = UIBasicSprite.AdvancedType.Sliced;

	// Token: 0x04005FDC RID: 24540
	public UIBasicSprite.AdvancedType rightType = UIBasicSprite.AdvancedType.Sliced;

	// Token: 0x04005FDD RID: 24541
	public UIBasicSprite.AdvancedType bottomType = UIBasicSprite.AdvancedType.Sliced;

	// Token: 0x04005FDE RID: 24542
	public UIBasicSprite.AdvancedType topType = UIBasicSprite.AdvancedType.Sliced;

	// Token: 0x04005FDF RID: 24543
	protected static Vector2[] mTempPos = new Vector2[4];

	// Token: 0x04005FE0 RID: 24544
	protected static Vector2[] mTempUVs = new Vector2[4];

	// Token: 0x02000F47 RID: 3911
	public enum Type
	{
		// Token: 0x04005FE2 RID: 24546
		Simple,
		// Token: 0x04005FE3 RID: 24547
		Sliced,
		// Token: 0x04005FE4 RID: 24548
		Tiled,
		// Token: 0x04005FE5 RID: 24549
		Filled,
		// Token: 0x04005FE6 RID: 24550
		Advanced
	}

	// Token: 0x02000F48 RID: 3912
	public enum FillDirection
	{
		// Token: 0x04005FE8 RID: 24552
		Horizontal,
		// Token: 0x04005FE9 RID: 24553
		Vertical,
		// Token: 0x04005FEA RID: 24554
		Radial90,
		// Token: 0x04005FEB RID: 24555
		Radial180,
		// Token: 0x04005FEC RID: 24556
		Radial360
	}

	// Token: 0x02000F49 RID: 3913
	public enum AdvancedType
	{
		// Token: 0x04005FEE RID: 24558
		Invisible,
		// Token: 0x04005FEF RID: 24559
		Sliced,
		// Token: 0x04005FF0 RID: 24560
		Tiled
	}

	// Token: 0x02000F4A RID: 3914
	public enum Flip
	{
		// Token: 0x04005FF2 RID: 24562
		Nothing,
		// Token: 0x04005FF3 RID: 24563
		Horizontally,
		// Token: 0x04005FF4 RID: 24564
		Vertically,
		// Token: 0x04005FF5 RID: 24565
		Both
	}
}
