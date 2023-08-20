using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x02000F7F RID: 3967

public class UIAtlas : MonoBehaviour
{
	

	// Token: 0x04006141 RID: 24897
	[HideInInspector]
	[SerializeField]
	private Material material;

	// Token: 0x04006142 RID: 24898
	[HideInInspector]
	[SerializeField]
	private List<UISpriteData> mSprites = new List<UISpriteData>();

	// Token: 0x04006143 RID: 24899
	[HideInInspector]
	[SerializeField]
	private float mPixelSize = 1f;

	// Token: 0x04006144 RID: 24900
	[HideInInspector]
	[SerializeField]
	private UIAtlas mReplacement;

	// Token: 0x04006145 RID: 24901
	[HideInInspector]
	[SerializeField]
	private UIAtlas.Coordinates mCoordinates;

	// Token: 0x04006146 RID: 24902
	[HideInInspector]
	[SerializeField]
	private List<UIAtlas.Sprite> sprites = new List<UIAtlas.Sprite>();

	// Token: 0x04006147 RID: 24903
	private int mPMA = -1;

	// Token: 0x04006148 RID: 24904
	private Dictionary<string, int> mSpriteIndices = new Dictionary<string, int>();

	// Token: 0x02000F80 RID: 3968
	[Serializable]
	private class Sprite
	{
		// Token: 0x17000966 RID: 2406
		// (get) Token: 0x060063C2 RID: 25538 RVA: 0x000444E9 File Offset: 0x000426E9
		public bool hasPadding
		{
			get
			{
				return this.paddingLeft != 0f || this.paddingRight != 0f || this.paddingTop != 0f || this.paddingBottom != 0f;
			}
		}

		// Token: 0x04006149 RID: 24905
		public string name = "Unity Bug";

		// Token: 0x0400614A RID: 24906
		public Rect outer = new Rect(0f, 0f, 1f, 1f);

		// Token: 0x0400614B RID: 24907
		public Rect inner = new Rect(0f, 0f, 1f, 1f);

		// Token: 0x0400614C RID: 24908
		public bool rotated;

		// Token: 0x0400614D RID: 24909
		public float paddingLeft;

		// Token: 0x0400614E RID: 24910
		public float paddingRight;

		// Token: 0x0400614F RID: 24911
		public float paddingTop;

		// Token: 0x04006150 RID: 24912
		public float paddingBottom;
	}

	// Token: 0x02000F81 RID: 3969
	private enum Coordinates
	{
		// Token: 0x04006152 RID: 24914
		Pixels,
		// Token: 0x04006153 RID: 24915
		TexCoords
	}
}
