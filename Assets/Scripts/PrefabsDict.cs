using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x020011F3 RID: 4595
public class PrefabsDict : IDictionary<string, Transform>, ICollection<KeyValuePair<string, Transform>>, IEnumerable<KeyValuePair<string, Transform>>, IEnumerable
{
	// Token: 0x0600736A RID: 29546 RVA: 0x002D9284 File Offset: 0x002D7484
	public override string ToString()
	{
		string[] array = new string[this._prefabs.Count];
		this._prefabs.Keys.CopyTo(array, 0);
		return string.Format("[{0}]", string.Join(", ", array));
	}

	// Token: 0x0600736B RID: 29547 RVA: 0x0004E8DD File Offset: 0x0004CADD
	internal void _Add(string prefabName, Transform prefab)
	{
		this._prefabs.Add(prefabName, prefab);
	}

	// Token: 0x0600736C RID: 29548 RVA: 0x0004E8EC File Offset: 0x0004CAEC
	internal bool _Remove(string prefabName)
	{
		return this._prefabs.Remove(prefabName);
	}

	// Token: 0x0600736D RID: 29549 RVA: 0x0004E8FA File Offset: 0x0004CAFA
	internal void _Clear()
	{
		this._prefabs.Clear();
	}

	// Token: 0x17000B57 RID: 2903
	// (get) Token: 0x0600736E RID: 29550 RVA: 0x0004E907 File Offset: 0x0004CB07
	public int Count
	{
		get
		{
			return this._prefabs.Count;
		}
	}

	// Token: 0x0600736F RID: 29551 RVA: 0x0004E914 File Offset: 0x0004CB14
	public bool ContainsKey(string prefabName)
	{
		return this._prefabs.ContainsKey(prefabName);
	}

	// Token: 0x06007370 RID: 29552 RVA: 0x0004E922 File Offset: 0x0004CB22
	public bool TryGetValue(string prefabName, out Transform prefab)
	{
		return this._prefabs.TryGetValue(prefabName, out prefab);
	}

	// Token: 0x06007371 RID: 29553 RVA: 0x0004E931 File Offset: 0x0004CB31
	public void Add(string key, Transform value)
	{
		throw new NotImplementedException("Read-Only");
	}

	// Token: 0x06007372 RID: 29554 RVA: 0x0004E931 File Offset: 0x0004CB31
	public bool Remove(string prefabName)
	{
		throw new NotImplementedException("Read-Only");
	}

	// Token: 0x06007373 RID: 29555 RVA: 0x0004E93D File Offset: 0x0004CB3D
	public bool Contains(KeyValuePair<string, Transform> item)
	{
		throw new NotImplementedException("Use Contains(string prefabName) instead.");
	}

	// Token: 0x17000B58 RID: 2904
	public Transform this[string key]
	{
		get
		{
			Transform result;
			try
			{
				result = this._prefabs[key];
			}
			catch (KeyNotFoundException)
			{
				throw new KeyNotFoundException(string.Format("A Prefab with the name '{0}' not found. \nPrefabs={1}", key, this.ToString()));
			}
			return result;
		}
		set
		{
			throw new NotImplementedException("Read-only.");
		}
	}

	// Token: 0x17000B59 RID: 2905
	// (get) Token: 0x06007376 RID: 29558 RVA: 0x0004E949 File Offset: 0x0004CB49
	public ICollection<string> Keys
	{
		get
		{
			return this._prefabs.Keys;
		}
	}

	// Token: 0x17000B5A RID: 2906
	// (get) Token: 0x06007377 RID: 29559 RVA: 0x0004E956 File Offset: 0x0004CB56
	public ICollection<Transform> Values
	{
		get
		{
			return this._prefabs.Values;
		}
	}

	// Token: 0x17000B5B RID: 2907
	// (get) Token: 0x06007378 RID: 29560 RVA: 0x0000617D File Offset: 0x0000437D
	private bool IsReadOnly
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17000B5C RID: 2908
	// (get) Token: 0x06007379 RID: 29561 RVA: 0x0000617D File Offset: 0x0000437D
	bool ICollection<KeyValuePair<string, Transform>>.IsReadOnly
	{
		get
		{
			return true;
		}
	}

	// Token: 0x0600737A RID: 29562 RVA: 0x0004E963 File Offset: 0x0004CB63
	public void Add(KeyValuePair<string, Transform> item)
	{
		throw new NotImplementedException("Read-only");
	}

	// Token: 0x0600737B RID: 29563 RVA: 0x0004E713 File Offset: 0x0004C913
	public void Clear()
	{
		throw new NotImplementedException();
	}

	// Token: 0x0600737C RID: 29564 RVA: 0x0004E96F File Offset: 0x0004CB6F
	private void CopyTo(KeyValuePair<string, Transform>[] array, int arrayIndex)
	{
		throw new NotImplementedException("Cannot be copied");
	}

	// Token: 0x0600737D RID: 29565 RVA: 0x0004E96F File Offset: 0x0004CB6F
	void ICollection<KeyValuePair<string, Transform>>.CopyTo(KeyValuePair<string, Transform>[] array, int arrayIndex)
	{
		throw new NotImplementedException("Cannot be copied");
	}

	// Token: 0x0600737E RID: 29566 RVA: 0x0004E963 File Offset: 0x0004CB63
	public bool Remove(KeyValuePair<string, Transform> item)
	{
		throw new NotImplementedException("Read-only");
	}

	// Token: 0x0600737F RID: 29567 RVA: 0x0004E97B File Offset: 0x0004CB7B
	public IEnumerator<KeyValuePair<string, Transform>> GetEnumerator()
	{
		return this._prefabs.GetEnumerator();
	}

	// Token: 0x06007380 RID: 29568 RVA: 0x0004E97B File Offset: 0x0004CB7B
	IEnumerator IEnumerable.GetEnumerator()
	{
		return this._prefabs.GetEnumerator();
	}

	// Token: 0x04006FFA RID: 28666
	public Dictionary<string, Transform> _prefabs = new Dictionary<string, Transform>();
}
