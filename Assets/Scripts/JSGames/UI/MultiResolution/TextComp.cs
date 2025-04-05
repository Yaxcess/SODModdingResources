using System;
using UnityEngine;
using UnityEngine.UI;

namespace JSGames.UI.MultiResolution
{
	// Token: 0x02001B63 RID: 7011
	[Serializable]
	public class TextComp : UIComponent
	{
		// Token: 0x0600A5CE RID: 42446 RVA: 0x00067AA7 File Offset: 0x00065CA7
		public TextComp(Component comp) : base(comp)
		{
		}

		// Token: 0x0600A5CF RID: 42447 RVA: 0x0039F010 File Offset: 0x0039D210
		public bool Equals(TextComp textComp)
		{
			return textComp.FontSize == this.FontSize && textComp.LineSpacing == this.LineSpacing && textComp.RichText == this.RichText && textComp.Alignment == this.Alignment && textComp.BestFit == this.BestFit && textComp.BestFitMin == this.BestFitMin && textComp.BestFitMax == this.BestFitMax && textComp.HorizontalWrapMode == this.HorizontalWrapMode && textComp.VerticalWrapMode == this.VerticalWrapMode;
		}

		// Token: 0x0600A5D0 RID: 42448 RVA: 0x0039F0B0 File Offset: 0x0039D2B0
		public override void ReadComponentData(Component Comp)
		{
			Text component = Comp.GetComponent<Text>();
			this.FontSize = component.fontSize;
			this.LineSpacing = component.lineSpacing;
			this.RichText = component.supportRichText;
			this.Alignment = component.alignment;
			this.BestFit = component.resizeTextForBestFit;
			this.BestFitMin = component.resizeTextMinSize;
			this.BestFitMax = component.resizeTextMaxSize;
			this.HorizontalWrapMode = component.horizontalOverflow;
			this.VerticalWrapMode = component.verticalOverflow;
		}

		// Token: 0x0400A8D4 RID: 43220
		public const string TextCompName = "Text";

		// Token: 0x0400A8D5 RID: 43221
		public int FontSize;

		// Token: 0x0400A8D6 RID: 43222
		public float LineSpacing;

		// Token: 0x0400A8D7 RID: 43223
		public bool RichText;

		// Token: 0x0400A8D8 RID: 43224
		public bool BestFit;

		// Token: 0x0400A8D9 RID: 43225
		public int BestFitMin;

		// Token: 0x0400A8DA RID: 43226
		public int BestFitMax;

		// Token: 0x0400A8DB RID: 43227
		public bool AlignByGeometry;

		// Token: 0x0400A8DC RID: 43228
		public HorizontalWrapMode HorizontalWrapMode;

		// Token: 0x0400A8DD RID: 43229
		public VerticalWrapMode VerticalWrapMode;

		// Token: 0x0400A8DE RID: 43230
		public TextAnchor Alignment;

		// Token: 0x0400A8DF RID: 43231
		public string TextJson;
	}
}
