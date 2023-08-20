using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x02000FA0 RID: 4000
[ExecuteInEditMode]
[AddComponentMenu("NGUI/UI/NGUI Font")]
public class UIFont : MonoBehaviour
{
	

	// Token: 0x040061FC RID: 25084
	[HideInInspector]
	[SerializeField]
	private Material mMat;

	// Token: 0x040061FD RID: 25085
	[HideInInspector]
	[SerializeField]
	private Rect mUVRect = new Rect(0f, 0f, 1f, 1f);


	// Token: 0x040061FF RID: 25087
	[HideInInspector]
	[SerializeField]
	private UIAtlas mAtlas;

	// Token: 0x04006200 RID: 25088
	[HideInInspector]
	[SerializeField]
	private UIFont mReplacement;


	// Token: 0x04006202 RID: 25090
	[HideInInspector]
	[SerializeField]
	private Font mDynamicFont;

	// Token: 0x04006203 RID: 25091
	[HideInInspector]
	[SerializeField]
	private int mDynamicFontSize = 16;

	// Token: 0x04006204 RID: 25092
	[HideInInspector]
	[SerializeField]
	private FontStyle mDynamicFontStyle;

	// Token: 0x04006205 RID: 25093
	[NonSerialized]
	private UISpriteData mSprite;

	// Token: 0x04006206 RID: 25094
	private int mPMA = -1;

	// Token: 0x04006207 RID: 25095
	private int mPacked = -1;
}
