using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace JSGames.UI
{
	// Token: 0x02001B2B RID: 6955
	public abstract class UIBase : MonoBehaviour
	{
		// Token: 0x170010A6 RID: 4262
		// (get) Token: 0x0600A3F1 RID: 41969 RVA: 0x000664D7 File Offset: 0x000646D7
		// (set) Token: 0x0600A3F2 RID: 41970 RVA: 0x000664DF File Offset: 0x000646DF
		public RectTransform pRectTransform { get; protected set; }

		// Token: 0x170010A7 RID: 4263
		// (get) Token: 0x0600A3F3 RID: 41971 RVA: 0x000664E8 File Offset: 0x000646E8
		// (set) Token: 0x0600A3F4 RID: 41972 RVA: 0x000664F5 File Offset: 0x000646F5
		public Vector3 pLocalPosition
		{
			get
			{
				return this.pRectTransform.localPosition;
			}
			set
			{
				this.pRectTransform.localPosition = value;
			}
		}

		// Token: 0x170010A8 RID: 4264
		// (get) Token: 0x0600A3F5 RID: 41973 RVA: 0x00066503 File Offset: 0x00064703
		// (set) Token: 0x0600A3F6 RID: 41974 RVA: 0x00066515 File Offset: 0x00064715
		public Vector3 pAnchoredPosition
		{
			get
			{
				return this.pRectTransform.anchoredPosition;
			}
			set
			{
				this.pRectTransform.anchoredPosition = value;
			}
		}

		// Token: 0x170010A9 RID: 4265
		// (get) Token: 0x0600A3F7 RID: 41975 RVA: 0x00066528 File Offset: 0x00064728
		// (set) Token: 0x0600A3F8 RID: 41976 RVA: 0x00066535 File Offset: 0x00064735
		public Vector3 pPosition
		{
			get
			{
				return this.pRectTransform.position;
			}
			set
			{
				this.pRectTransform.position = value;
			}
		}

		// Token: 0x170010AA RID: 4266
		// (get) Token: 0x0600A3F9 RID: 41977 RVA: 0x00066543 File Offset: 0x00064743
		// (set) Token: 0x0600A3FA RID: 41978 RVA: 0x00066550 File Offset: 0x00064750
		public Vector3 pLocalScale
		{
			get
			{
				return this.pRectTransform.localScale;
			}
			set
			{
				this.pRectTransform.localScale = value;
			}
		}

		// Token: 0x170010AB RID: 4267
		// (get) Token: 0x0600A3FB RID: 41979 RVA: 0x0006655E File Offset: 0x0006475E
		// (set) Token: 0x0600A3FC RID: 41980 RVA: 0x0006656B File Offset: 0x0006476B
		public Vector2 pSize
		{
			get
			{
				return this.pRectTransform.sizeDelta;
			}
			set
			{
				this.pRectTransform.sizeDelta = value;
			}
		}

		// Token: 0x170010AC RID: 4268
		// (get) Token: 0x0600A3FD RID: 41981 RVA: 0x00066579 File Offset: 0x00064779
		// (set) Token: 0x0600A3FE RID: 41982 RVA: 0x00066581 File Offset: 0x00064781
		public UIEvents pEventTarget { get; set; }

		// Token: 0x170010AD RID: 4269
		// (get) Token: 0x0600A3FF RID: 41983 RVA: 0x0006658A File Offset: 0x0006478A
		// (set) Token: 0x0600A400 RID: 41984 RVA: 0x00066592 File Offset: 0x00064792
		public UI pParentUI { get; protected set; }

		// Token: 0x170010AE RID: 4270
		// (get) Token: 0x0600A401 RID: 41985 RVA: 0x0006659B File Offset: 0x0006479B
		public List<UIWidget> pChildWidgets
		{
			get
			{
				return this.mChildWidgets;
			}
		}

		// Token: 0x170010AF RID: 4271
		// (get) Token: 0x0600A402 RID: 41986 RVA: 0x000665A3 File Offset: 0x000647A3
		public bool pInteractable
		{
			get
			{
				return this.mState == WidgetState.INTERACTIVE && this.mVisible;
			}
		}

		// Token: 0x170010B0 RID: 4272
		// (get) Token: 0x0600A403 RID: 41987 RVA: 0x000665B6 File Offset: 0x000647B6
		public bool pInteractableInHierarchy
		{
			get
			{
				return this.mStateInHierarchy == WidgetState.INTERACTIVE && this.mVisibleInHierarchy;
			}
		}

		// Token: 0x170010B1 RID: 4273
		// (get) Token: 0x0600A404 RID: 41988 RVA: 0x000665C9 File Offset: 0x000647C9
		public bool pVisibleInHierarchy
		{
			get
			{
				return this.mVisibleInHierarchy;
			}
		}

		// Token: 0x170010B2 RID: 4274
		// (get) Token: 0x0600A405 RID: 41989 RVA: 0x000665D1 File Offset: 0x000647D1
		public WidgetState pStateInHierarchy
		{
			get
			{
				return this.mStateInHierarchy;
			}
		}

		// Token: 0x170010B3 RID: 4275
		// (get) Token: 0x0600A406 RID: 41990 RVA: 0x000665D9 File Offset: 0x000647D9
		// (set) Token: 0x0600A407 RID: 41991 RVA: 0x000665E1 File Offset: 0x000647E1
		public virtual bool pVisible
		{
			get
			{
				return this.mVisible;
			}
			set
			{
				this._Visible = value;
				if (this.mVisible != value)
				{
					this.mVisible = value;
					this.UpdateVisibleInHierarchy();
					this.OnVisibleChanged(this.mVisible);
				}
			}
		}

		// Token: 0x170010B4 RID: 4276
		// (get) Token: 0x0600A408 RID: 41992 RVA: 0x0006660C File Offset: 0x0006480C
		// (set) Token: 0x0600A409 RID: 41993 RVA: 0x003995E0 File Offset: 0x003977E0
		public virtual WidgetState pState
		{
			get
			{
				return this.mState;
			}
			set
			{
				this._State = value;
				if (this.mState != value)
				{
					WidgetState previousState = this.mState;
					this.mState = value;
					this.OnStateChanged(previousState, this.mState);
					this.UpdateStateInHierarchy();
				}
			}
		}

		// Token: 0x0600A40A RID: 41994 RVA: 0x00066614 File Offset: 0x00064814
		public void OnParentSetVisible(bool parentVisible)
		{
			if (this.mParentVisible != parentVisible)
			{
				this.mParentVisible = parentVisible;
				this.UpdateVisibleInHierarchy();
			}
		}

		// Token: 0x0600A40B RID: 41995 RVA: 0x0006662C File Offset: 0x0006482C
		public void OnParentSetState(WidgetState parentState)
		{
			if (this.mParentState != parentState)
			{
				this.mParentState = parentState;
				this.UpdateStateInHierarchy();
			}
		}

		// Token: 0x0600A40C RID: 41996 RVA: 0x00066644 File Offset: 0x00064844
		public Vector2 GetScreenPosition()
		{
			return this.pPosition;
		}

		// Token: 0x0600A40D RID: 41997 RVA: 0x00399620 File Offset: 0x00397820
		public UIWidget FindWidget(string widgetName, bool recursive = true)
		{
			foreach (UIWidget uiwidget in this.mChildWidgets)
			{
				if (uiwidget.name == widgetName)
				{
					return uiwidget;
				}
				if (recursive)
				{
					UIWidget uiwidget2 = uiwidget.FindWidget(widgetName, recursive);
					if (uiwidget2 != null)
					{
						return uiwidget2;
					}
				}
			}
			return null;
		}

		// Token: 0x0600A40E RID: 41998 RVA: 0x00066651 File Offset: 0x00064851
		public int FindWidgetIndex(UIWidget widget)
		{
			return this.pChildWidgets.IndexOf(widget);
		}

		// Token: 0x0600A40F RID: 41999 RVA: 0x0006665F File Offset: 0x0006485F
		public UIWidget GetWidgetAt(int index)
		{
			if (index < this.pChildWidgets.Count)
			{
				return this.pChildWidgets[index];
			}
			return null;
		}

		// Token: 0x0600A410 RID: 42000 RVA: 0x0039969C File Offset: 0x0039789C
		protected UIBase.GraphicState FindGraphicState(Graphic graphic)
		{
			return this.mGraphicsStates.Find((UIBase.GraphicState x) => x.pGraphic == graphic);
		}

		// Token: 0x0600A411 RID: 42001 RVA: 0x00006173 File Offset: 0x00004373
		protected virtual void OnStateChanged(WidgetState previousState, WidgetState newState)
		{
		}

		// Token: 0x0600A412 RID: 42002 RVA: 0x00006173 File Offset: 0x00004373
		protected virtual void OnVisibleChanged(bool newVisible)
		{
		}

		// Token: 0x0600A413 RID: 42003 RVA: 0x00006173 File Offset: 0x00004373
		protected virtual void OnVisibleInHierarchyChanged(bool newVisibleInHierarchy)
		{
		}

		// Token: 0x0600A414 RID: 42004 RVA: 0x00006173 File Offset: 0x00004373
		protected virtual void OnStateInHierarchyChanged(WidgetState previousStateInHierarchy, WidgetState newStateInHierarchy)
		{
		}

		// Token: 0x0600A415 RID: 42005 RVA: 0x003996D0 File Offset: 0x003978D0
		protected virtual void UpdateVisibleInHierarchy()
		{
			bool flag = this.mVisibleInHierarchy;
			this.mVisibleInHierarchy = (this.mParentVisible ? this.mVisible : this.mParentVisible);
			if (flag != this.mVisibleInHierarchy)
			{
				foreach (UIWidget uiwidget in this.mChildWidgets)
				{
					uiwidget.OnParentSetVisible(this.mVisibleInHierarchy);
				}
				this.OnVisibleInHierarchyChanged(this.mVisibleInHierarchy);
			}
		}

		// Token: 0x0600A416 RID: 42006 RVA: 0x0039975C File Offset: 0x0039795C
		protected virtual void UpdateStateInHierarchy()
		{
			WidgetState widgetState = this.mStateInHierarchy;
			this.mStateInHierarchy = ((this.mState < this.mParentState) ? this.mState : this.mParentState);
			if (widgetState != this.mStateInHierarchy)
			{
				foreach (UIWidget uiwidget in this.mChildWidgets)
				{
					uiwidget.OnParentSetState(this.mStateInHierarchy);
				}
				this.OnStateInHierarchyChanged(widgetState, this.mStateInHierarchy);
			}
		}

		// Token: 0x0600A417 RID: 42007 RVA: 0x0006667D File Offset: 0x0006487D
		protected virtual void Start()
		{
			this.SetParamsFromPublicVariables();
		}

		// Token: 0x0600A418 RID: 42008 RVA: 0x00006173 File Offset: 0x00004373
		protected virtual void Update()
		{
		}

		// Token: 0x0600A419 RID: 42009 RVA: 0x00066685 File Offset: 0x00064885
		protected virtual void SetParamsFromPublicVariables()
		{
			if (this._State != this.pState)
			{
				this.pState = this._State;
			}
			if (this._Visible != this.pVisible)
			{
				this.pVisible = this._Visible;
			}
		}

		// Token: 0x0600A41A RID: 42010 RVA: 0x003997F4 File Offset: 0x003979F4
		protected virtual void UpdateUnityComponents()
		{
			if (!this.mVisibleInHierarchy)
			{
				foreach (UIBase.GraphicState graphicState in this.mGraphicsStates)
				{
					if (graphicState != null && graphicState.pGraphic != null)
					{
						if (!this.mGraphicsStatesCached)
						{
							graphicState.pOriginallyEnabled = graphicState.pGraphic.enabled;
						}
						graphicState.pGraphic.enabled = false;
					}
				}
				this.mGraphicsStatesCached = true;
				return;
			}
			if (this.mVisibleInHierarchy && this.mGraphicsStatesCached)
			{
				foreach (UIBase.GraphicState graphicState2 in this.mGraphicsStates)
				{
					if (graphicState2 != null && graphicState2.pGraphic != null)
					{
						graphicState2.pGraphic.enabled = graphicState2.pOriginallyEnabled;
					}
				}
				this.mGraphicsStatesCached = false;
			}
		}

		// Token: 0x0400A799 RID: 42905
		[Tooltip("This is the transform on which all child elements are parented to")]
		public RectTransform _ProxyTransform;

		// Token: 0x0400A79A RID: 42906
		[SerializeField]
		protected bool _Visible = true;

		// Token: 0x0400A79B RID: 42907
		[SerializeField]
		protected WidgetState _State = WidgetState.INTERACTIVE;

		// Token: 0x0400A79C RID: 42908
		protected List<UIWidget> mChildWidgets = new List<UIWidget>();

		// Token: 0x0400A79D RID: 42909
		protected List<UIBase.GraphicState> mGraphicsStates = new List<UIBase.GraphicState>();

		// Token: 0x0400A79E RID: 42910
		protected bool mGraphicsStatesCached;

		// Token: 0x0400A79F RID: 42911
		protected bool mParentVisible = true;

		// Token: 0x0400A7A0 RID: 42912
		protected WidgetState mParentState = WidgetState.INTERACTIVE;

		// Token: 0x0400A7A1 RID: 42913
		protected bool mVisible = true;

		// Token: 0x0400A7A2 RID: 42914
		protected WidgetState mState = WidgetState.INTERACTIVE;

		// Token: 0x0400A7A3 RID: 42915
		protected bool mVisibleInHierarchy = true;

		// Token: 0x0400A7A4 RID: 42916
		protected WidgetState mStateInHierarchy = WidgetState.INTERACTIVE;

		// Token: 0x02001B2C RID: 6956
		[Serializable]
		public class GraphicState
		{
			// Token: 0x170010B5 RID: 4277
			// (get) Token: 0x0600A41C RID: 42012 RVA: 0x000666BB File Offset: 0x000648BB
			// (set) Token: 0x0600A41D RID: 42013 RVA: 0x000666C3 File Offset: 0x000648C3
			public Graphic pGraphic { get; private set; }

			// Token: 0x170010B6 RID: 4278
			// (get) Token: 0x0600A41E RID: 42014 RVA: 0x000666CC File Offset: 0x000648CC
			// (set) Token: 0x0600A41F RID: 42015 RVA: 0x000666D4 File Offset: 0x000648D4
			public bool pOriginallyEnabled { get; set; }

			// Token: 0x170010B7 RID: 4279
			// (get) Token: 0x0600A420 RID: 42016 RVA: 0x000666DD File Offset: 0x000648DD
			// (set) Token: 0x0600A421 RID: 42017 RVA: 0x000666E5 File Offset: 0x000648E5
			public Vector3 pOriginalPosition { get; set; }

			// Token: 0x170010B8 RID: 4280
			// (get) Token: 0x0600A422 RID: 42018 RVA: 0x000666EE File Offset: 0x000648EE
			// (set) Token: 0x0600A423 RID: 42019 RVA: 0x000666F6 File Offset: 0x000648F6
			public Color pOriginalColor { get; set; }

			// Token: 0x170010B9 RID: 4281
			// (get) Token: 0x0600A424 RID: 42020 RVA: 0x000666FF File Offset: 0x000648FF
			// (set) Token: 0x0600A425 RID: 42021 RVA: 0x00066707 File Offset: 0x00064907
			public Vector3 pOriginalScale { get; set; }

			// Token: 0x170010BA RID: 4282
			// (get) Token: 0x0600A426 RID: 42022 RVA: 0x00066710 File Offset: 0x00064910
			// (set) Token: 0x0600A427 RID: 42023 RVA: 0x00066718 File Offset: 0x00064918
			public Sprite pOriginalSprite { get; set; }

			// Token: 0x170010BB RID: 4283
			// (get) Token: 0x0600A428 RID: 42024 RVA: 0x00066721 File Offset: 0x00064921
			// (set) Token: 0x0600A429 RID: 42025 RVA: 0x00066729 File Offset: 0x00064929
			public Vector3 pOriginalRotation { get; set; }

			// Token: 0x0600A42A RID: 42026 RVA: 0x00066732 File Offset: 0x00064932
			public GraphicState(Graphic graphic)
			{
				this.pGraphic = graphic;
			}
		}
	}
}
