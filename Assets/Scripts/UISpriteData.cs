using System;

// Token: 0x02000FBC RID: 4028
[Serializable]
public class UISpriteData
{
	// Token: 0x17000A0D RID: 2573
	// (get) Token: 0x0600660B RID: 26123 RVA: 0x00045D7B File Offset: 0x00043F7B
	public bool hasBorder
	{
		get
		{
			return (this.borderLeft | this.borderRight | this.borderTop | this.borderBottom) != 0;
		}
	}

	// Token: 0x17000A0E RID: 2574
	// (get) Token: 0x0600660C RID: 26124 RVA: 0x00045D9B File Offset: 0x00043F9B
	public bool hasPadding
	{
		get
		{
			return (this.paddingLeft | this.paddingRight | this.paddingTop | this.paddingBottom) != 0;
		}
	}

	// Token: 0x0600660D RID: 26125 RVA: 0x00045DBB File Offset: 0x00043FBB
	public void SetRect(int x, int y, int width, int height)
	{
		this.x = x;
		this.y = y;
		this.width = width;
		this.height = height;
	}

	// Token: 0x0600660E RID: 26126 RVA: 0x00045DDA File Offset: 0x00043FDA
	public void SetPadding(int left, int bottom, int right, int top)
	{
		this.paddingLeft = left;
		this.paddingBottom = bottom;
		this.paddingRight = right;
		this.paddingTop = top;
	}

	// Token: 0x0600660F RID: 26127 RVA: 0x00045DF9 File Offset: 0x00043FF9
	public void SetBorder(int left, int bottom, int right, int top)
	{
		this.borderLeft = left;
		this.borderBottom = bottom;
		this.borderRight = right;
		this.borderTop = top;
	}

	// Token: 0x06006610 RID: 26128 RVA: 0x0029C668 File Offset: 0x0029A868
	public void CopyFrom(UISpriteData sd)
	{
		this.name = sd.name;
		this.x = sd.x;
		this.y = sd.y;
		this.width = sd.width;
		this.height = sd.height;
		this.borderLeft = sd.borderLeft;
		this.borderRight = sd.borderRight;
		this.borderTop = sd.borderTop;
		this.borderBottom = sd.borderBottom;
		this.paddingLeft = sd.paddingLeft;
		this.paddingRight = sd.paddingRight;
		this.paddingTop = sd.paddingTop;
		this.paddingBottom = sd.paddingBottom;
	}

	// Token: 0x06006611 RID: 26129 RVA: 0x00045E18 File Offset: 0x00044018
	public void CopyBorderFrom(UISpriteData sd)
	{
		this.borderLeft = sd.borderLeft;
		this.borderRight = sd.borderRight;
		this.borderTop = sd.borderTop;
		this.borderBottom = sd.borderBottom;
	}

	// Token: 0x040062F0 RID: 25328
	public string name = "Sprite";

	// Token: 0x040062F1 RID: 25329
	public int x;

	// Token: 0x040062F2 RID: 25330
	public int y;

	// Token: 0x040062F3 RID: 25331
	public int width;

	// Token: 0x040062F4 RID: 25332
	public int height;

	// Token: 0x040062F5 RID: 25333
	public int borderLeft;

	// Token: 0x040062F6 RID: 25334
	public int borderRight;

	// Token: 0x040062F7 RID: 25335
	public int borderTop;

	// Token: 0x040062F8 RID: 25336
	public int borderBottom;

	// Token: 0x040062F9 RID: 25337
	public int paddingLeft;

	// Token: 0x040062FA RID: 25338
	public int paddingRight;

	// Token: 0x040062FB RID: 25339
	public int paddingTop;

	// Token: 0x040062FC RID: 25340
	public int paddingBottom;
}
