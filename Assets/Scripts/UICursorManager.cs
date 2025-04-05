using System;
using JSGames.UI;
using UnityEngine;

// Token: 0x02000276 RID: 630
public class UICursorManager : UI
{
	// Token: 0x1700019B RID: 411
	// (get) Token: 0x060011AC RID: 4524 RVA: 0x000118E3 File Offset: 0x0000FAE3
	public static UICursorManager pCursorManager
	{
		get
		{
			return UICursorManager.mCursorManager;
		}
	}

	// Token: 0x1700019C RID: 412
	// (get) Token: 0x060011AD RID: 4525 RVA: 0x000118EA File Offset: 0x0000FAEA
	// (set) Token: 0x060011AE RID: 4526 RVA: 0x000118F1 File Offset: 0x0000FAF1
	public static bool pVisibility
	{
		get
		{
			return UICursorManager.mVisibility;
		}
		set
		{
			UICursorManager.mVisibility = value;
			if (UICursorManager.mCursorManager != null)
			{
				UICursorManager.mCursorManager.pVisible = value;
			}
		}
	}

	// Token: 0x1700019D RID: 413
	// (get) Token: 0x060011AF RID: 4527 RVA: 0x00011911 File Offset: 0x0000FB11
	// (set) Token: 0x060011B0 RID: 4528 RVA: 0x00011919 File Offset: 0x0000FB19
	public JSGames.UI.UIWidget pCurrentCursor
	{
		get
		{
			return this.mCurrentCursor;
		}
		set
		{
			this.mCurrentCursor = value;
		}
	}

	// Token: 0x1700019E RID: 414
	// (get) Token: 0x060011B1 RID: 4529 RVA: 0x00011922 File Offset: 0x0000FB22
	// (set) Token: 0x060011B2 RID: 4530 RVA: 0x00011929 File Offset: 0x0000FB29
	public static bool pIsForceCursorVisibility
	{
		get
		{
			return UICursorManager.mIsForceCursorVisibility;
		}
		set
		{
			UICursorManager.mIsForceCursorVisibility = value;
		}
	}

	// Token: 0x0400106C RID: 4204
	private static GameObject mLoadingGearGO;

	// Token: 0x0400106D RID: 4205
	private static UI mLoadingGearInterface;

	// Token: 0x0400106E RID: 4206
	private static int mLoadingStackDepth;

	// Token: 0x0400106F RID: 4207
	private static UICursorManager mCursorManager;

	// Token: 0x04001070 RID: 4208
	private static bool mVisibility;

	// Token: 0x04001071 RID: 4209
	public bool _GlobalAutoHideCursor = true;

	// Token: 0x04001072 RID: 4210
	public bool _AutoHideCursor;

	// Token: 0x04001073 RID: 4211
	public float _AutoHideCursorTime = 2f;

	// Token: 0x04001074 RID: 4212
	public string _DefaultCursorName;

	// Token: 0x04001075 RID: 4213
	private float mHideCursorTimer = 10f;

	// Token: 0x04001076 RID: 4214
	private Vector3 mPrevMousePos = new Vector3(0f, 0f, 0f);

	// Token: 0x04001077 RID: 4215
	private bool mMouseMoved;

	// Token: 0x04001078 RID: 4216
	private bool mHoverAutoHideCursor = true;

	// Token: 0x04001079 RID: 4217
	private JSGames.UI.UIWidget mCurrentCursor;

	// Token: 0x0400107A RID: 4218
	private bool mCursorHidden;

	// Token: 0x0400107B RID: 4219
	private bool mIsSystemCursorVisible;

	// Token: 0x0400107C RID: 4220
	private static bool mIsForceCursorVisibility;
}
