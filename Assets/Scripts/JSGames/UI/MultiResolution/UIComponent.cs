using System;
using UnityEngine;

namespace JSGames.UI.MultiResolution
{
	// Token: 0x02001B64 RID: 7012
	[Serializable]
	public class UIComponent
	{
		// Token: 0x0600A5D1 RID: 42449 RVA: 0x00067AF8 File Offset: 0x00065CF8
		public UIComponent(Component comp)
		{
			this.Type = comp.GetType().Name;
			this.ReadComponentData(comp);
		}

		// Token: 0x0600A5D2 RID: 42450 RVA: 0x00006173 File Offset: 0x00004373
		public virtual void ReadComponentData(Component comp)
		{
		}

		// Token: 0x0400A8E0 RID: 43232
		public string Type;
	}
}
