using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

// Token: 0x0200102C RID: 4140
public abstract class ObContextSensitive : KAMonoBase
{
	// Token: 0x0400657B RID: 25979
	public bool _Active = true;

	// Token: 0x0400657C RID: 25980
	public bool _CheckForRenderer = true;

	// Token: 0x0400657D RID: 25981
	public List<ContextData> _DataList = new List<ContextData>();

	// Token: 0x0400657E RID: 25982
	public string _UIBundle = "RS_DATA/PfUiContextSensitive.unity3d/PfUiContextSensitive";

	// Token: 0x0400657F RID: 25983
	public ContextSensitivePriority[] _PriorityList;

	// Token: 0x04006580 RID: 25984
	public ContextSensitiveUIStyleData _UIStyleData;

	// Token: 0x04006581 RID: 25985
	public Vector3 _Position2D = new Vector3(0f, -256f, 0f);

	// Token: 0x04006582 RID: 25986
	public Vector3 _SafeAreaMultiplier = Vector3.zero;

	// Token: 0x04006583 RID: 25987
	public GameObject _ClickableRangeTargetObj;

	// Token: 0x04006584 RID: 25988
	public float _ClickableRangeDist = -1f;

	// Token: 0x04006585 RID: 25989
	public GameObject _UIFollowingTarget;

	// Token: 0x04006586 RID: 25990
	public Camera _MainCamera;

	// Token: 0x04006587 RID: 25991
	public float _ProximityRange = 2f;

	// Token: 0x04006588 RID: 25992
	public Vector3 _ProximityOffset = Vector3.zero;

	// Token: 0x04006589 RID: 25993
	public bool _DrawProximity;

	// Token: 0x0400658A RID: 25994
	public bool _MenuBackgroundVisibility = true;

	// Token: 0x0400658B RID: 25995
	public string _MenuBackgroundSpriteName;

	// Token: 0x0400658C RID: 25996
	public Color _MenuBackgroundColor = new Color(1f, 1f, 1f, 0.4f);

	// Token: 0x0400658D RID: 25997
	public bool _UseMenuForParentCategory;

	// Token: 0x0400658E RID: 25998
	public bool _UseMenuForSubCategory;

	public static ObContextSensitive.BundleLoadSuccess _OnBundleLoadSuccess;

	// Token: 0x0200102D RID: 4141
	// (Invoke) Token: 0x0600687C RID: 26748
	public delegate void BundleLoadSuccess();
}
