using System;
using System.Collections.Generic;
using UnityEngine;

namespace JSGames.UI.MultiResolution
{
	// Token: 0x02001B66 RID: 7014
	[Serializable]
	public class UILayout
	{
		// Token: 0x0600A5DB RID: 42459 RVA: 0x00067B18 File Offset: 0x00065D18
		public UILayout(string layoutName, Transform uiTransform, UILayout defaultLayout)
		{
			this.LayoutName = layoutName;
			this.DefaultLayoutReference = defaultLayout;
			this.FindGameObjects(uiTransform, "");
		}

		// Token: 0x0600A5DC RID: 42460 RVA: 0x0039F420 File Offset: 0x0039D620
		private void FindGameObjects(Transform trans, string hierarchy)
		{
			UIGameObject defaultLayoutObj = this.GetDefaultLayoutObj(hierarchy);
			UIGameObject uigameObject = new UIGameObject(trans, hierarchy, defaultLayoutObj);
			if (uigameObject != null && uigameObject.ComponentsJson.Count > 0)
			{
				this.GameObjects.Add(uigameObject);
			}
			for (int i = 0; i < trans.childCount; i++)
			{
				Transform child = trans.GetChild(i);
				string hierarchy2 = string.IsNullOrEmpty(hierarchy) ? child.name : (hierarchy + "/" + child.name);
				this.FindGameObjects(child, hierarchy2);
			}
		}

		// Token: 0x0600A5DD RID: 42461 RVA: 0x0039F4A0 File Offset: 0x0039D6A0
		private UIGameObject GetDefaultLayoutObj(string hierarchy)
		{
			if (this.DefaultLayoutReference == null)
			{
				return null;
			}
			foreach (UIGameObject uigameObject in this.DefaultLayoutReference.GameObjects)
			{
				if (uigameObject.Hierarchy == hierarchy)
				{
					return uigameObject;
				}
			}
			return null;
		}

		// Token: 0x0400A8E5 RID: 43237
		public string LayoutName;

		// Token: 0x0400A8E6 RID: 43238
		public List<UIGameObject> GameObjects = new List<UIGameObject>();

		// Token: 0x0400A8E7 RID: 43239
		public UILayout DefaultLayoutReference;
	}
}
