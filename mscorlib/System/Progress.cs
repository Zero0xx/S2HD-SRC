using System;
using System.Threading;

namespace System
{
	/// <summary>Provides an <see cref="T:System.IProgress`1" /> that invokes callbacks for each reported progress value.</summary>
	/// <typeparam name="T">Specifies the type of the progress report value.</typeparam>
	// Token: 0x02000124 RID: 292
	[__DynamicallyInvokable]
	public class Progress<T> : IProgress<T>
	{
		/// <summary>Initializes the <see cref="T:System.Progress`1" /> object.</summary>
		// Token: 0x060010EF RID: 4335 RVA: 0x00032E5D File Offset: 0x0003105D
		[__DynamicallyInvokable]
		public Progress()
		{
			this.m_synchronizationContext = (SynchronizationContext.CurrentNoFlow ?? ProgressStatics.DefaultContext);
			this.m_invokeHandlers = new SendOrPostCallback(this.InvokeHandlers);
		}

		/// <summary>Initializes the <see cref="T:System.Progress`1" /> object with the specified callback.</summary>
		/// <param name="handler">A handler to invoke for each reported progress value. This handler will be invoked in addition to any delegates registered with the <see cref="E:System.Progress`1.ProgressChanged" /> event. Depending on the <see cref="T:System.Threading.SynchronizationContext" /> instance captured by the <see cref="T:System.Progress`1" /> at construction, it is possible that this handler instance could be invoked concurrently with itself.</param>
		// Token: 0x060010F0 RID: 4336 RVA: 0x00032E8B File Offset: 0x0003108B
		[__DynamicallyInvokable]
		public Progress(Action<T> handler) : this()
		{
			if (handler == null)
			{
				throw new ArgumentNullException("handler");
			}
			this.m_handler = handler;
		}

		/// <summary>Raised for each reported progress value.</summary>
		// Token: 0x14000013 RID: 19
		// (add) Token: 0x060010F1 RID: 4337 RVA: 0x00032EA8 File Offset: 0x000310A8
		// (remove) Token: 0x060010F2 RID: 4338 RVA: 0x00032EE0 File Offset: 0x000310E0
		[__DynamicallyInvokable]
		[method: __DynamicallyInvokable]
		public event EventHandler<T> ProgressChanged;

		/// <summary>Reports a progress change.</summary>
		/// <param name="value">The value of the updated progress.</param>
		// Token: 0x060010F3 RID: 4339 RVA: 0x00032F18 File Offset: 0x00031118
		[__DynamicallyInvokable]
		protected virtual void OnReport(T value)
		{
			Action<T> handler = this.m_handler;
			EventHandler<T> progressChanged = this.ProgressChanged;
			if (handler != null || progressChanged != null)
			{
				this.m_synchronizationContext.Post(this.m_invokeHandlers, value);
			}
		}

		// Token: 0x060010F4 RID: 4340 RVA: 0x00032F50 File Offset: 0x00031150
		[__DynamicallyInvokable]
		void IProgress<!0>.Report(T value)
		{
			this.OnReport(value);
		}

		// Token: 0x060010F5 RID: 4341 RVA: 0x00032F5C File Offset: 0x0003115C
		private void InvokeHandlers(object state)
		{
			T t = (T)((object)state);
			Action<T> handler = this.m_handler;
			EventHandler<T> progressChanged = this.ProgressChanged;
			if (handler != null)
			{
				handler(t);
			}
			if (progressChanged != null)
			{
				progressChanged(this, t);
			}
		}

		// Token: 0x040005EB RID: 1515
		private readonly SynchronizationContext m_synchronizationContext;

		// Token: 0x040005EC RID: 1516
		private readonly Action<T> m_handler;

		// Token: 0x040005ED RID: 1517
		private readonly SendOrPostCallback m_invokeHandlers;
	}
}
