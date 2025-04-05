using System;

// Token: 0x020006BC RID: 1724
[Serializable]
public class HUDActionItem
{
	// Token: 0x04002C3C RID: 11324
	public int _Task;

	// Token: 0x04002C3D RID: 11325
	public string _ItemName;

	// Token: 0x04002C3E RID: 11326
	public KAWidget _Widget;

	// Token: 0x04002C3F RID: 11327
	public HudActions _Action;

	// Token: 0x04002C40 RID: 11328
	public int _Time;

	// Token: 0x04002C41 RID: 11329
	public float _RepeatTimeInterval;

	// Token: 0x04002C42 RID: 11330
	[NonSerialized]
	public Task pTask;

	// Token: 0x04002C43 RID: 11331
	[NonSerialized]
	public KAWidget pWidget;
}
