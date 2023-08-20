using System;
using UnityEngine;

// Token: 0x02000DD2 RID: 3538
[RequireComponent(typeof(Camera))]
public class KAUICamera : UICamera
{
	

	// Token: 0x040056B3 RID: 22195
	public bool _ClearEventMask = true;

	// Token: 0x040056B4 RID: 22196
	public float mDragTimer;

	// Token: 0x040056B5 RID: 22197
	public bool mDragStarted;

	// Token: 0x040056B6 RID: 22198
	public float _DragDelay = 0.25f;
}
