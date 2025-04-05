using System;
using UnityEngine;

// Token: 0x0200104D RID: 4173
public class ObFollowTransform : MonoBehaviour
{
	// Token: 0x060068E8 RID: 26856 RVA: 0x00047DD0 File Offset: 0x00045FD0
	private void Awake()
	{
		if (this._TargetTransformRef == null)
		{
			this.FindTransform();
		}
	}

	// Token: 0x060068E9 RID: 26857 RVA: 0x002AA684 File Offset: 0x002A8884
	private void LateUpdate()
	{
		if (this._TargetTransformRef != null)
		{
			Vector3 vector = this._TargetTransformRef.position;
			vector += this._Offset;
			base.transform.position = vector;
			if (this._MatchRotate)
			{
				base.transform.rotation = this._TargetTransformRef.rotation;
				return;
			}
		}
		else
		{
			this.FindTransform();
		}
	}

	// Token: 0x060068EA RID: 26858 RVA: 0x002AA6EC File Offset: 0x002A88EC
	public void FindTransform()
	{
		if (string.IsNullOrEmpty(this._TargetTransform))
		{
			return;
		}
		GameObject gameObject = GameObject.Find(this._TargetTransform);
		if (gameObject != null)
		{
			this._TargetTransformRef = gameObject.transform;
			return;
		}
		if (!this._RetryFind)
		{
			Debug.LogError("ERROR: ObFollowTransform - UNABLED TO FIND TARGET TRANSFORM: " + this._TargetTransform);
			this._TargetTransform = "";
		}
	}

	// Token: 0x060068EB RID: 26859 RVA: 0x00047DE6 File Offset: 0x00045FE6
	public void ClearTransform()
	{
		this._TargetTransformRef = null;
	}

	// Token: 0x0400661C RID: 26140
	public string _TargetTransform;

	// Token: 0x0400661D RID: 26141
	public Vector3 _Offset;

	// Token: 0x0400661E RID: 26142
	public Transform _TargetTransformRef;

	// Token: 0x0400661F RID: 26143
	public bool _RetryFind;

	// Token: 0x04006620 RID: 26144
	public bool _MatchRotate;
}
