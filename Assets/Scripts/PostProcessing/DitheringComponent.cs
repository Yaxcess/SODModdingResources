using System;

namespace UnityEngine.PostProcessing
{
	// Token: 0x02001BA9 RID: 7081
	public sealed class DitheringComponent : PostProcessingComponentRenderTexture<DitheringModel>
	{
		// Token: 0x1700110D RID: 4365
		// (get) Token: 0x0600A76B RID: 42859 RVA: 0x00068B61 File Offset: 0x00066D61
		public override bool active
		{
			get
			{
				return base.model.enabled && !this.context.interrupted;
			}
		}

		// Token: 0x0600A76C RID: 42860 RVA: 0x00068B80 File Offset: 0x00066D80
		public override void OnDisable()
		{
			this.noiseTextures = null;
		}

		// Token: 0x0600A76D RID: 42861 RVA: 0x003A8A20 File Offset: 0x003A6C20
		private void LoadNoiseTextures()
		{
			this.noiseTextures = new Texture2D[64];
			for (int i = 0; i < 64; i++)
			{
				this.noiseTextures[i] = Resources.Load<Texture2D>("Bluenoise64/LDR_LLL1_" + i.ToString());
			}
		}

		// Token: 0x0600A76E RID: 42862 RVA: 0x003A8A68 File Offset: 0x003A6C68
		public override void Prepare(Material uberMaterial)
		{
			int num = this.textureIndex + 1;
			this.textureIndex = num;
			if (num >= 64)
			{
				this.textureIndex = 0;
			}
			float value = Random.value;
			float value2 = Random.value;
			if (this.noiseTextures == null)
			{
				this.LoadNoiseTextures();
			}
			Texture2D texture2D = this.noiseTextures[this.textureIndex];
			uberMaterial.EnableKeyword("DITHERING");
			uberMaterial.SetTexture(DitheringComponent.Uniforms._DitheringTex, texture2D);
			uberMaterial.SetVector(DitheringComponent.Uniforms._DitheringCoords, new Vector4((float)this.context.width / (float)texture2D.width, (float)this.context.height / (float)texture2D.height, value, value2));
		}

		// Token: 0x0400AA7C RID: 43644
		private Texture2D[] noiseTextures;

		// Token: 0x0400AA7D RID: 43645
		private int textureIndex;

		// Token: 0x0400AA7E RID: 43646
		private const int k_TextureCount = 64;

		// Token: 0x02001BAA RID: 7082
		private static class Uniforms
		{
			// Token: 0x0400AA7F RID: 43647
			internal static readonly int _DitheringTex = Shader.PropertyToID("_DitheringTex");

			// Token: 0x0400AA80 RID: 43648
			internal static readonly int _DitheringCoords = Shader.PropertyToID("_DitheringCoords");
		}
	}
}
