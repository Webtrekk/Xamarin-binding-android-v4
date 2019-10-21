using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Webtrekk.Webtrekksdk.Configuration {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Configuration']/class[@name='ActivityConfiguration']"
	[global::Android.Runtime.Register ("com/webtrekk/webtrekksdk/Configuration/ActivityConfiguration", DoNotGenerateAcw=true)]
	public partial class ActivityConfiguration : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/webtrekk/webtrekksdk/Configuration/ActivityConfiguration", typeof (ActivityConfiguration));
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

		protected ActivityConfiguration (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Configuration']/class[@name='ActivityConfiguration']/constructor[@name='ActivityConfiguration' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ActivityConfiguration ()
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Configuration']/class[@name='ActivityConfiguration']/constructor[@name='ActivityConfiguration' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='boolean'] and parameter[4][@type='com.webtrekk.webtrekksdk.TrackingParameter'] and parameter[5][@type='com.webtrekk.webtrekksdk.TrackingParameter']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;ZLcom/webtrekk/webtrekksdk/TrackingParameter;Lcom/webtrekk/webtrekksdk/TrackingParameter;)V", "")]
		public unsafe ActivityConfiguration (string className, string mappingName, bool isAutoTrack, global::Com.Webtrekk.Webtrekksdk.TrackingParameter tp, global::Com.Webtrekk.Webtrekksdk.TrackingParameter constTp)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Ljava/lang/String;ZLcom/webtrekk/webtrekksdk/TrackingParameter;Lcom/webtrekk/webtrekksdk/TrackingParameter;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_className = JNIEnv.NewString (className);
			IntPtr native_mappingName = JNIEnv.NewString (mappingName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (native_className);
				__args [1] = new JniArgumentValue (native_mappingName);
				__args [2] = new JniArgumentValue (isAutoTrack);
				__args [3] = new JniArgumentValue ((tp == null) ? IntPtr.Zero : ((global::Java.Lang.Object) tp).Handle);
				__args [4] = new JniArgumentValue ((constTp == null) ? IntPtr.Zero : ((global::Java.Lang.Object) constTp).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_className);
				JNIEnv.DeleteLocalRef (native_mappingName);
			}
		}

		static Delegate cb_getActivityTrackingParameter;
#pragma warning disable 0169
		static Delegate GetGetActivityTrackingParameterHandler ()
		{
			if (cb_getActivityTrackingParameter == null)
				cb_getActivityTrackingParameter = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetActivityTrackingParameter);
			return cb_getActivityTrackingParameter;
		}

		static IntPtr n_GetActivityTrackingParameter (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Webtrekk.Webtrekksdk.Configuration.ActivityConfiguration __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Configuration.ActivityConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ActivityTrackingParameter);
		}
#pragma warning restore 0169

		static Delegate cb_setActivityTrackingParameter_Lcom_webtrekk_webtrekksdk_TrackingParameter_;
#pragma warning disable 0169
		static Delegate GetSetActivityTrackingParameter_Lcom_webtrekk_webtrekksdk_TrackingParameter_Handler ()
		{
			if (cb_setActivityTrackingParameter_Lcom_webtrekk_webtrekksdk_TrackingParameter_ == null)
				cb_setActivityTrackingParameter_Lcom_webtrekk_webtrekksdk_TrackingParameter_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetActivityTrackingParameter_Lcom_webtrekk_webtrekksdk_TrackingParameter_);
			return cb_setActivityTrackingParameter_Lcom_webtrekk_webtrekksdk_TrackingParameter_;
		}

		static void n_SetActivityTrackingParameter_Lcom_webtrekk_webtrekksdk_TrackingParameter_ (IntPtr jnienv, IntPtr native__this, IntPtr native_activityTrackingParameter)
		{
			global::Com.Webtrekk.Webtrekksdk.Configuration.ActivityConfiguration __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Configuration.ActivityConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Webtrekk.Webtrekksdk.TrackingParameter activityTrackingParameter = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.TrackingParameter> (native_activityTrackingParameter, JniHandleOwnership.DoNotTransfer);
			__this.ActivityTrackingParameter = activityTrackingParameter;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Webtrekk.Webtrekksdk.TrackingParameter ActivityTrackingParameter {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Configuration']/class[@name='ActivityConfiguration']/method[@name='getActivityTrackingParameter' and count(parameter)=0]"
			[Register ("getActivityTrackingParameter", "()Lcom/webtrekk/webtrekksdk/TrackingParameter;", "GetGetActivityTrackingParameterHandler")]
			get {
				const string __id = "getActivityTrackingParameter.()Lcom/webtrekk/webtrekksdk/TrackingParameter;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.TrackingParameter> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Configuration']/class[@name='ActivityConfiguration']/method[@name='setActivityTrackingParameter' and count(parameter)=1 and parameter[1][@type='com.webtrekk.webtrekksdk.TrackingParameter']]"
			[Register ("setActivityTrackingParameter", "(Lcom/webtrekk/webtrekksdk/TrackingParameter;)V", "GetSetActivityTrackingParameter_Lcom_webtrekk_webtrekksdk_TrackingParameter_Handler")]
			set {
				const string __id = "setActivityTrackingParameter.(Lcom/webtrekk/webtrekksdk/TrackingParameter;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getClassName;
#pragma warning disable 0169
		static Delegate GetGetClassNameHandler ()
		{
			if (cb_getClassName == null)
				cb_getClassName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetClassName);
			return cb_getClassName;
		}

		static IntPtr n_GetClassName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Webtrekk.Webtrekksdk.Configuration.ActivityConfiguration __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Configuration.ActivityConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ClassName);
		}
#pragma warning restore 0169

		static Delegate cb_setClassName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetClassName_Ljava_lang_String_Handler ()
		{
			if (cb_setClassName_Ljava_lang_String_ == null)
				cb_setClassName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetClassName_Ljava_lang_String_);
			return cb_setClassName_Ljava_lang_String_;
		}

		static void n_SetClassName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_className)
		{
			global::Com.Webtrekk.Webtrekksdk.Configuration.ActivityConfiguration __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Configuration.ActivityConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string className = JNIEnv.GetString (native_className, JniHandleOwnership.DoNotTransfer);
			__this.ClassName = className;
		}
#pragma warning restore 0169

		public virtual unsafe string ClassName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Configuration']/class[@name='ActivityConfiguration']/method[@name='getClassName' and count(parameter)=0]"
			[Register ("getClassName", "()Ljava/lang/String;", "GetGetClassNameHandler")]
			get {
				const string __id = "getClassName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Configuration']/class[@name='ActivityConfiguration']/method[@name='setClassName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setClassName", "(Ljava/lang/String;)V", "GetSetClassName_Ljava_lang_String_Handler")]
			set {
				const string __id = "setClassName.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getConstActivityTrackingParameter;
#pragma warning disable 0169
		static Delegate GetGetConstActivityTrackingParameterHandler ()
		{
			if (cb_getConstActivityTrackingParameter == null)
				cb_getConstActivityTrackingParameter = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetConstActivityTrackingParameter);
			return cb_getConstActivityTrackingParameter;
		}

		static IntPtr n_GetConstActivityTrackingParameter (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Webtrekk.Webtrekksdk.Configuration.ActivityConfiguration __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Configuration.ActivityConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ConstActivityTrackingParameter);
		}
#pragma warning restore 0169

		static Delegate cb_setConstActivityTrackingParameter_Lcom_webtrekk_webtrekksdk_TrackingParameter_;
#pragma warning disable 0169
		static Delegate GetSetConstActivityTrackingParameter_Lcom_webtrekk_webtrekksdk_TrackingParameter_Handler ()
		{
			if (cb_setConstActivityTrackingParameter_Lcom_webtrekk_webtrekksdk_TrackingParameter_ == null)
				cb_setConstActivityTrackingParameter_Lcom_webtrekk_webtrekksdk_TrackingParameter_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetConstActivityTrackingParameter_Lcom_webtrekk_webtrekksdk_TrackingParameter_);
			return cb_setConstActivityTrackingParameter_Lcom_webtrekk_webtrekksdk_TrackingParameter_;
		}

		static void n_SetConstActivityTrackingParameter_Lcom_webtrekk_webtrekksdk_TrackingParameter_ (IntPtr jnienv, IntPtr native__this, IntPtr native_constActivityTrackingParameter)
		{
			global::Com.Webtrekk.Webtrekksdk.Configuration.ActivityConfiguration __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Configuration.ActivityConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Webtrekk.Webtrekksdk.TrackingParameter constActivityTrackingParameter = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.TrackingParameter> (native_constActivityTrackingParameter, JniHandleOwnership.DoNotTransfer);
			__this.ConstActivityTrackingParameter = constActivityTrackingParameter;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Webtrekk.Webtrekksdk.TrackingParameter ConstActivityTrackingParameter {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Configuration']/class[@name='ActivityConfiguration']/method[@name='getConstActivityTrackingParameter' and count(parameter)=0]"
			[Register ("getConstActivityTrackingParameter", "()Lcom/webtrekk/webtrekksdk/TrackingParameter;", "GetGetConstActivityTrackingParameterHandler")]
			get {
				const string __id = "getConstActivityTrackingParameter.()Lcom/webtrekk/webtrekksdk/TrackingParameter;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.TrackingParameter> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Configuration']/class[@name='ActivityConfiguration']/method[@name='setConstActivityTrackingParameter' and count(parameter)=1 and parameter[1][@type='com.webtrekk.webtrekksdk.TrackingParameter']]"
			[Register ("setConstActivityTrackingParameter", "(Lcom/webtrekk/webtrekksdk/TrackingParameter;)V", "GetSetConstActivityTrackingParameter_Lcom_webtrekk_webtrekksdk_TrackingParameter_Handler")]
			set {
				const string __id = "setConstActivityTrackingParameter.(Lcom/webtrekk/webtrekksdk/TrackingParameter;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_isAutoTrack;
#pragma warning disable 0169
		static Delegate GetIsAutoTrackHandler ()
		{
			if (cb_isAutoTrack == null)
				cb_isAutoTrack = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsAutoTrack);
			return cb_isAutoTrack;
		}

		static bool n_IsAutoTrack (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Webtrekk.Webtrekksdk.Configuration.ActivityConfiguration __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Configuration.ActivityConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsAutoTrack;
		}
#pragma warning restore 0169

		static Delegate cb_setIsAutoTrack_Z;
#pragma warning disable 0169
		static Delegate GetSetIsAutoTrack_ZHandler ()
		{
			if (cb_setIsAutoTrack_Z == null)
				cb_setIsAutoTrack_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetIsAutoTrack_Z);
			return cb_setIsAutoTrack_Z;
		}

		static void n_SetIsAutoTrack_Z (IntPtr jnienv, IntPtr native__this, bool isAutoTrack)
		{
			global::Com.Webtrekk.Webtrekksdk.Configuration.ActivityConfiguration __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Configuration.ActivityConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.IsAutoTrack = isAutoTrack;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsAutoTrack {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Configuration']/class[@name='ActivityConfiguration']/method[@name='isAutoTrack' and count(parameter)=0]"
			[Register ("isAutoTrack", "()Z", "GetIsAutoTrackHandler")]
			get {
				const string __id = "isAutoTrack.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Configuration']/class[@name='ActivityConfiguration']/method[@name='setIsAutoTrack' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setIsAutoTrack", "(Z)V", "GetSetIsAutoTrack_ZHandler")]
			set {
				const string __id = "setIsAutoTrack.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getMappingName;
#pragma warning disable 0169
		static Delegate GetGetMappingNameHandler ()
		{
			if (cb_getMappingName == null)
				cb_getMappingName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMappingName);
			return cb_getMappingName;
		}

		static IntPtr n_GetMappingName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Webtrekk.Webtrekksdk.Configuration.ActivityConfiguration __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Configuration.ActivityConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.MappingName);
		}
#pragma warning restore 0169

		static Delegate cb_setMappingName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetMappingName_Ljava_lang_String_Handler ()
		{
			if (cb_setMappingName_Ljava_lang_String_ == null)
				cb_setMappingName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMappingName_Ljava_lang_String_);
			return cb_setMappingName_Ljava_lang_String_;
		}

		static void n_SetMappingName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_mappingName)
		{
			global::Com.Webtrekk.Webtrekksdk.Configuration.ActivityConfiguration __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Configuration.ActivityConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string mappingName = JNIEnv.GetString (native_mappingName, JniHandleOwnership.DoNotTransfer);
			__this.MappingName = mappingName;
		}
#pragma warning restore 0169

		public virtual unsafe string MappingName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Configuration']/class[@name='ActivityConfiguration']/method[@name='getMappingName' and count(parameter)=0]"
			[Register ("getMappingName", "()Ljava/lang/String;", "GetGetMappingNameHandler")]
			get {
				const string __id = "getMappingName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Configuration']/class[@name='ActivityConfiguration']/method[@name='setMappingName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setMappingName", "(Ljava/lang/String;)V", "GetSetMappingName_Ljava_lang_String_Handler")]
			set {
				const string __id = "setMappingName.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_resetOverridenPageURL;
#pragma warning disable 0169
		static Delegate GetResetOverridenPageURLHandler ()
		{
			if (cb_resetOverridenPageURL == null)
				cb_resetOverridenPageURL = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ResetOverridenPageURL);
			return cb_resetOverridenPageURL;
		}

		static void n_ResetOverridenPageURL (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Webtrekk.Webtrekksdk.Configuration.ActivityConfiguration __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Configuration.ActivityConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ResetOverridenPageURL ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Configuration']/class[@name='ActivityConfiguration']/method[@name='resetOverridenPageURL' and count(parameter)=0]"
		[Register ("resetOverridenPageURL", "()V", "GetResetOverridenPageURLHandler")]
		public virtual unsafe void ResetOverridenPageURL ()
		{
			const string __id = "resetOverridenPageURL.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_setOverridenPageURL_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetOverridenPageURL_Ljava_lang_String_Handler ()
		{
			if (cb_setOverridenPageURL_Ljava_lang_String_ == null)
				cb_setOverridenPageURL_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOverridenPageURL_Ljava_lang_String_);
			return cb_setOverridenPageURL_Ljava_lang_String_;
		}

		static void n_SetOverridenPageURL_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_url)
		{
			global::Com.Webtrekk.Webtrekksdk.Configuration.ActivityConfiguration __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Configuration.ActivityConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string url = JNIEnv.GetString (native_url, JniHandleOwnership.DoNotTransfer);
			__this.SetOverridenPageURL (url);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Configuration']/class[@name='ActivityConfiguration']/method[@name='setOverridenPageURL' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setOverridenPageURL", "(Ljava/lang/String;)V", "GetSetOverridenPageURL_Ljava_lang_String_Handler")]
		public virtual unsafe void SetOverridenPageURL (string url)
		{
			const string __id = "setOverridenPageURL.(Ljava/lang/String;)V";
			IntPtr native_url = JNIEnv.NewString (url);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_url);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_url);
			}
		}

	}
}
