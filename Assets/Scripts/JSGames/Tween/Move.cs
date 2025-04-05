using System;
using UnityEngine;

namespace JSGames.Tween
{
	// Token: 0x02001B05 RID: 6917
	public class Move : TweenerV3
	{
		// Token: 0x0600A300 RID: 41728 RVA: 0x00065979 File Offset: 0x00063B79
		public Move(GameObject tweenObject, Vector3 from, Vector3 to) : base(tweenObject, from, to)
		{
		}

		// Token: 0x0600A301 RID: 41729 RVA: 0x00065984 File Offset: 0x00063B84
		public Move(RectTransform rectTransform, Vector3 from, Vector3 to) : base(rectTransform.gameObject, from, to)
		{
			this.mRectTransform = rectTransform;
		}

		// Token: 0x0600A302 RID: 41730 RVA: 0x00396B10 File Offset: 0x00394D10
		protected override void DoAnim(float val)
		{
			if (this.mRectTransform != null)
			{
				this.mRectTransform.SetPosition(base.CustomLerp(this.from, this.to, val));
				return;
			}
			base.pTweenObject.transform.SetPosition(base.CustomLerp(this.from, this.to, val));
		}

		// Token: 0x0600A303 RID: 41731 RVA: 0x00396B70 File Offset: 0x00394D70
		protected override void DoAnimReverse(float val)
		{
			if (this.mRectTransform != null)
			{
				this.mRectTransform.SetPosition(base.CustomLerp(this.to, this.from, val));
				return;
			}
			base.pTweenObject.transform.SetPosition(base.CustomLerp(this.to, this.from, val));
		}

		// Token: 0x0400A705 RID: 42757
		private RectTransform mRectTransform;
	}
}
