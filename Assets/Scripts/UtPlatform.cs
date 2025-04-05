using System;
using System.Xml.Serialization;
using UnityEngine;

// Token: 0x02001284 RID: 4740
public class UtPlatform
{
	// Token: 0x17000BA7 RID: 2983
	// (get) Token: 0x06007735 RID: 30517 RVA: 0x00050EBD File Offset: 0x0004F0BD
	public static int pDeviceTypeID
	{
		get
		{
			return (int)UtPlatform.GetDeviceType();
		}
	}

	// Token: 0x17000BA8 RID: 2984
	// (get) Token: 0x06007736 RID: 30518 RVA: 0x00050EC4 File Offset: 0x0004F0C4
	public static int pPlatformID
	{
		get
		{
			return (int)UtPlatform.GetPlatformType();
		}
	}

	// Token: 0x06007737 RID: 30519 RVA: 0x0000A66D File Offset: 0x0000886D
	private static UtPlatform.DeviceType GetDeviceType()
	{
		return UtPlatform.DeviceType.Unknown;
	}

	// Token: 0x06007738 RID: 30520 RVA: 0x002EB340 File Offset: 0x002E9540
	public static UtPlatform.PlatformType GetPlatformType()
	{
		if (UtPlatform.IsiOS())
		{
			return UtPlatform.PlatformType.iOS;
		}
		if (UtPlatform.IsAndroid())
		{
			return UtPlatform.PlatformType.Android;
		}
		if (UtPlatform.IsWSA())
		{
			return UtPlatform.PlatformType.WSA;
		}
		if (UtPlatform.IsSteam())
		{
			return UtPlatform.PlatformType.Steam;
		}
		if (UtPlatform.IsStandAlone())
		{
			return UtPlatform.PlatformType.Standalone;
		}
		if (UtPlatform.IsXBox())
		{
			return UtPlatform.PlatformType.XBox;
		}
		if (UtPlatform.IsWebGL())
		{
			return UtPlatform.PlatformType.WebGL;
		}
		return UtPlatform.PlatformType.Unknown;
	}

	// Token: 0x06007739 RID: 30521 RVA: 0x00050ECB File Offset: 0x0004F0CB
	public static bool IsMobile()
	{
		return UtPlatform.IsiOS() || UtPlatform.IsAndroid();
	}

	// Token: 0x0600773A RID: 30522 RVA: 0x0000A66D File Offset: 0x0000886D
	public static bool IsiOS()
	{
		return false;
	}

	// Token: 0x0600773B RID: 30523 RVA: 0x0000A66D File Offset: 0x0000886D
	public static bool IsAndroid()
	{
		return false;
	}

	// Token: 0x0600773C RID: 30524 RVA: 0x0000A66D File Offset: 0x0000886D
	public static bool IsAmazon()
	{
		return false;
	}

	// Token: 0x0600773D RID: 30525 RVA: 0x0000A66D File Offset: 0x0000886D
	public static bool IsHuawei()
	{
		return false;
	}

	// Token: 0x0600773E RID: 30526 RVA: 0x0000A66D File Offset: 0x0000886D
	public static bool IsWSA()
	{
		return false;
	}

	// Token: 0x0600773F RID: 30527 RVA: 0x0000A66D File Offset: 0x0000886D
	public static bool IsEditor()
	{
		return false;
	}

	// Token: 0x06007740 RID: 30528 RVA: 0x0000617D File Offset: 0x0000437D
	public static bool IsStandAlone()
	{
		return true;
	}

	// Token: 0x06007741 RID: 30529 RVA: 0x0000A66D File Offset: 0x0000886D
	public static bool IsStandaloneOSX()
	{
		return false;
	}

	// Token: 0x06007742 RID: 30530 RVA: 0x0000617D File Offset: 0x0000437D
	public static bool IsStandaloneWindows()
	{
		return true;
	}

	// Token: 0x06007743 RID: 30531 RVA: 0x0000A66D File Offset: 0x0000886D
	public static bool IsSteam()
	{
		return false;
	}

	// Token: 0x06007744 RID: 30532 RVA: 0x0000A66D File Offset: 0x0000886D
	public static bool IsSteamWindows()
	{
		return false;
	}

	// Token: 0x06007745 RID: 30533 RVA: 0x0000A66D File Offset: 0x0000886D
	public static bool IsSteamMac()
	{
		return false;
	}

	// Token: 0x06007746 RID: 30534 RVA: 0x0000A66D File Offset: 0x0000886D
	public static bool IsXBox()
	{
		return false;
	}

	// Token: 0x06007747 RID: 30535 RVA: 0x0000A66D File Offset: 0x0000886D
	public static bool IsWebGL()
	{
		return false;
	}

	// Token: 0x06007748 RID: 30536 RVA: 0x0000617D File Offset: 0x0000437D
	public static bool IsHandheldDevice()
	{
		return true;
	}

	// Token: 0x0600774E RID: 30542 RVA: 0x00050F09 File Offset: 0x0004F109
	public static string GetPlatformName()
	{
		return "PC";
	}

	// Token: 0x0600774F RID: 30543 RVA: 0x00050F10 File Offset: 0x0004F110
	public static string GetDeviceModel()
	{
		return SystemInfo.deviceModel;
	}

	// Token: 0x06007750 RID: 30544 RVA: 0x002EB4C8 File Offset: 0x002E96C8
	public static bool PlatformCanBeUsed(string[] platform, string name)
	{
		if (platform == null || platform.Length == 0)
		{
			return true;
		}
		int i = 0;
		int num = platform.Length;
		while (i < num)
		{
			if (!string.IsNullOrEmpty(platform[i]) && name.Contains(platform[i]))
			{
				return true;
			}
			i++;
		}
		return false;
	}

	// Token: 0x06007751 RID: 30545 RVA: 0x002EB508 File Offset: 0x002E9708
	public static string GetCurrentPlatformFolderSuffix()
	{
		if (UtPlatform.IsiOS())
		{
			return "iOS";
		}
		if (UtPlatform.IsAndroid())
		{
			return "Android";
		}
		if (UtPlatform.IsWSA())
		{
			return "WSA";
		}
		if (UtPlatform.IsStandAlone())
		{
			if (UtPlatform.IsSteamWindows())
			{
				Debug.Log("Returning Steam");
				return "Steam";
			}
			if (UtPlatform.IsSteamMac())
			{
				return "SteamMac";
			}
			if (UtPlatform.IsStandaloneOSX())
			{
				return "Mac";
			}
			if (UtPlatform.IsStandaloneWindows())
			{
				return "Win";
			}
			return "StandaloneUnknown";
		}
		else
		{
			if (UtPlatform.IsXBox())
			{
				return "XBox";
			}
			if (UtPlatform.IsWebGL())
			{
				return "WebGL";
			}
			return "Unknown";
		}
	}

	// Token: 0x06007752 RID: 30546 RVA: 0x00050F17 File Offset: 0x0004F117
	public static bool IsImageEffectSupported()
	{
		return SystemInfo.supportsImageEffects;
	}

	// Token: 0x06007753 RID: 30547 RVA: 0x00050F1E File Offset: 0x0004F11E
	public static string GetGPUName()
	{
		return SystemInfo.graphicsDeviceName;
	}

	// Token: 0x04007324 RID: 29476
	public static int ForcedAvatarLimit = -1;

	// Token: 0x04007325 RID: 29477
	public static int MaxFullMMO = -1;

	// Token: 0x02001285 RID: 4741
	[Serializable]
	public enum PlatformType
	{
		// Token: 0x04007327 RID: 29479
		[XmlEnum("0")]
		Unknown,
		// Token: 0x04007328 RID: 29480
		[XmlEnum("1")]
		WebGL,
		// Token: 0x04007329 RID: 29481
		[XmlEnum("2")]
		iOS,
		// Token: 0x0400732A RID: 29482
		[XmlEnum("3")]
		Android,
		// Token: 0x0400732B RID: 29483
		[XmlEnum("4")]
		WSA,
		// Token: 0x0400732C RID: 29484
		[XmlEnum("5")]
		Standalone,
		// Token: 0x0400732D RID: 29485
		[XmlEnum("6")]
		Steam,
		// Token: 0x0400732E RID: 29486
		[XmlEnum("7")]
		XBox
	}

	// Token: 0x02001286 RID: 4742
	[Serializable]
	public enum DeviceType
	{
		// Token: 0x04007330 RID: 29488
		[XmlEnum("0")]
		Unknown,
		// Token: 0x04007331 RID: 29489
		[XmlEnum("1")]
		iPhone,
		// Token: 0x04007332 RID: 29490
		[XmlEnum("2")]
		iPad
	}
}
