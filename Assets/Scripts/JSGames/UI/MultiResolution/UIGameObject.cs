using System;
using System.Collections.Generic;
using UnityEngine;

namespace JSGames.UI.MultiResolution
{
	// Token: 0x02001B65 RID: 7013
	[Serializable]
	public class UIGameObject
	{
		// Token: 0x0600A5D3 RID: 42451 RVA: 0x0039F130 File Offset: 0x0039D330
		public UIGameObject(Transform trans, string hierarchy, UIGameObject defaultLayoutObj)
		{
			this.Name = trans.name;
			this.Hierarchy = hierarchy;
			this.DefaultLayoutObjReference = defaultLayoutObj;
			foreach (Component comp in trans.GetComponents(typeof(Component)))
			{
				string componentJson = this.GetComponentJson(comp);
				if (!string.IsNullOrEmpty(componentJson))
				{
					this.ComponentsJson.Add(componentJson);
				}
			}
		}

		// Token: 0x0600A5D4 RID: 42452 RVA: 0x0039F1A8 File Offset: 0x0039D3A8
		private string GetComponentJson(Component comp)
		{
			string name = comp.GetType().Name;
			string result = "";
			if (!(name == "Canvas"))
			{
				if (!(name == "CanvasScaler"))
				{
					if (!(name == "RectTransform"))
					{
						if (!(name == "Text"))
						{
							if (name == "GridLayoutGroup")
							{
								result = this.GetGridLayoutGroupComp(comp);
							}
						}
						else
						{
							result = this.GetTextComp(comp);
						}
					}
					else
					{
						result = this.GetRectTransformComp(comp);
					}
				}
				else
				{
					result = this.GetCanvasScalerComp(comp);
				}
			}
			else
			{
				result = this.GetCanvasComp(comp);
			}
			return result;
		}

		// Token: 0x0600A5D5 RID: 42453 RVA: 0x0039F23C File Offset: 0x0039D43C
		private string GetCanvasComp(Component comp)
		{
			CanvasComp canvasComp = new CanvasComp(comp);
			string defaultLayoutComp = this.GetDefaultLayoutComp("Canvas");
			if (!string.IsNullOrEmpty(defaultLayoutComp))
			{
				CanvasComp canvasComp2 = JsonUtility.FromJson<CanvasComp>(defaultLayoutComp);
				if (canvasComp.Equals(canvasComp2))
				{
					return "";
				}
			}
			return JsonUtility.ToJson(canvasComp);
		}

		// Token: 0x0600A5D6 RID: 42454 RVA: 0x0039F280 File Offset: 0x0039D480
		private string GetCanvasScalerComp(Component comp)
		{
			CanvasScalerComp canvasScalerComp = new CanvasScalerComp(comp);
			string defaultLayoutComp = this.GetDefaultLayoutComp("CanvasScaler");
			if (!string.IsNullOrEmpty(defaultLayoutComp))
			{
				CanvasScalerComp canvasScalerComp2 = JsonUtility.FromJson<CanvasScalerComp>(defaultLayoutComp);
				if (canvasScalerComp.Equals(canvasScalerComp2))
				{
					return "";
				}
			}
			return JsonUtility.ToJson(canvasScalerComp);
		}

		// Token: 0x0600A5D7 RID: 42455 RVA: 0x0039F2C4 File Offset: 0x0039D4C4
		private string GetRectTransformComp(Component comp)
		{
			RectTransformComp rectTransformComp = new RectTransformComp(comp);
			string defaultLayoutComp = this.GetDefaultLayoutComp("RectTransform");
			if (!string.IsNullOrEmpty(defaultLayoutComp))
			{
				RectTransformComp rectTransformComp2 = JsonUtility.FromJson<RectTransformComp>(defaultLayoutComp);
				if (rectTransformComp.Equals(rectTransformComp2))
				{
					return "";
				}
			}
			return JsonUtility.ToJson(rectTransformComp);
		}

		// Token: 0x0600A5D8 RID: 42456 RVA: 0x0039F308 File Offset: 0x0039D508
		private string GetTextComp(Component comp)
		{
			TextComp textComp = new TextComp(comp);
			string defaultLayoutComp = this.GetDefaultLayoutComp("Text");
			if (!string.IsNullOrEmpty(defaultLayoutComp))
			{
				TextComp textComp2 = JsonUtility.FromJson<TextComp>(defaultLayoutComp);
				if (textComp.Equals(textComp2))
				{
					return "";
				}
			}
			return JsonUtility.ToJson(textComp);
		}

		// Token: 0x0600A5D9 RID: 42457 RVA: 0x0039F34C File Offset: 0x0039D54C
		private string GetGridLayoutGroupComp(Component comp)
		{
			GridLayoutGroupComp gridLayoutGroupComp = new GridLayoutGroupComp(comp);
			string defaultLayoutComp = this.GetDefaultLayoutComp("GridLayoutGroup");
			if (!string.IsNullOrEmpty(defaultLayoutComp))
			{
				GridLayoutGroupComp gridLayoutGroupComp2 = JsonUtility.FromJson<GridLayoutGroupComp>(defaultLayoutComp);
				if (gridLayoutGroupComp.Equals(gridLayoutGroupComp2))
				{
					return "";
				}
			}
			return JsonUtility.ToJson(gridLayoutGroupComp);
		}

		// Token: 0x0600A5DA RID: 42458 RVA: 0x0039F390 File Offset: 0x0039D590
		private string GetDefaultLayoutComp(string compType)
		{
			if (this.DefaultLayoutObjReference == null)
			{
				return "";
			}
			foreach (string text in this.DefaultLayoutObjReference.ComponentsJson)
			{
				if (string.IsNullOrEmpty(text))
				{
					return "";
				}
				if (JsonUtility.FromJson<UIComponent>(text).Type == compType)
				{
					return text;
				}
			}
			return "";
		}

		// Token: 0x0400A8E1 RID: 43233
		public string Name;

		// Token: 0x0400A8E2 RID: 43234
		public string Hierarchy;

		// Token: 0x0400A8E3 RID: 43235
		public List<string> ComponentsJson = new List<string>();

		// Token: 0x0400A8E4 RID: 43236
		private UIGameObject DefaultLayoutObjReference;
	}
}
