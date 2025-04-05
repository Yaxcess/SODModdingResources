using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using UnityEngine;
using UnityEngine.SceneManagement;

// Token: 0x02001119 RID: 4377
public class RsResourceManager
{
	// Token: 0x04006A39 RID: 27193
	public const string DATA_FOLDER = "data";

	// Token: 0x04006A3A RID: 27194
	public const string SCENE_FOLDER = "scene";

	// Token: 0x04006A3B RID: 27195
	public const string CONTENT_DATA_FOLDER = "contentdata";

	// Token: 0x04006A3C RID: 27196
	public const string SHARED_DATA_FOLDER = "shareddata";

	// Token: 0x04006A3D RID: 27197
	public const string SOUND_FOLDER = "sound";

	// Token: 0x04006A3E RID: 27198
	public const string MOVIE_FOLDER = "movies";

	// Token: 0x04006A5B RID: 27227
	public static bool mReleaseBundleData;

	// Token: 0x04006A5C RID: 27228
	private static string[] BUCKET_ASSETS_TAG;

	// Token: 0x04006A5E RID: 27230
	private static string mBundleID;

	// Token: 0x04006A5F RID: 27231
	public static Dictionary<string, List<string>> mResourceBucket;
}
