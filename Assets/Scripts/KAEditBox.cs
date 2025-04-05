using System;
using System.Text.RegularExpressions;
using UnityEngine;

// Token: 0x02000DC1 RID: 3521
[RequireComponent(typeof(UIInput))]
public class KAEditBox : KAWidget
{
	// Token: 0x04005648 RID: 22088
	private UIInput mInput;

	// Token: 0x04005649 RID: 22089
	public KASkinInfo _EditInfo = new KASkinInfo();

	// Token: 0x0400564A RID: 22090
	public LocaleString _DefaultText = new LocaleString("You can type here");

	// Token: 0x0400564B RID: 22091
	public string _RegularExpression = "";

	// Token: 0x0400564C RID: 22092
	public bool _CheckValidityOnInput = true;

	// Token: 0x0400564D RID: 22093
	public bool _DisableUIMovement;
}
