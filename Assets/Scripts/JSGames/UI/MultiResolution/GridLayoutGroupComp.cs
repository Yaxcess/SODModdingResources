using System;
using UnityEngine;
using UnityEngine.UI;

namespace JSGames.UI.MultiResolution
{
	// Token: 0x02001B61 RID: 7009
	[Serializable]
	public class GridLayoutGroupComp : UIComponent
	{
		// Token: 0x0600A5C8 RID: 42440 RVA: 0x00067AE8 File Offset: 0x00065CE8
		public GridLayoutGroupComp(Component comp) : base(comp)
		{
			this.ReadComponentData(comp);
		}

		// Token: 0x0600A5C9 RID: 42441 RVA: 0x0039EE10 File Offset: 0x0039D010
		public bool Equals(GridLayoutGroupComp gridLayoutGroupComp)
		{
			return gridLayoutGroupComp.Padding.left == this.Padding.left && gridLayoutGroupComp.Padding.right == this.Padding.right && gridLayoutGroupComp.Padding.top == this.Padding.top && gridLayoutGroupComp.Padding.bottom == this.Padding.bottom && !(gridLayoutGroupComp.CellSize != this.CellSize) && !(gridLayoutGroupComp.Spacing != this.Spacing);
		}

		// Token: 0x0600A5CA RID: 42442 RVA: 0x0039EEAC File Offset: 0x0039D0AC
		public override void ReadComponentData(Component Comp)
		{
			GridLayoutGroup component = Comp.GetComponent<GridLayoutGroup>();
			this.Padding = component.padding;
			this.CellSize = component.cellSize;
			this.Spacing = component.spacing;
		}

		// Token: 0x0400A8C8 RID: 43208
		public const string GridLayoutGroupCompName = "GridLayoutGroup";

		// Token: 0x0400A8C9 RID: 43209
		public RectOffset Padding;

		// Token: 0x0400A8CA RID: 43210
		public Vector2 CellSize;

		// Token: 0x0400A8CB RID: 43211
		public Vector2 Spacing;
	}
}
