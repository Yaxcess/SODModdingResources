using System;
using UnityEngine;
using UnityEngine.UI;

namespace JSGames.UI
{
	// Token: 0x02001B28 RID: 6952
	[Serializable]
	public class UIAnimInfo
	{
		// Token: 0x170010A2 RID: 4258
		// (get) Token: 0x0600A3D9 RID: 41945 RVA: 0x000663FA File Offset: 0x000645FA
		// (set) Token: 0x0600A3DA RID: 41946 RVA: 0x00066402 File Offset: 0x00064602
		public int pLoopCount
		{
			get
			{
				return this.mCachedLoopCount;
			}
			set
			{
				this.mCachedLoopCount = value;
			}
		}

		// Token: 0x0600A3DB RID: 41947 RVA: 0x0006640B File Offset: 0x0006460B
		public void CacheOriginalSprite()
		{
			if (this._Image != null)
			{
				this.mOriginalSprite = this._Image.sprite;
			}
		}

		// Token: 0x0600A3DC RID: 41948 RVA: 0x0006642C File Offset: 0x0006462C
		public void SetOriginalSprite()
		{
			if (this._Image != null)
			{
				this._Image.sprite = this.mOriginalSprite;
			}
		}

		// Token: 0x0400A782 RID: 42882
		public string _Name;

		// Token: 0x0400A783 RID: 42883
		public UIAnimSpriteInfo[] _SpriteInfo;

		// Token: 0x0400A784 RID: 42884
		public float _Length;

		// Token: 0x0400A785 RID: 42885
		public int _LoopCount;

		// Token: 0x0400A786 RID: 42886
		public Image _Image;

		// Token: 0x0400A787 RID: 42887
		public string _ClipName;

		// Token: 0x0400A788 RID: 42888
		private Sprite mOriginalSprite;

		// Token: 0x0400A789 RID: 42889
		private int mCachedLoopCount;
	}
}
