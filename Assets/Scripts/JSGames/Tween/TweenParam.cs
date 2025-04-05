using System;
using UnityEngine;

namespace JSGames.Tween
{
	// Token: 0x02001B16 RID: 6934
	[Serializable]
	public class TweenParam
	{
		// Token: 0x0400A714 RID: 42772
		public float _DurationOrSpeed = 1f;

		// Token: 0x0400A715 RID: 42773
		public float _Delay;

		// Token: 0x0400A716 RID: 42774
		public int _LoopCount = 1;

		// Token: 0x0400A717 RID: 42775
		public bool _PingPong;

		// Token: 0x0400A718 RID: 42776
		public EaseType _Type;

		// Token: 0x0400A719 RID: 42777
		public bool _UseAnimationCurve;

		// Token: 0x0400A71A RID: 42778
		public AnimationCurve _AnimationCurve;
	}
}
