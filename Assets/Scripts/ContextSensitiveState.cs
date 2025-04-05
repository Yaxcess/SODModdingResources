using System;
using UnityEngine;

// Token: 0x02001028 RID: 4136
[Serializable]
public class ContextSensitiveState : ICloneable
{
	// Token: 0x06006843 RID: 26691 RVA: 0x000476E9 File Offset: 0x000458E9
	public object Clone()
	{
		return (ContextSensitiveState)base.MemberwiseClone();
	}

	// Token: 0x0400656C RID: 25964
	public ContextSensitiveStateType _MenuType;

	// Token: 0x0400656D RID: 25965
	public string[] _CurrentContextNamesList;

	// Token: 0x0400656E RID: 25966
	public bool _Enable3DUI;

	// Token: 0x0400656F RID: 25967
	public Vector3 _OffsetPos;

	// Token: 0x04006570 RID: 25968
	public Vector3 _UIScale = Vector3.one;

	// Token: 0x04006571 RID: 25969
	public bool _ShowCloseButton;
}
