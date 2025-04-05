using System;

// Token: 0x02001029 RID: 4137
[Serializable]
public class ContextSensitivePriority
{
	// Token: 0x17000A39 RID: 2617
	// (get) Token: 0x06006845 RID: 26693 RVA: 0x00047709 File Offset: 0x00045909
	// (set) Token: 0x06006846 RID: 26694 RVA: 0x00047711 File Offset: 0x00045911
	public ContextSensitiveState pData { get; set; }

	// Token: 0x06006847 RID: 26695 RVA: 0x0004771A File Offset: 0x0004591A
	public ContextSensitivePriority(ContextSensitiveStateType inType)
	{
		this._Type = inType;
	}

	// Token: 0x04006572 RID: 25970
	public ContextSensitiveStateType _Type;
}
