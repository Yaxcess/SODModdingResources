using System;
using UnityEngine;

namespace JSGames.Tween
{
	// Token: 0x02001B07 RID: 6919
	public class Scale : TweenerV3
	{
		// Token: 0x0600A307 RID: 41735 RVA: 0x00065979 File Offset: 0x00063B79
		public Scale(GameObject tweenObject, Vector3 from, Vector3 to) : base(tweenObject, from, to)
		{
		}

		// Token: 0x0600A308 RID: 41736 RVA: 0x000659E5 File Offset: 0x00063BE5
		protected override void DoAnim(float val)
		{
			base.pTweenObject.transform.SetLocalScale(base.CustomLerp(this.from, this.to, val));
		}

		// Token: 0x0600A309 RID: 41737 RVA: 0x00065A0A File Offset: 0x00063C0A
		protected override void DoAnimReverse(float val)
		{
			base.pTweenObject.transform.SetLocalScale(base.CustomLerp(this.to, this.from, val));
		}
	}
}
