using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x02000C6E RID: 3182
public class UiSceneMap : KAUI
{

	// Token: 0x04004CD1 RID: 19665
	public bool _ShowNpcIcons;

	// Token: 0x04004CD2 RID: 19666
	public Transform _MapWidget;

	// Token: 0x04004CD3 RID: 19667
	public BoxCollider _MapBounds;

	// Token: 0x04004CD4 RID: 19668
	public KAWidget _GetObjectiveMarker;

	// Token: 0x04004CD5 RID: 19669
	public KAWidget _ObjectiveCompleteMarker;

	// Token: 0x04004CD6 RID: 19670
	public KAWidget _PlayerBlip;

	// Token: 0x04004CD7 RID: 19671
	public KAWidget _NPCBlip;

	// Token: 0x04004CD8 RID: 19672
	public KAWidget _PortalBlip;

	// Token: 0x04004CD9 RID: 19673
	public KAWidget _FishingBlip;

	// Token: 0x04004CDA RID: 19674
	public KAWidget _FarmingBlip;

	// Token: 0x04004CDB RID: 19675
	public KAWidget _RacingBlip;

	// Token: 0x04004CDC RID: 19676
	public KAWidget _FlightSchoolBlip;

	// Token: 0x04004CDD RID: 19677
	public KAWidget _ScientificMachineBlip;

	// Token: 0x04004CDE RID: 19678
	public KAWidget _DragonTaxiBlip;

	// Token: 0x04004CDF RID: 19679
	public KAWidget _LabBlip;

	// Token: 0x04004CE0 RID: 19680
	public KAWidget _TargetPracticeBlip;

	// Token: 0x04004CE1 RID: 19681
	public KAWidget _StoreBlip;

	// Token: 0x04004CE2 RID: 19682
	public string[] _Portals;

	// Token: 0x04004CE3 RID: 19683
	public bool _ShowNPCWithQuestOnly = true;

	// Token: 0x04004CE4 RID: 19684
	public string _FarmingPortalName = "PfFarmPortal";

	// Token: 0x04004CE5 RID: 19685
	public string _RacingPortalName = "PfRacingPortal";

	// Token: 0x04004CE6 RID: 19686
	public string _FlightSchoolPortalName = "PfFlightSchoolPortal";

	// Token: 0x04004CE7 RID: 19687
	[NonSerialized]
	public UiToolbar _WorldMap;

	// Token: 0x04004CE8 RID: 19688
	[NonSerialized]
	public UiToolbar _MiniMap;

	// Token: 0x04004CE9 RID: 19689
	public string _WorldMapBundle = "RS_DATA/AniDWDragonsMapBerkDO.Unity3d/AniDWDragonsMapBerkDO";

	// Token: 0x04004CEA RID: 19690
	public UiSceneMap.SceneNameMapping[] _NameMapping;

	// Token: 0x02000C6F RID: 3183
	[Serializable]
	public class SceneNameMapping
	{
		// Token: 0x04004CEF RID: 19695
		public string _SceneName;

		// Token: 0x04004CF0 RID: 19696
		public string _DisplayName;
	}
}
