using System;

namespace UnityEngine.PostProcessing
{
	// Token: 0x02001BF1 RID: 7153
	[Serializable]
	public class ScreenSpaceReflectionModel : PostProcessingModel
	{
		// Token: 0x17001143 RID: 4419
		// (get) Token: 0x0600A818 RID: 43032 RVA: 0x0006921A File Offset: 0x0006741A
		// (set) Token: 0x0600A819 RID: 43033 RVA: 0x00069222 File Offset: 0x00067422
		public ScreenSpaceReflectionModel.Settings settings
		{
			get
			{
				return this.m_Settings;
			}
			set
			{
				this.m_Settings = value;
			}
		}

		// Token: 0x0600A81A RID: 43034 RVA: 0x0006922B File Offset: 0x0006742B
		public override void Reset()
		{
			this.m_Settings = ScreenSpaceReflectionModel.Settings.defaultSettings;
		}

		// Token: 0x0400ABBC RID: 43964
		[SerializeField]
		private ScreenSpaceReflectionModel.Settings m_Settings = ScreenSpaceReflectionModel.Settings.defaultSettings;

		// Token: 0x02001BF2 RID: 7154
		public enum SSRResolution
		{
			// Token: 0x0400ABBE RID: 43966
			High,
			// Token: 0x0400ABBF RID: 43967
			Low = 2
		}

		// Token: 0x02001BF3 RID: 7155
		public enum SSRReflectionBlendType
		{
			// Token: 0x0400ABC1 RID: 43969
			PhysicallyBased,
			// Token: 0x0400ABC2 RID: 43970
			Additive
		}

		// Token: 0x02001BF4 RID: 7156
		[Serializable]
		public struct IntensitySettings
		{
			// Token: 0x0400ABC3 RID: 43971
			[Tooltip("Nonphysical multiplier for the SSR reflections. 1.0 is physically based.")]
			[Range(0f, 2f)]
			public float reflectionMultiplier;

			// Token: 0x0400ABC4 RID: 43972
			[Tooltip("How far away from the maxDistance to begin fading SSR.")]
			[Range(0f, 1000f)]
			public float fadeDistance;

			// Token: 0x0400ABC5 RID: 43973
			[Tooltip("Amplify Fresnel fade out. Increase if floor reflections look good close to the surface and bad farther 'under' the floor.")]
			[Range(0f, 1f)]
			public float fresnelFade;

			// Token: 0x0400ABC6 RID: 43974
			[Tooltip("Higher values correspond to a faster Fresnel fade as the reflection changes from the grazing angle.")]
			[Range(0.1f, 10f)]
			public float fresnelFadePower;
		}

		// Token: 0x02001BF5 RID: 7157
		[Serializable]
		public struct ReflectionSettings
		{
			// Token: 0x0400ABC7 RID: 43975
			[Tooltip("How the reflections are blended into the render.")]
			public ScreenSpaceReflectionModel.SSRReflectionBlendType blendType;

			// Token: 0x0400ABC8 RID: 43976
			[Tooltip("Half resolution SSRR is much faster, but less accurate.")]
			public ScreenSpaceReflectionModel.SSRResolution reflectionQuality;

			// Token: 0x0400ABC9 RID: 43977
			[Tooltip("Maximum reflection distance in world units.")]
			[Range(0.1f, 300f)]
			public float maxDistance;

			// Token: 0x0400ABCA RID: 43978
			[Tooltip("Max raytracing length.")]
			[Range(16f, 1024f)]
			public int iterationCount;

			// Token: 0x0400ABCB RID: 43979
			[Tooltip("Log base 2 of ray tracing coarse step size. Higher traces farther, lower gives better quality silhouettes.")]
			[Range(1f, 16f)]
			public int stepSize;

			// Token: 0x0400ABCC RID: 43980
			[Tooltip("Typical thickness of columns, walls, furniture, and other objects that reflection rays might pass behind.")]
			[Range(0.01f, 10f)]
			public float widthModifier;

			// Token: 0x0400ABCD RID: 43981
			[Tooltip("Blurriness of reflections.")]
			[Range(0.1f, 8f)]
			public float reflectionBlur;

			// Token: 0x0400ABCE RID: 43982
			[Tooltip("Disable for a performance gain in scenes where most glossy objects are horizontal, like floors, water, and tables. Leave on for scenes with glossy vertical objects.")]
			public bool reflectBackfaces;
		}

		// Token: 0x02001BF6 RID: 7158
		[Serializable]
		public struct ScreenEdgeMask
		{
			// Token: 0x0400ABCF RID: 43983
			[Tooltip("Higher = fade out SSRR near the edge of the screen so that reflections don't pop under camera motion.")]
			[Range(0f, 1f)]
			public float intensity;
		}

		// Token: 0x02001BF7 RID: 7159
		[Serializable]
		public struct Settings
		{
			// Token: 0x17001144 RID: 4420
			// (get) Token: 0x0600A81C RID: 43036 RVA: 0x003ABDE4 File Offset: 0x003A9FE4
			public static ScreenSpaceReflectionModel.Settings defaultSettings
			{
				get
				{
					return new ScreenSpaceReflectionModel.Settings
					{
						reflection = new ScreenSpaceReflectionModel.ReflectionSettings
						{
							blendType = ScreenSpaceReflectionModel.SSRReflectionBlendType.PhysicallyBased,
							reflectionQuality = ScreenSpaceReflectionModel.SSRResolution.Low,
							maxDistance = 100f,
							iterationCount = 256,
							stepSize = 3,
							widthModifier = 0.5f,
							reflectionBlur = 1f,
							reflectBackfaces = false
						},
						intensity = new ScreenSpaceReflectionModel.IntensitySettings
						{
							reflectionMultiplier = 1f,
							fadeDistance = 100f,
							fresnelFade = 1f,
							fresnelFadePower = 1f
						},
						screenEdgeMask = new ScreenSpaceReflectionModel.ScreenEdgeMask
						{
							intensity = 0.03f
						}
					};
				}
			}

			// Token: 0x0400ABD0 RID: 43984
			public ScreenSpaceReflectionModel.ReflectionSettings reflection;

			// Token: 0x0400ABD1 RID: 43985
			public ScreenSpaceReflectionModel.IntensitySettings intensity;

			// Token: 0x0400ABD2 RID: 43986
			public ScreenSpaceReflectionModel.ScreenEdgeMask screenEdgeMask;
		}
	}
}
