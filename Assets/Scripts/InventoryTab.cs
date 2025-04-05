using System;
using UnityEngine;

// Token: 0x02000C5D RID: 3165
[Serializable]
public class InventoryTab
{

	// Token: 0x04004BE2 RID: 19426
	public LocaleString _DisplayNameText;

	// Token: 0x04004BE3 RID: 19427
	public LocaleString _RollOverText;

	// Token: 0x04004BE4 RID: 19428
	public InventoryTabType _Type;

	// Token: 0x04004BE5 RID: 19429
	public AudioClip _RollOverVO;

	// Token: 0x04004BE6 RID: 19430
	public Texture _IconTex;

	// Token: 0x04004BE7 RID: 19431
	public bool _AllowTrash;

	// Token: 0x04004BE8 RID: 19432
	[Header("Tab ID from InventoryTabSetting Asset")]
	public string _TabID;

	// Token: 0x04004BEA RID: 19434
	[NonSerialized]
	public int mNumSlotOccupied;

	// Token: 0x04004BEB RID: 19435
	[NonSerialized]
	public int mNumSlotUnlocked;
}
