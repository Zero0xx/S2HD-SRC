﻿using System;

namespace System.Deployment.Internal.Isolation.Manifest
{
	// Token: 0x0200068E RID: 1678
	internal enum CMS_ASSEMBLY_REFERENCE_FLAG
	{
		// Token: 0x040021EB RID: 8683
		CMS_ASSEMBLY_REFERENCE_FLAG_OPTIONAL = 1,
		// Token: 0x040021EC RID: 8684
		CMS_ASSEMBLY_REFERENCE_FLAG_VISIBLE,
		// Token: 0x040021ED RID: 8685
		CMS_ASSEMBLY_REFERENCE_FLAG_FOLLOW = 4,
		// Token: 0x040021EE RID: 8686
		CMS_ASSEMBLY_REFERENCE_FLAG_IS_PLATFORM = 8,
		// Token: 0x040021EF RID: 8687
		CMS_ASSEMBLY_REFERENCE_FLAG_CULTURE_WILDCARDED = 16,
		// Token: 0x040021F0 RID: 8688
		CMS_ASSEMBLY_REFERENCE_FLAG_PROCESSOR_ARCHITECTURE_WILDCARDED = 32,
		// Token: 0x040021F1 RID: 8689
		CMS_ASSEMBLY_REFERENCE_FLAG_PREREQUISITE = 128
	}
}
