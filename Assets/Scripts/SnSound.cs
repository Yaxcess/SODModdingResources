using System;
using UnityEngine;

// Token: 0x020011A2 RID: 4514
[Serializable]
public class SnSound : SnISound
{
	// Token: 0x06007140 RID: 28992 RVA: 0x0004D361 File Offset: 0x0004B561
	public SnSound(AudioClip inClip, SnSettings inSettings)
	{
		this._AudioClip = inClip;
		this._Settings = inSettings;
	}

	// Token: 0x06007141 RID: 28993 RVA: 0x0004D377 File Offset: 0x0004B577
	public SnSound(AudioClip inClip, SnSettings inSettings, SnTriggerList inTriggers)
	{
		this._AudioClip = inClip;
		this._Settings = inSettings;
		this._Triggers = inTriggers;
	}

	// Token: 0x06007142 RID: 28994 RVA: 0x0004D394 File Offset: 0x0004B594
	public SnSound(AudioClip inClip, SnSettings inSettings, SnTrigger[] inTriggers)
	{
		this._AudioClip = inClip;
		this._Settings = inSettings;
		if (inTriggers != null)
		{
			this._Triggers = new SnTriggerList(inTriggers);
		}
	}

	// Token: 0x06007143 RID: 28995 RVA: 0x0004D3B9 File Offset: 0x0004B5B9
	public SnChannel Play()
	{
		return this.Play(false);
	}

	// Token: 0x06007144 RID: 28996 RVA: 0x0004D3C2 File Offset: 0x0004B5C2
	public SnChannel Play(bool inForce)
	{
	
		
			return null;
		
		
	}

	// Token: 0x04006E1C RID: 28188
	public SnSettings _Settings;

	// Token: 0x04006E1D RID: 28189
	public AudioClip _AudioClip;

	// Token: 0x04006E1E RID: 28190
	public SnTriggerList _Triggers;
}
