using System;
using UnityEngine;

namespace JSGames.Tween
{
	// Token: 0x02001B10 RID: 6928
	public class TextMeshColor : TweenerV4
	{
		// Token: 0x0600A324 RID: 41764 RVA: 0x00065C45 File Offset: 0x00063E45
		public TextMeshColor(GameObject tweenObject, TextMesh textMesh, Vector4 from, Vector4 to) : base(tweenObject, from, to)
		{
			this.mTextMesh = textMesh;
		}

		// Token: 0x0600A325 RID: 41765 RVA: 0x00065C58 File Offset: 0x00063E58
		protected override void DoAnim(float val)
		{
			this.mTextMesh.SetColor(base.CustomLerp(this.from, this.to, val));
		}

		// Token: 0x0600A326 RID: 41766 RVA: 0x00065C78 File Offset: 0x00063E78
		protected override void DoAnimReverse(float val)
		{
			this.mTextMesh.SetColor(base.CustomLerp(this.to, this.from, val));
		}

		// Token: 0x0400A70B RID: 42763
		private TextMesh mTextMesh;
	}
}
