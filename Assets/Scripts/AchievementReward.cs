using System;
using System.Xml.Serialization;

// Token: 0x020006C9 RID: 1737
[XmlRoot(ElementName = "AR", Namespace = "")]
[Serializable]
public class AchievementReward
{
	// Token: 0x170003FE RID: 1022
	// (get) Token: 0x06002D38 RID: 11576 RVA: 0x00022262 File Offset: 0x00020462
	// (set) Token: 0x06002D39 RID: 11577 RVA: 0x0002226A File Offset: 0x0002046A
	[XmlElement(ElementName = "ui", IsNullable = true)]
	public UserItemData UserItem { get; set; }

	// Token: 0x06002D3A RID: 11578 RVA: 0x00022273 File Offset: 0x00020473
	public AchievementReward()
	{
		this.Amount = new int?(0);
		this.EntityID = null;
		this.EntityTypeID = 1;
	}

	// Token: 0x04002C8A RID: 11402
	[XmlElement(ElementName = "a")]
	public int? Amount;

	// Token: 0x04002C8B RID: 11403
	[XmlElement(ElementName = "p", IsNullable = true)]
	public int? PointTypeID;

	// Token: 0x04002C8C RID: 11404
	[XmlElement(ElementName = "ii")]
	public int ItemID;

	// Token: 0x04002C8D RID: 11405
	[XmlElement(ElementName = "i", IsNullable = true)]
	public Guid? EntityID;

	// Token: 0x04002C8E RID: 11406
	[XmlElement(ElementName = "t")]
	public int EntityTypeID;

	// Token: 0x04002C8F RID: 11407
	[XmlElement(ElementName = "r")]
	public int RewardID;

	// Token: 0x04002C90 RID: 11408
	[XmlElement(ElementName = "ai")]
	public int AchievementID;

	// Token: 0x04002C91 RID: 11409
	[XmlElement(ElementName = "amulti")]
	public bool AllowMultiple;

	// Token: 0x04002C92 RID: 11410
	[XmlElement(ElementName = "mina", IsNullable = true)]
	public int? MinAmount;

	// Token: 0x04002C93 RID: 11411
	[XmlElement(ElementName = "maxa", IsNullable = true)]
	public int? MaxAmount;

	// Token: 0x04002C94 RID: 11412
	[XmlElement(ElementName = "d", IsNullable = true)]
	public DateTime? Date;

	// Token: 0x04002C95 RID: 11413
	[XmlElement(ElementName = "cid")]
	public int CommonInventoryID;
}
