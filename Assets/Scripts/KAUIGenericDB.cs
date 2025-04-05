using System;
using UnityEngine;

// Token: 0x02000DDD RID: 3549
public class KAUIGenericDB : KAUI
{

	// Token: 0x040056F5 RID: 22261
	public GameObject _MessageObject;

	// Token: 0x040056F6 RID: 22262
	public string _YesMessage = "";

	// Token: 0x040056F7 RID: 22263
	public string _NoMessage = "";

	// Token: 0x040056F8 RID: 22264
	public string _OKMessage = "";

	// Token: 0x040056F9 RID: 22265
	public string _CloseMessage = "";

	// Token: 0x040056FA RID: 22266
	public string _TextMessage = "";

	// Token: 0x040056FB RID: 22267
	public string _MovieMessage = "";

	// Token: 0x040056FC RID: 22268
	public string _ButtonClickedMessage = "";

	// Token: 0x040056FD RID: 22269
	public int _MessageIdentifier = -1;

	// Token: 0x040056FE RID: 22270
	private bool mDestroyOnClick;

	// Token: 0x02000DDE RID: 3550
	// (Invoke) Token: 0x06005711 RID: 22289
	public delegate void MessageReceived(string inMessage);
}
