using System;
using System.Runtime.InteropServices;

namespace System.Diagnostics.SymbolStore
{
	/// <summary>Holds the public GUIDs for language vendors to be used with the symbol store.</summary>
	// Token: 0x020003DB RID: 987
	[ComVisible(true)]
	public class SymLanguageVendor
	{
		/// <summary>Specifies the GUID of the Microsoft language vendor.</summary>
		// Token: 0x0400164A RID: 5706
		public static readonly Guid Microsoft = new Guid(-1723120188, -6423, 4562, 144, 63, 0, 192, 79, 163, 2, 161);
	}
}
