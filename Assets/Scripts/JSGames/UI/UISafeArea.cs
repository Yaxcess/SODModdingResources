using System;
using UnityEngine;

namespace JSGames.UI
{
	// Token: 0x02001B4F RID: 6991
	public class UISafeArea : KAMonoBase
	{
		// Token: 0x14000265 RID: 613
		// (add) Token: 0x0600A50B RID: 42251 RVA: 0x0039C07C File Offset: 0x0039A27C
		// (remove) Token: 0x0600A50C RID: 42252 RVA: 0x0039C0B4 File Offset: 0x0039A2B4
		public event Action OnOrientationChanged;

		// Token: 0x14000266 RID: 614
		// (add) Token: 0x0600A50D RID: 42253 RVA: 0x0039C0EC File Offset: 0x0039A2EC
		// (remove) Token: 0x0600A50E RID: 42254 RVA: 0x0039C124 File Offset: 0x0039A324
		public event Action OnResolutionChanged;

		// Token: 0x0600A50F RID: 42255 RVA: 0x0039C15C File Offset: 0x0039A35C
		private void Awake()
		{
			float num = this._IgnoreThresholdFromEdges * (float)Screen.width;
			this.mForceSafeAreaRect = new Rect(new Vector2(num, 0f), new Vector2((float)Screen.width - num * 2f, (float)Screen.height));
			this.mCanvas = this.GetCanvas();
			this.mLastOrientation = Screen.orientation;
			this.mLastResolution.x = (float)Screen.width;
			this.mLastResolution.y = (float)Screen.height;
			if (this._SafeAreaTransform == null && base.transform.Find("SafeArea") != null)
			{
				this._SafeAreaTransform = base.transform.Find("SafeArea").GetComponent<RectTransform>();
			}
		}

		// Token: 0x0600A510 RID: 42256 RVA: 0x0039C220 File Offset: 0x0039A420
		private void Start()
		{
			if (this.mCanvas.renderMode != RenderMode.ScreenSpaceOverlay)
			{
				RenderMode renderMode = this.mCanvas.renderMode;
				this.mCanvas.renderMode = RenderMode.ScreenSpaceOverlay;
				this.ApplySafeArea(this.GetScreenSafeArea());
				this.mCanvas.renderMode = renderMode;
				return;
			}
			this.ApplySafeArea(this.GetScreenSafeArea());
		}

		// Token: 0x0600A511 RID: 42257 RVA: 0x0039C278 File Offset: 0x0039A478
		private void Update()
		{
			if (UtPlatform.IsMobile())
			{
				if (Screen.orientation != this.mLastOrientation)
				{
					this.OrientationChanged();
				}
				if (this.GetScreenSafeArea().size != this.mLastSafeArea)
				{
					this.ApplySafeArea(this.GetScreenSafeArea());
					return;
				}
			}
			else if ((float)Screen.width != this.mLastResolution.x || (float)Screen.height != this.mLastResolution.y)
			{
				this.ResolutionChanged();
			}
		}

		// Token: 0x0600A512 RID: 42258 RVA: 0x000672AC File Offset: 0x000654AC
		private Rect GetScreenSafeArea()
		{
			return Screen.safeArea;
		}

		// Token: 0x0600A513 RID: 42259 RVA: 0x0039C2F4 File Offset: 0x0039A4F4
		private void ApplySafeArea(Rect safeArea)
		{
			if (this._SafeAreaTransform == null || this.mCanvas == null)
			{
				return;
			}
			Vector2 position = safeArea.position;
			Vector2 anchorMax = safeArea.position + safeArea.size;
			position.x /= this.mCanvas.pixelRect.width;
			position.y /= this.mCanvas.pixelRect.height;
			anchorMax.x /= this.mCanvas.pixelRect.width;
			anchorMax.y /= this.mCanvas.pixelRect.height;
			this._SafeAreaTransform.anchorMin = position;
			this._SafeAreaTransform.anchorMax = anchorMax;
			if (!this._CanBottomCornerWidgetsMoveUp)
			{
				this.UpdateBottomCornerWidgetsPosition((this.mLastSafeAreaMin - safeArea.position).y / this.mCanvas.scaleFactor);
			}
			this.mLastSafeArea = safeArea.size;
			this.mLastSafeAreaMin = safeArea.position;
		}

		// Token: 0x0600A514 RID: 42260 RVA: 0x0039C418 File Offset: 0x0039A618
		private void UpdateBottomCornerWidgetsPosition(float offsetY)
		{
			foreach (object obj in this._SafeAreaTransform)
			{
				RectTransform rectTransform = (RectTransform)obj;
				this.UpdateBottomCornerWidgetsPosition(rectTransform, offsetY);
			}
		}

		// Token: 0x0600A515 RID: 42261 RVA: 0x0039C474 File Offset: 0x0039A674
		private void UpdateBottomCornerWidgetsPosition(RectTransform rectTransform, float offsetY)
		{
			if (rectTransform.anchorMin.y == 0f && rectTransform.anchorMin.x == rectTransform.anchorMax.x && (rectTransform.anchorMin.x == 1f || rectTransform.anchorMin.x == 0f))
			{
				if (this.RectTransformToScreenSpace(rectTransform).Overlaps(this.mForceSafeAreaRect))
				{
					return;
				}
				Vector2 anchoredPosition = rectTransform.anchoredPosition;
				anchoredPosition.y += offsetY;
				rectTransform.anchoredPosition = anchoredPosition;
			}
		}

		// Token: 0x0600A516 RID: 42262 RVA: 0x0039C504 File Offset: 0x0039A704
		public Rect RectTransformToScreenSpace(RectTransform transform)
		{
			Vector2 vector = Vector2.Scale(transform.rect.size, transform.lossyScale);
			Rect result = new Rect(transform.position.x, transform.position.y, vector.x, vector.y);
			result.x -= transform.pivot.x * vector.x;
			result.y -= transform.pivot.y * vector.y;
			return result;
		}

		// Token: 0x0600A517 RID: 42263 RVA: 0x0039C59C File Offset: 0x0039A79C
		private void OrientationChanged()
		{
			this.mLastOrientation = Screen.orientation;
			this.mLastResolution.x = (float)Screen.width;
			this.mLastResolution.y = (float)Screen.height;
			if (this.OnOrientationChanged != null)
			{
				this.OnOrientationChanged();
			}
		}

		// Token: 0x0600A518 RID: 42264 RVA: 0x000672B3 File Offset: 0x000654B3
		private void ResolutionChanged()
		{
			this.mLastResolution.x = (float)Screen.width;
			this.mLastResolution.y = (float)Screen.height;
			if (this.OnResolutionChanged != null)
			{
				this.OnResolutionChanged();
			}
		}

		// Token: 0x0600A519 RID: 42265 RVA: 0x0039C5EC File Offset: 0x0039A7EC
		private Canvas GetCanvas()
		{
			Canvas component = base.GetComponent<Canvas>();
			if (component == null && base.transform.root != null)
			{
				component = base.transform.root.GetComponent<Canvas>();
			}
			return component;
		}

		// Token: 0x0400A85C RID: 43100
		[Header("Bottom-Corner Anchored Object Configuration")]
		public bool _CanBottomCornerWidgetsMoveUp;

		// Token: 0x0400A85D RID: 43101
		public float _IgnoreThresholdFromEdges = 0.2f;

		// Token: 0x0400A85E RID: 43102
		[Space]
		public RectTransform _SafeAreaTransform;

		// Token: 0x0400A861 RID: 43105
		private ScreenOrientation mLastOrientation = ScreenOrientation.LandscapeLeft;

		// Token: 0x0400A862 RID: 43106
		private Vector2 mLastResolution = Vector2.zero;

		// Token: 0x0400A863 RID: 43107
		private Vector2 mLastSafeArea = Vector2.zero;

		// Token: 0x0400A864 RID: 43108
		private Canvas mCanvas;

		// Token: 0x0400A865 RID: 43109
		private Vector2 mLastSafeAreaMin = Vector2.zero;

		// Token: 0x0400A866 RID: 43110
		private Rect mForceSafeAreaRect;
	}
}
