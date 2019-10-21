using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Webtrekk.Webtrekksdk.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Utils']/class[@name='PinConnectionValidator']"
	[global::Android.Runtime.Register ("com/webtrekk/webtrekksdk/Utils/PinConnectionValidator", DoNotGenerateAcw=true)]
	public partial class PinConnectionValidator : global::Java.Lang.Object {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Utils']/interface[@name='PinConnectionValidator.TrustChecker']"
		[Register ("com/webtrekk/webtrekksdk/Utils/PinConnectionValidator$TrustChecker", "", "Com.Webtrekk.Webtrekksdk.Utils.PinConnectionValidator/ITrustCheckerInvoker")]
		public partial interface ITrustChecker : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Utils']/interface[@name='PinConnectionValidator.TrustChecker']/method[@name='checkServerTrusted' and count(parameter)=3 and parameter[1][@type='java.security.cert.X509Certificate[]'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
			[Register ("checkServerTrusted", "([Ljava/security/cert/X509Certificate;Ljava/lang/String;Ljava/lang/String;)Ljava/util/List;", "GetCheckServerTrusted_arrayLjava_security_cert_X509Certificate_Ljava_lang_String_Ljava_lang_String_Handler:Com.Webtrekk.Webtrekksdk.Utils.PinConnectionValidator/ITrustCheckerInvoker, webtrekkLibrary")]
			global::System.Collections.Generic.IList<global::Java.Security.Cert.X509Certificate> CheckServerTrusted (global::Java.Security.Cert.X509Certificate[] p0, string p1, string p2);

		}

		[global::Android.Runtime.Register ("com/webtrekk/webtrekksdk/Utils/PinConnectionValidator$TrustChecker", DoNotGenerateAcw=true)]
		internal class ITrustCheckerInvoker : global::Java.Lang.Object, ITrustChecker {

			internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/webtrekk/webtrekksdk/Utils/PinConnectionValidator$TrustChecker", typeof (ITrustCheckerInvoker));

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

			public static ITrustChecker GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<ITrustChecker> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.webtrekk.webtrekksdk.Utils.PinConnectionValidator.TrustChecker"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public ITrustCheckerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_checkServerTrusted_arrayLjava_security_cert_X509Certificate_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetCheckServerTrusted_arrayLjava_security_cert_X509Certificate_Ljava_lang_String_Ljava_lang_String_Handler ()
			{
				if (cb_checkServerTrusted_arrayLjava_security_cert_X509Certificate_Ljava_lang_String_Ljava_lang_String_ == null)
					cb_checkServerTrusted_arrayLjava_security_cert_X509Certificate_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_CheckServerTrusted_arrayLjava_security_cert_X509Certificate_Ljava_lang_String_Ljava_lang_String_);
				return cb_checkServerTrusted_arrayLjava_security_cert_X509Certificate_Ljava_lang_String_Ljava_lang_String_;
			}

			static IntPtr n_CheckServerTrusted_arrayLjava_security_cert_X509Certificate_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
			{
				global::Com.Webtrekk.Webtrekksdk.Utils.PinConnectionValidator.ITrustChecker __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Utils.PinConnectionValidator.ITrustChecker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Security.Cert.X509Certificate[] p0 = (global::Java.Security.Cert.X509Certificate[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Security.Cert.X509Certificate));
				string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
				string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = global::Android.Runtime.JavaList<global::Java.Security.Cert.X509Certificate>.ToLocalJniHandle (__this.CheckServerTrusted (p0, p1, p2));
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_checkServerTrusted_arrayLjava_security_cert_X509Certificate_Ljava_lang_String_Ljava_lang_String_;
			public unsafe global::System.Collections.Generic.IList<global::Java.Security.Cert.X509Certificate> CheckServerTrusted (global::Java.Security.Cert.X509Certificate[] p0, string p1, string p2)
			{
				if (id_checkServerTrusted_arrayLjava_security_cert_X509Certificate_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_checkServerTrusted_arrayLjava_security_cert_X509Certificate_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "checkServerTrusted", "([Ljava/security/cert/X509Certificate;Ljava/lang/String;Ljava/lang/String;)Ljava/util/List;");
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				IntPtr native_p1 = JNIEnv.NewString (p1);
				IntPtr native_p2 = JNIEnv.NewString (p2);
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				global::System.Collections.Generic.IList<global::Java.Security.Cert.X509Certificate> __ret = global::Android.Runtime.JavaList<global::Java.Security.Cert.X509Certificate>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_checkServerTrusted_arrayLjava_security_cert_X509Certificate_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				return __ret;
			}

		}


		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/webtrekk/webtrekksdk/Utils/PinConnectionValidator", typeof (PinConnectionValidator));
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

		protected PinConnectionValidator (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Utils']/class[@name='PinConnectionValidator']/constructor[@name='PinConnectionValidator' and count(parameter)=1 and parameter[1][@type='java.util.Set&lt;java.lang.String&gt;']]"
		[Register (".ctor", "(Ljava/util/Set;)V", "")]
		public unsafe PinConnectionValidator (global::System.Collections.Generic.ICollection<string> validPins)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/util/Set;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_validPins = global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (validPins);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_validPins);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_validPins);
			}
		}

		static Delegate cb_validatePinning_Ljavax_net_ssl_HttpsURLConnection_;
#pragma warning disable 0169
		static Delegate GetValidatePinning_Ljavax_net_ssl_HttpsURLConnection_Handler ()
		{
			if (cb_validatePinning_Ljavax_net_ssl_HttpsURLConnection_ == null)
				cb_validatePinning_Ljavax_net_ssl_HttpsURLConnection_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ValidatePinning_Ljavax_net_ssl_HttpsURLConnection_);
			return cb_validatePinning_Ljavax_net_ssl_HttpsURLConnection_;
		}

		static void n_ValidatePinning_Ljavax_net_ssl_HttpsURLConnection_ (IntPtr jnienv, IntPtr native__this, IntPtr native_conn)
		{
			global::Com.Webtrekk.Webtrekksdk.Utils.PinConnectionValidator __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Utils.PinConnectionValidator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Javax.Net.Ssl.HttpsURLConnection conn = global::Java.Lang.Object.GetObject<global::Javax.Net.Ssl.HttpsURLConnection> (native_conn, JniHandleOwnership.DoNotTransfer);
			__this.ValidatePinning (conn);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Utils']/class[@name='PinConnectionValidator']/method[@name='validatePinning' and count(parameter)=1 and parameter[1][@type='javax.net.ssl.HttpsURLConnection']]"
		[Register ("validatePinning", "(Ljavax/net/ssl/HttpsURLConnection;)V", "GetValidatePinning_Ljavax_net_ssl_HttpsURLConnection_Handler")]
		public virtual unsafe void ValidatePinning (global::Javax.Net.Ssl.HttpsURLConnection conn)
		{
			const string __id = "validatePinning.(Ljavax/net/ssl/HttpsURLConnection;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((conn == null) ? IntPtr.Zero : ((global::Java.Lang.Object) conn).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
