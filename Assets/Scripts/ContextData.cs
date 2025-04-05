using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x02001027 RID: 4135
[Serializable]
public class ContextData : ICloneable
{
	// Token: 0x17000A32 RID: 2610
	// (get) Token: 0x06006830 RID: 26672 RVA: 0x00047644 File Offset: 0x00045844
	// (set) Token: 0x06006831 RID: 26673 RVA: 0x0004764C File Offset: 0x0004584C
	public GameObject pTarget { get; set; }

	// Token: 0x17000A33 RID: 2611
	// (get) Token: 0x06006832 RID: 26674 RVA: 0x00047655 File Offset: 0x00045855
	// (set) Token: 0x06006833 RID: 26675 RVA: 0x0004765D File Offset: 0x0004585D
	public ContextData pParent { get; set; }

	// Token: 0x17000A34 RID: 2612
	// (get) Token: 0x06006834 RID: 26676 RVA: 0x00047666 File Offset: 0x00045866
	// (set) Token: 0x06006835 RID: 26677 RVA: 0x0004766E File Offset: 0x0004586E
	public UserItemData pUserItemData { get; set; }

	// Token: 0x17000A35 RID: 2613
	// (get) Token: 0x06006836 RID: 26678 RVA: 0x00047677 File Offset: 0x00045877
	// (set) Token: 0x06006837 RID: 26679 RVA: 0x0004767F File Offset: 0x0004587F
	public List<ContextData> pChildrenDataList
	{
		get
		{
			return this.mChildrenDataList;
		}
		set
		{
			this.mChildrenDataList = value;
		}
	}

	// Token: 0x17000A36 RID: 2614
	// (get) Token: 0x06006838 RID: 26680 RVA: 0x00047688 File Offset: 0x00045888
	// (set) Token: 0x06006839 RID: 26681 RVA: 0x00047690 File Offset: 0x00045890
	public bool pIsChildOpened { get; set; }

	// Token: 0x17000A37 RID: 2615
	// (get) Token: 0x0600683A RID: 26682 RVA: 0x00047699 File Offset: 0x00045899
	// (set) Token: 0x0600683B RID: 26683 RVA: 0x000476A1 File Offset: 0x000458A1
	public Vector3 pPosition { get; set; }

	// Token: 0x17000A38 RID: 2616
	// (get) Token: 0x0600683C RID: 26684 RVA: 0x000476AA File Offset: 0x000458AA
	// (set) Token: 0x0600683D RID: 26685 RVA: 0x000476B2 File Offset: 0x000458B2
	public bool pEnabled { get; set; }

	// Token: 0x0600683E RID: 26686 RVA: 0x000476BB File Offset: 0x000458BB
	public object Clone()
	{
		ContextData contextData = (ContextData)base.MemberwiseClone();
		contextData._DisplayName = new LocaleString(this._DisplayName._Text);
		contextData.mChildrenDataList = new List<ContextData>();
		return contextData;
	}

	// Token: 0x0600683F RID: 26687 RVA: 0x002A76A8 File Offset: 0x002A58A8
	public void AddChildName(string inName)
	{
		this._ChildrenNames = new List<string>(this._ChildrenNames)
		{
			inName
		}.ToArray();
	}

	// Token: 0x06006840 RID: 26688 RVA: 0x002A76D4 File Offset: 0x002A58D4
	public void RemoveChildName(string inName)
	{
		List<string> list = new List<string>(this._ChildrenNames);
		list.Remove(inName);
		this._ChildrenNames = list.ToArray();
	}

	// Token: 0x06006841 RID: 26689 RVA: 0x002A7704 File Offset: 0x002A5904
	public void RemoveAllChildren()
	{
		List<string> list = new List<string>();
		this._ChildrenNames = list.ToArray();
	}

	// Token: 0x04006559 RID: 25945
	public string _Name;

	// Token: 0x0400655A RID: 25946
	public string _ButtonName;

	// Token: 0x0400655B RID: 25947
	public LocaleString _DisplayName;

	// Token: 0x0400655C RID: 25948
	public LocaleString _ToolTipText;

	// Token: 0x0400655D RID: 25949
	public string[] _ChildrenNames;

	// Token: 0x0400655E RID: 25950
	public bool _DeactivateOnClick = true;

	// Token: 0x0400655F RID: 25951
	public string _ItemTemplateName;

	// Token: 0x04006560 RID: 25952
	public string _IconSpriteName;

	// Token: 0x04006561 RID: 25953
	public LocaleString _LabelText;

	// Token: 0x04006562 RID: 25954
	public Color _BackgroundColor = new Color(0.1f, 1f, 0.1f, 0.4f);

	// Token: 0x04006563 RID: 25955
	public Vector2 _2DScaleInPixels = new Vector2(120f, 56f);

	// Token: 0x04006564 RID: 25956
	public Vector2 _WidgetSize = new Vector2(128f, 128f);

	// Token: 0x04006568 RID: 25960
	[NonSerialized]
	private List<ContextData> mChildrenDataList = new List<ContextData>();
}
