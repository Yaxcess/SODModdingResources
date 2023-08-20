using System;
using UnityEngine;

// Token: 0x0200107B RID: 4219
public class ObProximity : KAMonoBase
{
	
	// Token: 0x040066FE RID: 26366
	public bool _Draw;

	// Token: 0x040066FF RID: 26367
	public bool _Active = true;

	// Token: 0x04006700 RID: 26368
	public bool _UseGlobalActive = true;

	// Token: 0x04006701 RID: 26369
	public bool _StopTutorialOnLoadLevel;

	// Token: 0x04006702 RID: 26370
	public string _LoadLevel = "";

	// Token: 0x04006703 RID: 26371
	public string _StartMarker = "";

	// Token: 0x04006704 RID: 26372
	public GameObject _ActivateObject;

	// Token: 0x04006705 RID: 26373
	public float _Range;

	// Token: 0x04006706 RID: 26374
	public Vector3 _Offset;

	// Token: 0x04006707 RID: 26375
	private float mLastUpdateTime;

	// Token: 0x04006708 RID: 26376
	private bool mWithinRange;

	// Token: 0x04006709 RID: 26377
	[SerializeField]
	private bool m_DisableOnLeave;
}
