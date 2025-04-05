using System;
using UnityEngine;

namespace JSGames.Tween
{
	// Token: 0x02001AF6 RID: 6902
	public static class EaseCurve
	{
		// Token: 0x0600A27F RID: 41599 RVA: 0x0006551C File Offset: 0x0006371C
		public static float Linear(float start, float end, float value)
		{
			return Mathf.Lerp(start, end, value);
		}

		// Token: 0x0600A280 RID: 41600 RVA: 0x00395728 File Offset: 0x00393928
		public static float Spring(float start, float end, float value)
		{
			value = Mathf.Clamp01(value);
			value = (Mathf.Sin(value * 3.1415927f * (0.2f + 2.5f * value * value * value)) * Mathf.Pow(1f - value, 2.2f) + value) * (1f + 1.2f * (1f - value));
			return start + (end - start) * value;
		}

		// Token: 0x0600A281 RID: 41601 RVA: 0x00065526 File Offset: 0x00063726
		public static float EaseInQuad(float start, float end, float value)
		{
			end -= start;
			return end * value * value + start;
		}

		// Token: 0x0600A282 RID: 41602 RVA: 0x00065534 File Offset: 0x00063734
		public static float EaseOutQuad(float start, float end, float value)
		{
			end -= start;
			return -end * value * (value - 2f) + start;
		}

		// Token: 0x0600A283 RID: 41603 RVA: 0x0039578C File Offset: 0x0039398C
		public static float EaseInOutQuad(float start, float end, float value)
		{
			value /= 0.5f;
			end -= start;
			if (value < 1f)
			{
				return end * 0.5f * value * value + start;
			}
			value -= 1f;
			return -end * 0.5f * (value * (value - 2f) - 1f) + start;
		}

		// Token: 0x0600A284 RID: 41604 RVA: 0x00065549 File Offset: 0x00063749
		public static float EaseInCubic(float start, float end, float value)
		{
			end -= start;
			return end * value * value * value + start;
		}

		// Token: 0x0600A285 RID: 41605 RVA: 0x00065559 File Offset: 0x00063759
		public static float EaseOutCubic(float start, float end, float value)
		{
			value -= 1f;
			end -= start;
			return end * (value * value * value + 1f) + start;
		}

		// Token: 0x0600A286 RID: 41606 RVA: 0x003957E0 File Offset: 0x003939E0
		public static float EaseInOutCubic(float start, float end, float value)
		{
			value /= 0.5f;
			end -= start;
			if (value < 1f)
			{
				return end * 0.5f * value * value * value + start;
			}
			value -= 2f;
			return end * 0.5f * (value * value * value + 2f) + start;
		}

		// Token: 0x0600A287 RID: 41607 RVA: 0x00065578 File Offset: 0x00063778
		public static float EaseInQuart(float start, float end, float value)
		{
			end -= start;
			return end * value * value * value * value + start;
		}

		// Token: 0x0600A288 RID: 41608 RVA: 0x0006558A File Offset: 0x0006378A
		public static float EaseOutQuart(float start, float end, float value)
		{
			value -= 1f;
			end -= start;
			return -end * (value * value * value * value - 1f) + start;
		}

		// Token: 0x0600A289 RID: 41609 RVA: 0x00395834 File Offset: 0x00393A34
		public static float EaseInOutQuart(float start, float end, float value)
		{
			value /= 0.5f;
			end -= start;
			if (value < 1f)
			{
				return end * 0.5f * value * value * value * value + start;
			}
			value -= 2f;
			return -end * 0.5f * (value * value * value * value - 2f) + start;
		}

		// Token: 0x0600A28A RID: 41610 RVA: 0x000655AC File Offset: 0x000637AC
		public static float EaseInQuint(float start, float end, float value)
		{
			end -= start;
			return end * value * value * value * value * value + start;
		}

		// Token: 0x0600A28B RID: 41611 RVA: 0x000655C0 File Offset: 0x000637C0
		public static float EaseOutQuint(float start, float end, float value)
		{
			value -= 1f;
			end -= start;
			return end * (value * value * value * value * value + 1f) + start;
		}

		// Token: 0x0600A28C RID: 41612 RVA: 0x0039588C File Offset: 0x00393A8C
		public static float EaseInOutQuint(float start, float end, float value)
		{
			value /= 0.5f;
			end -= start;
			if (value < 1f)
			{
				return end * 0.5f * value * value * value * value * value + start;
			}
			value -= 2f;
			return end * 0.5f * (value * value * value * value * value + 2f) + start;
		}

		// Token: 0x0600A28D RID: 41613 RVA: 0x000655E3 File Offset: 0x000637E3
		public static float EaseInSine(float start, float end, float value)
		{
			end -= start;
			return -end * Mathf.Cos(value * 1.5707964f) + end + start;
		}

		// Token: 0x0600A28E RID: 41614 RVA: 0x000655FD File Offset: 0x000637FD
		public static float EaseOutSine(float start, float end, float value)
		{
			end -= start;
			return end * Mathf.Sin(value * 1.5707964f) + start;
		}

		// Token: 0x0600A28F RID: 41615 RVA: 0x00065614 File Offset: 0x00063814
		public static float EaseInOutSine(float start, float end, float value)
		{
			end -= start;
			return -end * 0.5f * (Mathf.Cos(3.1415927f * value) - 1f) + start;
		}

		// Token: 0x0600A290 RID: 41616 RVA: 0x00065638 File Offset: 0x00063838
		public static float EaseInExpo(float start, float end, float value)
		{
			end -= start;
			return end * Mathf.Pow(2f, 10f * (value - 1f)) + start;
		}

		// Token: 0x0600A291 RID: 41617 RVA: 0x0006565A File Offset: 0x0006385A
		public static float EaseOutExpo(float start, float end, float value)
		{
			end -= start;
			return end * (-Mathf.Pow(2f, -10f * value) + 1f) + start;
		}

		// Token: 0x0600A292 RID: 41618 RVA: 0x003958E8 File Offset: 0x00393AE8
		public static float EaseInOutExpo(float start, float end, float value)
		{
			value /= 0.5f;
			end -= start;
			if (value < 1f)
			{
				return end * 0.5f * Mathf.Pow(2f, 10f * (value - 1f)) + start;
			}
			value -= 1f;
			return end * 0.5f * (-Mathf.Pow(2f, -10f * value) + 2f) + start;
		}

		// Token: 0x0600A293 RID: 41619 RVA: 0x0006567D File Offset: 0x0006387D
		public static float EaseInCirc(float start, float end, float value)
		{
			end -= start;
			return -end * (Mathf.Sqrt(1f - value * value) - 1f) + start;
		}

		// Token: 0x0600A294 RID: 41620 RVA: 0x0006569D File Offset: 0x0006389D
		public static float EaseOutCirc(float start, float end, float value)
		{
			value -= 1f;
			end -= start;
			return end * Mathf.Sqrt(1f - value * value) + start;
		}

		// Token: 0x0600A295 RID: 41621 RVA: 0x00395958 File Offset: 0x00393B58
		public static float EaseInOutCirc(float start, float end, float value)
		{
			value /= 0.5f;
			end -= start;
			if (value < 1f)
			{
				return -end * 0.5f * (Mathf.Sqrt(1f - value * value) - 1f) + start;
			}
			value -= 2f;
			return end * 0.5f * (Mathf.Sqrt(1f - value * value) + 1f) + start;
		}

		// Token: 0x0600A296 RID: 41622 RVA: 0x003959C4 File Offset: 0x00393BC4
		public static float EaseInBounce(float start, float end, float value)
		{
			end -= start;
			float num = 1f;
			return end - EaseCurve.EaseOutBounce(0f, end, num - value) + start;
		}

		// Token: 0x0600A297 RID: 41623 RVA: 0x003959F0 File Offset: 0x00393BF0
		public static float EaseOutBounce(float start, float end, float value)
		{
			value /= 1f;
			end -= start;
			if (value < 0.36363637f)
			{
				return end * (7.5625f * value * value) + start;
			}
			if (value < 0.72727275f)
			{
				value -= 0.54545456f;
				return end * (7.5625f * value * value + 0.75f) + start;
			}
			if ((double)value < 0.9090909090909091)
			{
				value -= 0.8181818f;
				return end * (7.5625f * value * value + 0.9375f) + start;
			}
			value -= 0.95454544f;
			return end * (7.5625f * value * value + 0.984375f) + start;
		}

		// Token: 0x0600A298 RID: 41624 RVA: 0x00395A8C File Offset: 0x00393C8C
		public static float EaseInOutBounce(float start, float end, float value)
		{
			end -= start;
			float num = 1f;
			if (value < num * 0.5f)
			{
				return EaseCurve.EaseInBounce(0f, end, value * 2f) * 0.5f + start;
			}
			return EaseCurve.EaseOutBounce(0f, end, value * 2f - num) * 0.5f + end * 0.5f + start;
		}

		// Token: 0x0600A299 RID: 41625 RVA: 0x00395AF0 File Offset: 0x00393CF0
		public static float EaseInBack(float start, float end, float value)
		{
			end -= start;
			value /= 1f;
			float num = 1.70158f;
			return end * value * value * ((num + 1f) * value - num) + start;
		}

		// Token: 0x0600A29A RID: 41626 RVA: 0x00395B24 File Offset: 0x00393D24
		public static float EaseOutBack(float start, float end, float value)
		{
			float num = 1.70158f;
			end -= start;
			value -= 1f;
			return end * (value * value * ((num + 1f) * value + num) + 1f) + start;
		}

		// Token: 0x0600A29B RID: 41627 RVA: 0x00395B60 File Offset: 0x00393D60
		public static float EaseInOutBack(float start, float end, float value)
		{
			float num = 1.70158f;
			end -= start;
			value /= 0.5f;
			if (value < 1f)
			{
				num *= 1.525f;
				return end * 0.5f * (value * value * ((num + 1f) * value - num)) + start;
			}
			value -= 2f;
			num *= 1.525f;
			return end * 0.5f * (value * value * ((num + 1f) * value + num) + 2f) + start;
		}

		// Token: 0x0600A29C RID: 41628 RVA: 0x00395BDC File Offset: 0x00393DDC
		public static float EaseInElastic(float start, float end, float value)
		{
			end -= start;
			float num = 1f;
			float num2 = num * 0.3f;
			float num3 = 0f;
			if (value == 0f)
			{
				return start;
			}
			if ((value /= num) == 1f)
			{
				return start + end;
			}
			float num4;
			if (num3 == 0f || num3 < Mathf.Abs(end))
			{
				num3 = end;
				num4 = num2 / 4f;
			}
			else
			{
				num4 = num2 / 6.2831855f * Mathf.Asin(end / num3);
			}
			return -(num3 * Mathf.Pow(2f, 10f * (value -= 1f)) * Mathf.Sin((value * num - num4) * 6.2831855f / num2)) + start;
		}

		// Token: 0x0600A29D RID: 41629 RVA: 0x00395C80 File Offset: 0x00393E80
		public static float EaseOutElastic(float start, float end, float value)
		{
			end -= start;
			float num = 1f;
			float num2 = num * 0.3f;
			float num3 = 0f;
			if (value == 0f)
			{
				return start;
			}
			if ((value /= num) == 1f)
			{
				return start + end;
			}
			float num4;
			if (num3 == 0f || num3 < Mathf.Abs(end))
			{
				num3 = end;
				num4 = num2 * 0.25f;
			}
			else
			{
				num4 = num2 / 6.2831855f * Mathf.Asin(end / num3);
			}
			return num3 * Mathf.Pow(2f, -10f * value) * Mathf.Sin((value * num - num4) * 6.2831855f / num2) + end + start;
		}

		// Token: 0x0600A29E RID: 41630 RVA: 0x00395D1C File Offset: 0x00393F1C
		public static float EaseInOutElastic(float start, float end, float value)
		{
			end -= start;
			float num = 1f;
			float num2 = num * 0.3f;
			float num3 = 0f;
			if (value == 0f)
			{
				return start;
			}
			if ((value /= num * 0.5f) == 2f)
			{
				return start + end;
			}
			float num4;
			if (num3 == 0f || num3 < Mathf.Abs(end))
			{
				num3 = end;
				num4 = num2 / 4f;
			}
			else
			{
				num4 = num2 / 6.2831855f * Mathf.Asin(end / num3);
			}
			if (value < 1f)
			{
				return -0.5f * (num3 * Mathf.Pow(2f, 10f * (value -= 1f)) * Mathf.Sin((value * num - num4) * 6.2831855f / num2)) + start;
			}
			return num3 * Mathf.Pow(2f, -10f * (value -= 1f)) * Mathf.Sin((value * num - num4) * 6.2831855f / num2) * 0.5f + end + start;
		}
	}
}
