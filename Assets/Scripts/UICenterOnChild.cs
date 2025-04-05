using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x02000EEA RID: 3818
[AddComponentMenu("NGUI/Interaction/Center Scroll View on Child")]
public class UICenterOnChild : MonoBehaviour
{
	
	// Token: 0x04005D61 RID: 23905
	public float springStrength = 8f;

	// Token: 0x04005D62 RID: 23906
	public float nextPageThreshold;

	// Token: 0x04005D63 RID: 23907
	public SpringPanel.OnFinished onFinished;

	// Token: 0x04005D64 RID: 23908
	public UICenterOnChild.OnCenterCallback onCenter;

	// Token: 0x02000EEB RID: 3819
	// (Invoke) Token: 0x06005E72 RID: 24178
	public delegate void OnCenterCallback(GameObject centeredObject);
}
