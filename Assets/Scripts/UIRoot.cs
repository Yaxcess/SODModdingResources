using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x02000FB6 RID: 4022
[ExecuteInEditMode]
public class UIRoot : MonoBehaviour
{
	

	// Token: 0x040062CD RID: 25293
	public static List<UIRoot> list = new List<UIRoot>();

	// Token: 0x040062CE RID: 25294
	public UIRoot.Scaling scalingStyle;

	// Token: 0x040062CF RID: 25295
	public int manualWidth = 1280;

	// Token: 0x040062D0 RID: 25296
	public int manualHeight = 720;

	// Token: 0x040062D1 RID: 25297
	public int minimumHeight = 320;

	// Token: 0x040062D2 RID: 25298
	public int maximumHeight = 1536;

	// Token: 0x040062D3 RID: 25299
	public bool fitWidth;

	// Token: 0x040062D4 RID: 25300
	public bool fitHeight = true;

	// Token: 0x040062D5 RID: 25301
	public bool adjustByDPI;

	// Token: 0x040062D6 RID: 25302
	public bool shrinkPortraitUI;

	// Token: 0x040062D7 RID: 25303
	private Transform mTrans;

	// Token: 0x02000FB7 RID: 4023
	public enum Scaling
	{
		// Token: 0x040062D9 RID: 25305
		Flexible,
		// Token: 0x040062DA RID: 25306
		Constrained,
		// Token: 0x040062DB RID: 25307
		ConstrainedOnMobiles
	}

	// Token: 0x02000FB8 RID: 4024
	public enum Constraint
	{
		// Token: 0x040062DD RID: 25309
		Fit,
		// Token: 0x040062DE RID: 25310
		Fill,
		// Token: 0x040062DF RID: 25311
		FitWidth,
		// Token: 0x040062E0 RID: 25312
		FitHeight
	}
}
