using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Webtrekk.Webtrekksdk.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Utils']/class[@name='ActivityListener']"
	[global::Android.Runtime.Register ("com/webtrekk/webtrekksdk/Utils/ActivityListener", DoNotGenerateAcw=true)]
	public partial class ActivityListener : global::Com.Webtrekk.Webtrekksdk.Utils.ActivityTrackingStatus {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Utils']/interface[@name='ActivityListener.Callback']"
		[Register ("com/webtrekk/webtrekksdk/Utils/ActivityListener$Callback", "", "Com.Webtrekk.Webtrekksdk.Utils.ActivityListener/ICallbackInvoker")]
		public partial interface ICallback : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Utils']/interface[@name='ActivityListener.Callback']/method[@name='onDestroy' and count(parameter)=1 and parameter[1][@type='com.webtrekk.webtrekksdk.Utils.ActivityTrackingStatus.STATUS']]"
			[Register ("onDestroy", "(Lcom/webtrekk/webtrekksdk/Utils/ActivityTrackingStatus$STATUS;)V", "GetOnDestroy_Lcom_webtrekk_webtrekksdk_Utils_ActivityTrackingStatus_STATUS_Handler:Com.Webtrekk.Webtrekksdk.Utils.ActivityListener/ICallbackInvoker, webtrekkLibrary")]
			void OnDestroy (global::Com.Webtrekk.Webtrekksdk.Utils.ActivityTrackingStatus.STATUS p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Utils']/interface[@name='ActivityListener.Callback']/method[@name='onStart' and count(parameter)=4 and parameter[1][@type='boolean'] and parameter[2][@type='com.webtrekk.webtrekksdk.Utils.ActivityTrackingStatus.STATUS'] and parameter[3][@type='long'] and parameter[4][@type='java.lang.String']]"
			[Register ("onStart", "(ZLcom/webtrekk/webtrekksdk/Utils/ActivityTrackingStatus$STATUS;JLjava/lang/String;)V", "GetOnStart_ZLcom_webtrekk_webtrekksdk_Utils_ActivityTrackingStatus_STATUS_JLjava_lang_String_Handler:Com.Webtrekk.Webtrekksdk.Utils.ActivityListener/ICallbackInvoker, webtrekkLibrary")]
			void OnStart (bool p0, global::Com.Webtrekk.Webtrekksdk.Utils.ActivityTrackingStatus.STATUS p1, long p2, string p3);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Utils']/interface[@name='ActivityListener.Callback']/method[@name='onStop' and count(parameter)=1 and parameter[1][@type='com.webtrekk.webtrekksdk.Utils.ActivityTrackingStatus.STATUS']]"
			[Register ("onStop", "(Lcom/webtrekk/webtrekksdk/Utils/ActivityTrackingStatus$STATUS;)V", "GetOnStop_Lcom_webtrekk_webtrekksdk_Utils_ActivityTrackingStatus_STATUS_Handler:Com.Webtrekk.Webtrekksdk.Utils.ActivityListener/ICallbackInvoker, webtrekkLibrary")]
			void OnStop (global::Com.Webtrekk.Webtrekksdk.Utils.ActivityTrackingStatus.STATUS p0);

		}

		[global::Android.Runtime.Register ("com/webtrekk/webtrekksdk/Utils/ActivityListener$Callback", DoNotGenerateAcw=true)]
		internal class ICallbackInvoker : global::Java.Lang.Object, ICallback {

			internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/webtrekk/webtrekksdk/Utils/ActivityListener$Callback", typeof (ICallbackInvoker));

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

			public static ICallback GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<ICallback> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.webtrekk.webtrekksdk.Utils.ActivityListener.Callback"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public ICallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onDestroy_Lcom_webtrekk_webtrekksdk_Utils_ActivityTrackingStatus_STATUS_;
#pragma warning disable 0169
			static Delegate GetOnDestroy_Lcom_webtrekk_webtrekksdk_Utils_ActivityTrackingStatus_STATUS_Handler ()
			{
				if (cb_onDestroy_Lcom_webtrekk_webtrekksdk_Utils_ActivityTrackingStatus_STATUS_ == null)
					cb_onDestroy_Lcom_webtrekk_webtrekksdk_Utils_ActivityTrackingStatus_STATUS_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnDestroy_Lcom_webtrekk_webtrekksdk_Utils_ActivityTrackingStatus_STATUS_);
				return cb_onDestroy_Lcom_webtrekk_webtrekksdk_Utils_ActivityTrackingStatus_STATUS_;
			}

			static void n_OnDestroy_Lcom_webtrekk_webtrekksdk_Utils_ActivityTrackingStatus_STATUS_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Webtrekk.Webtrekksdk.Utils.ActivityListener.ICallback __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Utils.ActivityListener.ICallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Webtrekk.Webtrekksdk.Utils.ActivityTrackingStatus.STATUS p0 = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Utils.ActivityTrackingStatus.STATUS> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnDestroy (p0);
			}
#pragma warning restore 0169

			IntPtr id_onDestroy_Lcom_webtrekk_webtrekksdk_Utils_ActivityTrackingStatus_STATUS_;
			public unsafe void OnDestroy (global::Com.Webtrekk.Webtrekksdk.Utils.ActivityTrackingStatus.STATUS p0)
			{
				if (id_onDestroy_Lcom_webtrekk_webtrekksdk_Utils_ActivityTrackingStatus_STATUS_ == IntPtr.Zero)
					id_onDestroy_Lcom_webtrekk_webtrekksdk_Utils_ActivityTrackingStatus_STATUS_ = JNIEnv.GetMethodID (class_ref, "onDestroy", "(Lcom/webtrekk/webtrekksdk/Utils/ActivityTrackingStatus$STATUS;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDestroy_Lcom_webtrekk_webtrekksdk_Utils_ActivityTrackingStatus_STATUS_, __args);
			}

			static Delegate cb_onStart_ZLcom_webtrekk_webtrekksdk_Utils_ActivityTrackingStatus_STATUS_JLjava_lang_String_;
#pragma warning disable 0169
			static Delegate GetOnStart_ZLcom_webtrekk_webtrekksdk_Utils_ActivityTrackingStatus_STATUS_JLjava_lang_String_Handler ()
			{
				if (cb_onStart_ZLcom_webtrekk_webtrekksdk_Utils_ActivityTrackingStatus_STATUS_JLjava_lang_String_ == null)
					cb_onStart_ZLcom_webtrekk_webtrekksdk_Utils_ActivityTrackingStatus_STATUS_JLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool, IntPtr, long, IntPtr>) n_OnStart_ZLcom_webtrekk_webtrekksdk_Utils_ActivityTrackingStatus_STATUS_JLjava_lang_String_);
				return cb_onStart_ZLcom_webtrekk_webtrekksdk_Utils_ActivityTrackingStatus_STATUS_JLjava_lang_String_;
			}

			static void n_OnStart_ZLcom_webtrekk_webtrekksdk_Utils_ActivityTrackingStatus_STATUS_JLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, bool p0, IntPtr native_p1, long p2, IntPtr native_p3)
			{
				global::Com.Webtrekk.Webtrekksdk.Utils.ActivityListener.ICallback __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Utils.ActivityListener.ICallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Webtrekk.Webtrekksdk.Utils.ActivityTrackingStatus.STATUS p1 = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Utils.ActivityTrackingStatus.STATUS> (native_p1, JniHandleOwnership.DoNotTransfer);
				string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
				__this.OnStart (p0, p1, p2, p3);
			}
#pragma warning restore 0169

			IntPtr id_onStart_ZLcom_webtrekk_webtrekksdk_Utils_ActivityTrackingStatus_STATUS_JLjava_lang_String_;
			public unsafe void OnStart (bool p0, global::Com.Webtrekk.Webtrekksdk.Utils.ActivityTrackingStatus.STATUS p1, long p2, string p3)
			{
				if (id_onStart_ZLcom_webtrekk_webtrekksdk_Utils_ActivityTrackingStatus_STATUS_JLjava_lang_String_ == IntPtr.Zero)
					id_onStart_ZLcom_webtrekk_webtrekksdk_Utils_ActivityTrackingStatus_STATUS_JLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onStart", "(ZLcom/webtrekk/webtrekksdk/Utils/ActivityTrackingStatus$STATUS;JLjava/lang/String;)V");
				IntPtr native_p3 = JNIEnv.NewString (p3);
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (native_p3);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onStart_ZLcom_webtrekk_webtrekksdk_Utils_ActivityTrackingStatus_STATUS_JLjava_lang_String_, __args);
				JNIEnv.DeleteLocalRef (native_p3);
			}

			static Delegate cb_onStop_Lcom_webtrekk_webtrekksdk_Utils_ActivityTrackingStatus_STATUS_;
#pragma warning disable 0169
			static Delegate GetOnStop_Lcom_webtrekk_webtrekksdk_Utils_ActivityTrackingStatus_STATUS_Handler ()
			{
				if (cb_onStop_Lcom_webtrekk_webtrekksdk_Utils_ActivityTrackingStatus_STATUS_ == null)
					cb_onStop_Lcom_webtrekk_webtrekksdk_Utils_ActivityTrackingStatus_STATUS_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnStop_Lcom_webtrekk_webtrekksdk_Utils_ActivityTrackingStatus_STATUS_);
				return cb_onStop_Lcom_webtrekk_webtrekksdk_Utils_ActivityTrackingStatus_STATUS_;
			}

			static void n_OnStop_Lcom_webtrekk_webtrekksdk_Utils_ActivityTrackingStatus_STATUS_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Webtrekk.Webtrekksdk.Utils.ActivityListener.ICallback __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Utils.ActivityListener.ICallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Webtrekk.Webtrekksdk.Utils.ActivityTrackingStatus.STATUS p0 = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Utils.ActivityTrackingStatus.STATUS> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnStop (p0);
			}
#pragma warning restore 0169

			IntPtr id_onStop_Lcom_webtrekk_webtrekksdk_Utils_ActivityTrackingStatus_STATUS_;
			public unsafe void OnStop (global::Com.Webtrekk.Webtrekksdk.Utils.ActivityTrackingStatus.STATUS p0)
			{
				if (id_onStop_Lcom_webtrekk_webtrekksdk_Utils_ActivityTrackingStatus_STATUS_ == IntPtr.Zero)
					id_onStop_Lcom_webtrekk_webtrekksdk_Utils_ActivityTrackingStatus_STATUS_ = JNIEnv.GetMethodID (class_ref, "onStop", "(Lcom/webtrekk/webtrekksdk/Utils/ActivityTrackingStatus$STATUS;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onStop_Lcom_webtrekk_webtrekksdk_Utils_ActivityTrackingStatus_STATUS_, __args);
			}

		}


		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/webtrekk/webtrekksdk/Utils/ActivityListener", typeof (ActivityListener));
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

		protected ActivityListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Utils']/class[@name='ActivityListener']/constructor[@name='ActivityListener' and count(parameter)=1 and parameter[1][@type='com.webtrekk.webtrekksdk.Utils.ActivityListener.Callback']]"
		[Register (".ctor", "(Lcom/webtrekk/webtrekksdk/Utils/ActivityListener$Callback;)V", "")]
		public unsafe ActivityListener (global::Com.Webtrekk.Webtrekksdk.Utils.ActivityListener.ICallback @callback)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/webtrekk/webtrekksdk/Utils/ActivityListener$Callback;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_init_Landroid_app_Application_;
#pragma warning disable 0169
		static Delegate GetInit_Landroid_app_Application_Handler ()
		{
			if (cb_init_Landroid_app_Application_ == null)
				cb_init_Landroid_app_Application_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Init_Landroid_app_Application_);
			return cb_init_Landroid_app_Application_;
		}

		static void n_Init_Landroid_app_Application_ (IntPtr jnienv, IntPtr native__this, IntPtr native_application)
		{
			global::Com.Webtrekk.Webtrekksdk.Utils.ActivityListener __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Utils.ActivityListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Application application = global::Java.Lang.Object.GetObject<global::Android.App.Application> (native_application, JniHandleOwnership.DoNotTransfer);
			__this.Init (application);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Utils']/class[@name='ActivityListener']/method[@name='init' and count(parameter)=1 and parameter[1][@type='android.app.Application']]"
		[Register ("init", "(Landroid/app/Application;)V", "GetInit_Landroid_app_Application_Handler")]
		public virtual unsafe void Init (global::Android.App.Application application)
		{
			const string __id = "init.(Landroid/app/Application;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((application == null) ? IntPtr.Zero : ((global::Java.Lang.Object) application).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
