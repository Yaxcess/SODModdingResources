using System;

namespace UnityEngine.PostProcessing
{
	// Token: 0x02001BE6 RID: 7142
	[Serializable]
	public class DitheringModel : PostProcessingModel
	{
		// Token: 0x17001139 RID: 4409
		// (get) Token: 0x0600A7FF RID: 43007 RVA: 0x00069125 File Offset: 0x00067325
		// (set) Token: 0x0600A800 RID: 43008 RVA: 0x0006912D File Offset: 0x0006732D
		public DitheringModel.Settings settings
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

		// Token: 0x0600A801 RID: 43009 RVA: 0x00069136 File Offset: 0x00067336
		public override void Reset()
		{
			this.m_Settings = DitheringModel.Settings.defaultSettings;
		}

		// Token: 0x0400ABA1 RID: 43937
		[SerializeField]
		private DitheringModel.Settings m_Settings = DitheringModel.Settings.defaultSettings;

		// Token: 0x02001BE7 RID: 7143
		[Serializable]
		public struct Settings
		{
			// Token: 0x1700113A RID: 4410
			// (get) Token: 0x0600A803 RID: 43011 RVA: 0x003ABCA4 File Offset: 0x003A9EA4
			public static DitheringModel.Settings defaultSettings
			{
				get
				{
					return default(DitheringModel.Settings);
				}
			}
		}
	}
}
