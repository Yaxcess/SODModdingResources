using System;
using UnityEngine;

namespace JSGames.UI.MultiResolution
{
	// Token: 0x02001B5F RID: 7007
	[Serializable]
	public class CanvasComp : UIComponent
	{
		// Token: 0x0600A5C2 RID: 42434 RVA: 0x00067AA7 File Offset: 0x00065CA7
		public CanvasComp(Component comp) : base(comp)
		{
		}

		// Token: 0x0600A5C3 RID: 42435 RVA: 0x0039ED44 File Offset: 0x0039CF44
		public bool Equals(CanvasComp canvasComp)
		{
			return canvasComp.RenderMode == this.RenderMode && canvasComp.SortOrder == this.SortOrder && canvasComp.PixelPerfect == this.PixelPerfect && canvasComp.OverridePixelPerfect == this.OverridePixelPerfect;
		}

		// Token: 0x0600A5C4 RID: 42436 RVA: 0x0039ED94 File Offset: 0x0039CF94
		public override void ReadComponentData(Component Comp)
		{
			Canvas component = Comp.GetComponent<Canvas>();
			this.RenderMode = component.renderMode;
			this.SortOrder = component.sortingOrder;
			this.PixelPerfect = component.pixelPerfect;
			this.OverridePixelPerfect = component.overridePixelPerfect;
		}

		// Token: 0x0400A8BF RID: 43199
		public const string CanvasCompName = "Canvas";

		// Token: 0x0400A8C0 RID: 43200
		public RenderMode RenderMode;

		// Token: 0x0400A8C1 RID: 43201
		public int SortOrder;

		// Token: 0x0400A8C2 RID: 43202
		public bool PixelPerfect;

		// Token: 0x0400A8C3 RID: 43203
		public bool OverridePixelPerfect;
	}
}
