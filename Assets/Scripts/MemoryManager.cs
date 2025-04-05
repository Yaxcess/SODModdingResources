using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// Token: 0x020009BD RID: 2493
public class MemoryManager : MonoBehaviour
{
	// Token: 0x04003B53 RID: 15187
	public MinMax _LowMemoryThreshold = new MinMax(0f, 15f);

	// Token: 0x04003B54 RID: 15188
	public MinMax _MediumMemoryThreshold = new MinMax(20f, 45f);

	// Token: 0x04003B55 RID: 15189
	public MinMax _HighMemoryThreshold = new MinMax(50f, 99999f);

	// Token: 0x04003B56 RID: 15190
	public float _UpdateInterval = 2.5f;

	// Token: 0x04003B57 RID: 15191
	public float _LowMemWarningWaitTime = 600f;

	// Token: 0x04003B58 RID: 15192
	public LocaleString _LowMemoryWarningText = new LocaleString("Your device is running low on memory. Please kill apps that you don`t need.");

	// Token: 0x04003B59 RID: 15193
	public LocaleString _WarningHeaderText = new LocaleString("Warning!");

	// Token: 0x04003B64 RID: 15204
	public static int MemoryWarningCleanupLevel = 0;

	// Token: 0x04003B65 RID: 15205
	private static bool firstTime = true;
}
