using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Webtrekk.Webtrekksdk.Request {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Request']/class[@name='RequestFactory']"
	[global::Android.Runtime.Register ("com/webtrekk/webtrekksdk/Request/RequestFactory", DoNotGenerateAcw=true)]
	public partial class RequestFactory : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Request']/class[@name='RequestFactory']/field[@name='PREFERENCE_KEY_IS_SAMPLING']"
		[Register ("PREFERENCE_KEY_IS_SAMPLING")]
		public const string PreferenceKeyIsSampling = (string) "issampling";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Request']/class[@name='RequestFactory']/field[@name='PREFERENCE_KEY_OPTED_OUT']"
		[Register ("PREFERENCE_KEY_OPTED_OUT")]
		public const string PreferenceKeyOptedOut = (string) "optedOut";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Request']/class[@name='RequestFactory']/field[@name='PREFERENCE_KEY_SAMPLING']"
		[Register ("PREFERENCE_KEY_SAMPLING")]
		public const string PreferenceKeySampling = (string) "sampling";
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/webtrekk/webtrekksdk/Request/RequestFactory", typeof (RequestFactory));
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

		protected RequestFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Request']/class[@name='RequestFactory']/constructor[@name='RequestFactory' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe RequestFactory ()
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

		static Delegate cb_getAutoCustomParameter;
#pragma warning disable 0169
		static Delegate GetGetAutoCustomParameterHandler ()
		{
			if (cb_getAutoCustomParameter == null)
				cb_getAutoCustomParameter = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAutoCustomParameter);
			return cb_getAutoCustomParameter;
		}

		static IntPtr n_GetAutoCustomParameter (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Webtrekk.Webtrekksdk.Request.RequestFactory __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Request.RequestFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (__this.AutoCustomParameter);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IDictionary<string, string> AutoCustomParameter {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Request']/class[@name='RequestFactory']/method[@name='getAutoCustomParameter' and count(parameter)=0]"
			[Register ("getAutoCustomParameter", "()Ljava/util/Map;", "GetGetAutoCustomParameterHandler")]
			get {
				const string __id = "getAutoCustomParameter.()Ljava/util/Map;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getConstGlobalTrackingParameter;
#pragma warning disable 0169
		static Delegate GetGetConstGlobalTrackingParameterHandler ()
		{
			if (cb_getConstGlobalTrackingParameter == null)
				cb_getConstGlobalTrackingParameter = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetConstGlobalTrackingParameter);
			return cb_getConstGlobalTrackingParameter;
		}

		static IntPtr n_GetConstGlobalTrackingParameter (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Webtrekk.Webtrekksdk.Request.RequestFactory __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Request.RequestFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ConstGlobalTrackingParameter);
		}
#pragma warning restore 0169

		static Delegate cb_setConstGlobalTrackingParameter_Lcom_webtrekk_webtrekksdk_TrackingParameter_;
#pragma warning disable 0169
		static Delegate GetSetConstGlobalTrackingParameter_Lcom_webtrekk_webtrekksdk_TrackingParameter_Handler ()
		{
			if (cb_setConstGlobalTrackingParameter_Lcom_webtrekk_webtrekksdk_TrackingParameter_ == null)
				cb_setConstGlobalTrackingParameter_Lcom_webtrekk_webtrekksdk_TrackingParameter_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetConstGlobalTrackingParameter_Lcom_webtrekk_webtrekksdk_TrackingParameter_);
			return cb_setConstGlobalTrackingParameter_Lcom_webtrekk_webtrekksdk_TrackingParameter_;
		}

		static void n_SetConstGlobalTrackingParameter_Lcom_webtrekk_webtrekksdk_TrackingParameter_ (IntPtr jnienv, IntPtr native__this, IntPtr native_constGlobalTrackingParameter)
		{
			global::Com.Webtrekk.Webtrekksdk.Request.RequestFactory __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Request.RequestFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Webtrekk.Webtrekksdk.TrackingParameter constGlobalTrackingParameter = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.TrackingParameter> (native_constGlobalTrackingParameter, JniHandleOwnership.DoNotTransfer);
			__this.ConstGlobalTrackingParameter = constGlobalTrackingParameter;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Webtrekk.Webtrekksdk.TrackingParameter ConstGlobalTrackingParameter {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Request']/class[@name='RequestFactory']/method[@name='getConstGlobalTrackingParameter' and count(parameter)=0]"
			[Register ("getConstGlobalTrackingParameter", "()Lcom/webtrekk/webtrekksdk/TrackingParameter;", "GetGetConstGlobalTrackingParameterHandler")]
			get {
				const string __id = "getConstGlobalTrackingParameter.()Lcom/webtrekk/webtrekksdk/TrackingParameter;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.TrackingParameter> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Request']/class[@name='RequestFactory']/method[@name='setConstGlobalTrackingParameter' and count(parameter)=1 and parameter[1][@type='com.webtrekk.webtrekksdk.TrackingParameter']]"
			[Register ("setConstGlobalTrackingParameter", "(Lcom/webtrekk/webtrekksdk/TrackingParameter;)V", "GetSetConstGlobalTrackingParameter_Lcom_webtrekk_webtrekksdk_TrackingParameter_Handler")]
			set {
				const string __id = "setConstGlobalTrackingParameter.(Lcom/webtrekk/webtrekksdk/TrackingParameter;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getCurrentActivityName;
#pragma warning disable 0169
		static Delegate GetGetCurrentActivityNameHandler ()
		{
			if (cb_getCurrentActivityName == null)
				cb_getCurrentActivityName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCurrentActivityName);
			return cb_getCurrentActivityName;
		}

		static IntPtr n_GetCurrentActivityName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Webtrekk.Webtrekksdk.Request.RequestFactory __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Request.RequestFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CurrentActivityName);
		}
#pragma warning restore 0169

		static Delegate cb_setCurrentActivityName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetCurrentActivityName_Ljava_lang_String_Handler ()
		{
			if (cb_setCurrentActivityName_Ljava_lang_String_ == null)
				cb_setCurrentActivityName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCurrentActivityName_Ljava_lang_String_);
			return cb_setCurrentActivityName_Ljava_lang_String_;
		}

		static void n_SetCurrentActivityName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_currentActivityName)
		{
			global::Com.Webtrekk.Webtrekksdk.Request.RequestFactory __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Request.RequestFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string currentActivityName = JNIEnv.GetString (native_currentActivityName, JniHandleOwnership.DoNotTransfer);
			__this.CurrentActivityName = currentActivityName;
		}
#pragma warning restore 0169

		public virtual unsafe string CurrentActivityName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Request']/class[@name='RequestFactory']/method[@name='getCurrentActivityName' and count(parameter)=0]"
			[Register ("getCurrentActivityName", "()Ljava/lang/String;", "GetGetCurrentActivityNameHandler")]
			get {
				const string __id = "getCurrentActivityName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Request']/class[@name='RequestFactory']/method[@name='setCurrentActivityName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setCurrentActivityName", "(Ljava/lang/String;)V", "GetSetCurrentActivityName_Ljava_lang_String_Handler")]
			set {
				const string __id = "setCurrentActivityName.(Ljava/lang/String;)V";
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

		static Delegate cb_getCustomParameter;
#pragma warning disable 0169
		static Delegate GetGetCustomParameterHandler ()
		{
			if (cb_getCustomParameter == null)
				cb_getCustomParameter = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCustomParameter);
			return cb_getCustomParameter;
		}

		static IntPtr n_GetCustomParameter (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Webtrekk.Webtrekksdk.Request.RequestFactory __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Request.RequestFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (__this.CustomParameter);
		}
#pragma warning restore 0169

		static Delegate cb_setCustomParameter_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetSetCustomParameter_Ljava_util_Map_Handler ()
		{
			if (cb_setCustomParameter_Ljava_util_Map_ == null)
				cb_setCustomParameter_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCustomParameter_Ljava_util_Map_);
			return cb_setCustomParameter_Ljava_util_Map_;
		}

		static void n_SetCustomParameter_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_customParameter)
		{
			global::Com.Webtrekk.Webtrekksdk.Request.RequestFactory __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Request.RequestFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var customParameter = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_customParameter, JniHandleOwnership.DoNotTransfer);
			__this.CustomParameter = customParameter;
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IDictionary<string, string> CustomParameter {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Request']/class[@name='RequestFactory']/method[@name='getCustomParameter' and count(parameter)=0]"
			[Register ("getCustomParameter", "()Ljava/util/Map;", "GetGetCustomParameterHandler")]
			get {
				const string __id = "getCustomParameter.()Ljava/util/Map;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Request']/class[@name='RequestFactory']/method[@name='setCustomParameter' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
			[Register ("setCustomParameter", "(Ljava/util/Map;)V", "GetSetCustomParameter_Ljava_util_Map_Handler")]
			set {
				const string __id = "setCustomParameter.(Ljava/util/Map;)V";
				IntPtr native_value = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getGlobalTrackingParameter;
#pragma warning disable 0169
		static Delegate GetGetGlobalTrackingParameterHandler ()
		{
			if (cb_getGlobalTrackingParameter == null)
				cb_getGlobalTrackingParameter = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetGlobalTrackingParameter);
			return cb_getGlobalTrackingParameter;
		}

		static IntPtr n_GetGlobalTrackingParameter (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Webtrekk.Webtrekksdk.Request.RequestFactory __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Request.RequestFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GlobalTrackingParameter);
		}
#pragma warning restore 0169

		static Delegate cb_setGlobalTrackingParameter_Lcom_webtrekk_webtrekksdk_TrackingParameter_;
#pragma warning disable 0169
		static Delegate GetSetGlobalTrackingParameter_Lcom_webtrekk_webtrekksdk_TrackingParameter_Handler ()
		{
			if (cb_setGlobalTrackingParameter_Lcom_webtrekk_webtrekksdk_TrackingParameter_ == null)
				cb_setGlobalTrackingParameter_Lcom_webtrekk_webtrekksdk_TrackingParameter_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetGlobalTrackingParameter_Lcom_webtrekk_webtrekksdk_TrackingParameter_);
			return cb_setGlobalTrackingParameter_Lcom_webtrekk_webtrekksdk_TrackingParameter_;
		}

		static void n_SetGlobalTrackingParameter_Lcom_webtrekk_webtrekksdk_TrackingParameter_ (IntPtr jnienv, IntPtr native__this, IntPtr native_globalTrackingParameter)
		{
			global::Com.Webtrekk.Webtrekksdk.Request.RequestFactory __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Request.RequestFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Webtrekk.Webtrekksdk.TrackingParameter globalTrackingParameter = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.TrackingParameter> (native_globalTrackingParameter, JniHandleOwnership.DoNotTransfer);
			__this.GlobalTrackingParameter = globalTrackingParameter;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Webtrekk.Webtrekksdk.TrackingParameter GlobalTrackingParameter {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Request']/class[@name='RequestFactory']/method[@name='getGlobalTrackingParameter' and count(parameter)=0]"
			[Register ("getGlobalTrackingParameter", "()Lcom/webtrekk/webtrekksdk/TrackingParameter;", "GetGetGlobalTrackingParameterHandler")]
			get {
				const string __id = "getGlobalTrackingParameter.()Lcom/webtrekk/webtrekksdk/TrackingParameter;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.TrackingParameter> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Request']/class[@name='RequestFactory']/method[@name='setGlobalTrackingParameter' and count(parameter)=1 and parameter[1][@type='com.webtrekk.webtrekksdk.TrackingParameter']]"
			[Register ("setGlobalTrackingParameter", "(Lcom/webtrekk/webtrekksdk/TrackingParameter;)V", "GetSetGlobalTrackingParameter_Lcom_webtrekk_webtrekksdk_TrackingParameter_Handler")]
			set {
				const string __id = "setGlobalTrackingParameter.(Lcom/webtrekk/webtrekksdk/TrackingParameter;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getInternalParameter;
#pragma warning disable 0169
		static Delegate GetGetInternalParameterHandler ()
		{
			if (cb_getInternalParameter == null)
				cb_getInternalParameter = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetInternalParameter);
			return cb_getInternalParameter;
		}

		static IntPtr n_GetInternalParameter (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Webtrekk.Webtrekksdk.Request.RequestFactory __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Request.RequestFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.InternalParameter);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Webtrekk.Webtrekksdk.TrackingParameter InternalParameter {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Request']/class[@name='RequestFactory']/method[@name='getInternalParameter' and count(parameter)=0]"
			[Register ("getInternalParameter", "()Lcom/webtrekk/webtrekksdk/TrackingParameter;", "GetGetInternalParameterHandler")]
			get {
				const string __id = "getInternalParameter.()Lcom/webtrekk/webtrekksdk/TrackingParameter;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.TrackingParameter> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isOptout;
#pragma warning disable 0169
		static Delegate GetIsOptoutHandler ()
		{
			if (cb_isOptout == null)
				cb_isOptout = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsOptout);
			return cb_isOptout;
		}

		static bool n_IsOptout (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Webtrekk.Webtrekksdk.Request.RequestFactory __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Request.RequestFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsOptout;
		}
#pragma warning restore 0169

		static Delegate cb_setIsOptout_Z;
#pragma warning disable 0169
		static Delegate GetSetIsOptout_ZHandler ()
		{
			if (cb_setIsOptout_Z == null)
				cb_setIsOptout_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetIsOptout_Z);
			return cb_setIsOptout_Z;
		}

		static void n_SetIsOptout_Z (IntPtr jnienv, IntPtr native__this, bool isOptout)
		{
			global::Com.Webtrekk.Webtrekksdk.Request.RequestFactory __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Request.RequestFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.IsOptout = isOptout;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsOptout {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Request']/class[@name='RequestFactory']/method[@name='isOptout' and count(parameter)=0]"
			[Register ("isOptout", "()Z", "GetIsOptoutHandler")]
			get {
				const string __id = "isOptout.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Request']/class[@name='RequestFactory']/method[@name='setIsOptout' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setIsOptout", "(Z)V", "GetSetIsOptout_ZHandler")]
			set {
				const string __id = "setIsOptout.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_isSampling;
#pragma warning disable 0169
		static Delegate GetIsSamplingHandler ()
		{
			if (cb_isSampling == null)
				cb_isSampling = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsSampling);
			return cb_isSampling;
		}

		static bool n_IsSampling (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Webtrekk.Webtrekksdk.Request.RequestFactory __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Request.RequestFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsSampling;
		}
#pragma warning restore 0169

		static Delegate cb_setIsSampling_Z;
#pragma warning disable 0169
		static Delegate GetSetIsSampling_ZHandler ()
		{
			if (cb_setIsSampling_Z == null)
				cb_setIsSampling_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetIsSampling_Z);
			return cb_setIsSampling_Z;
		}

		static void n_SetIsSampling_Z (IntPtr jnienv, IntPtr native__this, bool isSampling)
		{
			global::Com.Webtrekk.Webtrekksdk.Request.RequestFactory __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Request.RequestFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.IsSampling = isSampling;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsSampling {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Request']/class[@name='RequestFactory']/method[@name='isSampling' and count(parameter)=0]"
			[Register ("isSampling", "()Z", "GetIsSamplingHandler")]
			get {
				const string __id = "isSampling.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Request']/class[@name='RequestFactory']/method[@name='setIsSampling' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setIsSampling", "(Z)V", "GetSetIsSampling_ZHandler")]
			set {
				const string __id = "setIsSampling.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getRequestUrlStore;
#pragma warning disable 0169
		static Delegate GetGetRequestUrlStoreHandler ()
		{
			if (cb_getRequestUrlStore == null)
				cb_getRequestUrlStore = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRequestUrlStore);
			return cb_getRequestUrlStore;
		}

		static IntPtr n_GetRequestUrlStore (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Webtrekk.Webtrekksdk.Request.RequestFactory __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Request.RequestFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RequestUrlStore);
		}
#pragma warning restore 0169

		static Delegate cb_setRequestUrlStore_Lcom_webtrekk_webtrekksdk_Request_RequestUrlStore_;
#pragma warning disable 0169
		static Delegate GetSetRequestUrlStore_Lcom_webtrekk_webtrekksdk_Request_RequestUrlStore_Handler ()
		{
			if (cb_setRequestUrlStore_Lcom_webtrekk_webtrekksdk_Request_RequestUrlStore_ == null)
				cb_setRequestUrlStore_Lcom_webtrekk_webtrekksdk_Request_RequestUrlStore_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetRequestUrlStore_Lcom_webtrekk_webtrekksdk_Request_RequestUrlStore_);
			return cb_setRequestUrlStore_Lcom_webtrekk_webtrekksdk_Request_RequestUrlStore_;
		}

		static void n_SetRequestUrlStore_Lcom_webtrekk_webtrekksdk_Request_RequestUrlStore_ (IntPtr jnienv, IntPtr native__this, IntPtr native_requestUrlStore)
		{
			global::Com.Webtrekk.Webtrekksdk.Request.RequestFactory __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Request.RequestFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Webtrekk.Webtrekksdk.Request.RequestUrlStore requestUrlStore = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Request.RequestUrlStore> (native_requestUrlStore, JniHandleOwnership.DoNotTransfer);
			__this.RequestUrlStore = requestUrlStore;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Webtrekk.Webtrekksdk.Request.RequestUrlStore RequestUrlStore {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Request']/class[@name='RequestFactory']/method[@name='getRequestUrlStore' and count(parameter)=0]"
			[Register ("getRequestUrlStore", "()Lcom/webtrekk/webtrekksdk/Request/RequestUrlStore;", "GetGetRequestUrlStoreHandler")]
			get {
				const string __id = "getRequestUrlStore.()Lcom/webtrekk/webtrekksdk/Request/RequestUrlStore;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Request.RequestUrlStore> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Request']/class[@name='RequestFactory']/method[@name='setRequestUrlStore' and count(parameter)=1 and parameter[1][@type='com.webtrekk.webtrekksdk.Request.RequestUrlStore']]"
			[Register ("setRequestUrlStore", "(Lcom/webtrekk/webtrekksdk/Request/RequestUrlStore;)V", "GetSetRequestUrlStore_Lcom_webtrekk_webtrekksdk_Request_RequestUrlStore_Handler")]
			set {
				const string __id = "setRequestUrlStore.(Lcom/webtrekk/webtrekksdk/Request/RequestUrlStore;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getTrackingConfiguration;
#pragma warning disable 0169
		static Delegate GetGetTrackingConfigurationHandler ()
		{
			if (cb_getTrackingConfiguration == null)
				cb_getTrackingConfiguration = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTrackingConfiguration);
			return cb_getTrackingConfiguration;
		}

		static IntPtr n_GetTrackingConfiguration (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Webtrekk.Webtrekksdk.Request.RequestFactory __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Request.RequestFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TrackingConfiguration);
		}
#pragma warning restore 0169

		static Delegate cb_setTrackingConfiguration_Lcom_webtrekk_webtrekksdk_Configuration_TrackingConfiguration_;
#pragma warning disable 0169
		static Delegate GetSetTrackingConfiguration_Lcom_webtrekk_webtrekksdk_Configuration_TrackingConfiguration_Handler ()
		{
			if (cb_setTrackingConfiguration_Lcom_webtrekk_webtrekksdk_Configuration_TrackingConfiguration_ == null)
				cb_setTrackingConfiguration_Lcom_webtrekk_webtrekksdk_Configuration_TrackingConfiguration_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTrackingConfiguration_Lcom_webtrekk_webtrekksdk_Configuration_TrackingConfiguration_);
			return cb_setTrackingConfiguration_Lcom_webtrekk_webtrekksdk_Configuration_TrackingConfiguration_;
		}

		static void n_SetTrackingConfiguration_Lcom_webtrekk_webtrekksdk_Configuration_TrackingConfiguration_ (IntPtr jnienv, IntPtr native__this, IntPtr native_trackingConfiguration)
		{
			global::Com.Webtrekk.Webtrekksdk.Request.RequestFactory __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Request.RequestFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Webtrekk.Webtrekksdk.Configuration.TrackingConfiguration trackingConfiguration = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Configuration.TrackingConfiguration> (native_trackingConfiguration, JniHandleOwnership.DoNotTransfer);
			__this.TrackingConfiguration = trackingConfiguration;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Webtrekk.Webtrekksdk.Configuration.TrackingConfiguration TrackingConfiguration {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Request']/class[@name='RequestFactory']/method[@name='getTrackingConfiguration' and count(parameter)=0]"
			[Register ("getTrackingConfiguration", "()Lcom/webtrekk/webtrekksdk/Configuration/TrackingConfiguration;", "GetGetTrackingConfigurationHandler")]
			get {
				const string __id = "getTrackingConfiguration.()Lcom/webtrekk/webtrekksdk/Configuration/TrackingConfiguration;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Configuration.TrackingConfiguration> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Request']/class[@name='RequestFactory']/method[@name='setTrackingConfiguration' and count(parameter)=1 and parameter[1][@type='com.webtrekk.webtrekksdk.Configuration.TrackingConfiguration']]"
			[Register ("setTrackingConfiguration", "(Lcom/webtrekk/webtrekksdk/Configuration/TrackingConfiguration;)V", "GetSetTrackingConfiguration_Lcom_webtrekk_webtrekksdk_Configuration_TrackingConfiguration_Handler")]
			set {
				const string __id = "setTrackingConfiguration.(Lcom/webtrekk/webtrekksdk/Configuration/TrackingConfiguration;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getWebtrekkParameter;
#pragma warning disable 0169
		static Delegate GetGetWebtrekkParameterHandler ()
		{
			if (cb_getWebtrekkParameter == null)
				cb_getWebtrekkParameter = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetWebtrekkParameter);
			return cb_getWebtrekkParameter;
		}

		static IntPtr n_GetWebtrekkParameter (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Webtrekk.Webtrekksdk.Request.RequestFactory __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Request.RequestFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter, string>.ToLocalJniHandle (__this.WebtrekkParameter);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IDictionary<global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter, string> WebtrekkParameter {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Request']/class[@name='RequestFactory']/method[@name='getWebtrekkParameter' and count(parameter)=0]"
			[Register ("getWebtrekkParameter", "()Ljava/util/HashMap;", "GetGetWebtrekkParameterHandler")]
			get {
				const string __id = "getWebtrekkParameter.()Ljava/util/HashMap;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaDictionary<global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter, string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_addRequest_Lcom_webtrekk_webtrekksdk_Request_TrackingRequest_;
#pragma warning disable 0169
		static Delegate GetAddRequest_Lcom_webtrekk_webtrekksdk_Request_TrackingRequest_Handler ()
		{
			if (cb_addRequest_Lcom_webtrekk_webtrekksdk_Request_TrackingRequest_ == null)
				cb_addRequest_Lcom_webtrekk_webtrekksdk_Request_TrackingRequest_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddRequest_Lcom_webtrekk_webtrekksdk_Request_TrackingRequest_);
			return cb_addRequest_Lcom_webtrekk_webtrekksdk_Request_TrackingRequest_;
		}

		static void n_AddRequest_Lcom_webtrekk_webtrekksdk_Request_TrackingRequest_ (IntPtr jnienv, IntPtr native__this, IntPtr native_request)
		{
			global::Com.Webtrekk.Webtrekksdk.Request.RequestFactory __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Request.RequestFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Webtrekk.Webtrekksdk.Request.TrackingRequest request = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Request.TrackingRequest> (native_request, JniHandleOwnership.DoNotTransfer);
			__this.AddRequest (request);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Request']/class[@name='RequestFactory']/method[@name='addRequest' and count(parameter)=1 and parameter[1][@type='com.webtrekk.webtrekksdk.Request.TrackingRequest']]"
		[Register ("addRequest", "(Lcom/webtrekk/webtrekksdk/Request/TrackingRequest;)V", "GetAddRequest_Lcom_webtrekk_webtrekksdk_Request_TrackingRequest_Handler")]
		public virtual unsafe void AddRequest (global::Com.Webtrekk.Webtrekksdk.Request.TrackingRequest request)
		{
			const string __id = "addRequest.(Lcom/webtrekk/webtrekksdk/Request/TrackingRequest;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((request == null) ? IntPtr.Zero : ((global::Java.Lang.Object) request).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_createTrackingRequest_Lcom_webtrekk_webtrekksdk_TrackingParameter_;
#pragma warning disable 0169
		static Delegate GetCreateTrackingRequest_Lcom_webtrekk_webtrekksdk_TrackingParameter_Handler ()
		{
			if (cb_createTrackingRequest_Lcom_webtrekk_webtrekksdk_TrackingParameter_ == null)
				cb_createTrackingRequest_Lcom_webtrekk_webtrekksdk_TrackingParameter_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_CreateTrackingRequest_Lcom_webtrekk_webtrekksdk_TrackingParameter_);
			return cb_createTrackingRequest_Lcom_webtrekk_webtrekksdk_TrackingParameter_;
		}

		static IntPtr n_CreateTrackingRequest_Lcom_webtrekk_webtrekksdk_TrackingParameter_ (IntPtr jnienv, IntPtr native__this, IntPtr native_tp)
		{
			global::Com.Webtrekk.Webtrekksdk.Request.RequestFactory __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Request.RequestFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Webtrekk.Webtrekksdk.TrackingParameter tp = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.TrackingParameter> (native_tp, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateTrackingRequest (tp));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Request']/class[@name='RequestFactory']/method[@name='createTrackingRequest' and count(parameter)=1 and parameter[1][@type='com.webtrekk.webtrekksdk.TrackingParameter']]"
		[Register ("createTrackingRequest", "(Lcom/webtrekk/webtrekksdk/TrackingParameter;)Lcom/webtrekk/webtrekksdk/Request/TrackingRequest;", "GetCreateTrackingRequest_Lcom_webtrekk_webtrekksdk_TrackingParameter_Handler")]
		public virtual unsafe global::Com.Webtrekk.Webtrekksdk.Request.TrackingRequest CreateTrackingRequest (global::Com.Webtrekk.Webtrekksdk.TrackingParameter tp)
		{
			const string __id = "createTrackingRequest.(Lcom/webtrekk/webtrekksdk/TrackingParameter;)Lcom/webtrekk/webtrekksdk/Request/TrackingRequest;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((tp == null) ? IntPtr.Zero : ((global::Java.Lang.Object) tp).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Request.TrackingRequest> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			global::Com.Webtrekk.Webtrekksdk.Request.RequestFactory __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Request.RequestFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Flush ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Request']/class[@name='RequestFactory']/method[@name='flush' and count(parameter)=0]"
		[Register ("flush", "()V", "GetFlushHandler")]
		public virtual unsafe void Flush ()
		{
			const string __id = "flush.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_forceNewSession;
#pragma warning disable 0169
		static Delegate GetForceNewSessionHandler ()
		{
			if (cb_forceNewSession == null)
				cb_forceNewSession = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ForceNewSession);
			return cb_forceNewSession;
		}

		static void n_ForceNewSession (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Webtrekk.Webtrekksdk.Request.RequestFactory __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Request.RequestFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ForceNewSession ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Request']/class[@name='RequestFactory']/method[@name='forceNewSession' and count(parameter)=0]"
		[Register ("forceNewSession", "()V", "GetForceNewSessionHandler")]
		public virtual unsafe void ForceNewSession ()
		{
			const string __id = "forceNewSession.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_init_Landroid_content_Context_Lcom_webtrekk_webtrekksdk_Configuration_TrackingConfiguration_Lcom_webtrekk_webtrekksdk_Webtrekk_;
#pragma warning disable 0169
		static Delegate GetInit_Landroid_content_Context_Lcom_webtrekk_webtrekksdk_Configuration_TrackingConfiguration_Lcom_webtrekk_webtrekksdk_Webtrekk_Handler ()
		{
			if (cb_init_Landroid_content_Context_Lcom_webtrekk_webtrekksdk_Configuration_TrackingConfiguration_Lcom_webtrekk_webtrekksdk_Webtrekk_ == null)
				cb_init_Landroid_content_Context_Lcom_webtrekk_webtrekksdk_Configuration_TrackingConfiguration_Lcom_webtrekk_webtrekksdk_Webtrekk_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Init_Landroid_content_Context_Lcom_webtrekk_webtrekksdk_Configuration_TrackingConfiguration_Lcom_webtrekk_webtrekksdk_Webtrekk_);
			return cb_init_Landroid_content_Context_Lcom_webtrekk_webtrekksdk_Configuration_TrackingConfiguration_Lcom_webtrekk_webtrekksdk_Webtrekk_;
		}

		static void n_Init_Landroid_content_Context_Lcom_webtrekk_webtrekksdk_Configuration_TrackingConfiguration_Lcom_webtrekk_webtrekksdk_Webtrekk_ (IntPtr jnienv, IntPtr native__this, IntPtr native_context, IntPtr native_trackingConfiguration, IntPtr native_wt)
		{
			global::Com.Webtrekk.Webtrekksdk.Request.RequestFactory __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Request.RequestFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
			global::Com.Webtrekk.Webtrekksdk.Configuration.TrackingConfiguration trackingConfiguration = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Configuration.TrackingConfiguration> (native_trackingConfiguration, JniHandleOwnership.DoNotTransfer);
			global::Com.Webtrekk.Webtrekksdk.Webtrekk wt = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Webtrekk> (native_wt, JniHandleOwnership.DoNotTransfer);
			__this.Init (context, trackingConfiguration, wt);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Request']/class[@name='RequestFactory']/method[@name='init' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.webtrekk.webtrekksdk.Configuration.TrackingConfiguration'] and parameter[3][@type='com.webtrekk.webtrekksdk.Webtrekk']]"
		[Register ("init", "(Landroid/content/Context;Lcom/webtrekk/webtrekksdk/Configuration/TrackingConfiguration;Lcom/webtrekk/webtrekksdk/Webtrekk;)V", "GetInit_Landroid_content_Context_Lcom_webtrekk_webtrekksdk_Configuration_TrackingConfiguration_Lcom_webtrekk_webtrekksdk_Webtrekk_Handler")]
		public virtual unsafe void Init (global::Android.Content.Context context, global::Com.Webtrekk.Webtrekksdk.Configuration.TrackingConfiguration trackingConfiguration, global::Com.Webtrekk.Webtrekksdk.Webtrekk wt)
		{
			const string __id = "init.(Landroid/content/Context;Lcom/webtrekk/webtrekksdk/Configuration/TrackingConfiguration;Lcom/webtrekk/webtrekksdk/Webtrekk;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((trackingConfiguration == null) ? IntPtr.Zero : ((global::Java.Lang.Object) trackingConfiguration).Handle);
				__args [2] = new JniArgumentValue ((wt == null) ? IntPtr.Zero : ((global::Java.Lang.Object) wt).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_init_Landroid_content_Context_Lcom_webtrekk_webtrekksdk_Configuration_TrackingConfiguration_Lcom_webtrekk_webtrekksdk_Webtrekk_Ljava_util_Set_;
#pragma warning disable 0169
		static Delegate GetInit_Landroid_content_Context_Lcom_webtrekk_webtrekksdk_Configuration_TrackingConfiguration_Lcom_webtrekk_webtrekksdk_Webtrekk_Ljava_util_Set_Handler ()
		{
			if (cb_init_Landroid_content_Context_Lcom_webtrekk_webtrekksdk_Configuration_TrackingConfiguration_Lcom_webtrekk_webtrekksdk_Webtrekk_Ljava_util_Set_ == null)
				cb_init_Landroid_content_Context_Lcom_webtrekk_webtrekksdk_Configuration_TrackingConfiguration_Lcom_webtrekk_webtrekksdk_Webtrekk_Ljava_util_Set_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Init_Landroid_content_Context_Lcom_webtrekk_webtrekksdk_Configuration_TrackingConfiguration_Lcom_webtrekk_webtrekksdk_Webtrekk_Ljava_util_Set_);
			return cb_init_Landroid_content_Context_Lcom_webtrekk_webtrekksdk_Configuration_TrackingConfiguration_Lcom_webtrekk_webtrekksdk_Webtrekk_Ljava_util_Set_;
		}

		static void n_Init_Landroid_content_Context_Lcom_webtrekk_webtrekksdk_Configuration_TrackingConfiguration_Lcom_webtrekk_webtrekksdk_Webtrekk_Ljava_util_Set_ (IntPtr jnienv, IntPtr native__this, IntPtr native_context, IntPtr native_trackingConfiguration, IntPtr native_wt, IntPtr native_validPins)
		{
			global::Com.Webtrekk.Webtrekksdk.Request.RequestFactory __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Request.RequestFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
			global::Com.Webtrekk.Webtrekksdk.Configuration.TrackingConfiguration trackingConfiguration = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Configuration.TrackingConfiguration> (native_trackingConfiguration, JniHandleOwnership.DoNotTransfer);
			global::Com.Webtrekk.Webtrekksdk.Webtrekk wt = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Webtrekk> (native_wt, JniHandleOwnership.DoNotTransfer);
			var validPins = global::Android.Runtime.JavaSet<string>.FromJniHandle (native_validPins, JniHandleOwnership.DoNotTransfer);
			__this.Init (context, trackingConfiguration, wt, validPins);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Request']/class[@name='RequestFactory']/method[@name='init' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.webtrekk.webtrekksdk.Configuration.TrackingConfiguration'] and parameter[3][@type='com.webtrekk.webtrekksdk.Webtrekk'] and parameter[4][@type='java.util.Set&lt;java.lang.String&gt;']]"
		[Register ("init", "(Landroid/content/Context;Lcom/webtrekk/webtrekksdk/Configuration/TrackingConfiguration;Lcom/webtrekk/webtrekksdk/Webtrekk;Ljava/util/Set;)V", "GetInit_Landroid_content_Context_Lcom_webtrekk_webtrekksdk_Configuration_TrackingConfiguration_Lcom_webtrekk_webtrekksdk_Webtrekk_Ljava_util_Set_Handler")]
		public virtual unsafe void Init (global::Android.Content.Context context, global::Com.Webtrekk.Webtrekksdk.Configuration.TrackingConfiguration trackingConfiguration, global::Com.Webtrekk.Webtrekksdk.Webtrekk wt, global::System.Collections.Generic.ICollection<string> validPins)
		{
			const string __id = "init.(Landroid/content/Context;Lcom/webtrekk/webtrekksdk/Configuration/TrackingConfiguration;Lcom/webtrekk/webtrekksdk/Webtrekk;Ljava/util/Set;)V";
			IntPtr native_validPins = global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (validPins);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((trackingConfiguration == null) ? IntPtr.Zero : ((global::Java.Lang.Object) trackingConfiguration).Handle);
				__args [2] = new JniArgumentValue ((wt == null) ? IntPtr.Zero : ((global::Java.Lang.Object) wt).Handle);
				__args [3] = new JniArgumentValue (native_validPins);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_validPins);
			}
		}

		static Delegate cb_initAutoCustomParameter;
#pragma warning disable 0169
		static Delegate GetInitAutoCustomParameterHandler ()
		{
			if (cb_initAutoCustomParameter == null)
				cb_initAutoCustomParameter = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_InitAutoCustomParameter);
			return cb_initAutoCustomParameter;
		}

		static void n_InitAutoCustomParameter (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Webtrekk.Webtrekksdk.Request.RequestFactory __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Request.RequestFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.InitAutoCustomParameter ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Request']/class[@name='RequestFactory']/method[@name='initAutoCustomParameter' and count(parameter)=0]"
		[Register ("initAutoCustomParameter", "()V", "GetInitAutoCustomParameterHandler")]
		public virtual unsafe void InitAutoCustomParameter ()
		{
			const string __id = "initAutoCustomParameter.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_initEverID;
#pragma warning disable 0169
		static Delegate GetInitEverIDHandler ()
		{
			if (cb_initEverID == null)
				cb_initEverID = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_InitEverID);
			return cb_initEverID;
		}

		static void n_InitEverID (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Webtrekk.Webtrekksdk.Request.RequestFactory __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Request.RequestFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.InitEverID ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Request']/class[@name='RequestFactory']/method[@name='initEverID' and count(parameter)=0]"
		[Register ("initEverID", "()V", "GetInitEverIDHandler")]
		public virtual unsafe void InitEverID ()
		{
			const string __id = "initEverID.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_onFirstStart;
#pragma warning disable 0169
		static Delegate GetOnFirstStartHandler ()
		{
			if (cb_onFirstStart == null)
				cb_onFirstStart = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnFirstStart);
			return cb_onFirstStart;
		}

		static void n_OnFirstStart (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Webtrekk.Webtrekksdk.Request.RequestFactory __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Request.RequestFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnFirstStart ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Request']/class[@name='RequestFactory']/method[@name='onFirstStart' and count(parameter)=0]"
		[Register ("onFirstStart", "()V", "GetOnFirstStartHandler")]
		public virtual unsafe void OnFirstStart ()
		{
			const string __id = "onFirstStart.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_onSendIntervalOver;
#pragma warning disable 0169
		static Delegate GetOnSendIntervalOverHandler ()
		{
			if (cb_onSendIntervalOver == null)
				cb_onSendIntervalOver = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_OnSendIntervalOver);
			return cb_onSendIntervalOver;
		}

		static bool n_OnSendIntervalOver (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Webtrekk.Webtrekksdk.Request.RequestFactory __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Request.RequestFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.OnSendIntervalOver ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Request']/class[@name='RequestFactory']/method[@name='onSendIntervalOver' and count(parameter)=0]"
		[Register ("onSendIntervalOver", "()Z", "GetOnSendIntervalOverHandler")]
		public virtual unsafe bool OnSendIntervalOver ()
		{
			const string __id = "onSendIntervalOver.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_restore;
#pragma warning disable 0169
		static Delegate GetRestoreHandler ()
		{
			if (cb_restore == null)
				cb_restore = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Restore);
			return cb_restore;
		}

		static void n_Restore (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Webtrekk.Webtrekksdk.Request.RequestFactory __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Request.RequestFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Restore ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Request']/class[@name='RequestFactory']/method[@name='restore' and count(parameter)=0]"
		[Register ("restore", "()V", "GetRestoreHandler")]
		public virtual unsafe void Restore ()
		{
			const string __id = "restore.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_setCustomPageName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetCustomPageName_Ljava_lang_String_Handler ()
		{
			if (cb_setCustomPageName_Ljava_lang_String_ == null)
				cb_setCustomPageName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCustomPageName_Ljava_lang_String_);
			return cb_setCustomPageName_Ljava_lang_String_;
		}

		static void n_SetCustomPageName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_customPageName)
		{
			global::Com.Webtrekk.Webtrekksdk.Request.RequestFactory __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Request.RequestFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string customPageName = JNIEnv.GetString (native_customPageName, JniHandleOwnership.DoNotTransfer);
			__this.SetCustomPageName (customPageName);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Request']/class[@name='RequestFactory']/method[@name='setCustomPageName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setCustomPageName", "(Ljava/lang/String;)V", "GetSetCustomPageName_Ljava_lang_String_Handler")]
		public virtual unsafe void SetCustomPageName (string customPageName)
		{
			const string __id = "setCustomPageName.(Ljava/lang/String;)V";
			IntPtr native_customPageName = JNIEnv.NewString (customPageName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_customPageName);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_customPageName);
			}
		}

		static Delegate cb_setLasTrackTime_J;
#pragma warning disable 0169
		static Delegate GetSetLasTrackTime_JHandler ()
		{
			if (cb_setLasTrackTime_J == null)
				cb_setLasTrackTime_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetLasTrackTime_J);
			return cb_setLasTrackTime_J;
		}

		static void n_SetLasTrackTime_J (IntPtr jnienv, IntPtr native__this, long lasTrackTime)
		{
			global::Com.Webtrekk.Webtrekksdk.Request.RequestFactory __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Request.RequestFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetLasTrackTime (lasTrackTime);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Request']/class[@name='RequestFactory']/method[@name='setLasTrackTime' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("setLasTrackTime", "(J)V", "GetSetLasTrackTime_JHandler")]
		public virtual unsafe void SetLasTrackTime (long lasTrackTime)
		{
			const string __id = "setLasTrackTime.(J)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (lasTrackTime);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_startAdvertizingThread_Z;
#pragma warning disable 0169
		static Delegate GetStartAdvertizingThread_ZHandler ()
		{
			if (cb_startAdvertizingThread_Z == null)
				cb_startAdvertizingThread_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_StartAdvertizingThread_Z);
			return cb_startAdvertizingThread_Z;
		}

		static void n_StartAdvertizingThread_Z (IntPtr jnienv, IntPtr native__this, bool isFirstStart)
		{
			global::Com.Webtrekk.Webtrekksdk.Request.RequestFactory __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Request.RequestFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StartAdvertizingThread (isFirstStart);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Request']/class[@name='RequestFactory']/method[@name='startAdvertizingThread' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("startAdvertizingThread", "(Z)V", "GetStartAdvertizingThread_ZHandler")]
		public virtual unsafe void StartAdvertizingThread (bool isFirstStart)
		{
			const string __id = "startAdvertizingThread.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (isFirstStart);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_stop;
#pragma warning disable 0169
		static Delegate GetStopHandler ()
		{
			if (cb_stop == null)
				cb_stop = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Stop);
			return cb_stop;
		}

		static void n_Stop (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Webtrekk.Webtrekksdk.Request.RequestFactory __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Request.RequestFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Stop ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Request']/class[@name='RequestFactory']/method[@name='stop' and count(parameter)=0]"
		[Register ("stop", "()V", "GetStopHandler")]
		public virtual unsafe void Stop ()
		{
			const string __id = "stop.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_stopSendURLProcess;
#pragma warning disable 0169
		static Delegate GetStopSendURLProcessHandler ()
		{
			if (cb_stopSendURLProcess == null)
				cb_stopSendURLProcess = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_StopSendURLProcess);
			return cb_stopSendURLProcess;
		}

		static void n_StopSendURLProcess (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Webtrekk.Webtrekksdk.Request.RequestFactory __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Request.RequestFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StopSendURLProcess ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Request']/class[@name='RequestFactory']/method[@name='stopSendURLProcess' and count(parameter)=0]"
		[Register ("stopSendURLProcess", "()V", "GetStopSendURLProcessHandler")]
		public virtual unsafe void StopSendURLProcess ()
		{
			const string __id = "stopSendURLProcess.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_updateDynamicParameter;
#pragma warning disable 0169
		static Delegate GetUpdateDynamicParameterHandler ()
		{
			if (cb_updateDynamicParameter == null)
				cb_updateDynamicParameter = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_UpdateDynamicParameter);
			return cb_updateDynamicParameter;
		}

		static void n_UpdateDynamicParameter (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Webtrekk.Webtrekksdk.Request.RequestFactory __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Request.RequestFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UpdateDynamicParameter ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Request']/class[@name='RequestFactory']/method[@name='updateDynamicParameter' and count(parameter)=0]"
		[Register ("updateDynamicParameter", "()V", "GetUpdateDynamicParameterHandler")]
		public virtual unsafe void UpdateDynamicParameter ()
		{
			const string __id = "updateDynamicParameter.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
