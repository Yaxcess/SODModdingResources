using System;
using System.Collections.Generic;
using System.Xml.Serialization;

// Token: 0x020007B0 RID: 1968
[XmlRoot(ElementName = "BP", Namespace = "", IsNullable = true)]
[Serializable]
public class BluePrint
{
	// Token: 0x170004C5 RID: 1221
	// (get) Token: 0x06003115 RID: 12565 RVA: 0x00024056 File Offset: 0x00022256
	// (set) Token: 0x06003116 RID: 12566 RVA: 0x0002405E File Offset: 0x0002225E
	[XmlElement(ElementName = "BPDC", IsNullable = true)]
	public List<BluePrintDeductibleConfig> Deductibles { get; set; }

	// Token: 0x170004C6 RID: 1222
	// (get) Token: 0x06003117 RID: 12567 RVA: 0x00024067 File Offset: 0x00022267
	// (set) Token: 0x06003118 RID: 12568 RVA: 0x0002406F File Offset: 0x0002226F
	[XmlElement(ElementName = "ING", IsNullable = false)]
	public List<BluePrintSpecification> Ingredients { get; set; }

	// Token: 0x170004C7 RID: 1223
	// (get) Token: 0x06003119 RID: 12569 RVA: 0x00024078 File Offset: 0x00022278
	// (set) Token: 0x0600311A RID: 12570 RVA: 0x00024080 File Offset: 0x00022280
	[XmlElement(ElementName = "OUT", IsNullable = false)]
	public List<BluePrintSpecification> Outputs { get; set; }
}
