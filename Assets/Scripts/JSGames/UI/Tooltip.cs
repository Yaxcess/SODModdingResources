using System;
using UnityEngine;
using UnityEngine.UI;

namespace JSGames.UI
{
	// Token: 0x02001B25 RID: 6949
	public class Tooltip : KAMonoBase
	{

		// Token: 0x0400A769 RID: 42857
		public float _Timer = 1f;

		// Token: 0x0400A76D RID: 42861
		[SerializeField]
		private Image mBackground;

		// Token: 0x0400A76E RID: 42862
		[SerializeField]
		private Text mLabel;
	}
}
