using System;
using System.Xml.Serialization;
using UnityEngine;

// Token: 0x020012A4 RID: 4772
[Serializable]
public class MinMax
{
	// Token: 0x0600782D RID: 30765 RVA: 0x000065ED File Offset: 0x000047ED
	public MinMax()
	{
	}

	// Token: 0x0600782E RID: 30766 RVA: 0x00051830 File Offset: 0x0004FA30
	public MinMax(float inMin, float inMax)
	{
		this.Max = inMax;
		this.Min = inMin;
	}

	// Token: 0x0600782F RID: 30767 RVA: 0x00051846 File Offset: 0x0004FA46
	public float GetRandomValue()
	{
		return UnityEngine.Random.Range(this.Min * 1000f, this.Max * 1000f) / 1000f;
	}

	// Token: 0x06007830 RID: 30768 RVA: 0x0005186B File Offset: 0x0004FA6B
	public float GetRandomFloat()
	{
		return this.GetRandomValue();
	}

	// Token: 0x06007831 RID: 30769 RVA: 0x00051873 File Offset: 0x0004FA73
	public int GetRandomInt()
	{
		return (int)Math.Round((double)this.GetRandomValue(), MidpointRounding.AwayFromZero);
	}

	// Token: 0x06007832 RID: 30770 RVA: 0x00051883 File Offset: 0x0004FA83
	public bool IsInRange(float inValue)
	{
		return inValue >= this.Min && inValue <= this.Max;
	}

	// Token: 0x06007833 RID: 30771 RVA: 0x0005189A File Offset: 0x0004FA9A
	public override string ToString()
	{
		return "Min : " + this.Min.ToString() + ", Max : " + this.Max.ToString();
	}

	// Token: 0x0400737D RID: 29565
	[XmlElement(ElementName = "Min")]
	public float Min;

	// Token: 0x0400737E RID: 29566
	[XmlElement(ElementName = "Max")]
	public float Max;
}
