using UnityEngine;

// Token: 0x020012B4 RID: 4788
public class UWBreathZoneCSM : ObContextSensitive
{
	// Token: 0x040073C5 RID: 29637
	public ContextSensitiveState[] _Menus;

	// Token: 0x040073C6 RID: 29638
	public string _BreathZoneCSItemName = "BreathZone";

	// Token: 0x040073C7 RID: 29639
	public string _SwimCSItemName = "SwimZone";

	public Transform _BreathMarker;

	// Token: 0x040073CA RID: 29642
	public GameObject _CutSceneZoneIn;

	// Token: 0x040073CB RID: 29643
	public GameObject _CutSceneZoneOut;

	// Token: 0x040073CC RID: 29644
	public GameObject _BreathZoneCamera;

	// Token: 0x040073CD RID: 29645
	public float _HealthRefillRate = 0.1f;

	// Token: 0x040073CE RID: 29646
	public float _AirRefillRate = 0.2f;

	// Token: 0x040073CF RID: 29647
	public float _PetHealthRegenRatePercent = 1000f;

	// Token: 0x040073D0 RID: 29648
	public float _PetUpdateFrequency = 0.1f;
	public enum BreathZoneSubState
	{
		// Token: 0x040073DB RID: 29659
		NONE,
		// Token: 0x040073DC RID: 29660
		TRANSIT_IN,
		// Token: 0x040073DD RID: 29661
		BREATHING,
		// Token: 0x040073DE RID: 29662
		TRANSIT_OUT
	}
}
