using System;
using System.Security;

namespace System.IO.IsolatedStorage
{
	/// <summary>Provides settings for maintaining the quota size for isolated storage.</summary>
	// Token: 0x020001B3 RID: 435
	[SecurityCritical]
	public class IsolatedStorageSecurityState : SecurityState
	{
		// Token: 0x06001B51 RID: 6993 RVA: 0x0005C908 File Offset: 0x0005AB08
		internal static IsolatedStorageSecurityState CreateStateToIncreaseQuotaForApplication(long newQuota, long usedSize)
		{
			return new IsolatedStorageSecurityState
			{
				m_Options = IsolatedStorageSecurityOptions.IncreaseQuotaForApplication,
				m_Quota = newQuota,
				m_UsedSize = usedSize
			};
		}

		// Token: 0x06001B52 RID: 6994 RVA: 0x0005C931 File Offset: 0x0005AB31
		[SecurityCritical]
		private IsolatedStorageSecurityState()
		{
		}

		/// <summary>Gets the option for managing isolated storage security.</summary>
		/// <returns>The option to increase the isolated quota storage size.</returns>
		// Token: 0x17000317 RID: 791
		// (get) Token: 0x06001B53 RID: 6995 RVA: 0x0005C939 File Offset: 0x0005AB39
		public IsolatedStorageSecurityOptions Options
		{
			get
			{
				return this.m_Options;
			}
		}

		/// <summary>Gets the current usage size in isolated storage.</summary>
		/// <returns>The current usage size, in bytes.</returns>
		// Token: 0x17000318 RID: 792
		// (get) Token: 0x06001B54 RID: 6996 RVA: 0x0005C941 File Offset: 0x0005AB41
		public long UsedSize
		{
			get
			{
				return this.m_UsedSize;
			}
		}

		/// <summary>Gets or sets the current size of the quota for isolated storage.</summary>
		/// <returns>The current quota size, in bytes.</returns>
		// Token: 0x17000319 RID: 793
		// (get) Token: 0x06001B55 RID: 6997 RVA: 0x0005C949 File Offset: 0x0005AB49
		// (set) Token: 0x06001B56 RID: 6998 RVA: 0x0005C951 File Offset: 0x0005AB51
		public long Quota
		{
			get
			{
				return this.m_Quota;
			}
			set
			{
				this.m_Quota = value;
			}
		}

		/// <summary>Ensures that the state that is represented by <see cref="T:System.IO.IsolatedStorage.IsolatedStorageSecurityState" /> is available on the host.</summary>
		/// <exception cref="T:System.IO.IsolatedStorage.IsolatedStorageException">The state is not available.</exception>
		// Token: 0x06001B57 RID: 6999 RVA: 0x0005C95A File Offset: 0x0005AB5A
		[SecurityCritical]
		public override void EnsureState()
		{
			if (!base.IsStateAvailable())
			{
				throw new IsolatedStorageException(Environment.GetResourceString("IsolatedStorage_Operation"));
			}
		}

		// Token: 0x04000976 RID: 2422
		private long m_UsedSize;

		// Token: 0x04000977 RID: 2423
		private long m_Quota;

		// Token: 0x04000978 RID: 2424
		private IsolatedStorageSecurityOptions m_Options;
	}
}
