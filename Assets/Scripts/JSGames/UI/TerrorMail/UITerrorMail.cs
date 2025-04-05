using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using JSGames.UI.Util;
using UnityEngine;
using UnityEngine.EventSystems;

namespace JSGames.UI.TerrorMail
{
	// Token: 0x02001B6D RID: 7021
	public class UITerrorMail : UI
	{
		public string _UiChatRegisterNowPath;

		// Token: 0x0400A911 RID: 43281
		public MessageListInstance pMessageBoard;

		// Token: 0x0400A912 RID: 43282
		public UITerrorMailMenu _Menu;

		// Token: 0x0400A913 RID: 43283
		public UITerrorMailMessageThread _ThreadUI;

		// Token: 0x0400A914 RID: 43284
		public UITerrorMailTabMenu _TabUI;

		// Token: 0x0400A915 RID: 43285
		public LocaleString _DeleteMessageTitleText = new LocaleString("Delete this message?");

		// Token: 0x0400A916 RID: 43286
		public LocaleString _DeleteMessageText = new LocaleString("Are you sure you want to delete this message?");

		// Token: 0x0400A917 RID: 43287
		public LocaleString _IgnorePlayerTitleText = new LocaleString("Ignore this player?");

		// Token: 0x0400A918 RID: 43288
		public LocaleString _IgnorePlayerText = new LocaleString("Are you sure you'd like to ignore this person?");

		// Token: 0x0400A919 RID: 43289
		public LocaleString _GenericErrorText = new LocaleString("There was an error connecting to the server. Please try again.");

		// Token: 0x0400A91A RID: 43290
		public LocaleString _NeedPetText = new LocaleString("You need a dragon to play.");

		// Token: 0x0400A91B RID: 43291
		public LocaleString _MessageUnavailableText = new LocaleString("This message is not available.");

		// Token: 0x0400A91C RID: 43292
		public LocaleString _NotInMMORoomText;

		// Token: 0x0400A91D RID: 43293
		public LocaleString _NoDisplayNameText = new LocaleString("A friend");

		// Token: 0x0400A91E RID: 43294
		public TagAndDefaultText[] _TagAndDefaultText;

		// Token: 0x0400A91F RID: 43295
		public NPCFriendData[] _NPCFriends;

		// Token: 0x0400A920 RID: 43296
		public UIWidget _CloseBtn;

		// Token: 0x0400A921 RID: 43297
		public UIWidget _PostBtn;

		// Token: 0x0400A922 RID: 43298
		public UIWidget _NoMessageTxtItem;

		// Token: 0x0400A923 RID: 43299
		public UIWidget _CalendarButton;

		// Token: 0x0400A924 RID: 43300
		public string _MyMessageFilterName = "OnlineProfile";

		// Token: 0x0400A925 RID: 43301
		public string _OthersMessageFilterName = "OnlineBuddyProfile";

		// Token: 0x0400A926 RID: 43302
		public string _GiftMessageTemplateName = "MessageGift";

		// Token: 0x0400A927 RID: 43303
		public string _AnnouncementMessageTemplateName = "MessageAnnouncement";

		// Token: 0x0400A928 RID: 43304
		public string _AchievementMessageTemplateName = "MessageAchievement";

		// Token: 0x0400A929 RID: 43305
		public string _SocialMessageTemplateName = "MessageBuddy";

		// Token: 0x0400A92A RID: 43306
		public string _ChallengeMessageTemplateName = "MessageChallenge";

		// Token: 0x0400A92B RID: 43307
		public UIMessagePopulator _ChallengeForm;

		// Token: 0x0400A92C RID: 43308
		public UITerrorMailMessagesChallengeWon _ChallengeResultsForm;

		// Token: 0x0400A92D RID: 43309
		public UIMessagePopulator _ThreadUpdateForm;

		// Token: 0x0400A92F RID: 43311
		public UIMessageItem _MessageThreadItemTemplate;

		// Token: 0x0400A930 RID: 43312
		public UIMessageItem _MessageThreadReplyItemTemplate;

		// Token: 0x0400A931 RID: 43313
		public UIMessageItem _MessageListItemTemplate;

		// Token: 0x0400A932 RID: 43314
		public UITerrorMailMessageGifts _GiftForm;

		// Token: 0x0400A933 RID: 43315
		public UIMessagePopulator _AnnouncementForm;

		// Token: 0x0400A934 RID: 43316
		public UIMenu _AchievementsUIMenu;

		// Token: 0x0400A935 RID: 43317
		public UISystemMessage _AchievementsUIPopulator;

		// Token: 0x0400A936 RID: 43318
		public int _AcceptChallengeAchievementID = 133;

		// Token: 0x0400A937 RID: 43319
		public LocaleString _AllTabNoMessageText = new LocaleString("No Messages To Display");

		// Token: 0x0400A938 RID: 43320
		public LocaleString _MessageTabNoMessageText = new LocaleString("No Player Messages To Display");

		// Token: 0x0400A939 RID: 43321
		public LocaleString _ChallengeTabNoMessageText = new LocaleString("No Challenge Messages To Display");

		// Token: 0x0400A93A RID: 43322
		public LocaleString _GiftTabNoMessageText = new LocaleString("No Gift Messages To Display");

		// Token: 0x0400A93B RID: 43323
		public LocaleString _SocialTabNoMessageText = new LocaleString("No Social Messages To Display");

		// Token: 0x0400A93C RID: 43324
		public LocaleString _AchievementTabNoMessageText = new LocaleString("No Achievement Messages To Display");

		// Token: 0x0400A93D RID: 43325
		protected LocaleString noMessageText;

		// Token: 0x0400A93E RID: 43326
		public string _PostUIDBPath = "RS_DATA/PfUINewMessageDB.unity3d/PfUINewMessageDB";

		// Token: 0x0400A93F RID: 43327
		public UITerrorMailPost _PostUI;

		// Token: 0x0400A941 RID: 43329
		protected bool mLoading = true;

		// Token: 0x0400A942 RID: 43330
		protected UIWidget mSelectedItem;

		// Token: 0x0400A943 RID: 43331
		protected MessageInfo mMessageInfo;

		// Token: 0x0400A944 RID: 43332
		protected Message mSelectedMessage;

		// Token: 0x0400A945 RID: 43333
		protected List<object> mCombinedListMessages = new List<object>();
	}
}
