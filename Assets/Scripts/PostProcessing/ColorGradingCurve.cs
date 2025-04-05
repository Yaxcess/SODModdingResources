using System;

namespace UnityEngine.PostProcessing
{
	// Token: 0x02001C05 RID: 7173
	[Serializable]
	public sealed class ColorGradingCurve
	{
		// Token: 0x0600A859 RID: 43097 RVA: 0x000693F2 File Offset: 0x000675F2
		public ColorGradingCurve(AnimationCurve curve, float zeroValue, bool loop, Vector2 bounds)
		{
			this.curve = curve;
			this.m_ZeroValue = zeroValue;
			this.m_Loop = loop;
			this.m_Range = bounds.magnitude;
		}

		// Token: 0x0600A85A RID: 43098 RVA: 0x003ACBE0 File Offset: 0x003AADE0
		public void Cache()
		{
			if (!this.m_Loop)
			{
				return;
			}
			int length = this.curve.length;
			if (length < 2)
			{
				return;
			}
			if (this.m_InternalLoopingCurve == null)
			{
				this.m_InternalLoopingCurve = new AnimationCurve();
			}
			Keyframe key = this.curve[length - 1];
			key.time -= this.m_Range;
			Keyframe key2 = this.curve[0];
			key2.time += this.m_Range;
			this.m_InternalLoopingCurve.keys = this.curve.keys;
			this.m_InternalLoopingCurve.AddKey(key);
			this.m_InternalLoopingCurve.AddKey(key2);
		}

		// Token: 0x0600A85B RID: 43099 RVA: 0x003ACC90 File Offset: 0x003AAE90
		public float Evaluate(float t)
		{
			if (this.curve.length == 0)
			{
				return this.m_ZeroValue;
			}
			if (!this.m_Loop || this.curve.length == 1)
			{
				return this.curve.Evaluate(t);
			}
			return this.m_InternalLoopingCurve.Evaluate(t);
		}

		// Token: 0x0400AC17 RID: 44055
		public AnimationCurve curve;

		// Token: 0x0400AC18 RID: 44056
		[SerializeField]
		private bool m_Loop;

		// Token: 0x0400AC19 RID: 44057
		[SerializeField]
		private float m_ZeroValue;

		// Token: 0x0400AC1A RID: 44058
		[SerializeField]
		private float m_Range;

		// Token: 0x0400AC1B RID: 44059
		private AnimationCurve m_InternalLoopingCurve;
	}
}
