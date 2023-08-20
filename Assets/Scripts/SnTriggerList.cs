using System;
using System.Collections;

// Token: 0x02001199 RID: 4505
[Serializable]
public class SnTriggerList
{
	// Token: 0x17000ADA RID: 2778
	// (get) Token: 0x06007055 RID: 28757 RVA: 0x0004CD2B File Offset: 0x0004AF2B
	public int pLength
	{
		get
		{
			if (this._TriggerData == null)
			{
				return 0;
			}
			return this._TriggerData.Length;
		}
	}

	// Token: 0x17000ADB RID: 2779
	public SnTrigger this[int inIdx]
	{
		get
		{
			if (this._TriggerData == null)
			{
				return null;
			}
			return this._TriggerData[inIdx];
		}
		set
		{
			if (this._TriggerData != null)
			{
				this._TriggerData[inIdx] = value;
			}
		}
	}

	// Token: 0x06007058 RID: 28760 RVA: 0x000065ED File Offset: 0x000047ED
	public SnTriggerList()
	{
	}

	// Token: 0x06007059 RID: 28761 RVA: 0x0004CD66 File Offset: 0x0004AF66
	public SnTriggerList(int inSize)
	{
		this._TriggerData = new SnTrigger[inSize];
	}

	// Token: 0x0600705A RID: 28762 RVA: 0x0004CD7A File Offset: 0x0004AF7A
	public SnTriggerList(SnTrigger[] inArray)
	{
		this._TriggerData = inArray;
	}

	// Token: 0x0600705B RID: 28763 RVA: 0x0004CD89 File Offset: 0x0004AF89
	public IEnumerator GetEnumerator()
	{
		return this._TriggerData.GetEnumerator();
	}

	// Token: 0x04006DD2 RID: 28114
	public SnTrigger[] _TriggerData;
}
