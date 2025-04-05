using System;
using UnityEngine;

// Token: 0x0200054D RID: 1357
public class AvatarBlink : MonoBehaviour
{
	// Token: 0x1700033E RID: 830
	// (get) Token: 0x0600244B RID: 9291 RVA: 0x0001CF7E File Offset: 0x0001B17E
	public Renderer pMeshRenderer
	{
		get
		{
			return this.mMeshRenderer;
		}
	}

	// Token: 0x0600244C RID: 9292 RVA: 0x0001CF86 File Offset: 0x0001B186
	protected virtual void Awake()
	{
		this.mMeshRenderer = base.GetComponent<MeshRenderer>();
		if (this.mMeshRenderer == null)
		{
			this.mMeshRenderer = base.GetComponent<SkinnedMeshRenderer>();
		}
	}

	// Token: 0x0600244D RID: 9293 RVA: 0x0015506C File Offset: 0x0015326C
	private void Update()
	{
		if (this.mMeshRenderer == null)
		{
			return;
		}
		if (Time.time > this.mNextBlink)
		{
			this.mEndBlink = Time.time + this._BlinkLength;
			this.mNextBlink = this.mEndBlink + UnityEngine.Random.Range(1f, 6f);
			this.mMeshRenderer.enabled = true;
			return;
		}
		if (Time.time > this.mEndBlink)
		{
			this.mMeshRenderer.enabled = false;
			this.mEndBlink = this.mNextBlink;
		}
	}

	// Token: 0x0600244E RID: 9294 RVA: 0x0001CFAE File Offset: 0x0001B1AE
	public void ResetBlink()
	{
		this.mNextBlink = 0f;
	}

	// Token: 0x040022F8 RID: 8952
	public float _BlinkLength = 0.1f;

	// Token: 0x040022F9 RID: 8953
	private float mEndBlink;

	// Token: 0x040022FA RID: 8954
	private float mNextBlink;

	// Token: 0x040022FB RID: 8955
	protected Renderer mMeshRenderer;
}
