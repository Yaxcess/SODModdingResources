using System;
using UnityEngine;
using JSGames.Tween;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace JSGames.UI
{
	// Token: 0x02001B34 RID: 6964
	[Serializable]
	public class UIEffects
	{

		// Token: 0x0400A7D7 RID: 42967
		public SnSound _Clip;

		// Token: 0x0400A7DE RID: 42974
		public float _MaxDuration = -1f;

		// Token: 0x02001B35 RID: 6965
		[Serializable]
		public class PositionEffectData
		{
			// Token: 0x0400A7E1 RID: 42977
			public float _Time = 0.1f;

			// Token: 0x0400A7E2 RID: 42978
			public Vector3 _Offset;

			// Token: 0x0400A7E3 RID: 42979
			public EaseType _PositionEffect = EaseType.EaseInOutBack;

			// Token: 0x0400A7E4 RID: 42980
			public UIBehaviour _Widget;
		}

		// Token: 0x02001B36 RID: 6966
		[Serializable]
		public class ScaleEffectData
		{
			// Token: 0x0400A7E5 RID: 42981
			public float _Time = 0.1f;

			// Token: 0x0400A7E6 RID: 42982
			public Vector3 _Scale = Vector2.one * 1.5f;

			// Token: 0x0400A7E7 RID: 42983
			public EaseType _ScaleEffect = EaseType.EaseInOutBack;

			// Token: 0x0400A7E8 RID: 42984
			public UIBehaviour _Widget;
		}

		// Token: 0x02001B37 RID: 6967
		[Serializable]
		public class RotationEffectData
		{
			// Token: 0x0400A7E9 RID: 42985
			public float _Time = 0.1f;

			// Token: 0x0400A7EA RID: 42986
			public Vector3 _Rotate;

			// Token: 0x0400A7EB RID: 42987
			public EaseType _RotateEffect = EaseType.EaseInOutBack;

			// Token: 0x0400A7EC RID: 42988
			public UIBehaviour _Widget;
		}

		// Token: 0x02001B38 RID: 6968
		[Serializable]
		public class ColorEffectData
		{
			// Token: 0x0400A7ED RID: 42989
			public float _Time = 0.1f;

			// Token: 0x0400A7EE RID: 42990
			public Color _Color = Color.grey;

			// Token: 0x0400A7EF RID: 42991
			public EaseType _ColorEffect = EaseType.EaseInOutBack;

			// Token: 0x0400A7F0 RID: 42992
			public UIBehaviour _Widget;
		}

		// Token: 0x02001B39 RID: 6969
		[Serializable]
		public class SpriteEffectData
		{
			// Token: 0x0400A7F1 RID: 42993
			public Sprite _Sprite;

			// Token: 0x0400A7F2 RID: 42994
			public UIBehaviour _Widget;
		}

		// Token: 0x02001B3A RID: 6970
		[Serializable]
		public class ParticleEffectData
		{
			// Token: 0x0400A7F3 RID: 42995
			public ParticleSystem _Particle;

			// Token: 0x0400A7F4 RID: 42996
			public float _StartSize;
		}

		// Token: 0x02001B3B RID: 6971
		public abstract class EffectBase<ModifyType, WidgetDataType>
		{
			
			public abstract void ShowEffect(bool showEffect);

			// Token: 0x0400A7F5 RID: 42997
			public bool _UseEffect;

			// Token: 0x0400A7F6 RID: 42998
			public WidgetDataType[] _ApplyTo;

			// Token: 0x0400A7F7 RID: 42999
			protected ModifyType[] mOriginalValues;
		}

		// Token: 0x02001B41 RID: 6977
		[Serializable]
		public class ParticleEffect
		{
			// Token: 0x0400A7F8 RID: 43000
			public UIEffects.ParticleEffectData[] _Particles;
		}
	}
}
