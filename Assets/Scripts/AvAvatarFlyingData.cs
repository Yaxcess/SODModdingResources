using System;

// Token: 0x02000562 RID: 1378
[Serializable]
public class AvAvatarFlyingData
{
	// Token: 0x060024C2 RID: 9410 RVA: 0x00156D54 File Offset: 0x00154F54
	public AvAvatarFlyingData Clone()
	{
		AvAvatarFlyingData avAvatarFlyingData = new AvAvatarFlyingData();
		avAvatarFlyingData._RollTurnRate = this._RollTurnRate;
		avAvatarFlyingData._RollDampRate = this._RollDampRate;
		avAvatarFlyingData._YawTurnRate = this._YawTurnRate;
		avAvatarFlyingData._YawTurnFactor = this._YawTurnFactor;
		avAvatarFlyingData._PitchTurnRate = this._PitchTurnRate;
		avAvatarFlyingData._PitchDampRate = this._PitchDampRate;
		avAvatarFlyingData._Acceleration = this._Acceleration;
		avAvatarFlyingData._ManualFlapAccel = this._ManualFlapAccel;
		avAvatarFlyingData._ManualFlapTimer = this._ManualFlapTimer;
		avAvatarFlyingData._SpeedDampRate = this._SpeedDampRate;
		avAvatarFlyingData._BrakeDecel = this._BrakeDecel;
		avAvatarFlyingData._ClimbAccelRate = this._ClimbAccelRate;
		avAvatarFlyingData._DiveAccelRate = this._DiveAccelRate;
		avAvatarFlyingData._GlideDownMultiplier = this._GlideDownMultiplier;
		avAvatarFlyingData._FlyingMaxUpPitch = this._FlyingMaxUpPitch;
		avAvatarFlyingData._FlyingMaxDownPitch = this._FlyingMaxDownPitch;
		avAvatarFlyingData._GlidingMaxUpPitch = this._GlidingMaxUpPitch;
		avAvatarFlyingData._GlidingMaxDownPitch = this._GlidingMaxDownPitch;
		avAvatarFlyingData._MaxRoll = this._MaxRoll;
		avAvatarFlyingData._SpeedModifierOnCollision = this._SpeedModifierOnCollision;
		avAvatarFlyingData._BounceOnCollision = this._BounceOnCollision;
		avAvatarFlyingData._FlyingPositionBoostFactor = this._FlyingPositionBoostFactor;
		MinMax speed = new MinMax(this._Speed.Min, this._Speed.Max);
		avAvatarFlyingData._Speed = speed;
		return avAvatarFlyingData;
	}

	// Token: 0x040023D4 RID: 9172
	public float _RollTurnRate = 1.3f;

	// Token: 0x040023D5 RID: 9173
	public float _RollDampRate = 1.8f;

	// Token: 0x040023D6 RID: 9174
	public float _YawTurnRate = 2f;

	// Token: 0x040023D7 RID: 9175
	public float _YawTurnFactor = 0.3f;

	// Token: 0x040023D8 RID: 9176
	public float _PitchTurnRate = 1.5f;

	// Token: 0x040023D9 RID: 9177
	public float _PitchDampRate = 1.5f;

	// Token: 0x040023DA RID: 9178
	public MinMax _Speed = new MinMax(4f, 16f);

	// Token: 0x040023DB RID: 9179
	public float _Acceleration = 1.5f;

	// Token: 0x040023DC RID: 9180
	public float _ManualFlapAccel = 2f;

	// Token: 0x040023DD RID: 9181
	public float _ManualFlapTimer = 1f;

	// Token: 0x040023DE RID: 9182
	public float _SpeedDampRate = 10f;

	// Token: 0x040023DF RID: 9183
	public float _BrakeDecel = 0.5f;

	// Token: 0x040023E0 RID: 9184
	public float _ClimbAccelRate = 0.2f;

	// Token: 0x040023E1 RID: 9185
	public float _DiveAccelRate = 1f;

	// Token: 0x040023E2 RID: 9186
	public float _SpeedModifierOnCollision = 1f;

	// Token: 0x040023E3 RID: 9187
	public float _BounceOnCollision = 3f;

	// Token: 0x040023E4 RID: 9188
	public float _GlideDownMultiplier = 0.5f;

	// Token: 0x040023E5 RID: 9189
	public float _GravityModifier;

	// Token: 0x040023E6 RID: 9190
	public float _GravityClimbMultiplier = 1f;

	// Token: 0x040023E7 RID: 9191
	public float _GravityDiveMultiplier = 1f;

	// Token: 0x040023E8 RID: 9192
	public float _FlyingMaxUpPitch = 40f;

	// Token: 0x040023E9 RID: 9193
	public float _FlyingMaxDownPitch = 50f;

	// Token: 0x040023EA RID: 9194
	public float _GlidingMaxUpPitch = 30f;

	// Token: 0x040023EB RID: 9195
	public float _GlidingMaxDownPitch = 50f;

	// Token: 0x040023EC RID: 9196
	public float _MaxRoll = 40f;

	// Token: 0x040023ED RID: 9197
	public float _FlyingPositionBoostFactor = 1f;
}
