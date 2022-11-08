﻿using System;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Metadata;
using System.Security;
using System.Security.Principal;
using System.Threading;

namespace System.Runtime.Remoting.Messaging
{
	// Token: 0x02000853 RID: 2131
	[Serializable]
	internal class StackBuilderSink : IMessageSink
	{
		// Token: 0x06005B4B RID: 23371 RVA: 0x0013F540 File Offset: 0x0013D740
		public StackBuilderSink(MarshalByRefObject server)
		{
			this._server = server;
		}

		// Token: 0x06005B4C RID: 23372 RVA: 0x0013F54F File Offset: 0x0013D74F
		public StackBuilderSink(object server)
		{
			this._server = server;
			if (this._server == null)
			{
				this._bStatic = true;
			}
		}

		// Token: 0x06005B4D RID: 23373 RVA: 0x0013F570 File Offset: 0x0013D770
		[SecurityCritical]
		public virtual IMessage SyncProcessMessage(IMessage msg)
		{
			IMessage message = InternalSink.ValidateMessage(msg);
			if (message != null)
			{
				return message;
			}
			IMethodCallMessage methodCallMessage = msg as IMethodCallMessage;
			LogicalCallContext logicalCallContext = null;
			LogicalCallContext logicalCallContext2 = Thread.CurrentThread.GetMutableExecutionContext().LogicalCallContext;
			object data = logicalCallContext2.GetData("__xADCall");
			bool flag = false;
			IMessage message2;
			try
			{
				object server = this._server;
				StackBuilderSink.VerifyIsOkToCallMethod(server, methodCallMessage);
				LogicalCallContext logicalCallContext3;
				if (methodCallMessage != null)
				{
					logicalCallContext3 = methodCallMessage.LogicalCallContext;
				}
				else
				{
					logicalCallContext3 = (LogicalCallContext)msg.Properties["__CallContext"];
				}
				logicalCallContext = CallContext.SetLogicalCallContext(logicalCallContext3);
				flag = true;
				logicalCallContext3.PropagateIncomingHeadersToCallContext(msg);
				StackBuilderSink.PreserveThreadPrincipalIfNecessary(logicalCallContext3, logicalCallContext);
				if (this.IsOKToStackBlt(methodCallMessage, server) && ((Message)methodCallMessage).Dispatch(server))
				{
					message2 = new StackBasedReturnMessage();
					((StackBasedReturnMessage)message2).InitFields((Message)methodCallMessage);
					LogicalCallContext logicalCallContext4 = Thread.CurrentThread.GetMutableExecutionContext().LogicalCallContext;
					logicalCallContext4.PropagateOutgoingHeadersToMessage(message2);
					((StackBasedReturnMessage)message2).SetLogicalCallContext(logicalCallContext4);
				}
				else
				{
					MethodBase methodBase = StackBuilderSink.GetMethodBase(methodCallMessage);
					object[] array = null;
					RemotingMethodCachedData reflectionCachedData = InternalRemotingServices.GetReflectionCachedData(methodBase);
					object[] args = Message.CoerceArgs(methodCallMessage, reflectionCachedData.Parameters);
					object ret = this.PrivateProcessMessage(methodBase.MethodHandle, args, server, out array);
					this.CopyNonByrefOutArgsFromOriginalArgs(reflectionCachedData, args, ref array);
					LogicalCallContext logicalCallContext5 = Thread.CurrentThread.GetMutableExecutionContext().LogicalCallContext;
					if (data != null && (bool)data && logicalCallContext5 != null)
					{
						logicalCallContext5.RemovePrincipalIfNotSerializable();
					}
					message2 = new ReturnMessage(ret, array, (array == null) ? 0 : array.Length, logicalCallContext5, methodCallMessage);
					logicalCallContext5.PropagateOutgoingHeadersToMessage(message2);
					CallContext.SetLogicalCallContext(logicalCallContext);
				}
			}
			catch (Exception e)
			{
				message2 = new ReturnMessage(e, methodCallMessage);
				((ReturnMessage)message2).SetLogicalCallContext(methodCallMessage.LogicalCallContext);
				if (flag)
				{
					CallContext.SetLogicalCallContext(logicalCallContext);
				}
			}
			return message2;
		}

		// Token: 0x06005B4E RID: 23374 RVA: 0x0013F744 File Offset: 0x0013D944
		[SecurityCritical]
		public virtual IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink)
		{
			IMethodCallMessage methodCallMessage = (IMethodCallMessage)msg;
			IMessageCtrl result = null;
			IMessage message = null;
			LogicalCallContext logicalCallContext = null;
			bool flag = false;
			try
			{
				try
				{
					LogicalCallContext logicalCallContext2 = (LogicalCallContext)methodCallMessage.Properties[Message.CallContextKey];
					object server = this._server;
					StackBuilderSink.VerifyIsOkToCallMethod(server, methodCallMessage);
					logicalCallContext = CallContext.SetLogicalCallContext(logicalCallContext2);
					flag = true;
					logicalCallContext2.PropagateIncomingHeadersToCallContext(msg);
					StackBuilderSink.PreserveThreadPrincipalIfNecessary(logicalCallContext2, logicalCallContext);
					ServerChannelSinkStack serverChannelSinkStack = msg.Properties["__SinkStack"] as ServerChannelSinkStack;
					if (serverChannelSinkStack != null)
					{
						serverChannelSinkStack.ServerObject = server;
					}
					MethodBase methodBase = StackBuilderSink.GetMethodBase(methodCallMessage);
					object[] array = null;
					RemotingMethodCachedData reflectionCachedData = InternalRemotingServices.GetReflectionCachedData(methodBase);
					object[] args = Message.CoerceArgs(methodCallMessage, reflectionCachedData.Parameters);
					object ret = this.PrivateProcessMessage(methodBase.MethodHandle, args, server, out array);
					this.CopyNonByrefOutArgsFromOriginalArgs(reflectionCachedData, args, ref array);
					if (replySink != null)
					{
						LogicalCallContext logicalCallContext3 = Thread.CurrentThread.GetMutableExecutionContext().LogicalCallContext;
						if (logicalCallContext3 != null)
						{
							logicalCallContext3.RemovePrincipalIfNotSerializable();
						}
						message = new ReturnMessage(ret, array, (array == null) ? 0 : array.Length, logicalCallContext3, methodCallMessage);
						logicalCallContext3.PropagateOutgoingHeadersToMessage(message);
					}
				}
				catch (Exception e)
				{
					if (replySink != null)
					{
						message = new ReturnMessage(e, methodCallMessage);
						((ReturnMessage)message).SetLogicalCallContext((LogicalCallContext)methodCallMessage.Properties[Message.CallContextKey]);
					}
				}
				finally
				{
					if (replySink != null)
					{
						replySink.SyncProcessMessage(message);
					}
				}
			}
			finally
			{
				if (flag)
				{
					CallContext.SetLogicalCallContext(logicalCallContext);
				}
			}
			return result;
		}

		// Token: 0x17000FC8 RID: 4040
		// (get) Token: 0x06005B4F RID: 23375 RVA: 0x0013F8E8 File Offset: 0x0013DAE8
		public IMessageSink NextSink
		{
			[SecurityCritical]
			get
			{
				return null;
			}
		}

		// Token: 0x06005B50 RID: 23376 RVA: 0x0013F8EC File Offset: 0x0013DAEC
		[SecurityCritical]
		internal bool IsOKToStackBlt(IMethodMessage mcMsg, object server)
		{
			bool result = false;
			Message message = mcMsg as Message;
			if (message != null)
			{
				IInternalMessage internalMessage = message;
				if (message.GetFramePtr() != IntPtr.Zero && message.GetThisPtr() == server && (internalMessage.IdentityObject == null || (internalMessage.IdentityObject != null && internalMessage.IdentityObject == internalMessage.ServerIdentityObject)))
				{
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06005B51 RID: 23377 RVA: 0x0013F944 File Offset: 0x0013DB44
		[SecurityCritical]
		private static MethodBase GetMethodBase(IMethodMessage msg)
		{
			MethodBase methodBase = msg.MethodBase;
			if (null == methodBase)
			{
				throw new RemotingException(string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("Remoting_Message_MethodMissing"), msg.MethodName, msg.TypeName));
			}
			return methodBase;
		}

		// Token: 0x06005B52 RID: 23378 RVA: 0x0013F988 File Offset: 0x0013DB88
		[SecurityCritical]
		private static void VerifyIsOkToCallMethod(object server, IMethodMessage msg)
		{
			bool flag = false;
			MarshalByRefObject marshalByRefObject = server as MarshalByRefObject;
			if (marshalByRefObject != null)
			{
				bool flag2;
				Identity identity = MarshalByRefObject.GetIdentity(marshalByRefObject, out flag2);
				if (identity != null)
				{
					ServerIdentity serverIdentity = identity as ServerIdentity;
					if (serverIdentity != null && serverIdentity.MarshaledAsSpecificType)
					{
						Type serverType = serverIdentity.ServerType;
						if (serverType != null)
						{
							MethodBase methodBase = StackBuilderSink.GetMethodBase(msg);
							RuntimeType runtimeType = (RuntimeType)methodBase.DeclaringType;
							if (runtimeType != serverType && !runtimeType.IsAssignableFrom(serverType))
							{
								throw new RemotingException(string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("Remoting_InvalidCallingType"), methodBase.DeclaringType.FullName, serverType.FullName));
							}
							if (runtimeType.IsInterface)
							{
								StackBuilderSink.VerifyNotIRemoteDispatch(runtimeType);
							}
							flag = true;
						}
					}
				}
				if (!flag)
				{
					MethodBase methodBase2 = StackBuilderSink.GetMethodBase(msg);
					RuntimeType runtimeType2 = (RuntimeType)methodBase2.ReflectedType;
					if (!runtimeType2.IsInterface)
					{
						if (!runtimeType2.IsInstanceOfType(marshalByRefObject))
						{
							throw new RemotingException(string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("Remoting_InvalidCallingType"), runtimeType2.FullName, marshalByRefObject.GetType().FullName));
						}
					}
					else
					{
						StackBuilderSink.VerifyNotIRemoteDispatch(runtimeType2);
					}
				}
			}
		}

		// Token: 0x06005B53 RID: 23379 RVA: 0x0013FAA8 File Offset: 0x0013DCA8
		[SecurityCritical]
		private static void VerifyNotIRemoteDispatch(RuntimeType reflectedType)
		{
			if (reflectedType.FullName.Equals(StackBuilderSink.sIRemoteDispatch) && reflectedType.GetRuntimeAssembly().GetSimpleName().Equals(StackBuilderSink.sIRemoteDispatchAssembly))
			{
				throw new RemotingException(Environment.GetResourceString("Remoting_CantInvokeIRemoteDispatch"));
			}
		}

		// Token: 0x06005B54 RID: 23380 RVA: 0x0013FAE4 File Offset: 0x0013DCE4
		internal void CopyNonByrefOutArgsFromOriginalArgs(RemotingMethodCachedData methodCache, object[] args, ref object[] marshalResponseArgs)
		{
			int[] nonRefOutArgMap = methodCache.NonRefOutArgMap;
			if (nonRefOutArgMap.Length != 0)
			{
				if (marshalResponseArgs == null)
				{
					marshalResponseArgs = new object[methodCache.Parameters.Length];
				}
				foreach (int num in nonRefOutArgMap)
				{
					marshalResponseArgs[num] = args[num];
				}
			}
		}

		// Token: 0x06005B55 RID: 23381 RVA: 0x0013FB2C File Offset: 0x0013DD2C
		[SecurityCritical]
		internal static void PreserveThreadPrincipalIfNecessary(LogicalCallContext messageCallContext, LogicalCallContext threadCallContext)
		{
			if (threadCallContext != null && messageCallContext.Principal == null)
			{
				IPrincipal principal = threadCallContext.Principal;
				if (principal != null)
				{
					messageCallContext.Principal = principal;
				}
			}
		}

		// Token: 0x17000FC9 RID: 4041
		// (get) Token: 0x06005B56 RID: 23382 RVA: 0x0013FB55 File Offset: 0x0013DD55
		internal object ServerObject
		{
			get
			{
				return this._server;
			}
		}

		// Token: 0x06005B57 RID: 23383
		[SecurityCritical]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern object _PrivateProcessMessage(IntPtr md, object[] args, object server, out object[] outArgs);

		// Token: 0x06005B58 RID: 23384 RVA: 0x0013FB5D File Offset: 0x0013DD5D
		[SecurityCritical]
		public object PrivateProcessMessage(RuntimeMethodHandle md, object[] args, object server, out object[] outArgs)
		{
			return this._PrivateProcessMessage(md.Value, args, server, out outArgs);
		}

		// Token: 0x04002908 RID: 10504
		private object _server;

		// Token: 0x04002909 RID: 10505
		private static string sIRemoteDispatch = "System.EnterpriseServices.IRemoteDispatch";

		// Token: 0x0400290A RID: 10506
		private static string sIRemoteDispatchAssembly = "System.EnterpriseServices";

		// Token: 0x0400290B RID: 10507
		private bool _bStatic;
	}
}
