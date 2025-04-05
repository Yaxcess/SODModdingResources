using System;
using UnityEngine;

// Token: 0x020012BA RID: 4794
public class UWSwimmingZone : KAMonoBase
{
	// Token: 0x17000BE5 RID: 3045
	// (get) Token: 0x0600793F RID: 31039 RVA: 0x00052152 File Offset: 0x00050352
	// (set) Token: 0x06007940 RID: 31040 RVA: 0x0005215A File Offset: 0x0005035A
	public UWBreathZoneCSM pLastUsedBreathZone { get; set; }

	// Token: 0x17000BE6 RID: 3046
	// (get) Token: 0x06007941 RID: 31041 RVA: 0x00052163 File Offset: 0x00050363
	// (set) Token: 0x06007942 RID: 31042 RVA: 0x0005216B File Offset: 0x0005036B
	public bool pDoAvatarTransit { get; set; }

	// Token: 0x040073ED RID: 29677
	[Tooltip("The Y position of the top of the swimming zone.")]
	public float _TopYPosition = -2f;

	// Token: 0x040073EE RID: 29678
	[Tooltip("The amount the avatar will move on Y when entering UWSwimming from CSM.")]
	public float _AvatarTransitYOffset = 5f;

	// Token: 0x040073EF RID: 29679
	[Tooltip("The camera will not be allowed above TopYPosition - this.")]
	public float _CameraDistanceFromSurface = 0.5f;

	// Token: 0x040073F0 RID: 29680
	[Tooltip("The avatar will not be allowed above TopYPosition - this.")]
	public float _AvatarDistanceFromSurface = 2f;

	// Token: 0x040073F1 RID: 29681
	[Tooltip("The CSM will be shown if avatar is above TopYPosition - this")]
	public float _CSMTriggerHeight = 2f;

	// Token: 0x040073F2 RID: 29682
	public UiUWSwimAirMeter _AirMeter;

	// Token: 0x040073F3 RID: 29683
	public Transform _DeathMarker;

	// Token: 0x040073F4 RID: 29684
	public UWBreathZoneCSM _DefaultBreathZone;

	// Token: 0x040073F5 RID: 29685
	public UWSwimmingCSM _UWSwimCSM;

	// Token: 0x040073F6 RID: 29686
	public EnvironmentalEffects _EnvironmentalEffects;

	// Token: 0x040073F7 RID: 29687
	public Transform _DragonStayMarker;

	// Token: 0x040073F8 RID: 29688
	public Transform _SurfaceMarker;
}
