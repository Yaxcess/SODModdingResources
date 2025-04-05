using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using UnityEngine;

// Token: 0x02000F39 RID: 3897
public static class NGUIText
{
	// Token: 0x04005F72 RID: 24434
	public static UIFont bitmapFont;

	// Token: 0x04005F73 RID: 24435
	public static Font dynamicFont;

	// Token: 0x04005F74 RID: 24436
	public static NGUIText.GlyphInfo glyph = new NGUIText.GlyphInfo();

	// Token: 0x04005F75 RID: 24437
	public static int fontSize = 16;

	// Token: 0x04005F76 RID: 24438
	public static float fontScale = 1f;

	// Token: 0x04005F77 RID: 24439
	public static float pixelDensity = 1f;

	// Token: 0x04005F78 RID: 24440
	public static FontStyle fontStyle = FontStyle.Normal;

	// Token: 0x04005F79 RID: 24441
	public static NGUIText.Alignment alignment = NGUIText.Alignment.Left;

	// Token: 0x04005F7A RID: 24442
	public static Color tint = Color.white;

	// Token: 0x04005F7B RID: 24443
	public static int rectWidth = 1000000;

	// Token: 0x04005F7C RID: 24444
	public static int rectHeight = 1000000;

	// Token: 0x04005F7D RID: 24445
	public static int regionWidth = 1000000;

	// Token: 0x04005F7E RID: 24446
	public static int regionHeight = 1000000;

	// Token: 0x04005F7F RID: 24447
	public static int maxLines = 0;

	// Token: 0x04005F80 RID: 24448
	public static bool gradient = false;

	// Token: 0x04005F81 RID: 24449
	public static Color gradientBottom = Color.white;

	// Token: 0x04005F82 RID: 24450
	public static Color gradientTop = Color.white;

	// Token: 0x04005F83 RID: 24451
	public static bool encoding = false;

	// Token: 0x04005F84 RID: 24452
	public static float spacingX = 0f;

	// Token: 0x04005F85 RID: 24453
	public static float spacingY = 0f;

	// Token: 0x04005F86 RID: 24454
	public static bool premultiply = false;

	// Token: 0x04005F87 RID: 24455
	public static NGUIText.SymbolStyle symbolStyle;

	// Token: 0x04005F88 RID: 24456
	public static int finalSize = 0;

	// Token: 0x04005F89 RID: 24457
	public static float finalSpacingX = 0f;

	// Token: 0x04005F8A RID: 24458
	public static float finalLineHeight = 0f;

	// Token: 0x04005F8B RID: 24459
	public static float baseline = 0f;

	// Token: 0x04005F8C RID: 24460
	public static bool useSymbols = false;

	// Token: 0x02000F3A RID: 3898
	public enum Alignment
	{
		// Token: 0x04005F97 RID: 24471
		Automatic,
		// Token: 0x04005F98 RID: 24472
		Left,
		// Token: 0x04005F99 RID: 24473
		Center,
		// Token: 0x04005F9A RID: 24474
		Right,
		// Token: 0x04005F9B RID: 24475
		Justified
	}

	// Token: 0x02000F3B RID: 3899
	public enum SymbolStyle
	{
		// Token: 0x04005F9D RID: 24477
		None,
		// Token: 0x04005F9E RID: 24478
		Normal,
		// Token: 0x04005F9F RID: 24479
		Colored
	}

	// Token: 0x02000F3C RID: 3900
	public class GlyphInfo
	{
		// Token: 0x04005FA0 RID: 24480
		public Vector2 v0;

		// Token: 0x04005FA1 RID: 24481
		public Vector2 v1;

		// Token: 0x04005FA2 RID: 24482
		public Vector2 u0;

		// Token: 0x04005FA3 RID: 24483
		public Vector2 u1;

		// Token: 0x04005FA4 RID: 24484
		public Vector2 u2;

		// Token: 0x04005FA5 RID: 24485
		public Vector2 u3;

		// Token: 0x04005FA6 RID: 24486
		public float advance;

		// Token: 0x04005FA7 RID: 24487
		public int channel;
	}
}
