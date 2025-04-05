using System;

// Token: 0x02000559 RID: 1369
[Serializable]
public class AvAvatarStats
{
	// Token: 0x04002375 RID: 9077
	public float _CurrentHealth;

	// Token: 0x04002376 RID: 9078
	public float _MaxHealth;

	// Token: 0x04002377 RID: 9079
	public float _HealthRegenRate = 1f;

	// Token: 0x04002378 RID: 9080
	public float _CurrentEnergy;

	// Token: 0x04002379 RID: 9081
	public float _MaxEnergy;

	// Token: 0x0400237A RID: 9082
	public float _EnergyRegenRate;

	// Token: 0x0400237B RID: 9083
	public float _AutoAttackSpeed;

	// Token: 0x0400237C RID: 9084
	public float _AutoAttackRange;

	// Token: 0x0400237D RID: 9085
	public int _AttackDamageMin;

	// Token: 0x0400237E RID: 9086
	public int _AttackDamageMax;

	// Token: 0x0400237F RID: 9087
	public int _Strength;

	// Token: 0x04002380 RID: 9088
	public int _Endurance;

	// Token: 0x04002381 RID: 9089
	public int _Toughness;

	// Token: 0x04002382 RID: 9090
	public int _Dexterity;

	// Token: 0x04002383 RID: 9091
	public int _Intelligence;

	// Token: 0x04002384 RID: 9092
	public int _Will;

	// Token: 0x04002385 RID: 9093
	public float _CurrentLuck;

	// Token: 0x04002386 RID: 9094
	public float _MaxLuck;

	// Token: 0x04002387 RID: 9095
	public float _CurrentAir;

	// Token: 0x04002388 RID: 9096
	public float _MaxAir = 100f;

	// Token: 0x04002389 RID: 9097
	public float _AirUseRate = -0.2f;

	// Token: 0x0400238A RID: 9098
	public float _NoAirHealthDamageRate = -0.05f;
}
