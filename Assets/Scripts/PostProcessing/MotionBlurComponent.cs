using System;
using System.Runtime.CompilerServices;
using UnityEngine.Rendering;

namespace UnityEngine.PostProcessing
{
	public sealed class MotionBlurComponent : PostProcessingComponentCommandBuffer<MotionBlurModel>
	{
		public override bool active
		{
			get
			{
				return true;
			}
		}

		// Token: 0x0600A78D RID: 42893 RVA: 0x00068D64 File Offset: 0x00066F64
		public override string GetName()
		{
			return "Motion Blur";
		}

		public override DepthTextureMode GetCameraFlags()
		{
			return DepthTextureMode.Depth | DepthTextureMode.MotionVectors;
		}

		// Token: 0x0600A790 RID: 42896 RVA: 0x00068D87 File Offset: 0x00066F87
		public override CameraEvent GetCameraEvent()
		{
			return CameraEvent.BeforeImageEffects;
		}

		// Token: 0x0600A791 RID: 42897 RVA: 0x00068D8B File Offset: 0x00066F8B
		public override void OnEnable()
		{
		}

		public override void PopulateCommandBuffer(CommandBuffer cb)
		{
			
		}

		public override void OnDisable()
		{
		}

		public class ReconstructionFilter
		{
		}

		public class FrameBlendingFilter
		{
			
		}
	}
}
