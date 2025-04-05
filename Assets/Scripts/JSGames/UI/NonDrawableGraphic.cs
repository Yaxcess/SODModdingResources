using System;
using UnityEngine;
using UnityEngine.UI;

namespace JSGames.UI
{
	// Token: 0x02001B1C RID: 6940
	[RequireComponent(typeof(CanvasRenderer))]
	public class NonDrawableGraphic : Graphic
	{
		// Token: 0x0600A364 RID: 41828 RVA: 0x00006173 File Offset: 0x00004373
		public override void SetMaterialDirty()
		{
		}

		// Token: 0x0600A365 RID: 41829 RVA: 0x00006173 File Offset: 0x00004373
		public override void SetVerticesDirty()
		{
		}

		// Token: 0x0600A366 RID: 41830 RVA: 0x00065FBB File Offset: 0x000641BB
		protected override void OnPopulateMesh(VertexHelper vh)
		{
			vh.Clear();
		}
	}
}
