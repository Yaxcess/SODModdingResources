using System;
using System.Collections.Generic;
using JSGames.UI.Util;
using UnityEngine;
using UnityEngine.UI;

namespace JSGames.UI.TerrorMail
{
	// Token: 0x02001B68 RID: 7016
	public class UIMessagePopulator : UIToggleButton
	{
		// Token: 0x0400A8F7 RID: 43255
		protected static Dictionary<string, string> mCachedDisplayNames = new Dictionary<string, string>();

		// Token: 0x0400A8F8 RID: 43256
		public Text _TxtSubject;

		// Token: 0x0400A8F9 RID: 43257
		public Text _TxtReceivedDate;

		// Token: 0x0400A8FA RID: 43258
		public Text _TxtExpirationTimer;

		// Token: 0x0400A8FB RID: 43259
		public string _DateTimeFormat = "MMM dd, yyyy hh:mm tt";

		// Token: 0x0400A8FC RID: 43260
		public TagAndDefaultText[] _TagAndDefaultText;

		// Token: 0x0400A8FD RID: 43261
		public LocaleString _ChallengeSubjectText = new LocaleString(" has sent you a challenge!");

		// Token: 0x0400A8FE RID: 43262
		public ChallengeInviteMessageData[] _ChallengeMessage;

		// Token: 0x0400A904 RID: 43268
		[HideInInspector]
		public string[] mKeys = new string[0];

		// Token: 0x0400A905 RID: 43269
		[HideInInspector]
		public int mUsernamesToRetrieve;
	}
}
