using System;
using System.Collections.Generic;

// Token: 0x020006BE RID: 1726
[Serializable]
public class AvatarStateBetweenTasks
{
	// Token: 0x04002C48 RID: 11336
	public string _AvatarState;

	// Token: 0x04002C49 RID: 11337
	public int _StartTask;

	// Token: 0x04002C4A RID: 11338
	public int _EndTask;

	// Token: 0x04002C4B RID: 11339
	public bool _SetOnReloadOnly = true;

	// Token: 0x04002C4C RID: 11340
	public List<AvatarActions> _Actions;

	// Token: 0x04002C4D RID: 11341
	public string _MountablePetName = string.Empty;

	// Token: 0x04002C4E RID: 11342
	public string _MountPillionNPC = string.Empty;
}
