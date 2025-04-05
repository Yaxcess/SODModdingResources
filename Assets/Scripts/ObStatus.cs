using System;
using UnityEngine;

// Token: 0x0200109C RID: 4252
public class ObStatus : MonoBehaviour, ObIStatus
{
	// Token: 0x17000A50 RID: 2640
	// (get) Token: 0x06006A25 RID: 27173 RVA: 0x00048C28 File Offset: 0x00046E28
	// (set) Token: 0x06006A26 RID: 27174 RVA: 0x00048C30 File Offset: 0x00046E30
	public bool pIsReady
	{
		get
		{
			return this.mReady;
		}
		set
		{
			this.mReady = value;
		}
	}

	// Token: 0x04006790 RID: 26512
	private bool mReady;
}
