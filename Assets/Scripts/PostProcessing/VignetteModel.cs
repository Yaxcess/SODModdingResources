using System;

namespace UnityEngine.PostProcessing
{
	// Token: 0x02001BFA RID: 7162
	[Serializable]
	public class VignetteModel : PostProcessingModel
	{
		// Token: 0x17001147 RID: 4423
		// (get) Token: 0x0600A822 RID: 43042 RVA: 0x0006927C File Offset: 0x0006747C
		// (set) Token: 0x0600A823 RID: 43043 RVA: 0x00069284 File Offset: 0x00067484
		public VignetteModel.Settings settings
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

		// Token: 0x0600A824 RID: 43044 RVA: 0x0006928D File Offset: 0x0006748D
		public override void Reset()
		{
			this.m_Settings = VignetteModel.Settings.defaultSettings;
		}

		// Token: 0x0400ABD6 RID: 43990
		[SerializeField]
		private VignetteModel.Settings m_Settings = VignetteModel.Settings.defaultSettings;

		// Token: 0x02001BFB RID: 7163
		public enum Mode
		{
			// Token: 0x0400ABD8 RID: 43992
			Classic,
			// Token: 0x0400ABD9 RID: 43993
			Masked
		}

		// Token: 0x02001BFC RID: 7164
		[Serializable]
		public struct Settings
		{
			// Token: 0x17001148 RID: 4424
			// (get) Token: 0x0600A826 RID: 43046 RVA: 0x003ABEE4 File Offset: 0x003AA0E4
			public static VignetteModel.Settings defaultSettings
			{
				get
				{
					return new VignetteModel.Settings
					{
						mode = VignetteModel.Mode.Classic,
						color = new Color(0f, 0f, 0f, 1f),
						center = new Vector2(0.5f, 0.5f),
						intensity = 0.45f,
						smoothness = 0.2f,
						roundness = 1f,
						mask = null,
						opacity = 1f,
						rounded = false
					};
				}
			}

			// Token: 0x0400ABDA RID: 43994
			[Tooltip("Use the \"Classic\" mode for parametric controls. Use the \"Masked\" mode to use your own texture mask.")]
			public VignetteModel.Mode mode;

			// Token: 0x0400ABDB RID: 43995
			[ColorUsage(false)]
			[Tooltip("Vignette color. Use the alpha channel for transparency.")]
			public Color color;

			// Token: 0x0400ABDC RID: 43996
			[Tooltip("Sets the vignette center point (screen center is [0.5,0.5]).")]
			public Vector2 center;

			// Token: 0x0400ABDD RID: 43997
			[Range(0f, 1f)]
			[Tooltip("Amount of vignetting on screen.")]
			public float intensity;

			// Token: 0x0400ABDE RID: 43998
			[Range(0.01f, 1f)]
			[Tooltip("Smoothness of the vignette borders.")]
			public float smoothness;

			// Token: 0x0400ABDF RID: 43999
			[Range(0f, 1f)]
			[Tooltip("Lower values will make a square-ish vignette.")]
			public float roundness;

			// Token: 0x0400ABE0 RID: 44000
			[Tooltip("A black and white mask to use as a vignette.")]
			public Texture mask;

			// Token: 0x0400ABE1 RID: 44001
			[Range(0f, 1f)]
			[Tooltip("Mask opacity.")]
			public float opacity;

			// Token: 0x0400ABE2 RID: 44002
			[Tooltip("Should the vignette be perfectly round or be dependent on the current aspect ratio?")]
			public bool rounded;
		}
	}
}
