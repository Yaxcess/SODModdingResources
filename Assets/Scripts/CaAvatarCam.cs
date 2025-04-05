using System;
using UnityEngine;

// Token: 0x020005A2 RID: 1442
public class CaAvatarCam : KAMonoBase
{
	public const float mMinCameraDistance = 2f;

	public static float _AccelRadius = 3f;

	public float _Speed;

	public bool _IgnoreCollision;

	public bool _FreeRotate = true;

	public float _CollisionRadius = 0.25f;

	public float _DefaultPitch = 25f;

	public float _DefaultDistance = 4f;

	public float mMaxCameraDistance = 12f;

	public bool mUpdateAvatarCamParam = true;

	[Range(0f, 1f)]
	public float _OptimizationFarClipScaleFactor = 1f;

	public enum CameraLayer
	{
		LAYER_AVATAR,
		LAYER_FLYING,
		LAYER_ENGAGEMENT,
		LAYER_FISHING,
		LAYER_COUNT
	}

	public enum CameraMode
	{
		MODE_RELATIVE,
		MODE_ABSOLUTE,
		MODE_SHAKE
	}

	public struct CamInterpData
	{
		public Vector3 offset;

		public float focusHeight;

		public float lookAtHeight;

		public float speed;

		public CaAvatarCam.CameraMode mode;

		public Transform lookAt;

		public Quaternion lookQuat;

		public Transform pitchBone;

		public float relativePitch;

		public AvAvatarController lookAtController;

		public float curAccelRadius;

		public bool postLerp;

		public Vector3 mDesWorldPos;

		public Vector3 mCurWorldPos;
	}
}
