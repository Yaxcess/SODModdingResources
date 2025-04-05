using System;
using System.Collections.Generic;
using JSGames.UI.Util;

namespace JSGames.UI.TerrorMail
{
	// Token: 0x02001B67 RID: 7015
	public class UIMessageItem : UIMessagePopulator
	{
		// Token: 0x0400A8E8 RID: 43240
		public UIWidget _SenderWidget;

		// Token: 0x0400A8E9 RID: 43241
		public UIWidget _AnnouncementMessageWidget;

		// Token: 0x0400A8EA RID: 43242
		public UIWidget _ChallengeMessageWidget;

		// Token: 0x0400A8EB RID: 43243
		public UIWidget _MessageReplyCountWidget;

		// Token: 0x0400A8EC RID: 43244
		public UIWidget _GiftUnopenedWidget;

		// Token: 0x0400A8ED RID: 43245
		public UIWidget _GiftOpenedWidget;

		// Token: 0x0400A8EE RID: 43246
		public UIWidget _BuddyIconWidget;

		// Token: 0x0400A8EF RID: 43247
		public UIWidget _IgnoredIconWidget;

		// Token: 0x0400A8F0 RID: 43248
		public UIWidget _IgnoreBtn;

		// Token: 0x0400A8F1 RID: 43249
		public UIWidget _ReportBtn;

		// Token: 0x0400A8F2 RID: 43250
		public UIWidget _DeleteBtn;

		// Token: 0x0400A8F4 RID: 43252
		public int _MaxTextLength = 20;

		// Token: 0x0400A8F5 RID: 43253
		public string _TruncatedSymbolText = "...";

		// Token: 0x0400A8F6 RID: 43254
		public LocaleString _BuddyNameFallback = new LocaleString("A friend ");
	}
}
