using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Webtrekk.Webtrekksdk.Request {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Request']/class[@name='RequestProcessor']"
	[global::Android.Runtime.Register ("com/webtrekk/webtrekksdk/Request/RequestProcessor", DoNotGenerateAcw=true)]
	public partial class RequestProcessor : global::Java.Lang.Object, global::Java.Lang.IRunnable {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Request']/class[@name='RequestProcessor']/field[@name='NETWORK_CONNECTION_TIMEOUT']"
		[Register ("NETWORK_CONNECTION_TIMEOUT")]
		public const int NetworkConnectionTimeout = (int) 60000;
		// Metadata.xml XPath interface reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Request']/interface[@name='RequestProcessor.ProcessOutputCallback']"
		[Register ("com/webtrekk/webtrekksdk/Request/RequestProcessor$ProcessOutputCallback", "", "Com.Webtrekk.Webtrekksdk.Request.RequestProcessor/IProcessOutputCallbackInvoker")]
		public partial interface IProcessOutputCallback : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Request']/interface[@name='RequestProcessor.ProcessOutputCallback']/method[@name='process' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='javax.net.ssl.HttpsURLConnection']]"
			[Register ("process", "(ILjavax/net/ssl/HttpsURLConnection;)V", "GetProcess_ILjavax_net_ssl_HttpsURLConnection_Handler:Com.Webtrekk.Webtrekksdk.Request.RequestProcessor/IProcessOutputCallbackInvoker, webtrekkLibrary")]
			void Process (int p0, global::Javax.Net.Ssl.HttpsURLConnection p1);

		}

		[global::Android.Runtime.Register ("com/webtrekk/webtrekksdk/Request/RequestProcessor$ProcessOutputCallback", DoNotGenerateAcw=true)]
		internal class IProcessOutputCallbackInvoker : global::Java.Lang.Object, IProcessOutputCallback {

			internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/webtrekk/webtrekksdk/Request/RequestProcessor$ProcessOutputCallback", typeof (IProcessOutputCallbackInvoker));

			static IntPtr java_class_ref {
				get { return _members.JniPeerType.PeerReference.Handle; }
			}

			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			IntPtr class_ref;

			public static IProcessOutputCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IProcessOutputCallback> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.webtrekk.webtrekksdk.Request.RequestProcessor.ProcessOutputCallback"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IProcessOutputCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_process_ILjavax_net_ssl_HttpsURLConnection_;
#pragma warning disable 0169
			static Delegate GetProcess_ILjavax_net_ssl_HttpsURLConnection_Handler ()
			{
				if (cb_process_ILjavax_net_ssl_HttpsURLConnection_ == null)
					cb_process_ILjavax_net_ssl_HttpsURLConnection_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_Process_ILjavax_net_ssl_HttpsURLConnection_);
				return cb_process_ILjavax_net_ssl_HttpsURLConnection_;
			}

			static void n_Process_ILjavax_net_ssl_HttpsURLConnection_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
			{
				global::Com.Webtrekk.Webtrekksdk.Request.RequestProcessor.IProcessOutputCallback __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Request.RequestProcessor.IProcessOutputCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Javax.Net.Ssl.HttpsURLConnection p1 = global::Java.Lang.Object.GetObject<global::Javax.Net.Ssl.HttpsURLConnection> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.Process (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_process_ILjavax_net_ssl_HttpsURLConnection_;
			public unsafe void Process (int p0, global::Javax.Net.Ssl.HttpsURLConnection p1)
			{
				if (id_process_ILjavax_net_ssl_HttpsURLConnection_ == IntPtr.Zero)
					id_process_ILjavax_net_ssl_HttpsURLConnection_ = JNIEnv.GetMethodID (class_ref, "process", "(ILjavax/net/ssl/HttpsURLConnection;)V");
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_process_ILjavax_net_ssl_HttpsURLConnection_, __args);
			}

		}


		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/webtrekk/webtrekksdk/Request/RequestProcessor", typeof (RequestProcessor));
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

		protected RequestProcessor (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Request']/class[@name='RequestProcessor']/constructor[@name='RequestProcessor' and count(parameter)=1 and parameter[1][@type='com.webtrekk.webtrekksdk.Request.RequestUrlStore']]"
		[Register (".ctor", "(Lcom/webtrekk/webtrekksdk/Request/RequestUrlStore;)V", "")]
		public unsafe RequestProcessor (global::Com.Webtrekk.Webtrekksdk.Request.RequestUrlStore requestUrlStore)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/webtrekk/webtrekksdk/Request/RequestUrlStore;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((requestUrlStore == null) ? IntPtr.Zero : ((global::Java.Lang.Object) requestUrlStore).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Request']/class[@name='RequestProcessor']/constructor[@name='RequestProcessor' and count(parameter)=2 and parameter[1][@type='com.webtrekk.webtrekksdk.Request.RequestUrlStore'] and parameter[2][@type='com.webtrekk.webtrekksdk.Utils.PinConnectionValidator']]"
		[Register (".ctor", "(Lcom/webtrekk/webtrekksdk/Request/RequestUrlStore;Lcom/webtrekk/webtrekksdk/Utils/PinConnectionValidator;)V", "")]
		public unsafe RequestProcessor (global::Com.Webtrekk.Webtrekksdk.Request.RequestUrlStore requestUrlStore, global::Com.Webtrekk.Webtrekksdk.Utils.PinConnectionValidator validator)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/webtrekk/webtrekksdk/Request/RequestUrlStore;Lcom/webtrekk/webtrekksdk/Utils/PinConnectionValidator;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((requestUrlStore == null) ? IntPtr.Zero : ((global::Java.Lang.Object) requestUrlStore).Handle);
				__args [1] = new JniArgumentValue ((validator == null) ? IntPtr.Zero : ((global::Java.Lang.Object) validator).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_getUrl_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetUrl_Ljava_lang_String_Handler ()
		{
			if (cb_getUrl_Ljava_lang_String_ == null)
				cb_getUrl_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetUrl_Ljava_lang_String_);
			return cb_getUrl_Ljava_lang_String_;
		}

		static IntPtr n_GetUrl_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_urlString)
		{
			global::Com.Webtrekk.Webtrekksdk.Request.RequestProcessor __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Request.RequestProcessor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string urlString = JNIEnv.GetString (native_urlString, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetUrl (urlString));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Request']/class[@name='RequestProcessor']/method[@name='getUrl' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getUrl", "(Ljava/lang/String;)Ljava/net/URL;", "GetGetUrl_Ljava_lang_String_Handler")]
		public virtual unsafe global::Java.Net.URL GetUrl (string urlString)
		{
			const string __id = "getUrl.(Ljava/lang/String;)Ljava/net/URL;";
			IntPtr native_urlString = JNIEnv.NewString (urlString);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_urlString);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Net.URL> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_urlString);
			}
		}

		static Delegate cb_getUrlConnection_Ljava_net_URL_;
#pragma warning disable 0169
		static Delegate GetGetUrlConnection_Ljava_net_URL_Handler ()
		{
			if (cb_getUrlConnection_Ljava_net_URL_ == null)
				cb_getUrlConnection_Ljava_net_URL_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetUrlConnection_Ljava_net_URL_);
			return cb_getUrlConnection_Ljava_net_URL_;
		}

		static IntPtr n_GetUrlConnection_Ljava_net_URL_ (IntPtr jnienv, IntPtr native__this, IntPtr native_url)
		{
			global::Com.Webtrekk.Webtrekksdk.Request.RequestProcessor __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Request.RequestProcessor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Net.URL url = global::Java.Lang.Object.GetObject<global::Java.Net.URL> (native_url, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetUrlConnection (url));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Request']/class[@name='RequestProcessor']/method[@name='getUrlConnection' and count(parameter)=1 and parameter[1][@type='java.net.URL']]"
		[Register ("getUrlConnection", "(Ljava/net/URL;)Ljavax/net/ssl/HttpsURLConnection;", "GetGetUrlConnection_Ljava_net_URL_Handler")]
		public virtual unsafe global::Javax.Net.Ssl.HttpsURLConnection GetUrlConnection (global::Java.Net.URL url)
		{
			const string __id = "getUrlConnection.(Ljava/net/URL;)Ljavax/net/ssl/HttpsURLConnection;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((url == null) ? IntPtr.Zero : ((global::Java.Lang.Object) url).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Javax.Net.Ssl.HttpsURLConnection> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_run;
#pragma warning disable 0169
		static Delegate GetRunHandler ()
		{
			if (cb_run == null)
				cb_run = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Run);
			return cb_run;
		}

		static void n_Run (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Webtrekk.Webtrekksdk.Request.RequestProcessor __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Request.RequestProcessor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Run ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Request']/class[@name='RequestProcessor']/method[@name='run' and count(parameter)=0]"
		[Register ("run", "()V", "GetRunHandler")]
		public virtual unsafe void Run ()
		{
			const string __id = "run.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_sendRequest_Ljava_net_URL_Lcom_webtrekk_webtrekksdk_Request_RequestProcessor_ProcessOutputCallback_;
#pragma warning disable 0169
		static Delegate GetSendRequest_Ljava_net_URL_Lcom_webtrekk_webtrekksdk_Request_RequestProcessor_ProcessOutputCallback_Handler ()
		{
			if (cb_sendRequest_Ljava_net_URL_Lcom_webtrekk_webtrekksdk_Request_RequestProcessor_ProcessOutputCallback_ == null)
				cb_sendRequest_Ljava_net_URL_Lcom_webtrekk_webtrekksdk_Request_RequestProcessor_ProcessOutputCallback_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, int>) n_SendRequest_Ljava_net_URL_Lcom_webtrekk_webtrekksdk_Request_RequestProcessor_ProcessOutputCallback_);
			return cb_sendRequest_Ljava_net_URL_Lcom_webtrekk_webtrekksdk_Request_RequestProcessor_ProcessOutputCallback_;
		}

		static int n_SendRequest_Ljava_net_URL_Lcom_webtrekk_webtrekksdk_Request_RequestProcessor_ProcessOutputCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_url, IntPtr native_processOutput)
		{
			global::Com.Webtrekk.Webtrekksdk.Request.RequestProcessor __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Request.RequestProcessor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Net.URL url = global::Java.Lang.Object.GetObject<global::Java.Net.URL> (native_url, JniHandleOwnership.DoNotTransfer);
			global::Com.Webtrekk.Webtrekksdk.Request.RequestProcessor.IProcessOutputCallback processOutput = (global::Com.Webtrekk.Webtrekksdk.Request.RequestProcessor.IProcessOutputCallback)global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Request.RequestProcessor.IProcessOutputCallback> (native_processOutput, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.SendRequest (url, processOutput);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Request']/class[@name='RequestProcessor']/method[@name='sendRequest' and count(parameter)=2 and parameter[1][@type='java.net.URL'] and parameter[2][@type='com.webtrekk.webtrekksdk.Request.RequestProcessor.ProcessOutputCallback']]"
		[Register ("sendRequest", "(Ljava/net/URL;Lcom/webtrekk/webtrekksdk/Request/RequestProcessor$ProcessOutputCallback;)I", "GetSendRequest_Ljava_net_URL_Lcom_webtrekk_webtrekksdk_Request_RequestProcessor_ProcessOutputCallback_Handler")]
		public virtual unsafe int SendRequest (global::Java.Net.URL url, global::Com.Webtrekk.Webtrekksdk.Request.RequestProcessor.IProcessOutputCallback processOutput)
		{
			const string __id = "sendRequest.(Ljava/net/URL;Lcom/webtrekk/webtrekksdk/Request/RequestProcessor$ProcessOutputCallback;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((url == null) ? IntPtr.Zero : ((global::Java.Lang.Object) url).Handle);
				__args [1] = new JniArgumentValue ((processOutput == null) ? IntPtr.Zero : ((global::Java.Lang.Object) processOutput).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

	}
}
