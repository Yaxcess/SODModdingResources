using System;
using UnityEngine;

// Token: 0x020011A3 RID: 4515
[Serializable]
public class SnRandomSound
{
	// Token: 0x06007145 RID: 28997 RVA: 0x0004D3EC File Offset: 0x0004B5EC
	public SnRandomSound(AudioClip[] inClipList)
	{
		this._ClipList = inClipList;
		this._Settings = new SnSettings();
	}

	// Token: 0x06007146 RID: 28998 RVA: 0x0004D406 File Offset: 0x0004B606
	public SnRandomSound(AudioClip[] inClipList, SnSettings inSettings)
	{
		this._ClipList = inClipList;
		this._Settings = inSettings;
	}

	

	
	// Token: 0x04006E1F RID: 28191
	public SnSettings _Settings;

	// Token: 0x04006E20 RID: 28192
	public AudioClip[] _ClipList;
}
