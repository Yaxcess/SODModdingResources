using System;
using System.Collections.Generic;
using UnityEngine.Rendering;

namespace UnityEngine.PostProcessing
{
	// Token: 0x02001B9F RID: 7071
	public sealed class BuiltinDebugViewsComponent : PostProcessingComponentCommandBuffer<BuiltinDebugViewsModel>
	{
		// Token: 0x17001106 RID: 4358
		// (get) Token: 0x0600A72F RID: 42799 RVA: 0x00068863 File Offset: 0x00066A63
		public override bool active
		{
			get
			{
				return base.model.IsModeActive(BuiltinDebugViewsModel.Mode.Depth) || base.model.IsModeActive(BuiltinDebugViewsModel.Mode.Normals) || base.model.IsModeActive(BuiltinDebugViewsModel.Mode.MotionVectors);
			}
		}

		// Token: 0x0600A730 RID: 42800 RVA: 0x003A710C File Offset: 0x003A530C
		public override DepthTextureMode GetCameraFlags()
		{
			BuiltinDebugViewsModel.Mode mode = base.model.settings.mode;
			DepthTextureMode depthTextureMode = DepthTextureMode.None;
			switch (mode)
			{
			case BuiltinDebugViewsModel.Mode.Depth:
				depthTextureMode |= DepthTextureMode.Depth;
				break;
			case BuiltinDebugViewsModel.Mode.Normals:
				depthTextureMode |= DepthTextureMode.DepthNormals;
				break;
			case BuiltinDebugViewsModel.Mode.MotionVectors:
				depthTextureMode |= (DepthTextureMode.Depth | DepthTextureMode.MotionVectors);
				break;
			}
			return depthTextureMode;
		}

		// Token: 0x0600A731 RID: 42801 RVA: 0x0006888F File Offset: 0x00066A8F
		public override CameraEvent GetCameraEvent()
		{
			if (base.model.settings.mode != BuiltinDebugViewsModel.Mode.MotionVectors)
			{
				return CameraEvent.BeforeImageEffectsOpaque;
			}
			return CameraEvent.BeforeImageEffects;
		}

		// Token: 0x0600A732 RID: 42802 RVA: 0x000688A9 File Offset: 0x00066AA9
		public override string GetName()
		{
			return "Builtin Debug Views";
		}

		// Token: 0x0600A733 RID: 42803 RVA: 0x003A7154 File Offset: 0x003A5354
		public override void PopulateCommandBuffer(CommandBuffer cb)
		{
			
		}

		// Token: 0x0600A734 RID: 42804 RVA: 0x003A71E4 File Offset: 0x003A53E4
		private void DepthPass(CommandBuffer cb)
		{
			Material mat = this.context.materialFactory.Get("Hidden/Post FX/Builtin Debug Views");
			BuiltinDebugViewsModel.DepthSettings depth = base.model.settings.depth;
			cb.SetGlobalFloat(BuiltinDebugViewsComponent.Uniforms._DepthScale, 1f / depth.scale);
			cb.Blit(null, BuiltinRenderTextureType.CameraTarget, mat, 0);
		}

		// Token: 0x0600A735 RID: 42805 RVA: 0x003A7240 File Offset: 0x003A5440
		private void DepthNormalsPass(CommandBuffer cb)
		{
			Material mat = this.context.materialFactory.Get("Hidden/Post FX/Builtin Debug Views");
			cb.Blit(null, BuiltinRenderTextureType.CameraTarget, mat, 1);
		}

		// Token: 0x0600A736 RID: 42806 RVA: 0x003A7274 File Offset: 0x003A5474
		private void MotionVectorsPass(CommandBuffer cb)
		{
			Material material = this.context.materialFactory.Get("Hidden/Post FX/Builtin Debug Views");
			BuiltinDebugViewsModel.MotionVectorsSettings motionVectors = base.model.settings.motionVectors;
			int nameID = BuiltinDebugViewsComponent.Uniforms._TempRT;
			cb.GetTemporaryRT(nameID, this.context.width, this.context.height, 0, FilterMode.Bilinear);
			cb.SetGlobalFloat(BuiltinDebugViewsComponent.Uniforms._Opacity, motionVectors.sourceOpacity);
			cb.SetGlobalTexture(BuiltinDebugViewsComponent.Uniforms._MainTex, BuiltinRenderTextureType.CameraTarget);
			cb.Blit(BuiltinRenderTextureType.CameraTarget, nameID, material, 2);
			if (motionVectors.motionImageOpacity > 0f && motionVectors.motionImageAmplitude > 0f)
			{
				int tempRT = BuiltinDebugViewsComponent.Uniforms._TempRT2;
				cb.GetTemporaryRT(tempRT, this.context.width, this.context.height, 0, FilterMode.Bilinear);
				cb.SetGlobalFloat(BuiltinDebugViewsComponent.Uniforms._Opacity, motionVectors.motionImageOpacity);
				cb.SetGlobalFloat(BuiltinDebugViewsComponent.Uniforms._Amplitude, motionVectors.motionImageAmplitude);
				cb.SetGlobalTexture(BuiltinDebugViewsComponent.Uniforms._MainTex, nameID);
				cb.Blit(nameID, tempRT, material, 3);
				cb.ReleaseTemporaryRT(nameID);
				nameID = tempRT;
			}
			if (motionVectors.motionVectorsOpacity > 0f && motionVectors.motionVectorsAmplitude > 0f)
			{
				this.PrepareArrows();
				float num = 1f / (float)motionVectors.motionVectorsResolution;
				float x = num * (float)this.context.height / (float)this.context.width;
				cb.SetGlobalVector(BuiltinDebugViewsComponent.Uniforms._Scale, new Vector2(x, num));
				cb.SetGlobalFloat(BuiltinDebugViewsComponent.Uniforms._Opacity, motionVectors.motionVectorsOpacity);
				cb.SetGlobalFloat(BuiltinDebugViewsComponent.Uniforms._Amplitude, motionVectors.motionVectorsAmplitude);
				cb.DrawMesh(this.m_Arrows.mesh, Matrix4x4.identity, material, 0, 4);
			}
			cb.SetGlobalTexture(BuiltinDebugViewsComponent.Uniforms._MainTex, nameID);
			cb.Blit(nameID, BuiltinRenderTextureType.CameraTarget);
			cb.ReleaseTemporaryRT(nameID);
		}

		// Token: 0x0600A737 RID: 42807 RVA: 0x003A7468 File Offset: 0x003A5668
		private void PrepareArrows()
		{
			int motionVectorsResolution = base.model.settings.motionVectors.motionVectorsResolution;
			int num = motionVectorsResolution * Screen.width / Screen.height;
			if (this.m_Arrows == null)
			{
				this.m_Arrows = new BuiltinDebugViewsComponent.ArrowArray();
			}
			if (this.m_Arrows.columnCount != num || this.m_Arrows.rowCount != motionVectorsResolution)
			{
				this.m_Arrows.Release();
				this.m_Arrows.BuildMesh(num, motionVectorsResolution);
			}
		}

		// Token: 0x0600A738 RID: 42808 RVA: 0x000688B0 File Offset: 0x00066AB0
		public override void OnDisable()
		{
			if (this.m_Arrows != null)
			{
				this.m_Arrows.Release();
			}
			this.m_Arrows = null;
		}

		// Token: 0x0400AA40 RID: 43584
		private const string k_ShaderString = "Hidden/Post FX/Builtin Debug Views";

		// Token: 0x0400AA41 RID: 43585
		private BuiltinDebugViewsComponent.ArrowArray m_Arrows;

		// Token: 0x02001BA0 RID: 7072
		private static class Uniforms
		{
			// Token: 0x0400AA42 RID: 43586
			internal static readonly int _DepthScale = Shader.PropertyToID("_DepthScale");

			// Token: 0x0400AA43 RID: 43587
			internal static readonly int _TempRT = Shader.PropertyToID("_TempRT");

			// Token: 0x0400AA44 RID: 43588
			internal static readonly int _Opacity = Shader.PropertyToID("_Opacity");

			// Token: 0x0400AA45 RID: 43589
			internal static readonly int _MainTex = Shader.PropertyToID("_MainTex");

			// Token: 0x0400AA46 RID: 43590
			internal static readonly int _TempRT2 = Shader.PropertyToID("_TempRT2");

			// Token: 0x0400AA47 RID: 43591
			internal static readonly int _Amplitude = Shader.PropertyToID("_Amplitude");

			// Token: 0x0400AA48 RID: 43592
			internal static readonly int _Scale = Shader.PropertyToID("_Scale");
		}

		// Token: 0x02001BA1 RID: 7073
		private enum Pass
		{
			// Token: 0x0400AA4A RID: 43594
			Depth,
			// Token: 0x0400AA4B RID: 43595
			Normals,
			// Token: 0x0400AA4C RID: 43596
			MovecOpacity,
			// Token: 0x0400AA4D RID: 43597
			MovecImaging,
			// Token: 0x0400AA4E RID: 43598
			MovecArrows
		}

		// Token: 0x02001BA2 RID: 7074
		private class ArrowArray
		{
			// Token: 0x17001107 RID: 4359
			// (get) Token: 0x0600A73B RID: 42811 RVA: 0x000688D4 File Offset: 0x00066AD4
			// (set) Token: 0x0600A73C RID: 42812 RVA: 0x000688DC File Offset: 0x00066ADC
			public Mesh mesh { get; private set; }

			// Token: 0x17001108 RID: 4360
			// (get) Token: 0x0600A73D RID: 42813 RVA: 0x000688E5 File Offset: 0x00066AE5
			// (set) Token: 0x0600A73E RID: 42814 RVA: 0x000688ED File Offset: 0x00066AED
			public int columnCount { get; private set; }

			// Token: 0x17001109 RID: 4361
			// (get) Token: 0x0600A73F RID: 42815 RVA: 0x000688F6 File Offset: 0x00066AF6
			// (set) Token: 0x0600A740 RID: 42816 RVA: 0x000688FE File Offset: 0x00066AFE
			public int rowCount { get; private set; }

			// Token: 0x0600A741 RID: 42817 RVA: 0x003A7558 File Offset: 0x003A5758
			public void BuildMesh(int columns, int rows)
			{
				Vector3[] array = new Vector3[]
				{
					new Vector3(0f, 0f, 0f),
					new Vector3(0f, 1f, 0f),
					new Vector3(0f, 1f, 0f),
					new Vector3(-1f, 1f, 0f),
					new Vector3(0f, 1f, 0f),
					new Vector3(1f, 1f, 0f)
				};
				int num = 6 * columns * rows;
				List<Vector3> list = new List<Vector3>(num);
				List<Vector2> list2 = new List<Vector2>(num);
				for (int i = 0; i < rows; i++)
				{
					for (int j = 0; j < columns; j++)
					{
						Vector2 item = new Vector2((0.5f + (float)j) / (float)columns, (0.5f + (float)i) / (float)rows);
						for (int k = 0; k < 6; k++)
						{
							list.Add(array[k]);
							list2.Add(item);
						}
					}
				}
				int[] array2 = new int[num];
				for (int l = 0; l < num; l++)
				{
					array2[l] = l;
				}
				this.mesh = new Mesh
				{
					hideFlags = HideFlags.DontSave
				};
				this.mesh.SetVertices(list);
				this.mesh.SetUVs(0, list2);
				this.mesh.SetIndices(array2, MeshTopology.Lines, 0);
				this.mesh.UploadMeshData(true);
				this.columnCount = columns;
				this.rowCount = rows;
			}

			// Token: 0x0600A742 RID: 42818 RVA: 0x00068907 File Offset: 0x00066B07
			public void Release()
			{
				GraphicsUtils.Destroy(this.mesh);
				this.mesh = null;
			}
		}
	}
}
