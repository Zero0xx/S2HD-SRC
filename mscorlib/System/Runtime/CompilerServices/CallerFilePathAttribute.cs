using System;

namespace System.Runtime.CompilerServices
{
	/// <summary>Allows you to obtain the full path of the source file that contains the caller. This is the file path at the time of compile.</summary>
	// Token: 0x020008BA RID: 2234
	[AttributeUsage(AttributeTargets.Parameter, Inherited = false)]
	[__DynamicallyInvokable]
	public sealed class CallerFilePathAttribute : Attribute
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Runtime.CompilerServices.CallerFilePathAttribute" /> class.</summary>
		// Token: 0x06005CE4 RID: 23780 RVA: 0x00145A7D File Offset: 0x00143C7D
		[__DynamicallyInvokable]
		public CallerFilePathAttribute()
		{
		}
	}
}
