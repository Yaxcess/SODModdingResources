using System;
using System.Collections.Generic;
using System.Xml.Serialization;

// Token: 0x0200070E RID: 1806
[XmlRoot(ElementName = "CIRS", Namespace = "")]
[Serializable]
public class CommonInventoryResponse
{
	// Token: 0x1700042E RID: 1070
	// (get) Token: 0x06002EFA RID: 12026 RVA: 0x0002314D File Offset: 0x0002134D
	// (set) Token: 0x06002EFB RID: 12027 RVA: 0x00023155 File Offset: 0x00021355
	[XmlElement(ElementName = "pir", IsNullable = true)]
	public List<PrizeItemResponse> PrizeItems { get; set; }

	// Token: 0x04002E0F RID: 11791
	[XmlElement(ElementName = "s")]
	public bool Success;

	// Token: 0x04002E10 RID: 11792
	[XmlElement(ElementName = "cids")]
	public CommonInventoryResponseItem[] CommonInventoryIDs;

	// Token: 0x04002E11 RID: 11793
	[XmlElement(ElementName = "ugc", IsNullable = true)]
	public UserGameCurrency UserGameCurrency;
}
