using System;
using System.Xml.Serialization;

// Token: 0x02000888 RID: 2184
public enum SetTaskStateStatus
{
	// Token: 0x040035DB RID: 13787
	[XmlEnum("1")]
	RequiresMembership = 1,
	// Token: 0x040035DC RID: 13788
	[XmlEnum("2")]
	RequiresAcceptance,
	// Token: 0x040035DD RID: 13789
	[XmlEnum("3")]
	NotWithinDateRange,
	// Token: 0x040035DE RID: 13790
	[XmlEnum("4")]
	PreRequisiteMissionIncomplete,
	// Token: 0x040035DF RID: 13791
	[XmlEnum("5")]
	UserRankLessThanMinRank,
	// Token: 0x040035E0 RID: 13792
	[XmlEnum("6")]
	UserRankGreaterThanMaxRank,
	// Token: 0x040035E1 RID: 13793
	[XmlEnum("7")]
	UserHasNoRankData,
	// Token: 0x040035E2 RID: 13794
	[XmlEnum("8")]
	MissionStateNotFound,
	// Token: 0x040035E3 RID: 13795
	[XmlEnum("9")]
	RequiredPriorTaskIncomplete,
	// Token: 0x040035E4 RID: 13796
	[XmlEnum("10")]
	ParentsTaskIncomplete,
	// Token: 0x040035E5 RID: 13797
	[XmlEnum("11")]
	ParentsSubMissionIncomplete,
	// Token: 0x040035E6 RID: 13798
	[XmlEnum("12")]
	TaskCanBeDone,
	// Token: 0x040035E7 RID: 13799
	[XmlEnum("13")]
	OneOrMoreMissionsHaveNoRewardsAttached,
	// Token: 0x040035E8 RID: 13800
	[XmlEnum("14")]
	PayLoadUpdated,
	// Token: 0x040035E9 RID: 13801
	[XmlEnum("15")]
	NonRepeatableMission,
	// Token: 0x040035EA RID: 13802
	[XmlEnum("255")]
	Unknown = 255
}
