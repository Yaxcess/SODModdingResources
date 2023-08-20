using System;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

// Token: 0x0200119E RID: 4510
[RequireComponent(typeof(AudioSource))]
[Serializable]
public class SnChannel : KAMonoBase, SnIChannel
{
	// Token: 0x17000AF7 RID: 2807
	// (get) Token: 0x06007094 RID: 28820 RVA: 0x0004CD96 File Offset: 0x0004AF96
	public string pName
	{
		get
		{
			return base.gameObject.name;
		}
	}

	// Token: 0x17000AF8 RID: 2808
	// (get) Token: 0x06007095 RID: 28821 RVA: 0x0004CDA3 File Offset: 0x0004AFA3
	public string pPool
	{
		get
		{
			return this._Pool;
		}
	}

	// Token: 0x17000AF9 RID: 2809
	// (get) Token: 0x06007096 RID: 28822 RVA: 0x0004CDAB File Offset: 0x0004AFAB
	// (set) Token: 0x06007097 RID: 28823 RVA: 0x0004CDB3 File Offset: 0x0004AFB3
	public int pPriority
	{
		get
		{
			return this._Priority;
		}
		set
		{
			this._Priority = value;
		}
	}


	// Token: 0x17000B00 RID: 2816
	// (get) Token: 0x0600709F RID: 28831 RVA: 0x0004CE1B File Offset: 0x0004B01B
	public AudioSource pAudioSource
	{
		get
		{
			return base.GetComponent<AudioSource>();
		}
	}

	// Token: 0x17000B02 RID: 2818
	// (get) Token: 0x060070A1 RID: 28833 RVA: 0x0004CE2B File Offset: 0x0004B02B
	public GameObject pGameObject
	{
		get
		{
			return base.gameObject;
		}
	}

	// Token: 0x17000B03 RID: 2819
	// (get) Token: 0x060070A2 RID: 28834 RVA: 0x0001B31A File Offset: 0x0001951A
	public Transform pTransform
	{
		get
		{
			return base.transform;
		}
	}

	

	


	// Token: 0x17000B09 RID: 2825
	// (get) Token: 0x060070AD RID: 28845 RVA: 0x0004CEB5 File Offset: 0x0004B0B5
	// (set) Token: 0x060070AE RID: 28846 RVA: 0x0004CEBD File Offset: 0x0004B0BD
	public bool pReleaseOnStop
	{
		get
		{
			return this._ReleaseOnStop;
		}
		set
		{
			this._ReleaseOnStop = value;
		}
	}

	// Token: 0x17000B0A RID: 2826
	// (get) Token: 0x060070AF RID: 28847 RVA: 0x0004CEC6 File Offset: 0x0004B0C6
	// (set) Token: 0x060070B0 RID: 28848 RVA: 0x0004CECE File Offset: 0x0004B0CE
	public bool pFollowListener
	{
		get
		{
			return this._FollowListener;
		}
		set
		{
			this._FollowListener = value;
		}
	}

	// Token: 0x17000B0B RID: 2827
	// (get) Token: 0x060070B1 RID: 28849 RVA: 0x0004CED7 File Offset: 0x0004B0D7
	// (set) Token: 0x060070B2 RID: 28850 RVA: 0x0004CEDF File Offset: 0x0004B0DF
	public GameObject pEventTarget
	{
		get
		{
			return this._EventTarget;
		}
		set
		{
			this._EventTarget = value;
		}
	}

	// Token: 0x17000B0E RID: 2830
	// (get) Token: 0x060070B6 RID: 28854 RVA: 0x0004CF13 File Offset: 0x0004B113
	// (set) Token: 0x060070B7 RID: 28855 RVA: 0x0004CF1B File Offset: 0x0004B11B
	public bool pLoopQueue
	{
		get
		{
			return this._LoopQueue;
		}
		set
		{
			this._LoopQueue = value;
		}
	}

	
	// Token: 0x04006DE7 RID: 28135
	public string _Pool = "";

	// Token: 0x04006DE8 RID: 28136
	public int _Priority;

	// Token: 0x04006DE9 RID: 28137
	public float _RolloffBegin;

	// Token: 0x04006DEA RID: 28138
	public float _RolloffEnd = float.PositiveInfinity;

	// Token: 0x04006DEB RID: 28139
	public float _RolloffMinVolume;

	// Token: 0x04006DEC RID: 28140
	public float _RolloffMaxVolume = 1f;

	// Token: 0x04006DED RID: 28141
	public bool _UseRolloffDistance;

	// Token: 0x04006DEE RID: 28142
	public bool _Persistent;

	// Token: 0x04006DEF RID: 28143
	public bool _ReleaseOnStop = true;

	// Token: 0x04006DF0 RID: 28144
	public bool _FollowListener;

    // Token: 0x04006DF2 RID: 28146
    public SnTriggerList _Triggers;

    // Token: 0x04006DF1 RID: 28145
    public GameObject _EventTarget;

	// Token: 0x04006DF3 RID: 28147
	public AudioClip[] _ClipQueue;

    // Token: 0x04006DF4 RID: 28148
    public SnTriggerList[] _TriggerQueue;

    // Token: 0x04006DF5 RID: 28149
    public bool _LoopQueue;

	// Token: 0x04006DF6 RID: 28150
	public bool _RandomQueue;

	// Token: 0x04006DF7 RID: 28151
	public bool _Draw;

	public bool Acquire()
	{
		return true;
	}

    // Token: 0x06007089 RID: 28809
    public bool Release()
	{
		return true;
	}

    // Token: 0x0600708A RID: 28810
    public void ApplySettings(SnSettings inSettings)
	{

	}

    // Token: 0x0600708B RID: 28811
    public void Play()
	{

	}

    // Token: 0x0600708C RID: 28812
    public void Play(SnSettings inSettings)
	{

	}

    // Token: 0x0600708D RID: 28813
    public void Pause()
	{

	}

    // Token: 0x0600708E RID: 28814
    public void Stop()
	{

	}

    // Token: 0x0600708F RID: 28815
    public void Mute(bool mute)
	{

	}

    // Token: 0x06007090 RID: 28816
    public void Kill()
	{

	}

    // Token: 0x06007091 RID: 28817
    public void Tick()
	{

	}

    // Token: 0x06007092 RID: 28818
    public void LoadTriggers(string inURL)
	{

	}

    // Token: 0x17000ADF RID: 2783
    // (get) Token: 0x06007062 RID: 28770
    public float pUseTime { get; }

    // Token: 0x17000AE0 RID: 2784
    // (get) Token: 0x06007063 RID: 28771
    public bool pInUse { get; }

    // Token: 0x17000AE1 RID: 2785
    // (get) Token: 0x06007064 RID: 28772
    public bool pIsStreaming { get; }

    // Token: 0x17000AE2 RID: 2786
    // (get) Token: 0x06007065 RID: 28773
    public bool pIsPlaying { get; }

    // Token: 0x17000AE3 RID: 2787
    // (get) Token: 0x06007066 RID: 28774
    public string pClipName { get; }

    // Token: 0x17000AE4 RID: 2788
    // (get) Token: 0x06007067 RID: 28775
    // (set) Token: 0x06007068 RID: 28776
    public AudioClip pClip { get; set; }

    // Token: 0x17000AE6 RID: 2790
    // (get) Token: 0x0600706A RID: 28778
    public SnIStream pAudioStream { get; }

    // Token: 0x17000AE9 RID: 2793
    // (get) Token: 0x0600706D RID: 28781
    // (set) Token: 0x0600706E RID: 28782
    public float pVolume { get; set; }

    // Token: 0x17000AEA RID: 2794
    // (get) Token: 0x0600706F RID: 28783
    // (set) Token: 0x06007070 RID: 28784
    public bool pLoop { get; set; }

    // Token: 0x17000AEB RID: 2795
    // (get) Token: 0x06007071 RID: 28785
    // (set) Token: 0x06007072 RID: 28786
    public float pRolloffBegin { get; set; }

    // Token: 0x17000AEC RID: 2796
    // (get) Token: 0x06007073 RID: 28787
    // (set) Token: 0x06007074 RID: 28788
    public float pRolloffEnd { get; set; }

    // Token: 0x17000AED RID: 2797
    // (get) Token: 0x06007075 RID: 28789
    // (set) Token: 0x06007076 RID: 28790
    public bool pUseRolloffDistance { get; set; }

    // Token: 0x17000AF1 RID: 2801
    // (get) Token: 0x0600707D RID: 28797
    public SnEventType pLastEvent { get; }

    // Token: 0x17000AF2 RID: 2802
    // (get) Token: 0x0600707E RID: 28798
    // (set) Token: 0x0600707F RID: 28799
    public SnTriggerList pTriggers { get; set; }

    // Token: 0x17000AF4 RID: 2804
    // (get) Token: 0x06007082 RID: 28802
    // (set) Token: 0x06007083 RID: 28803
    public AudioClip[] pClipQueue { get; set; }

    // Token: 0x17000AF5 RID: 2805
    // (get) Token: 0x06007084 RID: 28804
    // (set) Token: 0x06007085 RID: 28805
    public SnTriggerList[] pTriggerQueue { get; set; }

    // Token: 0x17000AF6 RID: 2806
    // (get) Token: 0x06007086 RID: 28806
    // (set) Token: 0x06007087 RID: 28807
    public SnSettings pDefaultSettings { get; set; }

    // Token: 0x0200119F RID: 4511
    [Serializable]
	public class Pool
	{
		

	}
}
