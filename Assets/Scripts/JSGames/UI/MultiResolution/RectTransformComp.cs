using System;
using UnityEngine;

namespace JSGames.UI.MultiResolution
{
	// Token: 0x02001B62 RID: 7010
	[Serializable]
	public class RectTransformComp : UIComponent
	{
		// Token: 0x0600A5CB RID: 42443 RVA: 0x00067AA7 File Offset: 0x00065CA7
		public RectTransformComp(Component comp) : base(comp)
		{
		}

		// Token: 0x0600A5CC RID: 42444 RVA: 0x0039EEE4 File Offset: 0x0039D0E4
		public bool Equals(RectTransformComp rectTransformComp)
		{
			return !(rectTransformComp.AnchoredPosition != this.AnchoredPosition) && !(rectTransformComp.AnchorMax != this.AnchorMax) && !(rectTransformComp.AnchorMin != this.AnchorMin) && !(rectTransformComp.SizeDelta != this.SizeDelta) && !(rectTransformComp.Pivot != this.Pivot) && !(rectTransformComp.Pivot != this.Pivot) && !(rectTransformComp.Rotation != this.Rotation) && !(rectTransformComp.Scale != this.Scale);
		}

		// Token: 0x0600A5CD RID: 42445 RVA: 0x0039EF9C File Offset: 0x0039D19C
		public override void ReadComponentData(Component Comp)
		{
			RectTransform component = Comp.GetComponent<RectTransform>();
			this.AnchoredPosition = component.anchoredPosition;
			this.AnchorMax = component.anchorMax;
			this.AnchorMin = component.anchorMin;
			this.SizeDelta = component.sizeDelta;
			this.Pivot = component.pivot;
			this.Rotation = component.rotation;
			this.Scale = component.localScale;
		}

		// Token: 0x0400A8CC RID: 43212
		public const string RectTransformCompName = "RectTransform";

		// Token: 0x0400A8CD RID: 43213
		public Vector3 AnchoredPosition;

		// Token: 0x0400A8CE RID: 43214
		public Vector2 AnchorMin;

		// Token: 0x0400A8CF RID: 43215
		public Vector2 AnchorMax;

		// Token: 0x0400A8D0 RID: 43216
		public Vector2 SizeDelta;

		// Token: 0x0400A8D1 RID: 43217
		public Vector3 Pivot;

		// Token: 0x0400A8D2 RID: 43218
		public Quaternion Rotation;

		// Token: 0x0400A8D3 RID: 43219
		public Vector3 Scale;
	}
}
