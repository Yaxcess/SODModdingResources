using System;
using UnityEngine;

// Token: 0x0200055C RID: 1372
[Serializable]
public class AvAvatarStateData
{

	// Token: 0x04002399 RID: 9113
	public AvAvatarSubState _State;

	// Token: 0x0400239A RID: 9114
	public float _Acceleration = 10f;

	// Token: 0x0400239B RID: 9115
	public float _RotSpeed = 100f;

	// Token: 0x0400239C RID: 9116
	public float _RestThreshold = 0.1f;

	// Token: 0x0400239D RID: 9117
	public float _WalkThreshold = 3f;

	// Token: 0x0400239E RID: 9118
	public float _WalkAnimScale = 0.3f;

	// Token: 0x0400239F RID: 9119
	public float _RunAnimScale = 0.2f;

	// Token: 0x040023A0 RID: 9120
	public float _MaxForwardSpeed = 6f;

	// Token: 0x040023A1 RID: 9121
	public float _MinForwardSpeed;

	// Token: 0x040023A2 RID: 9122
	public float _MaxBackwardSpeed = 2.5f;

	// Token: 0x040023A3 RID: 9123
	public float _MaxAirSpeed = 4.25f;

	// Token: 0x040023A4 RID: 9124
	public float _Gravity = -16f;

	// Token: 0x040023A5 RID: 9125
	public float _MaxForwardBackwardTilt;

	// Token: 0x040023A6 RID: 9126
	public float _MaxSidewaysTilt;

	// Token: 0x040023A7 RID: 9127
	public float _PushPower;

	// Token: 0x040023A8 RID: 9128
	public float _FidgetTimeMin = 8f;

	// Token: 0x040023A9 RID: 9129
	public float _FidgetTimeMax = 12f;

	// Token: 0x040023AA RID: 9130
	public float _Height = 0.35f;

	// Token: 0x040023AB RID: 9131
	public AvAvatarCamParams _AvatarCameraParams;

	// Token: 0x040023AC RID: 9132
	public Vector3 _JumpBack = Vector3.zero;

	// Token: 0x040023AD RID: 9133
	public AvAvatarJump _JumpValues;

	// Token: 0x040023AE RID: 9134
	public AvAvatarStateAnims _StateAnims;
}
