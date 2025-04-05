using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

// Token: 0x020006BF RID: 1727
[RequireComponent(typeof(ObStatus))]
public class FUEManager : KAMonoBase
{
	public HUDAction[] _HUDAction;

	// Token: 0x04002C50 RID: 11344
	public List<TaskStartMarker> _TaskStartMarker;

	// Token: 0x04002C51 RID: 11345
	public List<AvatarStateBetweenTasks> _AvatarStateBetweenTasks;

	// Token: 0x04002C52 RID: 11346
	public TaskInputInfo[] _TaskInputInfo;

	// Token: 0x04002C53 RID: 11347
	public UICSMInfo[] _UICSMInfo;

	// Token: 0x04002C54 RID: 11348
	public FlightTutorial _FlightTutorial;

	// Token: 0x04002C55 RID: 11349
	public int _FlightTutorialTask = 3429;

	// Token: 0x04002C56 RID: 11350
	public DragonWeaponTutorial _WeaponTutorial;

	// Token: 0x04002C57 RID: 11351
	public int _WeaponTutorialTask = 3430;

	// Token: 0x04002C58 RID: 11352
	public AgeUpTutorial _AgeUpTutorial;

	// Token: 0x04002C59 RID: 11353
	public int _AgeUpTutorialTask = 5935;

	// Token: 0x04002C5A RID: 11354
	public JumpTutorial _JumpTutorial;

	// Token: 0x04002C5B RID: 11355
	public int _JumpTutorialTask = 5931;

	// Token: 0x04002C5C RID: 11356
	public BranchUiTutorial _BranchUiTutorial;

	// Token: 0x04002C5D RID: 11357
	public int _BranchUiTutorialTask = 6619;

	// Token: 0x04002C5E RID: 11358
	public string _DragonFireBtn = "DragonFire";

	// Token: 0x04002C5F RID: 11359
	public static FUEManager pInstance;

	// Token: 0x04002C60 RID: 11360
	public static bool pIsFUERunning;

	// Token: 0x04002C61 RID: 11361
	public List<string> _TrackedCutscenes = new List<string>();

	// Token: 0x04002C62 RID: 11362
	public List<int> _TrackedOfferIDs = new List<int>();
}
