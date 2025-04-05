using System;

namespace UnityEngine.PostProcessing
{
	// Token: 0x02001BC2 RID: 7106
	[Serializable]
	public class AmbientOcclusionModel : PostProcessingModel
	{
		// Token: 0x1700111A RID: 4378
		// (get) Token: 0x0600A7C4 RID: 42948 RVA: 0x00068F39 File Offset: 0x00067139
		// (set) Token: 0x0600A7C5 RID: 42949 RVA: 0x00068F41 File Offset: 0x00067141
		public AmbientOcclusionModel.Settings settings
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

		// Token: 0x0600A7C6 RID: 42950 RVA: 0x00068F4A File Offset: 0x0006714A
		public override void Reset()
		{
			this.m_Settings = AmbientOcclusionModel.Settings.defaultSettings;
		}

		// Token: 0x0400AB15 RID: 43797
		[SerializeField]
		private AmbientOcclusionModel.Settings m_Settings = AmbientOcclusionModel.Settings.defaultSettings;

		// Token: 0x02001BC3 RID: 7107
		public enum SampleCount
		{
			// Token: 0x0400AB17 RID: 43799
			Lowest = 3,
			// Token: 0x0400AB18 RID: 43800
			Low = 6,
			// Token: 0x0400AB19 RID: 43801
			Medium = 10,
			// Token: 0x0400AB1A RID: 43802
			High = 16
		}

		// Token: 0x02001BC4 RID: 7108
		[Serializable]
		public struct Settings
		{
			// Token: 0x1700111B RID: 4379
			// (get) Token: 0x0600A7C8 RID: 42952 RVA: 0x003AB298 File Offset: 0x003A9498
			public static AmbientOcclusionModel.Settings defaultSettings
			{
				get
				{
					return new AmbientOcclusionModel.Settings
					{
						intensity = 1f,
						radius = 0.3f,
						sampleCount = AmbientOcclusionModel.SampleCount.Medium,
						downsampling = true,
						forceForwardCompatibility = false,
						ambientOnly = false,
						highPrecision = false
					};
				}
			}

			// Token: 0x0400AB1B RID: 43803
			[Range(0f, 4f)]
			[Tooltip("Degree of darkness produced by the effect.")]
			public float intensity;

			// Token: 0x0400AB1C RID: 43804
			[Min(0.0001f)]
			[Tooltip("Radius of sample points, which affects extent of darkened areas.")]
			public float radius;

			// Token: 0x0400AB1D RID: 43805
			[Tooltip("Number of sample points, which affects quality and performance.")]
			public AmbientOcclusionModel.SampleCount sampleCount;

			// Token: 0x0400AB1E RID: 43806
			[Tooltip("Halves the resolution of the effect to increase performance at the cost of visual quality.")]
			public bool downsampling;

			// Token: 0x0400AB1F RID: 43807
			[Tooltip("Forces compatibility with Forward rendered objects when working with the Deferred rendering path.")]
			public bool forceForwardCompatibility;

			// Token: 0x0400AB20 RID: 43808
			[Tooltip("Enables the ambient-only mode in that the effect only affects ambient lighting. This mode is only available with the Deferred rendering path and HDR rendering.")]
			public bool ambientOnly;

			// Token: 0x0400AB21 RID: 43809
			[Tooltip("Toggles the use of a higher precision depth texture with the forward rendering path (may impact performances). Has no effect with the deferred rendering path.")]
			public bool highPrecision;
		}
	}
}
