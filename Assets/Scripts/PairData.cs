using System;
using System.Collections.Generic;
using System.Xml.Serialization;

// Token: 0x02000812 RID: 2066
[XmlRoot(ElementName = "Pairs", Namespace = "", IsNullable = false)]
[Serializable]
public class PairData
{
	// Token: 0x1700051A RID: 1306
	// (get) Token: 0x0600325E RID: 12894 RVA: 0x00024B30 File Offset: 0x00022D30
	// (set) Token: 0x0600325F RID: 12895 RVA: 0x00024B38 File Offset: 0x00022D38
	[XmlIgnore]
	public List<Pair> pPairList
	{
		get
		{
			return this.mPairList;
		}
		set
		{
			this.mPairList = value;
		}
	}

	

	// Token: 0x040032B2 RID: 12978
	[XmlElement(ElementName = "Pair")]
	public Pair[] Pairs;

	// Token: 0x040032B3 RID: 12979
	public const string VALUE_NOT_DEFINED = "___VALUE_NOT_FOUND___";

	// Token: 0x040032B4 RID: 12980
	public const string LIST_NOT_VALID = "LIST_NOT_VALID";

	// Token: 0x040032B5 RID: 12981
	private static Dictionary<int, PairDataInstance> mPairData = new Dictionary<int, PairDataInstance>();

	// Token: 0x040032B6 RID: 12982
	[XmlIgnore]
	public int _DataID = -1;

	// Token: 0x040032B7 RID: 12983
	[XmlIgnore]
	public bool _IsDirty;

	// Token: 0x040032B8 RID: 12984
	private List<Pair> mPairList;
}
