using System;
using UnityEngine;

// Token: 0x02001169 RID: 4457
public class SanctuaryLevelReady : MonoBehaviour
{
	// Token: 0x06006E3A RID: 28218 RVA: 0x0004BA87 File Offset: 0x00049C87
	public void OnLevelReady()
	{
		SanctuaryManager.pLevelReady = true;
	}
}
