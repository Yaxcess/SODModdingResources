using System;
using UnityEngine;

// Token: 0x02000A7B RID: 2683
public class KAMonoBase : MonoBehaviour
{
	// Token: 0x17000664 RID: 1636
	// (get) Token: 0x06003D8B RID: 15755 RVA: 0x0002A976 File Offset: 0x00028B76
	public new Transform transform
	{
		get
		{
			if (this.mCachedTransform == null)
			{
				this.mCachedTransform = base.transform;
			}
			return this.mCachedTransform;
		}
	}

	// Token: 0x17000665 RID: 1637
	// (get) Token: 0x06003D8C RID: 15756 RVA: 0x0002A998 File Offset: 0x00028B98
	public new GameObject gameObject
	{
		get
		{
			if (this.mCachedGameObject == null)
			{
				this.mCachedGameObject = base.gameObject;
			}
			return this.mCachedGameObject;
		}
	}

	// Token: 0x17000666 RID: 1638
	// (get) Token: 0x06003D8D RID: 15757 RVA: 0x0002A9BA File Offset: 0x00028BBA
	public Rigidbody rigidbody
	{
		get
		{
			if (this.mCachedRigidBody == null)
			{
				this.mCachedRigidBody = base.GetComponent<Rigidbody>();
			}
			return this.mCachedRigidBody;
		}
	}

	// Token: 0x17000667 RID: 1639
	// (get) Token: 0x06003D8E RID: 15758 RVA: 0x0002A9DC File Offset: 0x00028BDC
	public Rigidbody2D rigidbody2D
	{
		get
		{
			if (this.mCachedRigidBody2D == null)
			{
				this.mCachedRigidBody2D = base.GetComponent<Rigidbody2D>();
			}
			return this.mCachedRigidBody2D;
		}
	}

	// Token: 0x17000668 RID: 1640
	// (get) Token: 0x06003D8F RID: 15759 RVA: 0x0002A9FE File Offset: 0x00028BFE
	// (set) Token: 0x06003D90 RID: 15760 RVA: 0x0002AA20 File Offset: 0x00028C20
	public virtual Collider collider
	{
		get
		{
			if (this.mCachedCollider == null)
			{
				this.mCachedCollider = base.GetComponent<Collider>();
			}
			return this.mCachedCollider;
		}
		set
		{
			this.mCachedCollider = value;
		}
	}

	// Token: 0x17000669 RID: 1641
	// (get) Token: 0x06003D91 RID: 15761 RVA: 0x0002AA29 File Offset: 0x00028C29
	public Collider2D collider2D
	{
		get
		{
			if (this.mCachedCollider2D == null)
			{
				this.mCachedCollider2D = base.GetComponent<Collider2D>();
			}
			return this.mCachedCollider2D;
		}
	}

	// Token: 0x1700066A RID: 1642
	// (get) Token: 0x06003D92 RID: 15762 RVA: 0x0002AA4B File Offset: 0x00028C4B
	public Renderer renderer
	{
		get
		{
			if (this.mCachedRenderer == null)
			{
				this.mCachedRenderer = base.GetComponent<Renderer>();
			}
			return this.mCachedRenderer;
		}
	}

	// Token: 0x1700066B RID: 1643
	// (get) Token: 0x06003D93 RID: 15763 RVA: 0x0002AA6D File Offset: 0x00028C6D
	public Camera camera
	{
		get
		{
			if (this.mCachedCamera == null)
			{
				this.mCachedCamera = base.GetComponent<Camera>();
			}
			return this.mCachedCamera;
		}
	}

	// Token: 0x1700066C RID: 1644
	// (get) Token: 0x06003D94 RID: 15764 RVA: 0x0002AA8F File Offset: 0x00028C8F
	public Light light
	{
		get
		{
			if (this.mCachedLight == null)
			{
				this.mCachedLight = base.GetComponent<Light>();
			}
			return this.mCachedLight;
		}
	}

	// Token: 0x1700066D RID: 1645
	// (get) Token: 0x06003D95 RID: 15765 RVA: 0x0002AAB1 File Offset: 0x00028CB1
	public AudioSource audio
	{
		get
		{
			if (this.mCachedAudio == null)
			{
				this.mCachedAudio = base.GetComponent<AudioSource>();
			}
			return this.mCachedAudio;
		}
	}

	// Token: 0x1700066E RID: 1646
	// (get) Token: 0x06003D96 RID: 15766 RVA: 0x0002AAD3 File Offset: 0x00028CD3
	public Animation animation
	{
		get
		{
			if (this.mCachedAnimation == null)
			{
				this.mCachedAnimation = base.GetComponent<Animation>();
			}
			return this.mCachedAnimation;
		}
	}

	// Token: 0x1700066F RID: 1647
	// (get) Token: 0x06003D97 RID: 15767 RVA: 0x0002AAF5 File Offset: 0x00028CF5
	public ParticleSystem particleSystem
	{
		get
		{
			if (this.mCachedParticleSystem == null)
			{
				this.mCachedParticleSystem = base.GetComponent<ParticleSystem>();
			}
			return this.mCachedParticleSystem;
		}
	}

	// Token: 0x04003ED9 RID: 16089
	protected Collider mCachedCollider;

	// Token: 0x04003EDA RID: 16090
	private Transform mCachedTransform;

	// Token: 0x04003EDB RID: 16091
	private GameObject mCachedGameObject;

	// Token: 0x04003EDC RID: 16092
	private Rigidbody mCachedRigidBody;

	// Token: 0x04003EDD RID: 16093
	private Rigidbody2D mCachedRigidBody2D;

	// Token: 0x04003EDE RID: 16094
	private Collider2D mCachedCollider2D;

	// Token: 0x04003EDF RID: 16095
	private Renderer mCachedRenderer;

	// Token: 0x04003EE0 RID: 16096
	private Camera mCachedCamera;

	// Token: 0x04003EE1 RID: 16097
	private Light mCachedLight;

	// Token: 0x04003EE2 RID: 16098
	private AudioSource mCachedAudio;

	// Token: 0x04003EE3 RID: 16099
	private Animation mCachedAnimation;

	// Token: 0x04003EE4 RID: 16100
	private ParticleSystem mCachedParticleSystem;
}
