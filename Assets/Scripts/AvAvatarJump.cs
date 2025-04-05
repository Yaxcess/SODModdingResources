using System;

// Token: 0x02000558 RID: 1368
[Serializable]
public class AvAvatarJump
{
	// Token: 0x0400236A RID: 9066
	public string _JumpAnim;

	// Token: 0x0400236B RID: 9067
	public string _SuperJumpAnim;

	// Token: 0x0400236C RID: 9068
	public string _FallAnim;

	// Token: 0x0400236D RID: 9069
	public string _LandAnim;

	// Token: 0x0400236E RID: 9070
	public float _TimeSinceOnGround;

	// Token: 0x0400236F RID: 9071
	public float _MinJumpHeight;

	// Token: 0x04002370 RID: 9072
	public float _MaxJumpHeight;

	// Token: 0x04002371 RID: 9073
	public float _MaxJumpTime;

	// Token: 0x04002372 RID: 9074
	public JumpAnimData[] _SuperJumpAnimData;

	// Token: 0x04002373 RID: 9075
	public JumpAnimData[] _JumpAnimData;

	// Token: 0x04002374 RID: 9076
	public JumpAnimData[] _NoJumpAnimData;
}
