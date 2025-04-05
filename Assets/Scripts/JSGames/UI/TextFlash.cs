using System;
using UnityEngine;
using UnityEngine.UI;

namespace JSGames.UI
{
	// Token: 0x02001B1F RID: 6943
	public class TextFlash : MonoBehaviour
	{
		// Token: 0x0600A383 RID: 41859 RVA: 0x00397EA4 File Offset: 0x003960A4
		private void Start()
		{
			this.mText = base.gameObject.GetComponent<Text>();
			if (this.mText == null)
			{
				UIWidget component = base.gameObject.GetComponent<UIWidget>();
				if (component != null)
				{
					this.mText = component._Text;
				}
			}
			if (this.mText != null)
			{
				this.mOriginalColor = this.mText.color;
				this.mOriginalScale = this.mText.transform.localScale;
				this.mTime = 0f;
			}
		}

		// Token: 0x0600A384 RID: 41860 RVA: 0x00397F38 File Offset: 0x00396138
		private void Update()
		{
			if (this.mText == null)
			{
				return;
			}
			if (this.m_DisableBlink)
			{
				if (!this.mEffectApplied)
				{
					this.ApplyEffects();
				}
				return;
			}
			if (this.m_LerpEffects)
			{
				this.LerpEffects();
			}
			this.mTime += Time.deltaTime;
			if (this.mTime > this.m_FlashSpeed)
			{
				this.mTime = 0f;
				this.mLerpTime = 0f;
				this.ApplyEffects();
			}
		}

		// Token: 0x0600A385 RID: 41861 RVA: 0x00397FB8 File Offset: 0x003961B8
		private void LerpEffects()
		{
			Color32 a = this.mEffectApplied ? this.m_TargetColor : this.mOriginalColor;
			Color32 b = this.mEffectApplied ? this.mOriginalColor : this.m_TargetColor;
			this.mLerpTime += Time.deltaTime / this.m_FlashSpeed;
			Color32 c = Color32.Lerp(a, b, this.mLerpTime);
			Vector3 a2 = this.mEffectApplied ? this.m_TargetScale : this.mOriginalScale;
			Vector3 b2 = this.mEffectApplied ? this.mOriginalScale : this.m_TargetScale;
			Vector3 scale = Vector3.Lerp(a2, b2, this.mLerpTime);
			this.ApplyEffects(c, scale);
		}

		// Token: 0x0600A386 RID: 41862 RVA: 0x00398060 File Offset: 0x00396260
		private void ApplyEffects()
		{
			this.mText.color = (this.mEffectApplied ? this.mOriginalColor : this.m_TargetColor);
			this.mText.transform.localScale = (this.mEffectApplied ? this.mOriginalScale : this.m_TargetScale);
			this.mEffectApplied = !this.mEffectApplied;
		}

		// Token: 0x0600A387 RID: 41863 RVA: 0x00066163 File Offset: 0x00064363
		private void ApplyEffects(Color color, Vector3 scale)
		{
			this.mText.color = color;
			this.mText.transform.localScale = scale;
		}

		// Token: 0x0600A388 RID: 41864 RVA: 0x00066182 File Offset: 0x00064382
		public void ResetEffects()
		{
			this.mTime = 0f;
			this.mEffectApplied = false;
			this.mText.color = this.mOriginalColor;
			this.mText.transform.localScale = this.mOriginalScale;
		}

		// Token: 0x0400A744 RID: 42820
		[SerializeField]
		private Color32 m_TargetColor;

		// Token: 0x0400A745 RID: 42821
		[SerializeField]
		private Vector3 m_TargetScale;

		// Token: 0x0400A746 RID: 42822
		[SerializeField]
		private float m_FlashSpeed;

		// Token: 0x0400A747 RID: 42823
		[SerializeField]
		private bool m_DisableBlink;

		// Token: 0x0400A748 RID: 42824
		[SerializeField]
		private bool m_LerpEffects;

		// Token: 0x0400A749 RID: 42825
		private Color32 mOriginalColor;

		// Token: 0x0400A74A RID: 42826
		private Vector3 mOriginalScale;

		// Token: 0x0400A74B RID: 42827
		private Text mText;

		// Token: 0x0400A74C RID: 42828
		private float mTime;

		// Token: 0x0400A74D RID: 42829
		private bool mEffectApplied;

		// Token: 0x0400A74E RID: 42830
		private float mLerpTime;
	}
}
