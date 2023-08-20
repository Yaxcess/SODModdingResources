using System;
using UnityEngine;

// Token: 0x02001009 RID: 4105
public class ObClickable : KAMonoBase
{
	// Token: 0x17000A2D RID: 2605
	// (get) Token: 0x0600679D RID: 26525 RVA: 0x000470A7 File Offset: 0x000452A7
	public bool pMouseOver
	{
		get
		{
			return this.mMouseOver;
		}
	}

	// Token: 0x17000A2E RID: 2606
	// (get) Token: 0x0600679E RID: 26526 RVA: 0x000470AF File Offset: 0x000452AF
	public bool pMousePressed
	{
		get
		{
			return this.mMousePressed;
		}
	}

	// Token: 0x1400006A RID: 106
	// (add) Token: 0x0600679F RID: 26527 RVA: 0x002A4B78 File Offset: 0x002A2D78
	// (remove) Token: 0x060067A0 RID: 26528 RVA: 0x002A4BAC File Offset: 0x002A2DAC
	private static event ObClickable.ActivatedEventHandler OnActivated;

	// Token: 0x17000A2F RID: 2607
	// (get) Token: 0x060067A1 RID: 26529 RVA: 0x000470B7 File Offset: 0x000452B7
	// (set) Token: 0x060067A2 RID: 26530 RVA: 0x000470BE File Offset: 0x000452BE
	public static GameObject pMouseOverObject
	{
		get
		{
			return ObClickable.mMouseOverObject;
		}
		set
		{
			ObClickable.mMouseOverObject = value;
		}
	}

	// Token: 0x17000A30 RID: 2608
	// (get) Token: 0x060067A3 RID: 26531 RVA: 0x000470C6 File Offset: 0x000452C6
	// (set) Token: 0x060067A4 RID: 26532 RVA: 0x000470CD File Offset: 0x000452CD
	public static bool pGlobalActive
	{
		get
		{
			return ObClickable.mGlobalActive;
		}
		set
		{
			ObClickable.mGlobalActive = value;
		}
	}

    // Token: 0x040064CD RID: 25805
    public SnSound _ClickSound;

    // Token: 0x040064C8 RID: 25800
    public SnSound _RolloverSound;

    // Token: 0x040064C9 RID: 25801
    public SnRandomSound _RolloverRandomSound;

    // Token: 0x040064B7 RID: 25783
    public bool _Draw;

	// Token: 0x040064B8 RID: 25784
	public bool _Active = true;

	// Token: 0x040064B9 RID: 25785
	public bool _UseGlobalActive = true;

	// Token: 0x040064BA RID: 25786
	public bool _AvatarWalkTo = true;

	// Token: 0x040064BB RID: 25787
	public string _LoadLevel = "";

	// Token: 0x040064BC RID: 25788
	public string _StartMarker = "";

	// Token: 0x040064BD RID: 25789
	public GameObject _ActivateObject;

	// Token: 0x040064BE RID: 25790
	public GameObject _MessageObject;

	// Token: 0x040064BF RID: 25791
	public const string _HighlightShader = "KAHighlight";

	// Token: 0x040064C0 RID: 25792
	public Material _HighlightMaterial;

	// Token: 0x040064C1 RID: 25793
	public string _MouseOverAnim = "";

	// Token: 0x040064C2 RID: 25794
	public string _MouseExitAnim = "";

	// Token: 0x040064C3 RID: 25795
	public string _RollOverCursorName = "";

	// Token: 0x040064C4 RID: 25796
	public float _Range;

	// Token: 0x040064C5 RID: 25797
	public float _RangeAngle = 20f;

	// Token: 0x040064C6 RID: 25798
	public Vector3 _RangeOffset = new Vector3(0f, 0f, 0f);

	// Token: 0x040064C7 RID: 25799
	public Vector3 _Offset = new Vector3(0f, 0f, 0f);

	// Token: 0x040064CA RID: 25802
	public bool _RolloverStopOnMouseExit = true;

	// Token: 0x040064CB RID: 25803
	public float _RolloverReplayDelay;

	// Token: 0x040064CC RID: 25804
	public float _RolloverTime = 1f;

	// Token: 0x040064CE RID: 25806
	public bool _FirstOnly;

	// Token: 0x040064CF RID: 25807
	public bool _StopVOPoolOnClick = true;

	// Token: 0x040064D0 RID: 25808
	protected bool mMouseOver;

	// Token: 0x040064D1 RID: 25809
	private bool mMousePressed;

	// Token: 0x040064D2 RID: 25810
	public ObClickable.ObjectClickedDelegate _ObjectClickedCallback;

	// Token: 0x040064D3 RID: 25811
	protected Shader[][] mShaders;

	// Token: 0x040064D4 RID: 25812
	private static bool mGlobalActive = true;

	// Token: 0x040064D5 RID: 25813
	private float mRolloverTime = -1f;

	// Token: 0x040064D6 RID: 25814
	private SnChannel mRolloverSoundChannel;

	// Token: 0x040064D7 RID: 25815
	private AudioClip mRolloverAudioClip;

	// Token: 0x040064D8 RID: 25816
	private float mRolloverReplayDelayTimer;

	// Token: 0x040064D9 RID: 25817
	protected bool mHighlighted;

	// Token: 0x040064DB RID: 25819
	private static GameObject mMouseOverObject = null;

	// Token: 0x040064DC RID: 25820
	private float mLastUpdateTime;

	// Token: 0x0200100A RID: 4106
	// (Invoke) Token: 0x060067BD RID: 26557
	public delegate void ActivatedEventHandler(GameObject go);

	// Token: 0x0200100B RID: 4107
	// (Invoke) Token: 0x060067C1 RID: 26561
	public delegate void ObjectClickedDelegate(GameObject go);
}
