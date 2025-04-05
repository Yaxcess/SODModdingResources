using System;

namespace JSGames.UI.TerrorMail
{
	// Token: 0x02001B7B RID: 7035
	public class MessageBoardFriendUserData
	{
		// Token: 0x170010F4 RID: 4340
		// (get) Token: 0x0600A68D RID: 42637 RVA: 0x00068116 File Offset: 0x00066316
		// (set) Token: 0x0600A68E RID: 42638 RVA: 0x0006811E File Offset: 0x0006631E
		public string pUserID { get; private set; }

		// Token: 0x170010F5 RID: 4341
		// (get) Token: 0x0600A68F RID: 42639 RVA: 0x00068127 File Offset: 0x00066327
		// (set) Token: 0x0600A690 RID: 42640 RVA: 0x0006812F File Offset: 0x0006632F
		public string pUserName { get; private set; }

		// Token: 0x0600A691 RID: 42641 RVA: 0x00068138 File Offset: 0x00066338
		public MessageBoardFriendUserData(string userID, string userName)
		{
			this.pUserID = userID;
			this.pUserName = userName;
		}
	}
}
