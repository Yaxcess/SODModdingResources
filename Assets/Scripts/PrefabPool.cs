using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x020011F0 RID: 4592
[Serializable]
public class PrefabPool
{
	// Token: 0x17000B4E RID: 2894
	// (get) Token: 0x06007349 RID: 29513 RVA: 0x0004E7AA File Offset: 0x0004C9AA
	public bool logMessages
	{
		get
		{
			if (this.forceLoggingSilent)
			{
				return false;
			}
			if (this.spawnPool.logMessages)
			{
				return this.spawnPool.logMessages;
			}
			return this._logMessages;
		}
	}

	// Token: 0x0600734A RID: 29514 RVA: 0x002D87B0 File Offset: 0x002D69B0
	public PrefabPool(Transform prefab)
	{
		this.prefab = prefab;
		this.prefabGO = prefab.gameObject;
	}

	// Token: 0x0600734B RID: 29515 RVA: 0x002D881C File Offset: 0x002D6A1C
	public PrefabPool()
	{
	}

	// Token: 0x0600734C RID: 29516 RVA: 0x0004E7D5 File Offset: 0x0004C9D5
	internal void inspectorInstanceConstructor()
	{
		this.prefabGO = this.prefab.gameObject;
		this._spawned = new List<Transform>();
		this._despawned = new List<Transform>();
	}

	// Token: 0x0600734D RID: 29517 RVA: 0x002D8874 File Offset: 0x002D6A74
	internal void SelfDestruct()
	{
		this.prefab = null;
		this.prefabGO = null;
		this.spawnPool = null;
		foreach (Transform transform in this._despawned)
		{
			if (transform != null)
			{
				UnityEngine.Object.Destroy(transform.gameObject);
			}
		}
		foreach (Transform transform2 in this._spawned)
		{
			if (transform2 != null)
			{
				UnityEngine.Object.Destroy(transform2.gameObject);
			}
		}
		this._spawned.Clear();
		this._despawned.Clear();
	}

	// Token: 0x17000B4F RID: 2895
	// (get) Token: 0x0600734E RID: 29518 RVA: 0x0004E7FE File Offset: 0x0004C9FE
	public List<Transform> spawned
	{
		get
		{
			return new List<Transform>(this._spawned);
		}
	}

	// Token: 0x17000B50 RID: 2896
	// (get) Token: 0x0600734F RID: 29519 RVA: 0x0004E80B File Offset: 0x0004CA0B
	public List<Transform> despawned
	{
		get
		{
			return new List<Transform>(this._despawned);
		}
	}

	// Token: 0x17000B51 RID: 2897
	// (get) Token: 0x06007350 RID: 29520 RVA: 0x0004E818 File Offset: 0x0004CA18
	public int totalCount
	{
		get
		{
			return 0 + this._spawned.Count + this._despawned.Count;
		}
	}

	// Token: 0x17000B52 RID: 2898
	// (get) Token: 0x06007351 RID: 29521 RVA: 0x0004E833 File Offset: 0x0004CA33
	// (set) Token: 0x06007352 RID: 29522 RVA: 0x0004E83B File Offset: 0x0004CA3B
	internal bool preloaded
	{
		get
		{
			return this._preloaded;
		}
		private set
		{
			this._preloaded = value;
		}
	}

	// Token: 0x06007353 RID: 29523 RVA: 0x0004E844 File Offset: 0x0004CA44
	internal bool DespawnInstance(Transform xform)
	{
		return this.DespawnInstance(xform, true);
	}

	// Token: 0x06007354 RID: 29524 RVA: 0x002D8950 File Offset: 0x002D6B50
	internal bool DespawnInstance(Transform xform, bool sendEventMessage)
	{
		if (this.logMessages)
		{
			Debug.Log(string.Format("SpawnPool {0} ({1}): Despawning '{2}'", this.spawnPool.poolName, this.prefab.name, xform.name));
		}
		this._spawned.Remove(xform);
		this._despawned.Add(xform);
		if (sendEventMessage)
		{
			xform.gameObject.BroadcastMessage("OnDespawned", SendMessageOptions.DontRequireReceiver);
		}
	
		if (!this.cullingActive && this.cullDespawned && this.totalCount > this.cullAbove)
		{
			this.cullingActive = true;
			this.spawnPool.StartCoroutine(this.CullDespawned());
		}
		return true;
	}

	// Token: 0x06007355 RID: 29525 RVA: 0x0004E84E File Offset: 0x0004CA4E
	internal IEnumerator CullDespawned()
	{
		if (this.logMessages)
		{
			Debug.Log(string.Format("SpawnPool {0} ({1}): CULLING TRIGGERED! Waiting {2}sec to begin checking for despawns...", this.spawnPool.poolName, this.prefab.name, this.cullDelay));
		}
		yield return new WaitForSeconds((float)this.cullDelay);
		while (this.totalCount > this.cullAbove)
		{
			int num = 0;
			while (num < this.cullMaxPerPass && this.totalCount > this.cullAbove)
			{
				if (this._despawned.Count > 0)
				{
					Component component = this._despawned[0];
					this._despawned.RemoveAt(0);
					UnityEngine.Object.Destroy(component.gameObject);
					if (this.logMessages)
					{
						Debug.Log(string.Format("SpawnPool {0} ({1}): CULLING to {2} instances. Now at {3}.", new object[]
						{
							this.spawnPool.poolName,
							this.prefab.name,
							this.cullAbove,
							this.totalCount
						}));
					}
				}
				else if (this.logMessages)
				{
					Debug.Log(string.Format("SpawnPool {0} ({1}): CULLING waiting for despawn. Checking again in {2}sec", this.spawnPool.poolName, this.prefab.name, this.cullDelay));
					break;
				}
				num++;
			}
			yield return new WaitForSeconds((float)this.cullDelay);
		}
		if (this.logMessages)
		{
			Debug.Log(string.Format("SpawnPool {0} ({1}): CULLING FINISHED! Stopping", this.spawnPool.poolName, this.prefab.name));
		}
		this.cullingActive = false;
		yield return null;
		yield break;
	}

	// Token: 0x06007356 RID: 29526 RVA: 0x002D8A04 File Offset: 0x002D6C04
	internal Transform SpawnInstance(Vector3 pos, Quaternion rot)
	{
		if (this.limitInstances && this.limitFIFO && this._spawned.Count >= this.limitAmount)
		{
			Transform transform = this._spawned[0];
			if (this.logMessages)
			{
				Debug.Log(string.Format("SpawnPool {0} ({1}): LIMIT REACHED! FIFO=True. Calling despawning for {2}...", this.spawnPool.poolName, this.prefab.name, transform));
			}
			this.DespawnInstance(transform);
			this.spawnPool._spawned.Remove(transform);
		}
		Transform transform2;
		if (this._despawned.Count == 0)
		{
			transform2 = this.SpawnNew(pos, rot);
			if (transform2 != null)
			{
				ObSelfDestructTimer component = transform2.GetComponent<ObSelfDestructTimer>();
				if (component != null)
				{
					component._Pool = this.spawnPool;
				}
			}
			if (Application.isEditor)
			{
				Debug.LogWarning("Creating a pool instance because none are currently available!  Is this the expected behavior?");
			}
		}
		else
		{
			transform2 = this._despawned[0];
			this._despawned.RemoveAt(0);
			this._spawned.Add(transform2);
			if (transform2 == null)
			{
				throw new MissingReferenceException("Make sure you didn't delete a despawned instance directly.");
			}
			if (this.logMessages)
			{
				Debug.Log(string.Format("SpawnPool {0} ({1}): respawning '{2}'.", this.spawnPool.poolName, this.prefab.name, transform2.name));
			}
			transform2.position = pos;
			transform2.rotation = rot;
			
		}
		if (transform2 != null)
		{
			transform2.gameObject.BroadcastMessage("OnSpawned", SendMessageOptions.DontRequireReceiver);
		}
		return transform2;
	}

	// Token: 0x06007357 RID: 29527 RVA: 0x0004E85D File Offset: 0x0004CA5D
	public Transform SpawnNew()
	{
		return this.SpawnNew(Vector3.zero, Quaternion.identity);
	}

	// Token: 0x06007358 RID: 29528 RVA: 0x002D8B80 File Offset: 0x002D6D80
	public Transform SpawnNew(Vector3 pos, Quaternion rot)
	{
		if (this.spawnPool == null || this.prefab == null)
		{
			return null;
		}
		if (this.limitInstances && this.totalCount >= this.limitAmount)
		{
			if (this.logMessages)
			{
				Debug.Log(string.Format("SpawnPool {0} ({1}): LIMIT REACHED! Not creating new instances! (Returning null)", this.spawnPool.poolName, this.prefab.name));
			}
			return null;
		}
		if (pos == Vector3.zero)
		{
			pos = this.spawnPool.group.position;
		}
		if (rot == Quaternion.identity)
		{
			rot = this.spawnPool.group.rotation;
		}
		Transform transform = UnityEngine.Object.Instantiate<Transform>(this.prefab, pos, rot);
		this.nameInstance(transform);
		transform.parent = this.spawnPool.group;
		if (this.spawnPool.matchPoolScale)
		{
			transform.localScale = Vector3.one;
		}
		if (this.spawnPool.matchPoolLayer)
		{
			this.SetRecursively(transform, this.spawnPool.gameObject.layer);
		}
		this._spawned.Add(transform);
		if (this.logMessages)
		{
			Debug.Log(string.Format("SpawnPool {0} ({1}): Spawned new instance '{2}'.", this.spawnPool.poolName, this.prefab.name, transform.name));
		}
		return transform;
	}

	// Token: 0x06007359 RID: 29529 RVA: 0x002D8CD0 File Offset: 0x002D6ED0
	private void SetRecursively(Transform xform, int layer)
	{
		xform.gameObject.layer = layer;
		foreach (object obj in xform)
		{
			Transform xform2 = (Transform)obj;
			this.SetRecursively(xform2, layer);
		}
	}

	// Token: 0x0600735A RID: 29530 RVA: 0x0004E86F File Offset: 0x0004CA6F
	internal void AddUnpooled(Transform inst, bool despawn)
	{
		this.nameInstance(inst);
		if (despawn)
		{
			
			this._despawned.Add(inst);
			return;
		}
		this._spawned.Add(inst);
	}

	// Token: 0x0600735B RID: 29531 RVA: 0x002D8D34 File Offset: 0x002D6F34
	internal void PreloadInstances()
	{
		if (this.preloaded)
		{
			Debug.Log(string.Format("SpawnPool {0} ({1}): Already preloaded! You cannot preload twice. If you are running this through code, make sure it isn't also defined in the Inspector.", this.spawnPool.poolName, this.prefab.name));
			return;
		}
		if (this.prefab == null)
		{
			Debug.LogError(string.Format("SpawnPool {0} ({1}): Prefab cannot be null.", this.spawnPool.poolName, this.prefab.name));
			return;
		}
		if (this.limitInstances && this.preloadAmount > this.limitAmount)
		{
			Debug.LogWarning(string.Format("SpawnPool {0} ({1}): You turned ON 'Limit Instances' and entered a 'Limit Amount' greater than the 'Preload Amount'! Setting preload amount to limit amount.", this.spawnPool.poolName, this.prefab.name));
			this.preloadAmount = this.limitAmount;
		}
		if (this.cullDespawned && this.preloadAmount > this.cullAbove)
		{
			Debug.LogWarning(string.Format("SpawnPool {0} ({1}): You turned ON Culling and entered a 'Cull Above' threshold greater than the 'Preload Amount'! This will cause the culling feature to trigger immediatly, which is wrong conceptually. Only use culling for extreme situations. See the docs.", this.spawnPool.poolName, this.prefab.name));
		}
		if (this.preloadTime)
		{
			if (this.preloadFrames > this.preloadAmount)
			{
				Debug.LogWarning(string.Format("SpawnPool {0} ({1}): Preloading over-time is on but the frame duration is greater than the number of instances to preload. The minimum spawned per frame is 1, so the maximum time is the same as the number of instances. Changing the preloadFrames value...", this.spawnPool.poolName, this.prefab.name));
				this.preloadFrames = this.preloadAmount;
			}
			this.spawnPool.StartCoroutine(this.PreloadOverTime());
			return;
		}
		this.forceLoggingSilent = true;
		while (this.totalCount < this.preloadAmount)
		{
			Transform transform = this.SpawnNew();
			if (transform != null)
			{
				ObSelfDestructTimer component = transform.GetComponent<ObSelfDestructTimer>();
				if (component != null)
				{
					component._Pool = this.spawnPool;
				}
				this.DespawnInstance(transform, false);
			}
		}
		this.forceLoggingSilent = false;
	}

	// Token: 0x0600735C RID: 29532 RVA: 0x0004E8A0 File Offset: 0x0004CAA0
	private IEnumerator PreloadOverTime()
	{
		yield return new WaitForSeconds(this.preloadDelay);
		int num = this.preloadAmount - this.totalCount;
		if (num <= 0)
		{
			yield break;
		}
		int remainder;
		int numPerFrame = Math.DivRem(num, this.preloadFrames, out remainder);
		this.forceLoggingSilent = true;
		int num2;
		for (int i = 0; i < this.preloadFrames; i = num2 + 1)
		{
			int numThisFrame = numPerFrame;
			if (i == this.preloadFrames - 1)
			{
				numThisFrame += remainder;
			}
			for (int j = 0; j < numThisFrame; j = num2 + 1)
			{
				Transform transform = this.SpawnNew();
				if (transform != null)
				{
					ObSelfDestructTimer component = transform.GetComponent<ObSelfDestructTimer>();
					if (component != null)
					{
						component._Pool = this.spawnPool;
					}
					this.DespawnInstance(transform, false);
				}
				yield return null;
				num2 = j;
			}
			if (this.totalCount > this.preloadAmount)
			{
				break;
			}
			num2 = i;
		}
		this.forceLoggingSilent = false;
		yield break;
	}

	// Token: 0x0600735D RID: 29533 RVA: 0x002D8ED4 File Offset: 0x002D70D4
	private void nameInstance(Transform instance)
	{
		instance.name += (this.totalCount + 1).ToString("#000");
	}

	// Token: 0x04006FDB RID: 28635
	public Transform prefab;

	// Token: 0x04006FDC RID: 28636
	internal GameObject prefabGO;

	// Token: 0x04006FDD RID: 28637
	public int preloadAmount = 1;

	// Token: 0x04006FDE RID: 28638
	public bool preloadTime;

	// Token: 0x04006FDF RID: 28639
	public int preloadFrames = 2;

	// Token: 0x04006FE0 RID: 28640
	public float preloadDelay;

	// Token: 0x04006FE1 RID: 28641
	public bool limitInstances;

	// Token: 0x04006FE2 RID: 28642
	public int limitAmount = 100;

	// Token: 0x04006FE3 RID: 28643
	public bool limitFIFO;

	// Token: 0x04006FE4 RID: 28644
	public bool cullDespawned;

	// Token: 0x04006FE5 RID: 28645
	public int cullAbove = 50;

	// Token: 0x04006FE6 RID: 28646
	public int cullDelay = 60;

	// Token: 0x04006FE7 RID: 28647
	public int cullMaxPerPass = 5;

	// Token: 0x04006FE8 RID: 28648
	public bool _logMessages;

	// Token: 0x04006FE9 RID: 28649
	private bool forceLoggingSilent;

	// Token: 0x04006FEA RID: 28650
	public SpawnPool spawnPool;

	// Token: 0x04006FEB RID: 28651
	private bool cullingActive;

	// Token: 0x04006FEC RID: 28652
	public List<Transform> _spawned = new List<Transform>();

	// Token: 0x04006FED RID: 28653
	public List<Transform> _despawned = new List<Transform>();

	// Token: 0x04006FEE RID: 28654
	private bool _preloaded;
}
