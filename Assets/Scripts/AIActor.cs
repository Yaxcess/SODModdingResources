using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x020004D1 RID: 1233
public class AIActor : MonoBehaviour
{	
    // Token: 0x17000319 RID: 793
    // (get) Token: 0x060021CB RID: 8651 RVA: 0x0001B297 File Offset: 0x00019497
    // (set) Token: 0x060021CC RID: 8652 RVA: 0x0001B29F File Offset: 0x0001949F
    public float Velocity { get; set; }

	// Token: 0x1700031A RID: 794
	// (get) Token: 0x060021CD RID: 8653 RVA: 0x0001B2A8 File Offset: 0x000194A8
	// (set) Token: 0x060021CE RID: 8654 RVA: 0x0001B2B0 File Offset: 0x000194B0
	public bool CanAccelerate { get; set; }

	// Token: 0x1700031B RID: 795
	// (get) Token: 0x060021CF RID: 8655 RVA: 0x0001B2B9 File Offset: 0x000194B9
	// (set) Token: 0x060021D0 RID: 8656 RVA: 0x0001B2C1 File Offset: 0x000194C1
	public MoveStateData pMoveState { get; set; }

	// Token: 0x1700031C RID: 796
	// (get) Token: 0x060021D1 RID: 8657 RVA: 0x0001B2CA File Offset: 0x000194CA
	public AIActor pController
	{
		get
		{
			return this.mController;
		}
	}

    // Token: 0x1700031D RID: 797
    // (get) Token: 0x060021D2 RID: 8658 RVA: 0x0001B2D2 File Offset: 0x000194D2


    // Token: 0x04002053 RID: 8275
    public AIBehavior _BehaviorsRoot;

	// Token: 0x04002054 RID: 8276
	public Animation _Animation;

	// Token: 0x04002055 RID: 8277
	public bool _CanFly;

	// Token: 0x04002056 RID: 8278
	public float _Speed = 5f;

	// Token: 0x04002057 RID: 8279
	public float _Acceleration = 5f;

	// Token: 0x04002058 RID: 8280
	public float _DecelerateRange = 4f;

	// Token: 0x04002059 RID: 8281
	public float _StoppingDistance = 2f;

	// Token: 0x0400205A RID: 8282
	public ChCharacter _Character;

	// Token: 0x0400205B RID: 8283
	public SoundMapper _SoundMapper = new SoundMapper();

	// Token: 0x0400205C RID: 8284
	public float _GroundCheckStartHeight = 2f;

	// Token: 0x0400205D RID: 8285
	public float _GroundCheckDist = 20f;

	// Token: 0x04002060 RID: 8288
	public List<AIActor.AnimationData> _AnimationDataList;

	// Token: 0x04002061 RID: 8289
	[HideInInspector]
	public AIBehaviorState BehaviorFunctionCallResult = AIBehaviorState.FAILED;

	// Token: 0x04002062 RID: 8290
	[HideInInspector]
	public float DeltaTime;

	// Token: 0x04002063 RID: 8291
	[HideInInspector]
	public Vector3 Position;

	// Token: 0x04002064 RID: 8292
	protected AIBehavior_FSM mFSMCharacter;

	// Token: 0x04002065 RID: 8293
	protected int mState = -1;

	// Token: 0x04002066 RID: 8294
	private float mLastUpdateTime = -1f;

	// Token: 0x04002067 RID: 8295
	private AIBehavior_PlayAnim mCustomPlayAnim;

	// Token: 0x04002068 RID: 8296
	private GameObject mParticleEffect;

	// Token: 0x04002069 RID: 8297
	[Header("State/Speeds")]
	public List<MoveStateData> _MoveStates;

	// Token: 0x0400206A RID: 8298
	public float _MoveCheckDistance = 1f;

	// Token: 0x0400206C RID: 8300
	protected AIActor mController;

	// Token: 0x020004D2 RID: 1234
	[Serializable]
	public class AnimationData
	{
		// Token: 0x0400206D RID: 8301
		public string _Action;

		// Token: 0x0400206E RID: 8302
		public string _Name;
	}

	// Token: 0x020004D3 RID: 1235
	[Serializable]
	public class EffectData
	{
		// Token: 0x0400206F RID: 8303
		public AudioClip _Sound;

		// Token: 0x04002070 RID: 8304
		public string _Animation;

		// Token: 0x04002071 RID: 8305
		public AIActor.ParticleData _ParticleInfo;
	}

	// Token: 0x020004D4 RID: 1236
	[Serializable]
	public class ParticleData
	{
		// Token: 0x04002072 RID: 8306
		public GameObject _Particle;

		// Token: 0x04002073 RID: 8307
		public Vector3 _Position;
	}
}
