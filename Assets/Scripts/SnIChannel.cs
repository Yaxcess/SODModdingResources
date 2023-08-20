using System;
using UnityEngine;

// Token: 0x0200119B RID: 4507
public interface SnIChannel
{
	// Token: 0x17000ADC RID: 2780
	// (get) Token: 0x0600705E RID: 28766
	string pName { get; }

	// Token: 0x17000ADD RID: 2781
	// (get) Token: 0x0600705F RID: 28767
	string pPool { get; }

	// Token: 0x17000ADE RID: 2782
	// (get) Token: 0x06007060 RID: 28768
	// (set) Token: 0x06007061 RID: 28769
	int pPriority { get; set; }

	// Token: 0x17000ADF RID: 2783
	// (get) Token: 0x06007062 RID: 28770
	float pUseTime { get; }

	// Token: 0x17000AE0 RID: 2784
	// (get) Token: 0x06007063 RID: 28771
	bool pInUse { get; }

	// Token: 0x17000AE1 RID: 2785
	// (get) Token: 0x06007064 RID: 28772
	bool pIsStreaming { get; }

	// Token: 0x17000AE2 RID: 2786
	// (get) Token: 0x06007065 RID: 28773
	bool pIsPlaying { get; }

	// Token: 0x17000AE3 RID: 2787
	// (get) Token: 0x06007066 RID: 28774
	string pClipName { get; }

	// Token: 0x17000AE4 RID: 2788
	// (get) Token: 0x06007067 RID: 28775
	// (set) Token: 0x06007068 RID: 28776
	AudioClip pClip { get; set; }

	// Token: 0x17000AE5 RID: 2789
	// (get) Token: 0x06007069 RID: 28777
	AudioSource pAudioSource { get; }

	// Token: 0x17000AE6 RID: 2790
	// (get) Token: 0x0600706A RID: 28778
	SnIStream pAudioStream { get; }

	// Token: 0x17000AE7 RID: 2791
	// (get) Token: 0x0600706B RID: 28779
	GameObject pGameObject { get; }

	// Token: 0x17000AE8 RID: 2792
	// (get) Token: 0x0600706C RID: 28780
	Transform pTransform { get; }

	// Token: 0x17000AE9 RID: 2793
	// (get) Token: 0x0600706D RID: 28781
	// (set) Token: 0x0600706E RID: 28782
	float pVolume { get; set; }

	// Token: 0x17000AEA RID: 2794
	// (get) Token: 0x0600706F RID: 28783
	// (set) Token: 0x06007070 RID: 28784
	bool pLoop { get; set; }

	// Token: 0x17000AEB RID: 2795
	// (get) Token: 0x06007071 RID: 28785
	// (set) Token: 0x06007072 RID: 28786
	float pRolloffBegin { get; set; }

	// Token: 0x17000AEC RID: 2796
	// (get) Token: 0x06007073 RID: 28787
	// (set) Token: 0x06007074 RID: 28788
	float pRolloffEnd { get; set; }

	// Token: 0x17000AED RID: 2797
	// (get) Token: 0x06007075 RID: 28789
	// (set) Token: 0x06007076 RID: 28790
	bool pUseRolloffDistance { get; set; }

	// Token: 0x17000AEE RID: 2798
	// (get) Token: 0x06007077 RID: 28791
	// (set) Token: 0x06007078 RID: 28792
	bool pReleaseOnStop { get; set; }

	// Token: 0x17000AEF RID: 2799
	// (get) Token: 0x06007079 RID: 28793
	// (set) Token: 0x0600707A RID: 28794
	bool pFollowListener { get; set; }

	// Token: 0x17000AF0 RID: 2800
	// (get) Token: 0x0600707B RID: 28795
	// (set) Token: 0x0600707C RID: 28796
	GameObject pEventTarget { get; set; }

	// Token: 0x17000AF1 RID: 2801
	// (get) Token: 0x0600707D RID: 28797
	SnEventType pLastEvent { get; }

	// Token: 0x17000AF2 RID: 2802
	// (get) Token: 0x0600707E RID: 28798
	// (set) Token: 0x0600707F RID: 28799
	SnTriggerList pTriggers { get; set; }

	// Token: 0x17000AF3 RID: 2803
	// (get) Token: 0x06007080 RID: 28800
	// (set) Token: 0x06007081 RID: 28801
	bool pLoopQueue { get; set; }

	// Token: 0x17000AF4 RID: 2804
	// (get) Token: 0x06007082 RID: 28802
	// (set) Token: 0x06007083 RID: 28803
	AudioClip[] pClipQueue { get; set; }

	// Token: 0x17000AF5 RID: 2805
	// (get) Token: 0x06007084 RID: 28804
	// (set) Token: 0x06007085 RID: 28805
	SnTriggerList[] pTriggerQueue { get; set; }

	// Token: 0x17000AF6 RID: 2806
	// (get) Token: 0x06007086 RID: 28806
	// (set) Token: 0x06007087 RID: 28807
	SnSettings pDefaultSettings { get; set; }

	// Token: 0x06007088 RID: 28808
	bool Acquire();

	// Token: 0x06007089 RID: 28809
	bool Release();

	// Token: 0x0600708A RID: 28810
	void ApplySettings(SnSettings inSettings);

	// Token: 0x0600708B RID: 28811
	void Play();

	// Token: 0x0600708C RID: 28812
	void Play(SnSettings inSettings);

	// Token: 0x0600708D RID: 28813
	void Pause();

	// Token: 0x0600708E RID: 28814
	void Stop();

	// Token: 0x0600708F RID: 28815
	void Mute(bool mute);

	// Token: 0x06007090 RID: 28816
	void Kill();

	// Token: 0x06007091 RID: 28817
	void Tick();

	// Token: 0x06007092 RID: 28818
	void LoadTriggers(string inURL);
}
