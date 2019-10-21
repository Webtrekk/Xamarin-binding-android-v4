using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Webtrekk.Webtrekksdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='WebtrekkUserParameters']"
	[global::Android.Runtime.Register ("com/webtrekk/webtrekksdk/WebtrekkUserParameters", DoNotGenerateAcw=true)]
	public partial class WebtrekkUserParameters : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/webtrekk/webtrekksdk/WebtrekkUserParameters", typeof (WebtrekkUserParameters));
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

		protected WebtrekkUserParameters (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='WebtrekkUserParameters']/constructor[@name='WebtrekkUserParameters' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe WebtrekkUserParameters ()
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

		static Delegate cb_setAddress_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAddress_Ljava_lang_String_Handler ()
		{
			if (cb_setAddress_Ljava_lang_String_ == null)
				cb_setAddress_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetAddress_Ljava_lang_String_);
			return cb_setAddress_Ljava_lang_String_;
		}

		static IntPtr n_SetAddress_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_address)
		{
			global::Com.Webtrekk.Webtrekksdk.WebtrekkUserParameters __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.WebtrekkUserParameters> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string address = JNIEnv.GetString (native_address, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetAddress (address));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='WebtrekkUserParameters']/method[@name='setAddress' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setAddress", "(Ljava/lang/String;)Lcom/webtrekk/webtrekksdk/WebtrekkUserParameters;", "GetSetAddress_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Webtrekk.Webtrekksdk.WebtrekkUserParameters SetAddress (string address)
		{
			const string __id = "setAddress.(Ljava/lang/String;)Lcom/webtrekk/webtrekksdk/WebtrekkUserParameters;";
			IntPtr native_address = JNIEnv.NewString (address);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_address);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.WebtrekkUserParameters> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_address);
			}
		}

		static Delegate cb_setAddressMD5_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAddressMD5_Ljava_lang_String_Handler ()
		{
			if (cb_setAddressMD5_Ljava_lang_String_ == null)
				cb_setAddressMD5_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetAddressMD5_Ljava_lang_String_);
			return cb_setAddressMD5_Ljava_lang_String_;
		}

		static IntPtr n_SetAddressMD5_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_addressMD5)
		{
			global::Com.Webtrekk.Webtrekksdk.WebtrekkUserParameters __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.WebtrekkUserParameters> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string addressMD5 = JNIEnv.GetString (native_addressMD5, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetAddressMD5 (addressMD5));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='WebtrekkUserParameters']/method[@name='setAddressMD5' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setAddressMD5", "(Ljava/lang/String;)Lcom/webtrekk/webtrekksdk/WebtrekkUserParameters;", "GetSetAddressMD5_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Webtrekk.Webtrekksdk.WebtrekkUserParameters SetAddressMD5 (string addressMD5)
		{
			const string __id = "setAddressMD5.(Ljava/lang/String;)Lcom/webtrekk/webtrekksdk/WebtrekkUserParameters;";
			IntPtr native_addressMD5 = JNIEnv.NewString (addressMD5);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_addressMD5);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.WebtrekkUserParameters> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_addressMD5);
			}
		}

		static Delegate cb_setAddressSHA256_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAddressSHA256_Ljava_lang_String_Handler ()
		{
			if (cb_setAddressSHA256_Ljava_lang_String_ == null)
				cb_setAddressSHA256_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetAddressSHA256_Ljava_lang_String_);
			return cb_setAddressSHA256_Ljava_lang_String_;
		}

		static IntPtr n_SetAddressSHA256_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_addressSHA256)
		{
			global::Com.Webtrekk.Webtrekksdk.WebtrekkUserParameters __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.WebtrekkUserParameters> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string addressSHA256 = JNIEnv.GetString (native_addressSHA256, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetAddressSHA256 (addressSHA256));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='WebtrekkUserParameters']/method[@name='setAddressSHA256' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setAddressSHA256", "(Ljava/lang/String;)Lcom/webtrekk/webtrekksdk/WebtrekkUserParameters;", "GetSetAddressSHA256_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Webtrekk.Webtrekksdk.WebtrekkUserParameters SetAddressSHA256 (string addressSHA256)
		{
			const string __id = "setAddressSHA256.(Ljava/lang/String;)Lcom/webtrekk/webtrekksdk/WebtrekkUserParameters;";
			IntPtr native_addressSHA256 = JNIEnv.NewString (addressSHA256);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_addressSHA256);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.WebtrekkUserParameters> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_addressSHA256);
			}
		}

		static Delegate cb_setAndroidId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAndroidId_Ljava_lang_String_Handler ()
		{
			if (cb_setAndroidId_Ljava_lang_String_ == null)
				cb_setAndroidId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetAndroidId_Ljava_lang_String_);
			return cb_setAndroidId_Ljava_lang_String_;
		}

		static IntPtr n_SetAndroidId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_androidId)
		{
			global::Com.Webtrekk.Webtrekksdk.WebtrekkUserParameters __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.WebtrekkUserParameters> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string androidId = JNIEnv.GetString (native_androidId, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetAndroidId (androidId));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='WebtrekkUserParameters']/method[@name='setAndroidId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setAndroidId", "(Ljava/lang/String;)Lcom/webtrekk/webtrekksdk/WebtrekkUserParameters;", "GetSetAndroidId_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Webtrekk.Webtrekksdk.WebtrekkUserParameters SetAndroidId (string androidId)
		{
			const string __id = "setAndroidId.(Ljava/lang/String;)Lcom/webtrekk/webtrekksdk/WebtrekkUserParameters;";
			IntPtr native_androidId = JNIEnv.NewString (androidId);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_androidId);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.WebtrekkUserParameters> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_androidId);
			}
		}

		static Delegate cb_setCustom_ILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetCustom_ILjava_lang_String_Handler ()
		{
			if (cb_setCustom_ILjava_lang_String_ == null)
				cb_setCustom_ILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr>) n_SetCustom_ILjava_lang_String_);
			return cb_setCustom_ILjava_lang_String_;
		}

		static IntPtr n_SetCustom_ILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, int id, IntPtr native_value)
		{
			global::Com.Webtrekk.Webtrekksdk.WebtrekkUserParameters __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.WebtrekkUserParameters> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetCustom (id, value));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='WebtrekkUserParameters']/method[@name='setCustom' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
		[Register ("setCustom", "(ILjava/lang/String;)Lcom/webtrekk/webtrekksdk/WebtrekkUserParameters;", "GetSetCustom_ILjava_lang_String_Handler")]
		public virtual unsafe global::Com.Webtrekk.Webtrekksdk.WebtrekkUserParameters SetCustom (int id, string value)
		{
			const string __id = "setCustom.(ILjava/lang/String;)Lcom/webtrekk/webtrekksdk/WebtrekkUserParameters;";
			IntPtr native_value = JNIEnv.NewString (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (id);
				__args [1] = new JniArgumentValue (native_value);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.WebtrekkUserParameters> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_setEmail_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetEmail_Ljava_lang_String_Handler ()
		{
			if (cb_setEmail_Ljava_lang_String_ == null)
				cb_setEmail_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetEmail_Ljava_lang_String_);
			return cb_setEmail_Ljava_lang_String_;
		}

		static IntPtr n_SetEmail_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_email)
		{
			global::Com.Webtrekk.Webtrekksdk.WebtrekkUserParameters __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.WebtrekkUserParameters> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string email = JNIEnv.GetString (native_email, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetEmail (email));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='WebtrekkUserParameters']/method[@name='setEmail' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setEmail", "(Ljava/lang/String;)Lcom/webtrekk/webtrekksdk/WebtrekkUserParameters;", "GetSetEmail_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Webtrekk.Webtrekksdk.WebtrekkUserParameters SetEmail (string email)
		{
			const string __id = "setEmail.(Ljava/lang/String;)Lcom/webtrekk/webtrekksdk/WebtrekkUserParameters;";
			IntPtr native_email = JNIEnv.NewString (email);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_email);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.WebtrekkUserParameters> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_email);
			}
		}

		static Delegate cb_setEmailMD5_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetEmailMD5_Ljava_lang_String_Handler ()
		{
			if (cb_setEmailMD5_Ljava_lang_String_ == null)
				cb_setEmailMD5_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetEmailMD5_Ljava_lang_String_);
			return cb_setEmailMD5_Ljava_lang_String_;
		}

		static IntPtr n_SetEmailMD5_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_emailMD5)
		{
			global::Com.Webtrekk.Webtrekksdk.WebtrekkUserParameters __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.WebtrekkUserParameters> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string emailMD5 = JNIEnv.GetString (native_emailMD5, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetEmailMD5 (emailMD5));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='WebtrekkUserParameters']/method[@name='setEmailMD5' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setEmailMD5", "(Ljava/lang/String;)Lcom/webtrekk/webtrekksdk/WebtrekkUserParameters;", "GetSetEmailMD5_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Webtrekk.Webtrekksdk.WebtrekkUserParameters SetEmailMD5 (string emailMD5)
		{
			const string __id = "setEmailMD5.(Ljava/lang/String;)Lcom/webtrekk/webtrekksdk/WebtrekkUserParameters;";
			IntPtr native_emailMD5 = JNIEnv.NewString (emailMD5);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_emailMD5);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.WebtrekkUserParameters> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_emailMD5);
			}
		}

		static Delegate cb_setEmailSHA256_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetEmailSHA256_Ljava_lang_String_Handler ()
		{
			if (cb_setEmailSHA256_Ljava_lang_String_ == null)
				cb_setEmailSHA256_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetEmailSHA256_Ljava_lang_String_);
			return cb_setEmailSHA256_Ljava_lang_String_;
		}

		static IntPtr n_SetEmailSHA256_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_emailSHA256)
		{
			global::Com.Webtrekk.Webtrekksdk.WebtrekkUserParameters __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.WebtrekkUserParameters> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string emailSHA256 = JNIEnv.GetString (native_emailSHA256, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetEmailSHA256 (emailSHA256));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='WebtrekkUserParameters']/method[@name='setEmailSHA256' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setEmailSHA256", "(Ljava/lang/String;)Lcom/webtrekk/webtrekksdk/WebtrekkUserParameters;", "GetSetEmailSHA256_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Webtrekk.Webtrekksdk.WebtrekkUserParameters SetEmailSHA256 (string emailSHA256)
		{
			const string __id = "setEmailSHA256.(Ljava/lang/String;)Lcom/webtrekk/webtrekksdk/WebtrekkUserParameters;";
			IntPtr native_emailSHA256 = JNIEnv.NewString (emailSHA256);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_emailSHA256);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.WebtrekkUserParameters> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_emailSHA256);
			}
		}

		static Delegate cb_setFacebookID_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetFacebookID_Ljava_lang_String_Handler ()
		{
			if (cb_setFacebookID_Ljava_lang_String_ == null)
				cb_setFacebookID_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetFacebookID_Ljava_lang_String_);
			return cb_setFacebookID_Ljava_lang_String_;
		}

		static IntPtr n_SetFacebookID_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_facebookID)
		{
			global::Com.Webtrekk.Webtrekksdk.WebtrekkUserParameters __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.WebtrekkUserParameters> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string facebookID = JNIEnv.GetString (native_facebookID, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetFacebookID (facebookID));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='WebtrekkUserParameters']/method[@name='setFacebookID' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setFacebookID", "(Ljava/lang/String;)Lcom/webtrekk/webtrekksdk/WebtrekkUserParameters;", "GetSetFacebookID_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Webtrekk.Webtrekksdk.WebtrekkUserParameters SetFacebookID (string facebookID)
		{
			const string __id = "setFacebookID.(Ljava/lang/String;)Lcom/webtrekk/webtrekksdk/WebtrekkUserParameters;";
			IntPtr native_facebookID = JNIEnv.NewString (facebookID);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_facebookID);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.WebtrekkUserParameters> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_facebookID);
			}
		}

		static Delegate cb_setGooglePlusID_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetGooglePlusID_Ljava_lang_String_Handler ()
		{
			if (cb_setGooglePlusID_Ljava_lang_String_ == null)
				cb_setGooglePlusID_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetGooglePlusID_Ljava_lang_String_);
			return cb_setGooglePlusID_Ljava_lang_String_;
		}

		static IntPtr n_SetGooglePlusID_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_googlePlusID)
		{
			global::Com.Webtrekk.Webtrekksdk.WebtrekkUserParameters __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.WebtrekkUserParameters> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string googlePlusID = JNIEnv.GetString (native_googlePlusID, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetGooglePlusID (googlePlusID));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='WebtrekkUserParameters']/method[@name='setGooglePlusID' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setGooglePlusID", "(Ljava/lang/String;)Lcom/webtrekk/webtrekksdk/WebtrekkUserParameters;", "GetSetGooglePlusID_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Webtrekk.Webtrekksdk.WebtrekkUserParameters SetGooglePlusID (string googlePlusID)
		{
			const string __id = "setGooglePlusID.(Ljava/lang/String;)Lcom/webtrekk/webtrekksdk/WebtrekkUserParameters;";
			IntPtr native_googlePlusID = JNIEnv.NewString (googlePlusID);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_googlePlusID);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.WebtrekkUserParameters> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_googlePlusID);
			}
		}

		static Delegate cb_setLinkedInID_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetLinkedInID_Ljava_lang_String_Handler ()
		{
			if (cb_setLinkedInID_Ljava_lang_String_ == null)
				cb_setLinkedInID_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetLinkedInID_Ljava_lang_String_);
			return cb_setLinkedInID_Ljava_lang_String_;
		}

		static IntPtr n_SetLinkedInID_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_linkedInID)
		{
			global::Com.Webtrekk.Webtrekksdk.WebtrekkUserParameters __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.WebtrekkUserParameters> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string linkedInID = JNIEnv.GetString (native_linkedInID, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetLinkedInID (linkedInID));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='WebtrekkUserParameters']/method[@name='setLinkedInID' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setLinkedInID", "(Ljava/lang/String;)Lcom/webtrekk/webtrekksdk/WebtrekkUserParameters;", "GetSetLinkedInID_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Webtrekk.Webtrekksdk.WebtrekkUserParameters SetLinkedInID (string linkedInID)
		{
			const string __id = "setLinkedInID.(Ljava/lang/String;)Lcom/webtrekk/webtrekksdk/WebtrekkUserParameters;";
			IntPtr native_linkedInID = JNIEnv.NewString (linkedInID);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_linkedInID);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.WebtrekkUserParameters> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_linkedInID);
			}
		}

		static Delegate cb_setPhone_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetPhone_Ljava_lang_String_Handler ()
		{
			if (cb_setPhone_Ljava_lang_String_ == null)
				cb_setPhone_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetPhone_Ljava_lang_String_);
			return cb_setPhone_Ljava_lang_String_;
		}

		static IntPtr n_SetPhone_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_phone)
		{
			global::Com.Webtrekk.Webtrekksdk.WebtrekkUserParameters __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.WebtrekkUserParameters> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string phone = JNIEnv.GetString (native_phone, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetPhone (phone));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='WebtrekkUserParameters']/method[@name='setPhone' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setPhone", "(Ljava/lang/String;)Lcom/webtrekk/webtrekksdk/WebtrekkUserParameters;", "GetSetPhone_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Webtrekk.Webtrekksdk.WebtrekkUserParameters SetPhone (string phone)
		{
			const string __id = "setPhone.(Ljava/lang/String;)Lcom/webtrekk/webtrekksdk/WebtrekkUserParameters;";
			IntPtr native_phone = JNIEnv.NewString (phone);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_phone);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.WebtrekkUserParameters> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_phone);
			}
		}

		static Delegate cb_setPhoneMD5_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetPhoneMD5_Ljava_lang_String_Handler ()
		{
			if (cb_setPhoneMD5_Ljava_lang_String_ == null)
				cb_setPhoneMD5_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetPhoneMD5_Ljava_lang_String_);
			return cb_setPhoneMD5_Ljava_lang_String_;
		}

		static IntPtr n_SetPhoneMD5_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_phoneMD5)
		{
			global::Com.Webtrekk.Webtrekksdk.WebtrekkUserParameters __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.WebtrekkUserParameters> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string phoneMD5 = JNIEnv.GetString (native_phoneMD5, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetPhoneMD5 (phoneMD5));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='WebtrekkUserParameters']/method[@name='setPhoneMD5' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setPhoneMD5", "(Ljava/lang/String;)Lcom/webtrekk/webtrekksdk/WebtrekkUserParameters;", "GetSetPhoneMD5_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Webtrekk.Webtrekksdk.WebtrekkUserParameters SetPhoneMD5 (string phoneMD5)
		{
			const string __id = "setPhoneMD5.(Ljava/lang/String;)Lcom/webtrekk/webtrekksdk/WebtrekkUserParameters;";
			IntPtr native_phoneMD5 = JNIEnv.NewString (phoneMD5);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_phoneMD5);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.WebtrekkUserParameters> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_phoneMD5);
			}
		}

		static Delegate cb_setPhoneSHA256_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetPhoneSHA256_Ljava_lang_String_Handler ()
		{
			if (cb_setPhoneSHA256_Ljava_lang_String_ == null)
				cb_setPhoneSHA256_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetPhoneSHA256_Ljava_lang_String_);
			return cb_setPhoneSHA256_Ljava_lang_String_;
		}

		static IntPtr n_SetPhoneSHA256_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_phoneSHA256)
		{
			global::Com.Webtrekk.Webtrekksdk.WebtrekkUserParameters __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.WebtrekkUserParameters> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string phoneSHA256 = JNIEnv.GetString (native_phoneSHA256, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetPhoneSHA256 (phoneSHA256));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='WebtrekkUserParameters']/method[@name='setPhoneSHA256' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setPhoneSHA256", "(Ljava/lang/String;)Lcom/webtrekk/webtrekksdk/WebtrekkUserParameters;", "GetSetPhoneSHA256_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Webtrekk.Webtrekksdk.WebtrekkUserParameters SetPhoneSHA256 (string phoneSHA256)
		{
			const string __id = "setPhoneSHA256.(Ljava/lang/String;)Lcom/webtrekk/webtrekksdk/WebtrekkUserParameters;";
			IntPtr native_phoneSHA256 = JNIEnv.NewString (phoneSHA256);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_phoneSHA256);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.WebtrekkUserParameters> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_phoneSHA256);
			}
		}

		static Delegate cb_setTwitterID_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetTwitterID_Ljava_lang_String_Handler ()
		{
			if (cb_setTwitterID_Ljava_lang_String_ == null)
				cb_setTwitterID_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetTwitterID_Ljava_lang_String_);
			return cb_setTwitterID_Ljava_lang_String_;
		}

		static IntPtr n_SetTwitterID_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_twitterID)
		{
			global::Com.Webtrekk.Webtrekksdk.WebtrekkUserParameters __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.WebtrekkUserParameters> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string twitterID = JNIEnv.GetString (native_twitterID, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetTwitterID (twitterID));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='WebtrekkUserParameters']/method[@name='setTwitterID' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setTwitterID", "(Ljava/lang/String;)Lcom/webtrekk/webtrekksdk/WebtrekkUserParameters;", "GetSetTwitterID_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Webtrekk.Webtrekksdk.WebtrekkUserParameters SetTwitterID (string twitterID)
		{
			const string __id = "setTwitterID.(Ljava/lang/String;)Lcom/webtrekk/webtrekksdk/WebtrekkUserParameters;";
			IntPtr native_twitterID = JNIEnv.NewString (twitterID);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_twitterID);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.WebtrekkUserParameters> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_twitterID);
			}
		}

		static Delegate cb_setWindowsId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetWindowsId_Ljava_lang_String_Handler ()
		{
			if (cb_setWindowsId_Ljava_lang_String_ == null)
				cb_setWindowsId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetWindowsId_Ljava_lang_String_);
			return cb_setWindowsId_Ljava_lang_String_;
		}

		static IntPtr n_SetWindowsId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_windowsId)
		{
			global::Com.Webtrekk.Webtrekksdk.WebtrekkUserParameters __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.WebtrekkUserParameters> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string windowsId = JNIEnv.GetString (native_windowsId, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetWindowsId (windowsId));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='WebtrekkUserParameters']/method[@name='setWindowsId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setWindowsId", "(Ljava/lang/String;)Lcom/webtrekk/webtrekksdk/WebtrekkUserParameters;", "GetSetWindowsId_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Webtrekk.Webtrekksdk.WebtrekkUserParameters SetWindowsId (string windowsId)
		{
			const string __id = "setWindowsId.(Ljava/lang/String;)Lcom/webtrekk/webtrekksdk/WebtrekkUserParameters;";
			IntPtr native_windowsId = JNIEnv.NewString (windowsId);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_windowsId);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.WebtrekkUserParameters> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_windowsId);
			}
		}

		static Delegate cb_setiOSId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetiOSId_Ljava_lang_String_Handler ()
		{
			if (cb_setiOSId_Ljava_lang_String_ == null)
				cb_setiOSId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetiOSId_Ljava_lang_String_);
			return cb_setiOSId_Ljava_lang_String_;
		}

		static IntPtr n_SetiOSId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_iOSId)
		{
			global::Com.Webtrekk.Webtrekksdk.WebtrekkUserParameters __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.WebtrekkUserParameters> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string iOSId = JNIEnv.GetString (native_iOSId, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetiOSId (iOSId));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='WebtrekkUserParameters']/method[@name='setiOSId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setiOSId", "(Ljava/lang/String;)Lcom/webtrekk/webtrekksdk/WebtrekkUserParameters;", "GetSetiOSId_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Webtrekk.Webtrekksdk.WebtrekkUserParameters SetiOSId (string iOSId)
		{
			const string __id = "setiOSId.(Ljava/lang/String;)Lcom/webtrekk/webtrekksdk/WebtrekkUserParameters;";
			IntPtr native_iOSId = JNIEnv.NewString (iOSId);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_iOSId);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.WebtrekkUserParameters> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_iOSId);
			}
		}

	}
}
