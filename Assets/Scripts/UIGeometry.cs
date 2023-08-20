using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x02000F57 RID: 3927
public class UIGeometry
{
	// Token: 0x17000906 RID: 2310
	// (get) Token: 0x0600622F RID: 25135 RVA: 0x00042EE1 File Offset: 0x000410E1
	public bool hasVertices
	{
		get
		{
			return this.verts.Count > 0;
		}
	}

	// Token: 0x17000907 RID: 2311
	// (get) Token: 0x06006230 RID: 25136 RVA: 0x00042EF1 File Offset: 0x000410F1
	public bool hasTransformed
	{
		get
		{
			return this.mRtpVerts != null && this.mRtpVerts.Count > 0 && this.mRtpVerts.Count == this.verts.Count;
		}
	}

	// Token: 0x06006231 RID: 25137 RVA: 0x00042F23 File Offset: 0x00041123
	public void Clear()
	{
		this.verts.Clear();
		this.uvs.Clear();
		this.cols.Clear();
		this.mRtpVerts.Clear();
	}

	// Token: 0x06006232 RID: 25138 RVA: 0x0028B42C File Offset: 0x0028962C
	public void ApplyTransform(Matrix4x4 widgetToPanel, bool generateNormals = true)
	{
		if (this.verts.Count > 0)
		{
			this.mRtpVerts.Clear();
			int i = 0;
			int count = this.verts.Count;
			while (i < count)
			{
				this.mRtpVerts.Add(widgetToPanel.MultiplyPoint3x4(this.verts[i]));
				i++;
			}
			if (generateNormals)
			{
				this.mRtpNormal = widgetToPanel.MultiplyVector(Vector3.back).normalized;
				Vector3 normalized = widgetToPanel.MultiplyVector(Vector3.right).normalized;
				this.mRtpTan = new Vector4(normalized.x, normalized.y, normalized.z, -1f);
				return;
			}
		}
		else
		{
			this.mRtpVerts.Clear();
		}
	}

	// Token: 0x06006233 RID: 25139 RVA: 0x0028B4EC File Offset: 0x002896EC
	public void WriteToBuffers(List<Vector3> v, List<Vector2> u, List<Color> c, List<Vector3> n, List<Vector4> t, List<Vector4> u2)
	{
		if (this.mRtpVerts != null && this.mRtpVerts.Count > 0)
		{
			if (n == null)
			{
				int i = 0;
				int count = this.mRtpVerts.Count;
				while (i < count)
				{
					v.Add(this.mRtpVerts[i]);
					u.Add(this.uvs[i]);
					c.Add(this.cols[i]);
					i++;
				}
			}
			else
			{
				int j = 0;
				int count2 = this.mRtpVerts.Count;
				while (j < count2)
				{
					v.Add(this.mRtpVerts[j]);
					u.Add(this.uvs[j]);
					c.Add(this.cols[j]);
					n.Add(this.mRtpNormal);
					t.Add(this.mRtpTan);
					j++;
				}
			}
			if (u2 != null)
			{
				Vector4 zero = Vector4.zero;
				int k = 0;
				int count3 = this.verts.Count;
				while (k < count3)
				{
					zero.x = this.verts[k].x;
					zero.y = this.verts[k].y;
					u2.Add(zero);
					k++;
				}
			}
			if (this.onCustomWrite != null)
			{
				this.onCustomWrite(v, u, c, n, t, u2);
			}
		}
	}

	// Token: 0x0400603D RID: 24637
	public List<Vector3> verts = new List<Vector3>();

	// Token: 0x0400603E RID: 24638
	public List<Vector2> uvs = new List<Vector2>();

	// Token: 0x0400603F RID: 24639
	public List<Color> cols = new List<Color>();

	// Token: 0x04006040 RID: 24640
	public UIGeometry.OnCustomWrite onCustomWrite;

	// Token: 0x04006041 RID: 24641
	private List<Vector3> mRtpVerts = new List<Vector3>();

	// Token: 0x04006042 RID: 24642
	private Vector3 mRtpNormal;

	// Token: 0x04006043 RID: 24643
	private Vector4 mRtpTan;

	// Token: 0x02000F58 RID: 3928
	// (Invoke) Token: 0x06006236 RID: 25142
	public delegate void OnCustomWrite(List<Vector3> v, List<Vector2> u, List<Color> c, List<Vector3> n, List<Vector4> t, List<Vector4> u2);
}
