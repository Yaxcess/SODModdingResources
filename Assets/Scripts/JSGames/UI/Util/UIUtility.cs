using System;
using UnityEngine;

namespace JSGames.UI.Util
{
	// Token: 0x02001B5E RID: 7006
	public static class UIUtility
	{
		// Token: 0x0600A5BF RID: 42431 RVA: 0x0039ECB8 File Offset: 0x0039CEB8
		public static Vector2 ScreenPointToLocalNormalized(this RectTransform rectTransform, Canvas canvas, Vector3 screenPoint)
		{
			Vector2 point;
			RectTransformUtility.ScreenPointToLocalPointInRectangle(rectTransform, screenPoint, canvas.worldCamera, out point);
			return Rect.PointToNormalized(rectTransform.rect, point);
		}

		// Token: 0x0600A5C0 RID: 42432 RVA: 0x0039ECE8 File Offset: 0x0039CEE8
		public static Vector2 ScreenToLocalPoint(this RectTransform rectTransform, Canvas canvas, Vector3 screenPoint)
		{
			return rectTransform.ScreenToLocalPoint(canvas, rectTransform.rect.size, screenPoint);
		}

		// Token: 0x0600A5C1 RID: 42433 RVA: 0x0039ED0C File Offset: 0x0039CF0C
		public static Vector2 ScreenToLocalPoint(this RectTransform rectTransform, Canvas canvas, Vector2 rectSize, Vector3 screenPoint)
		{
			Vector2 vector = rectTransform.ScreenPointToLocalNormalized(canvas, screenPoint);
			return new Vector2(rectSize.x * vector.x, rectSize.y * vector.y);
		}
	}
}
