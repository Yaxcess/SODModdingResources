using System;

namespace UnityEngine.PostProcessing
{
	// Token: 0x02001C04 RID: 7172
	public class PostProcessingProfile : ScriptableObject
	{
		// Token: 0x0400AC08 RID: 44040
		public BuiltinDebugViewsModel debugViews = new BuiltinDebugViewsModel();

		// Token: 0x0400AC09 RID: 44041
		public FogModel fog = new FogModel();

		// Token: 0x0400AC0A RID: 44042
		public AntialiasingModel antialiasing = new AntialiasingModel();

		// Token: 0x0400AC0B RID: 44043
		public AmbientOcclusionModel ambientOcclusion = new AmbientOcclusionModel();

		// Token: 0x0400AC0C RID: 44044
		public ScreenSpaceReflectionModel screenSpaceReflection = new ScreenSpaceReflectionModel();

		// Token: 0x0400AC0D RID: 44045
		public DepthOfFieldModel depthOfField = new DepthOfFieldModel();

		// Token: 0x0400AC0E RID: 44046
		public MotionBlurModel motionBlur = new MotionBlurModel();

		// Token: 0x0400AC0F RID: 44047
		public EyeAdaptationModel eyeAdaptation = new EyeAdaptationModel();

		// Token: 0x0400AC10 RID: 44048
		public BloomModel bloom = new BloomModel();

		// Token: 0x0400AC11 RID: 44049
		public ColorGradingModel colorGrading = new ColorGradingModel();

		// Token: 0x0400AC12 RID: 44050
		public UserLutModel userLut = new UserLutModel();

		// Token: 0x0400AC13 RID: 44051
		public ChromaticAberrationModel chromaticAberration = new ChromaticAberrationModel();

		// Token: 0x0400AC14 RID: 44052
		public GrainModel grain = new GrainModel();

		// Token: 0x0400AC15 RID: 44053
		public VignetteModel vignette = new VignetteModel();

		// Token: 0x0400AC16 RID: 44054
		public DitheringModel dithering = new DitheringModel();
	}
}
