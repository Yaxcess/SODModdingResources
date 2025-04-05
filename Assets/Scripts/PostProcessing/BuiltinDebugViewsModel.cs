using System;

namespace UnityEngine.PostProcessing
{
	// Token: 0x02001BD1 RID: 7121
	[Serializable]
	public class BuiltinDebugViewsModel : PostProcessingModel
	{
		// Token: 0x17001125 RID: 4389
		// (get) Token: 0x0600A7DB RID: 42971 RVA: 0x00068FE7 File Offset: 0x000671E7
		// (set) Token: 0x0600A7DC RID: 42972 RVA: 0x00068FEF File Offset: 0x000671EF
		public BuiltinDebugViewsModel.Settings settings
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

		// Token: 0x17001126 RID: 4390
		// (get) Token: 0x0600A7DD RID: 42973 RVA: 0x00068FF8 File Offset: 0x000671F8
		public bool willInterrupt
		{
			get
			{
				return !this.IsModeActive(BuiltinDebugViewsModel.Mode.None) && !this.IsModeActive(BuiltinDebugViewsModel.Mode.EyeAdaptation) && !this.IsModeActive(BuiltinDebugViewsModel.Mode.PreGradingLog) && !this.IsModeActive(BuiltinDebugViewsModel.Mode.LogLut) && !this.IsModeActive(BuiltinDebugViewsModel.Mode.UserLut);
			}
		}

		// Token: 0x0600A7DE RID: 42974 RVA: 0x0006902B File Offset: 0x0006722B
		public override void Reset()
		{
			this.settings = BuiltinDebugViewsModel.Settings.defaultSettings;
		}

		// Token: 0x0600A7DF RID: 42975 RVA: 0x00069038 File Offset: 0x00067238
		public bool IsModeActive(BuiltinDebugViewsModel.Mode mode)
		{
			return this.m_Settings.mode == mode;
		}

		// Token: 0x0400AB47 RID: 43847
		[SerializeField]
		private BuiltinDebugViewsModel.Settings m_Settings = BuiltinDebugViewsModel.Settings.defaultSettings;

		// Token: 0x02001BD2 RID: 7122
		[Serializable]
		public struct DepthSettings
		{
			// Token: 0x17001127 RID: 4391
			// (get) Token: 0x0600A7E1 RID: 42977 RVA: 0x003AB6B0 File Offset: 0x003A98B0
			public static BuiltinDebugViewsModel.DepthSettings defaultSettings
			{
				get
				{
					return new BuiltinDebugViewsModel.DepthSettings
					{
						scale = 1f
					};
				}
			}

			// Token: 0x0400AB48 RID: 43848
			[Range(0f, 1f)]
			[Tooltip("Scales the camera far plane before displaying the depth map.")]
			public float scale;
		}

		// Token: 0x02001BD3 RID: 7123
		[Serializable]
		public struct MotionVectorsSettings
		{
			// Token: 0x17001128 RID: 4392
			// (get) Token: 0x0600A7E2 RID: 42978 RVA: 0x003AB6D4 File Offset: 0x003A98D4
			public static BuiltinDebugViewsModel.MotionVectorsSettings defaultSettings
			{
				get
				{
					return new BuiltinDebugViewsModel.MotionVectorsSettings
					{
						sourceOpacity = 1f,
						motionImageOpacity = 0f,
						motionImageAmplitude = 16f,
						motionVectorsOpacity = 1f,
						motionVectorsResolution = 24,
						motionVectorsAmplitude = 64f
					};
				}
			}

			// Token: 0x0400AB49 RID: 43849
			[Range(0f, 1f)]
			[Tooltip("Opacity of the source render.")]
			public float sourceOpacity;

			// Token: 0x0400AB4A RID: 43850
			[Range(0f, 1f)]
			[Tooltip("Opacity of the per-pixel motion vector colors.")]
			public float motionImageOpacity;

			// Token: 0x0400AB4B RID: 43851
			[Min(0f)]
			[Tooltip("Because motion vectors are mainly very small vectors, you can use this setting to make them more visible.")]
			public float motionImageAmplitude;

			// Token: 0x0400AB4C RID: 43852
			[Range(0f, 1f)]
			[Tooltip("Opacity for the motion vector arrows.")]
			public float motionVectorsOpacity;

			// Token: 0x0400AB4D RID: 43853
			[Range(8f, 64f)]
			[Tooltip("The arrow density on screen.")]
			public int motionVectorsResolution;

			// Token: 0x0400AB4E RID: 43854
			[Min(0f)]
			[Tooltip("Tweaks the arrows length.")]
			public float motionVectorsAmplitude;
		}

		// Token: 0x02001BD4 RID: 7124
		public enum Mode
		{
			// Token: 0x0400AB50 RID: 43856
			None,
			// Token: 0x0400AB51 RID: 43857
			Depth,
			// Token: 0x0400AB52 RID: 43858
			Normals,
			// Token: 0x0400AB53 RID: 43859
			MotionVectors,
			// Token: 0x0400AB54 RID: 43860
			AmbientOcclusion,
			// Token: 0x0400AB55 RID: 43861
			EyeAdaptation,
			// Token: 0x0400AB56 RID: 43862
			FocusPlane,
			// Token: 0x0400AB57 RID: 43863
			PreGradingLog,
			// Token: 0x0400AB58 RID: 43864
			LogLut,
			// Token: 0x0400AB59 RID: 43865
			UserLut
		}

		// Token: 0x02001BD5 RID: 7125
		[Serializable]
		public struct Settings
		{
			// Token: 0x17001129 RID: 4393
			// (get) Token: 0x0600A7E3 RID: 42979 RVA: 0x003AB730 File Offset: 0x003A9930
			public static BuiltinDebugViewsModel.Settings defaultSettings
			{
				get
				{
					return new BuiltinDebugViewsModel.Settings
					{
						mode = BuiltinDebugViewsModel.Mode.None,
						depth = BuiltinDebugViewsModel.DepthSettings.defaultSettings,
						motionVectors = BuiltinDebugViewsModel.MotionVectorsSettings.defaultSettings
					};
				}
			}

			// Token: 0x0400AB5A RID: 43866
			public BuiltinDebugViewsModel.Mode mode;

			// Token: 0x0400AB5B RID: 43867
			public BuiltinDebugViewsModel.DepthSettings depth;

			// Token: 0x0400AB5C RID: 43868
			public BuiltinDebugViewsModel.MotionVectorsSettings motionVectors;
		}
	}
}
