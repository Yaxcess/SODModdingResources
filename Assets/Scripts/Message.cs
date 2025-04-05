using System;
using JSGames;

// Token: 0x020007D9 RID: 2009
public class Message
{
	// Token: 0x040031BD RID: 12733
	public int? MessageID;

	// Token: 0x040031BE RID: 12734
	public string Creator;

	// Token: 0x040031BF RID: 12735
	public MessageLevel MessageLevel;

	// Token: 0x040031C0 RID: 12736
	public MessageType MessageType;

	// Token: 0x040031C1 RID: 12737
	public string Content;

	// Token: 0x040031C2 RID: 12738
	public int? ReplyToMessageID;

	// Token: 0x040031C3 RID: 12739
	public DateTime CreateTime;

	// Token: 0x040031C4 RID: 12740
	public DateTime? UpdateDate;

	// Token: 0x040031C5 RID: 12741
	public int ConversationID;

	// Token: 0x040031C6 RID: 12742
	public string DisplayAttribute;

	// Token: 0x040031C7 RID: 12743
	public bool isPrivate;
}
