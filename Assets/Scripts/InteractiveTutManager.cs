using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

// Token: 0x02000A47 RID: 2631
public class InteractiveTutManager : MonoBehaviour
{
	

	// Token: 0x04003E2C RID: 15916
	public static bool _Save = true;

	// Token: 0x04003E2F RID: 15919
	public static GameObject _CurrentActiveTutorialObject = null;

	// Token: 0x04003E30 RID: 15920
	public int _PairID;

	// Token: 0x04003E31 RID: 15921
	public string _TutIndexKeyName;


	// Token: 0x04003E33 RID: 15923
	public bool _CanRepeatOnIdle = true;

	// Token: 0x04003E34 RID: 15924
	public float _IdleRepeatInterval = 30f;


	// Token: 0x04003E36 RID: 15926
	public bool _IsSavedStepToBeLoaded = true;

	// Token: 0x04003E3A RID: 15930
	public Vector2 _TutorialBoardPos;

	// Token: 0x04003E3B RID: 15931
	public LocaleString _TutorialDBHeader = new LocaleString("Tutorial");

	// Token: 0x04003E3C RID: 15932
	public string _TutorialDBRes = "RS_DATA/PfUiTutMsgDBDM.unity3d/PfUiTutMsgDBDM";

	// Token: 0x04003E3D RID: 15933
	public string _TutorialDBResMobile = "";

	// Token: 0x04003E3E RID: 15934
	public string _RecordIdxName = "";

	// Token: 0x04003E3F RID: 15935
	public int _MaxTimesToBeShown = 1;

	// Token: 0x04003E40 RID: 15936
	public LocaleString _CloseMessage = new LocaleString("Do you want to skip tutorial?");

	
}
