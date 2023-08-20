using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x020004E5 RID: 1253
public class AIActor_Pet : AIActor
{
    private Dictionary<AISanctuaryPetFSM, int> mStateMap;

    // Token: 0x040020C1 RID: 8385
    public AISanctuaryPetFSM _State;

	// Token: 0x040020C2 RID: 8386
	[HideInInspector]
	public SanctuaryPet SanctuaryPet;

}
