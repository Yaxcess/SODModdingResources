using System;
using UnityEngine;

// Token: 0x020009C5 RID: 2501
public class StoreLoader
{
	


	// Token: 0x04003B83 RID: 15235
	public const string STORE_LAUNCH_COUNT = "STORE_LAUNCH_COUNT";

	// Token: 0x04003B84 RID: 15236
	public const string STORE_OBJECT_NAME = "PfUiStoresDO";

	// Token: 0x020009C6 RID: 2502
	[Serializable]
	public class Selection
	{
		// Token: 0x04003B88 RID: 15240
		[Tooltip("Name of store to open.")]
		public string _Store;

		// Token: 0x04003B89 RID: 15241
		[Tooltip("Name of category to open.  Leave blank to open default category.")]
		public string _Category;
	}
}
