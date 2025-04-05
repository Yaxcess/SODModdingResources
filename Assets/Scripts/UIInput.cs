using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

// Token: 0x02000FA1 RID: 4001
[AddComponentMenu("NGUI/UI/Input Field")]
public class UIInput : MonoBehaviour
{

	// Token: 0x04006206 RID: 25094
	public static UIInput current;

	// Token: 0x04006207 RID: 25095
	public static UIInput selection;

	// Token: 0x04006208 RID: 25096
	public UILabel label;

	// Token: 0x04006209 RID: 25097
	public UIInput.InputType inputType;

	// Token: 0x0400620A RID: 25098
	public UIInput.OnReturnKey onReturnKey;

	// Token: 0x0400620B RID: 25099
	public UIInput.KeyboardType keyboardType;

	// Token: 0x0400620C RID: 25100
	public bool hideInput;

	// Token: 0x0400620D RID: 25101
	[NonSerialized]
	public bool selectAllTextOnFocus = true;

	// Token: 0x0400620E RID: 25102
	public bool submitOnUnselect;

	// Token: 0x0400620F RID: 25103
	public UIInput.Validation validation;

	// Token: 0x04006210 RID: 25104
	public int characterLimit;

	// Token: 0x04006211 RID: 25105
	public string savedAs;

	// Token: 0x04006212 RID: 25106
	[HideInInspector]
	[SerializeField]
	private GameObject selectOnTab;

	// Token: 0x04006213 RID: 25107
	public Color activeTextColor = Color.white;

	// Token: 0x04006214 RID: 25108
	public Color caretColor = new Color(1f, 1f, 1f, 0.8f);

	// Token: 0x04006215 RID: 25109
	public Color selectionColor = new Color(1f, 0.8745098f, 0.5529412f, 0.5f);

	// Token: 0x04006216 RID: 25110
	public List<EventDelegate> onSubmit = new List<EventDelegate>();

	// Token: 0x04006217 RID: 25111
	public List<EventDelegate> onChange = new List<EventDelegate>();

	// Token: 0x04006218 RID: 25112
	public UIInput.OnValidate onValidate;

	// Token: 0x04006219 RID: 25113
	[SerializeField]
	[HideInInspector]
	protected string mValue;

	// Token: 0x0400621A RID: 25114
	[NonSerialized]
	protected string mDefaultText = "";

	// Token: 0x0400621B RID: 25115
	[NonSerialized]
	protected Color mDefaultColor = Color.white;

	// Token: 0x0400621C RID: 25116
	[NonSerialized]
	protected float mPosition;

	// Token: 0x0400621D RID: 25117
	[NonSerialized]
	protected bool mDoInit = true;

	// Token: 0x0400621E RID: 25118
	[NonSerialized]
	protected NGUIText.Alignment mAlignment = NGUIText.Alignment.Left;

	// Token: 0x0400621F RID: 25119
	[NonSerialized]
	protected bool mLoadSavedValue = true;

	// Token: 0x04006220 RID: 25120
	protected static int mDrawStart = 0;

	// Token: 0x04006221 RID: 25121
	protected static string mLastIME = "";

	// Token: 0x04006222 RID: 25122
	[NonSerialized]
	protected int mSelectionStart;

	// Token: 0x04006223 RID: 25123
	[NonSerialized]
	protected int mSelectionEnd;

	// Token: 0x04006224 RID: 25124
	[NonSerialized]
	protected UITexture mHighlight;

	// Token: 0x04006225 RID: 25125
	[NonSerialized]
	protected UITexture mCaret;

	// Token: 0x04006226 RID: 25126
	[NonSerialized]
	protected Texture2D mBlankTex;

	// Token: 0x04006227 RID: 25127
	[NonSerialized]
	protected float mNextBlink;

	// Token: 0x04006228 RID: 25128
	[NonSerialized]
	protected float mLastAlpha;

	// Token: 0x04006229 RID: 25129
	[NonSerialized]
	protected string mCached = "";

	// Token: 0x0400622A RID: 25130
	[NonSerialized]
	protected int mSelectMe = -1;

	// Token: 0x0400622B RID: 25131
	[NonSerialized]
	protected int mSelectTime = -1;

	// Token: 0x0400622C RID: 25132
	[NonSerialized]
	protected bool mStarted;

	// Token: 0x02000FA2 RID: 4002
	public enum InputType
	{
		// Token: 0x04006232 RID: 25138
		Standard,
		// Token: 0x04006233 RID: 25139
		AutoCorrect,
		// Token: 0x04006234 RID: 25140
		Password
	}

	// Token: 0x02000FA3 RID: 4003
	public enum Validation
	{
		// Token: 0x04006236 RID: 25142
		None,
		// Token: 0x04006237 RID: 25143
		Integer,
		// Token: 0x04006238 RID: 25144
		Float,
		// Token: 0x04006239 RID: 25145
		Alphanumeric,
		// Token: 0x0400623A RID: 25146
		Username,
		// Token: 0x0400623B RID: 25147
		Name,
		// Token: 0x0400623C RID: 25148
		Filename
	}

	// Token: 0x02000FA4 RID: 4004
	public enum KeyboardType
	{
		// Token: 0x0400623E RID: 25150
		Default,
		// Token: 0x0400623F RID: 25151
		ASCIICapable,
		// Token: 0x04006240 RID: 25152
		NumbersAndPunctuation,
		// Token: 0x04006241 RID: 25153
		URL,
		// Token: 0x04006242 RID: 25154
		NumberPad,
		// Token: 0x04006243 RID: 25155
		PhonePad,
		// Token: 0x04006244 RID: 25156
		NamePhonePad,
		// Token: 0x04006245 RID: 25157
		EmailAddress
	}

	// Token: 0x02000FA5 RID: 4005
	public enum OnReturnKey
	{
		// Token: 0x04006247 RID: 25159
		Default,
		// Token: 0x04006248 RID: 25160
		Submit,
		// Token: 0x04006249 RID: 25161
		NewLine
	}

	// Token: 0x02000FA6 RID: 4006
	// (Invoke) Token: 0x060064D7 RID: 25815
	public delegate char OnValidate(string text, int charIndex, char addedChar);
}
