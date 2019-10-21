using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Webtrekk.Webtrekksdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='Webtrekk']"
	[global::Android.Runtime.Register ("com/webtrekk/webtrekksdk/Webtrekk", DoNotGenerateAcw=true)]
	public partial class Webtrekk : global::Java.Lang.Object, global::Com.Webtrekk.Webtrekksdk.Utils.ActivityListener.ICallback {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='Webtrekk']/field[@name='PREFERENCE_APP_VERSIONCODE']"
		[Register ("PREFERENCE_APP_VERSIONCODE")]
		public const string PreferenceAppVersioncode = (string) "appVersion";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='Webtrekk']/field[@name='PREFERENCE_FILE_NAME']"
		[Register ("PREFERENCE_FILE_NAME")]
		public const string PreferenceFileName = (string) "webtrekk-preferences";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='Webtrekk']/field[@name='PREFERENCE_KEY_CONFIGURATION']"
		[Register ("PREFERENCE_KEY_CONFIGURATION")]
		public const string PreferenceKeyConfiguration = (string) "webtrekkTrackingConfiguration";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='Webtrekk']/field[@name='PREFERENCE_KEY_EVER_ID']"
		[Register ("PREFERENCE_KEY_EVER_ID")]
		public const string PreferenceKeyEverId = (string) "everId";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='Webtrekk']/field[@name='PREFERENCE_KEY_INSTALLATION_FLAG']"
		[Register ("PREFERENCE_KEY_INSTALLATION_FLAG")]
		public const string PreferenceKeyInstallationFlag = (string) "InstallationFlag";


		// Metadata.xml XPath field reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='Webtrekk']/field[@name='mTrackingLibraryVersion']"
		[Register ("mTrackingLibraryVersion")]
		public static string MTrackingLibraryVersion {
			get {
				const string __id = "mTrackingLibraryVersion.Ljava/lang/String;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mTrackingLibraryVersion.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='Webtrekk']/field[@name='mTrackingLibraryVersionUI']"
		[Register ("mTrackingLibraryVersionUI")]
		public static string MTrackingLibraryVersionUI {
			get {
				const string __id = "mTrackingLibraryVersionUI.Ljava/lang/String;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mTrackingLibraryVersionUI.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='Webtrekk.AndroidWebViewCallback']"
		[global::Android.Runtime.Register ("com/webtrekk/webtrekksdk/Webtrekk$AndroidWebViewCallback", DoNotGenerateAcw=true)]
		public partial class AndroidWebViewCallback : global::Java.Lang.Object {

			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/webtrekk/webtrekksdk/Webtrekk$AndroidWebViewCallback", typeof (AndroidWebViewCallback));
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

			protected AndroidWebViewCallback (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_getEverId;
#pragma warning disable 0169
			static Delegate GetGetEverIdHandler ()
			{
				if (cb_getEverId == null)
					cb_getEverId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEverId);
				return cb_getEverId;
			}

			static IntPtr n_GetEverId (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Webtrekk.Webtrekksdk.Webtrekk.AndroidWebViewCallback __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Webtrekk.AndroidWebViewCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.EverId);
			}
#pragma warning restore 0169

			public virtual unsafe string EverId {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='Webtrekk.AndroidWebViewCallback']/method[@name='getEverId' and count(parameter)=0]"
				[Register ("getEverId", "()Ljava/lang/String;", "GetGetEverIdHandler")]
				get {
					const string __id = "getEverId.()Ljava/lang/String;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

		}

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/webtrekk/webtrekksdk/Webtrekk", typeof (Webtrekk));
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

		protected Webtrekk (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

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
			global::Com.Webtrekk.Webtrekksdk.Webtrekk __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Webtrekk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Webtrekk.Webtrekksdk.Webtrekk __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Webtrekk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Webtrekk.Webtrekksdk.TrackingParameter constGlobalTrackingParameter = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.TrackingParameter> (native_constGlobalTrackingParameter, JniHandleOwnership.DoNotTransfer);
			__this.ConstGlobalTrackingParameter = constGlobalTrackingParameter;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Webtrekk.Webtrekksdk.TrackingParameter ConstGlobalTrackingParameter {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='Webtrekk']/method[@name='getConstGlobalTrackingParameter' and count(parameter)=0]"
			[Register ("getConstGlobalTrackingParameter", "()Lcom/webtrekk/webtrekksdk/TrackingParameter;", "GetGetConstGlobalTrackingParameterHandler")]
			get {
				const string __id = "getConstGlobalTrackingParameter.()Lcom/webtrekk/webtrekksdk/TrackingParameter;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.TrackingParameter> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='Webtrekk']/method[@name='setConstGlobalTrackingParameter' and count(parameter)=1 and parameter[1][@type='com.webtrekk.webtrekksdk.TrackingParameter']]"
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

		static Delegate cb_getContext;
#pragma warning disable 0169
		static Delegate GetGetContextHandler ()
		{
			if (cb_getContext == null)
				cb_getContext = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetContext);
			return cb_getContext;
		}

		static IntPtr n_GetContext (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Webtrekk.Webtrekksdk.Webtrekk __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Webtrekk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Context);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Content.Context Context {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='Webtrekk']/method[@name='getContext' and count(parameter)=0]"
			[Register ("getContext", "()Landroid/content/Context;", "GetGetContextHandler")]
			get {
				const string __id = "getContext.()Landroid/content/Context;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Content.Context> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			global::Com.Webtrekk.Webtrekksdk.Webtrekk __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Webtrekk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CurrentActivityName);
		}
#pragma warning restore 0169

		static Delegate cb_setCurrentActivityName_Ljava_lang_String_;
#pragma warning disable 0169
		[Obsolete]
		static Delegate GetSetCurrentActivityName_Ljava_lang_String_Handler ()
		{
			if (cb_setCurrentActivityName_Ljava_lang_String_ == null)
				cb_setCurrentActivityName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCurrentActivityName_Ljava_lang_String_);
			return cb_setCurrentActivityName_Ljava_lang_String_;
		}

		[Obsolete]
		static void n_SetCurrentActivityName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_currentActivityName)
		{
			global::Com.Webtrekk.Webtrekksdk.Webtrekk __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Webtrekk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string currentActivityName = JNIEnv.GetString (native_currentActivityName, JniHandleOwnership.DoNotTransfer);
			__this.CurrentActivityName = currentActivityName;
		}
#pragma warning restore 0169

		public virtual unsafe string CurrentActivityName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='Webtrekk']/method[@name='getCurrentActivityName' and count(parameter)=0]"
			[Register ("getCurrentActivityName", "()Ljava/lang/String;", "GetGetCurrentActivityNameHandler")]
			get {
				const string __id = "getCurrentActivityName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='Webtrekk']/method[@name='setCurrentActivityName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			global::Com.Webtrekk.Webtrekksdk.Webtrekk __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Webtrekk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Webtrekk.Webtrekksdk.Webtrekk __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Webtrekk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var customParameter = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_customParameter, JniHandleOwnership.DoNotTransfer);
			__this.CustomParameter = customParameter;
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IDictionary<string, string> CustomParameter {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='Webtrekk']/method[@name='getCustomParameter' and count(parameter)=0]"
			[Register ("getCustomParameter", "()Ljava/util/Map;", "GetGetCustomParameterHandler")]
			get {
				const string __id = "getCustomParameter.()Ljava/util/Map;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='Webtrekk']/method[@name='setCustomParameter' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
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

		static Delegate cb_getEverId;
#pragma warning disable 0169
		static Delegate GetGetEverIdHandler ()
		{
			if (cb_getEverId == null)
				cb_getEverId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEverId);
			return cb_getEverId;
		}

		static IntPtr n_GetEverId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Webtrekk.Webtrekksdk.Webtrekk __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Webtrekk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.EverId);
		}
#pragma warning restore 0169

		static Delegate cb_setEverId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetEverId_Ljava_lang_String_Handler ()
		{
			if (cb_setEverId_Ljava_lang_String_ == null)
				cb_setEverId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetEverId_Ljava_lang_String_);
			return cb_setEverId_Ljava_lang_String_;
		}

		static void n_SetEverId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_everId)
		{
			global::Com.Webtrekk.Webtrekksdk.Webtrekk __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Webtrekk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string everId = JNIEnv.GetString (native_everId, JniHandleOwnership.DoNotTransfer);
			__this.EverId = everId;
		}
#pragma warning restore 0169

		public virtual unsafe string EverId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='Webtrekk']/method[@name='getEverId' and count(parameter)=0]"
			[Register ("getEverId", "()Ljava/lang/String;", "GetGetEverIdHandler")]
			get {
				const string __id = "getEverId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='Webtrekk']/method[@name='setEverId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setEverId", "(Ljava/lang/String;)V", "GetSetEverId_Ljava_lang_String_Handler")]
			set {
				const string __id = "setEverId.(Ljava/lang/String;)V";
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
			global::Com.Webtrekk.Webtrekksdk.Webtrekk __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Webtrekk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Webtrekk.Webtrekksdk.Webtrekk __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Webtrekk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Webtrekk.Webtrekksdk.TrackingParameter globalTrackingParameter = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.TrackingParameter> (native_globalTrackingParameter, JniHandleOwnership.DoNotTransfer);
			__this.GlobalTrackingParameter = globalTrackingParameter;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Webtrekk.Webtrekksdk.TrackingParameter GlobalTrackingParameter {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='Webtrekk']/method[@name='getGlobalTrackingParameter' and count(parameter)=0]"
			[Register ("getGlobalTrackingParameter", "()Lcom/webtrekk/webtrekksdk/TrackingParameter;", "GetGetGlobalTrackingParameterHandler")]
			get {
				const string __id = "getGlobalTrackingParameter.()Lcom/webtrekk/webtrekksdk/TrackingParameter;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.TrackingParameter> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='Webtrekk']/method[@name='setGlobalTrackingParameter' and count(parameter)=1 and parameter[1][@type='com.webtrekk.webtrekksdk.TrackingParameter']]"
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

		public static unsafe global::Com.Webtrekk.Webtrekksdk.Webtrekk Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='Webtrekk']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lcom/webtrekk/webtrekksdk/Webtrekk;", "GetGetInstanceHandler")]
			get {
				const string __id = "getInstance.()Lcom/webtrekk/webtrekksdk/Webtrekk;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Webtrekk> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isAutoTrackApiLevel;
#pragma warning disable 0169
		static Delegate GetIsAutoTrackApiLevelHandler ()
		{
			if (cb_isAutoTrackApiLevel == null)
				cb_isAutoTrackApiLevel = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsAutoTrackApiLevel);
			return cb_isAutoTrackApiLevel;
		}

		static bool n_IsAutoTrackApiLevel (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Webtrekk.Webtrekksdk.Webtrekk __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Webtrekk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsAutoTrackApiLevel;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsAutoTrackApiLevel {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='Webtrekk']/method[@name='isAutoTrackApiLevel' and count(parameter)=0]"
			[Register ("isAutoTrackApiLevel", "()Z", "GetIsAutoTrackApiLevelHandler")]
			get {
				const string __id = "isAutoTrackApiLevel.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isAutoTracked;
#pragma warning disable 0169
		static Delegate GetIsAutoTrackedHandler ()
		{
			if (cb_isAutoTracked == null)
				cb_isAutoTracked = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsAutoTracked);
			return cb_isAutoTracked;
		}

		static bool n_IsAutoTracked (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Webtrekk.Webtrekksdk.Webtrekk __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Webtrekk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsAutoTracked;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsAutoTracked {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='Webtrekk']/method[@name='isAutoTracked' and count(parameter)=0]"
			[Register ("isAutoTracked", "()Z", "GetIsAutoTrackedHandler")]
			get {
				const string __id = "isAutoTracked.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isEnableRemoteConfiguration;
#pragma warning disable 0169
		static Delegate GetIsEnableRemoteConfigurationHandler ()
		{
			if (cb_isEnableRemoteConfiguration == null)
				cb_isEnableRemoteConfiguration = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsEnableRemoteConfiguration);
			return cb_isEnableRemoteConfiguration;
		}

		static bool n_IsEnableRemoteConfiguration (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Webtrekk.Webtrekksdk.Webtrekk __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Webtrekk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsEnableRemoteConfiguration;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsEnableRemoteConfiguration {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='Webtrekk']/method[@name='isEnableRemoteConfiguration' and count(parameter)=0]"
			[Register ("isEnableRemoteConfiguration", "()Z", "GetIsEnableRemoteConfigurationHandler")]
			get {
				const string __id = "isEnableRemoteConfiguration.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isInitialized;
#pragma warning disable 0169
		static Delegate GetIsInitializedHandler ()
		{
			if (cb_isInitialized == null)
				cb_isInitialized = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsInitialized);
			return cb_isInitialized;
		}

		static bool n_IsInitialized (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Webtrekk.Webtrekksdk.Webtrekk __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Webtrekk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsInitialized;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsInitialized {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='Webtrekk']/method[@name='isInitialized' and count(parameter)=0]"
			[Register ("isInitialized", "()Z", "GetIsInitializedHandler")]
			get {
				const string __id = "isInitialized.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
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
			global::Com.Webtrekk.Webtrekksdk.Webtrekk __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Webtrekk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Webtrekk.Webtrekksdk.Webtrekk __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Webtrekk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.IsSampling = isSampling;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsSampling {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='Webtrekk']/method[@name='isSampling' and count(parameter)=0]"
			[Register ("isSampling", "()Z", "GetIsSamplingHandler")]
			get {
				const string __id = "isSampling.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='Webtrekk']/method[@name='setIsSampling' and count(parameter)=1 and parameter[1][@type='boolean']]"
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

		public static unsafe bool LoggingEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='Webtrekk']/method[@name='isLoggingEnabled' and count(parameter)=0]"
			[Register ("isLoggingEnabled", "()Z", "GetIsLoggingEnabledHandler")]
			get {
				const string __id = "isLoggingEnabled.()Z";
				try {
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='Webtrekk']/method[@name='setLoggingEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setLoggingEnabled", "(Z)V", "GetSetLoggingEnabled_ZHandler")]
			set {
				const string __id = "setLoggingEnabled.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.StaticMethods.InvokeVoidMethod (__id, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getMaxRequests;
#pragma warning disable 0169
		static Delegate GetGetMaxRequestsHandler ()
		{
			if (cb_getMaxRequests == null)
				cb_getMaxRequests = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetMaxRequests);
			return cb_getMaxRequests;
		}

		static int n_GetMaxRequests (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Webtrekk.Webtrekksdk.Webtrekk __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Webtrekk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MaxRequests;
		}
#pragma warning restore 0169

		public virtual unsafe int MaxRequests {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='Webtrekk']/method[@name='getMaxRequests' and count(parameter)=0]"
			[Register ("getMaxRequests", "()I", "GetGetMaxRequestsHandler")]
			get {
				const string __id = "getMaxRequests.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
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
			global::Com.Webtrekk.Webtrekksdk.Webtrekk __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Webtrekk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Optout;
		}
#pragma warning restore 0169

		static Delegate cb_setOptout_Z;
#pragma warning disable 0169
		static Delegate GetSetOptout_ZHandler ()
		{
			if (cb_setOptout_Z == null)
				cb_setOptout_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetOptout_Z);
			return cb_setOptout_Z;
		}

		static void n_SetOptout_Z (IntPtr jnienv, IntPtr native__this, bool value)
		{
			global::Com.Webtrekk.Webtrekksdk.Webtrekk __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Webtrekk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Optout = value;
		}
#pragma warning restore 0169

		public virtual unsafe bool Optout {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='Webtrekk']/method[@name='isOptout' and count(parameter)=0]"
			[Register ("isOptout", "()Z", "GetIsOptoutHandler")]
			get {
				const string __id = "isOptout.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='Webtrekk']/method[@name='setOptout' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setOptout", "(Z)V", "GetSetOptout_ZHandler")]
			set {
				const string __id = "setOptout.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getProductListTracker;
#pragma warning disable 0169
		static Delegate GetGetProductListTrackerHandler ()
		{
			if (cb_getProductListTracker == null)
				cb_getProductListTracker = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetProductListTracker);
			return cb_getProductListTracker;
		}

		static IntPtr n_GetProductListTracker (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Webtrekk.Webtrekksdk.Webtrekk __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Webtrekk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ProductListTracker);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Webtrekk.Webtrekksdk.ProductListTracker ProductListTracker {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='Webtrekk']/method[@name='getProductListTracker' and count(parameter)=0]"
			[Register ("getProductListTracker", "()Lcom/webtrekk/webtrekksdk/ProductListTracker;", "GetGetProductListTrackerHandler")]
			get {
				const string __id = "getProductListTracker.()Lcom/webtrekk/webtrekksdk/ProductListTracker;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.ProductListTracker> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getRecommendations;
#pragma warning disable 0169
		static Delegate GetGetRecommendationsHandler ()
		{
			if (cb_getRecommendations == null)
				cb_getRecommendations = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRecommendations);
			return cb_getRecommendations;
		}

		static IntPtr n_GetRecommendations (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Webtrekk.Webtrekksdk.Webtrekk __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Webtrekk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Recommendations);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Webtrekk.Webtrekksdk.WebtrekkRecommendations Recommendations {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='Webtrekk']/method[@name='getRecommendations' and count(parameter)=0]"
			[Register ("getRecommendations", "()Lcom/webtrekk/webtrekksdk/WebtrekkRecommendations;", "GetGetRecommendationsHandler")]
			get {
				const string __id = "getRecommendations.()Lcom/webtrekk/webtrekksdk/WebtrekkRecommendations;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.WebtrekkRecommendations> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getResendOnStartEventTime;
#pragma warning disable 0169
		static Delegate GetGetResendOnStartEventTimeHandler ()
		{
			if (cb_getResendOnStartEventTime == null)
				cb_getResendOnStartEventTime = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetResendOnStartEventTime);
			return cb_getResendOnStartEventTime;
		}

		static int n_GetResendOnStartEventTime (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Webtrekk.Webtrekksdk.Webtrekk __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Webtrekk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ResendOnStartEventTime;
		}
#pragma warning restore 0169

		public virtual unsafe int ResendOnStartEventTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='Webtrekk']/method[@name='getResendOnStartEventTime' and count(parameter)=0]"
			[Register ("getResendOnStartEventTime", "()I", "GetGetResendOnStartEventTimeHandler")]
			get {
				const string __id = "getResendOnStartEventTime.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getSampling;
#pragma warning disable 0169
		static Delegate GetGetSamplingHandler ()
		{
			if (cb_getSampling == null)
				cb_getSampling = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetSampling);
			return cb_getSampling;
		}

		static int n_GetSampling (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Webtrekk.Webtrekksdk.Webtrekk __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Webtrekk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Sampling;
		}
#pragma warning restore 0169

		public virtual unsafe int Sampling {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='Webtrekk']/method[@name='getSampling' and count(parameter)=0]"
			[Register ("getSampling", "()I", "GetGetSamplingHandler")]
			get {
				const string __id = "getSampling.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getSendDelay;
#pragma warning disable 0169
		static Delegate GetGetSendDelayHandler ()
		{
			if (cb_getSendDelay == null)
				cb_getSendDelay = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetSendDelay);
			return cb_getSendDelay;
		}

		static int n_GetSendDelay (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Webtrekk.Webtrekksdk.Webtrekk __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Webtrekk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SendDelay;
		}
#pragma warning restore 0169

		public virtual unsafe int SendDelay {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='Webtrekk']/method[@name='getSendDelay' and count(parameter)=0]"
			[Register ("getSendDelay", "()I", "GetGetSendDelayHandler")]
			get {
				const string __id = "getSendDelay.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public static unsafe bool Tls12Enabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='Webtrekk']/method[@name='isTls12Enabled' and count(parameter)=0]"
			[Register ("isTls12Enabled", "()Z", "GetIsTls12EnabledHandler")]
			get {
				const string __id = "isTls12Enabled.()Z";
				try {
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='Webtrekk']/method[@name='setTls12Enabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setTls12Enabled", "(Z)V", "GetSetTls12Enabled_ZHandler")]
			set {
				const string __id = "setTls12Enabled.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.StaticMethods.InvokeVoidMethod (__id, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getTrackDomain;
#pragma warning disable 0169
		static Delegate GetGetTrackDomainHandler ()
		{
			if (cb_getTrackDomain == null)
				cb_getTrackDomain = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTrackDomain);
			return cb_getTrackDomain;
		}

		static IntPtr n_GetTrackDomain (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Webtrekk.Webtrekksdk.Webtrekk __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Webtrekk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.TrackDomain);
		}
#pragma warning restore 0169

		public virtual unsafe string TrackDomain {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='Webtrekk']/method[@name='getTrackDomain' and count(parameter)=0]"
			[Register ("getTrackDomain", "()Ljava/lang/String;", "GetGetTrackDomainHandler")]
			get {
				const string __id = "getTrackDomain.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTrackId;
#pragma warning disable 0169
		[Obsolete]
		static Delegate GetGetTrackIdHandler ()
		{
			if (cb_getTrackId == null)
				cb_getTrackId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTrackId);
			return cb_getTrackId;
		}

		[Obsolete]
		static IntPtr n_GetTrackId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Webtrekk.Webtrekksdk.Webtrekk __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Webtrekk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.TrackId);
		}
#pragma warning restore 0169

		[Obsolete (@"deprecated")]
		public virtual unsafe string TrackId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='Webtrekk']/method[@name='getTrackId' and count(parameter)=0]"
			[Register ("getTrackId", "()Ljava/lang/String;", "GetGetTrackIdHandler")]
			get {
				const string __id = "getTrackId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			global::Com.Webtrekk.Webtrekksdk.Webtrekk __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Webtrekk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Webtrekk.Webtrekksdk.Webtrekk __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Webtrekk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Webtrekk.Webtrekksdk.Configuration.TrackingConfiguration trackingConfiguration = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Configuration.TrackingConfiguration> (native_trackingConfiguration, JniHandleOwnership.DoNotTransfer);
			__this.TrackingConfiguration = trackingConfiguration;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Webtrekk.Webtrekksdk.Configuration.TrackingConfiguration TrackingConfiguration {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='Webtrekk']/method[@name='getTrackingConfiguration' and count(parameter)=0]"
			[Register ("getTrackingConfiguration", "()Lcom/webtrekk/webtrekksdk/Configuration/TrackingConfiguration;", "GetGetTrackingConfigurationHandler")]
			get {
				const string __id = "getTrackingConfiguration.()Lcom/webtrekk/webtrekksdk/Configuration/TrackingConfiguration;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Configuration.TrackingConfiguration> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='Webtrekk']/method[@name='setTrackingConfiguration' and count(parameter)=1 and parameter[1][@type='com.webtrekk.webtrekksdk.Configuration.TrackingConfiguration']]"
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

		static Delegate cb_getTrackingConfigurationUrl;
#pragma warning disable 0169
		static Delegate GetGetTrackingConfigurationUrlHandler ()
		{
			if (cb_getTrackingConfigurationUrl == null)
				cb_getTrackingConfigurationUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTrackingConfigurationUrl);
			return cb_getTrackingConfigurationUrl;
		}

		static IntPtr n_GetTrackingConfigurationUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Webtrekk.Webtrekksdk.Webtrekk __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Webtrekk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.TrackingConfigurationUrl);
		}
#pragma warning restore 0169

		public virtual unsafe string TrackingConfigurationUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='Webtrekk']/method[@name='getTrackingConfigurationUrl' and count(parameter)=0]"
			[Register ("getTrackingConfigurationUrl", "()Ljava/lang/String;", "GetGetTrackingConfigurationUrlHandler")]
			get {
				const string __id = "getTrackingConfigurationUrl.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTrackingIDs;
#pragma warning disable 0169
		static Delegate GetGetTrackingIDsHandler ()
		{
			if (cb_getTrackingIDs == null)
				cb_getTrackingIDs = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTrackingIDs);
			return cb_getTrackingIDs;
		}

		static IntPtr n_GetTrackingIDs (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Webtrekk.Webtrekksdk.Webtrekk __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Webtrekk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.TrackingIDs);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<string> TrackingIDs {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='Webtrekk']/method[@name='getTrackingIDs' and count(parameter)=0]"
			[Register ("getTrackingIDs", "()Ljava/util/List;", "GetGetTrackingIDsHandler")]
			get {
				const string __id = "getTrackingIDs.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getVersion;
#pragma warning disable 0169
		static Delegate GetGetVersionHandler ()
		{
			if (cb_getVersion == null)
				cb_getVersion = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetVersion);
			return cb_getVersion;
		}

		static int n_GetVersion (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Webtrekk.Webtrekksdk.Webtrekk __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Webtrekk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Version;
		}
#pragma warning restore 0169

		public virtual unsafe int Version {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='Webtrekk']/method[@name='getVersion' and count(parameter)=0]"
			[Register ("getVersion", "()I", "GetGetVersionHandler")]
			get {
				const string __id = "getVersion.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_autoTrackActivity;
#pragma warning disable 0169
		static Delegate GetAutoTrackActivityHandler ()
		{
			if (cb_autoTrackActivity == null)
				cb_autoTrackActivity = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_AutoTrackActivity);
			return cb_autoTrackActivity;
		}

		static void n_AutoTrackActivity (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Webtrekk.Webtrekksdk.Webtrekk __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Webtrekk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AutoTrackActivity ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='Webtrekk']/method[@name='autoTrackActivity' and count(parameter)=0]"
		[Register ("autoTrackActivity", "()V", "GetAutoTrackActivityHandler")]
		public virtual unsafe void AutoTrackActivity ()
		{
			const string __id = "autoTrackActivity.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='Webtrekk']/method[@name='initWebtrekk' and count(parameter)=1 and parameter[1][@type='android.app.Application']]"
		[Register ("initWebtrekk", "(Landroid/app/Application;)V", "")]
		public unsafe void InitWebtrekk (global::Android.App.Application app)
		{
			const string __id = "initWebtrekk.(Landroid/app/Application;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((app == null) ? IntPtr.Zero : ((global::Java.Lang.Object) app).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='Webtrekk']/method[@name='initWebtrekk' and count(parameter)=2 and parameter[1][@type='android.app.Application'] and parameter[2][@type='int']]"
		[Register ("initWebtrekk", "(Landroid/app/Application;I)V", "")]
		public unsafe void InitWebtrekk (global::Android.App.Application app, int configResourceID)
		{
			const string __id = "initWebtrekk.(Landroid/app/Application;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((app == null) ? IntPtr.Zero : ((global::Java.Lang.Object) app).Handle);
				__args [1] = new JniArgumentValue (configResourceID);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='Webtrekk']/method[@name='initWebtrekk' and count(parameter)=3 and parameter[1][@type='android.app.Application'] and parameter[2][@type='int'] and parameter[3][@type='java.util.Set&lt;java.lang.String&gt;']]"
		[Register ("initWebtrekk", "(Landroid/app/Application;ILjava/util/Set;)V", "")]
		public unsafe void InitWebtrekk (global::Android.App.Application app, int configResourceID, global::System.Collections.Generic.ICollection<string> validPins)
		{
			const string __id = "initWebtrekk.(Landroid/app/Application;ILjava/util/Set;)V";
			IntPtr native_validPins = global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (validPins);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((app == null) ? IntPtr.Zero : ((global::Java.Lang.Object) app).Handle);
				__args [1] = new JniArgumentValue (configResourceID);
				__args [2] = new JniArgumentValue (native_validPins);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_validPins);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='Webtrekk']/method[@name='initWebtrekk' and count(parameter)=2 and parameter[1][@type='android.app.Application'] and parameter[2][@type='java.util.Set&lt;java.lang.String&gt;']]"
		[Register ("initWebtrekk", "(Landroid/app/Application;Ljava/util/Set;)V", "")]
		public unsafe void InitWebtrekk (global::Android.App.Application app, global::System.Collections.Generic.ICollection<string> validPins)
		{
			const string __id = "initWebtrekk.(Landroid/app/Application;Ljava/util/Set;)V";
			IntPtr native_validPins = global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (validPins);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((app == null) ? IntPtr.Zero : ((global::Java.Lang.Object) app).Handle);
				__args [1] = new JniArgumentValue (native_validPins);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_validPins);
			}
		}

		static Delegate cb_onDestroy_Lcom_webtrekk_webtrekksdk_Utils_ActivityTrackingStatus_STATUS_;
#pragma warning disable 0169
		static Delegate GetOnDestroy_Lcom_webtrekk_webtrekksdk_Utils_ActivityTrackingStatus_STATUS_Handler ()
		{
			if (cb_onDestroy_Lcom_webtrekk_webtrekksdk_Utils_ActivityTrackingStatus_STATUS_ == null)
				cb_onDestroy_Lcom_webtrekk_webtrekksdk_Utils_ActivityTrackingStatus_STATUS_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnDestroy_Lcom_webtrekk_webtrekksdk_Utils_ActivityTrackingStatus_STATUS_);
			return cb_onDestroy_Lcom_webtrekk_webtrekksdk_Utils_ActivityTrackingStatus_STATUS_;
		}

		static void n_OnDestroy_Lcom_webtrekk_webtrekksdk_Utils_ActivityTrackingStatus_STATUS_ (IntPtr jnienv, IntPtr native__this, IntPtr native_status)
		{
			global::Com.Webtrekk.Webtrekksdk.Webtrekk __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Webtrekk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Webtrekk.Webtrekksdk.Utils.ActivityTrackingStatus.STATUS status = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Utils.ActivityTrackingStatus.STATUS> (native_status, JniHandleOwnership.DoNotTransfer);
			__this.OnDestroy (status);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='Webtrekk']/method[@name='onDestroy' and count(parameter)=1 and parameter[1][@type='com.webtrekk.webtrekksdk.Utils.ActivityTrackingStatus.STATUS']]"
		[Register ("onDestroy", "(Lcom/webtrekk/webtrekksdk/Utils/ActivityTrackingStatus$STATUS;)V", "GetOnDestroy_Lcom_webtrekk_webtrekksdk_Utils_ActivityTrackingStatus_STATUS_Handler")]
		public virtual unsafe void OnDestroy (global::Com.Webtrekk.Webtrekksdk.Utils.ActivityTrackingStatus.STATUS status)
		{
			const string __id = "onDestroy.(Lcom/webtrekk/webtrekksdk/Utils/ActivityTrackingStatus$STATUS;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((status == null) ? IntPtr.Zero : ((global::Java.Lang.Object) status).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_onStart_ZLcom_webtrekk_webtrekksdk_Utils_ActivityTrackingStatus_STATUS_JLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnStart_ZLcom_webtrekk_webtrekksdk_Utils_ActivityTrackingStatus_STATUS_JLjava_lang_String_Handler ()
		{
			if (cb_onStart_ZLcom_webtrekk_webtrekksdk_Utils_ActivityTrackingStatus_STATUS_JLjava_lang_String_ == null)
				cb_onStart_ZLcom_webtrekk_webtrekksdk_Utils_ActivityTrackingStatus_STATUS_JLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool, IntPtr, long, IntPtr>) n_OnStart_ZLcom_webtrekk_webtrekksdk_Utils_ActivityTrackingStatus_STATUS_JLjava_lang_String_);
			return cb_onStart_ZLcom_webtrekk_webtrekksdk_Utils_ActivityTrackingStatus_STATUS_JLjava_lang_String_;
		}

		static void n_OnStart_ZLcom_webtrekk_webtrekksdk_Utils_ActivityTrackingStatus_STATUS_JLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, bool isRecreationInProcess, IntPtr native_status, long inactivityTime, IntPtr native_activityName)
		{
			global::Com.Webtrekk.Webtrekksdk.Webtrekk __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Webtrekk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Webtrekk.Webtrekksdk.Utils.ActivityTrackingStatus.STATUS status = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Utils.ActivityTrackingStatus.STATUS> (native_status, JniHandleOwnership.DoNotTransfer);
			string activityName = JNIEnv.GetString (native_activityName, JniHandleOwnership.DoNotTransfer);
			__this.OnStart (isRecreationInProcess, status, inactivityTime, activityName);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='Webtrekk']/method[@name='onStart' and count(parameter)=4 and parameter[1][@type='boolean'] and parameter[2][@type='com.webtrekk.webtrekksdk.Utils.ActivityTrackingStatus.STATUS'] and parameter[3][@type='long'] and parameter[4][@type='java.lang.String']]"
		[Register ("onStart", "(ZLcom/webtrekk/webtrekksdk/Utils/ActivityTrackingStatus$STATUS;JLjava/lang/String;)V", "GetOnStart_ZLcom_webtrekk_webtrekksdk_Utils_ActivityTrackingStatus_STATUS_JLjava_lang_String_Handler")]
		public virtual unsafe void OnStart (bool isRecreationInProcess, global::Com.Webtrekk.Webtrekksdk.Utils.ActivityTrackingStatus.STATUS status, long inactivityTime, string activityName)
		{
			const string __id = "onStart.(ZLcom/webtrekk/webtrekksdk/Utils/ActivityTrackingStatus$STATUS;JLjava/lang/String;)V";
			IntPtr native_activityName = JNIEnv.NewString (activityName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (isRecreationInProcess);
				__args [1] = new JniArgumentValue ((status == null) ? IntPtr.Zero : ((global::Java.Lang.Object) status).Handle);
				__args [2] = new JniArgumentValue (inactivityTime);
				__args [3] = new JniArgumentValue (native_activityName);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_activityName);
			}
		}

		static Delegate cb_onStop_Lcom_webtrekk_webtrekksdk_Utils_ActivityTrackingStatus_STATUS_;
#pragma warning disable 0169
		static Delegate GetOnStop_Lcom_webtrekk_webtrekksdk_Utils_ActivityTrackingStatus_STATUS_Handler ()
		{
			if (cb_onStop_Lcom_webtrekk_webtrekksdk_Utils_ActivityTrackingStatus_STATUS_ == null)
				cb_onStop_Lcom_webtrekk_webtrekksdk_Utils_ActivityTrackingStatus_STATUS_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnStop_Lcom_webtrekk_webtrekksdk_Utils_ActivityTrackingStatus_STATUS_);
			return cb_onStop_Lcom_webtrekk_webtrekksdk_Utils_ActivityTrackingStatus_STATUS_;
		}

		static void n_OnStop_Lcom_webtrekk_webtrekksdk_Utils_ActivityTrackingStatus_STATUS_ (IntPtr jnienv, IntPtr native__this, IntPtr native_status)
		{
			global::Com.Webtrekk.Webtrekksdk.Webtrekk __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Webtrekk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Webtrekk.Webtrekksdk.Utils.ActivityTrackingStatus.STATUS status = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Utils.ActivityTrackingStatus.STATUS> (native_status, JniHandleOwnership.DoNotTransfer);
			__this.OnStop (status);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='Webtrekk']/method[@name='onStop' and count(parameter)=1 and parameter[1][@type='com.webtrekk.webtrekksdk.Utils.ActivityTrackingStatus.STATUS']]"
		[Register ("onStop", "(Lcom/webtrekk/webtrekksdk/Utils/ActivityTrackingStatus$STATUS;)V", "GetOnStop_Lcom_webtrekk_webtrekksdk_Utils_ActivityTrackingStatus_STATUS_Handler")]
		public virtual unsafe void OnStop (global::Com.Webtrekk.Webtrekksdk.Utils.ActivityTrackingStatus.STATUS status)
		{
			const string __id = "onStop.(Lcom/webtrekk/webtrekksdk/Utils/ActivityTrackingStatus$STATUS;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((status == null) ? IntPtr.Zero : ((global::Java.Lang.Object) status).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_send;
#pragma warning disable 0169
		static Delegate GetSendHandler ()
		{
			if (cb_send == null)
				cb_send = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_Send);
			return cb_send;
		}

		static bool n_Send (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Webtrekk.Webtrekksdk.Webtrekk __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Webtrekk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Send ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='Webtrekk']/method[@name='send' and count(parameter)=0]"
		[Register ("send", "()Z", "GetSendHandler")]
		public virtual unsafe bool Send ()
		{
			const string __id = "send.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
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

		static void n_SetCustomPageName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_pageName)
		{
			global::Com.Webtrekk.Webtrekksdk.Webtrekk __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Webtrekk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string pageName = JNIEnv.GetString (native_pageName, JniHandleOwnership.DoNotTransfer);
			__this.SetCustomPageName (pageName);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='Webtrekk']/method[@name='setCustomPageName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setCustomPageName", "(Ljava/lang/String;)V", "GetSetCustomPageName_Ljava_lang_String_Handler")]
		public virtual unsafe void SetCustomPageName (string pageName)
		{
			const string __id = "setCustomPageName.(Ljava/lang/String;)V";
			IntPtr native_pageName = JNIEnv.NewString (pageName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_pageName);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_pageName);
			}
		}

		static Delegate cb_setMediaCode_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetMediaCode_Ljava_lang_String_Handler ()
		{
			if (cb_setMediaCode_Ljava_lang_String_ == null)
				cb_setMediaCode_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMediaCode_Ljava_lang_String_);
			return cb_setMediaCode_Ljava_lang_String_;
		}

		static void n_SetMediaCode_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_mediaCode)
		{
			global::Com.Webtrekk.Webtrekksdk.Webtrekk __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Webtrekk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string mediaCode = JNIEnv.GetString (native_mediaCode, JniHandleOwnership.DoNotTransfer);
			__this.SetMediaCode (mediaCode);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='Webtrekk']/method[@name='setMediaCode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setMediaCode", "(Ljava/lang/String;)V", "GetSetMediaCode_Ljava_lang_String_Handler")]
		public virtual unsafe void SetMediaCode (string mediaCode)
		{
			const string __id = "setMediaCode.(Ljava/lang/String;)V";
			IntPtr native_mediaCode = JNIEnv.NewString (mediaCode);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_mediaCode);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_mediaCode);
			}
		}

		static Delegate cb_setPageURL_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetPageURL_Ljava_lang_String_Handler ()
		{
			if (cb_setPageURL_Ljava_lang_String_ == null)
				cb_setPageURL_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_SetPageURL_Ljava_lang_String_);
			return cb_setPageURL_Ljava_lang_String_;
		}

		static bool n_SetPageURL_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_url)
		{
			global::Com.Webtrekk.Webtrekksdk.Webtrekk __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Webtrekk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string url = JNIEnv.GetString (native_url, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.SetPageURL (url);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='Webtrekk']/method[@name='setPageURL' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setPageURL", "(Ljava/lang/String;)Z", "GetSetPageURL_Ljava_lang_String_Handler")]
		public virtual unsafe bool SetPageURL (string url)
		{
			const string __id = "setPageURL.(Ljava/lang/String;)Z";
			IntPtr native_url = JNIEnv.NewString (url);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_url);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_url);
			}
		}

		static Delegate cb_setupWebView_Landroid_webkit_WebView_;
#pragma warning disable 0169
		static Delegate GetSetupWebView_Landroid_webkit_WebView_Handler ()
		{
			if (cb_setupWebView_Landroid_webkit_WebView_ == null)
				cb_setupWebView_Landroid_webkit_WebView_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetupWebView_Landroid_webkit_WebView_);
			return cb_setupWebView_Landroid_webkit_WebView_;
		}

		static void n_SetupWebView_Landroid_webkit_WebView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_webView)
		{
			global::Com.Webtrekk.Webtrekksdk.Webtrekk __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Webtrekk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Webkit.WebView webView = global::Java.Lang.Object.GetObject<global::Android.Webkit.WebView> (native_webView, JniHandleOwnership.DoNotTransfer);
			__this.SetupWebView (webView);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='Webtrekk']/method[@name='setupWebView' and count(parameter)=1 and parameter[1][@type='android.webkit.WebView']]"
		[Register ("setupWebView", "(Landroid/webkit/WebView;)V", "GetSetupWebView_Landroid_webkit_WebView_Handler")]
		public virtual unsafe void SetupWebView (global::Android.Webkit.WebView webView)
		{
			const string __id = "setupWebView.(Landroid/webkit/WebView;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((webView == null) ? IntPtr.Zero : ((global::Java.Lang.Object) webView).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_stopTracking;
#pragma warning disable 0169
		static Delegate GetStopTrackingHandler ()
		{
			if (cb_stopTracking == null)
				cb_stopTracking = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_StopTracking);
			return cb_stopTracking;
		}

		static void n_StopTracking (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Webtrekk.Webtrekksdk.Webtrekk __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Webtrekk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StopTracking ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='Webtrekk']/method[@name='stopTracking' and count(parameter)=0]"
		[Register ("stopTracking", "()V", "GetStopTrackingHandler")]
		public virtual unsafe void StopTracking ()
		{
			const string __id = "stopTracking.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_track;
#pragma warning disable 0169
		static Delegate GetTrackHandler ()
		{
			if (cb_track == null)
				cb_track = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Track);
			return cb_track;
		}

		static void n_Track (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Webtrekk.Webtrekksdk.Webtrekk __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Webtrekk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Track ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='Webtrekk']/method[@name='track' and count(parameter)=0]"
		[Register ("track", "()V", "GetTrackHandler")]
		public virtual unsafe void Track ()
		{
			const string __id = "track.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_track_Lcom_webtrekk_webtrekksdk_TrackingParameter_;
#pragma warning disable 0169
		static Delegate GetTrack_Lcom_webtrekk_webtrekksdk_TrackingParameter_Handler ()
		{
			if (cb_track_Lcom_webtrekk_webtrekksdk_TrackingParameter_ == null)
				cb_track_Lcom_webtrekk_webtrekksdk_TrackingParameter_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Track_Lcom_webtrekk_webtrekksdk_TrackingParameter_);
			return cb_track_Lcom_webtrekk_webtrekksdk_TrackingParameter_;
		}

		static void n_Track_Lcom_webtrekk_webtrekksdk_TrackingParameter_ (IntPtr jnienv, IntPtr native__this, IntPtr native_tp)
		{
			global::Com.Webtrekk.Webtrekksdk.Webtrekk __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Webtrekk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Webtrekk.Webtrekksdk.TrackingParameter tp = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.TrackingParameter> (native_tp, JniHandleOwnership.DoNotTransfer);
			__this.Track (tp);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='Webtrekk']/method[@name='track' and count(parameter)=1 and parameter[1][@type='com.webtrekk.webtrekksdk.TrackingParameter']]"
		[Register ("track", "(Lcom/webtrekk/webtrekksdk/TrackingParameter;)V", "GetTrack_Lcom_webtrekk_webtrekksdk_TrackingParameter_Handler")]
		public virtual unsafe void Track (global::Com.Webtrekk.Webtrekksdk.TrackingParameter tp)
		{
			const string __id = "track.(Lcom/webtrekk/webtrekksdk/TrackingParameter;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((tp == null) ? IntPtr.Zero : ((global::Java.Lang.Object) tp).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_track_Lcom_webtrekk_webtrekksdk_WebtrekkUserParameters_;
#pragma warning disable 0169
		static Delegate GetTrack_Lcom_webtrekk_webtrekksdk_WebtrekkUserParameters_Handler ()
		{
			if (cb_track_Lcom_webtrekk_webtrekksdk_WebtrekkUserParameters_ == null)
				cb_track_Lcom_webtrekk_webtrekksdk_WebtrekkUserParameters_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Track_Lcom_webtrekk_webtrekksdk_WebtrekkUserParameters_);
			return cb_track_Lcom_webtrekk_webtrekksdk_WebtrekkUserParameters_;
		}

		static void n_Track_Lcom_webtrekk_webtrekksdk_WebtrekkUserParameters_ (IntPtr jnienv, IntPtr native__this, IntPtr native_userParameters)
		{
			global::Com.Webtrekk.Webtrekksdk.Webtrekk __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Webtrekk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Webtrekk.Webtrekksdk.WebtrekkUserParameters userParameters = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.WebtrekkUserParameters> (native_userParameters, JniHandleOwnership.DoNotTransfer);
			__this.Track (userParameters);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='Webtrekk']/method[@name='track' and count(parameter)=1 and parameter[1][@type='com.webtrekk.webtrekksdk.WebtrekkUserParameters']]"
		[Register ("track", "(Lcom/webtrekk/webtrekksdk/WebtrekkUserParameters;)V", "GetTrack_Lcom_webtrekk_webtrekksdk_WebtrekkUserParameters_Handler")]
		public virtual unsafe void Track (global::Com.Webtrekk.Webtrekksdk.WebtrekkUserParameters userParameters)
		{
			const string __id = "track.(Lcom/webtrekk/webtrekksdk/WebtrekkUserParameters;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((userParameters == null) ? IntPtr.Zero : ((global::Java.Lang.Object) userParameters).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_trackException_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetTrackException_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_trackException_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_trackException_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_TrackException_Ljava_lang_String_Ljava_lang_String_);
			return cb_trackException_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_TrackException_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name, IntPtr native_message)
		{
			global::Com.Webtrekk.Webtrekksdk.Webtrekk __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Webtrekk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			string message = JNIEnv.GetString (native_message, JniHandleOwnership.DoNotTransfer);
			__this.TrackException (name, message);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='Webtrekk']/method[@name='trackException' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("trackException", "(Ljava/lang/String;Ljava/lang/String;)V", "GetTrackException_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void TrackException (string name, string message)
		{
			const string __id = "trackException.(Ljava/lang/String;Ljava/lang/String;)V";
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

		static Delegate cb_trackException_Ljava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetTrackException_Ljava_lang_Throwable_Handler ()
		{
			if (cb_trackException_Ljava_lang_Throwable_ == null)
				cb_trackException_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_TrackException_Ljava_lang_Throwable_);
			return cb_trackException_Ljava_lang_Throwable_;
		}

		static void n_TrackException_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_ex)
		{
			global::Com.Webtrekk.Webtrekksdk.Webtrekk __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Webtrekk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Throwable ex = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_ex, JniHandleOwnership.DoNotTransfer);
			__this.TrackException (ex);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='Webtrekk']/method[@name='trackException' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register ("trackException", "(Ljava/lang/Throwable;)V", "GetTrackException_Ljava_lang_Throwable_Handler")]
		public virtual unsafe void TrackException (global::Java.Lang.Throwable ex)
		{
			const string __id = "trackException.(Ljava/lang/Throwable;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((ex == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) ex).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
