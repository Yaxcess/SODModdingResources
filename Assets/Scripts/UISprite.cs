using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x02000FBA RID: 4026
[ExecuteInEditMode]
[AddComponentMenu("NGUI/UI/NGUI Sprite")]
public class UISprite : UIBasicSprite
{
	

	// Token: 0x040062E1 RID: 25313
	//[HideInInspector]
	[SerializeField]
	private UIAtlas mAtlas;

	// Token: 0x040062E2 RID: 25314
	//[HideInInspector]
	[SerializeField]
	private string mSpriteName;

	// Token: 0x040062E3 RID: 25315
	//[HideInInspector]
	[SerializeField]
	private bool mFillCenter = true;

	// Token: 0x040062E4 RID: 25316
	[NonSerialized]
	protected UISpriteData mSprite;

	// Token: 0x040062E5 RID: 25317
	[NonSerialized]
	private bool mSpriteSet;

	// Token: 0x040062E6 RID: 25318
	private string mOrgSprite;
}
