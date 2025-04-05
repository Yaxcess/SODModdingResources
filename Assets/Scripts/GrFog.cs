using System;
using UnityEngine;

// Token: 0x020009EA RID: 2538
public class GrFog : MonoBehaviour
{
	// Token: 0x06003AAB RID: 15019 RVA: 0x001AE1E4 File Offset: 0x001AC3E4
	public void Activate()
	{
		this.mOldFog = RenderSettings.fog;
		this.mOldFogColor = RenderSettings.fogColor;
		this.mOldFogDensity = RenderSettings.fogDensity;
		this.mOldAmbientLight = RenderSettings.ambientLight;
		RenderSettings.fog = true;
		RenderSettings.fogColor = this._FogColor;
		RenderSettings.fogDensity = this._FogDensity;
		RenderSettings.ambientLight = this._AmbientLight;
	}

	// Token: 0x06003AAC RID: 15020 RVA: 0x00028E40 File Offset: 0x00027040
	public void Restore()
	{
		RenderSettings.fog = this.mOldFog;
		RenderSettings.fogColor = this.mOldFogColor;
		RenderSettings.fogDensity = this.mOldFogDensity;
		RenderSettings.ambientLight = this.mOldAmbientLight;
	}

	// Token: 0x04003C4D RID: 15437
	public Color _FogColor;

	// Token: 0x04003C4E RID: 15438
	public float _FogDensity;

	// Token: 0x04003C4F RID: 15439
	public Color _AmbientLight;

	// Token: 0x04003C50 RID: 15440
	private bool mOldFog;

	// Token: 0x04003C51 RID: 15441
	private Color mOldFogColor;

	// Token: 0x04003C52 RID: 15442
	private float mOldFogDensity;

	// Token: 0x04003C53 RID: 15443
	private Color mOldAmbientLight;
}
