using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Webtrekk.Webtrekksdk.Modules {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Modules']/class[@name='ExceptionHandler']"
	[global::Android.Runtime.Register ("com/webtrekk/webtrekksdk/Modules/ExceptionHandler", DoNotGenerateAcw=true)]
	public partial class ExceptionHandler : global::Java.Lang.Object, global::Java.Lang.Thread.IUncaughtExceptionHandler {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Modules']/class[@name='ExceptionHandler.IncorrectErrorFileFormatException']"
		[global::Android.Runtime.Register ("com/webtrekk/webtrekksdk/Modules/ExceptionHandler$IncorrectErrorFileFormatException", DoNotGenerateAcw=true)]
		public partial class IncorrectErrorFileFormatException : global::Java.Lang.Exception {

			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/webtrekk/webtrekksdk/Modules/ExceptionHandler$IncorrectErrorFileFormatException", typeof (IncorrectErrorFileFormatException));
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

			protected IncorrectErrorFileFormatException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Modules']/class[@name='ExceptionHandler.Type']"
		[global::Android.Runtime.Register ("com/webtrekk/webtrekksdk/Modules/ExceptionHandler$Type", DoNotGenerateAcw=true)]
		public sealed partial class Type : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Modules']/class[@name='ExceptionHandler.Type']/field[@name='CATCHED']"
			[Register ("CATCHED")]
			public static global::Com.Webtrekk.Webtrekksdk.Modules.ExceptionHandler.Type Catched {
				get {
					const string __id = "CATCHED.Lcom/webtrekk/webtrekksdk/Modules/ExceptionHandler$Type;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Modules.ExceptionHandler.Type> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Modules']/class[@name='ExceptionHandler.Type']/field[@name='FATAL']"
			[Register ("FATAL")]
			public static global::Com.Webtrekk.Webtrekksdk.Modules.ExceptionHandler.Type Fatal {
				get {
					const string __id = "FATAL.Lcom/webtrekk/webtrekksdk/Modules/ExceptionHandler$Type;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Modules.ExceptionHandler.Type> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Modules']/class[@name='ExceptionHandler.Type']/field[@name='INFO']"
			[Register ("INFO")]
			public static global::Com.Webtrekk.Webtrekksdk.Modules.ExceptionHandler.Type Info {
				get {
					const string __id = "INFO.Lcom/webtrekk/webtrekksdk/Modules/ExceptionHandler$Type;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Modules.ExceptionHandler.Type> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Modules']/class[@name='ExceptionHandler.Type']/field[@name='NON_DEFINED']"
			[Register ("NON_DEFINED")]
			public static global::Com.Webtrekk.Webtrekksdk.Modules.ExceptionHandler.Type NonDefined {
				get {
					const string __id = "NON_DEFINED.Lcom/webtrekk/webtrekksdk/Modules/ExceptionHandler$Type;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Modules.ExceptionHandler.Type> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/webtrekk/webtrekksdk/Modules/ExceptionHandler$Type", typeof (Type));
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

			internal Type (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Modules']/class[@name='ExceptionHandler.Type']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Ljava/lang/Enum;", "")]
			public static unsafe global::Java.Lang.Enum ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Ljava/lang/Enum;";
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Enum> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Modules']/class[@name='ExceptionHandler.Type']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/webtrekk/webtrekksdk/Modules/ExceptionHandler$Type;", "")]
			public static unsafe global::Com.Webtrekk.Webtrekksdk.Modules.ExceptionHandler.Type[] Values ()
			{
				const string __id = "values.()[Lcom/webtrekk/webtrekksdk/Modules/ExceptionHandler$Type;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Com.Webtrekk.Webtrekksdk.Modules.ExceptionHandler.Type[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Webtrekk.Webtrekksdk.Modules.ExceptionHandler.Type));
				} finally {
				}
			}

		}

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/webtrekk/webtrekksdk/Modules/ExceptionHandler", typeof (ExceptionHandler));
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

		protected ExceptionHandler (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Modules']/class[@name='ExceptionHandler']/constructor[@name='ExceptionHandler' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ExceptionHandler ()
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

		static Delegate cb_init_Lcom_webtrekk_webtrekksdk_Request_RequestFactory_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetInit_Lcom_webtrekk_webtrekksdk_Request_RequestFactory_Landroid_content_Context_Handler ()
		{
			if (cb_init_Lcom_webtrekk_webtrekksdk_Request_RequestFactory_Landroid_content_Context_ == null)
				cb_init_Lcom_webtrekk_webtrekksdk_Request_RequestFactory_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Init_Lcom_webtrekk_webtrekksdk_Request_RequestFactory_Landroid_content_Context_);
			return cb_init_Lcom_webtrekk_webtrekksdk_Request_RequestFactory_Landroid_content_Context_;
		}

		static void n_Init_Lcom_webtrekk_webtrekksdk_Request_RequestFactory_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_requestFactory, IntPtr native_context)
		{
			global::Com.Webtrekk.Webtrekksdk.Modules.ExceptionHandler __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Modules.ExceptionHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Webtrekk.Webtrekksdk.Request.RequestFactory requestFactory = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Request.RequestFactory> (native_requestFactory, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
			__this.Init (requestFactory, context);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Modules']/class[@name='ExceptionHandler']/method[@name='init' and count(parameter)=2 and parameter[1][@type='com.webtrekk.webtrekksdk.Request.RequestFactory'] and parameter[2][@type='android.content.Context']]"
		[Register ("init", "(Lcom/webtrekk/webtrekksdk/Request/RequestFactory;Landroid/content/Context;)V", "GetInit_Lcom_webtrekk_webtrekksdk_Request_RequestFactory_Landroid_content_Context_Handler")]
		public virtual unsafe void Init (global::Com.Webtrekk.Webtrekksdk.Request.RequestFactory requestFactory, global::Android.Content.Context context)
		{
			const string __id = "init.(Lcom/webtrekk/webtrekksdk/Request/RequestFactory;Landroid/content/Context;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((requestFactory == null) ? IntPtr.Zero : ((global::Java.Lang.Object) requestFactory).Handle);
				__args [1] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_trackCatched_Ljava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetTrackCatched_Ljava_lang_Throwable_Handler ()
		{
			if (cb_trackCatched_Ljava_lang_Throwable_ == null)
				cb_trackCatched_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_TrackCatched_Ljava_lang_Throwable_);
			return cb_trackCatched_Ljava_lang_Throwable_;
		}

		static void n_TrackCatched_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_ex)
		{
			global::Com.Webtrekk.Webtrekksdk.Modules.ExceptionHandler __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Modules.ExceptionHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Throwable ex = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_ex, JniHandleOwnership.DoNotTransfer);
			__this.TrackCatched (ex);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Modules']/class[@name='ExceptionHandler']/method[@name='trackCatched' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register ("trackCatched", "(Ljava/lang/Throwable;)V", "GetTrackCatched_Ljava_lang_Throwable_Handler")]
		public virtual unsafe void TrackCatched (global::Java.Lang.Throwable ex)
		{
			const string __id = "trackCatched.(Ljava/lang/Throwable;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((ex == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) ex).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_trackInfo_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetTrackInfo_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_trackInfo_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_trackInfo_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_TrackInfo_Ljava_lang_String_Ljava_lang_String_);
			return cb_trackInfo_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_TrackInfo_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name, IntPtr native_message)
		{
			global::Com.Webtrekk.Webtrekksdk.Modules.ExceptionHandler __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Modules.ExceptionHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			string message = JNIEnv.GetString (native_message, JniHandleOwnership.DoNotTransfer);
			__this.TrackInfo (name, message);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Modules']/class[@name='ExceptionHandler']/method[@name='trackInfo' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("trackInfo", "(Ljava/lang/String;Ljava/lang/String;)V", "GetTrackInfo_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void TrackInfo (string name, string message)
		{
			const string __id = "trackInfo.(Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_name = JNIEnv.NewString (name);
			IntPtr native_message = JNIEnv.NewString (message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_name);
				__args [1] = new JniArgumentValue (native_message);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
				JNIEnv.DeleteLocalRef (native_message);
			}
		}

		static Delegate cb_uncaughtException_Ljava_lang_Thread_Ljava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetUncaughtException_Ljava_lang_Thread_Ljava_lang_Throwable_Handler ()
		{
			if (cb_uncaughtException_Ljava_lang_Thread_Ljava_lang_Throwable_ == null)
				cb_uncaughtException_Ljava_lang_Thread_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_UncaughtException_Ljava_lang_Thread_Ljava_lang_Throwable_);
			return cb_uncaughtException_Ljava_lang_Thread_Ljava_lang_Throwable_;
		}

		static void n_UncaughtException_Ljava_lang_Thread_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_thread, IntPtr native_ex)
		{
			global::Com.Webtrekk.Webtrekksdk.Modules.ExceptionHandler __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Modules.ExceptionHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Thread thread = global::Java.Lang.Object.GetObject<global::Java.Lang.Thread> (native_thread, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Throwable ex = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_ex, JniHandleOwnership.DoNotTransfer);
			__this.UncaughtException (thread, ex);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Modules']/class[@name='ExceptionHandler']/method[@name='uncaughtException' and count(parameter)=2 and parameter[1][@type='java.lang.Thread'] and parameter[2][@type='java.lang.Throwable']]"
		[Register ("uncaughtException", "(Ljava/lang/Thread;Ljava/lang/Throwable;)V", "GetUncaughtException_Ljava_lang_Thread_Ljava_lang_Throwable_Handler")]
		public virtual unsafe void UncaughtException (global::Java.Lang.Thread thread, global::Java.Lang.Throwable ex)
		{
			const string __id = "uncaughtException.(Ljava/lang/Thread;Ljava/lang/Throwable;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((thread == null) ? IntPtr.Zero : ((global::Java.Lang.Object) thread).Handle);
				__args [1] = new JniArgumentValue ((ex == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) ex).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
