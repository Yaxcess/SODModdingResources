using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

// Token: 0x02000FA8 RID: 4008
[ExecuteInEditMode]
[AddComponentMenu("NGUI/UI/NGUI Label")]
public class UILabel : UIWidget
{
	
	

	// Token: 0x0400624E RID: 25166
	[HideInInspector]
	[SerializeField]
	private Font mTrueTypeFont;

	// Token: 0x0400624F RID: 25167
	[HideInInspector]
	[SerializeField]
	private UIFont mFont;

	// Token: 0x04006250 RID: 25168
	[Multiline(6)]
	[HideInInspector]
	[SerializeField]
	private string mText = "";

	// Token: 0x04006251 RID: 25169
	[HideInInspector]
	[SerializeField]
	private int mFontSize = 16;

	// Token: 0x04006252 RID: 25170
	[HideInInspector]
	[SerializeField]
	private FontStyle mFontStyle;

	

	// Token: 0x04006254 RID: 25172
	[HideInInspector]
	[SerializeField]
	private bool mEncoding = true;

	// Token: 0x04006255 RID: 25173
	[HideInInspector]
	[SerializeField]
	private int mMaxLineCount;

	// Token: 0x04006256 RID: 25174
	[HideInInspector]
	[SerializeField]
	private UILabel.Effect mEffectStyle;

	// Token: 0x04006257 RID: 25175
	[HideInInspector]
	[SerializeField]
	private Color mEffectColor = Color.black;

	

	// Token: 0x04006259 RID: 25177
	[HideInInspector]
	[SerializeField]
	private Vector2 mEffectDistance = Vector2.one;

	// Token: 0x0400625A RID: 25178
	[HideInInspector]
	[SerializeField]
	private UILabel.Overflow mOverflow;

	// Token: 0x0400625B RID: 25179
	[HideInInspector]
	[SerializeField]
	private bool mApplyGradient;

	// Token: 0x0400625C RID: 25180
	[HideInInspector]
	[SerializeField]
	private Color mGradientTop = Color.white;

	// Token: 0x0400625D RID: 25181
	[HideInInspector]
	[SerializeField]
	private Color mGradientBottom = new Color(0.7f, 0.7f, 0.7f);

	// Token: 0x0400625E RID: 25182
	[HideInInspector]
	[SerializeField]
	private int mSpacingX;

	// Token: 0x0400625F RID: 25183
	[HideInInspector]
	[SerializeField]
	private int mSpacingY;

	// Token: 0x04006260 RID: 25184
	[HideInInspector]
	[SerializeField]
	private bool mUseFloatSpacing;

	// Token: 0x04006261 RID: 25185
	[HideInInspector]
	[SerializeField]
	private float mFloatSpacingX;

	// Token: 0x04006262 RID: 25186
	[HideInInspector]
	[SerializeField]
	private float mFloatSpacingY;

	// Token: 0x04006263 RID: 25187
	[HideInInspector]
	[SerializeField]
	private bool mOverflowEllipsis;

	// Token: 0x04006264 RID: 25188
	[HideInInspector]
	[SerializeField]
	private int mOverflowWidth;

	// Token: 0x04006265 RID: 25189
	[HideInInspector]
	[SerializeField]
	private UILabel.Modifier mModifier;

	// Token: 0x04006266 RID: 25190
	[HideInInspector]
	[SerializeField]
	private bool mShrinkToFit;

	// Token: 0x04006267 RID: 25191
	[HideInInspector]
	[SerializeField]
	private int mMaxLineWidth;

	// Token: 0x04006268 RID: 25192
	[HideInInspector]
	[SerializeField]
	private int mMaxLineHeight;

	// Token: 0x04006269 RID: 25193
	[HideInInspector]
	[SerializeField]
	private float mLineWidth;

	// Token: 0x0400626A RID: 25194
	[HideInInspector]
	[SerializeField]
	private bool mMultiline = true;

	// Token: 0x0400626B RID: 25195
	[HideInInspector]
	[SerializeField]
	private bool mIgnoreFontChange;

	// Token: 0x0400626C RID: 25196
	[HideInInspector]
	[SerializeField]
	private int mTextID;

	// Token: 0x0400626D RID: 25197
	[NonSerialized]
	private string mEnglishTxt = "";

	// Token: 0x0400626F RID: 25199
	[NonSerialized]
	private Font mActiveTTF;

	// Token: 0x04006270 RID: 25200
	[NonSerialized]
	private float mDensity = 1f;

	// Token: 0x04006271 RID: 25201
	[NonSerialized]
	private bool mShouldBeProcessed = true;

	// Token: 0x04006272 RID: 25202
	[NonSerialized]
	private string mProcessedText;

	// Token: 0x04006273 RID: 25203
	[NonSerialized]
	private bool mPremultiply;

	// Token: 0x04006274 RID: 25204
	[NonSerialized]
	private Vector2 mCalculatedSize = Vector2.zero;

	// Token: 0x04006275 RID: 25205
	[NonSerialized]
	private float mScale = 1f;

	// Token: 0x04006276 RID: 25206
	[NonSerialized]
	private int mFinalFontSize;

	// Token: 0x04006277 RID: 25207
	[NonSerialized]
	private int mLastWidth;

	// Token: 0x04006278 RID: 25208
	[NonSerialized]
	private int mLastHeight;

	// Token: 0x04006279 RID: 25209
	[NonSerialized]
	private bool mIsEnglishTextCached;

	// Token: 0x0400627A RID: 25210
	public UILabel.ModifierFunc customModifier;

	// Token: 0x0400627B RID: 25211
	private static BetterList<UILabel> mList = new BetterList<UILabel>();

	// Token: 0x0400627C RID: 25212
	private static Dictionary<Font, int> mFontUsage = new Dictionary<Font, int>();

	// Token: 0x0400627D RID: 25213
	[NonSerialized]
	private static BetterList<UIDrawCall> mTempDrawcalls;

	// Token: 0x0400627E RID: 25214
	private static bool mTexRebuildAdded = false;

	// Token: 0x0400627F RID: 25215
	private static List<Vector3> mTempVerts = new List<Vector3>();

	// Token: 0x04006280 RID: 25216
	private static List<int> mTempIndices = new List<int>();

	// Token: 0x02000FA9 RID: 4009
	public enum Effect
	{
		// Token: 0x04006282 RID: 25218
		None,
		// Token: 0x04006283 RID: 25219
		Shadow,
		// Token: 0x04006284 RID: 25220
		Outline,
		// Token: 0x04006285 RID: 25221
		Outline8
	}

	// Token: 0x02000FAA RID: 4010
	public enum Overflow
	{
		// Token: 0x04006287 RID: 25223
		ShrinkContent,
		// Token: 0x04006288 RID: 25224
		ClampContent,
		// Token: 0x04006289 RID: 25225
		ResizeFreely,
		// Token: 0x0400628A RID: 25226
		ResizeHeight
	}

	// Token: 0x02000FAB RID: 4011
	public enum Crispness
	{
		// Token: 0x0400628C RID: 25228
		Never,
		// Token: 0x0400628D RID: 25229
		OnDesktop,
		// Token: 0x0400628E RID: 25230
		Always
	}

	// Token: 0x02000FAC RID: 4012
	public enum Modifier
	{
		// Token: 0x04006290 RID: 25232
		None,
		// Token: 0x04006291 RID: 25233
		ToUppercase,
		// Token: 0x04006292 RID: 25234
		ToLowercase,
		// Token: 0x04006293 RID: 25235
		Custom = 255
	}

	// Token: 0x02000FAD RID: 4013
	// (Invoke) Token: 0x0600655F RID: 25951
	public delegate string ModifierFunc(string s);
}
