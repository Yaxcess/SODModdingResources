using System;
using UnityEngine;

// Token: 0x0200119A RID: 4506
[Serializable]
public class SnSettings
{
	// Token: 0x0600705C RID: 28764 RVA: 0x002CD014 File Offset: 0x002CB214
	public SnSettings()
	{
	}

	// Token: 0x0600705D RID: 28765 RVA: 0x002CD07C File Offset: 0x002CB27C
	public SnSettings(SnSettings inSettings)
	{
		this._Channel = inSettings._Channel;
		this._Pool = inSettings._Pool;
		this._Priority = inSettings._Priority;
		this._Volume = inSettings._Volume;
		this._Pitch = inSettings._Pitch;
		this._MinVolume = inSettings._MinVolume;
		this._MaxVolume = inSettings._MaxVolume;
		this._RolloffFactor = inSettings._RolloffFactor;
		this._RolloffBegin = inSettings._RolloffBegin;
		this._RolloffEnd = inSettings._RolloffEnd;
		this._UseRolloffDistance = inSettings._UseRolloffDistance;
		this._Loop = inSettings._Loop;
		this._ReleaseOnStop = inSettings._ReleaseOnStop;
		this._FollowListener = inSettings._FollowListener;
		this._EventTarget = inSettings._EventTarget;
	}

	// Token: 0x04006DD3 RID: 28115
	public string _Channel = "";

	// Token: 0x04006DD4 RID: 28116
	public string _Pool = "";

	// Token: 0x04006DD5 RID: 28117
	public int _Priority;

	// Token: 0x04006DD6 RID: 28118
	public float _Volume = 1f;

	// Token: 0x04006DD7 RID: 28119
	public float _Pitch = 1f;

	// Token: 0x04006DD8 RID: 28120
	public float _MinVolume;

	// Token: 0x04006DD9 RID: 28121
	public float _MaxVolume = 1f;

	// Token: 0x04006DDA RID: 28122
	public float _RolloffFactor = 0.1f;

	// Token: 0x04006DDB RID: 28123
	public float _RolloffBegin;

	// Token: 0x04006DDC RID: 28124
	public float _RolloffEnd = float.PositiveInfinity;

	// Token: 0x04006DDD RID: 28125
	public bool _UseRolloffDistance;

	// Token: 0x04006DDE RID: 28126
	public bool _Loop;

	// Token: 0x04006DDF RID: 28127
	public bool _ReleaseOnStop = true;

	// Token: 0x04006DE0 RID: 28128
	public bool _FollowListener;

	// Token: 0x04006DE1 RID: 28129
	public GameObject _EventTarget;
}
