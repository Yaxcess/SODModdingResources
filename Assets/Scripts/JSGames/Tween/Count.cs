using System;
using UnityEngine;
using UnityEngine.UI;

namespace JSGames.Tween
{
	// Token: 0x02001B0F RID: 6927
	public class Count : TweenerF
	{
		// Token: 0x0600A320 RID: 41760 RVA: 0x00065C1F File Offset: 0x00063E1F
		public Count(GameObject tweenObject, Text uiText, float from, float to) : base(tweenObject, from, to)
		{
			this.mUIText = uiText;
		}

		// Token: 0x0600A321 RID: 41761 RVA: 0x00065C32 File Offset: 0x00063E32
		public Count(GameObject tweenObject, TextMesh textMesh, float from, float to) : base(tweenObject, from, to)
		{
			this.mTextMesh = textMesh;
		}

		// Token: 0x0600A322 RID: 41762 RVA: 0x00396C90 File Offset: 0x00394E90
		protected override void DoAnim(float val)
		{
			int num = (int)base.CustomLerp(this.from, this.to, val);
			if (this.mUIText != null)
			{
				this.mUIText.SetText(num.ToString());
				return;
			}
			if (this.mTextMesh != null)
			{
				this.mTextMesh.SetText(num.ToString());
			}
		}

		// Token: 0x0600A323 RID: 41763 RVA: 0x00396C90 File Offset: 0x00394E90
		protected override void DoAnimReverse(float val)
		{
			int num = (int)base.CustomLerp(this.from, this.to, val);
			if (this.mUIText != null)
			{
				this.mUIText.SetText(num.ToString());
				return;
			}
			if (this.mTextMesh != null)
			{
				this.mTextMesh.SetText(num.ToString());
			}
		}

		// Token: 0x0400A709 RID: 42761
		private Text mUIText;

		// Token: 0x0400A70A RID: 42762
		private TextMesh mTextMesh;
	}
}
