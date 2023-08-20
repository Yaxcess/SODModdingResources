using System;

// Token: 0x02001194 RID: 4500
public interface SnIStream
{
	// Token: 0x17000AD3 RID: 2771
	// (get) Token: 0x06007044 RID: 28740
	bool pPlaying { get; }

	// Token: 0x17000AD4 RID: 2772
	// (get) Token: 0x06007045 RID: 28741
	// (set) Token: 0x06007046 RID: 28742
	bool pPaused { get; set; }

	// Token: 0x17000AD5 RID: 2773
	// (get) Token: 0x06007047 RID: 28743
	bool pActive { get; }

	// Token: 0x17000AD6 RID: 2774
	// (get) Token: 0x06007048 RID: 28744
	uint pPosition { get; }

	// Token: 0x17000AD7 RID: 2775
	// (get) Token: 0x06007049 RID: 28745
	uint pLength { get; }

	// Token: 0x17000AD8 RID: 2776
	// (get) Token: 0x0600704A RID: 28746
	// (set) Token: 0x0600704B RID: 28747
	float pVolume { get; set; }

	// Token: 0x17000AD9 RID: 2777
	// (get) Token: 0x0600704C RID: 28748
	// (set) Token: 0x0600704D RID: 28749
	bool pLoop { get; set; }

	// Token: 0x0600704E RID: 28750
	void Stop();
}
