using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;

// Token: 0x020007E2 RID: 2018
[XmlRoot(ElementName = "Mission", Namespace = "")]
public class Mission
{
	// Token: 0x040031EB RID: 12779
	[XmlElement(ElementName = "I")]
	public int MissionID;

	// Token: 0x040031EC RID: 12780
	[XmlElement(ElementName = "N")]
	public string Name;

	// Token: 0x040031ED RID: 12781
	[XmlElement(ElementName = "G")]
	public int GroupID;

	// Token: 0x040031EE RID: 12782
	[XmlElement(ElementName = "P", IsNullable = true)]
	public int? ParentID;

	// Token: 0x040031EF RID: 12783
	[XmlElement(ElementName = "S")]
	public string Static;

	// Token: 0x040031F0 RID: 12784
	[XmlElement(ElementName = "A")]
	public bool Accepted;

	// Token: 0x040031F1 RID: 12785
	[XmlElement(ElementName = "C")]
	public int Completed;

	// Token: 0x040031F2 RID: 12786
	[XmlElement(ElementName = "R")]
	public string Rule;

	// Token: 0x040031F3 RID: 12787
	[XmlElement(ElementName = "MR")]
	public MissionRule MissionRule;

	// Token: 0x040031F4 RID: 12788
	[XmlElement(ElementName = "V")]
	public int VersionID;

	// Token: 0x040031F5 RID: 12789
	[XmlElement(ElementName = "AID")]
	public int AchievementID;

	// Token: 0x040031F6 RID: 12790
	[XmlElement(ElementName = "AAID")]
	public int AcceptanceAchievementID;

	// Token: 0x040031F7 RID: 12791
	[XmlElement(ElementName = "M")]
	public List<Mission> Missions;

	// Token: 0x040031F8 RID: 12792
	[XmlElement(ElementName = "Task")]
	public List<Task> Tasks;

	// Token: 0x040031F9 RID: 12793
	[XmlElement(ElementName = "AR")]
	public List<AchievementReward> Rewards;

	// Token: 0x040031FA RID: 12794
	[XmlElement(ElementName = "AAR")]
	public List<AchievementReward> AcceptanceRewards;

	// Token: 0x040031FB RID: 12795
	[XmlElement(ElementName = "RPT")]
	public bool Repeatable;

	// Token: 0x040031FC RID: 12796
	public static uint LOG_MASK = 1U;

	// Token: 0x040031FD RID: 12797
	public static bool pLocked = true;

	// Token: 0x040031FE RID: 12798
	public static bool pSave = true;

	// Token: 0x040031FF RID: 12799
	public static bool pFail = false;

	// Token: 0x04003200 RID: 12800
	public static bool pSyncDB = true;

	// Token: 0x04003201 RID: 12801
	[XmlIgnore]
	public Mission.SetupComplete OnSetupComplete;

	// Token: 0x04003202 RID: 12802
	[XmlIgnore]
	public bool pStaticDataReady;

	// Token: 0x04003203 RID: 12803
	[XmlIgnore]
	public bool pTimedMission;

	// Token: 0x04003204 RID: 12804
	[XmlIgnore]
	public Mission _Parent;

	// Token: 0x04003206 RID: 12806
	[XmlIgnore]
	public List<Mission.SaveTask> pTasksSaving = new List<Mission.SaveTask>();

	// Token: 0x020007E3 RID: 2019
	// (Invoke) Token: 0x060031EA RID: 12778
	public delegate void SetupComplete();

	// Token: 0x020007E4 RID: 2020
	public class SaveTask
	{
		// Token: 0x060031ED RID: 12781 RVA: 0x00024708 File Offset: 0x00022908
		public SaveTask(Task task, bool completed, MissionCompleteEventHandler callback)
		{
			this._Task = task;
			this._Completed = completed;
			this._Callback = callback;
		}

		// Token: 0x04003207 RID: 12807
		[XmlIgnore]
		public Task _Task;

		// Token: 0x04003208 RID: 12808
		[XmlIgnore]
		public bool _Completed;

		// Token: 0x04003209 RID: 12809
		[XmlIgnore]
		public MissionCompleteEventHandler _Callback;
	}
}
