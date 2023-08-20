using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x02000F83 RID: 3971
[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
public class UICamera : KAMonoBase
{
	
	// Token: 0x0400615F RID: 24927
	public static UICamera.OnScreenResize onScreenResize;

	// Token: 0x04006160 RID: 24928
	public UICamera.EventType eventType = UICamera.EventType.UI_3D;

	// Token: 0x04006161 RID: 24929
	public bool eventsGoToColliders;

	// Token: 0x04006162 RID: 24930
	public LayerMask eventReceiverMask = -1;

	// Token: 0x04006163 RID: 24931
	[HideInInspector]
	public bool _IsMouseButtonUp;

	// Token: 0x04006164 RID: 24932
	public UICamera.ProcessEventsIn processEventsIn;

	// Token: 0x04006165 RID: 24933
	public bool debug;

	// Token: 0x04006166 RID: 24934
	public bool useMouse = true;

	// Token: 0x04006167 RID: 24935
	public bool useTouch = true;

	// Token: 0x04006168 RID: 24936
	public bool allowMultiTouch = true;

	// Token: 0x04006169 RID: 24937
	public bool useKeyboard = true;

	// Token: 0x0400616A RID: 24938
	public bool useController = true;

	// Token: 0x0400616B RID: 24939
	public bool stickyTooltip = true;

	// Token: 0x0400616C RID: 24940
	public float tooltipDelay = 1f;

	// Token: 0x0400616D RID: 24941
	public bool longPressTooltip;

	// Token: 0x0400616E RID: 24942
	public float mouseDragThreshold = 4f;

	// Token: 0x0400616F RID: 24943
	public float mouseClickThreshold = 10f;

	// Token: 0x04006170 RID: 24944
	public float touchDragThreshold = 40f;

	// Token: 0x04006171 RID: 24945
	public float touchClickThreshold = 40f;

	// Token: 0x04006172 RID: 24946
	public float rangeDistance = -1f;

	// Token: 0x04006173 RID: 24947
	public string horizontalAxisName = "Horizontal";

	// Token: 0x04006174 RID: 24948
	public string verticalAxisName = "Vertical";

	// Token: 0x04006175 RID: 24949
	public string horizontalPanAxisName;

	// Token: 0x04006176 RID: 24950
	public string verticalPanAxisName;

	// Token: 0x04006177 RID: 24951
	public string scrollAxisName = "Mouse ScrollWheel";

	// Token: 0x04006178 RID: 24952
	[Tooltip("If enabled, command-click will result in a right-click event on OSX")]
	public bool commandClick = true;

	// Token: 0x04006179 RID: 24953
	public KeyCode submitKey0 = KeyCode.Return;

	// Token: 0x0400617A RID: 24954
	public KeyCode submitKey1 = KeyCode.JoystickButton0;

	// Token: 0x0400617B RID: 24955
	public KeyCode cancelKey0 = KeyCode.Escape;

	// Token: 0x0400617C RID: 24956
	public KeyCode cancelKey1 = KeyCode.JoystickButton1;

	// Token: 0x0400617D RID: 24957
	public bool autoHideCursor = true;

	// Token: 0x0400617E RID: 24958
	public static UICamera.OnCustomInput onCustomInput;

	// Token: 0x0400617F RID: 24959
	public static bool showTooltips = true;

	// Token: 0x04006180 RID: 24960
	public static bool ignoreAllEvents = false;

	// Token: 0x04006181 RID: 24961
	public static bool ignoreControllerInput = false;

	// Token: 0x04006182 RID: 24962
	private static bool mDisableController = false;

	// Token: 0x04006183 RID: 24963
	private static Vector2 mLastPos = Vector2.zero;

	// Token: 0x04006184 RID: 24964
	public static Vector3 lastWorldPosition = Vector3.zero;

	// Token: 0x04006185 RID: 24965
	public static Ray lastWorldRay = default(Ray);

	// Token: 0x04006186 RID: 24966
	public static RaycastHit lastHit;

	// Token: 0x04006187 RID: 24967
	public static UICamera current = null;

	// Token: 0x04006188 RID: 24968
	public static Camera currentCamera = null;

	// Token: 0x04006189 RID: 24969
	public static UICamera.OnSchemeChange onSchemeChange;

	// Token: 0x0400618A RID: 24970
	private static UICamera.ControlScheme mLastScheme = UICamera.ControlScheme.Mouse;

	// Token: 0x0400618B RID: 24971
	public static int currentTouchID = -100;

	// Token: 0x0400618C RID: 24972
	private static KeyCode mCurrentKey = KeyCode.Alpha0;

	// Token: 0x0400618D RID: 24973
	public static UICamera.MouseOrTouch currentTouch = null;

	// Token: 0x0400618E RID: 24974
	private static bool mInputFocus = false;

	// Token: 0x0400618F RID: 24975
	private static GameObject mGenericHandler;

	// Token: 0x04006190 RID: 24976
	public static GameObject fallThrough;

	// Token: 0x04006191 RID: 24977
	public static UICamera.VoidDelegate onClick;

	// Token: 0x04006192 RID: 24978
	public static UICamera.VoidDelegate onDoubleClick;

	// Token: 0x04006193 RID: 24979
	public static UICamera.BoolDelegate onHover;

	// Token: 0x04006194 RID: 24980
	public static UICamera.BoolDelegate onPress;

	// Token: 0x04006195 RID: 24981
	public static UICamera.BoolDelegate onSelect;

	// Token: 0x04006196 RID: 24982
	public static UICamera.FloatDelegate onScroll;

	// Token: 0x04006197 RID: 24983
	public static UICamera.VectorDelegate onDrag;

	// Token: 0x04006198 RID: 24984
	public static UICamera.VoidDelegate onDragStart;

	// Token: 0x04006199 RID: 24985
	public static UICamera.ObjectDelegate onDragOver;

	// Token: 0x0400619A RID: 24986
	public static UICamera.ObjectDelegate onDragOut;

	// Token: 0x0400619B RID: 24987
	public static UICamera.VoidDelegate onDragEnd;

	// Token: 0x0400619C RID: 24988
	public static UICamera.ObjectDelegate onDrop;

	// Token: 0x0400619D RID: 24989
	public static UICamera.KeyCodeDelegate onKey;

	// Token: 0x0400619E RID: 24990
	public static UICamera.KeyCodeDelegate onNavigate;

	// Token: 0x0400619F RID: 24991
	public static UICamera.VectorDelegate onPan;

	// Token: 0x040061A0 RID: 24992
	public static UICamera.BoolDelegate onTooltip;

	// Token: 0x040061A1 RID: 24993
	public static UICamera.MoveDelegate onMouseMove;

	// Token: 0x040061A2 RID: 24994
	private static UICamera.MouseOrTouch[] mMouse = new UICamera.MouseOrTouch[]
	{
		new UICamera.MouseOrTouch(),
		new UICamera.MouseOrTouch(),
		new UICamera.MouseOrTouch()
	};

	// Token: 0x040061A3 RID: 24995
	public static UICamera.MouseOrTouch controller = new UICamera.MouseOrTouch();

	// Token: 0x040061A4 RID: 24996
	public static List<UICamera.MouseOrTouch> activeTouches = new List<UICamera.MouseOrTouch>();

	// Token: 0x040061A5 RID: 24997
	private static List<int> mTouchIDs = new List<int>();

	// Token: 0x040061A6 RID: 24998
	private static int mWidth = 0;

	// Token: 0x040061A7 RID: 24999
	private static int mHeight = 0;

	// Token: 0x040061A8 RID: 25000
	public static GameObject mTooltip = null;

	// Token: 0x040061A9 RID: 25001
	private Camera mCam;

	// Token: 0x040061AA RID: 25002
	public static float mTooltipTime = 0f;

	// Token: 0x040061AB RID: 25003
	private float mNextRaycast;

	// Token: 0x040061AC RID: 25004
	public static bool isDragging = false;

	// Token: 0x040061AD RID: 25005
	private static int mLastInteractionCheck = -1;

	// Token: 0x040061AE RID: 25006
	private static bool mLastInteractionResult = false;

	// Token: 0x040061AF RID: 25007
	private static int mLastFocusCheck = -1;

	// Token: 0x040061B0 RID: 25008
	private static bool mLastFocusResult = false;

	// Token: 0x040061B1 RID: 25009
	private static int mLastOverCheck = -1;

	// Token: 0x040061B2 RID: 25010
	private static bool mLastOverResult = false;

	// Token: 0x040061B3 RID: 25011
	private static GameObject mRayHitObject;

	// Token: 0x040061B4 RID: 25012
	public static GameObject mHover;

	// Token: 0x040061B5 RID: 25013
	private static GameObject mSelected;

	// Token: 0x040061B6 RID: 25014
	private static UICamera.DepthEntry mHit = default(UICamera.DepthEntry);

	// Token: 0x040061B7 RID: 25015
	private static BetterList<UICamera.DepthEntry> mHits = new BetterList<UICamera.DepthEntry>();

	// Token: 0x040061B8 RID: 25016
	private static RaycastHit[] mRayHits;

	// Token: 0x040061B9 RID: 25017
	private static Collider2D[] mOverlap;

	// Token: 0x040061BA RID: 25018
	private static Plane m2DPlane = new Plane(Vector3.back, 0f);

	// Token: 0x040061BB RID: 25019
	private static float mNextEvent = 0f;

	// Token: 0x040061BC RID: 25020
	private static int mNotifying = 0;

	// Token: 0x040061BD RID: 25021
	private static bool disableControllerCheck = true;

	// Token: 0x040061BE RID: 25022
	private static bool mUsingTouchEvents = true;

	// Token: 0x040061BF RID: 25023
	public static UICamera.GetTouchCountCallback GetInputTouchCount;

	// Token: 0x040061C0 RID: 25024
	public static UICamera.GetTouchCallback GetInputTouch;

	// Token: 0x02000F84 RID: 3972
	public enum ControlScheme
	{
		// Token: 0x040061C2 RID: 25026
		Mouse,
		// Token: 0x040061C3 RID: 25027
		Touch,
		// Token: 0x040061C4 RID: 25028
		Controller
	}

	// Token: 0x02000F85 RID: 3973
	public enum ClickNotification
	{
		// Token: 0x040061C6 RID: 25030
		None,
		// Token: 0x040061C7 RID: 25031
		Always,
		// Token: 0x040061C8 RID: 25032
		BasedOnDelta
	}

	// Token: 0x02000F86 RID: 3974
	public class MouseOrTouch
	{
		

		// Token: 0x040061C9 RID: 25033
		public KeyCode key;

		// Token: 0x040061CA RID: 25034
		public Vector2 pos;

		// Token: 0x040061CB RID: 25035
		public Vector2 lastPos;

		// Token: 0x040061CC RID: 25036
		public Vector2 delta;

		// Token: 0x040061CD RID: 25037
		public Vector2 totalDelta;

		// Token: 0x040061CE RID: 25038
		public Camera pressedCam;

		// Token: 0x040061CF RID: 25039
		public GameObject last;

		// Token: 0x040061D0 RID: 25040
		public GameObject current;

		// Token: 0x040061D1 RID: 25041
		public GameObject pressed;

		// Token: 0x040061D2 RID: 25042
		public GameObject dragged;

		// Token: 0x040061D3 RID: 25043
		public TouchPhase phase;

		// Token: 0x040061D4 RID: 25044
		public float pressTime;

		// Token: 0x040061D5 RID: 25045
		public float clickTime;

		// Token: 0x040061D6 RID: 25046
		public UICamera.ClickNotification clickNotification = UICamera.ClickNotification.Always;

		// Token: 0x040061D7 RID: 25047
		public bool touchBegan = true;

		// Token: 0x040061D8 RID: 25048
		public bool pressStarted;

		// Token: 0x040061D9 RID: 25049
		public bool dragStarted;

		// Token: 0x040061DA RID: 25050
		public int ignoreDelta;
	}

	// Token: 0x02000F87 RID: 3975
	public enum EventType
	{
		// Token: 0x040061DC RID: 25052
		World_3D,
		// Token: 0x040061DD RID: 25053
		UI_3D,
		// Token: 0x040061DE RID: 25054
		World_2D,
		// Token: 0x040061DF RID: 25055
		UI_2D
	}

	// Token: 0x02000F88 RID: 3976
	// (Invoke) Token: 0x06006416 RID: 25622
	public delegate bool GetKeyStateFunc(KeyCode key);

	// Token: 0x02000F89 RID: 3977
	// (Invoke) Token: 0x0600641A RID: 25626
	public delegate float GetAxisFunc(string name);

	// Token: 0x02000F8A RID: 3978
	// (Invoke) Token: 0x0600641E RID: 25630
	public delegate bool GetAnyKeyFunc();

	// Token: 0x02000F8B RID: 3979
	// (Invoke) Token: 0x06006422 RID: 25634
	public delegate UICamera.MouseOrTouch GetMouseDelegate(int button);

	// Token: 0x02000F8C RID: 3980
	// (Invoke) Token: 0x06006426 RID: 25638
	public delegate UICamera.MouseOrTouch GetTouchDelegate(int id, bool createIfMissing);

	// Token: 0x02000F8D RID: 3981
	// (Invoke) Token: 0x0600642A RID: 25642
	public delegate void RemoveTouchDelegate(int id);

	// Token: 0x02000F8E RID: 3982
	// (Invoke) Token: 0x0600642E RID: 25646
	public delegate void OnScreenResize();

	// Token: 0x02000F8F RID: 3983
	public enum ProcessEventsIn
	{
		// Token: 0x040061E1 RID: 25057
		Update,
		// Token: 0x040061E2 RID: 25058
		LateUpdate
	}

	// Token: 0x02000F90 RID: 3984
	// (Invoke) Token: 0x06006432 RID: 25650
	public delegate void OnCustomInput();

	// Token: 0x02000F91 RID: 3985
	// (Invoke) Token: 0x06006436 RID: 25654
	public delegate void OnSchemeChange();

	// Token: 0x02000F92 RID: 3986
	// (Invoke) Token: 0x0600643A RID: 25658
	public delegate void MoveDelegate(Vector2 delta);

	// Token: 0x02000F93 RID: 3987
	// (Invoke) Token: 0x0600643E RID: 25662
	public delegate void VoidDelegate(GameObject go);

	// Token: 0x02000F94 RID: 3988
	// (Invoke) Token: 0x06006442 RID: 25666
	public delegate void BoolDelegate(GameObject go, bool state);

	// Token: 0x02000F95 RID: 3989
	// (Invoke) Token: 0x06006446 RID: 25670
	public delegate void FloatDelegate(GameObject go, float delta);

	// Token: 0x02000F96 RID: 3990
	// (Invoke) Token: 0x0600644A RID: 25674
	public delegate void VectorDelegate(GameObject go, Vector2 delta);

	// Token: 0x02000F97 RID: 3991
	// (Invoke) Token: 0x0600644E RID: 25678
	public delegate void ObjectDelegate(GameObject go, GameObject obj);

	// Token: 0x02000F98 RID: 3992
	// (Invoke) Token: 0x06006452 RID: 25682
	public delegate void KeyCodeDelegate(GameObject go, KeyCode key);

	// Token: 0x02000F99 RID: 3993
	private struct DepthEntry
	{
		// Token: 0x040061E3 RID: 25059
		public int depth;

		// Token: 0x040061E4 RID: 25060
		public RaycastHit hit;

		// Token: 0x040061E5 RID: 25061
		public Vector3 point;

		// Token: 0x040061E6 RID: 25062
		public GameObject go;
	}

	// Token: 0x02000F9A RID: 3994
	public class Touch
	{
		// Token: 0x040061E7 RID: 25063
		public int fingerId;

		// Token: 0x040061E8 RID: 25064
		public TouchPhase phase;

		// Token: 0x040061E9 RID: 25065
		public Vector2 position;

		// Token: 0x040061EA RID: 25066
		public int tapCount;
	}

	// Token: 0x02000F9B RID: 3995
	// (Invoke) Token: 0x06006457 RID: 25687
	public delegate int GetTouchCountCallback();

	// Token: 0x02000F9C RID: 3996
	// (Invoke) Token: 0x0600645B RID: 25691
	public delegate UICamera.Touch GetTouchCallback(int index);
}
