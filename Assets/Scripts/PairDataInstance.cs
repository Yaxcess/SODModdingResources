using System;

// Token: 0x0200095D RID: 2397
public class PairDataInstance
{
	// Token: 0x1700060E RID: 1550
	// (get) Token: 0x06003813 RID: 14355 RVA: 0x000277DB File Offset: 0x000259DB
	public bool pIsLoading
	{
		get
		{
			return this.mLoadInProgress;
		}
	}

	// Token: 0x1700060F RID: 1551
	// (get) Token: 0x06003814 RID: 14356 RVA: 0x000277E3 File Offset: 0x000259E3
	public bool pIsSaving
	{
		get
		{
			return this.mSaveInProgress;
		}
	}

	

	// Token: 0x04003A45 RID: 14917
	public int _DataID = -1;

	// Token: 0x04003A46 RID: 14918
	public PairData _Data;

	// Token: 0x04003A47 RID: 14919
	public bool _DataReady;

	// Token: 0x04003A48 RID: 14920
	public PairDataEventHandler mLoadCallback;

	// Token: 0x04003A49 RID: 14921
	public PairDataEventHandler mSaveCallback;

	// Token: 0x04003A4A RID: 14922
	public object mUserData;

	// Token: 0x04003A4B RID: 14923
	private bool mLoadInProgress;

	// Token: 0x04003A4C RID: 14924
	private bool mSaveInProgress;
}
