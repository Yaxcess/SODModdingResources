using System;
using System.Xml.Serialization;

// Token: 0x020007C0 RID: 1984
[XmlRoot(ElementName = "SL", Namespace = "", IsNullable = true)]
[Serializable]
public class ItemsInStoreDataSale
{
	// Token: 0x170004F3 RID: 1267
	// (get) Token: 0x0600317C RID: 12668 RVA: 0x00024364 File Offset: 0x00022564
	public bool pForMembers
	{
		get
		{
			return this.ForMembers != null && this.ForMembers.Value;
		}
	}

	

	// Token: 0x0400314B RID: 12619
	[XmlElement(ElementName = "pcid")]
	public int PriceChangeId;

	// Token: 0x0400314C RID: 12620
	[XmlElement(ElementName = "m")]
	public float Modifier;

	// Token: 0x0400314D RID: 12621
	[XmlElement(ElementName = "ic")]
	public string Icon;

	// Token: 0x0400314E RID: 12622
	[XmlElement(ElementName = "rid", IsNullable = true)]
	public int? RankId;

	// Token: 0x0400314F RID: 12623
	[XmlElement(ElementName = "iids")]
	public int[] ItemIDs;

	// Token: 0x04003150 RID: 12624
	[XmlElement(ElementName = "cids")]
	public int[] CategoryIDs;

	// Token: 0x04003151 RID: 12625
	[XmlElement(ElementName = "ism", IsNullable = true)]
	public bool? ForMembers;

	// Token: 0x04003152 RID: 12626
	[XmlElement(ElementName = "sd", IsNullable = true)]
	public DateTime? StartDate;

	// Token: 0x04003153 RID: 12627
	[XmlElement(ElementName = "ed", IsNullable = true)]
	public DateTime? EndDate;
}
