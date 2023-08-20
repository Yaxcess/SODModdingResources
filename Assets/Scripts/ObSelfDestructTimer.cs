using System;
using UnityEngine;

// Token: 0x02001096 RID: 4246
public class ObSelfDestructTimer : MonoBehaviour
{
	// Token: 0x06006A13 RID: 27155 RVA: 0x00048BB1 File Offset: 0x00046DB1
	public virtual void OnEnable()
	{
		base.Invoke("DestroySelf", this._SelfDestructTime);
	}

	// Token: 0x06006A14 RID: 27156 RVA: 0x00048BC4 File Offset: 0x00046DC4
	public void OnDisable()
	{
		base.CancelInvoke("DestroySelf");
	}

	// Token: 0x06006A15 RID: 27157 RVA: 0x00047A28 File Offset: 0x00045C28
	public void DestroySelf()
	{
		if (this._Pool != null)
		{
			this._Pool.Despawn(base.transform);
			return;
		}
		UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x04006788 RID: 26504
	public float _SelfDestructTime = 1f;

	// Token: 0x04006789 RID: 26505
	public SpawnPool _Pool;
}
