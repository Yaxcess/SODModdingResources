using System;

namespace UnityEngine.PostProcessing
{
	// Token: 0x02001BEB RID: 7147
	[Serializable]
	public class FogModel : PostProcessingModel
	{
		// Token: 0x1700113D RID: 4413
		// (get) Token: 0x0600A809 RID: 43017 RVA: 0x00069187 File Offset: 0x00067387
		// (set) Token: 0x0600A80A RID: 43018 RVA: 0x0006918F File Offset: 0x0006738F
		public FogModel.Settings settings
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

		// Token: 0x0600A80B RID: 43019 RVA: 0x00069198 File Offset: 0x00067398
		public override void Reset()
		{
			this.m_Settings = FogModel.Settings.defaultSettings;
		}

		// Token: 0x0400ABB1 RID: 43953
		[SerializeField]
		private FogModel.Settings m_Settings = FogModel.Settings.defaultSettings;

		// Token: 0x02001BEC RID: 7148
		[Serializable]
		public struct Settings
		{
			// Token: 0x1700113E RID: 4414
			// (get) Token: 0x0600A80D RID: 43021 RVA: 0x003ABD48 File Offset: 0x003A9F48
			public static FogModel.Settings defaultSettings
			{
				get
				{
					return new FogModel.Settings
					{
						excludeSkybox = true
					};
				}
			}

			// Token: 0x0400ABB2 RID: 43954
			[Tooltip("Should the fog affect the skybox?")]
			public bool excludeSkybox;
		}
	}
}
