using System;
using UnityEngine;

namespace JSGames.UI
{
	// Token: 0x02001B18 RID: 6936
	public class LerpScale : MonoBehaviour
	{
		// Token: 0x0600A350 RID: 41808 RVA: 0x00065F2F File Offset: 0x0006412F
		private void Start()
		{
			this.mOriginalScale = base.transform.localScale;
			this.mTime = 0f;
			this.mAllowEffect = this.m_PlayOnAwake;
		}

		// Token: 0x0600A351 RID: 41809 RVA: 0x00065F59 File Offset: 0x00064159
		private void Update()
		{
			if (this.mAllowEffect)
			{
				this.PlayLerp();
			}
		}

		// Token: 0x0600A352 RID: 41810 RVA: 0x00396EC4 File Offset: 0x003950C4
		private void PlayLerp()
		{
			Vector3 a = this.mEffectApplied ? this.m_TargetScale : this.mOriginalScale;
			Vector3 b = this.mEffectApplied ? this.mOriginalScale : this.m_TargetScale;
			this.mLerpTime += Time.deltaTime / this.m_Duration;
			Vector3 localScale = Vector3.Lerp(a, b, this.mLerpTime);
			base.transform.localScale = localScale;
			this.mTime += Time.deltaTime;
			if (this.mTime > this.m_Duration)
			{
				this.mTime = 0f;
				this.mLerpTime = 0f;
				this.mEffectApplied = !this.mEffectApplied;
			}
		}

		// Token: 0x0600A353 RID: 41811 RVA: 0x00065F69 File Offset: 0x00064169
		public void ResetEffect()
		{
			this.mTime = 0f;
			this.mEffectApplied = false;
			this.mAllowEffect = false;
			base.transform.localScale = this.mOriginalScale;
		}

		// Token: 0x0400A71D RID: 42781
		[SerializeField]
		private Vector3 m_TargetScale;

		// Token: 0x0400A71E RID: 42782
		[SerializeField]
		private float m_Duration;

		// Token: 0x0400A71F RID: 42783
		[SerializeField]
		private bool m_PlayOnAwake;

		// Token: 0x0400A720 RID: 42784
		private Vector3 mOriginalScale;

		// Token: 0x0400A721 RID: 42785
		private float mTime;

		// Token: 0x0400A722 RID: 42786
		private float mLerpTime;

		// Token: 0x0400A723 RID: 42787
		private bool mEffectApplied;

		// Token: 0x0400A724 RID: 42788
		private bool mAllowEffect;
	}
}
