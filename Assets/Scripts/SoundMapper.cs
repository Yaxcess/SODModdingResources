using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x020004D7 RID: 1239
[Serializable]
public class SoundMapper
{
	

	// Token: 0x04002076 RID: 8310
	public SoundMapper.SoundPair[] _Map;

	// Token: 0x04002077 RID: 8311
	private List<SnChannel> mPlayingSounds;

	// Token: 0x04002078 RID: 8312
	private List<SnChannel> mFreeSounds;

	// Token: 0x020004D8 RID: 1240
	[Serializable]
	public class SoundPair
	{
		// Token: 0x04002079 RID: 8313
		public string Name;

		// Token: 0x0400207A RID: 8314
		public AudioClip Clip;

		// Token: 0x0400207B RID: 8315
		public bool PlayOnMobile;
	}
}
