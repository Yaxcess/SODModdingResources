using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x02000FC2 RID: 4034
[ExecuteInEditMode]
[AddComponentMenu("NGUI/UI/NGUI Texture")]
public class UITexture : UIBasicSprite
{
	

	// Token: 0x04006325 RID: 25381
	[HideInInspector]
	[SerializeField]
	private Rect mRect = new Rect(0f, 0f, 1f, 1f);

	// Token: 0x04006326 RID: 25382
	[HideInInspector]
	[SerializeField]
	private Texture mTexture;

	// Token: 0x04006327 RID: 25383
	[HideInInspector]
	[SerializeField]
	private Shader mShader;

	// Token: 0x04006328 RID: 25384
	[HideInInspector]
	[SerializeField]
	private Vector4 mBorder = Vector4.zero;

	// Token: 0x04006329 RID: 25385
	[HideInInspector]
	[SerializeField]
	private bool mFixedAspect;

	// Token: 0x0400632A RID: 25386
	[NonSerialized]
	private int mPMA = -1;
}
