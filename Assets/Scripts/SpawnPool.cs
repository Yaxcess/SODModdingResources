using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x020011EB RID: 4587
[AddComponentMenu("Path-o-logical/PoolManager/SpawnPool")]
public sealed class SpawnPool : KAMonoBase, IList<Transform>, ICollection<Transform>, IEnumerable<Transform>, IEnumerable
{
	// Token: 0x17000B41 RID: 2881
	// (get) Token: 0x06007309 RID: 29449 RVA: 0x0004E610 File Offset: 0x0004C810
	// (set) Token: 0x0600730A RID: 29450 RVA: 0x0004E618 File Offset: 0x0004C818
	public Transform group { get; private set; }

	// Token: 0x17000B42 RID: 2882
	// (get) Token: 0x0600730B RID: 29451 RVA: 0x002D7AF8 File Offset: 0x002D5CF8
	public Dictionary<string, PrefabPool> prefabPools
	{
		get
		{
			Dictionary<string, PrefabPool> dictionary = new Dictionary<string, PrefabPool>();
			foreach (PrefabPool prefabPool in this._prefabPools)
			{
				dictionary[prefabPool.prefabGO.name] = prefabPool;
			}
			return dictionary;
		}
	}

	// Token: 0x0600730C RID: 29452 RVA: 0x002D7B60 File Offset: 0x002D5D60
	private void Awake()
	{
		if (this.dontDestroyOnLoad)
		{
			UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
		}
		this.group = base.transform;
		if (this.poolName == "")
		{
			this.poolName = this.group.name.Replace("Pool", "");
			this.poolName = this.poolName.Replace("(Clone)", "");
		}
		if (this.logMessages)
		{
			
		}
		foreach (PrefabPool prefabPool in this._perPrefabPoolOptions)
		{
			if (prefabPool.prefab == null)
			{
				
			}
			else
			{
				prefabPool.inspectorInstanceConstructor();
				this.CreatePrefabPool(prefabPool);
			}
		}
		
	}

	// Token: 0x0600730D RID: 29453 RVA: 0x002D7C7C File Offset: 0x002D5E7C
	private void OnDestroy()
	{
		if (this.logMessages)
		{
			
		}
		SpawnPool spawnPool;
		
		base.StopAllCoroutines();
		this._spawned.Clear();
		foreach (PrefabPool prefabPool in this._prefabPools)
		{
			prefabPool.SelfDestruct();
		}
		this._prefabPools.Clear();
		this.prefabs._Clear();
	}

	// Token: 0x0600730E RID: 29454 RVA: 0x002D7D38 File Offset: 0x002D5F38
	public void CreatePrefabPool(PrefabPool prefabPool)
	{
		if (this.prefabs.ContainsKey(prefabPool.prefab.name))
		{
			
		}
		bool flag = !(this.GetPrefab(prefabPool.prefab) == null);
		if (!this.prefabs.ContainsKey(prefabPool.prefab.name) && !flag)
		{
			prefabPool.spawnPool = this;
			this._prefabPools.Add(prefabPool);
			this.prefabs._Add(prefabPool.prefab.name, prefabPool.prefab);
		}
		if (!prefabPool.preloaded)
		{
			if (this.logMessages)
			{
				Debug.Log(string.Format("SpawnPool {0}: Preloading {1} {2}", this.poolName, prefabPool.preloadAmount, prefabPool.prefab.name));
			}
			prefabPool.PreloadInstances();
		}
	}

	// Token: 0x0600730F RID: 29455 RVA: 0x002D7E1C File Offset: 0x002D601C
	public void Add(Transform instance, string prefabName, bool despawn, bool parent)
	{
		foreach (PrefabPool prefabPool in this._prefabPools)
		{
			if (prefabPool.prefabGO == null)
			{
				Debug.LogError("Unexpected Error: PrefabPool.prefabGO is null");
				return;
			}
			if (prefabPool.prefabGO.name == prefabName)
			{
				prefabPool.AddUnpooled(instance, despawn);
				if (this.logMessages)
				{
					Debug.Log(string.Format("SpawnPool {0}: Adding previously unpooled instance {1}", this.poolName, instance.name));
				}
				if (parent)
				{
					instance.parent = this.group;
				}
				if (!despawn)
				{
					this._spawned.Add(instance);
				}
				return;
			}
		}
		Debug.LogError(string.Format("SpawnPool {0}: PrefabPool {1} not found.", this.poolName, prefabName));
	}

	
	public void Add(Transform item)
	{
		throw new NotImplementedException("Use SpawnPool.Spawn() to properly add items to the pool.");
	}

	// Token: 0x06007311 RID: 29457 RVA: 0x0004E62D File Offset: 0x0004C82D
	public void Remove(Transform item)
	{
		throw new NotImplementedException("Use Despawn() to properly manage items that should remain in the pool but be deactivated.");
	}

	// Token: 0x06007312 RID: 29458 RVA: 0x002D7F00 File Offset: 0x002D6100
	public PrefabPool GetPrefabPool(Transform prefab)
	{
		if (prefab == null)
		{
			return null;
		}
		foreach (PrefabPool prefabPool in this._prefabPools)
		{
			if (prefabPool == null || prefabPool.prefabGO == null)
			{
				Debug.LogWarning("@@@@@@@ not good object in prefab pool");
			}
			else if (prefabPool.prefabGO.name == prefab.gameObject.name)
			{
				return prefabPool;
			}
		}
		return null;
	}

	// Token: 0x06007313 RID: 29459 RVA: 0x0004E639 File Offset: 0x0004C839
	public GameObject Spawn(GameObject go, Vector3 pos, Quaternion rot)
	{
		return this.Spawn(go.transform, pos, rot).gameObject;
	}

	// Token: 0x06007314 RID: 29460 RVA: 0x002D7F98 File Offset: 0x002D6198
	public Transform Spawn(Transform prefab, Vector3 pos, Quaternion rot)
	{
		ObSelfDestructTimer component = prefab.GetComponent<ObSelfDestructTimer>();
		if (component != null)
		{
			component._Pool = this;
		}
		if (prefab == null)
		{
			return null;
		}
		Transform transform;
		foreach (PrefabPool prefabPool in this._prefabPools)
		{
			if (prefabPool.prefabGO == null)
			{
				Debug.LogError(" SpawnPool::Spawn PrefabPool.prefabGO is null");
			}
			else if (prefabPool.prefabGO.name == prefab.name)
			{
				transform = prefabPool.SpawnInstance(pos, rot);
				if (transform == null)
				{
					return null;
				}
				if (transform.parent != this.group)
				{
					transform.parent = this.group;
				}
				this._spawned.Add(transform);
				return transform;
			}
		}
		PrefabPool prefabPool2 = new PrefabPool(prefab);
		this.CreatePrefabPool(prefabPool2);
		transform = prefabPool2.SpawnInstance(pos, rot);
		transform.parent = this.group;
		this._spawned.Add(transform);
		return transform;
	}

	// Token: 0x06007315 RID: 29461 RVA: 0x0004E64E File Offset: 0x0004C84E
	public Transform Spawn(Transform prefab)
	{
		return this.Spawn(prefab, Vector3.zero, Quaternion.identity);
	}

	// Token: 0x06007316 RID: 29462 RVA: 0x002D80BC File Offset: 0x002D62BC
	public ParticleSystem Spawn(ParticleSystem prefab, Vector3 pos, Quaternion quat)
	{
		Transform transform = this.Spawn(prefab.transform, pos, quat);
		if (transform == null)
		{
			return null;
		}
		ParticleSystem component = transform.GetComponent<ParticleSystem>();
		base.StartCoroutine(this.ListenForEmitDespawn(component));
		return component;
	}

	// Token: 0x06007317 RID: 29463 RVA: 0x002D80FC File Offset: 0x002D62FC
	public void Despawn(Transform xform)
	{
		bool flag = false;
		foreach (PrefabPool prefabPool in this._prefabPools)
		{
			if (prefabPool._spawned.Contains(xform))
			{
				flag = prefabPool.DespawnInstance(xform);
				break;
			}
			if (prefabPool._despawned.Contains(xform))
			{
				Debug.LogError(string.Format("SpawnPool {0}: {1} has already been despawned. You cannot despawn something more than once!", this.poolName, xform.name));
				return;
			}
		}
		if (!flag)
		{
			
			return;
		}
		this._spawned.Remove(xform);
	}

	// Token: 0x06007318 RID: 29464 RVA: 0x0004E661 File Offset: 0x0004C861
	public void Despawn(Transform instance, float seconds)
	{
		base.StartCoroutine(this.DoDespawnAfterSeconds(instance, seconds));
	}

	// Token: 0x06007319 RID: 29465 RVA: 0x002D81BC File Offset: 0x002D63BC
	public void RemoveFromPool(Transform Obj)
	{
		int i = 0;
		int count = this._prefabPools.Count;
		while (i < count)
		{
			this._prefabPools[i]._despawned.Remove(Obj);
			i++;
		}
	}

	// Token: 0x0600731A RID: 29466 RVA: 0x0004E672 File Offset: 0x0004C872
	private IEnumerator DoDespawnAfterSeconds(Transform instance, float seconds)
	{
		yield return new WaitForSeconds(seconds);
		this.Despawn(instance);
		yield break;
	}

	// Token: 0x0600731B RID: 29467 RVA: 0x002D81FC File Offset: 0x002D63FC
	public void DespawnAll()
	{
		foreach (Transform xform in new List<Transform>(this._spawned))
		{
			this.Despawn(xform);
		}
	}

	// Token: 0x0600731C RID: 29468 RVA: 0x0004E68F File Offset: 0x0004C88F
	public bool IsSpawned(Transform instance)
	{
		return this._spawned.Contains(instance);
	}

	// Token: 0x0600731D RID: 29469 RVA: 0x002D8254 File Offset: 0x002D6454
	public Transform GetPrefab(Transform prefab)
	{
		if (prefab == null)
		{
			Debug.LogError(" SpawnPool::GetPrefab incoming prefab is null ");
			return null;
		}
		foreach (PrefabPool prefabPool in this._prefabPools)
		{
			if (prefabPool.prefabGO == null)
			{
				Debug.LogError(string.Format("SpawnPool {0}: PrefabPool.prefabGO is null", this.poolName));
			}
			else if (prefabPool.prefabGO.name == prefab.name)
			{
				return prefabPool.prefab;
			}
		}
		return null;
	}

	// Token: 0x0600731E RID: 29470 RVA: 0x002D8300 File Offset: 0x002D6500
	public GameObject GetPrefab(GameObject prefab)
	{
		foreach (PrefabPool prefabPool in this._prefabPools)
		{
			if (prefabPool.prefabGO == null)
			{
				Debug.LogError(string.Format("SpawnPool {0}: PrefabPool.prefabGO is null", this.poolName));
			}
			if (prefabPool.prefabGO.name == prefab.name)
			{
				return prefabPool.prefabGO;
			}
		}
		return null;
	}

	// Token: 0x0600731F RID: 29471 RVA: 0x0004E69D File Offset: 0x0004C89D
	private IEnumerator ListenForEmitDespawn(ParticleSystem emitter)
	{
		
		this.Despawn(emitter.transform);
		yield break;
	}

	// Token: 0x06007320 RID: 29472 RVA: 0x002D8394 File Offset: 0x002D6594
	public override string ToString()
	{
		List<string> list = new List<string>();
		foreach (Transform transform in this._spawned)
		{
			list.Add(transform.name);
		}
		return string.Join(", ", list.ToArray());
	}

	// Token: 0x17000B43 RID: 2883
	public Transform this[int index]
	{
		get
		{
			return this._spawned[index];
		}
		set
		{
			throw new NotImplementedException("Read-only.");
		}
	}

	// Token: 0x06007323 RID: 29475 RVA: 0x0004E6CD File Offset: 0x0004C8CD
	public bool Contains(Transform item)
	{
		throw new NotImplementedException("Use IsSpawned(Transform instance) instead.");
	}

	// Token: 0x06007324 RID: 29476 RVA: 0x0004E6D9 File Offset: 0x0004C8D9
	public void CopyTo(Transform[] array, int arrayIndex)
	{
		this._spawned.CopyTo(array, arrayIndex);
	}

	// Token: 0x17000B44 RID: 2884
	// (get) Token: 0x06007325 RID: 29477 RVA: 0x0004E6E8 File Offset: 0x0004C8E8
	public int Count
	{
		get
		{
			return this._spawned.Count;
		}
	}

	// Token: 0x06007326 RID: 29478 RVA: 0x0004E6F5 File Offset: 0x0004C8F5
	public IEnumerator<Transform> GetEnumerator()
	{
		foreach (Transform transform in this._spawned)
		{
			yield return transform;
		}
		List<Transform>.Enumerator enumerator = default(List<Transform>.Enumerator);
		yield break;
		yield break;
	}

	// Token: 0x06007327 RID: 29479 RVA: 0x0004E704 File Offset: 0x0004C904
	IEnumerator IEnumerable.GetEnumerator()
	{
		foreach (Transform transform in this._spawned)
		{
			yield return transform;
		}
		List<Transform>.Enumerator enumerator = default(List<Transform>.Enumerator);
		yield break;
		yield break;
	}

	// Token: 0x06007328 RID: 29480 RVA: 0x0004E713 File Offset: 0x0004C913
	public int IndexOf(Transform item)
	{
		throw new NotImplementedException();
	}

	// Token: 0x06007329 RID: 29481 RVA: 0x0004E713 File Offset: 0x0004C913
	public void Insert(int index, Transform item)
	{
		throw new NotImplementedException();
	}

	// Token: 0x0600732A RID: 29482 RVA: 0x0004E713 File Offset: 0x0004C913
	public void RemoveAt(int index)
	{
		throw new NotImplementedException();
	}

	// Token: 0x0600732B RID: 29483 RVA: 0x0004E713 File Offset: 0x0004C913
	public void Clear()
	{
		throw new NotImplementedException();
	}

	// Token: 0x17000B45 RID: 2885
	// (get) Token: 0x0600732C RID: 29484 RVA: 0x0004E713 File Offset: 0x0004C913
	public bool IsReadOnly
	{
		get
		{
			throw new NotImplementedException();
		}
	}

	// Token: 0x0600732D RID: 29485 RVA: 0x0004E713 File Offset: 0x0004C913
	bool ICollection<Transform>.Remove(Transform item)
	{
		throw new NotImplementedException();
	}

	// Token: 0x04006FBC RID: 28604
	public string poolName = "";

	// Token: 0x04006FBD RID: 28605
	public bool matchPoolScale;

	// Token: 0x04006FBE RID: 28606
	public bool matchPoolLayer;

	// Token: 0x04006FBF RID: 28607
	public bool dontDestroyOnLoad;

	// Token: 0x04006FC0 RID: 28608
	public bool logMessages;

	// Token: 0x04006FC1 RID: 28609
	public List<PrefabPool> _perPrefabPoolOptions = new List<PrefabPool>();

	// Token: 0x04006FC2 RID: 28610
	public Dictionary<object, bool> prefabsFoldOutStates = new Dictionary<object, bool>();

	// Token: 0x04006FC3 RID: 28611
	[HideInInspector]
	public float maxParticleDespawnTime = 60f;

	// Token: 0x04006FC5 RID: 28613
	public PrefabsDict prefabs = new PrefabsDict();

	// Token: 0x04006FC6 RID: 28614
	public Dictionary<object, bool> _editorListItemStates = new Dictionary<object, bool>();

	// Token: 0x04006FC7 RID: 28615
	public List<PrefabPool> _prefabPools = new List<PrefabPool>();

	// Token: 0x04006FC8 RID: 28616
	internal List<Transform> _spawned = new List<Transform>();
}
