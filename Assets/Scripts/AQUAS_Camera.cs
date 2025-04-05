using System;
using UnityEngine;

// Token: 0x020012F8 RID: 4856
[AddComponentMenu("AQUAS/AQUAS Camera")]
[RequireComponent(typeof(Camera))]
public class AQUAS_Camera : MonoBehaviour
{
	// Token: 0x06007BEA RID: 31722 RVA: 0x00053131 File Offset: 0x00051331
	private void Start()
	{
		this.Set();
	}

	// Token: 0x06007BEB RID: 31723 RVA: 0x00053139 File Offset: 0x00051339
	private void Set()
	{
		if (base.GetComponent<Camera>().depthTextureMode == DepthTextureMode.None)
		{
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
		}
	}
}
