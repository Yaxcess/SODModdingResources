using System.Collections.Generic;
using UnityEngine;

public class UiContextSensitive : KAUI
{
	public ObContextSensitive pContextSensitiveObj { get; set; }

	// Token: 0x170006B7 RID: 1719
	// (get) Token: 0x060041BA RID: 16826 RVA: 0x0002D90C File Offset: 0x0002BB0C
	// (set) Token: 0x060041BB RID: 16827 RVA: 0x0002D914 File Offset: 0x0002BB14
	public ContextSensitiveStateType pCurrentStateType { get; set; }

	// Token: 0x170006B8 RID: 1720
	// (get) Token: 0x060041BC RID: 16828 RVA: 0x0002D91D File Offset: 0x0002BB1D
	// (set) Token: 0x060041BD RID: 16829 RVA: 0x0002D925 File Offset: 0x0002BB25
	public Vector3 pOffsetPos { get; set; }

	// Token: 0x170006B9 RID: 1721
	// (get) Token: 0x060041BE RID: 16830 RVA: 0x0002D92E File Offset: 0x0002BB2E
	// (set) Token: 0x060041BF RID: 16831 RVA: 0x0002D936 File Offset: 0x0002BB36
	public IContextSensitiveStyle pUIStyle { get; set; }

	// Token: 0x170006BA RID: 1722
	// (get) Token: 0x060041C0 RID: 16832 RVA: 0x0002D93F File Offset: 0x0002BB3F
	// (set) Token: 0x060041C1 RID: 16833 RVA: 0x0002D947 File Offset: 0x0002BB47
	public bool pIs3DUI { get; set; }
	// Token: 0x0400433B RID: 17211
	public KAWidget _ButtonTemplate;

	// Token: 0x0400433C RID: 17212
	public GameObject _MenuTemplate;

	// Token: 0x0400433F RID: 17215
	public bool pUseMenuForParentCategory;

	// Token: 0x04004340 RID: 17216
	public bool pUseMenuForSubCategory;

	// Token: 0x04004341 RID: 17217
	public bool pOverrideSubCategoryXOffset;
}
