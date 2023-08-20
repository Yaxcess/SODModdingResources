using System;
using System.Collections;
using UnityEngine;

// Token: 0x020004EC RID: 1260
public class AIBehavior_FSM : AIBehavior
{
	

	// Token: 0x040020DB RID: 8411
	private int mCurrentState = -1;

	// Token: 0x040020DC RID: 8412
	private bool mUpdateList = true;

	// Token: 0x040020DD RID: 8413
	private AIBehavior[] mStates;

	// Token: 0x040020DE RID: 8414
	private ArrayList mPreviousStates = new ArrayList();
}
