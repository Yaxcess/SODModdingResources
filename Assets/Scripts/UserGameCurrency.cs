using System;
using System.Xml.Serialization;

// Token: 0x020008B7 RID: 2231
[XmlRoot(ElementName = "UserGameCurrency", Namespace = "")]
[Serializable]
public class UserGameCurrency
{
	// Token: 0x06003583 RID: 13699 RVA: 0x0002639B File Offset: 0x0002459B
	public UserGameCurrency()
	{
		this.GameCurrency = new int?(0);
		this.CashCurrency = new int?(0);
	}

	// Token: 0x040036DC RID: 14044
	[XmlElement(ElementName = "id")]
	public int? UserGameCurrencyID;

	// Token: 0x040036DD RID: 14045
	[XmlElement(ElementName = "uid")]
	public Guid? UserID;

	// Token: 0x040036DE RID: 14046
	[XmlElement(ElementName = "gc")]
	public int? GameCurrency;

	// Token: 0x040036DF RID: 14047
	[XmlElement(ElementName = "cc")]
	public int? CashCurrency;
}
