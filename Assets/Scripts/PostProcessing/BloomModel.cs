using System;

namespace UnityEngine.PostProcessing
{
	// Token: 0x02001BCD RID: 7117
	[Serializable]
	public class BloomModel : PostProcessingModel
	{
		// Token: 0x17001120 RID: 4384
		// (get) Token: 0x0600A7D2 RID: 42962 RVA: 0x00068F9B File Offset: 0x0006719B
		// (set) Token: 0x0600A7D3 RID: 42963 RVA: 0x00068FA3 File Offset: 0x000671A3
		public BloomModel.Settings settings
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

		// Token: 0x0600A7D4 RID: 42964 RVA: 0x00068FAC File Offset: 0x000671AC
		public override void Reset()
		{
			this.m_Settings = BloomModel.Settings.defaultSettings;
		}

		// Token: 0x0400AB3D RID: 43837
		[SerializeField]
		private BloomModel.Settings m_Settings = BloomModel.Settings.defaultSettings;

		// Token: 0x02001BCE RID: 7118
		[Serializable]
		public struct BloomSettings
		{
			// Token: 0x17001121 RID: 4385
			// (get) Token: 0x0600A7D7 RID: 42967 RVA: 0x00068FDA File Offset: 0x000671DA
			// (set) Token: 0x0600A7D6 RID: 42966 RVA: 0x00068FCC File Offset: 0x000671CC
			public float thresholdLinear
			{
				get
				{
					return Mathf.GammaToLinearSpace(this.threshold);
				}
				set
				{
					this.threshold = Mathf.LinearToGammaSpace(value);
				}
			}

			// Token: 0x17001122 RID: 4386
			// (get) Token: 0x0600A7D8 RID: 42968 RVA: 0x003AB604 File Offset: 0x003A9804
			public static BloomModel.BloomSettings defaultSettings
			{
				get
				{
					return new BloomModel.BloomSettings
					{
						intensity = 0.5f,
						threshold = 1.1f,
						softKnee = 0.5f,
						radius = 4f,
						antiFlicker = false
					};
				}
			}

			// Token: 0x0400AB3E RID: 43838
			[Min(0f)]
			[Tooltip("Strength of the bloom filter.")]
			public float intensity;

			// Token: 0x0400AB3F RID: 43839
			[Min(0f)]
			[Tooltip("Filters out pixels under this level of brightness.")]
			public float threshold;

			// Token: 0x0400AB40 RID: 43840
			[Range(0f, 1f)]
			[Tooltip("Makes transition between under/over-threshold gradual (0 = hard threshold, 1 = soft threshold).")]
			public float softKnee;

			// Token: 0x0400AB41 RID: 43841
			[Range(1f, 7f)]
			[Tooltip("Changes extent of veiling effects in a screen resolution-independent fashion.")]
			public float radius;

			// Token: 0x0400AB42 RID: 43842
			[Tooltip("Reduces flashing noise with an additional filter.")]
			public bool antiFlicker;
		}

		// Token: 0x02001BCF RID: 7119
		[Serializable]
		public struct LensDirtSettings
		{
			// Token: 0x17001123 RID: 4387
			// (get) Token: 0x0600A7D9 RID: 42969 RVA: 0x003AB654 File Offset: 0x003A9854
			public static BloomModel.LensDirtSettings defaultSettings
			{
				get
				{
					return new BloomModel.LensDirtSettings
					{
						texture = null,
						intensity = 3f
					};
				}
			}

			// Token: 0x0400AB43 RID: 43843
			[Tooltip("Dirtiness texture to add smudges or dust to the lens.")]
			public Texture texture;

			// Token: 0x0400AB44 RID: 43844
			[Min(0f)]
			[Tooltip("Amount of lens dirtiness.")]
			public float intensity;
		}

		// Token: 0x02001BD0 RID: 7120
		[Serializable]
		public struct Settings
		{
			// Token: 0x17001124 RID: 4388
			// (get) Token: 0x0600A7DA RID: 42970 RVA: 0x003AB680 File Offset: 0x003A9880
			public static BloomModel.Settings defaultSettings
			{
				get
				{
					return new BloomModel.Settings
					{
						bloom = BloomModel.BloomSettings.defaultSettings,
						lensDirt = BloomModel.LensDirtSettings.defaultSettings
					};
				}
			}

			// Token: 0x0400AB45 RID: 43845
			public BloomModel.BloomSettings bloom;

			// Token: 0x0400AB46 RID: 43846
			public BloomModel.LensDirtSettings lensDirt;
		}
	}
}
