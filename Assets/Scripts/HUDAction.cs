using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x020006BD RID: 1725
[Serializable]
public class HUDAction
{
	// Token: 0x04002C44 RID: 11332
	public string _UiObjectName;

	// Token: 0x04002C45 RID: 11333
	public GameObject _UiObject;

	// Token: 0x04002C46 RID: 11334
	public List<HUDActionItem> _Items;

	// Token: 0x04002C47 RID: 11335
	[NonSerialized]
	public KAUI pUI;
}
