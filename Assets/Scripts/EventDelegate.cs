using System;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

// Token: 0x02000F30 RID: 3888
[Serializable]
public class EventDelegate
{
	// Token: 0x170008D4 RID: 2260
	// (get) Token: 0x0600606E RID: 24686 RVA: 0x00041D75 File Offset: 0x0003FF75
	// (set) Token: 0x0600606F RID: 24687 RVA: 0x00041D7D File Offset: 0x0003FF7D
	public MonoBehaviour target
	{
		get
		{
			return this.mTarget;
		}
		set
		{
			this.mTarget = value;
			this.mCachedCallback = null;
			this.mRawDelegate = false;
			this.mCached = false;
			this.mMethod = null;
			this.mParameterInfos = null;
			this.mParameters = null;
		}
	}

	// Token: 0x170008D5 RID: 2261
	// (get) Token: 0x06006070 RID: 24688 RVA: 0x00041DB0 File Offset: 0x0003FFB0
	// (set) Token: 0x06006071 RID: 24689 RVA: 0x00041DB8 File Offset: 0x0003FFB8
	public string methodName
	{
		get
		{
			return this.mMethodName;
		}
		set
		{
			this.mMethodName = value;
			this.mCachedCallback = null;
			this.mRawDelegate = false;
			this.mCached = false;
			this.mMethod = null;
			this.mParameterInfos = null;
			this.mParameters = null;
		}
	}

	// Token: 0x170008D6 RID: 2262
	// (get) Token: 0x06006072 RID: 24690 RVA: 0x00041DEB File Offset: 0x0003FFEB
	public EventDelegate.Parameter[] parameters
	{
		get
		{
			if (!this.mCached)
			{
				this.Cache();
			}
			return this.mParameters;
		}
	}

	// Token: 0x170008D7 RID: 2263
	// (get) Token: 0x06006073 RID: 24691 RVA: 0x00041E01 File Offset: 0x00040001
	public bool isValid
	{
		get
		{
			if (!this.mCached)
			{
				this.Cache();
			}
			return (this.mRawDelegate && this.mCachedCallback != null) || (this.mTarget != null && !string.IsNullOrEmpty(this.mMethodName));
		}
	}

	// Token: 0x170008D8 RID: 2264
	// (get) Token: 0x06006074 RID: 24692 RVA: 0x0027DE10 File Offset: 0x0027C010
	public bool isEnabled
	{
		get
		{
			if (!this.mCached)
			{
				this.Cache();
			}
			if (this.mRawDelegate && this.mCachedCallback != null)
			{
				return true;
			}
			if (this.mTarget == null)
			{
				return false;
			}
			MonoBehaviour monoBehaviour = this.mTarget;
			return monoBehaviour == null || monoBehaviour.enabled;
		}
	}

	// Token: 0x06006075 RID: 24693 RVA: 0x000065ED File Offset: 0x000047ED
	public EventDelegate()
	{
	}

	// Token: 0x06006076 RID: 24694 RVA: 0x00041E41 File Offset: 0x00040041
	public EventDelegate(EventDelegate.Callback call)
	{
		this.Set(call);
	}

	// Token: 0x06006077 RID: 24695 RVA: 0x00041E50 File Offset: 0x00040050
	public EventDelegate(MonoBehaviour target, string methodName)
	{
		this.Set(target, methodName);
	}

	// Token: 0x06006078 RID: 24696 RVA: 0x00041E60 File Offset: 0x00040060
	private static string GetMethodName(EventDelegate.Callback callback)
	{
		return callback.Method.Name;
	}

	// Token: 0x06006079 RID: 24697 RVA: 0x00041E6D File Offset: 0x0004006D
	private static bool IsValid(EventDelegate.Callback callback)
	{
		return callback != null && callback.Method != null;
	}

	// Token: 0x0600607A RID: 24698 RVA: 0x0027DE68 File Offset: 0x0027C068
	public override bool Equals(object obj)
	{
		if (obj == null)
		{
			return !this.isValid;
		}
		if (obj is EventDelegate.Callback)
		{
			EventDelegate.Callback callback = obj as EventDelegate.Callback;
			if (callback.Equals(this.mCachedCallback))
			{
				return true;
			}
			MonoBehaviour y = callback.Target as MonoBehaviour;
			return this.mTarget == y && string.Equals(this.mMethodName, EventDelegate.GetMethodName(callback));
		}
		else
		{
			if (obj is EventDelegate)
			{
				EventDelegate eventDelegate = obj as EventDelegate;
				return this.mTarget == eventDelegate.mTarget && string.Equals(this.mMethodName, eventDelegate.mMethodName);
			}
			return false;
		}
	}

	// Token: 0x0600607B RID: 24699 RVA: 0x00041E80 File Offset: 0x00040080
	public override int GetHashCode()
	{
		return EventDelegate.s_Hash;
	}

	// Token: 0x0600607C RID: 24700 RVA: 0x0027DF08 File Offset: 0x0027C108
	private void Set(EventDelegate.Callback call)
	{
		this.Clear();
		if (call != null && EventDelegate.IsValid(call))
		{
			this.mTarget = (call.Target as MonoBehaviour);
			if (this.mTarget == null)
			{
				this.mRawDelegate = true;
				this.mCachedCallback = call;
				this.mMethodName = null;
				return;
			}
			this.mMethodName = EventDelegate.GetMethodName(call);
			this.mRawDelegate = false;
		}
	}

	// Token: 0x0600607D RID: 24701 RVA: 0x00041E87 File Offset: 0x00040087
	public void Set(MonoBehaviour target, string methodName)
	{
		this.Clear();
		this.mTarget = target;
		this.mMethodName = methodName;
	}

	// Token: 0x0600607E RID: 24702 RVA: 0x0027DF70 File Offset: 0x0027C170
	private void Cache()
	{
		this.mCached = true;
		if (this.mRawDelegate)
		{
			return;
		}
		if ((this.mCachedCallback == null || this.mCachedCallback.Target as MonoBehaviour != this.mTarget || EventDelegate.GetMethodName(this.mCachedCallback) != this.mMethodName) && this.mTarget != null && !string.IsNullOrEmpty(this.mMethodName))
		{
			Type type = this.mTarget.GetType();
			this.mMethod = null;
			while (type != null)
			{
				try
				{
					this.mMethod = type.GetMethod(this.mMethodName, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
					if (this.mMethod != null)
					{
						break;
					}
				}
				catch (Exception)
				{
				}
				type = type.BaseType;
			}
			if (this.mMethod == null)
			{
				string str = "Could not find method '";
				string str2 = this.mMethodName;
				string str3 = "' on ";
				Type type2 = this.mTarget.GetType();
				Debug.LogError(str + str2 + str3 + ((type2 != null) ? type2.ToString() : null), this.mTarget);
				return;
			}
			if (this.mMethod.ReturnType != typeof(void))
			{
				Type type3 = this.mTarget.GetType();
				Debug.LogError(((type3 != null) ? type3.ToString() : null) + "." + this.mMethodName + " must have a 'void' return type.", this.mTarget);
				return;
			}
			this.mParameterInfos = this.mMethod.GetParameters();
			if (this.mParameterInfos.Length == 0)
			{
				this.mCachedCallback = (EventDelegate.Callback)Delegate.CreateDelegate(typeof(EventDelegate.Callback), this.mTarget, this.mMethodName);
				this.mArgs = null;
				this.mParameters = null;
				return;
			}
			this.mCachedCallback = null;
			if (this.mParameters == null || this.mParameters.Length != this.mParameterInfos.Length)
			{
				this.mParameters = new EventDelegate.Parameter[this.mParameterInfos.Length];
				int i = 0;
				int num = this.mParameters.Length;
				while (i < num)
				{
					this.mParameters[i] = new EventDelegate.Parameter();
					i++;
				}
			}
			int j = 0;
			int num2 = this.mParameters.Length;
			while (j < num2)
			{
				this.mParameters[j].expectedType = this.mParameterInfos[j].ParameterType;
				j++;
			}
		}
	}

	// Token: 0x0600607F RID: 24703 RVA: 0x0027E1C0 File Offset: 0x0027C3C0
	public bool Execute()
	{
		if (!this.mCached)
		{
			this.Cache();
		}
		if (this.mCachedCallback != null)
		{
			this.mCachedCallback();
			return true;
		}
		if (this.mMethod != null)
		{
			if (this.mParameters == null || this.mParameters.Length == 0)
			{
				this.mMethod.Invoke(this.mTarget, null);
			}
			else
			{
				if (this.mArgs == null || this.mArgs.Length != this.mParameters.Length)
				{
					this.mArgs = new object[this.mParameters.Length];
				}
				int i = 0;
				int num = this.mParameters.Length;
				while (i < num)
				{
					this.mArgs[i] = this.mParameters[i].value;
					i++;
				}
				try
				{
					this.mMethod.Invoke(this.mTarget, this.mArgs);
				}
				catch (ArgumentException ex)
				{
					string text = "Error calling ";
					if (this.mTarget == null)
					{
						text += this.mMethod.Name;
					}
					else
					{
						string str = text;
						Type type = this.mTarget.GetType();
						text = str + ((type != null) ? type.ToString() : null) + "." + this.mMethod.Name;
					}
					text = text + ": " + ex.Message;
					text += "\n  Expected: ";
					if (this.mParameterInfos.Length == 0)
					{
						text += "no arguments";
					}
					else
					{
						string str2 = text;
						ParameterInfo parameterInfo = this.mParameterInfos[0];
						text = str2 + ((parameterInfo != null) ? parameterInfo.ToString() : null);
						for (int j = 1; j < this.mParameterInfos.Length; j++)
						{
							string str3 = text;
							string str4 = ", ";
							Type parameterType = this.mParameterInfos[j].ParameterType;
							text = str3 + str4 + ((parameterType != null) ? parameterType.ToString() : null);
						}
					}
					text += "\n  Received: ";
					if (this.mParameters.Length == 0)
					{
						text += "no arguments";
					}
					else
					{
						string str5 = text;
						Type type2 = this.mParameters[0].type;
						text = str5 + ((type2 != null) ? type2.ToString() : null);
						for (int k = 1; k < this.mParameters.Length; k++)
						{
							string str6 = text;
							string str7 = ", ";
							Type type3 = this.mParameters[k].type;
							text = str6 + str7 + ((type3 != null) ? type3.ToString() : null);
						}
					}
					text += "\n";
					Debug.LogError(text);
				}
				int l = 0;
				int num2 = this.mArgs.Length;
				while (l < num2)
				{
					if (this.mParameterInfos[l].IsIn || this.mParameterInfos[l].IsOut)
					{
						this.mParameters[l].value = this.mArgs[l];
					}
					this.mArgs[l] = null;
					l++;
				}
			}
			return true;
		}
		return false;
	}

	// Token: 0x06006080 RID: 24704 RVA: 0x0027E498 File Offset: 0x0027C698
	public void Clear()
	{
		this.mTarget = null;
		this.mMethodName = null;
		this.mRawDelegate = false;
		this.mCachedCallback = null;
		this.mParameters = null;
		this.mCached = false;
		this.mMethod = null;
		this.mParameterInfos = null;
		this.mArgs = null;
	}

	// Token: 0x06006081 RID: 24705 RVA: 0x0027E4E4 File Offset: 0x0027C6E4
	public override string ToString()
	{
		if (this.mTarget != null)
		{
			string text = this.mTarget.GetType().ToString();
			int num = text.LastIndexOf('.');
			if (num > 0)
			{
				text = text.Substring(num + 1);
			}
			if (!string.IsNullOrEmpty(this.methodName))
			{
				return text + "/" + this.methodName;
			}
			return text + "/[delegate]";
		}
		else
		{
			if (!this.mRawDelegate)
			{
				return null;
			}
			return "[delegate]";
		}
	}

	// Token: 0x06006082 RID: 24706 RVA: 0x0027E564 File Offset: 0x0027C764
	public static void Execute(List<EventDelegate> list)
	{
		if (list != null)
		{
			for (int i = 0; i < list.Count; i++)
			{
				EventDelegate eventDelegate = list[i];
				if (eventDelegate != null)
				{
					try
					{
						eventDelegate.Execute();
					}
					catch (Exception ex)
					{
						if (ex.InnerException != null)
						{
							Debug.LogException(ex.InnerException);
						}
						else
						{
							Debug.LogException(ex);
						}
					}
					if (i >= list.Count)
					{
						break;
					}
					if (list[i] != eventDelegate)
					{
						continue;
					}
					if (eventDelegate.oneShot)
					{
						list.RemoveAt(i);
						continue;
					}
				}
			}
		}
	}

	// Token: 0x06006083 RID: 24707 RVA: 0x0027E5EC File Offset: 0x0027C7EC
	public static bool IsValid(List<EventDelegate> list)
	{
		if (list != null)
		{
			int i = 0;
			int count = list.Count;
			while (i < count)
			{
				EventDelegate eventDelegate = list[i];
				if (eventDelegate != null && eventDelegate.isValid)
				{
					return true;
				}
				i++;
			}
		}
		return false;
	}

	// Token: 0x06006084 RID: 24708 RVA: 0x0027E628 File Offset: 0x0027C828
	public static EventDelegate Set(List<EventDelegate> list, EventDelegate.Callback callback)
	{
		if (list != null)
		{
			EventDelegate eventDelegate = new EventDelegate(callback);
			list.Clear();
			list.Add(eventDelegate);
			return eventDelegate;
		}
		return null;
	}

	// Token: 0x06006085 RID: 24709 RVA: 0x00041E9D File Offset: 0x0004009D
	public static void Set(List<EventDelegate> list, EventDelegate del)
	{
		if (list != null)
		{
			list.Clear();
			list.Add(del);
		}
	}

	// Token: 0x06006086 RID: 24710 RVA: 0x00041EAF File Offset: 0x000400AF
	public static EventDelegate Add(List<EventDelegate> list, EventDelegate.Callback callback)
	{
		return EventDelegate.Add(list, callback, false);
	}

	// Token: 0x06006087 RID: 24711 RVA: 0x0027E650 File Offset: 0x0027C850
	public static EventDelegate Add(List<EventDelegate> list, EventDelegate.Callback callback, bool oneShot)
	{
		if (list != null)
		{
			int i = 0;
			int count = list.Count;
			while (i < count)
			{
				EventDelegate eventDelegate = list[i];
				if (eventDelegate != null && eventDelegate.Equals(callback))
				{
					return eventDelegate;
				}
				i++;
			}
			EventDelegate eventDelegate2 = new EventDelegate(callback);
			eventDelegate2.oneShot = oneShot;
			list.Add(eventDelegate2);
			return eventDelegate2;
		}
		Debug.LogWarning("Attempting to add a callback to a list that's null");
		return null;
	}

	// Token: 0x06006088 RID: 24712 RVA: 0x00041EB9 File Offset: 0x000400B9
	public static void Add(List<EventDelegate> list, EventDelegate ev)
	{
		EventDelegate.Add(list, ev, ev.oneShot);
	}

	// Token: 0x06006089 RID: 24713 RVA: 0x0027E6AC File Offset: 0x0027C8AC
	public static void Add(List<EventDelegate> list, EventDelegate ev, bool oneShot)
	{
		if (ev.mRawDelegate || ev.target == null || string.IsNullOrEmpty(ev.methodName))
		{
			EventDelegate.Add(list, ev.mCachedCallback, oneShot);
			return;
		}
		if (list != null)
		{
			int i = 0;
			int count = list.Count;
			while (i < count)
			{
				EventDelegate eventDelegate = list[i];
				if (eventDelegate != null && eventDelegate.Equals(ev))
				{
					return;
				}
				i++;
			}
			EventDelegate eventDelegate2 = new EventDelegate(ev.target, ev.methodName);
			eventDelegate2.oneShot = oneShot;
			if (ev.mParameters != null && ev.mParameters.Length != 0)
			{
				eventDelegate2.mParameters = new EventDelegate.Parameter[ev.mParameters.Length];
				for (int j = 0; j < ev.mParameters.Length; j++)
				{
					eventDelegate2.mParameters[j] = ev.mParameters[j];
				}
			}
			list.Add(eventDelegate2);
			return;
		}
		Debug.LogWarning("Attempting to add a callback to a list that's null");
	}

	// Token: 0x0600608A RID: 24714 RVA: 0x0027E794 File Offset: 0x0027C994
	public static bool Remove(List<EventDelegate> list, EventDelegate.Callback callback)
	{
		if (list != null)
		{
			int i = 0;
			int count = list.Count;
			while (i < count)
			{
				EventDelegate eventDelegate = list[i];
				if (eventDelegate != null && eventDelegate.Equals(callback))
				{
					list.RemoveAt(i);
					return true;
				}
				i++;
			}
		}
		return false;
	}

	// Token: 0x0600608B RID: 24715 RVA: 0x0027E794 File Offset: 0x0027C994
	public static bool Remove(List<EventDelegate> list, EventDelegate ev)
	{
		if (list != null)
		{
			int i = 0;
			int count = list.Count;
			while (i < count)
			{
				EventDelegate eventDelegate = list[i];
				if (eventDelegate != null && eventDelegate.Equals(ev))
				{
					list.RemoveAt(i);
					return true;
				}
				i++;
			}
		}
		return false;
	}

	// Token: 0x04005F53 RID: 24403
	[SerializeField]
	private MonoBehaviour mTarget;

	// Token: 0x04005F54 RID: 24404
	[SerializeField]
	private string mMethodName;

	// Token: 0x04005F55 RID: 24405
	[SerializeField]
	private EventDelegate.Parameter[] mParameters;

	// Token: 0x04005F56 RID: 24406
	public bool oneShot;

	// Token: 0x04005F57 RID: 24407
	[NonSerialized]
	private EventDelegate.Callback mCachedCallback;

	// Token: 0x04005F58 RID: 24408
	[NonSerialized]
	private bool mRawDelegate;

	// Token: 0x04005F59 RID: 24409
	[NonSerialized]
	private bool mCached;

	// Token: 0x04005F5A RID: 24410
	[NonSerialized]
	private MethodInfo mMethod;

	// Token: 0x04005F5B RID: 24411
	[NonSerialized]
	private ParameterInfo[] mParameterInfos;

	// Token: 0x04005F5C RID: 24412
	[NonSerialized]
	private object[] mArgs;

	// Token: 0x04005F5D RID: 24413
	private static int s_Hash = "EventDelegate".GetHashCode();

	// Token: 0x02000F31 RID: 3889
	[Serializable]
	public class Parameter
	{
		// Token: 0x0600608D RID: 24717 RVA: 0x00041ED9 File Offset: 0x000400D9
		public Parameter()
		{
		}

		// Token: 0x0600608E RID: 24718 RVA: 0x00041EF1 File Offset: 0x000400F1
		public Parameter(UnityEngine.Object obj, string field)
		{
			this.obj = obj;
			this.field = field;
		}

		// Token: 0x0600608F RID: 24719 RVA: 0x00041F17 File Offset: 0x00040117
		public Parameter(object val)
		{
			this.mValue = val;
		}

		// Token: 0x170008D9 RID: 2265
		// (get) Token: 0x06006090 RID: 24720 RVA: 0x0027E7D8 File Offset: 0x0027C9D8
		// (set) Token: 0x06006091 RID: 24721 RVA: 0x00041F36 File Offset: 0x00040136
		public object value
		{
			get
			{
				if (this.mValue != null)
				{
					return this.mValue;
				}
				if (!this.cached)
				{
					this.cached = true;
					this.fieldInfo = null;
					this.propInfo = null;
					if (this.obj != null && !string.IsNullOrEmpty(this.field))
					{
						Type type = this.obj.GetType();
						this.propInfo = type.GetProperty(this.field);
						if (this.propInfo == null)
						{
							this.fieldInfo = type.GetField(this.field);
						}
					}
				}
				if (this.propInfo != null)
				{
					return this.propInfo.GetValue(this.obj, null);
				}
				if (this.fieldInfo != null)
				{
					return this.fieldInfo.GetValue(this.obj);
				}
				if (this.obj != null)
				{
					return this.obj;
				}
				if (this.expectedType != null && this.expectedType.IsValueType)
				{
					return null;
				}
				return Convert.ChangeType(null, this.expectedType);
			}
			set
			{
				this.mValue = value;
			}
		}

		// Token: 0x170008DA RID: 2266
		// (get) Token: 0x06006092 RID: 24722 RVA: 0x00041F3F File Offset: 0x0004013F
		public Type type
		{
			get
			{
				if (this.mValue != null)
				{
					return this.mValue.GetType();
				}
				if (this.obj == null)
				{
					return typeof(void);
				}
				return this.obj.GetType();
			}
		}

		// Token: 0x04005F5E RID: 24414
		public UnityEngine.Object obj;

		// Token: 0x04005F5F RID: 24415
		public string field;

		// Token: 0x04005F60 RID: 24416
		[NonSerialized]
		private object mValue;

		// Token: 0x04005F61 RID: 24417
		[NonSerialized]
		public Type expectedType = typeof(void);

		// Token: 0x04005F62 RID: 24418
		[NonSerialized]
		public bool cached;

		// Token: 0x04005F63 RID: 24419
		[NonSerialized]
		public PropertyInfo propInfo;

		// Token: 0x04005F64 RID: 24420
		[NonSerialized]
		public FieldInfo fieldInfo;
	}

	// Token: 0x02000F32 RID: 3890
	// (Invoke) Token: 0x06006094 RID: 24724
	public delegate void Callback();
}
