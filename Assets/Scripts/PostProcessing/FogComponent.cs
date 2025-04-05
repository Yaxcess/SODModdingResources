using System;
using UnityEngine.Rendering;

namespace UnityEngine.PostProcessing
{
	// Token: 0x02001BAD RID: 7085
	public sealed class FogComponent : PostProcessingComponentCommandBuffer<FogModel>
	{
		// Token: 0x1700110F RID: 4367
		// (get) Token: 0x0600A77A RID: 42874 RVA: 0x00068BFB File Offset: 0x00066DFB
		public override bool active
		{
			get
			{
				return base.model.enabled && this.context.isGBufferAvailable && RenderSettings.fog && !this.context.interrupted;
			}
		}

		// Token: 0x0600A77B RID: 42875 RVA: 0x00068C2E File Offset: 0x00066E2E
		public override string GetName()
		{
			return "Fog";
		}

		// Token: 0x0600A77C RID: 42876 RVA: 0x0000617D File Offset: 0x0000437D
		public override DepthTextureMode GetCameraFlags()
		{
			return DepthTextureMode.Depth;
		}

		// Token: 0x0600A77D RID: 42877 RVA: 0x000641E8 File Offset: 0x000623E8
		public override CameraEvent GetCameraEvent()
		{
			return CameraEvent.AfterImageEffectsOpaque;
		}

		// Token: 0x0600A77E RID: 42878 RVA: 0x003A9084 File Offset: 0x003A7284
		public override void PopulateCommandBuffer(CommandBuffer cb)
		{
			FogModel.Settings settings = base.model.settings;
			Material material = this.context.materialFactory.Get("Hidden/Post FX/Fog");
			material.shaderKeywords = null;
			Color value = GraphicsUtils.isLinearColorSpace ? RenderSettings.fogColor.linear : RenderSettings.fogColor;
			material.SetColor(FogComponent.Uniforms._FogColor, value);
			material.SetFloat(FogComponent.Uniforms._Density, RenderSettings.fogDensity);
			material.SetFloat(FogComponent.Uniforms._Start, RenderSettings.fogStartDistance);
			material.SetFloat(FogComponent.Uniforms._End, RenderSettings.fogEndDistance);
			switch (RenderSettings.fogMode)
			{
			case FogMode.Linear:
				material.EnableKeyword("FOG_LINEAR");
				break;
			case FogMode.Exponential:
				material.EnableKeyword("FOG_EXP");
				break;
			case FogMode.ExponentialSquared:
				material.EnableKeyword("FOG_EXP2");
				break;
			}
			RenderTextureFormat format = this.context.isHdr ? RenderTextureFormat.DefaultHDR : RenderTextureFormat.Default;
			cb.GetTemporaryRT(FogComponent.Uniforms._TempRT, this.context.width, this.context.height, 24, FilterMode.Bilinear, format);
			cb.Blit(BuiltinRenderTextureType.CameraTarget, FogComponent.Uniforms._TempRT);
			cb.Blit(FogComponent.Uniforms._TempRT, BuiltinRenderTextureType.CameraTarget, material, settings.excludeSkybox ? 1 : 0);
			cb.ReleaseTemporaryRT(FogComponent.Uniforms._TempRT);
		}

		// Token: 0x0400AA92 RID: 43666
		private const string k_ShaderString = "Hidden/Post FX/Fog";

		// Token: 0x02001BAE RID: 7086
		private static class Uniforms
		{
			// Token: 0x0400AA93 RID: 43667
			internal static readonly int _FogColor = Shader.PropertyToID("_FogColor");

			// Token: 0x0400AA94 RID: 43668
			internal static readonly int _Density = Shader.PropertyToID("_Density");

			// Token: 0x0400AA95 RID: 43669
			internal static readonly int _Start = Shader.PropertyToID("_Start");

			// Token: 0x0400AA96 RID: 43670
			internal static readonly int _End = Shader.PropertyToID("_End");

			// Token: 0x0400AA97 RID: 43671
			internal static readonly int _TempRT = Shader.PropertyToID("_TempRT");
		}
	}
}
