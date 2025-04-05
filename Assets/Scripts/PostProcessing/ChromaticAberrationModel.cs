using System;

namespace UnityEngine.PostProcessing
{
	// Token: 0x02001BD6 RID: 7126
	[Serializable]
	public class ChromaticAberrationModel : PostProcessingModel
	{
		// Token: 0x1700112A RID: 4394
		// (get) Token: 0x0600A7E4 RID: 42980 RVA: 0x0006905B File Offset: 0x0006725B
		// (set) Token: 0x0600A7E5 RID: 42981 RVA: 0x00069063 File Offset: 0x00067263
		public ChromaticAberrationModel.Settings settings
		{
			get
			{
				return this.m_Settings;
			}
			set
			{
				this.m_Settings = value;
			}
		}

		// Token: 0x0600A7E6 RID: 42982 RVA: 0x0006906C File Offset: 0x0006726C
		public override void Reset()
		{
			this.m_Settings = ChromaticAberrationModel.Settings.defaultSettings;
		}

		// Token: 0x0400AB5D RID: 43869
		[SerializeField]
		private ChromaticAberrationModel.Settings m_Settings = ChromaticAberrationModel.Settings.defaultSettings;

		// Token: 0x02001BD7 RID: 7127
		[Serializable]
		public struct Settings
		{
			// Token: 0x1700112B RID: 4395
			// (get) Token: 0x0600A7E8 RID: 42984 RVA: 0x003AB768 File Offset: 0x003A9968
			public static ChromaticAberrationModel.Settings defaultSettings
			{
				get
				{
					return new ChromaticAberrationModel.Settings
					{
						spectralTexture = null,
						intensity = 0.1f
					};
				}
			}

			// Token: 0x0400AB5E RID: 43870
			[Tooltip("Shift the hue of chromatic aberrations.")]
			public Texture2D spectralTexture;

			// Token: 0x0400AB5F RID: 43871
			[Range(0f, 1f)]
			[Tooltip("Amount of tangential distortion.")]
			public float intensity;
		}
	}
}
