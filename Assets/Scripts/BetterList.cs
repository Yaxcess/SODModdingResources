using System;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

// Token: 0x02000F29 RID: 3881
public class BetterList<T>
{
	// Token: 0x06006029 RID: 24617 RVA: 0x00041B75 File Offset: 0x0003FD75
	public IEnumerator<T> GetEnumerator()
	{
		if (this.buffer != null)
		{
			int num;
			for (int i = 0; i < this.size; i = num)
			{
				yield return this.buffer[i];
				num = i + 1;
			}
		}
		yield break;
	}

	// Token: 0x170008C1 RID: 2241
	[DebuggerHidden]
	public T this[int i]
	{
		get
		{
			return this.buffer[i];
		}
		set
		{
			this.buffer[i] = value;
		}
	}

	// Token: 0x0600602C RID: 24620 RVA: 0x0027D260 File Offset: 0x0027B460
	private void AllocateMore()
	{
		T[] array = (this.buffer != null) ? new T[Mathf.Max(this.buffer.Length << 1, 32)] : new T[32];
		if (this.buffer != null && this.size > 0)
		{
			this.buffer.CopyTo(array, 0);
		}
		this.buffer = array;
	}

	// Token: 0x0600602D RID: 24621 RVA: 0x0027D2BC File Offset: 0x0027B4BC
	private void Trim()
	{
		if (this.size > 0)
		{
			if (this.size < this.buffer.Length)
			{
				T[] array = new T[this.size];
				for (int i = 0; i < this.size; i++)
				{
					array[i] = this.buffer[i];
				}
				this.buffer = array;
				return;
			}
		}
		else
		{
			this.buffer = null;
		}
	}

	// Token: 0x0600602E RID: 24622 RVA: 0x00041BA1 File Offset: 0x0003FDA1
	public void Clear()
	{
		this.size = 0;
	}

	// Token: 0x0600602F RID: 24623 RVA: 0x00041BAA File Offset: 0x0003FDAA
	public void Release()
	{
		this.size = 0;
		this.buffer = null;
	}

	// Token: 0x06006030 RID: 24624 RVA: 0x0027D324 File Offset: 0x0027B524
	public void Add(T item)
	{
		if (this.buffer == null || this.size == this.buffer.Length)
		{
			this.AllocateMore();
		}
		T[] array = this.buffer;
		int num = this.size;
		this.size = num + 1;
		array[num] = item;
	}

	// Token: 0x06006031 RID: 24625 RVA: 0x0027D36C File Offset: 0x0027B56C
	public void Insert(int index, T item)
	{
		if (this.buffer == null || this.size == this.buffer.Length)
		{
			this.AllocateMore();
		}
		if (index > -1 && index < this.size)
		{
			for (int i = this.size; i > index; i--)
			{
				this.buffer[i] = this.buffer[i - 1];
			}
			this.buffer[index] = item;
			this.size++;
			return;
		}
		this.Add(item);
	}

	// Token: 0x06006032 RID: 24626 RVA: 0x0027D3F4 File Offset: 0x0027B5F4
	public bool Contains(T item)
	{
		if (this.buffer == null)
		{
			return false;
		}
		for (int i = 0; i < this.size; i++)
		{
			if (this.buffer[i].Equals(item))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06006033 RID: 24627 RVA: 0x0027D440 File Offset: 0x0027B640
	public int IndexOf(T item)
	{
		if (this.buffer == null)
		{
			return -1;
		}
		for (int i = 0; i < this.size; i++)
		{
			if (this.buffer[i].Equals(item))
			{
				return i;
			}
		}
		return -1;
	}

	// Token: 0x06006034 RID: 24628 RVA: 0x0027D48C File Offset: 0x0027B68C
	public bool Remove(T item)
	{
		if (this.buffer != null)
		{
			EqualityComparer<T> @default = EqualityComparer<T>.Default;
			for (int i = 0; i < this.size; i++)
			{
				if (@default.Equals(this.buffer[i], item))
				{
					this.size--;
					this.buffer[i] = default(T);
					for (int j = i; j < this.size; j++)
					{
						this.buffer[j] = this.buffer[j + 1];
					}
					this.buffer[this.size] = default(T);
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x06006035 RID: 24629 RVA: 0x0027D544 File Offset: 0x0027B744
	public void RemoveAt(int index)
	{
		if (this.buffer != null && index > -1 && index < this.size)
		{
			this.size--;
			this.buffer[index] = default(T);
			for (int i = index; i < this.size; i++)
			{
				this.buffer[i] = this.buffer[i + 1];
			}
			this.buffer[this.size] = default(T);
		}
	}

	// Token: 0x06006036 RID: 24630 RVA: 0x0027D5D0 File Offset: 0x0027B7D0
	public T Pop()
	{
		if (this.buffer != null && this.size != 0)
		{
			T[] array = this.buffer;
			int num = this.size - 1;
			this.size = num;
			T result = array[num];
			this.buffer[this.size] = default(T);
			return result;
		}
		return default(T);
	}

	// Token: 0x06006037 RID: 24631 RVA: 0x00041BBA File Offset: 0x0003FDBA
	public T[] ToArray()
	{
		this.Trim();
		return this.buffer;
	}

	// Token: 0x06006038 RID: 24632 RVA: 0x0027D630 File Offset: 0x0027B830
	[DebuggerHidden]
	[DebuggerStepThrough]
	public void Sort(BetterList<T>.CompareFunc comparer)
	{
		int num = 0;
		int num2 = this.size - 1;
		bool flag = true;
		while (flag)
		{
			flag = false;
			for (int i = num; i < num2; i++)
			{
				if (comparer(this.buffer[i], this.buffer[i + 1]) > 0)
				{
					T t = this.buffer[i];
					this.buffer[i] = this.buffer[i + 1];
					this.buffer[i + 1] = t;
					flag = true;
				}
				else if (!flag)
				{
					num = ((i == 0) ? 0 : (i - 1));
				}
			}
		}
	}

	// Token: 0x04005F2E RID: 24366
	public T[] buffer;

	// Token: 0x04005F2F RID: 24367
	public int size;

	// Token: 0x02000F2A RID: 3882
	// (Invoke) Token: 0x0600603B RID: 24635
	public delegate int CompareFunc(T left, T right);
}
