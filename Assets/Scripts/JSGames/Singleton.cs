using System;
using UnityEngine;

namespace JSGames
{
	// Token: 0x02001AC5 RID: 6853
	public abstract class Singleton<T> : KAMonoBase where T : KAMonoBase
	{
		// Token: 0x1700106F RID: 4207
		// (get) Token: 0x0600A157 RID: 41303 RVA: 0x0006470F File Offset: 0x0006290F
		public static T pInstance
		{
			get
			{
				if (Singleton<T>.mInstance == null)
				{
					Singleton<T>.mInstance = UnityEngine.Object.FindObjectOfType<T>();
				}
				return Singleton<T>.mInstance;
			}
		}

		// Token: 0x0600A158 RID: 41304 RVA: 0x00064732 File Offset: 0x00062932
		protected virtual void Awake()
		{
			if (this._PersistentOnSceneChange)
			{
				UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
			}
		}

		// Token: 0x0600A159 RID: 41305 RVA: 0x00064747 File Offset: 0x00062947
		protected virtual void Start()
		{
			if (UnityEngine.Object.FindObjectsOfType<T>().Length > 1)
			{
				Debug.Log(base.gameObject.name + " has been destroyed because another object already has the same component.");
				UnityEngine.Object.Destroy(base.gameObject);
			}
		}

		// Token: 0x0600A15A RID: 41306 RVA: 0x00064778 File Offset: 0x00062978
		protected virtual void OnDestroy()
		{
			if (this == Singleton<T>.mInstance)
			{
				Singleton<T>.mInstance = default(T);
			}
		}

		// Token: 0x0400A5F1 RID: 42481
		private static T mInstance;

		// Token: 0x0400A5F2 RID: 42482
		public bool _PersistentOnSceneChange;
	}
}
