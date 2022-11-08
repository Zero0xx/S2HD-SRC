﻿using System;

namespace System.Security.Principal
{
	// Token: 0x0200030F RID: 783
	[Flags]
	internal enum PolicyRights
	{
		// Token: 0x0400103A RID: 4154
		POLICY_VIEW_LOCAL_INFORMATION = 1,
		// Token: 0x0400103B RID: 4155
		POLICY_VIEW_AUDIT_INFORMATION = 2,
		// Token: 0x0400103C RID: 4156
		POLICY_GET_PRIVATE_INFORMATION = 4,
		// Token: 0x0400103D RID: 4157
		POLICY_TRUST_ADMIN = 8,
		// Token: 0x0400103E RID: 4158
		POLICY_CREATE_ACCOUNT = 16,
		// Token: 0x0400103F RID: 4159
		POLICY_CREATE_SECRET = 32,
		// Token: 0x04001040 RID: 4160
		POLICY_CREATE_PRIVILEGE = 64,
		// Token: 0x04001041 RID: 4161
		POLICY_SET_DEFAULT_QUOTA_LIMITS = 128,
		// Token: 0x04001042 RID: 4162
		POLICY_SET_AUDIT_REQUIREMENTS = 256,
		// Token: 0x04001043 RID: 4163
		POLICY_AUDIT_LOG_ADMIN = 512,
		// Token: 0x04001044 RID: 4164
		POLICY_SERVER_ADMIN = 1024,
		// Token: 0x04001045 RID: 4165
		POLICY_LOOKUP_NAMES = 2048,
		// Token: 0x04001046 RID: 4166
		POLICY_NOTIFICATION = 4096
	}
}
