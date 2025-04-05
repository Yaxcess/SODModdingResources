using System;
using UnityEngine;

namespace JSGames.Tween
{
	// Token: 0x02001B09 RID: 6921
	public class RotateLocal : TweenerV3
	{
		// Token: 0x0600A30D RID: 41741 RVA: 0x00065979 File Offset: 0x00063B79
		public RotateLocal(GameObject tweenObject, Vector3 from, Vector3 to) : base(tweenObject, from, to)
		{
		}

		// Token: 0x0600A30E RID: 41742 RVA: 0x00065A79 File Offset: 0x00063C79
		protected override void DoAnim(float val)
		{
			base.pTweenObject.transform.SetLocalRotation(base.CustomLerp(this.from, this.to, val));
		}

		// Token: 0x0600A30F RID: 41743 RVA: 0x00065A9E File Offset: 0x00063C9E
		protected override void DoAnimReverse(float val)
		{
			base.pTweenObject.transform.SetLocalRotation(base.CustomLerp(this.to, this.from, val));
		}
	}
}
