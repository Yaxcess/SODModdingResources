using System;
using UnityEngine.EventSystems;

namespace JSGames.UI
{
	// Token: 0x02001B42 RID: 6978
	public class UIEvents
	{
		// Token: 0x14000257 RID: 599
		// (add) Token: 0x0600A47C RID: 42108 RVA: 0x0039A788 File Offset: 0x00398988
		// (remove) Token: 0x0600A47D RID: 42109 RVA: 0x0039A7C0 File Offset: 0x003989C0
		public event Action<UIWidget, int> OnAnimEnd;

		// Token: 0x14000258 RID: 600
		// (add) Token: 0x0600A47E RID: 42110 RVA: 0x0039A7F8 File Offset: 0x003989F8
		// (remove) Token: 0x0600A47F RID: 42111 RVA: 0x0039A830 File Offset: 0x00398A30
		public event Action<UIWidget, PointerEventData> OnDrag;

		// Token: 0x14000259 RID: 601
		// (add) Token: 0x0600A480 RID: 42112 RVA: 0x0039A868 File Offset: 0x00398A68
		// (remove) Token: 0x0600A481 RID: 42113 RVA: 0x0039A8A0 File Offset: 0x00398AA0
		public event Action<UIWidget, PointerEventData> OnDrop;

		// Token: 0x1400025A RID: 602
		// (add) Token: 0x0600A482 RID: 42114 RVA: 0x0039A8D8 File Offset: 0x00398AD8
		// (remove) Token: 0x0600A483 RID: 42115 RVA: 0x0039A910 File Offset: 0x00398B10
		public event Action<UIWidget, PointerEventData> OnBeginDrag;

		// Token: 0x1400025B RID: 603
		// (add) Token: 0x0600A484 RID: 42116 RVA: 0x0039A948 File Offset: 0x00398B48
		// (remove) Token: 0x0600A485 RID: 42117 RVA: 0x0039A980 File Offset: 0x00398B80
		public event Action<UIWidget, PointerEventData> OnEndDrag;

		// Token: 0x1400025C RID: 604
		// (add) Token: 0x0600A486 RID: 42118 RVA: 0x0039A9B8 File Offset: 0x00398BB8
		// (remove) Token: 0x0600A487 RID: 42119 RVA: 0x0039A9F0 File Offset: 0x00398BF0
		public event Action<UIWidget, PointerEventData> OnClick;

		// Token: 0x1400025D RID: 605
		// (add) Token: 0x0600A488 RID: 42120 RVA: 0x0039AA28 File Offset: 0x00398C28
		// (remove) Token: 0x0600A489 RID: 42121 RVA: 0x0039AA60 File Offset: 0x00398C60
		public event Action<UIWidget, bool, PointerEventData> OnPress;

		// Token: 0x1400025E RID: 606
		// (add) Token: 0x0600A48A RID: 42122 RVA: 0x0039AA98 File Offset: 0x00398C98
		// (remove) Token: 0x0600A48B RID: 42123 RVA: 0x0039AAD0 File Offset: 0x00398CD0
		public event Action<UIWidget> OnPressRepeated;

		// Token: 0x1400025F RID: 607
		// (add) Token: 0x0600A48C RID: 42124 RVA: 0x0039AB08 File Offset: 0x00398D08
		// (remove) Token: 0x0600A48D RID: 42125 RVA: 0x0039AB40 File Offset: 0x00398D40
		public event Action<UIWidget, bool, PointerEventData> OnHover;

		// Token: 0x14000260 RID: 608
		// (add) Token: 0x0600A48E RID: 42126 RVA: 0x0039AB78 File Offset: 0x00398D78
		// (remove) Token: 0x0600A48F RID: 42127 RVA: 0x0039ABB0 File Offset: 0x00398DB0
		public event Action<UIEditBox, string> OnEndEdit;

		// Token: 0x14000261 RID: 609
		// (add) Token: 0x0600A490 RID: 42128 RVA: 0x0039ABE8 File Offset: 0x00398DE8
		// (remove) Token: 0x0600A491 RID: 42129 RVA: 0x0039AC20 File Offset: 0x00398E20
		public event Action<UIEditBox, string> OnValueChanged;

		// Token: 0x14000262 RID: 610
		// (add) Token: 0x0600A492 RID: 42130 RVA: 0x0039AC58 File Offset: 0x00398E58
		// (remove) Token: 0x0600A493 RID: 42131 RVA: 0x0039AC90 File Offset: 0x00398E90
		public event Action<UIToggleButton, bool> OnCheckedChanged;

		// Token: 0x14000263 RID: 611
		// (add) Token: 0x0600A494 RID: 42132 RVA: 0x0039ACC8 File Offset: 0x00398EC8
		// (remove) Token: 0x0600A495 RID: 42133 RVA: 0x0039AD00 File Offset: 0x00398F00
		public event Action<UIWidget, UI> OnSelected;

		// Token: 0x0600A496 RID: 42134 RVA: 0x00066ADD File Offset: 0x00064CDD
		public void TriggerOnAnimEnd(UIWidget widget, int animIndex)
		{
			if (this.OnAnimEnd != null)
			{
				this.OnAnimEnd(widget, animIndex);
			}
		}

		// Token: 0x0600A497 RID: 42135 RVA: 0x00066AF4 File Offset: 0x00064CF4
		public void TriggerOnDrag(UIWidget widget, PointerEventData eventData)
		{
			if (this.OnDrag != null)
			{
				this.OnDrag(widget, eventData);
			}
		}

		// Token: 0x0600A498 RID: 42136 RVA: 0x00066B0B File Offset: 0x00064D0B
		public void TriggerOnDrop(UIWidget widget, PointerEventData eventData)
		{
			if (this.OnDrop != null)
			{
				this.OnDrop(widget, eventData);
			}
		}

		// Token: 0x0600A499 RID: 42137 RVA: 0x00066B22 File Offset: 0x00064D22
		public void TriggerOnBeginDrag(UIWidget widget, PointerEventData eventData)
		{
			if (this.OnBeginDrag != null)
			{
				this.OnBeginDrag(widget, eventData);
			}
		}

		// Token: 0x0600A49A RID: 42138 RVA: 0x00066B39 File Offset: 0x00064D39
		public void TriggerOnEndDrag(UIWidget widget, PointerEventData eventData)
		{
			if (this.OnEndDrag != null)
			{
				this.OnEndDrag(widget, eventData);
			}
		}

		// Token: 0x0600A49B RID: 42139 RVA: 0x00066B50 File Offset: 0x00064D50
		public void TriggerOnClick(UIWidget widget, PointerEventData eventData)
		{
			if (this.OnClick != null)
			{
				this.OnClick(widget, eventData);
			}
		}

		// Token: 0x0600A49C RID: 42140 RVA: 0x00066B67 File Offset: 0x00064D67
		public void TriggerOnPress(UIWidget widget, bool isPressed, PointerEventData eventData)
		{
			if (this.OnPress != null)
			{
				this.OnPress(widget, isPressed, eventData);
			}
		}

		// Token: 0x0600A49D RID: 42141 RVA: 0x00066B7F File Offset: 0x00064D7F
		public void TriggerOnPressRepeated(UIWidget widget)
		{
			if (this.OnPressRepeated != null)
			{
				this.OnPressRepeated(widget);
			}
		}

		// Token: 0x0600A49E RID: 42142 RVA: 0x00066B95 File Offset: 0x00064D95
		public void TriggerOnHover(UIWidget widget, bool isHovering, PointerEventData eventData)
		{
			if (this.OnHover != null)
			{
				this.OnHover(widget, isHovering, eventData);
			}
		}

		// Token: 0x0600A49F RID: 42143 RVA: 0x00066BAD File Offset: 0x00064DAD
		public void TriggerOnEdit(UIEditBox editBox, string text)
		{
			if (this.OnEndEdit != null)
			{
				this.OnEndEdit(editBox, text);
			}
		}

		// Token: 0x0600A4A0 RID: 42144 RVA: 0x00066BC4 File Offset: 0x00064DC4
		public void TriggerOnValueChanged(UIEditBox editBox, string text)
		{
			if (this.OnValueChanged != null)
			{
				this.OnValueChanged(editBox, text);
			}
		}

		// Token: 0x0600A4A1 RID: 42145 RVA: 0x00066BDB File Offset: 0x00064DDB
		public void TriggerOnCheckedChanged(UIToggleButton toggleButton, bool isChecked)
		{
			if (this.OnCheckedChanged != null)
			{
				this.OnCheckedChanged(toggleButton, isChecked);
			}
		}

		// Token: 0x0600A4A2 RID: 42146 RVA: 0x00066BF2 File Offset: 0x00064DF2
		public void TriggerOnSelected(UIWidget widget, UI fromUI)
		{
			if (this.OnSelected != null)
			{
				this.OnSelected(widget, fromUI);
			}
		}
	}
}
