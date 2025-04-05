using System;

namespace UnityEngine.PostProcessing
{
	// Token: 0x02001BC5 RID: 7109
	[Serializable]
	public class AntialiasingModel : PostProcessingModel
	{
		// Token: 0x1700111C RID: 4380
		// (get) Token: 0x0600A7C9 RID: 42953 RVA: 0x00068F6A File Offset: 0x0006716A
		// (set) Token: 0x0600A7CA RID: 42954 RVA: 0x00068F72 File Offset: 0x00067172
		public AntialiasingModel.Settings settings
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

		// Token: 0x0600A7CB RID: 42955 RVA: 0x00068F7B File Offset: 0x0006717B
		public override void Reset()
		{
			this.m_Settings = AntialiasingModel.Settings.defaultSettings;
		}

		// Token: 0x0400AB22 RID: 43810
		[SerializeField]
		private AntialiasingModel.Settings m_Settings = AntialiasingModel.Settings.defaultSettings;

		// Token: 0x02001BC6 RID: 7110
		public enum Method
		{
			// Token: 0x0400AB24 RID: 43812
			Fxaa,
			// Token: 0x0400AB25 RID: 43813
			Taa
		}

		// Token: 0x02001BC7 RID: 7111
		public enum FxaaPreset
		{
			// Token: 0x0400AB27 RID: 43815
			ExtremePerformance,
			// Token: 0x0400AB28 RID: 43816
			Performance,
			// Token: 0x0400AB29 RID: 43817
			Default,
			// Token: 0x0400AB2A RID: 43818
			Quality,
			// Token: 0x0400AB2B RID: 43819
			ExtremeQuality
		}

		// Token: 0x02001BC8 RID: 7112
		[Serializable]
		public struct FxaaQualitySettings
		{
			// Token: 0x0400AB2C RID: 43820
			[Tooltip("The amount of desired sub-pixel aliasing removal. Effects the sharpeness of the output.")]
			[Range(0f, 1f)]
			public float subpixelAliasingRemovalAmount;

			// Token: 0x0400AB2D RID: 43821
			[Tooltip("The minimum amount of local contrast required to qualify a region as containing an edge.")]
			[Range(0.063f, 0.333f)]
			public float edgeDetectionThreshold;

			// Token: 0x0400AB2E RID: 43822
			[Tooltip("Local contrast adaptation value to disallow the algorithm from executing on the darker regions.")]
			[Range(0f, 0.0833f)]
			public float minimumRequiredLuminance;

			// Token: 0x0400AB2F RID: 43823
			public static AntialiasingModel.FxaaQualitySettings[] presets = new AntialiasingModel.FxaaQualitySettings[]
			{
				new AntialiasingModel.FxaaQualitySettings
				{
					subpixelAliasingRemovalAmount = 0f,
					edgeDetectionThreshold = 0.333f,
					minimumRequiredLuminance = 0.0833f
				},
				new AntialiasingModel.FxaaQualitySettings
				{
					subpixelAliasingRemovalAmount = 0.25f,
					edgeDetectionThreshold = 0.25f,
					minimumRequiredLuminance = 0.0833f
				},
				new AntialiasingModel.FxaaQualitySettings
				{
					subpixelAliasingRemovalAmount = 0.75f,
					edgeDetectionThreshold = 0.166f,
					minimumRequiredLuminance = 0.0833f
				},
				new AntialiasingModel.FxaaQualitySettings
				{
					subpixelAliasingRemovalAmount = 1f,
					edgeDetectionThreshold = 0.125f,
					minimumRequiredLuminance = 0.0625f
				},
				new AntialiasingModel.FxaaQualitySettings
				{
					subpixelAliasingRemovalAmount = 1f,
					edgeDetectionThreshold = 0.063f,
					minimumRequiredLuminance = 0.0312f
				}
			};
		}

		// Token: 0x02001BC9 RID: 7113
		[Serializable]
		public struct FxaaConsoleSettings
		{
			// Token: 0x0400AB30 RID: 43824
			[Tooltip("The amount of spread applied to the sampling coordinates while sampling for subpixel information.")]
			[Range(0.33f, 0.5f)]
			public float subpixelSpreadAmount;

			// Token: 0x0400AB31 RID: 43825
			[Tooltip("This value dictates how sharp the edges in the image are kept; a higher value implies sharper edges.")]
			[Range(2f, 8f)]
			public float edgeSharpnessAmount;

			// Token: 0x0400AB32 RID: 43826
			[Tooltip("The minimum amount of local contrast required to qualify a region as containing an edge.")]
			[Range(0.125f, 0.25f)]
			public float edgeDetectionThreshold;

			// Token: 0x0400AB33 RID: 43827
			[Tooltip("Local contrast adaptation value to disallow the algorithm from executing on the darker regions.")]
			[Range(0.04f, 0.06f)]
			public float minimumRequiredLuminance;

			// Token: 0x0400AB34 RID: 43828
			public static AntialiasingModel.FxaaConsoleSettings[] presets = new AntialiasingModel.FxaaConsoleSettings[]
			{
				new AntialiasingModel.FxaaConsoleSettings
				{
					subpixelSpreadAmount = 0.33f,
					edgeSharpnessAmount = 8f,
					edgeDetectionThreshold = 0.25f,
					minimumRequiredLuminance = 0.06f
				},
				new AntialiasingModel.FxaaConsoleSettings
				{
					subpixelSpreadAmount = 0.33f,
					edgeSharpnessAmount = 8f,
					edgeDetectionThreshold = 0.125f,
					minimumRequiredLuminance = 0.06f
				},
				new AntialiasingModel.FxaaConsoleSettings
				{
					subpixelSpreadAmount = 0.5f,
					edgeSharpnessAmount = 8f,
					edgeDetectionThreshold = 0.125f,
					minimumRequiredLuminance = 0.05f
				},
				new AntialiasingModel.FxaaConsoleSettings
				{
					subpixelSpreadAmount = 0.5f,
					edgeSharpnessAmount = 4f,
					edgeDetectionThreshold = 0.125f,
					minimumRequiredLuminance = 0.04f
				},
				new AntialiasingModel.FxaaConsoleSettings
				{
					subpixelSpreadAmount = 0.5f,
					edgeSharpnessAmount = 2f,
					edgeDetectionThreshold = 0.125f,
					minimumRequiredLuminance = 0.04f
				}
			};
		}

		// Token: 0x02001BCA RID: 7114
		[Serializable]
		public struct FxaaSettings
		{
			// Token: 0x1700111D RID: 4381
			// (get) Token: 0x0600A7CF RID: 42959 RVA: 0x003AB564 File Offset: 0x003A9764
			public static AntialiasingModel.FxaaSettings defaultSettings
			{
				get
				{
					return new AntialiasingModel.FxaaSettings
					{
						preset = AntialiasingModel.FxaaPreset.Default
					};
				}
			}

			// Token: 0x0400AB35 RID: 43829
			public AntialiasingModel.FxaaPreset preset;
		}

		// Token: 0x02001BCB RID: 7115
		[Serializable]
		public struct TaaSettings
		{
			// Token: 0x1700111E RID: 4382
			// (get) Token: 0x0600A7D0 RID: 42960 RVA: 0x003AB584 File Offset: 0x003A9784
			public static AntialiasingModel.TaaSettings defaultSettings
			{
				get
				{
					return new AntialiasingModel.TaaSettings
					{
						jitterSpread = 0.75f,
						sharpen = 0.3f,
						stationaryBlending = 0.95f,
						motionBlending = 0.85f
					};
				}
			}

			// Token: 0x0400AB36 RID: 43830
			[Tooltip("The diameter (in texels) inside which jitter samples are spread. Smaller values result in crisper but more aliased output, while larger values result in more stable but blurrier output.")]
			[Range(0.1f, 1f)]
			public float jitterSpread;

			// Token: 0x0400AB37 RID: 43831
			[Tooltip("Controls the amount of sharpening applied to the color buffer.")]
			[Range(0f, 3f)]
			public float sharpen;

			// Token: 0x0400AB38 RID: 43832
			[Tooltip("The blend coefficient for a stationary fragment. Controls the percentage of history sample blended into the final color.")]
			[Range(0f, 0.99f)]
			public float stationaryBlending;

			// Token: 0x0400AB39 RID: 43833
			[Tooltip("The blend coefficient for a fragment with significant motion. Controls the percentage of history sample blended into the final color.")]
			[Range(0f, 0.99f)]
			public float motionBlending;
		}

		// Token: 0x02001BCC RID: 7116
		[Serializable]
		public struct Settings
		{
			// Token: 0x1700111F RID: 4383
			// (get) Token: 0x0600A7D1 RID: 42961 RVA: 0x003AB5CC File Offset: 0x003A97CC
			public static AntialiasingModel.Settings defaultSettings
			{
				get
				{
					return new AntialiasingModel.Settings
					{
						method = AntialiasingModel.Method.Fxaa,
						fxaaSettings = AntialiasingModel.FxaaSettings.defaultSettings,
						taaSettings = AntialiasingModel.TaaSettings.defaultSettings
					};
				}
			}

			// Token: 0x0400AB3A RID: 43834
			public AntialiasingModel.Method method;

			// Token: 0x0400AB3B RID: 43835
			public AntialiasingModel.FxaaSettings fxaaSettings;

			// Token: 0x0400AB3C RID: 43836
			public AntialiasingModel.TaaSettings taaSettings;
		}
	}
}
