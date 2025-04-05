using System;

namespace UnityEngine.PostProcessing
{
	// Token: 0x02001BF8 RID: 7160
	[Serializable]
	public class UserLutModel : PostProcessingModel
	{
		// Token: 0x17001145 RID: 4421
		// (get) Token: 0x0600A81D RID: 43037 RVA: 0x0006924B File Offset: 0x0006744B
		// (set) Token: 0x0600A81E RID: 43038 RVA: 0x00069253 File Offset: 0x00067453
		public UserLutModel.Settings settings
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

		// Token: 0x0600A81F RID: 43039 RVA: 0x0006925C File Offset: 0x0006745C
		public override void Reset()
		{
			this.m_Settings = UserLutModel.Settings.defaultSettings;
		}

		// Token: 0x0400ABD3 RID: 43987
		[SerializeField]
		private UserLutModel.Settings m_Settings = UserLutModel.Settings.defaultSettings;

		// Token: 0x02001BF9 RID: 7161
		[Serializable]
		public struct Settings
		{
			// Token: 0x17001146 RID: 4422
			// (get) Token: 0x0600A821 RID: 43041 RVA: 0x003ABEB8 File Offset: 0x003AA0B8
			public static UserLutModel.Settings defaultSettings
			{
				get
				{
					return new UserLutModel.Settings
					{
						lut = null,
						contribution = 1f
					};
				}
			}

			// Token: 0x0400ABD4 RID: 43988
			[Tooltip("Custom lookup texture (strip format, e.g. 256x16).")]
			public Texture2D lut;

			// Token: 0x0400ABD5 RID: 43989
			[Range(0f, 1f)]
			[Tooltip("Blending factor.")]
			public float contribution;
		}
	}
}
