using System;
using UnityEngine;
using UnityEngine.UI;

namespace JSGames.Tween
{
	// Token: 0x02001B11 RID: 6929
	public class GraphicColor : TweenerV4
	{
		// Token: 0x0600A327 RID: 41767 RVA: 0x00065C98 File Offset: 0x00063E98
		public GraphicColor(GameObject tweenObject, Graphic uiGraphic, Vector4 from, Vector4 to) : base(tweenObject, from, to)
		{
			this.mUIGraphic = uiGraphic;
		}

		// Token: 0x0600A328 RID: 41768 RVA: 0x00065CAB File Offset: 0x00063EAB
		protected override void DoAnim(float val)
		{
			this.mUIGraphic.SetColor(base.CustomLerp(this.from, this.to, val));
		}

		// Token: 0x0600A329 RID: 41769 RVA: 0x00065CCB File Offset: 0x00063ECB
		protected override void DoAnimReverse(float val)
		{
			this.mUIGraphic.SetColor(base.CustomLerp(this.to, this.from, val));
		}

		// Token: 0x0400A70C RID: 42764
		private Graphic mUIGraphic;
	}
}
