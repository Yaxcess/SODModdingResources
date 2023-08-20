using System;
using UnityEngine;

// Token: 0x02000DE2 RID: 3554
[RequireComponent(typeof(Camera))]
public class KAUIManager : KAUICamera
{
	// Token: 0x170007F2 RID: 2034
	// (get) Token: 0x0600571F RID: 22303 RVA: 0x0003B8F5 File Offset: 0x00039AF5
	public static KAUIManager pInstance
	{
		get
		{
			return KAUIManager.mInstance;
		}
	}

	
	// Token: 0x04005711 RID: 22289
	public int _MinLandscapeOrthoSize = 384;

	// Token: 0x04005712 RID: 22290
	public int _MaxLandscapeOrthoSize = 384;

	// Token: 0x04005713 RID: 22291
	public int _MinPortraitOrthoSize = 512;

	// Token: 0x04005714 RID: 22292
	public int _MaxPortraitOrthoSize = 512;

	// Token: 0x04005715 RID: 22293
	public float _2Dto3DScaleFactor = 0.005f;

	// Token: 0x04005716 RID: 22294
	public KAUIManager.CameraOrthoSize[] _CameraOrthoSize;

	// Token: 0x04005717 RID: 22295
	private bool mCameraOrthoSet;

	// Token: 0x04005718 RID: 22296
	private static KAUIManager mInstance;

	// Token: 0x0400571A RID: 22298
	public bool _TestPortraitInEditor;

	// Token: 0x0400571B RID: 22299
	public bool _TestSmallScreenInEditor;

	// Token: 0x0400571C RID: 22300
	public float _SmallScreenDiagonalInches = 5f;

	// Token: 0x0400571D RID: 22301
	public bool _UpdateCameraFOV;

	// Token: 0x0400571E RID: 22302
	public float _PortraitFOV;

	// Token: 0x0400571F RID: 22303
	public float _LandscapeFOV;

	// Token: 0x04005720 RID: 22304
	private bool mIsPortraitMode;

	// Token: 0x04005721 RID: 22305
	private bool mIsLandscapeMode;

	// Token: 0x04005722 RID: 22306
	private string mInput;

	// Token: 0x04005723 RID: 22307
	private KAWidget mSelectedWidget;

	// Token: 0x04005724 RID: 22308
	private GameObject mSelectedObject;

	// Token: 0x04005725 RID: 22309
	private KAWidget mDragItem;

	// Token: 0x02000DE3 RID: 3555
	[Serializable]
	public class CameraOrthoSize
	{
		// Token: 0x04005726 RID: 22310
		public int _AspectWidth;

		// Token: 0x04005727 RID: 22311
		public int _AspectHeight;

		// Token: 0x04005728 RID: 22312
		public int _StandloneLandscapeOrthoSize;

		// Token: 0x04005729 RID: 22313
		public int _MobileLandscapeOrthoSize;

		// Token: 0x0400572A RID: 22314
		public int _StandlonePortraitOrthoSize;

		// Token: 0x0400572B RID: 22315
		public int _MobilePortraitOrthoSize;
	}
}
