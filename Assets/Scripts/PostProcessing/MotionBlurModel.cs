using System;

namespace UnityEngine.PostProcessing
{
	// Token: 0x02001BEF RID: 7151
	[Serializable]
	public class MotionBlurModel : PostProcessingModel
	{
		// Token: 0x17001141 RID: 4417
		// (get) Token: 0x0600A813 RID: 43027 RVA: 0x000691E9 File Offset: 0x000673E9
		// (set) Token: 0x0600A814 RID: 43028 RVA: 0x000691F1 File Offset: 0x000673F1
		public MotionBlurModel.Settings settings
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

		// Token: 0x0600A815 RID: 43029 RVA: 0x000691FA File Offset: 0x000673FA
		public override void Reset()
		{
			this.m_Settings = MotionBlurModel.Settings.defaultSettings;
		}

		// Token: 0x0400ABB8 RID: 43960
		[SerializeField]
		private MotionBlurModel.Settings m_Settings = MotionBlurModel.Settings.defaultSettings;

		// Token: 0x02001BF0 RID: 7152
		[Serializable]
		public struct Settings
		{
			// Token: 0x17001142 RID: 4418
			// (get) Token: 0x0600A817 RID: 43031 RVA: 0x003ABDAC File Offset: 0x003A9FAC
			public static MotionBlurModel.Settings defaultSettings
			{
				get
				{
					return new MotionBlurModel.Settings
					{
						shutterAngle = 270f,
						sampleCount = 10,
						frameBlending = 0f
					};
				}
			}

			// Token: 0x0400ABB9 RID: 43961
			[Range(0f, 360f)]
			[Tooltip("The angle of rotary shutter. Larger values give longer exposure.")]
			public float shutterAngle;

			// Token: 0x0400ABBA RID: 43962
			[Range(4f, 32f)]
			[Tooltip("The amount of sample points, which affects quality and performances.")]
			public int sampleCount;

			// Token: 0x0400ABBB RID: 43963
			[Range(0f, 1f)]
			[Tooltip("The strength of multiple frame blending. The opacity of preceding frames are determined from this coefficient and time differences.")]
			public float frameBlending;
		}
	}
}
