using System;

namespace UnityEngine.PostProcessing
{
	// Token: 0x02001BBE RID: 7102
	public sealed class UserLutComponent : PostProcessingComponentRenderTexture<UserLutModel>
	{
		// Token: 0x17001118 RID: 4376
		// (get) Token: 0x0600A7BB RID: 42939 RVA: 0x003AAFE8 File Offset: 0x003A91E8
		public override bool active
		{
			get
			{
				UserLutModel.Settings settings = base.model.settings;
				return base.model.enabled && settings.lut != null && settings.contribution > 0f && settings.lut.height == (int)Mathf.Sqrt((float)settings.lut.width) && !this.context.interrupted;
			}
		}

		// Token: 0x0600A7BC RID: 42940 RVA: 0x003AB058 File Offset: 0x003A9258
		public override void Prepare(Material uberMaterial)
		{
			UserLutModel.Settings settings = base.model.settings;
			uberMaterial.EnableKeyword("USER_LUT");
			uberMaterial.SetTexture(UserLutComponent.Uniforms._UserLut, settings.lut);
			uberMaterial.SetVector(UserLutComponent.Uniforms._UserLut_Params, new Vector4(1f / (float)settings.lut.width, 1f / (float)settings.lut.height, (float)settings.lut.height - 1f, settings.contribution));
		}

		// Token: 0x0600A7BD RID: 42941 RVA: 0x003AB0DC File Offset: 0x003A92DC
		public void OnGUI()
		{
			UserLutModel.Settings settings = base.model.settings;
			GUI.DrawTexture(new Rect(this.context.viewport.x * (float)Screen.width + 8f, 8f, (float)settings.lut.width, (float)settings.lut.height), settings.lut);
		}

		// Token: 0x02001BBF RID: 7103
		private static class Uniforms
		{
			// Token: 0x0400AB0E RID: 43790
			internal static readonly int _UserLut = Shader.PropertyToID("_UserLut");

			// Token: 0x0400AB0F RID: 43791
			internal static readonly int _UserLut_Params = Shader.PropertyToID("_UserLut_Params");
		}
	}
}
