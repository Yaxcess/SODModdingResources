using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// Token: 0x02000ACE RID: 2766
public class UiChatHistory : KAUI
{
	public static bool _IsVisible = true;

	// Token: 0x0400413A RID: 16698
	public static GameObject _Listener;

	// Token: 0x04004140 RID: 16704
	public const string DEFAULT_BLOCKED_TEXT_COLOR = "FF0000";

	// Token: 0x04004145 RID: 16709
	public static bool mFade = false;

	// Token: 0x04004146 RID: 16710
	public LocaleString _SystemText = new LocaleString("[c]System");

	// Token: 0x04004147 RID: 16711
	public Vector3 _ChatWindowPos;

	// Token: 0x04004148 RID: 16712
	public Vector3 _ChatExpandBtnPos;

	// Token: 0x04004149 RID: 16713
	public Vector2 _ChatWindowMaxSize = new Vector2(500f, 300f);

	// Token: 0x0400414A RID: 16714
	public float _FlashDuration = 2f;

	// Token: 0x0400414B RID: 16715
	public List<KAWidget> _WidgetsToFlash;

	// Token: 0x0400414C RID: 16716
	public List<UiChatHistory.ChatTabFlashInfo> _ChatTabFlashInfo;

	// Token: 0x0400414D RID: 16717
	public UiMessageLog _UiMessageLog;

	// Token: 0x0400414E RID: 16718
	public KAUIMenu _ChatMenu;

	// Token: 0x0400414F RID: 16719
	public KAScrollBar _ScrollBar;

	// Token: 0x04004150 RID: 16720
	public KAWidget _ChatBackground;

	// Token: 0x04004151 RID: 16721
	public KAWidget _DragBtn;

	// Token: 0x04004152 RID: 16722
	public KAEditBox _ChatBox;

	// Token: 0x04004153 RID: 16723
	public int _ChatEntryEndPadding = 3;

	// Token: 0x04004154 RID: 16724
	public int _ID = 1000;

	// Token: 0x04004155 RID: 16725
	public string _NameSeparator = ">";

	// Token: 0x04004156 RID: 16726
	public string _SystemMessagesExcludedScene = "DragonRacingDO";

	// Token: 0x04004157 RID: 16727
	public string _RoomChatOptionSceneName = "DragonRacingDO";

	// Token: 0x04004158 RID: 16728
	public LocaleString _TitleText;

	// Token: 0x04004159 RID: 16729
	public UITextList _TextList;

	// Token: 0x0400415A RID: 16730
	public bool _ExcludeSystemMessages;

	// Token: 0x0400415B RID: 16731
	public bool _ClearChatOnSceneLoad = true;

	// Token: 0x0400415C RID: 16732
	public int _MaxChatCharacters = 80;

	// Token: 0x0400415D RID: 16733
	public LocaleString _TouchInputText = new LocaleString("Tap");

	// Token: 0x0400415E RID: 16734
	public LocaleString _NonTouchInputText = new LocaleString("Click");

	// Token: 0x0400415F RID: 16735
	public LocaleString _SystemMessageActionText = new LocaleString("[[input]] [-]HERE[c] to [[action]]");

	// Token: 0x04004160 RID: 16736
	public LocaleString _BlockedWordWarningText = new LocaleString("Stoick > We do not allow that type of language in School of Dragons. Please do not use iswords like that!");

	// Token: 0x04004161 RID: 16737
	public LocaleString _ServerErrorText = new LocaleString("Server error.");

	// Token: 0x04004162 RID: 16738
	public LocaleString _ServerErrorTitleText = new LocaleString("Error");

	// Token: 0x04004163 RID: 16739
	public LocaleString _MultiplayerDisabledOnDeviceText = new LocaleString("You need to turn multiplayer on. You can do that in your settings.");

	// Token: 0x04004164 RID: 16740
	public LocaleString _MultiplayerDisabledOnServerText = new LocaleString("You need to turn multiplayer on. You can do that from your account at www.schoolofdragons.com.");

	// Token: 0x04004165 RID: 16741
	public LocaleString _SafeChatDisabledOnServerText = new LocaleString("[REVIEW] You need to turn Safe Chat on. You can do that from your account at www.schoolofdragons.com.");

	// Token: 0x04004166 RID: 16742
	public Color _SystemMessageTextColor;

	// Token: 0x04004167 RID: 16743
	public Color _ActiveLinkTextColor;

	// Token: 0x04004181 RID: 16769
	public static UiChatHistory.OnChatUIClosed pOnChatUIClosed = null;

	// Token: 0x04004182 RID: 16770
	public LocaleString _MobileChatBoxDefaultText = new LocaleString("Tap here to chat");

	// Token: 0x04004183 RID: 16771
	public string _UiChatRegisterNowPath;

	// Token: 0x02000ACF RID: 2767
	[Serializable]
	public class ChatTabFlashInfo
	{
		// Token: 0x04004184 RID: 16772
		public ChatOptions _ChatOption;

		// Token: 0x04004185 RID: 16773
		public KAWidget _ChatTabWidget;

		// Token: 0x04004186 RID: 16774
		public float _FlashDuration = 2f;

		// Token: 0x04004187 RID: 16775
		[HideInInspector]
		public bool _FlashPending;

		// Token: 0x04004188 RID: 16776
		[HideInInspector]
		public float _CurrentFlashTime;
	}

	// Token: 0x02000AD0 RID: 2768
	[Serializable]
	public class MessageAction
	{
		// Token: 0x04004189 RID: 16777
		public string _MessageType;

		// Token: 0x0400418A RID: 16778
		public string _MessageSubType;

		// Token: 0x0400418B RID: 16779
		public int _MessageTypeID;

		// Token: 0x0400418C RID: 16780
		public LocaleString _Action;

		// Token: 0x0400418D RID: 16781
		public bool _IsChallenge;
	}

	// Token: 0x02000AD1 RID: 2769
	public class ChatMessage
	{
		// Token: 0x06004056 RID: 16470 RVA: 0x0002CA74 File Offset: 0x0002AC74
		public ChatMessage(string message, ChatOptions channel)
		{
			this._Message = message;
			this._Channel = channel;
		}

		// Token: 0x0400418E RID: 16782
		public string _Message;

		// Token: 0x0400418F RID: 16783
		public ChatOptions _Channel;

		// Token: 0x04004190 RID: 16784
		public object _MessageInfoObject;

		// Token: 0x04004191 RID: 16785
		public Action<object> _Callback;

		// Token: 0x04004192 RID: 16786
		public KAWidget _Widget;
	}

	// Token: 0x02000AD2 RID: 2770
	public class AnalyticsChatEventParams
	{
		// Token: 0x04004193 RID: 16787
		public const string CloseRegisterPrompt = "Closed Register Prompt";

		// Token: 0x04004194 RID: 16788
		public const string AcceptRegisterPrompt = "Accepted Register Prompt";

		// Token: 0x04004195 RID: 16789
		public const string RegisterAfterPrompt = "Registered After Prompt";
	}

	// Token: 0x02000AD3 RID: 2771
	// (Invoke) Token: 0x06004059 RID: 16473
	public delegate void OnChatUIClosed();
}
