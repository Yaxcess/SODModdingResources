using System;
using UnityEngine;

// Token: 0x02000F44 RID: 3908
[RequireComponent(typeof(UIPanel))]
[AddComponentMenu("NGUI/Internal/Spring Panel")]
public class SpringPanel : MonoBehaviour
{

	// Token: 0x04005FC9 RID: 24521
	public static SpringPanel current;

	// Token: 0x04005FCA RID: 24522
	public Vector3 target = Vector3.zero;

	// Token: 0x04005FCB RID: 24523
	public float strength = 10f;

	// Token: 0x04005FCC RID: 24524
	public SpringPanel.OnFinished onFinished;

	// (Invoke) Token: 0x060061B0 RID: 25008
	public delegate void OnFinished();
}
