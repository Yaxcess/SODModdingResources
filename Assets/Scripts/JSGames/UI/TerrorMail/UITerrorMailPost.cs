using System;
using JSGames.UI.Util;
using UnityEngine;
using UnityEngine.EventSystems;

namespace JSGames.UI.TerrorMail
{
	// Token: 0x02001B7C RID: 7036
	public class UITerrorMailPost : UI
	{

		// Token: 0x0400A986 RID: 43398
		public UITerrorMail _Board;

		// Token: 0x0400A987 RID: 43399
		public UIDropDown _DropDown;

		// Token: 0x0400A988 RID: 43400
		public int _MaxCharacters = 160;

		// Token: 0x0400A989 RID: 43401
		public LocaleString _MessageTooLongText = new LocaleString("That phrase doesn't fit.");

		// Token: 0x0400A98A RID: 43402
		public LocaleString _NoMatchesText = new LocaleString("(No matches found.)");

		// Token: 0x0400A98B RID: 43403
		public LocaleString _PostSucceededText = new LocaleString("Message posted.");

		// Token: 0x0400A98C RID: 43404
		public LocaleString _PostFailedText = new LocaleString("Unable to post your message. Please try again later.");

		// Token: 0x0400A98D RID: 43405
		public LocaleString _PostBlockedText = new LocaleString("This message has been blocked.");

		// Token: 0x0400A98E RID: 43406
		public LocaleString _PostAuthorizationFailedText = new LocaleString("You must authorize your account before you can post messages.");

		// Token: 0x0400A98F RID: 43407
		public float _TimeoutDuration = 15f;

		// Token: 0x0400A990 RID: 43408
		public LocaleString _TimeoutText = new LocaleString("Message cannot be posted at this time.");

		// Token: 0x0400A991 RID: 43409
		public int _SocialBuddyMessageAchievementID = 106;

		// Token: 0x0400A992 RID: 43410
		public UIAnim2D _ColorBkg;

		// Token: 0x0400A993 RID: 43411
		public UIWidget _CloseBtn;

		// Token: 0x0400A994 RID: 43412
		public UIWidget _PostBtn;

		// Token: 0x0400A995 RID: 43413
		public UIWidget _ClearBtn;

		// Token: 0x0400A996 RID: 43414
		public UIWidget _TxtCount;

		// Token: 0x0400A997 RID: 43415
		public UIEditBox _EditOpen;

		// Token: 0x0400A998 RID: 43416
		public UIToggleButton _PrivateToggle;

		// Token: 0x0400A999 RID: 43417
		public UIToggleButton _PublicToggle;
	}
}
