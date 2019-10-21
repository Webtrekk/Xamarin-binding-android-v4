using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Webtrekk.Webtrekksdk.Request {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Request']/class[@name='RequestUrlStore']"
	[global::Android.Runtime.Register ("com/webtrekk/webtrekksdk/Request/RequestUrlStore", DoNotGenerateAcw=true)]
	public partial class RequestUrlStore : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/webtrekk/webtrekksdk/Request/RequestUrlStore", typeof (RequestUrlStore));
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

		protected RequestUrlStore (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Request']/class[@name='RequestUrlStore']/constructor[@name='RequestUrlStore' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe RequestUrlStore (global::Android.Content.Context context)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_getRequestStoreFile;
#pragma warning disable 0169
		static Delegate GetGetRequestStoreFileHandler ()
		{
			if (cb_getRequestStoreFile == null)
				cb_getRequestStoreFile = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRequestStoreFile);
			return cb_getRequestStoreFile;
		}

		static IntPtr n_GetRequestStoreFile (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Webtrekk.Webtrekksdk.Request.RequestUrlStore __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Request.RequestUrlStore> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RequestStoreFile);
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.IO.File RequestStoreFile {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Request']/class[@name='RequestUrlStore']/method[@name='getRequestStoreFile' and count(parameter)=0]"
			[Register ("getRequestStoreFile", "()Ljava/io/File;", "GetGetRequestStoreFileHandler")]
			get {
				const string __id = "getRequestStoreFile.()Ljava/io/File;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.IO.File> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_addURL_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAddURL_Ljava_lang_String_Handler ()
		{
			if (cb_addURL_Ljava_lang_String_ == null)
				cb_addURL_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddURL_Ljava_lang_String_);
			return cb_addURL_Ljava_lang_String_;
		}

		static void n_AddURL_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_requestUrl)
		{
			global::Com.Webtrekk.Webtrekksdk.Request.RequestUrlStore __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Request.RequestUrlStore> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string requestUrl = JNIEnv.GetString (native_requestUrl, JniHandleOwnership.DoNotTransfer);
			__this.AddURL (requestUrl);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Request']/class[@name='RequestUrlStore']/method[@name='addURL' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("addURL", "(Ljava/lang/String;)V", "GetAddURL_Ljava_lang_String_Handler")]
		public virtual unsafe void AddURL (string requestUrl)
		{
			const string __id = "addURL.(Ljava/lang/String;)V";
			IntPtr native_requestUrl = JNIEnv.NewString (requestUrl);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_requestUrl);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_requestUrl);
			}
		}

		static Delegate cb_clearAllTrackingData;
#pragma warning disable 0169
		static Delegate GetClearAllTrackingDataHandler ()
		{
			if (cb_clearAllTrackingData == null)
				cb_clearAllTrackingData = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ClearAllTrackingData);
			return cb_clearAllTrackingData;
		}

		static void n_ClearAllTrackingData (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Webtrekk.Webtrekksdk.Request.RequestUrlStore __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Request.RequestUrlStore> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ClearAllTrackingData ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Request']/class[@name='RequestUrlStore']/method[@name='clearAllTrackingData' and count(parameter)=0]"
		[Register ("clearAllTrackingData", "()V", "GetClearAllTrackingDataHandler")]
		public virtual unsafe void ClearAllTrackingData ()
		{
			const string __id = "clearAllTrackingData.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_deleteRequestsFile;
#pragma warning disable 0169
		static Delegate GetDeleteRequestsFileHandler ()
		{
			if (cb_deleteRequestsFile == null)
				cb_deleteRequestsFile = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_DeleteRequestsFile);
			return cb_deleteRequestsFile;
		}

		static void n_DeleteRequestsFile (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Webtrekk.Webtrekksdk.Request.RequestUrlStore __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Request.RequestUrlStore> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DeleteRequestsFile ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Request']/class[@name='RequestUrlStore']/method[@name='deleteRequestsFile' and count(parameter)=0]"
		[Register ("deleteRequestsFile", "()V", "GetDeleteRequestsFileHandler")]
		public virtual unsafe void DeleteRequestsFile ()
		{
			const string __id = "deleteRequestsFile.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_flush;
#pragma warning disable 0169
		static Delegate GetFlushHandler ()
		{
			if (cb_flush == null)
				cb_flush = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Flush);
			return cb_flush;
		}

		static void n_Flush (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Webtrekk.Webtrekksdk.Request.RequestUrlStore __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Request.RequestUrlStore> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Flush ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Request']/class[@name='RequestUrlStore']/method[@name='flush' and count(parameter)=0]"
		[Register ("flush", "()V", "GetFlushHandler")]
		public virtual unsafe void Flush ()
		{
			const string __id = "flush.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_peek;
#pragma warning disable 0169
		static Delegate GetPeekHandler ()
		{
			if (cb_peek == null)
				cb_peek = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Peek);
			return cb_peek;
		}

		static IntPtr n_Peek (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Webtrekk.Webtrekksdk.Request.RequestUrlStore __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Request.RequestUrlStore> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Peek ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Request']/class[@name='RequestUrlStore']/method[@name='peek' and count(parameter)=0]"
		[Register ("peek", "()Ljava/lang/String;", "GetPeekHandler")]
		public virtual unsafe string Peek ()
		{
			const string __id = "peek.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_removeLastURL;
#pragma warning disable 0169
		static Delegate GetRemoveLastURLHandler ()
		{
			if (cb_removeLastURL == null)
				cb_removeLastURL = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RemoveLastURL);
			return cb_removeLastURL;
		}

		static void n_RemoveLastURL (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Webtrekk.Webtrekksdk.Request.RequestUrlStore __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Request.RequestUrlStore> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RemoveLastURL ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Request']/class[@name='RequestUrlStore']/method[@name='removeLastURL' and count(parameter)=0]"
		[Register ("removeLastURL", "()V", "GetRemoveLastURLHandler")]
		public virtual unsafe void RemoveLastURL ()
		{
			const string __id = "removeLastURL.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_reset;
#pragma warning disable 0169
		static Delegate GetResetHandler ()
		{
			if (cb_reset == null)
				cb_reset = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Reset);
			return cb_reset;
		}

		static void n_Reset (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Webtrekk.Webtrekksdk.Request.RequestUrlStore __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Request.RequestUrlStore> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Reset ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Request']/class[@name='RequestUrlStore']/method[@name='reset' and count(parameter)=0]"
		[Register ("reset", "()V", "GetResetHandler")]
		public virtual unsafe void Reset ()
		{
			const string __id = "reset.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_size;
#pragma warning disable 0169
		static Delegate GetSizeHandler ()
		{
			if (cb_size == null)
				cb_size = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_Size);
			return cb_size;
		}

		static int n_Size (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Webtrekk.Webtrekksdk.Request.RequestUrlStore __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Request.RequestUrlStore> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Size ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Request']/class[@name='RequestUrlStore']/method[@name='size' and count(parameter)=0]"
		[Register ("size", "()I", "GetSizeHandler")]
		public virtual unsafe int Size ()
		{
			const string __id = "size.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

	}
}
