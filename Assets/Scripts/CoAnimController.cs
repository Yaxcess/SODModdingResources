using System;
using UnityEngine;

// Token: 0x020005D2 RID: 1490
public class CoAnimController : MonoBehaviour
{

	// Token: 0x04002740 RID: 10048
	public string _MessageObjectName = "";

	// Token: 0x04002741 RID: 10049
	public GameObject _MessageObject;

	// Token: 0x04002742 RID: 10050
	public Transform _AvatarMarker;

	// Token: 0x04002743 RID: 10051
	public Transform _PetMarker;

	// Token: 0x04002744 RID: 10052
	public float _CrossFade = 0.2f;

	// Token: 0x04002745 RID: 10053
	public float _AnimSpeed = 1f;

	// Token: 0x04002746 RID: 10054
	public bool _DisplayTime;

	// Token: 0x04002747 RID: 10055
	public Vector2 _TimePos = new Vector2(10f, 10f);

	// Token: 0x04002748 RID: 10056
	public Transform _PostCSAvatarMarker;

	// Token: 0x04002749 RID: 10057
	private float mTimer;

	// Token: 0x0400274A RID: 10058
	private AnimationState mAState;

	// Token: 0x0400274B RID: 10059
	private Vector3 mOriginalAvatarPosition = Vector3.zero;

	// Token: 0x0400274C RID: 10060
	private Quaternion mOriginalAvatarRotation = Quaternion.identity;

	// Token: 0x0400274D RID: 10061
	private bool mWasAvatarMounted;

	// Token: 0x0400274E RID: 10062
	public static Action OnCutSceneStart;

	// Token: 0x0400274F RID: 10063
	public static Action OnCutSceneDone;
}
