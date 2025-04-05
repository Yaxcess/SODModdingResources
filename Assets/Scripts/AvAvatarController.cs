using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x02000565 RID: 1381
[RequireComponent(typeof(CharacterController))]
public class AvAvatarController : SplineControl
{
    // Token: 0x17000351 RID: 849
    // (get) Token: 0x060024C5 RID: 9413 RVA: 0x0001D605 File Offset: 0x0001B805
    // (set) Token: 0x060024C6 RID: 9414 RVA: 0x0001D60D File Offset: 0x0001B80D
    public bool DisableSoarButtonUpdate { get; set; }

    // Token: 0x17000352 RID: 850
    // (get) Token: 0x060024C7 RID: 9415 RVA: 0x0001D616 File Offset: 0x0001B816
    // (set) Token: 0x060024C8 RID: 9416 RVA: 0x0001D61E File Offset: 0x0001B81E
    public bool PlayingFlightSchoolFlightSuit { get; set; }

    public bool pIsTransiting { get; set; }

    public UWSwimmingZone pUWSwimZone { get; set; }

    // Token: 0x040023F5 RID: 9205
    public float _ObjectDragAngleLimit = 50f;

    // Token: 0x040023F6 RID: 9206
    public float _ObjectDragSnapPosLimit = 0.3f;

    // Token: 0x040023F7 RID: 9207
    public string _ObjectDragTag = "Draggable";

    // Token: 0x040023F8 RID: 9208
    public string _MainRootName = "";

    // Token: 0x040023F9 RID: 9209
    public Transform _MainRoot;

    // Token: 0x040023FA RID: 9210
    public AvAvatarControlMode _ControlMode;

    // Token: 0x040023FB RID: 9211
    public AvAvatarStateData[] _StateData;

    // Token: 0x040023FC RID: 9212
    public float _Height;

    // Token: 0x040023FD RID: 9213
    public float _GroundSnapThreshold = 0.6f;

    // Token: 0x040023FE RID: 9214
    public float _FireballImmuneTime = 1f;

    // Token: 0x040023FF RID: 9215
    public int _AttackDamage = 1;

    // Token: 0x04002400 RID: 9216
    public AvAvatarShooting _AvatarShootingData;

    // Token: 0x04002401 RID: 9217
    public string[] _ProjectileFiringAreas;

    // Token: 0x04002402 RID: 9218
    public string[] _AvatarAttackingAreas;

    // Token: 0x04002403 RID: 9219
    public GameObject _CoinsReceivedPrtPrefab;

    // Token: 0x04002404 RID: 9220
    public Vector3 _CoinsReceivedPrtOffset = Vector3.up * 1.5f;

    // Token: 0x04002405 RID: 9221
    public bool _ActivateOnAwake;

    // Token: 0x04002406 RID: 9222
    public float _GlideModeAutoHeight = 2f;

    // Token: 0x04002407 RID: 9223
    public Transform _FlyingBone;

    // Token: 0x04002408 RID: 9224
    public bool _NoFlyingLanding;

    // Token: 0x04002409 RID: 9225
    public AvAvatarBounceParams _AvatarBounceParams;

    // Token: 0x0400240A RID: 9226
    public SnRandomSound _JumpTriggerSound;

    // Token: 0x0400240B RID: 9227
    public string _CarryAnim;

    // Token: 0x0400240C RID: 9228
    public Vector3 _CarryOffset;

    // Token: 0x0400240D RID: 9229
    public AvAvatarWallClimbParams _WallClimbParams;

    // Token: 0x0400240E RID: 9230
    public Vector3 _DisplayNameOffset = new Vector3(0f, 2f, 0f);

    // Token: 0x0400240F RID: 9231
    public Vector3 _EmoticonOffset = new Vector3(0f, 2f, 0f);

    // Token: 0x04002410 RID: 9232
    public LocaleString _NoOpenChatText;

    // Token: 0x04002411 RID: 9233
    public AvAvatarChatSizes[] _ChatSizes;

    // Token: 0x04002412 RID: 9234
    public Transform _ChatBubbleParent;

    // Token: 0x04002413 RID: 9235
    public List<ModifierAttributes> _ModifierAttributes = new List<ModifierAttributes>();

    // Token: 0x04002414 RID: 9236
    public int _GlidingAngle = 60;

    // Token: 0x04002415 RID: 9237
    [Range(-1f, 1f)]
    public float _InitialGlideThrust = -0.4f;

    // Token: 0x04002416 RID: 9238
    public float _RemoveButtonTimer = 10f;

    // Token: 0x04002417 RID: 9239
    public int _FlightSuitCategoryIDs = 228;

    // Token: 0x04002418 RID: 9240
    public AvAvatarController.FxData[] _GlidingFxData;

    // Token: 0x04002419 RID: 9241
    public bool _ApplyGlideFxOnDive;

    // Token: 0x0400241A RID: 9242
    public float _FlySpeedLimitToSwim = 2f;

    // Token: 0x0400241B RID: 9243
    public string _SoarTutorialName = "Soar";

    // Token: 0x0400241C RID: 9244
    public string _RemoveTutorialName = "RemoveFlightSuit";

    // Token: 0x0400241D RID: 9245
    public string _LastEquippedFlightSuitKey = "LEFS";

    // Token: 0x0400241E RID: 9246
    public GameObject _WaterSplashParticle;

    // Token: 0x0400241F RID: 9247
    public GameObject _SwimParticle;

    // Token: 0x04002420 RID: 9248
    public GameObject _SwimIdleParticle;

    // Token: 0x04002421 RID: 9249
    public GameObject _WaterSkimParticle;

    // Token: 0x04002422 RID: 9250
    public Transform _SwimParticleBone;

    // Token: 0x04002423 RID: 9251
    public Transform _HandBone;

    // Token: 0x04002424 RID: 9252
    public AvAvatarBlink _Blink;

    // Token: 0x04002425 RID: 9253
    public AvAvatarStats _Stats = new AvAvatarStats();

    // Token: 0x04002426 RID: 9254
    public Vector3 _CSMColliderMountedPosition;

    // Token: 0x04002427 RID: 9255
    public Vector3 _CSMColliderUnmountedPosition;

    // Token: 0x04002428 RID: 9256
    public float _CSMColliderMountedHeight = 1f;

    // Token: 0x04002429 RID: 9257
    public float _CSMColliderUnmountedHeight = 1.6f;

    // Token: 0x0400242A RID: 9258
    public float _CSMColliderRadius = 0.3f;

    // Token: 0x0400242B RID: 9259
    public string _CSMRollOverCurserName = "Activate";

    // Token: 0x0400242C RID: 9260
    public const string AVATAR_CSM_COLLIDER_TAG = "AvatarCSMCollider";

    // Token: 0x0400242D RID: 9261
    public float _DisplayNameStartHeight = 1.5f;

    public float _DisplayNameSpacing = 0.2f;

    public const float MinHoverSpeed = 1f;

    public static bool mAimControlMode = true;

    public static bool mForceBraking = false;

    public float _DefaultFlightPitch = 15f;

    public float _DefaultFlightDistance = 8f;

    public float _GlidingTakeOffSpeed = 20f;

    public float _GlideTakeOffTimer = 0.5f;

    public float _JoySensitivity = 0.7f;

    public float _BonusMaxSpeedWithBoost = 0.2f;

    public float _AccelValueWithBoost = 2f;

    public float _WaterDrag = 1f;

    [HideInInspector]
    public bool mDisplayFlyingData;

    public static bool mForceBrakeUWSwimming = false;

    public float _DefaultUWSwimmingPitch = 15f;

    public float _DefaultUWSwimDistance = 8f;

    public float _MaxUWSwimSpeedWithBoost = 0.2f;

    public float _UWSwimAccelValueWithBoost = 2f;

    public AudioClip _PlayerHealthZeroSFX;

    public GameObject _UWSwimParticle;

    public GameObject _UWSwimIdleParticle;

    public GameObject _UWSwimBrakeParticle;

    [Serializable]
    public class FxData
    {
        public GameObject _Fx;

        public Transform _Bone;

        public Vector3 _Offset;
    }
    public class CarriedObject
    {
        public CarriedObject(GameObject go, bool duplicate)
        {
        }

        public GameObject _CarriedObject;

        public bool _IsDuplicated;
    }

    public enum SwimAnimState
    {
        NONE,
        SPLASH,
        SWIM,
        IDLE,
        UWSWIM,
        UWIDLE,
        UWBRAKE
    }
}
