using System;
using UnityEngine;

// Token: 0x02001132 RID: 4402
public class DragonSkin : MonoBehaviour
{
	// Token: 0x06006DB8 RID: 28088 RVA: 0x002BDCA8 File Offset: 0x002BBEA8
	public bool IsRendererAllowedToChange(string inName)
	{
		foreach (string value in this._RenderersToChange)
		{
			if (inName.Contains(value))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x04006ABA RID: 27322
	public Material[] _Materials;

	// Token: 0x04006ABB RID: 27323
	public DragonSkin.ParticleData[] _Particles;

	// Token: 0x04006ABC RID: 27324
	public Material[] _LODMaterials;

	// Token: 0x04006ABD RID: 27325
	public DragonSkin.ParticleData[] _LODParticles;

	// Token: 0x04006ABE RID: 27326
	public Material[] _BabyMaterials;

	// Token: 0x04006ABF RID: 27327
	public DragonSkin.ParticleData[] _BabyParticles;

	// Token: 0x04006AC0 RID: 27328
	public Material[] _TeenMaterials;

	// Token: 0x04006AC1 RID: 27329
	public DragonSkin.ParticleData[] _TeenParticles;

	// Token: 0x04006AC2 RID: 27330
	public Material[] _TeenLODMaterials;

	// Token: 0x04006AC3 RID: 27331
	public DragonSkin.ParticleData[] _TeenLODParticles;

	// Token: 0x04006AC4 RID: 27332
	public Material[] _TitanMaterials;

	// Token: 0x04006AC5 RID: 27333
	public DragonSkin.ParticleData[] _TitanParticles;

	// Token: 0x04006AC6 RID: 27334
	public Material[] _TitanLODMaterials;

	// Token: 0x04006AC7 RID: 27335
	public DragonSkin.ParticleData[] _TitanLODParticles;

	// Token: 0x04006AC8 RID: 27336
	public Mesh _Mesh;

	// Token: 0x04006AC9 RID: 27337
	public Mesh _BabyMesh;

	// Token: 0x04006ACA RID: 27338
	public Mesh _TeenMesh;

	// Token: 0x04006ACB RID: 27339
	public Mesh _TitanMesh;

	// Token: 0x04006ACC RID: 27340
	public string[] _RenderersToChange;

	// Token: 0x04006ACD RID: 27341
	public DragonSkin.WeaponData _Weapon = new DragonSkin.WeaponData("");

	// Token: 0x02001133 RID: 4403
	[Serializable]
	public class WeaponData
	{
		// Token: 0x06006DBA RID: 28090 RVA: 0x0004B5A1 File Offset: 0x000497A1
		public WeaponData(string inName)
		{
			this.name = inName;
		}

		// Token: 0x04006ACE RID: 27342
		public string name;
	}

	// Token: 0x02001134 RID: 4404
	[Serializable]
	public class ParticleData
	{
		// Token: 0x04006ACF RID: 27343
		public GameObject _ParticleObject;

		// Token: 0x04006AD0 RID: 27344
		public string _BoneName;

		// Token: 0x04006AD1 RID: 27345
		public Vector3 _PositionOffset = Vector3.zero;

		// Token: 0x04006AD2 RID: 27346
		public Vector3 _RotationOffset = Vector3.zero;
	}
}
