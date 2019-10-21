using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Webtrekk.Webtrekksdk.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Utils']/class[@name='WebtrekkLogging']"
	[global::Android.Runtime.Register ("com/webtrekk/webtrekksdk/Utils/WebtrekkLogging", DoNotGenerateAcw=true)]
	public partial class WebtrekkLogging : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Utils']/class[@name='WebtrekkLogging']/field[@name='logTag']"
		[Register ("logTag")]
		public const string LogTag = (string) "WebtrekkSDK";
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/webtrekk/webtrekksdk/Utils/WebtrekkLogging", typeof (WebtrekkLogging));
		internal static new IntPtr class_ref {
			get {
				return _members.JniPeerType.PeerReference.Handle;
			}
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		protected WebtrekkLogging (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Utils']/class[@name='WebtrekkLogging']/constructor[@name='WebtrekkLogging' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe WebtrekkLogging ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		public static unsafe bool IsLogging {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Utils']/class[@name='WebtrekkLogging']/method[@name='isLogging' and count(parameter)=0]"
			[Register ("isLogging", "()Z", "GetIsLoggingHandler")]
			get {
				const string __id = "isLogging.()Z";
				try {
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Utils']/class[@name='WebtrekkLogging']/method[@name='setIsLogging' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setIsLogging", "(Z)V", "GetSetIsLogging_ZHandler")]
			set {
				const string __id = "setIsLogging.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.StaticMethods.InvokeVoidMethod (__id, __args);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Utils']/class[@name='WebtrekkLogging']/method[@name='log' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("log", "(Ljava/lang/String;)V", "")]
		public static unsafe void Log (string message)
		{
			const string __id = "log.(Ljava/lang/String;)V";
			IntPtr native_message = JNIEnv.NewString (message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_message);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Utils']/class[@name='WebtrekkLogging']/method[@name='log' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Throwable']]"
		[Register ("log", "(Ljava/lang/String;Ljava/lang/Throwable;)V", "")]
		public static unsafe void Log (string message, global::Java.Lang.Throwable t)
		{
			const string __id = "log.(Ljava/lang/String;Ljava/lang/Throwable;)V";
			IntPtr native_message = JNIEnv.NewString (message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_message);
				__args [1] = new JniArgumentValue ((t == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) t).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
			}
		}

	}
}
