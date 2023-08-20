using System;

// Token: 0x02000E10 RID: 3600
public class KAWidgetUserData
{
	// Token: 0x0600581D RID: 22557 RVA: 0x0003C4E3 File Offset: 0x0003A6E3
	public KAWidgetUserData()
	{
		this._Index = -1;
	}

	// Token: 0x0600581E RID: 22558 RVA: 0x0003C4F2 File Offset: 0x0003A6F2
	public KAWidgetUserData(int i)
	{
		this._Index = i;
	}

	// Token: 0x0600581F RID: 22559 RVA: 0x0003C501 File Offset: 0x0003A701
	public KAWidgetUserData(int i, KAWidget inItem)
	{
		this._Index = i;
		this._Item = inItem;
	}

	// Token: 0x06005820 RID: 22560 RVA: 0x0003C517 File Offset: 0x0003A717
	public KAWidget GetItem()
	{
		return this._Item;
	}

	// Token: 0x06005821 RID: 22561 RVA: 0x0003C51F File Offset: 0x0003A71F
	public virtual KAWidgetUserData CloneObject()
	{
		return (KAWidgetUserData)base.MemberwiseClone();
	}

	// Token: 0x06005822 RID: 22562 RVA: 0x00006173 File Offset: 0x00004373
	public virtual void Destroy()
	{
	}

	// Token: 0x04005811 RID: 22545
	public KAWidget _Item;

	// Token: 0x04005812 RID: 22546
	public int _Index;
}
