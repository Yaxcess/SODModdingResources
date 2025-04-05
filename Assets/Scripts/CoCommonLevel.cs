using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x020005DA RID: 1498
public class CoCommonLevel : MonoBehaviour
{
	
	static CoCommonLevel()
	{

	}

	// Token: 0x04002767 RID: 10087
	public static List<string> _ActivateObjectsOnLoad = new List<string>();

	// Token: 0x04002768 RID: 10088
	public static bool _MembershipVerified = false;

	// Token: 0x04002769 RID: 10089
	public AvAvatarState _AvatarStartState = AvAvatarState.IDLE;

	// Token: 0x0400276A RID: 10090
	public AvAvatarSubState _AvatarStartSubState;

	// Token: 0x0400276B RID: 10091
	public Transform[] _AvatarStartMarker;

	// Token: 0x0400276C RID: 10092
	[Tooltip("Start Markers for non-members.")]
	public Transform[] _AvatarStartMarkerNM;

	// Token: 0x0400276D RID: 10093
	[Tooltip("Start Markers in case of invalid start state (i.e. flying with a flightless dragon).")]
	public Transform[] _AvatarStartMarkerFallback;

	// Token: 0x0400276E RID: 10094
	[Tooltip("Start Markers for non-members in case of invalid start state (i.e. flying with a flightless dragon).")]
	public Transform[] _AvatarStartMarkerFallbackNM;

	// Token: 0x0400276F RID: 10095
	public TaskSpawnPoint[] _AvatarTaskSpawnPoints;

	// Token: 0x04002770 RID: 10096
	public NPCStartData[] _NPCStartData;

	// Token: 0x04002771 RID: 10097
	public GameObject[] _CheckReadyStatusList;

	// Token: 0x04002772 RID: 10098
	public GameObject[] _ObjectNotifyList;

	// Token: 0x04002773 RID: 10099
	public bool _ForceProjectionShadow;

	// Token: 0x04002774 RID: 10100
	[Tooltip("This will load the player at the start of the level if they load from another scene - prevents certain exploits on low memory devices")]
	public bool _IgnorePreviousPositionOnLoad;

	// Token: 0x04002776 RID: 10102
	public bool _RideAllowed = true;

	// Token: 0x04002777 RID: 10103
	public bool _PetAllowed = true;

	// Token: 0x04002778 RID: 10104
	public bool _SaveSceneWhenVisited = true;

	// Token: 0x04002779 RID: 10105
	public GameObject[] _WaitList;

	// Token: 0x0400277A RID: 10106
	public GameObject[] _WaitListCompletedNotifyList;

	// Token: 0x0400277C RID: 10108
	public AchievementOnVisit _VisitAchievementData;

	// Token: 0x0400277D RID: 10109
	public PoolInfo[] _TurnOffPoolInfo;
}
