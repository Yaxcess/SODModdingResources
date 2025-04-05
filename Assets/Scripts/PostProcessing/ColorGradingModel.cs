using System;

namespace UnityEngine.PostProcessing
{
	// Token: 0x02001BD8 RID: 7128
	[Serializable]
	public class ColorGradingModel : PostProcessingModel
	{
		// Token: 0x1700112C RID: 4396
		// (get) Token: 0x0600A7E9 RID: 42985 RVA: 0x0006908C File Offset: 0x0006728C
		// (set) Token: 0x0600A7EA RID: 42986 RVA: 0x00069094 File Offset: 0x00067294
		public ColorGradingModel.Settings settings
		{
			get
			{
				return this.m_Settings;
			}
			set
			{
				this.m_Settings = value;
				this.OnValidate();
			}
		}

		// Token: 0x1700112D RID: 4397
		// (get) Token: 0x0600A7EB RID: 42987 RVA: 0x000690A3 File Offset: 0x000672A3
		// (set) Token: 0x0600A7EC RID: 42988 RVA: 0x000690AB File Offset: 0x000672AB
		public bool isDirty { get; internal set; }

		// Token: 0x1700112E RID: 4398
		// (get) Token: 0x0600A7ED RID: 42989 RVA: 0x000690B4 File Offset: 0x000672B4
		// (set) Token: 0x0600A7EE RID: 42990 RVA: 0x000690BC File Offset: 0x000672BC
		public RenderTexture bakedLut { get; internal set; }

		// Token: 0x0600A7EF RID: 42991 RVA: 0x000690C5 File Offset: 0x000672C5
		public override void Reset()
		{
			this.m_Settings = ColorGradingModel.Settings.defaultSettings;
			this.OnValidate();
		}

		// Token: 0x0600A7F0 RID: 42992 RVA: 0x000690D8 File Offset: 0x000672D8
		public override void OnValidate()
		{
			this.isDirty = true;
		}

		// Token: 0x0400AB60 RID: 43872
		[SerializeField]
		private ColorGradingModel.Settings m_Settings = ColorGradingModel.Settings.defaultSettings;

		// Token: 0x02001BD9 RID: 7129
		public enum Tonemapper
		{
			// Token: 0x0400AB64 RID: 43876
			None,
			// Token: 0x0400AB65 RID: 43877
			ACES,
			// Token: 0x0400AB66 RID: 43878
			Neutral
		}

		// Token: 0x02001BDA RID: 7130
		[Serializable]
		public struct TonemappingSettings
		{
			// Token: 0x1700112F RID: 4399
			// (get) Token: 0x0600A7F2 RID: 42994 RVA: 0x003AB794 File Offset: 0x003A9994
			public static ColorGradingModel.TonemappingSettings defaultSettings
			{
				get
				{
					return new ColorGradingModel.TonemappingSettings
					{
						tonemapper = ColorGradingModel.Tonemapper.Neutral,
						neutralBlackIn = 0.02f,
						neutralWhiteIn = 10f,
						neutralBlackOut = 0f,
						neutralWhiteOut = 10f,
						neutralWhiteLevel = 5.3f,
						neutralWhiteClip = 10f
					};
				}
			}

			// Token: 0x0400AB67 RID: 43879
			[Tooltip("Tonemapping algorithm to use at the end of the color grading process. Use \"Neutral\" if you need a customizable tonemapper or \"Filmic\" to give a standard filmic look to your scenes.")]
			public ColorGradingModel.Tonemapper tonemapper;

			// Token: 0x0400AB68 RID: 43880
			[Range(-0.1f, 0.1f)]
			public float neutralBlackIn;

			// Token: 0x0400AB69 RID: 43881
			[Range(1f, 20f)]
			public float neutralWhiteIn;

			// Token: 0x0400AB6A RID: 43882
			[Range(-0.09f, 0.1f)]
			public float neutralBlackOut;

			// Token: 0x0400AB6B RID: 43883
			[Range(1f, 19f)]
			public float neutralWhiteOut;

			// Token: 0x0400AB6C RID: 43884
			[Range(0.1f, 20f)]
			public float neutralWhiteLevel;

			// Token: 0x0400AB6D RID: 43885
			[Range(1f, 10f)]
			public float neutralWhiteClip;
		}

		// Token: 0x02001BDB RID: 7131
		[Serializable]
		public struct BasicSettings
		{
			// Token: 0x17001130 RID: 4400
			// (get) Token: 0x0600A7F3 RID: 42995 RVA: 0x003AB7FC File Offset: 0x003A99FC
			public static ColorGradingModel.BasicSettings defaultSettings
			{
				get
				{
					return new ColorGradingModel.BasicSettings
					{
						postExposure = 0f,
						temperature = 0f,
						tint = 0f,
						hueShift = 0f,
						saturation = 1f,
						contrast = 1f
					};
				}
			}

			// Token: 0x0400AB6E RID: 43886
			[Tooltip("Adjusts the overall exposure of the scene in EV units. This is applied after HDR effect and right before tonemapping so it won't affect previous effects in the chain.")]
			public float postExposure;

			// Token: 0x0400AB6F RID: 43887
			[Range(-100f, 100f)]
			[Tooltip("Sets the white balance to a custom color temperature.")]
			public float temperature;

			// Token: 0x0400AB70 RID: 43888
			[Range(-100f, 100f)]
			[Tooltip("Sets the white balance to compensate for a green or magenta tint.")]
			public float tint;

			// Token: 0x0400AB71 RID: 43889
			[Range(-180f, 180f)]
			[Tooltip("Shift the hue of all colors.")]
			public float hueShift;

			// Token: 0x0400AB72 RID: 43890
			[Range(0f, 2f)]
			[Tooltip("Pushes the intensity of all colors.")]
			public float saturation;

			// Token: 0x0400AB73 RID: 43891
			[Range(0f, 2f)]
			[Tooltip("Expands or shrinks the overall range of tonal values.")]
			public float contrast;
		}

		// Token: 0x02001BDC RID: 7132
		[Serializable]
		public struct ChannelMixerSettings
		{
			// Token: 0x17001131 RID: 4401
			// (get) Token: 0x0600A7F4 RID: 42996 RVA: 0x003AB85C File Offset: 0x003A9A5C
			public static ColorGradingModel.ChannelMixerSettings defaultSettings
			{
				get
				{
					return new ColorGradingModel.ChannelMixerSettings
					{
						red = new Vector3(1f, 0f, 0f),
						green = new Vector3(0f, 1f, 0f),
						blue = new Vector3(0f, 0f, 1f),
						currentEditingChannel = 0
					};
				}
			}

			// Token: 0x0400AB74 RID: 43892
			public Vector3 red;

			// Token: 0x0400AB75 RID: 43893
			public Vector3 green;

			// Token: 0x0400AB76 RID: 43894
			public Vector3 blue;

			// Token: 0x0400AB77 RID: 43895
			[HideInInspector]
			public int currentEditingChannel;
		}

		// Token: 0x02001BDD RID: 7133
		[Serializable]
		public struct LogWheelsSettings
		{
			// Token: 0x17001132 RID: 4402
			// (get) Token: 0x0600A7F5 RID: 42997 RVA: 0x003AB8CC File Offset: 0x003A9ACC
			public static ColorGradingModel.LogWheelsSettings defaultSettings
			{
				get
				{
					return new ColorGradingModel.LogWheelsSettings
					{
						slope = Color.clear,
						power = Color.clear,
						offset = Color.clear
					};
				}
			}

			// Token: 0x0400AB78 RID: 43896
			[Trackball("GetSlopeValue")]
			public Color slope;

			// Token: 0x0400AB79 RID: 43897
			[Trackball("GetPowerValue")]
			public Color power;

			// Token: 0x0400AB7A RID: 43898
			[Trackball("GetOffsetValue")]
			public Color offset;
		}

		// Token: 0x02001BDE RID: 7134
		[Serializable]
		public struct LinearWheelsSettings
		{
			// Token: 0x17001133 RID: 4403
			// (get) Token: 0x0600A7F6 RID: 42998 RVA: 0x003AB908 File Offset: 0x003A9B08
			public static ColorGradingModel.LinearWheelsSettings defaultSettings
			{
				get
				{
					return new ColorGradingModel.LinearWheelsSettings
					{
						lift = Color.clear,
						gamma = Color.clear,
						gain = Color.clear
					};
				}
			}

			// Token: 0x0400AB7B RID: 43899
			[Trackball("GetLiftValue")]
			public Color lift;

			// Token: 0x0400AB7C RID: 43900
			[Trackball("GetGammaValue")]
			public Color gamma;

			// Token: 0x0400AB7D RID: 43901
			[Trackball("GetGainValue")]
			public Color gain;
		}

		// Token: 0x02001BDF RID: 7135
		public enum ColorWheelMode
		{
			// Token: 0x0400AB7F RID: 43903
			Linear,
			// Token: 0x0400AB80 RID: 43904
			Log
		}

		// Token: 0x02001BE0 RID: 7136
		[Serializable]
		public struct ColorWheelsSettings
		{
			// Token: 0x17001134 RID: 4404
			// (get) Token: 0x0600A7F7 RID: 42999 RVA: 0x003AB944 File Offset: 0x003A9B44
			public static ColorGradingModel.ColorWheelsSettings defaultSettings
			{
				get
				{
					return new ColorGradingModel.ColorWheelsSettings
					{
						mode = ColorGradingModel.ColorWheelMode.Log,
						log = ColorGradingModel.LogWheelsSettings.defaultSettings,
						linear = ColorGradingModel.LinearWheelsSettings.defaultSettings
					};
				}
			}

			// Token: 0x0400AB81 RID: 43905
			public ColorGradingModel.ColorWheelMode mode;

			// Token: 0x0400AB82 RID: 43906
			[TrackballGroup]
			public ColorGradingModel.LogWheelsSettings log;

			// Token: 0x0400AB83 RID: 43907
			[TrackballGroup]
			public ColorGradingModel.LinearWheelsSettings linear;
		}

		// Token: 0x02001BE1 RID: 7137
		[Serializable]
		public struct CurvesSettings
		{
			// Token: 0x17001135 RID: 4405
			// (get) Token: 0x0600A7F8 RID: 43000 RVA: 0x003AB97C File Offset: 0x003A9B7C
			public static ColorGradingModel.CurvesSettings defaultSettings
			{
				get
				{
					return new ColorGradingModel.CurvesSettings
					{
						master = new ColorGradingCurve(new AnimationCurve(new Keyframe[]
						{
							new Keyframe(0f, 0f, 1f, 1f),
							new Keyframe(1f, 1f, 1f, 1f)
						}), 0f, false, new Vector2(0f, 1f)),
						red = new ColorGradingCurve(new AnimationCurve(new Keyframe[]
						{
							new Keyframe(0f, 0f, 1f, 1f),
							new Keyframe(1f, 1f, 1f, 1f)
						}), 0f, false, new Vector2(0f, 1f)),
						green = new ColorGradingCurve(new AnimationCurve(new Keyframe[]
						{
							new Keyframe(0f, 0f, 1f, 1f),
							new Keyframe(1f, 1f, 1f, 1f)
						}), 0f, false, new Vector2(0f, 1f)),
						blue = new ColorGradingCurve(new AnimationCurve(new Keyframe[]
						{
							new Keyframe(0f, 0f, 1f, 1f),
							new Keyframe(1f, 1f, 1f, 1f)
						}), 0f, false, new Vector2(0f, 1f)),
						hueVShue = new ColorGradingCurve(new AnimationCurve(), 0.5f, true, new Vector2(0f, 1f)),
						hueVSsat = new ColorGradingCurve(new AnimationCurve(), 0.5f, true, new Vector2(0f, 1f)),
						satVSsat = new ColorGradingCurve(new AnimationCurve(), 0.5f, false, new Vector2(0f, 1f)),
						lumVSsat = new ColorGradingCurve(new AnimationCurve(), 0.5f, false, new Vector2(0f, 1f)),
						e_CurrentEditingCurve = 0,
						e_CurveY = true,
						e_CurveR = false,
						e_CurveG = false,
						e_CurveB = false
					};
				}
			}

			// Token: 0x0400AB84 RID: 43908
			public ColorGradingCurve master;

			// Token: 0x0400AB85 RID: 43909
			public ColorGradingCurve red;

			// Token: 0x0400AB86 RID: 43910
			public ColorGradingCurve green;

			// Token: 0x0400AB87 RID: 43911
			public ColorGradingCurve blue;

			// Token: 0x0400AB88 RID: 43912
			public ColorGradingCurve hueVShue;

			// Token: 0x0400AB89 RID: 43913
			public ColorGradingCurve hueVSsat;

			// Token: 0x0400AB8A RID: 43914
			public ColorGradingCurve satVSsat;

			// Token: 0x0400AB8B RID: 43915
			public ColorGradingCurve lumVSsat;

			// Token: 0x0400AB8C RID: 43916
			[HideInInspector]
			public int e_CurrentEditingCurve;

			// Token: 0x0400AB8D RID: 43917
			[HideInInspector]
			public bool e_CurveY;

			// Token: 0x0400AB8E RID: 43918
			[HideInInspector]
			public bool e_CurveR;

			// Token: 0x0400AB8F RID: 43919
			[HideInInspector]
			public bool e_CurveG;

			// Token: 0x0400AB90 RID: 43920
			[HideInInspector]
			public bool e_CurveB;
		}

		// Token: 0x02001BE2 RID: 7138
		[Serializable]
		public struct Settings
		{
			// Token: 0x17001136 RID: 4406
			// (get) Token: 0x0600A7F9 RID: 43001 RVA: 0x003ABC04 File Offset: 0x003A9E04
			public static ColorGradingModel.Settings defaultSettings
			{
				get
				{
					return new ColorGradingModel.Settings
					{
						tonemapping = ColorGradingModel.TonemappingSettings.defaultSettings,
						basic = ColorGradingModel.BasicSettings.defaultSettings,
						channelMixer = ColorGradingModel.ChannelMixerSettings.defaultSettings,
						colorWheels = ColorGradingModel.ColorWheelsSettings.defaultSettings,
						curves = ColorGradingModel.CurvesSettings.defaultSettings
					};
				}
			}

			// Token: 0x0400AB91 RID: 43921
			public ColorGradingModel.TonemappingSettings tonemapping;

			// Token: 0x0400AB92 RID: 43922
			public ColorGradingModel.BasicSettings basic;

			// Token: 0x0400AB93 RID: 43923
			public ColorGradingModel.ChannelMixerSettings channelMixer;

			// Token: 0x0400AB94 RID: 43924
			public ColorGradingModel.ColorWheelsSettings colorWheels;

			// Token: 0x0400AB95 RID: 43925
			public ColorGradingModel.CurvesSettings curves;
		}
	}
}
