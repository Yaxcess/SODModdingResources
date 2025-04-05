using System;
using System.Collections.Generic;
using JSGames.UI.MultiResolution;
using UnityEngine;
using UnityEngine.UI;

namespace JSGames.UI
{
	// Token: 0x02001B19 RID: 6937
	public class UIMultiResolution : MonoBehaviour
	{
		// Token: 0x0600A355 RID: 41813 RVA: 0x00065F95 File Offset: 0x00064195
		protected void Awake()
		{
			this.UpdateUi();
		}

		// Token: 0x0600A356 RID: 41814 RVA: 0x00396F78 File Offset: 0x00395178
		private void UpdateUi()
		{
			string deviceName = SystemInfo.deviceName;
			if (!this.UpdateUiForDevice(deviceName))
			{
				this.UpdateUiForResolution((float)Screen.width, (float)Screen.height);
			}
		}

		// Token: 0x0600A357 RID: 41815 RVA: 0x00396FA8 File Offset: 0x003951A8
		private bool UpdateUiForDevice(string deviceName)
		{
			foreach (UIMultiResolution.DeviceConfiguration deviceConfiguration in this._DeviceConfigs)
			{
				if (deviceConfiguration._DeviceName == deviceName)
				{
					this.UpdateUiForConfig(deviceConfiguration._Config);
					return true;
				}
			}
			return false;
		}

		// Token: 0x0600A358 RID: 41816 RVA: 0x00397018 File Offset: 0x00395218
		private void UpdateUiForResolution(float screenWidth, float screenHeight)
		{
			float aspectRatio = screenWidth / screenHeight;
			this.UpdateUiForAspectRatio(aspectRatio);
		}

		// Token: 0x0600A359 RID: 41817 RVA: 0x00397030 File Offset: 0x00395230
		private void UpdateUiForAspectRatio(float aspectRatio)
		{
			foreach (UIMultiResolution.AspectRatioConfiguration aspectRatioConfiguration in this._AspectRatioConfig)
			{
				if (aspectRatio >= aspectRatioConfiguration._MinAspectRatio && aspectRatio <= aspectRatioConfiguration._MaxAspectRatio)
				{
					this.UpdateUiForConfig(aspectRatioConfiguration._Config);
					break;
				}
			}
		}

		// Token: 0x0600A35A RID: 41818 RVA: 0x0039709C File Offset: 0x0039529C
		private void UpdateUiForConfig(TextAsset configuration)
		{
			foreach (UIGameObject uigameObject in JsonUtility.FromJson<UILayout>(configuration.text).GameObjects)
			{
				Transform transform = base.transform;
				if (!string.IsNullOrEmpty(uigameObject.Hierarchy))
				{
					transform = base.transform.Find(uigameObject.Hierarchy);
				}
				if (transform == null)
				{
					Debug.LogWarning("Couldn't find the game object " + uigameObject.Hierarchy + "  in the gameobject " + base.transform.name);
				}
				else
				{
					foreach (string compJson in uigameObject.ComponentsJson)
					{
						this.UpdateComponent(transform, compJson);
					}
				}
			}
		}

		// Token: 0x0600A35B RID: 41819 RVA: 0x00397194 File Offset: 0x00395394
		private void UpdateComponent(Transform trans, string compJson)
		{
			string type = JsonUtility.FromJson<UIComponent>(compJson).Type;
			if (type == "Canvas")
			{
				this.UpdateCanvasCompConfig(trans, compJson);
				return;
			}
			if (type == "CanvasScaler")
			{
				this.UpdateCanvasScalerConfig(trans, compJson);
				return;
			}
			if (type == "RectTransform")
			{
				this.UpdateRectTransformConfig(trans, compJson);
				return;
			}
			if (type == "Text")
			{
				this.UpdateText(trans, compJson);
				return;
			}
			if (!(type == "GridLayoutGroup"))
			{
				return;
			}
			this.UpdateGridLayoutGroup(trans, compJson);
		}

		// Token: 0x0600A35C RID: 41820 RVA: 0x0039721C File Offset: 0x0039541C
		private void UpdateCanvasCompConfig(Transform trans, string canvasJson)
		{
			CanvasComp canvasComp = JsonUtility.FromJson<CanvasComp>(canvasJson);
			Canvas component = trans.GetComponent<Canvas>();
			component.pixelPerfect = canvasComp.PixelPerfect;
			component.overridePixelPerfect = canvasComp.OverridePixelPerfect;
			if (component.overridePixelPerfect)
			{
				component.renderMode = canvasComp.RenderMode;
			}
			component.sortingOrder = canvasComp.SortOrder;
		}

		// Token: 0x0600A35D RID: 41821 RVA: 0x00397270 File Offset: 0x00395470
		private void UpdateCanvasScalerConfig(Transform trans, string scalerJson)
		{
			CanvasScalerComp canvasScalerComp = JsonUtility.FromJson<CanvasScalerComp>(scalerJson);
			CanvasScaler component = trans.GetComponent<CanvasScaler>();
			component.referenceResolution = canvasScalerComp.ScalerResolution;
			component.uiScaleMode = canvasScalerComp.UIScaleMode;
			component.screenMatchMode = canvasScalerComp.ScreenMatchMode;
		}

		// Token: 0x0600A35E RID: 41822 RVA: 0x003972B0 File Offset: 0x003954B0
		private void UpdateRectTransformConfig(Transform trans, string rectJson)
		{
			RectTransformComp rectTransformComp = JsonUtility.FromJson<RectTransformComp>(rectJson);
			RectTransform component = trans.GetComponent<RectTransform>();
			component.anchoredPosition = rectTransformComp.AnchoredPosition;
			component.anchorMax = rectTransformComp.AnchorMax;
			component.anchorMin = rectTransformComp.AnchorMin;
			component.sizeDelta = rectTransformComp.SizeDelta;
			component.pivot = rectTransformComp.Pivot;
			component.rotation = rectTransformComp.Rotation;
			component.localScale = rectTransformComp.Scale;
		}

		// Token: 0x0600A35F RID: 41823 RVA: 0x00397328 File Offset: 0x00395528
		private void UpdateText(Transform trans, string textJson)
		{
			TextComp textComp = JsonUtility.FromJson<TextComp>(textJson);
			Text component = trans.GetComponent<Text>();
			component.fontSize = textComp.FontSize;
			component.lineSpacing = textComp.LineSpacing;
			component.supportRichText = textComp.RichText;
			component.alignment = textComp.Alignment;
			component.resizeTextForBestFit = textComp.BestFit;
			component.resizeTextMaxSize = textComp.BestFitMax;
			component.resizeTextMinSize = textComp.BestFitMin;
			component.alignByGeometry = textComp.AlignByGeometry;
			component.horizontalOverflow = textComp.HorizontalWrapMode;
			component.verticalOverflow = textComp.VerticalWrapMode;
		}

		// Token: 0x0600A360 RID: 41824 RVA: 0x003973BC File Offset: 0x003955BC
		private void UpdateGridLayoutGroup(Transform trans, string gridLayoutJson)
		{
			GridLayoutGroupComp gridLayoutGroupComp = JsonUtility.FromJson<GridLayoutGroupComp>(gridLayoutJson);
			GridLayoutGroup component = trans.GetComponent<GridLayoutGroup>();
			component.padding = gridLayoutGroupComp.Padding;
			component.cellSize = gridLayoutGroupComp.CellSize;
			component.spacing = gridLayoutGroupComp.Spacing;
		}

		// Token: 0x0400A725 RID: 42789
		public List<UIMultiResolution.DeviceConfiguration> _DeviceConfigs = new List<UIMultiResolution.DeviceConfiguration>();

		// Token: 0x0400A726 RID: 42790
		public List<UIMultiResolution.AspectRatioConfiguration> _AspectRatioConfig = new List<UIMultiResolution.AspectRatioConfiguration>();

		// Token: 0x02001B1A RID: 6938
		[Serializable]
		public class DeviceConfiguration
		{
			// Token: 0x0400A727 RID: 42791
			public string _DeviceName;

			// Token: 0x0400A728 RID: 42792
			public TextAsset _Config;
		}

		// Token: 0x02001B1B RID: 6939
		[Serializable]
		public class AspectRatioConfiguration
		{
			// Token: 0x0400A729 RID: 42793
			public float _MinAspectRatio;

			// Token: 0x0400A72A RID: 42794
			public float _MaxAspectRatio;

			// Token: 0x0400A72B RID: 42795
			public TextAsset _Config;
		}
	}
}
