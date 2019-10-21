using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Webtrekk.Webtrekksdk.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Utils']/class[@name='ActivityTrackingStatus']"
	[global::Android.Runtime.Register ("com/webtrekk/webtrekksdk/Utils/ActivityTrackingStatus", DoNotGenerateAcw=true)]
	public partial class ActivityTrackingStatus : global::Java.Lang.Object, global::Android.App.Application.IActivityLifecycleCallbacks {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Utils']/class[@name='ActivityTrackingStatus.STATUS']"
		[global::Android.Runtime.Register ("com/webtrekk/webtrekksdk/Utils/ActivityTrackingStatus$STATUS", DoNotGenerateAcw=true)]
		public sealed partial class STATUS : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Utils']/class[@name='ActivityTrackingStatus.STATUS']/field[@name='ACTIVITY_IS_SHOWN']"
			[Register ("ACTIVITY_IS_SHOWN")]
			public static global::Com.Webtrekk.Webtrekksdk.Utils.ActivityTrackingStatus.STATUS ActivityIsShown {
				get {
					const string __id = "ACTIVITY_IS_SHOWN.Lcom/webtrekk/webtrekksdk/Utils/ActivityTrackingStatus$STATUS;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Utils.ActivityTrackingStatus.STATUS> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Utils']/class[@name='ActivityTrackingStatus.STATUS']/field[@name='FIRST_ACTIVITY_STARTED']"
			[Register ("FIRST_ACTIVITY_STARTED")]
			public static global::Com.Webtrekk.Webtrekksdk.Utils.ActivityTrackingStatus.STATUS FirstActivityStarted {
				get {
					const string __id = "FIRST_ACTIVITY_STARTED.Lcom/webtrekk/webtrekksdk/Utils/ActivityTrackingStatus$STATUS;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Utils.ActivityTrackingStatus.STATUS> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Utils']/class[@name='ActivityTrackingStatus.STATUS']/field[@name='GOING_TO_BACKGROUND']"
			[Register ("GOING_TO_BACKGROUND")]
			public static global::Com.Webtrekk.Webtrekksdk.Utils.ActivityTrackingStatus.STATUS GoingToBackground {
				get {
					const string __id = "GOING_TO_BACKGROUND.Lcom/webtrekk/webtrekksdk/Utils/ActivityTrackingStatus$STATUS;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Utils.ActivityTrackingStatus.STATUS> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Utils']/class[@name='ActivityTrackingStatus.STATUS']/field[@name='NO_ACTIVITY_IS_RUNNING']"
			[Register ("NO_ACTIVITY_IS_RUNNING")]
			public static global::Com.Webtrekk.Webtrekksdk.Utils.ActivityTrackingStatus.STATUS NoActivityIsRunning {
				get {
					const string __id = "NO_ACTIVITY_IS_RUNNING.Lcom/webtrekk/webtrekksdk/Utils/ActivityTrackingStatus$STATUS;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Utils.ActivityTrackingStatus.STATUS> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Utils']/class[@name='ActivityTrackingStatus.STATUS']/field[@name='RETURNINIG_FROM_BACKGROUND']"
			[Register ("RETURNINIG_FROM_BACKGROUND")]
			public static global::Com.Webtrekk.Webtrekksdk.Utils.ActivityTrackingStatus.STATUS ReturninigFromBackground {
				get {
					const string __id = "RETURNINIG_FROM_BACKGROUND.Lcom/webtrekk/webtrekksdk/Utils/ActivityTrackingStatus$STATUS;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Utils.ActivityTrackingStatus.STATUS> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Utils']/class[@name='ActivityTrackingStatus.STATUS']/field[@name='SHUT_DOWNING']"
			[Register ("SHUT_DOWNING")]
			public static global::Com.Webtrekk.Webtrekksdk.Utils.ActivityTrackingStatus.STATUS ShutDowning {
				get {
					const string __id = "SHUT_DOWNING.Lcom/webtrekk/webtrekksdk/Utils/ActivityTrackingStatus$STATUS;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Utils.ActivityTrackingStatus.STATUS> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/webtrekk/webtrekksdk/Utils/ActivityTrackingStatus$STATUS", typeof (STATUS));
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

			internal STATUS (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Utils']/class[@name='ActivityTrackingStatus.STATUS']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/webtrekk/webtrekksdk/Utils/ActivityTrackingStatus$STATUS;", "")]
			public static unsafe global::Com.Webtrekk.Webtrekksdk.Utils.ActivityTrackingStatus.STATUS ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/webtrekk/webtrekksdk/Utils/ActivityTrackingStatus$STATUS;";
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Utils.ActivityTrackingStatus.STATUS> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Utils']/class[@name='ActivityTrackingStatus.STATUS']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/webtrekk/webtrekksdk/Utils/ActivityTrackingStatus$STATUS;", "")]
			public static unsafe global::Com.Webtrekk.Webtrekksdk.Utils.ActivityTrackingStatus.STATUS[] Values ()
			{
				const string __id = "values.()[Lcom/webtrekk/webtrekksdk/Utils/ActivityTrackingStatus$STATUS;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Com.Webtrekk.Webtrekksdk.Utils.ActivityTrackingStatus.STATUS[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Webtrekk.Webtrekksdk.Utils.ActivityTrackingStatus.STATUS));
				} finally {
				}
			}

		}

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/webtrekk/webtrekksdk/Utils/ActivityTrackingStatus", typeof (ActivityTrackingStatus));
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

		protected ActivityTrackingStatus (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Utils']/class[@name='ActivityTrackingStatus']/constructor[@name='ActivityTrackingStatus' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ActivityTrackingStatus ()
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

		static Delegate cb_getCurrentActivitiesCount;
#pragma warning disable 0169
		static Delegate GetGetCurrentActivitiesCountHandler ()
		{
			if (cb_getCurrentActivitiesCount == null)
				cb_getCurrentActivitiesCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetCurrentActivitiesCount);
			return cb_getCurrentActivitiesCount;
		}

		static int n_GetCurrentActivitiesCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Webtrekk.Webtrekksdk.Utils.ActivityTrackingStatus __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Utils.ActivityTrackingStatus> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CurrentActivitiesCount;
		}
#pragma warning restore 0169

		public virtual unsafe int CurrentActivitiesCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Utils']/class[@name='ActivityTrackingStatus']/method[@name='getCurrentActivitiesCount' and count(parameter)=0]"
			[Register ("getCurrentActivitiesCount", "()I", "GetGetCurrentActivitiesCountHandler")]
			get {
				const string __id = "getCurrentActivitiesCount.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getInactivityApplicaitonTime;
#pragma warning disable 0169
		static Delegate GetGetInactivityApplicaitonTimeHandler ()
		{
			if (cb_getInactivityApplicaitonTime == null)
				cb_getInactivityApplicaitonTime = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetInactivityApplicaitonTime);
			return cb_getInactivityApplicaitonTime;
		}

		static long n_GetInactivityApplicaitonTime (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Webtrekk.Webtrekksdk.Utils.ActivityTrackingStatus __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Utils.ActivityTrackingStatus> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.InactivityApplicaitonTime;
		}
#pragma warning restore 0169

		protected virtual unsafe long InactivityApplicaitonTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Utils']/class[@name='ActivityTrackingStatus']/method[@name='getInactivityApplicaitonTime' and count(parameter)=0]"
			[Register ("getInactivityApplicaitonTime", "()J", "GetGetInactivityApplicaitonTimeHandler")]
			get {
				const string __id = "getInactivityApplicaitonTime.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_onActivityCreated_Landroid_app_Activity_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetOnActivityCreated_Landroid_app_Activity_Landroid_os_Bundle_Handler ()
		{
			if (cb_onActivityCreated_Landroid_app_Activity_Landroid_os_Bundle_ == null)
				cb_onActivityCreated_Landroid_app_Activity_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnActivityCreated_Landroid_app_Activity_Landroid_os_Bundle_);
			return cb_onActivityCreated_Landroid_app_Activity_Landroid_os_Bundle_;
		}

		static void n_OnActivityCreated_Landroid_app_Activity_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_activity, IntPtr native_savedInstanceState)
		{
			global::Com.Webtrekk.Webtrekksdk.Utils.ActivityTrackingStatus __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Utils.ActivityTrackingStatus> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity activity = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_activity, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle savedInstanceState = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_savedInstanceState, JniHandleOwnership.DoNotTransfer);
			__this.OnActivityCreated (activity, savedInstanceState);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Utils']/class[@name='ActivityTrackingStatus']/method[@name='onActivityCreated' and count(parameter)=2 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='android.os.Bundle']]"
		[Register ("onActivityCreated", "(Landroid/app/Activity;Landroid/os/Bundle;)V", "GetOnActivityCreated_Landroid_app_Activity_Landroid_os_Bundle_Handler")]
		public virtual unsafe void OnActivityCreated (global::Android.App.Activity activity, global::Android.OS.Bundle savedInstanceState)
		{
			const string __id = "onActivityCreated.(Landroid/app/Activity;Landroid/os/Bundle;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((activity == null) ? IntPtr.Zero : ((global::Java.Lang.Object) activity).Handle);
				__args [1] = new JniArgumentValue ((savedInstanceState == null) ? IntPtr.Zero : ((global::Java.Lang.Object) savedInstanceState).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_onActivityDestroyed_Landroid_app_Activity_;
#pragma warning disable 0169
		static Delegate GetOnActivityDestroyed_Landroid_app_Activity_Handler ()
		{
			if (cb_onActivityDestroyed_Landroid_app_Activity_ == null)
				cb_onActivityDestroyed_Landroid_app_Activity_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnActivityDestroyed_Landroid_app_Activity_);
			return cb_onActivityDestroyed_Landroid_app_Activity_;
		}

		static void n_OnActivityDestroyed_Landroid_app_Activity_ (IntPtr jnienv, IntPtr native__this, IntPtr native_activity)
		{
			global::Com.Webtrekk.Webtrekksdk.Utils.ActivityTrackingStatus __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Utils.ActivityTrackingStatus> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity activity = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_activity, JniHandleOwnership.DoNotTransfer);
			__this.OnActivityDestroyed (activity);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Utils']/class[@name='ActivityTrackingStatus']/method[@name='onActivityDestroyed' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("onActivityDestroyed", "(Landroid/app/Activity;)V", "GetOnActivityDestroyed_Landroid_app_Activity_Handler")]
		public virtual unsafe void OnActivityDestroyed (global::Android.App.Activity activity)
		{
			const string __id = "onActivityDestroyed.(Landroid/app/Activity;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((activity == null) ? IntPtr.Zero : ((global::Java.Lang.Object) activity).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_onActivityPaused_Landroid_app_Activity_;
#pragma warning disable 0169
		static Delegate GetOnActivityPaused_Landroid_app_Activity_Handler ()
		{
			if (cb_onActivityPaused_Landroid_app_Activity_ == null)
				cb_onActivityPaused_Landroid_app_Activity_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnActivityPaused_Landroid_app_Activity_);
			return cb_onActivityPaused_Landroid_app_Activity_;
		}

		static void n_OnActivityPaused_Landroid_app_Activity_ (IntPtr jnienv, IntPtr native__this, IntPtr native_activity)
		{
			global::Com.Webtrekk.Webtrekksdk.Utils.ActivityTrackingStatus __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Utils.ActivityTrackingStatus> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity activity = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_activity, JniHandleOwnership.DoNotTransfer);
			__this.OnActivityPaused (activity);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Utils']/class[@name='ActivityTrackingStatus']/method[@name='onActivityPaused' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("onActivityPaused", "(Landroid/app/Activity;)V", "GetOnActivityPaused_Landroid_app_Activity_Handler")]
		public virtual unsafe void OnActivityPaused (global::Android.App.Activity activity)
		{
			const string __id = "onActivityPaused.(Landroid/app/Activity;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((activity == null) ? IntPtr.Zero : ((global::Java.Lang.Object) activity).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_onActivityResumed_Landroid_app_Activity_;
#pragma warning disable 0169
		static Delegate GetOnActivityResumed_Landroid_app_Activity_Handler ()
		{
			if (cb_onActivityResumed_Landroid_app_Activity_ == null)
				cb_onActivityResumed_Landroid_app_Activity_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnActivityResumed_Landroid_app_Activity_);
			return cb_onActivityResumed_Landroid_app_Activity_;
		}

		static void n_OnActivityResumed_Landroid_app_Activity_ (IntPtr jnienv, IntPtr native__this, IntPtr native_activity)
		{
			global::Com.Webtrekk.Webtrekksdk.Utils.ActivityTrackingStatus __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Utils.ActivityTrackingStatus> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity activity = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_activity, JniHandleOwnership.DoNotTransfer);
			__this.OnActivityResumed (activity);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Utils']/class[@name='ActivityTrackingStatus']/method[@name='onActivityResumed' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("onActivityResumed", "(Landroid/app/Activity;)V", "GetOnActivityResumed_Landroid_app_Activity_Handler")]
		public virtual unsafe void OnActivityResumed (global::Android.App.Activity activity)
		{
			const string __id = "onActivityResumed.(Landroid/app/Activity;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((activity == null) ? IntPtr.Zero : ((global::Java.Lang.Object) activity).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_onActivitySaveInstanceState_Landroid_app_Activity_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetOnActivitySaveInstanceState_Landroid_app_Activity_Landroid_os_Bundle_Handler ()
		{
			if (cb_onActivitySaveInstanceState_Landroid_app_Activity_Landroid_os_Bundle_ == null)
				cb_onActivitySaveInstanceState_Landroid_app_Activity_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnActivitySaveInstanceState_Landroid_app_Activity_Landroid_os_Bundle_);
			return cb_onActivitySaveInstanceState_Landroid_app_Activity_Landroid_os_Bundle_;
		}

		static void n_OnActivitySaveInstanceState_Landroid_app_Activity_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_activity, IntPtr native_outState)
		{
			global::Com.Webtrekk.Webtrekksdk.Utils.ActivityTrackingStatus __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Utils.ActivityTrackingStatus> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity activity = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_activity, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle outState = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_outState, JniHandleOwnership.DoNotTransfer);
			__this.OnActivitySaveInstanceState (activity, outState);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Utils']/class[@name='ActivityTrackingStatus']/method[@name='onActivitySaveInstanceState' and count(parameter)=2 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='android.os.Bundle']]"
		[Register ("onActivitySaveInstanceState", "(Landroid/app/Activity;Landroid/os/Bundle;)V", "GetOnActivitySaveInstanceState_Landroid_app_Activity_Landroid_os_Bundle_Handler")]
		public virtual unsafe void OnActivitySaveInstanceState (global::Android.App.Activity activity, global::Android.OS.Bundle outState)
		{
			const string __id = "onActivitySaveInstanceState.(Landroid/app/Activity;Landroid/os/Bundle;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((activity == null) ? IntPtr.Zero : ((global::Java.Lang.Object) activity).Handle);
				__args [1] = new JniArgumentValue ((outState == null) ? IntPtr.Zero : ((global::Java.Lang.Object) outState).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_onActivityStarted_Landroid_app_Activity_;
#pragma warning disable 0169
		static Delegate GetOnActivityStarted_Landroid_app_Activity_Handler ()
		{
			if (cb_onActivityStarted_Landroid_app_Activity_ == null)
				cb_onActivityStarted_Landroid_app_Activity_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnActivityStarted_Landroid_app_Activity_);
			return cb_onActivityStarted_Landroid_app_Activity_;
		}

		static void n_OnActivityStarted_Landroid_app_Activity_ (IntPtr jnienv, IntPtr native__this, IntPtr native_activity)
		{
			global::Com.Webtrekk.Webtrekksdk.Utils.ActivityTrackingStatus __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Utils.ActivityTrackingStatus> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity activity = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_activity, JniHandleOwnership.DoNotTransfer);
			__this.OnActivityStarted (activity);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Utils']/class[@name='ActivityTrackingStatus']/method[@name='onActivityStarted' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("onActivityStarted", "(Landroid/app/Activity;)V", "GetOnActivityStarted_Landroid_app_Activity_Handler")]
		public virtual unsafe void OnActivityStarted (global::Android.App.Activity activity)
		{
			const string __id = "onActivityStarted.(Landroid/app/Activity;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((activity == null) ? IntPtr.Zero : ((global::Java.Lang.Object) activity).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_onActivityStopped_Landroid_app_Activity_;
#pragma warning disable 0169
		static Delegate GetOnActivityStopped_Landroid_app_Activity_Handler ()
		{
			if (cb_onActivityStopped_Landroid_app_Activity_ == null)
				cb_onActivityStopped_Landroid_app_Activity_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnActivityStopped_Landroid_app_Activity_);
			return cb_onActivityStopped_Landroid_app_Activity_;
		}

		static void n_OnActivityStopped_Landroid_app_Activity_ (IntPtr jnienv, IntPtr native__this, IntPtr native_activity)
		{
			global::Com.Webtrekk.Webtrekksdk.Utils.ActivityTrackingStatus __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Utils.ActivityTrackingStatus> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity activity = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_activity, JniHandleOwnership.DoNotTransfer);
			__this.OnActivityStopped (activity);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Utils']/class[@name='ActivityTrackingStatus']/method[@name='onActivityStopped' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("onActivityStopped", "(Landroid/app/Activity;)V", "GetOnActivityStopped_Landroid_app_Activity_Handler")]
		public virtual unsafe void OnActivityStopped (global::Android.App.Activity activity)
		{
			const string __id = "onActivityStopped.(Landroid/app/Activity;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((activity == null) ? IntPtr.Zero : ((global::Java.Lang.Object) activity).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
