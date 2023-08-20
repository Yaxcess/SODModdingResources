using System;

// Token: 0x02000DBC RID: 3516
[Serializable]
public class KAAnimInfo
{
	
	// Token: 0x04005636 RID: 22070
	public float _Length;

	// Token: 0x04005637 RID: 22071
	public int _LoopCount;

	// Token: 0x04005638 RID: 22072
	public UISprite _Sprite;

	// Token: 0x04005639 RID: 22073
	public string _ClipName;

	// Token: 0x0400563A RID: 22074
	private string mRollBackSprite;

	// Token: 0x0400563B RID: 22075
	private int mCachedLoopCount;
}
