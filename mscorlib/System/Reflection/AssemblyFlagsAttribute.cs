using System;
using System.Runtime.InteropServices;

namespace System.Reflection
{
	/// <summary>Specifies a bitwise combination of <see cref="T:System.Reflection.AssemblyNameFlags" /> flags for an assembly, describing just-in-time (JIT) compiler options, whether the assembly is retargetable, and whether it has a full or tokenized public key. This class cannot be inherited.</summary>
	// Token: 0x02000596 RID: 1430
	[AttributeUsage(AttributeTargets.Assembly, Inherited = false)]
	[ComVisible(true)]
	[__DynamicallyInvokable]
	public sealed class AssemblyFlagsAttribute : Attribute
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Reflection.AssemblyFlagsAttribute" /> class with the specified combination of <see cref="T:System.Reflection.AssemblyNameFlags" /> flags, cast as an unsigned integer value.</summary>
		/// <param name="flags">A bitwise combination of <see cref="T:System.Reflection.AssemblyNameFlags" /> flags, cast as an unsigned integer value, representing just-in-time (JIT) compiler options, longevity, whether an assembly is retargetable, and whether it has a full or tokenized public key.</param>
		// Token: 0x06004351 RID: 17233 RVA: 0x000F7ADF File Offset: 0x000F5CDF
		[Obsolete("This constructor has been deprecated. Please use AssemblyFlagsAttribute(AssemblyNameFlags) instead. http://go.microsoft.com/fwlink/?linkid=14202")]
		[CLSCompliant(false)]
		public AssemblyFlagsAttribute(uint flags)
		{
			this.m_flags = (AssemblyNameFlags)flags;
		}

		/// <summary>Gets an unsigned integer value representing the combination of <see cref="T:System.Reflection.AssemblyNameFlags" /> flags specified when this attribute instance was created.</summary>
		/// <returns>An unsigned integer value representing a bitwise combination of <see cref="T:System.Reflection.AssemblyNameFlags" /> flags.</returns>
		// Token: 0x17000A07 RID: 2567
		// (get) Token: 0x06004352 RID: 17234 RVA: 0x000F7AEE File Offset: 0x000F5CEE
		[Obsolete("This property has been deprecated. Please use AssemblyFlags instead. http://go.microsoft.com/fwlink/?linkid=14202")]
		[CLSCompliant(false)]
		public uint Flags
		{
			get
			{
				return (uint)this.m_flags;
			}
		}

		/// <summary>Gets an integer value representing the combination of <see cref="T:System.Reflection.AssemblyNameFlags" /> flags specified when this attribute instance was created.</summary>
		/// <returns>An integer value representing a bitwise combination of <see cref="T:System.Reflection.AssemblyNameFlags" /> flags.</returns>
		// Token: 0x17000A08 RID: 2568
		// (get) Token: 0x06004353 RID: 17235 RVA: 0x000F7AF6 File Offset: 0x000F5CF6
		[__DynamicallyInvokable]
		public int AssemblyFlags
		{
			[__DynamicallyInvokable]
			get
			{
				return (int)this.m_flags;
			}
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Reflection.AssemblyFlagsAttribute" /> class with the specified combination of <see cref="T:System.Reflection.AssemblyNameFlags" /> flags, cast as an integer value.</summary>
		/// <param name="assemblyFlags">A bitwise combination of <see cref="T:System.Reflection.AssemblyNameFlags" /> flags, cast as an integer value, representing just-in-time (JIT) compiler options, longevity, whether an assembly is retargetable, and whether it has a full or tokenized public key.</param>
		// Token: 0x06004354 RID: 17236 RVA: 0x000F7AFE File Offset: 0x000F5CFE
		[Obsolete("This constructor has been deprecated. Please use AssemblyFlagsAttribute(AssemblyNameFlags) instead. http://go.microsoft.com/fwlink/?linkid=14202")]
		public AssemblyFlagsAttribute(int assemblyFlags)
		{
			this.m_flags = (AssemblyNameFlags)assemblyFlags;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Reflection.AssemblyFlagsAttribute" /> class with the specified combination of <see cref="T:System.Reflection.AssemblyNameFlags" /> flags.</summary>
		/// <param name="assemblyFlags">A bitwise combination of <see cref="T:System.Reflection.AssemblyNameFlags" /> flags representing just-in-time (JIT) compiler options, longevity, whether an assembly is retargetable, and whether it has a full or tokenized public key.</param>
		// Token: 0x06004355 RID: 17237 RVA: 0x000F7B0D File Offset: 0x000F5D0D
		[__DynamicallyInvokable]
		public AssemblyFlagsAttribute(AssemblyNameFlags assemblyFlags)
		{
			this.m_flags = assemblyFlags;
		}

		// Token: 0x04001B51 RID: 6993
		private AssemblyNameFlags m_flags;
	}
}
