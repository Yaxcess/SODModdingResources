using System;

namespace UnityEngine.PostProcessing
{
	// Token: 0x02001BED RID: 7149
	[Serializable]
	public class GrainModel : PostProcessingModel
	{
		// Token: 0x1700113F RID: 4415
		// (get) Token: 0x0600A80E RID: 43022 RVA: 0x000691B8 File Offset: 0x000673B8
		// (set) Token: 0x0600A80F RID: 43023 RVA: 0x000691C0 File Offset: 0x000673C0
		public GrainModel.Settings settings
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

		// Token: 0x0600A810 RID: 43024 RVA: 0x000691C9 File Offset: 0x000673C9
		public override void Reset()
		{
			this.m_Settings = GrainModel.Settings.defaultSettings;
		}

		// Token: 0x0400ABB3 RID: 43955
		[SerializeField]
		private GrainModel.Settings m_Settings = GrainModel.Settings.defaultSettings;

		// Token: 0x02001BEE RID: 7150
		[Serializable]
		public struct Settings
		{
			// Token: 0x17001140 RID: 4416
			// (get) Token: 0x0600A812 RID: 43026 RVA: 0x003ABD68 File Offset: 0x003A9F68
			public static GrainModel.Settings defaultSettings
			{
				get
				{
					return new GrainModel.Settings
					{
						colored = true,
						intensity = 0.5f,
						size = 1f,
						luminanceContribution = 0.8f
					};
				}
			}

			// Token: 0x0400ABB4 RID: 43956
			[Tooltip("Enable the use of colored grain.")]
			public bool colored;

			// Token: 0x0400ABB5 RID: 43957
			[Range(0f, 1f)]
			[Tooltip("Grain strength. Higher means more visible grain.")]
			public float intensity;

			// Token: 0x0400ABB6 RID: 43958
			[Range(0.3f, 3f)]
			[Tooltip("Grain particle size.")]
			public float size;

			// Token: 0x0400ABB7 RID: 43959
			[Range(0f, 1f)]
			[Tooltip("Controls the noisiness response curve based on scene luminance. Lower values mean less noise in dark areas.")]
			public float luminanceContribution;
		}
	}
}
