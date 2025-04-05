using System;

namespace UnityEngine.PostProcessing
{
	// Token: 0x02001BE3 RID: 7139
	[Serializable]
	public class DepthOfFieldModel : PostProcessingModel
	{
		// Token: 0x17001137 RID: 4407
		// (get) Token: 0x0600A7FA RID: 43002 RVA: 0x000690F4 File Offset: 0x000672F4
		// (set) Token: 0x0600A7FB RID: 43003 RVA: 0x000690FC File Offset: 0x000672FC
		public DepthOfFieldModel.Settings settings
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

		// Token: 0x0600A7FC RID: 43004 RVA: 0x00069105 File Offset: 0x00067305
		public override void Reset()
		{
			this.m_Settings = DepthOfFieldModel.Settings.defaultSettings;
		}

		// Token: 0x0400AB96 RID: 43926
		[SerializeField]
		private DepthOfFieldModel.Settings m_Settings = DepthOfFieldModel.Settings.defaultSettings;

		// Token: 0x02001BE4 RID: 7140
		public enum KernelSize
		{
			// Token: 0x0400AB98 RID: 43928
			Small,
			// Token: 0x0400AB99 RID: 43929
			Medium,
			// Token: 0x0400AB9A RID: 43930
			Large,
			// Token: 0x0400AB9B RID: 43931
			VeryLarge
		}

		// Token: 0x02001BE5 RID: 7141
		[Serializable]
		public struct Settings
		{
			// Token: 0x17001138 RID: 4408
			// (get) Token: 0x0600A7FE RID: 43006 RVA: 0x003ABC58 File Offset: 0x003A9E58
			public static DepthOfFieldModel.Settings defaultSettings
			{
				get
				{
					return new DepthOfFieldModel.Settings
					{
						focusDistance = 10f,
						aperture = 5.6f,
						focalLength = 50f,
						useCameraFov = false,
						kernelSize = DepthOfFieldModel.KernelSize.Medium
					};
				}
			}

			// Token: 0x0400AB9C RID: 43932
			[Min(0.1f)]
			[Tooltip("Distance to the point of focus.")]
			public float focusDistance;

			// Token: 0x0400AB9D RID: 43933
			[Range(0.05f, 32f)]
			[Tooltip("Ratio of aperture (known as f-stop or f-number). The smaller the value is, the shallower the depth of field is.")]
			public float aperture;

			// Token: 0x0400AB9E RID: 43934
			[Range(1f, 300f)]
			[Tooltip("Distance between the lens and the film. The larger the value is, the shallower the depth of field is.")]
			public float focalLength;

			// Token: 0x0400AB9F RID: 43935
			[Tooltip("Calculate the focal length automatically from the field-of-view value set on the camera. Using this setting isn't recommended.")]
			public bool useCameraFov;

			// Token: 0x0400ABA0 RID: 43936
			[Tooltip("Convolution kernel size of the bokeh filter, which determines the maximum radius of bokeh. It also affects the performance (the larger the kernel is, the longer the GPU time is required).")]
			public DepthOfFieldModel.KernelSize kernelSize;
		}
	}
}
