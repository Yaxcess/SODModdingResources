using System;
using UnityEngine;

// Token: 0x02000EC2 RID: 3778
public class Spline
{
	// Token: 0x06005D72 RID: 23922 RVA: 0x0026EC3C File Offset: 0x0026CE3C
	public Spline(int numCtrolPts, bool looping, bool constSpeed, bool alignTangent, bool hasQ)
	{
		this.mLooping = looping;
		this.mConstSpeed = constSpeed;
		this.mAlignTangent = alignTangent;
		this.mNumNodes = numCtrolPts;
		this.mNodes = new SplineNode[this.mNumNodes];
		this.mHasQ = hasQ;
	}

	// Token: 0x06005D73 RID: 23923 RVA: 0x0003F7D6 File Offset: 0x0003D9D6
	public void SetControlPoint(int idx, Vector3 cpoint, Quaternion cqut, float t)
	{
		this.mNodes[idx] = new SplineNode();
		this.mNodes[idx].mPoint = cpoint;
		this.mNodes[idx].mQuat = cqut;
		this.mNodes[idx].mTime = t;
	}

	// Token: 0x06005D74 RID: 23924 RVA: 0x0026EC90 File Offset: 0x0026CE90
	public Spline(Vector3[] ctrlPoints, Quaternion[] ctrlQuats, float[] ctrlTimes, bool looping, bool constSpeed, bool alignTangent)
	{
		this.mLooping = looping;
		this.mConstSpeed = constSpeed;
		this.mAlignTangent = alignTangent;
		if (ctrlQuats == null)
		{
			this.mHasQ = false;
		}
		else
		{
			this.mHasQ = (ctrlQuats.Length != 0);
		}
		this.mNumNodes = ctrlPoints.Length;
		this.mNodes = new SplineNode[this.mNumNodes];
		for (int i = 0; i < this.mNumNodes; i++)
		{
			this.mNodes[i] = new SplineNode();
			this.mNodes[i].mPoint = ctrlPoints[i];
			if (ctrlQuats != null && ctrlQuats.Length > i)
			{
				this.mNodes[i].mQuat = ctrlQuats[i];
			}
			if (ctrlTimes != null && ctrlTimes.Length > i)
			{
				this.mNodes[i].mTime = ctrlTimes[i];
			}
		}
		this.RecalculateSpline();
	}

	// Token: 0x06005D75 RID: 23925 RVA: 0x0026ED68 File Offset: 0x0026CF68
	public void GeneratePath(Transform start, Transform end, float turnRadius, float minDist, bool endAlign, float moveHeight)
	{
		this.mLooping = false;
		this.mConstSpeed = true;
		if (this.mNumNodes < 10)
		{
			this.mNumNodes = 10;
			this.mNodes = new SplineNode[this.mNumNodes];
		}
		Vector3[] array = new Vector3[10];
		float[] array2 = new float[]
		{
			0f,
			0.1f,
			0.16f,
			0.2f,
			0.5f,
			0.75f,
			0.8f,
			0.85f,
			0.9f,
			1f
		};
		Vector3 position = new Vector3(0f, 0f, 0f);
		Vector3 position2 = new Vector3(0f, 0f, 0f);
		Vector3 forward = new Vector3(0f, 0f, 0f);
		Vector3 forward2 = new Vector3(0f, 0f, 0f);
		position = start.position;
		position.y = moveHeight;
		position2 = end.position;
		position2.y = moveHeight;
		forward = start.forward;
		forward.y = 0f;
		forward.Normalize();
		forward2 = end.forward;
		forward2.y = 0f;
		forward2.Normalize();
		array[0] = position;
		array[9] = position2;
		array[1] = this.GetHeartPoint(position, position2, forward, 1f * turnRadius);
		array[2] = this.GetHeartPoint(array[1], position2, array[1] - array[0], turnRadius);
		array[3] = this.GetHeartPoint(array[2], position2, array[2] - array[1], turnRadius);
		if (endAlign)
		{
			array[8] = position2 + forward2 * (-1f * turnRadius);
			array[7] = this.GetHeartPoint(array[8], position, array[8] - array[9], 1f * turnRadius);
			array[6] = this.GetHeartPoint(array[7], position, array[7] - array[8], 1f * turnRadius);
			array[5] = this.GetHeartPoint(array[6], position, array[6] - array[7], 1f * turnRadius);
			array[4] = (array[3] + array[5]) * 0.5f;
			this.mNumNodes = 10;
		}
		else
		{
			array2[4] = 1f;
			this.mNumNodes = 5;
			array[4] = position2;
		}
		for (int i = 0; i < this.mNumNodes; i++)
		{
			this.SetControlPoint(i, array[i], Quaternion.identity, array2[i]);
		}
		this.RecalculateSpline();
	}

	// Token: 0x06005D76 RID: 23926 RVA: 0x0026F018 File Offset: 0x0026D218
	public float GetPosQuatByTime(float t, out Vector3 pos, out Quaternion quat)
	{
		float num = t;
		pos = Vector3.zero;
		quat = Quaternion.identity;
		if (num < 0f)
		{
			num = 0f;
		}
		if (num > 1f)
		{
			num = 1f;
		}
		if (this.mNumNodes < 2)
		{
			return num;
		}
		float t2;
		int num2;
		int num3;
		if (this.GetSectionTimeInfo(num, out t2, out num2, out num3))
		{
			if (this.mHasQ)
			{
				quat = this.CalculateQuat(this.mNodes[num2].mQuat, this.mNodes[num3].mQuat, t2);
			}
			pos = this.Calculate3D(num2, num3, t2);
		}
		if (this.mAlignTangent)
		{
			float num4 = 0.02f;
			if (this.mLinearLength >= 1f)
			{
				num4 = 1f / this.mLinearLength;
			}
			float num5 = num + num4;
			if (num5 > 1f)
			{
				num5 = num - num4;
			}
			if (num5 < 0f)
			{
				num5 = 0f;
			}
			if (this.GetSectionTimeInfo(num5, out t2, out num2, out num3))
			{
				Vector3 vector = this.Calculate3D(num2, num3, t2);
				if (num5 > num)
				{
					vector -= pos;
				}
				else
				{
					vector = pos - vector;
				}
				if (vector.magnitude > 0.001f)
				{
					vector.Normalize();
					quat = Quaternion.LookRotation(vector);
				}
			}
		}
		return num;
	}

	// Token: 0x06005D77 RID: 23927 RVA: 0x0026F168 File Offset: 0x0026D368
	public float GetPosQuatByDist(float d, out Vector3 pos, out Quaternion quat)
	{
		float num = d / this.mLinearLength;
		Vector3 vector = new Vector3(0f, 0f, 0f);
		Quaternion quaternion = new Quaternion(0f, 0f, 0f, 0f);
		num = this.GetPosQuatByTime(num, out vector, out quaternion);
		pos = vector;
		quat = quaternion;
		return num * this.mLinearLength;
	}

	// Token: 0x06005D78 RID: 23928 RVA: 0x0001EF41 File Offset: 0x0001D141
	public float GetClosestPoint(Vector3 pos, float pPos)
	{
		return 0f;
	}

	// Token: 0x06005D79 RID: 23929 RVA: 0x0026F1D4 File Offset: 0x0026D3D4
	public void GenerateTangents()
	{
		this.mHasQ = false;
		this.mAlignTangent = true;
		Vector3 vector = new Vector3(0f, 0f, 0f);
		Quaternion mQuat = new Quaternion(0f, 0f, 0f, 0f);
		for (int i = 0; i < this.mNumNodes; i++)
		{
			this.GetPosQuatByTime(this.mNodes[i].mTime, out vector, out mQuat);
			this.mNodes[i].mQuat = mQuat;
		}
		this.mHasQ = true;
		this.mAlignTangent = false;
	}

	// Token: 0x06005D7A RID: 23930 RVA: 0x0026F268 File Offset: 0x0026D468
	public void RecalculateSpline()
	{
		int num = this.mNumNodes - 1;
		for (int i = 0; i < this.mNumNodes; i++)
		{
			if (this.mConstSpeed)
			{
				if (this.mLooping)
				{
					if (i == 0)
					{
						this.mNodes[i].mTime = 1f;
					}
					else
					{
						this.mNodes[i].mTime = (float)i / (float)this.mNumNodes;
					}
				}
				else
				{
					this.mNodes[i].mTime = (float)i / (float)(this.mNumNodes - 1);
				}
			}
		}
		for (int i = 0; i < this.mNumNodes; i++)
		{
			int num2 = i;
			int num3;
			if (i == num)
			{
				num3 = 0;
			}
			else
			{
				num3 = i + 1;
			}
			if (i == 0)
			{
				this.mNodes[num2].mTimeFactor = this.mNodes[num3].mTime;
			}
			else
			{
				this.mNodes[num2].mTimeFactor = this.mNodes[num3].mTime - this.mNodes[num2].mTime;
			}
			this.mNodes[num2].mTimeFactor = 1f / this.mNodes[num2].mTimeFactor;
		}
		if (this.mLooping)
		{
			this.mNodes[num].mTimeFactor = this.mNodes[0].mTime - this.mNodes[num].mTime;
			this.mNodes[num].mTimeFactor = 1f / this.mNodes[num].mTimeFactor;
		}
		this.CalculateLinearLength((float)this.mNumSample, this.mConstSpeed);
	}

	// Token: 0x06005D7B RID: 23931 RVA: 0x0003F810 File Offset: 0x0003DA10
	public void OnDrawGizmos(int np)
	{
		this.OnDrawGizmos(np, Matrix4x4.identity, Color.blue);
	}

	// Token: 0x06005D7C RID: 23932 RVA: 0x0026F3D8 File Offset: 0x0026D5D8
	public void OnDrawGizmos(int np, Matrix4x4 tmat, Color c)
	{
		float num = 0f;
		float num2 = 1f / (float)np;
		Gizmos.color = c;
		Vector3 from;
		Quaternion quaternion;
		this.GetPosQuatByDist(num, out from, out quaternion);
		Gizmos.matrix = tmat;
		for (int i = 1; i <= np; i++)
		{
			num += num2;
			Vector3 vector;
			Quaternion quaternion2;
			this.GetPosQuatByTime(num, out vector, out quaternion2);
			Gizmos.DrawLine(from, vector);
			from = vector;
			quaternion = quaternion2;
		}
		if (this.mHasQ)
		{
			Matrix4x4 rhs = default(Matrix4x4);
			for (int i = 0; i < this.mNumNodes; i++)
			{
				rhs.SetTRS(this.mNodes[i].mPoint, this.mNodes[i].mQuat, Vector3.one);
				Gizmos.matrix = tmat * rhs;
				Gizmos.color = Color.red;
				Gizmos.DrawLine(Vector3.zero, Vector3.right);
				Gizmos.color = Color.green;
				Gizmos.DrawLine(Vector3.zero, Vector3.up);
				Gizmos.color = Color.blue;
				Gizmos.DrawLine(Vector3.zero, Vector3.forward);
			}
			return;
		}
		for (int i = 0; i < this.mNumNodes; i++)
		{
			switch (i % 5)
			{
			case 0:
				Gizmos.color = Color.black;
				break;
			case 1:
				Gizmos.color = Color.white;
				break;
			case 2:
				Gizmos.color = Color.red;
				break;
			case 3:
				Gizmos.color = Color.green;
				break;
			case 4:
				Gizmos.color = Color.blue;
				break;
			}
			Gizmos.DrawWireCube(this.mNodes[i].mPoint, new Vector3(0.2f, 0.2f, 0.2f));
		}
	}

	// Token: 0x06005D7D RID: 23933 RVA: 0x0026F590 File Offset: 0x0026D790
	private void CalculateLinearLength(float ns, bool normalizetime)
	{
		bool flag = this.mHasQ;
		float num = 1f / ns;
		float num2 = num;
		bool flag2 = this.mAlignTangent;
		this.mLinearLength = 0f;
		Vector3 b = this.mNodes[0].mPoint;
		this.mHasQ = false;
		this.mAlignTangent = false;
		int i = 1;
		while (num2 < num + 1f)
		{
			Vector3 vector;
			Quaternion quaternion;
			this.GetPosQuatByTime(num2, out vector, out quaternion);
			this.mLinearLength += Vector3.Distance(vector, b);
			if (i < this.mNumNodes && num2 >= this.mNodes[i].mTime)
			{
				this.mNodes[i].mDistance = this.mLinearLength;
				i++;
			}
			b = vector;
			num2 += num;
		}
		if (this.mLooping)
		{
			this.mNodes[0].mTime = 1f;
			this.mNodes[0].mDistance = this.mLinearLength;
		}
		else
		{
			this.mNodes[0].mTime = 0f;
			this.mNodes[0].mDistance = 0f;
			this.mNodes[this.mNumNodes - 1].mDistance = this.mLinearLength;
		}
		if (normalizetime)
		{
			for (i = 1; i < this.mNumNodes; i++)
			{
				this.mNodes[i].mTime = this.mNodes[i].mDistance / this.mLinearLength;
			}
			this.mNodes[0].mTimeFactor = 1f / this.mNodes[1].mTime;
			for (i = 1; i < this.mNumNodes - 1; i++)
			{
				this.mNodes[i].mTimeFactor = 1f / (this.mNodes[i + 1].mTime - this.mNodes[i].mTime);
			}
			if (this.mLooping)
			{
				this.mNodes[this.mNumNodes - 1].mTimeFactor = 1f / (this.mNodes[0].mTime - this.mNodes[this.mNumNodes - 1].mTime);
			}
			else
			{
				this.mNodes[this.mNumNodes - 1].mTimeFactor = 0f;
			}
		}
		this.mHasQ = flag;
		this.mAlignTangent = flag2;
	}

	// Token: 0x06005D7E RID: 23934 RVA: 0x0026F7D0 File Offset: 0x0026D9D0
	public bool GetSectionTimeInfo(float t, out float rt, out int n1, out int n2)
	{
		for (int i = 1; i < this.mNumNodes; i++)
		{
			if (this.mNodes[i].mTime >= t)
			{
				int num = i - 1;
				if (num == 0 && this.mLooping)
				{
					rt = t * this.mNodes[0].mTimeFactor;
				}
				else
				{
					rt = (t - this.mNodes[num].mTime) * this.mNodes[num].mTimeFactor;
				}
				n1 = num;
				n2 = i;
				return true;
			}
		}
		if (this.mLooping && this.mNodes[0].mTime >= t)
		{
			int num = this.mNumNodes - 1;
			int i = 0;
			rt = (t - this.mNodes[num].mTime) * this.mNodes[num].mTimeFactor;
			n1 = num;
			n2 = i;
			return true;
		}
		n1 = 0;
		n2 = 0;
		rt = 0f;
		return false;
	}

	// Token: 0x06005D7F RID: 23935 RVA: 0x0026F8A8 File Offset: 0x0026DAA8
	private Vector3 Calculate3D(int n1, int n2, float t)
	{
		Vector3 mPoint = new Vector3(0f, 0f, 0f);
		Vector3 mPoint2 = new Vector3(0f, 0f, 0f);
		Vector3 mPoint3 = new Vector3(0f, 0f, 0f);
		Vector3 mPoint4 = new Vector3(0f, 0f, 0f);
		Vector3 a = new Vector3(0f, 0f, 0f);
		Vector3 a2 = new Vector3(0f, 0f, 0f);
		mPoint2 = this.mNodes[n1].mPoint;
		mPoint3 = this.mNodes[n2].mPoint;
		if (this.mLooping)
		{
			if (n1 == 0)
			{
				mPoint = this.mNodes[this.mNumNodes - 1].mPoint;
			}
			else
			{
				mPoint = this.mNodes[n1 - 1].mPoint;
			}
			a = (mPoint3 - mPoint) * 0.5f;
			if (n2 == this.mNumNodes - 1)
			{
				mPoint4 = this.mNodes[0].mPoint;
			}
			else
			{
				mPoint4 = this.mNodes[n2 + 1].mPoint;
			}
			a2 = (mPoint4 - mPoint2) * 0.5f;
		}
		else
		{
			if (n1 == 0)
			{
				mPoint = this.mNodes[n1].mPoint;
				a = (mPoint3 - mPoint2) * 0.5f;
			}
			else
			{
				mPoint = this.mNodes[n1 - 1].mPoint;
				a = (mPoint3 - mPoint) * 0.5f;
			}
			if (n2 == this.mNumNodes - 1)
			{
				mPoint4 = this.mNodes[n2].mPoint;
				a2 = (mPoint3 - mPoint2) * 0.5f;
			}
			else
			{
				mPoint4 = this.mNodes[n2 + 1].mPoint;
				a2 = (mPoint4 - mPoint2) * 0.5f;
			}
		}
		float num = t * t;
		float num2 = num * t;
		float d = num2 + num2 - num - num - num + 1f;
		float d2 = -num2 - num2 + num + num + num;
		float d3 = num2 - num - num + t;
		float d4 = num2 - num;
		return mPoint2 * d + mPoint3 * d2 + a * d3 + a2 * d4;
	}

	// Token: 0x06005D80 RID: 23936 RVA: 0x0003F823 File Offset: 0x0003DA23
	private Quaternion CalculateQuat(Quaternion q1, Quaternion q2, float t)
	{
		return Quaternion.Slerp(q1, q2, t);
	}

	// Token: 0x06005D81 RID: 23937 RVA: 0x0026FAF0 File Offset: 0x0026DCF0
	private Vector3 GetHeartPoint(Vector3 sp, Vector3 dp, Vector3 sdir0, float r)
	{
		Vector3 vector = dp - sp;
		Vector3 vector2 = sdir0;
		vector2.Normalize();
		vector.Normalize();
		float num = (Vector3.Dot(vector2, vector) + 1f) * 0.5f;
		num = 1f - num;
		num *= 0.7f;
		num += 0.3f;
		Vector3 vector3 = vector2 + vector;
		if (vector3.magnitude < 1E-05f)
		{
			vector3 = Vector3.Cross(vector, Vector3.up);
			vector3 *= 0.1f;
			vector3 = vector2 + vector3;
		}
		vector3.Normalize();
		vector3 *= r * num;
		return vector3 + sp;
	}

	// Token: 0x04005C71 RID: 23665
	public SplineNode[] mNodes;

	// Token: 0x04005C72 RID: 23666
	public int mNumNodes;

	// Token: 0x04005C73 RID: 23667
	public float mLinearLength;

	// Token: 0x04005C74 RID: 23668
	public bool mLooping;

	// Token: 0x04005C75 RID: 23669
	public bool mConstSpeed;

	// Token: 0x04005C76 RID: 23670
	public bool mAlignTangent;

	// Token: 0x04005C77 RID: 23671
	public bool mHasQ;

	// Token: 0x04005C78 RID: 23672
	public int mNumSample = 3000;
}
