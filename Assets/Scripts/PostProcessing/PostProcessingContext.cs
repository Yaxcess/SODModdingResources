using System;

namespace UnityEngine.PostProcessing
{
	// Token: 0x02001C02 RID: 7170
	public class PostProcessingContext
	{
		// Token: 0x1700114B RID: 4427
		// (get) Token: 0x0600A849 RID: 43081 RVA: 0x00069354 File Offset: 0x00067554
		// (set) Token: 0x0600A84A RID: 43082 RVA: 0x0006935C File Offset: 0x0006755C
		public bool interrupted { get; private set; }

		// Token: 0x0600A84B RID: 43083 RVA: 0x00069365 File Offset: 0x00067565
		public void Interrupt()
		{
			this.interrupted = true;
		}

		// Token: 0x0600A84C RID: 43084 RVA: 0x0006936E File Offset: 0x0006756E
		public PostProcessingContext Reset()
		{
			this.profile = null;
			this.camera = null;
			this.materialFactory = null;
			this.renderTextureFactory = null;
			this.interrupted = false;
			return this;
		}

		// Token: 0x1700114C RID: 4428
		// (get) Token: 0x0600A84D RID: 43085 RVA: 0x00069394 File Offset: 0x00067594
		public bool isGBufferAvailable
		{
			get
			{
				return this.camera.actualRenderingPath == RenderingPath.DeferredShading;
			}
		}

		// Token: 0x1700114D RID: 4429
		// (get) Token: 0x0600A84E RID: 43086 RVA: 0x000693A4 File Offset: 0x000675A4
		public bool isHdr
		{
			get
			{
				return this.camera.allowHDR;
			}
		}

		// Token: 0x1700114E RID: 4430
		// (get) Token: 0x0600A84F RID: 43087 RVA: 0x000693B1 File Offset: 0x000675B1
		public int width
		{
			get
			{
				return this.camera.pixelWidth;
			}
		}

		// Token: 0x1700114F RID: 4431
		// (get) Token: 0x0600A850 RID: 43088 RVA: 0x000693BE File Offset: 0x000675BE
		public int height
		{
			get
			{
				return this.camera.pixelHeight;
			}
		}

		// Token: 0x17001150 RID: 4432
		// (get) Token: 0x0600A851 RID: 43089 RVA: 0x000693CB File Offset: 0x000675CB
		public Rect viewport
		{
			get
			{
				return this.camera.rect;
			}
		}

		// Token: 0x0400AC02 RID: 44034
		public PostProcessingProfile profile;

		// Token: 0x0400AC03 RID: 44035
		public Camera camera;

		// Token: 0x0400AC04 RID: 44036
		public MaterialFactory materialFactory;

		// Token: 0x0400AC05 RID: 44037
		public RenderTextureFactory renderTextureFactory;
	}
}
