using System;
using UnityEngine;

namespace JSGames.Tween
{
	// Token: 0x02001AFF RID: 6911
	public abstract class Tweener
	{
		// Token: 0x14000255 RID: 597
		// (add) Token: 0x0600A2E9 RID: 41705 RVA: 0x00396870 File Offset: 0x00394A70
		// (remove) Token: 0x0600A2EA RID: 41706 RVA: 0x003968A4 File Offset: 0x00394AA4
		public static event Tweener.AnimationCompleteEvent pOnAnimationCompleted;

		// Token: 0x17001092 RID: 4242
		// (get) Token: 0x0600A2EB RID: 41707 RVA: 0x00065858 File Offset: 0x00063A58
		// (set) Token: 0x0600A2EC RID: 41708 RVA: 0x00065860 File Offset: 0x00063A60
		public GameObject pTweenObject { get; protected set; }

		// Token: 0x17001093 RID: 4243
		// (get) Token: 0x0600A2ED RID: 41709 RVA: 0x00065869 File Offset: 0x00063A69
		// (set) Token: 0x0600A2EE RID: 41710 RVA: 0x00065871 File Offset: 0x00063A71
		public TweenState pState { get; set; }

		// Token: 0x0600A2EF RID: 41711 RVA: 0x003968D8 File Offset: 0x00394AD8
		public void DoUpdate()
		{
			if (this.pTweenObject == null)
			{
				Tweener.pOnAnimationCompleted(this);
				return;
			}
			if (this.pState == TweenState.PAUSE || this.pState == TweenState.DONE)
			{
				return;
			}
			if (this.mDelayCounter < this.mDelay)
			{
				this.mDelayCounter += Time.deltaTime;
				return;
			}
			this.mValue = Mathf.MoveTowards(this.mValue, 1f, Time.deltaTime * this.mDeltaMove);
			float val = this.mValue;
			if (this.mUseAnimationCurve && this.mAnimationCurve != null)
			{
				val = this.mAnimationCurve.Evaluate(this.mValue);
			}
			else if (this.mCustomAnimationCurve != null)
			{
				val = this.mCustomAnimationCurve(0f, 1f, this.mValue);
			}
			if (!this.mDoInReverese)
			{
				this.DoAnim(val);
			}
			else
			{
				this.DoAnimReverse(val);
			}
			if (this.mValue >= 1f)
			{
				this.mDoInReverese = (this.mPingPong ? (!this.mDoInReverese) : this.mDoInReverese);
				this.mCompletedLoopCount++;
				if (this.mCompletedLoopCount == (this.mPingPong ? ((this.mLoopCount != 1) ? (2 * this.mLoopCount) : 2) : this.mLoopCount))
				{
					this.pState = TweenState.DONE;
					Tweener.pOnAnimationCompleted(this);
					if (this.pOnAnimationCompleteCallback != null)
					{
						this.pOnAnimationCompleteCallback(null);
					}
				}
				this.mValue = 0f;
			}
		}

		// Token: 0x0600A2F0 RID: 41712 RVA: 0x00396A58 File Offset: 0x00394C58
		public void SetData(float deltaMove, float delay, int loopCount, bool pingPong, bool useAnimationCurve, AnimationCurve animationCurve, CustomCurve customAnimationCurve, OnAnimationCompleteCallback onAnimationCompleteCallback)
		{
			this.mDeltaMove = deltaMove;
			this.mDelay = delay;
			this.mLoopCount = ((loopCount == 0) ? 1 : loopCount);
			this.mPingPong = pingPong;
			this.mAnimationCurve = animationCurve;
			this.mCustomAnimationCurve = customAnimationCurve;
			this.pState = TweenState.RUNNING;
			useAnimationCurve = this.mUseAnimationCurve;
			this.pOnAnimationCompleteCallback = onAnimationCompleteCallback;
		}

		// Token: 0x0600A2F1 RID: 41713 RVA: 0x0006587A File Offset: 0x00063A7A
		protected float CustomLerp(float start, float end, float value)
		{
			return (1f - value) * start + value * end;
		}

		// Token: 0x0600A2F2 RID: 41714 RVA: 0x00065889 File Offset: 0x00063A89
		protected Vector2 CustomLerp(Vector2 start, Vector2 end, float value)
		{
			return new Vector2(this.CustomLerp(start.x, end.x, value), this.CustomLerp(start.y, end.y, value));
		}

		// Token: 0x0600A2F3 RID: 41715 RVA: 0x000658B6 File Offset: 0x00063AB6
		protected Vector3 CustomLerp(Vector3 start, Vector3 end, float value)
		{
			return new Vector3(this.CustomLerp(start.x, end.x, value), this.CustomLerp(start.y, end.y, value), this.CustomLerp(start.z, end.z, value));
		}

		// Token: 0x0600A2F4 RID: 41716 RVA: 0x00396AB0 File Offset: 0x00394CB0
		protected Vector4 CustomLerp(Vector4 start, Vector4 end, float value)
		{
			return new Vector4(this.CustomLerp(start.x, end.x, value), this.CustomLerp(start.y, end.y, value), this.CustomLerp(start.z, end.z, value), this.CustomLerp(start.w, end.w, value));
		}

		// Token: 0x0600A2F5 RID: 41717
		protected abstract void DoAnim(float val);

		// Token: 0x0600A2F6 RID: 41718
		protected abstract void DoAnimReverse(float val);

		// Token: 0x0400A6EF RID: 42735
		private OnAnimationCompleteCallback pOnAnimationCompleteCallback;

		// Token: 0x0400A6F2 RID: 42738
		protected float mValue;

		// Token: 0x0400A6F3 RID: 42739
		private AnimationCurve mAnimationCurve;

		// Token: 0x0400A6F4 RID: 42740
		private CustomCurve mCustomAnimationCurve;

		// Token: 0x0400A6F5 RID: 42741
		private int mLoopCount = 1;

		// Token: 0x0400A6F6 RID: 42742
		private int mCompletedLoopCount;

		// Token: 0x0400A6F7 RID: 42743
		private float mDeltaMove;

		// Token: 0x0400A6F8 RID: 42744
		private float mDelay;

		// Token: 0x0400A6F9 RID: 42745
		private float mDelayCounter;

		// Token: 0x0400A6FA RID: 42746
		private bool mPingPong;

		// Token: 0x0400A6FB RID: 42747
		private bool mDoInReverese;

		// Token: 0x0400A6FC RID: 42748
		private bool mUseAnimationCurve;

		// Token: 0x02001B00 RID: 6912
		// (Invoke) Token: 0x0600A2F9 RID: 41721
		public delegate void AnimationCompleteEvent(Tweener tweener);
	}
}
