using System;
using UnityEngine;
using UnityEngine.EventSystems;

namespace JSGames.UI
{
	// Token: 0x02001B43 RID: 6979
	public class UIGenericDB : UI
	{

		// Token: 0x0400A806 RID: 43014
		public UIButton _BtnYes;

		// Token: 0x0400A807 RID: 43015
		public UIButton _BtnNo;

		// Token: 0x0400A808 RID: 43016
		public UIButton _BtnOK;

		// Token: 0x0400A809 RID: 43017
		public UIButton _BtnClose;

		// Token: 0x0400A80A RID: 43018
		public UIWidget _TxtDialog;

		// Token: 0x0400A80B RID: 43019
		public UIWidget _TxtTitle;

		// Token: 0x0400A80C RID: 43020
		[SerializeField]
		private AudioClip _DialogVO;

		// Token: 0x0400A80D RID: 43021
		public string _YesMessage = "";

		// Token: 0x0400A80E RID: 43022
		public string _NoMessage = "";

		// Token: 0x0400A80F RID: 43023
		public string _OKMessage = "";

		// Token: 0x0400A810 RID: 43024
		public string _CloseMessage = "";

		// Token: 0x0400A811 RID: 43025
		public string _TextMessage = "";

		// Token: 0x0400A812 RID: 43026
		public string _MovieMessage = "";

		// Token: 0x0400A813 RID: 43027
		public string _ButtonClicked = "";

		// Token: 0x0400A814 RID: 43028
		public GameObject _MessageObject;

		// Token: 0x0400A815 RID: 43029
		public int _MessageIdentifier = -1;
	}
}
