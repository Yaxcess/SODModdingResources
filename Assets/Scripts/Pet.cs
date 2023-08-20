using System;
using UnityEngine;

// Token: 0x020010E5 RID: 4325
public class Pet : MonoBehaviour
{


	// Token: 0x040068F7 RID: 26871
	public bool _FollowAvatar = true;

	// Token: 0x040068F8 RID: 26872
	public bool _FollowFront;

	// Token: 0x040068F9 RID: 26873
	public float _AvatarDistanceCheckInterval = 5f;

	// Token: 0x040068FA RID: 26874
	public float _TeleportToAvatarDistanceThreshold = 20f;

	// Token: 0x040068FB RID: 26875
	public float _MaxHeightDiffWithAvatar = 1.5f;

	// Token: 0x040068FC RID: 26876
	public string _AnimNameIdle = "IdleStand";

	// Token: 0x040068FD RID: 26877
	public string _AnimNameSwim = "FlyForward";

	// Token: 0x040068FE RID: 26878
	public string _AnimNameRun = "FlyForwardBoostFlap";

	// Token: 0x040068FF RID: 26879
	public string _AnimNameSleep = "IdleStand";

	// Token: 0x04006900 RID: 26880
	public string _AnimNameWalk = "FlyForward";

	// Token: 0x04006901 RID: 26881
	[NonSerialized]
	public string _IdleAnimName = "";

	// Token: 0x04006902 RID: 26882
	public float _IdleAnimSpeed = 1f;

	// Token: 0x04006903 RID: 26883
	public static float pAvatarOffSetOffSetNow;

	// Token: 0x04006904 RID: 26884
	public bool _MoveToDone;

	// Token: 0x04006905 RID: 26885
	public float _HeightTweenSpeed = 1.5f;

	// Token: 0x04006906 RID: 26886
	public float _StartOffsetFront;

	// Token: 0x04006907 RID: 26887
	public float _StartOffsetRear = 100f;

	// Token: 0x04006908 RID: 26888
	public float _FollowFrontDistance = 2.5f;

	// Token: 0x04006909 RID: 26889
	public float _FollowRearDistance = 1.5f;

	// Token: 0x0400690A RID: 26890
	public float _TweenTime = 1f;

	// Token: 0x0400690B RID: 26891
	public Pet.PetFollowArray[] _PetFollowArray;

	// Token: 0x0400690C RID: 26892
	public float _UpdateAvatarTargetPositionDelayRate = 0.2f;

	// Token: 0x0400690D RID: 26893
	public float _AvatarTargetPositionDistanceOffset = 0.1f;

	// Token: 0x0400690E RID: 26894
	public float _MinPettingTimer = 4f;

	// Token: 0x0400690F RID: 26895
	[NonSerialized]
	public bool pIsPetting;

	// Token: 0x04006910 RID: 26896
	public Transform mAvatar;

	// Token: 0x04006911 RID: 26897
	public Transform mAvatarTarget;

	// Token: 0x04006913 RID: 26899
	protected bool mMoveToAvatarPostponed;

	// Token: 0x04006914 RID: 26900
	protected Vector3 mAvatarLookAt = Vector3.forward;

	// Token: 0x04006915 RID: 26901
	protected float mAvatarOffsetSign = 1f;

	// Token: 0x04006916 RID: 26902
	protected float mAvatarOffsetOffset;

	// Token: 0x04006917 RID: 26903
	protected GameObject mWaterObject;

	// Token: 0x04006918 RID: 26904
	protected bool mCanBePetted;

	// Token: 0x04006919 RID: 26905
	protected bool mPettingAllowed;

	// Token: 0x0400691A RID: 26906
	protected GameObject[] mPettingBones;

	// Token: 0x0400691B RID: 26907
	protected int mNumPettingBones;

	// Token: 0x0400691C RID: 26908
	protected float mPettingTimer;

	// Token: 0x0400691D RID: 26909
	protected Vector3 mOldPettingMousePos = new Vector3(0f, 0f, 0f);

	// Token: 0x0400691E RID: 26910
	protected bool mMouseOverPettingParts;

	// Token: 0x0400691F RID: 26911
	protected string mPettingPartName = "";

	// Token: 0x04006920 RID: 26912
	protected float mPrevHeight;

	// Token: 0x04006921 RID: 26913
	private bool mTweenTimeSet;

	// Token: 0x04006922 RID: 26914
	private int mPathIndex = -1;

	// Token: 0x04006923 RID: 26915
	private float mTweenTime;

	// Token: 0x04006924 RID: 26916
	protected Vector3 mCurrentGroundNormal = Vector3.up;

	// Token: 0x04006925 RID: 26917
	private Vector3 mAvatarPrevPos = new Vector3(-100f, -100f, -100f);

	// Token: 0x04006926 RID: 26918
	private float mNextUpdateAvatarTargetPostionTime;

	// Token: 0x020010E6 RID: 4326
	[Serializable]
	public class PetFollowArray
	{
		// Token: 0x06006BAE RID: 27566 RVA: 0x0004A03D File Offset: 0x0004823D
		public PetFollowArray(float speed, float distance)
		{
			this.Speed = speed;
			this.FarDistance = distance;
		}

		// Token: 0x04006927 RID: 26919
		public float Speed;

		// Token: 0x04006928 RID: 26920
		public float FarDistance;
	}
}
