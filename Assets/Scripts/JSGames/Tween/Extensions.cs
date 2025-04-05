using System;
using UnityEngine;
using UnityEngine.UI;

namespace JSGames.Tween
{
	// Token: 0x02001AF7 RID: 6903
	public static class Extensions
	{
		// Token: 0x0600A29F RID: 41631 RVA: 0x000656BF File Offset: 0x000638BF
		public static void SetPosition(this Transform transform, Vector3 position)
		{
			transform.position = position;
		}

		// Token: 0x0600A2A0 RID: 41632 RVA: 0x000656C8 File Offset: 0x000638C8
		public static void SetPosition(this RectTransform transform, Vector3 position)
		{
			transform.anchoredPosition3D = position;
		}

		// Token: 0x0600A2A1 RID: 41633 RVA: 0x00395E0C File Offset: 0x0039400C
		public static void SetPosition(this Transform transform, Vector2 position)
		{
			Vector3 position2 = position;
			position2.z = transform.position.z;
			transform.position = position2;
		}

		// Token: 0x0600A2A2 RID: 41634 RVA: 0x000656D1 File Offset: 0x000638D1
		public static void SetPosition(this RectTransform rectTransform, Vector2 position)
		{
			rectTransform.anchoredPosition = position;
		}

		// Token: 0x0600A2A3 RID: 41635 RVA: 0x000656DA File Offset: 0x000638DA
		public static void SetLocalPosition(this Transform transform, Vector3 position)
		{
			transform.localPosition = position;
		}

		// Token: 0x0600A2A4 RID: 41636 RVA: 0x00395E3C File Offset: 0x0039403C
		public static void SetLocalPosition(this Transform transform, Vector2 position)
		{
			Vector3 localPosition = position;
			localPosition.z = transform.localPosition.z;
			transform.localPosition = localPosition;
		}

		// Token: 0x0600A2A5 RID: 41637 RVA: 0x000656E3 File Offset: 0x000638E3
		public static void SetLocalScale(this Transform transform, Vector3 scale)
		{
			transform.localScale = scale;
		}

		// Token: 0x0600A2A6 RID: 41638 RVA: 0x00395E6C File Offset: 0x0039406C
		public static void SetLocalScale(this Transform transform, Vector2 scale)
		{
			Vector3 localScale = scale;
			localScale.z = transform.localScale.z;
			transform.localScale = localScale;
		}

		// Token: 0x0600A2A7 RID: 41639 RVA: 0x000656EC File Offset: 0x000638EC
		public static void SetRotation(this Transform transform, Vector3 angle)
		{
			transform.rotation = Quaternion.Euler(angle);
		}

		// Token: 0x0600A2A8 RID: 41640 RVA: 0x000656FA File Offset: 0x000638FA
		public static void SetLocalRotation(this Transform transform, Vector3 angle)
		{
			transform.localRotation = Quaternion.Euler(angle);
		}

		// Token: 0x0600A2A9 RID: 41641 RVA: 0x00065708 File Offset: 0x00063908
		public static void SetColor(this Renderer renderer, Vector4 color)
		{
			renderer.material.color = color;
		}

		// Token: 0x0600A2AA RID: 41642 RVA: 0x0006571B File Offset: 0x0006391B
		public static void SetColor(this TextMesh textMesh, Vector4 color)
		{
			textMesh.color = color;
		}

		// Token: 0x0600A2AB RID: 41643 RVA: 0x00065729 File Offset: 0x00063929
		public static void SetColor(this Graphic uiGraphic, Vector4 color)
		{
			uiGraphic.color = color;
		}

		// Token: 0x0600A2AC RID: 41644 RVA: 0x00395E9C File Offset: 0x0039409C
		public static void SetAlpha(this Renderer renderer, float val)
		{
			for (int i = 0; i < renderer.materials.Length; i++)
			{
				Color color = renderer.material.color;
				color.a = val;
				renderer.material.color = color;
			}
		}

		// Token: 0x0600A2AD RID: 41645 RVA: 0x00065737 File Offset: 0x00063937
		public static void SetText(this TextMesh textMesh, string text)
		{
			textMesh.text = text;
		}

		// Token: 0x0600A2AE RID: 41646 RVA: 0x00065740 File Offset: 0x00063940
		public static void SetText(this Text uiText, string text)
		{
			uiText.text = text;
		}
	}
}
