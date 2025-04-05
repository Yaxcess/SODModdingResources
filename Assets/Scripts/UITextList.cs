using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using JSGames.UI;

// Token: 0x02000FBF RID: 4031
[AddComponentMenu("NGUI/UI/Text List")]
public class UITextList : MonoBehaviour
{

	// Token: 0x04006313 RID: 25363
	public UILabel textLabel;

	// Token: 0x04006314 RID: 25364
	public UIProgressBar scrollBar;

	// Token: 0x04006315 RID: 25365
	public UITextList.Style style;

	// Token: 0x04006316 RID: 25366
	public int paragraphHistory = 100;

	// Token: 0x04006317 RID: 25367
	protected char[] mSeparator = new char[]
	{
		'\n'
	};

	// Token: 0x04006318 RID: 25368
	protected float mScroll;

	// Token: 0x04006319 RID: 25369
	protected int mTotalLines;

	// Token: 0x0400631A RID: 25370
	protected int mLastWidth;

	// Token: 0x0400631B RID: 25371
	protected int mLastHeight;

	// Token: 0x02000FC0 RID: 4032
	public enum Style
	{
		// Token: 0x0400631F RID: 25375
		Text,
		// Token: 0x04006320 RID: 25376
		Chat
	}

	// Token: 0x02000FC1 RID: 4033
	protected class Paragraph
	{
		// Token: 0x04006321 RID: 25377
		public string text;

		// Token: 0x04006322 RID: 25378
		public string[] lines;
	}
}
