using System;
using UnityEngine;
using UnityEngine.UI;

namespace JSGames.UI.MultiResolution
{
	// Token: 0x02001B60 RID: 7008
	[Serializable]
	public class CanvasScalerComp : UIComponent
	{
		// Token: 0x0600A5C5 RID: 42437 RVA: 0x00067AA7 File Offset: 0x00065CA7
		public CanvasScalerComp(Component comp) : base(comp)
		{
		}

		// Token: 0x0600A5C6 RID: 42438 RVA: 0x00067AB0 File Offset: 0x00065CB0
		public bool Equals(CanvasScalerComp canvasScalerComp)
		{
			return !(canvasScalerComp.ScalerResolution != this.ScalerResolution) && canvasScalerComp.UIScaleMode == this.UIScaleMode && canvasScalerComp.ScreenMatchMode == this.ScreenMatchMode;
		}

		// Token: 0x0600A5C7 RID: 42439 RVA: 0x0039EDD8 File Offset: 0x0039CFD8
		public override void ReadComponentData(Component Comp)
		{
			CanvasScaler component = Comp.GetComponent<CanvasScaler>();
			this.ScalerResolution = component.referenceResolution;
			this.UIScaleMode = component.uiScaleMode;
			this.ScreenMatchMode = component.screenMatchMode;
		}

		// Token: 0x0400A8C4 RID: 43204
		public const string CanvasScalerCompName = "CanvasScaler";

		// Token: 0x0400A8C5 RID: 43205
		public Vector2 ScalerResolution;

		// Token: 0x0400A8C6 RID: 43206
		public CanvasScaler.ScaleMode UIScaleMode;

		// Token: 0x0400A8C7 RID: 43207
		public CanvasScaler.ScreenMatchMode ScreenMatchMode;
	}
}
