using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml.Serialization;
using Newtonsoft.Json;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x020012A5 RID: 4773
public class UtUtilities
{
	// Token: 0x04007376 RID: 29558
	public const float FEET_TO_METERS = 0.3048f;

	// Token: 0x04007377 RID: 29559
	public const float DISTANCE_FOR_STOP_UPDATE = 100f;

	// Token: 0x04007378 RID: 29560
	public const float IOS_VERSION_THIRTEEN = 13f;

	// Token: 0x04007379 RID: 29561
	public static bool _ConnectedToInternet = true;
}
