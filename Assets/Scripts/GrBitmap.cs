using System;
using System.Collections;
using System.IO;
using UnityEngine;

// Token: 0x020009E6 RID: 2534
[Serializable]
public class GrBitmap
{
	// Token: 0x06003A88 RID: 14984 RVA: 0x001ACCE0 File Offset: 0x001AAEE0
	public GrBitmap(string fileName, int w, int h, bool loadPix)
	{
		this._Texture = new Texture2D(w, h);
		this.LoadFromExtFile(fileName, loadPix);
	}

	// Token: 0x06003A89 RID: 14985 RVA: 0x001ACD44 File Offset: 0x001AAF44
	public GrBitmap(string bname, int w, int h, bool c, Color clearColor)
	{
		this._Name = bname;
		this._Width = w;
		this._Height = h;
		this._Colors = new Color[this._Width * this._Height];
		if (c)
		{
			this.Clear(clearColor);
		}
	}

	// Token: 0x06003A8A RID: 14986 RVA: 0x001ACDC8 File Offset: 0x001AAFC8
	public GrBitmap(Texture2D t)
	{
		this.ChangeTexture(t, true);
	}

	// Token: 0x06003A8B RID: 14987 RVA: 0x001ACE1C File Offset: 0x001AB01C
	public GrBitmap(Texture2D t, bool c, Color clearColor)
	{
		this.ChangeTexture(t, true);
		if (c)
		{
			this.Clear(clearColor);
			this.Apply();
		}
	}

	// Token: 0x06003A8C RID: 14988 RVA: 0x00028D0F File Offset: 0x00026F0F
	public void SetConstant(Color cc)
	{
		this.mConstant = cc;
	}

	// Token: 0x06003A8D RID: 14989 RVA: 0x00028D18 File Offset: 0x00026F18
	public void Apply()
	{
		this.Apply(false);
	}

	// Token: 0x06003A8E RID: 14990 RVA: 0x00028D21 File Offset: 0x00026F21
	public void Apply(bool t)
	{
		if (this._Texture != null)
		{
			this._Texture.SetPixels(this._Colors);
			this._Texture.Apply(t);
		}
	}

	// Token: 0x06003A8F RID: 14991 RVA: 0x00028D4E File Offset: 0x00026F4E
	public void SetBlendMode(BlendOp colorOp, BlendOp alphaOp, RepeatMode repeatMode)
	{
		this.mAlphaBlendMode = alphaOp;
		this.mColorBlendMode = colorOp;
		this.mRepeatMode = repeatMode;
	}

	// Token: 0x06003A90 RID: 14992 RVA: 0x00028D65 File Offset: 0x00026F65
	public Color GetPixel(int x, int y)
	{
		return this._Colors[x + y * this._Width];
	}

	// Token: 0x06003A91 RID: 14993 RVA: 0x00028D7C File Offset: 0x00026F7C
	public void SetPixel(int x, int y, Color c)
	{
		this._Colors[x + y * this._Width] = c;
	}

	// Token: 0x06003A92 RID: 14994 RVA: 0x00028D94 File Offset: 0x00026F94
	public void Clear(Color c)
	{
		this.ClearRect(c, new Rect(0f, 0f, (float)this._Width, (float)this._Height));
	}

	// Token: 0x06003A93 RID: 14995 RVA: 0x001ACE80 File Offset: 0x001AB080
	public void LoadPixels(GrBitmap bmp)
	{
		if (bmp._Texture != null)
		{
			this._Colors = bmp._Texture.GetPixels();
			return;
		}
		if (bmp._Colors != null)
		{
			int num = bmp._Colors.Length;
			this._Colors = new Color[num];
			for (int i = 0; i < num; i++)
			{
				this._Colors[i] = bmp._Colors[i];
			}
		}
	}

	// Token: 0x06003A94 RID: 14996 RVA: 0x001ACEF0 File Offset: 0x001AB0F0
	public void SaveToExtFile(string fileName)
	{
		byte[] buffer = this._Texture.EncodeToPNG();
		using (BinaryWriter binaryWriter = new BinaryWriter(File.OpenWrite(fileName)))
		{
			binaryWriter.Write(buffer);
			binaryWriter.Close();
		}
	}

	// Token: 0x06003A95 RID: 14997 RVA: 0x001ACF40 File Offset: 0x001AB140
	public void LoadFromExtFile(string fileName, bool loadPix)
	{
		using (BinaryReader binaryReader = new BinaryReader(File.OpenRead(fileName)))
		{
			byte[] data = binaryReader.ReadBytes((int)binaryReader.BaseStream.Length);
			binaryReader.Close();
			if (this._Texture.LoadImage(data))
			{
				this.ChangeTexture(this._Texture, loadPix);
			}
			this._Texture.name = fileName;
		}
	}

	// Token: 0x06003A96 RID: 14998 RVA: 0x00028DBA File Offset: 0x00026FBA
	public Texture2D GetTexture()
	{
		return this._Texture;
	}

	// Token: 0x06003A97 RID: 14999 RVA: 0x001ACFB8 File Offset: 0x001AB1B8
	public void ChangeTexture(Texture2D t, bool loadPix)
	{
		if (t == null)
		{
			Debug.LogError("!!!!!!!GrBitmap texture should not be null !!!");
			return;
		}
		this._Texture = t;
		this._Name = t.name;
		this._Width = t.width;
		this._Height = t.height;
		this._Colors = t.GetPixels();
		if (loadPix)
		{
			this.ReloadPixels();
		}
	}

	// Token: 0x06003A98 RID: 15000 RVA: 0x001AD01C File Offset: 0x001AB21C
	public void ChangeTextureCorrect(Texture2D t, bool loadPix)
	{
		if (t == null)
		{
			Debug.LogError("!!!!!!!GrBitmap texture should not be null !!!");
			return;
		}
		this._Texture = t;
		this._Name = t.name;
		this._Width = t.width;
		this._Height = t.height;
		if (loadPix)
		{
			this.ReloadPixels();
		}
	}

	// Token: 0x06003A99 RID: 15001 RVA: 0x00028DC2 File Offset: 0x00026FC2
	public void ReloadPixels()
	{
		if (this._Texture)
		{
			this._Colors = this._Texture.GetPixels();
		}
	}

	// Token: 0x06003A9A RID: 15002 RVA: 0x001AD074 File Offset: 0x001AB274
	public void ClearRect(Color c, Rect r)
	{
		int num = (int)(r.x + r.y * (float)this._Width);
		int num2 = 0;
		while ((float)num2 < r.height)
		{
			int num3 = num;
			int num4 = 0;
			while ((float)num4 < r.width)
			{
				this._Colors[num3] = c;
				num3++;
				num4++;
			}
			num += this._Width;
			num2++;
		}
	}

	// Token: 0x06003A9B RID: 15003 RVA: 0x00028DE2 File Offset: 0x00026FE2
	public void BlitTo(GrBitmap dst, int dx, int dy)
	{
		this.BlitTo(dst, new Rect(0f, 0f, (float)this._Width, (float)this._Height), new Rect((float)dx, (float)dy, (float)this._Width, (float)this._Height));
	}

	// Token: 0x06003A9C RID: 15004 RVA: 0x001AD0E0 File Offset: 0x001AB2E0
	public void BlitTo(GrBitmap dst, Rect srcRect, Rect dstRect)
	{
		int num = (int)srcRect.x;
		int num2 = (int)srcRect.y;
		int num3 = (int)srcRect.width;
		int num4 = (int)srcRect.height;
		int num5 = (int)dstRect.x;
		int num6 = (int)dstRect.y;
		int num7 = (int)dstRect.width;
		int num8 = (int)dstRect.height;
		if (num3 == 0)
		{
			num3 = this._Width;
		}
		if (num4 == 0)
		{
			num4 = this._Height;
		}
		if (num7 == 0)
		{
			num7 = num3;
		}
		if (num8 == 0)
		{
			num8 = num4;
		}
		if (num3 == num7 && num4 == num8)
		{
			if (this.ClipRectsFast(ref num, ref num2, ref num3, ref num4, this._Width, this._Height, ref num5, ref num6, dst._Width, dst._Height))
			{
				return;
			}
			num8 = num4;
			num7 = num3;
			int num9 = num + num2 * this._Width;
			int num10 = num5 + num6 * dst._Width;
			for (int i = 0; i < num8; i++)
			{
				int num11 = num9;
				int num12 = num10;
				for (int j = 0; j < num7; j++)
				{
					dst._Colors[num12] = this.BlendColors(this._Colors[num11], dst._Colors[num12]);
					num11++;
					num12++;
				}
				num9 += this._Width;
				num10 += dst._Width;
			}
			return;
		}
		else
		{
			if (this.mRepeatMode != RepeatMode.STAMP)
			{
				if (this.mRepeatMode == RepeatMode.REPEAT || this.mRepeatMode == RepeatMode.ALIGNEDREPEAT)
				{
					if (this.ClipRectsRepeat(ref num, ref num2, ref num3, ref num4, this._Width, this._Height, ref num5, ref num6, ref num7, ref num8, dst._Width, dst._Height))
					{
						return;
					}
					int num13 = 0;
					if (this.mRepeatMode == RepeatMode.ALIGNEDREPEAT)
					{
						num13 = num6 % num4;
					}
					int num14 = num6 * num7 + num5;
					for (int i = 0; i < num8; i++)
					{
						if (num13 >= num4)
						{
							num13 -= num4;
						}
						int num15 = num14;
						int num16;
						if (this.mRepeatMode == RepeatMode.ALIGNEDREPEAT)
						{
							num16 = num5 % num3;
						}
						else
						{
							num16 = 0;
						}
						for (int j = 0; j < num7; j++)
						{
							if (num16 >= num3)
							{
								num16 -= num3;
							}
							dst._Colors[num15] = this.BlendColors(this._Colors[num16 + num13 * num3], dst._Colors[num15]);
							num15++;
							num16++;
						}
						num14 += dst._Width;
						num13++;
					}
				}
				return;
			}
			if (this.ClipRectsStretch(ref num, ref num2, ref num3, ref num4, this._Width, this._Height, ref num5, ref num6, ref num7, ref num8, dst._Width, dst._Height))
			{
				return;
			}
			float num17 = (float)num3 / (float)num7;
			float num18 = (float)num4 / (float)num8;
			int num19 = num5 + num6 * dst._Width;
			float num20 = (float)num2;
			for (int i = 0; i < num8; i++)
			{
				float num21 = (float)((int)num20);
				if (num21 - (float)num2 >= (float)num4)
				{
					num21 = (float)(num2 + num4 - 1);
				}
				float num22 = (float)num + num21 * (float)this._Width;
				float num23 = num22;
				int num24 = num19;
				for (int j = 0; j < num7; j++)
				{
					if (num22 - num23 >= (float)num3)
					{
						num22 = num23 + (float)num3 - 1f;
					}
					dst._Colors[num24] = this.BlendColors(this._Colors[(int)num22], dst._Colors[num24]);
					num22 += num17;
					num24++;
				}
				num20 += num18;
				num19 += dst._Width;
			}
			return;
		}
	}

	// Token: 0x06003A9D RID: 15005 RVA: 0x00028E1F File Offset: 0x0002701F
	public void FlipUpDown()
	{
		this.FlipUpDown(new Rect(0f, 0f, 0f, 0f));
	}

	// Token: 0x06003A9E RID: 15006 RVA: 0x001AD46C File Offset: 0x001AB66C
	public void FlipUpDown(Rect fRect)
	{
		int num = (int)fRect.x;
		int num2 = (int)fRect.y;
		int num3 = (int)fRect.width;
		int num4 = (int)fRect.height;
		if (num3 == 0)
		{
			num3 = this._Width;
		}
		if (num4 == 0)
		{
			num4 = this._Height;
		}
		if (num + num3 > this._Width || num2 + num4 > this._Height)
		{
			Debug.LogError("Bitmap Flip out of range ");
			return;
		}
		Color[] array = new Color[this._Width * this._Height];
		int num5 = num + num2 * this._Width;
		int num6 = num5 + (num4 - 1) * this._Width;
		for (int i = 0; i < num4; i++)
		{
			int num7 = num5;
			int num8 = num6;
			for (int j = 0; j < num3; j++)
			{
				array[num8] = this._Colors[num7];
				num7++;
				num8++;
			}
			num5 += this._Width;
			num6 -= this._Width;
		}
		this._Colors = array;
	}

	// Token: 0x06003A9F RID: 15007 RVA: 0x001AD578 File Offset: 0x001AB778
	public Color BlendColors(Color src, Color dst)
	{
		Color color = new Color(src.r, src.g, src.b, src.a);
		switch (this.mAlphaBlendMode)
		{
		case BlendOp.NONE:
			color.a = dst.a;
			break;
		case BlendOp.REPLACE:
			color.a = src.a;
			break;
		case BlendOp.ADD:
			color.a = src.a + dst.a;
			if (color.a > 1f)
			{
				color.a = 1f;
			}
			break;
		case BlendOp.MULTIPLY:
			color.a = src.a * dst.a;
			break;
		case BlendOp.FROMCONSTANT:
			color.a = this.mConstant.a;
			break;
		case BlendOp.INVERSE:
			color.a = 1f - src.a;
			break;
		case BlendOp.FROMCOLOR:
			color.a = (src.r + src.g + src.b) * 0.333333f;
			break;
		case BlendOp.FROMCOLORINVERSE:
			color.a = 1f - (src.r + src.g + src.b) * 0.333333f;
			break;
		}
		switch (this.mColorBlendMode)
		{
		case BlendOp.NONE:
			color.r = dst.r;
			color.g = dst.g;
			color.b = dst.b;
			break;
		case BlendOp.REPLACE:
			color.r = src.r;
			color.g = src.g;
			color.b = src.b;
			break;
		case BlendOp.ADD:
			color.r = src.r + dst.r;
			if (color.r > 1f)
			{
				color.r = 1f;
			}
			color.g = src.g + dst.g;
			if (color.g > 1f)
			{
				color.g = 1f;
			}
			color.b = src.b + dst.b;
			if (color.b > 1f)
			{
				color.b = 1f;
			}
			break;
		case BlendOp.MULTIPLY:
			color.r = src.r * dst.r;
			color.g = src.g * dst.g;
			color.b = src.b * dst.b;
			break;
		case BlendOp.FROMCONSTANT:
			color.r = this.mConstant.r;
			color.g = this.mConstant.g;
			color.b = this.mConstant.b;
			break;
		case BlendOp.INVERSE:
			color.r = 1f - src.r;
			color.g = 1f - src.g;
			color.b = 1f - src.b;
			break;
		case BlendOp.FROMALPHA:
			color.r = src.a;
			color.g = src.a;
			color.b = src.a;
			break;
		case BlendOp.USEALPHA:
			color.r = src.r * src.a + dst.r * (1f - src.a);
			color.g = src.g * src.a + dst.g * (1f - src.a);
			color.b = src.b * src.a + dst.b * (1f - src.a);
			break;
		case BlendOp.OVERLAY:
		{
			float num = (dst.r + dst.g + dst.b) * 0.33333f;
			if (num > 0.5f)
			{
				color.r = 1f - (1f - dst.r) * (1f - src.r);
				color.g = 1f - (1f - dst.g) * (1f - src.g);
				color.b = 1f - (1f - dst.b) * (1f - src.b);
				if (num < 0.66f)
				{
					float num2 = (num - 0.5f) / 0.16f;
					float num3 = 1f - num2;
					color.r = dst.r * num3 + color.r * num2;
					color.g = dst.g * num3 + color.g * num2;
					color.b = dst.b * num3 + color.b * num2;
				}
			}
			else
			{
				color = dst;
			}
			break;
		}
		}
		return color;
	}

	// Token: 0x06003AA0 RID: 15008 RVA: 0x001ADA50 File Offset: 0x001ABC50
	private bool IsBorder(int[] mask, GrBitmap outline, int x, int y, int w, Rect boundingRect)
	{
		return (boundingRect.width > 0f && !boundingRect.Contains(new Vector2((float)x, (float)y))) || mask[x + y * w] > 0 || outline.GetPixel(x, y).r < 0.01f;
	}

	// Token: 0x06003AA1 RID: 15009 RVA: 0x001ADAA8 File Offset: 0x001ABCA8
	public void FloodFill(GrBitmap source, GrBitmap outline, int x, int y, Rect boundingRect)
	{
		Vector2 vector = new Vector2((float)x, (float)y);
		int num = this._Width * this._Height;
		int[] array = new int[num];
		for (int i = 0; i < num; i++)
		{
			array[i] = 0;
		}
		Stack stack = new Stack();
		stack.Push(vector);
		while (stack.Count > 0)
		{
			vector = (Vector2)stack.Pop();
			int num2 = (int)vector.x;
			int num3 = (int)vector.y;
			while (num3 >= 0 && !this.IsBorder(array, outline, num2, num3, this._Width, boundingRect))
			{
				num3--;
			}
			num3++;
			bool flag2;
			bool flag = flag2 = false;
			while (num3 < this._Height && !this.IsBorder(array, outline, num2, num3, this._Width, boundingRect))
			{
				array[num2 + num3 * this._Width] = 1;
				if (!flag2 && vector.x > 0f && !this.IsBorder(array, outline, num2 - 1, num3, this._Width, boundingRect))
				{
					stack.Push(new Vector2((float)(num2 - 1), (float)num3));
					flag2 = true;
				}
				else if (flag2 && (vector.x > 0f || this.IsBorder(array, outline, num2 - 1, num3, this._Width, boundingRect)))
				{
					flag2 = false;
				}
				if (!flag && vector.x < (float)(this._Width - 1) && !this.IsBorder(array, outline, num2 + 1, num3, this._Width, boundingRect))
				{
					stack.Push(new Vector2((float)(num2 + 1), (float)num3));
					flag = true;
				}
				else if (flag && (num2 < this._Width - 1 || this.IsBorder(array, outline, num2 + 1, num3, this._Width, boundingRect)))
				{
					flag = false;
				}
				num3++;
			}
		}
		int width = source._Width;
		int height = source._Height;
		for (int i = 0; i < this._Height; i++)
		{
			for (int j = 0; j < this._Width; j++)
			{
				if (array[i * this._Width + j] == 1)
				{
					this.SetPixel(j, i, source.GetPixel(j % width, i % height));
				}
			}
		}
		this.Apply();
	}

	// Token: 0x06003AA2 RID: 15010 RVA: 0x001ADCFC File Offset: 0x001ABEFC
	private bool ClipRectsFast(ref int xs, ref int ys, ref int w, ref int h, int wsrc, int hsrc, ref int xd, ref int yd, int wdes, int hdes)
	{
		float num = (float)xd;
		float num2 = (float)yd;
		float num3 = (float)xs;
		float num4 = (float)ys;
		float num5 = (float)w;
		float num6 = (float)h;
		if (num3 > (float)wsrc || num4 > (float)hsrc)
		{
			return true;
		}
		if (num3 + num5 < 0f || num4 + num6 < 0f)
		{
			return true;
		}
		if (num > (float)wdes || num2 > (float)hdes)
		{
			return true;
		}
		if (num + num5 < 0f || num2 + num6 < 0f)
		{
			return true;
		}
		if (num3 < 0f)
		{
			num -= num3;
			num5 += num3;
			num3 = 0f;
		}
		if (num4 < 0f)
		{
			num2 -= num4;
			num6 += num4;
			num4 = 0f;
		}
		if (num3 + num5 > (float)wsrc)
		{
			num5 -= num3 + num5 - (float)wsrc;
		}
		if (num4 + num6 > (float)hsrc)
		{
			num6 -= num4 + num6 - (float)hsrc;
		}
		if (num + num5 > (float)wdes)
		{
			num5 -= num + num5 - (float)wdes;
		}
		if (num2 + num6 > (float)hdes)
		{
			num6 -= num2 + num6 - (float)hdes;
		}
		if (num < 0f)
		{
			num3 -= num;
			num5 += num;
			num = 0f;
		}
		if (num2 < 0f)
		{
			num4 -= num2;
			num6 += num2;
			num2 = 0f;
		}
		xd = (int)num;
		yd = (int)num2;
		xs = (int)num3;
		ys = (int)num4;
		w = (int)num5;
		h = (int)num6;
		return false;
	}

	// Token: 0x06003AA3 RID: 15011 RVA: 0x001ADE40 File Offset: 0x001AC040
	private bool ClipRectsStretch(ref int xs, ref int ys, ref int ws, ref int hs, int wsrc, int hsrc, ref int xd, ref int yd, ref int wd, ref int hd, int wdes, int hdes)
	{
		float num = (float)xd;
		float num2 = (float)yd;
		float num3 = (float)xs;
		float num4 = (float)ys;
		float num5 = (float)ws;
		float num6 = (float)hs;
		float num7 = (float)wd;
		float num8 = (float)hd;
		float num9 = num7 / num5;
		float num10 = num8 / num6;
		if (num3 >= (float)wsrc || num4 >= (float)hsrc)
		{
			return true;
		}
		if (num3 + num5 <= 0f || num4 + num6 <= 0f)
		{
			return true;
		}
		if (num >= (float)wdes || num2 >= (float)hdes)
		{
			return true;
		}
		if (num + num7 <= 0f || num2 + num8 <= 0f)
		{
			return true;
		}
		if (num3 < 0f)
		{
			num5 += num3;
			num -= num3 * num9;
			num7 += num3 * num9;
			num3 = 0f;
		}
		if (num4 < 0f)
		{
			num6 += num4;
			num2 -= num4 * num10;
			num8 += num4 * num10;
			num4 = 0f;
		}
		if (num3 + num5 > (float)wsrc)
		{
			float num11 = num3 + num5 - (float)wsrc;
			num5 -= num11;
			num7 -= num11 * num9;
		}
		if (num4 + num6 > (float)hsrc)
		{
			float num12 = num4 + num6 - (float)hsrc;
			num6 -= num12;
			num8 -= num12 * num10;
		}
		if (num + num7 > (float)wdes)
		{
			num5 -= (num + num7 - (float)wdes) / num9;
			num7 -= num + num7 - (float)wdes;
		}
		if (num2 + num8 > (float)hdes)
		{
			num6 -= (num2 + num8 - (float)hdes) / num10;
			num8 -= num2 + num8 - (float)hdes;
		}
		if (num < 0f)
		{
			num3 += -num / num9;
			num5 -= -num / num9;
			num7 -= -num;
			num = 0f;
		}
		if (num2 < 0f)
		{
			num4 += -num2 / num10;
			num6 -= -num2 / num10;
			num8 -= -num2;
			num2 = 0f;
		}
		xd = (int)num;
		yd = (int)num2;
		xs = (int)num3;
		ys = (int)num4;
		ws = (int)num5;
		hs = (int)num6;
		wd = (int)num7;
		hd = (int)num8;
		return false;
	}

	// Token: 0x06003AA4 RID: 15012 RVA: 0x001AE024 File Offset: 0x001AC224
	private bool ClipRectsRepeat(ref int xs, ref int ys, ref int ws, ref int hs, int wsrc, int hsrc, ref int xd, ref int yd, ref int wd, ref int hd, int wdes, int hdes)
	{
		float num = (float)xd;
		float num2 = (float)yd;
		float num3 = (float)xs;
		float num4 = (float)ys;
		float num5 = (float)wd;
		float num6 = (float)hd;
		float num7 = (float)ws;
		float num8 = (float)hs;
		if (num >= (float)wdes || num2 >= (float)hdes)
		{
			return true;
		}
		if (num + num5 <= 0f || num2 + num6 <= 0f)
		{
			return true;
		}
		if (num3 >= (float)wsrc || num4 >= (float)hsrc)
		{
			return true;
		}
		if (num3 + num7 <= 0f || num4 + num8 <= 0f)
		{
			return true;
		}
		if (num3 < 0f)
		{
			num3 = 0f;
		}
		if (num4 < 0f)
		{
			num4 = 0f;
		}
		if (num + num5 > (float)wdes)
		{
			num5 -= num + num5 - (float)wdes;
		}
		if (num2 + num6 > (float)hdes)
		{
			num6 -= num2 + num6 - (float)hdes;
		}
		if (num < 0f)
		{
			num5 += num;
			num = 0f;
		}
		if (num2 < 0f)
		{
			num6 += num2;
			num2 = 0f;
		}
		xd = (int)num;
		yd = (int)num2;
		xs = (int)num3;
		ys = (int)num4;
		ws = (int)num7;
		hs = (int)num8;
		wd = (int)num5;
		hd = (int)num6;
		return false;
	}

	// Token: 0x04003C43 RID: 15427
	public Texture2D _Texture;

	// Token: 0x04003C44 RID: 15428
	public string _Name = "";

	// Token: 0x04003C45 RID: 15429
	public int _Width;

	// Token: 0x04003C46 RID: 15430
	public int _Height;

	// Token: 0x04003C47 RID: 15431
	public Color[] _Colors;

	// Token: 0x04003C48 RID: 15432
	private BlendOp mAlphaBlendMode = BlendOp.REPLACE;

	// Token: 0x04003C49 RID: 15433
	private BlendOp mColorBlendMode = BlendOp.REPLACE;

	// Token: 0x04003C4A RID: 15434
	private RepeatMode mRepeatMode;

	// Token: 0x04003C4B RID: 15435
	private Color mConstant = new Color(1f, 1f, 1f, 1f);
}
