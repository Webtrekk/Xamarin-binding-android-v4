using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Webtrekk.Webtrekksdk.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Utils']/class[@name='HelperFunctions']"
	[global::Android.Runtime.Register ("com/webtrekk/webtrekksdk/Utils/HelperFunctions", DoNotGenerateAcw=true)]
	public sealed partial class HelperFunctions : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/webtrekk/webtrekksdk/Utils/HelperFunctions", typeof (HelperFunctions));
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

		internal HelperFunctions (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		public static unsafe string APILevel {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Utils']/class[@name='HelperFunctions']/method[@name='getAPILevel' and count(parameter)=0]"
			[Register ("getAPILevel", "()Ljava/lang/String;", "GetGetAPILevelHandler")]
			get {
				const string __id = "getAPILevel.()Ljava/lang/String;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public static unsafe string Country {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Utils']/class[@name='HelperFunctions']/method[@name='getCountry' and count(parameter)=0]"
			[Register ("getCountry", "()Ljava/lang/String;", "GetGetCountryHandler")]
			get {
				const string __id = "getCountry.()Ljava/lang/String;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public static unsafe string Device {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Utils']/class[@name='HelperFunctions']/method[@name='getDevice' and count(parameter)=0]"
			[Register ("getDevice", "()Ljava/lang/String;", "GetGetDeviceHandler")]
			get {
				const string __id = "getDevice.()Ljava/lang/String;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public static unsafe string HttpUserAgent {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Utils']/class[@name='HelperFunctions']/method[@name='getHttpUserAgent' and count(parameter)=0]"
			[Register ("getHttpUserAgent", "()Ljava/lang/String;", "GetGetHttpUserAgentHandler")]
			get {
				const string __id = "getHttpUserAgent.()Ljava/lang/String;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public static unsafe bool IsTls12Supported {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Utils']/class[@name='HelperFunctions']/method[@name='isTls12Supported' and count(parameter)=0]"
			[Register ("isTls12Supported", "()Z", "GetIsTls12SupportedHandler")]
			get {
				const string __id = "isTls12Supported.()Z";
				try {
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, null);
					return __rm;
				} finally {
				}
			}
		}

		public static unsafe string Language {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Utils']/class[@name='HelperFunctions']/method[@name='getLanguage' and count(parameter)=0]"
			[Register ("getLanguage", "()Ljava/lang/String;", "GetGetLanguageHandler")]
			get {
				const string __id = "getLanguage.()Ljava/lang/String;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public static unsafe string OSName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Utils']/class[@name='HelperFunctions']/method[@name='getOSName' and count(parameter)=0]"
			[Register ("getOSName", "()Ljava/lang/String;", "GetGetOSNameHandler")]
			get {
				const string __id = "getOSName.()Ljava/lang/String;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public static unsafe string OSVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Utils']/class[@name='HelperFunctions']/method[@name='getOSVersion' and count(parameter)=0]"
			[Register ("getOSVersion", "()Ljava/lang/String;", "GetGetOSVersionHandler")]
			get {
				const string __id = "getOSVersion.()Ljava/lang/String;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public static unsafe string Timezone {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Utils']/class[@name='HelperFunctions']/method[@name='getTimezone' and count(parameter)=0]"
			[Register ("getTimezone", "()Ljava/lang/String;", "GetGetTimezoneHandler")]
			get {
				const string __id = "getTimezone.()Ljava/lang/String;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public static unsafe string UserAgent {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Utils']/class[@name='HelperFunctions']/method[@name='getUserAgent' and count(parameter)=0]"
			[Register ("getUserAgent", "()Ljava/lang/String;", "GetGetUserAgentHandler")]
			get {
				const string __id = "getUserAgent.()Ljava/lang/String;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Utils']/class[@name='HelperFunctions']/method[@name='firstStart' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("firstStart", "(Landroid/content/Context;)Z", "")]
		public static unsafe bool FirstStart (global::Android.Content.Context context)
		{
			const string __id = "firstStart.(Landroid/content/Context;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Utils']/class[@name='HelperFunctions']/method[@name='generateEverid' and count(parameter)=0]"
		[Register ("generateEverid", "()Ljava/lang/String;", "")]
		public static unsafe string GenerateEverid ()
		{
			const string __id = "generateEverid.()Ljava/lang/String;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Utils']/class[@name='HelperFunctions']/method[@name='getAdClearId' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getAdClearId", "(Landroid/content/Context;)J", "")]
		public static unsafe long GetAdClearId (global::Android.Content.Context context)
		{
			const string __id = "getAdClearId.(Landroid/content/Context;)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.StaticMethods.InvokeInt64Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Utils']/class[@name='HelperFunctions']/method[@name='getAppVersionCode' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getAppVersionCode", "(Landroid/content/Context;)I", "")]
		public static unsafe int GetAppVersionCode (global::Android.Content.Context context)
		{
			const string __id = "getAppVersionCode.(Landroid/content/Context;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Utils']/class[@name='HelperFunctions']/method[@name='getAppVersionName' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getAppVersionName", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public static unsafe string GetAppVersionName (global::Android.Content.Context context)
		{
			const string __id = "getAppVersionName.(Landroid/content/Context;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Utils']/class[@name='HelperFunctions']/method[@name='getConnectionString' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getConnectionString", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public static unsafe string GetConnectionString (global::Android.Content.Context context)
		{
			const string __id = "getConnectionString.(Landroid/content/Context;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Utils']/class[@name='HelperFunctions']/method[@name='getDeepLinkMediaCode' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='boolean']]"
		[Register ("getDeepLinkMediaCode", "(Landroid/content/Context;Z)Ljava/lang/String;", "")]
		public static unsafe string GetDeepLinkMediaCode (global::Android.Content.Context context, bool deleteFlag)
		{
			const string __id = "getDeepLinkMediaCode.(Landroid/content/Context;Z)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (deleteFlag);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Utils']/class[@name='HelperFunctions']/method[@name='getDepth' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getDepth", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public static unsafe string GetDepth (global::Android.Content.Context context)
		{
			const string __id = "getDepth.(Landroid/content/Context;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Utils']/class[@name='HelperFunctions']/method[@name='getEverId' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getEverId", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public static unsafe string GetEverId (global::Android.Content.Context context)
		{
			const string __id = "getEverId.(Landroid/content/Context;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Utils']/class[@name='HelperFunctions']/method[@name='getMailByAccountManager' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getMailByAccountManager", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public static unsafe string GetMailByAccountManager (global::Android.Content.Context context)
		{
			const string __id = "getMailByAccountManager.(Landroid/content/Context;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Utils']/class[@name='HelperFunctions']/method[@name='getOrientation' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getOrientation", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public static unsafe string GetOrientation (global::Android.Content.Context context)
		{
			const string __id = "getOrientation.(Landroid/content/Context;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Utils']/class[@name='HelperFunctions']/method[@name='getResolution' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getResolution", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public static unsafe string GetResolution (global::Android.Content.Context context)
		{
			const string __id = "getResolution.(Landroid/content/Context;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Utils']/class[@name='HelperFunctions']/method[@name='getUserProfile' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getUserProfile", "(Landroid/content/Context;)Ljava/util/Map;", "")]
		public static unsafe global::System.Collections.Generic.IDictionary<string, string> GetUserProfile (global::Android.Content.Context context)
		{
			const string __id = "getUserProfile.(Landroid/content/Context;)Ljava/util/Map;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Utils']/class[@name='HelperFunctions']/method[@name='getWebTrekkSharedPreference' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getWebTrekkSharedPreference", "(Landroid/content/Context;)Landroid/content/SharedPreferences;", "")]
		public static unsafe global::Android.Content.ISharedPreferences GetWebTrekkSharedPreference (global::Android.Content.Context context)
		{
			const string __id = "getWebTrekkSharedPreference.(Landroid/content/Context;)Landroid/content/SharedPreferences;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Content.ISharedPreferences> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Utils']/class[@name='HelperFunctions']/method[@name='getXmlFromUrl' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getXmlFromUrl", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public unsafe string GetXmlFromUrl (string url)
		{
			const string __id = "getXmlFromUrl.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_url = JNIEnv.NewString (url);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_url);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_url);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Utils']/class[@name='HelperFunctions']/method[@name='isAppPreinstalled' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("isAppPreinstalled", "(Landroid/content/Context;)Z", "")]
		public static unsafe bool IsAppPreinstalled (global::Android.Content.Context context)
		{
			const string __id = "isAppPreinstalled.(Landroid/content/Context;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Utils']/class[@name='HelperFunctions']/method[@name='isNetworkConnection' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("isNetworkConnection", "(Landroid/content/Context;)Z", "")]
		public static unsafe bool IsNetworkConnection (global::Android.Content.Context context)
		{
			const string __id = "isNetworkConnection.(Landroid/content/Context;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Utils']/class[@name='HelperFunctions']/method[@name='isNewInstallation' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("isNewInstallation", "(Landroid/content/Context;)Z", "")]
		public static unsafe bool IsNewInstallation (global::Android.Content.Context context)
		{
			const string __id = "isNewInstallation.(Landroid/content/Context;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Utils']/class[@name='HelperFunctions']/method[@name='isRoaming' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("isRoaming", "(Landroid/content/Context;)Z", "")]
		public static unsafe bool IsRoaming (global::Android.Content.Context context)
		{
			const string __id = "isRoaming.(Landroid/content/Context;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Utils']/class[@name='HelperFunctions']/method[@name='isSysAutoRotate' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("isSysAutoRotate", "(Landroid/content/Context;)Z", "")]
		public static unsafe bool IsSysAutoRotate (global::Android.Content.Context context)
		{
			const string __id = "isSysAutoRotate.(Landroid/content/Context;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Utils']/class[@name='HelperFunctions']/method[@name='makeMd5' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("makeMd5", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string MakeMd5 (string value)
		{
			const string __id = "makeMd5.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_value = JNIEnv.NewString (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_value);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Utils']/class[@name='HelperFunctions']/method[@name='makeSha256' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("makeSha256", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string MakeSha256 (string value)
		{
			const string __id = "makeSha256.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_value = JNIEnv.NewString (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_value);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Utils']/class[@name='HelperFunctions']/method[@name='setAppVersionCode' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='android.content.Context']]"
		[Register ("setAppVersionCode", "(ILandroid/content/Context;)V", "")]
		public static unsafe void SetAppVersionCode (int versionCode, global::Android.Content.Context context)
		{
			const string __id = "setAppVersionCode.(ILandroid/content/Context;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (versionCode);
				__args [1] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Utils']/class[@name='HelperFunctions']/method[@name='setDeepLinkMediaCode' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("setDeepLinkMediaCode", "(Landroid/content/Context;Ljava/lang/String;)V", "")]
		public static unsafe void SetDeepLinkMediaCode (global::Android.Content.Context context, string value)
		{
			const string __id = "setDeepLinkMediaCode.(Landroid/content/Context;Ljava/lang/String;)V";
			IntPtr native_value = JNIEnv.NewString (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (native_value);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Utils']/class[@name='HelperFunctions']/method[@name='setEverId' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("setEverId", "(Landroid/content/Context;Ljava/lang/String;)V", "")]
		public static unsafe void SetEverId (global::Android.Content.Context context, string value)
		{
			const string __id = "setEverId.(Landroid/content/Context;Ljava/lang/String;)V";
			IntPtr native_value = JNIEnv.NewString (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (native_value);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Utils']/class[@name='HelperFunctions']/method[@name='stringFromStream' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
		[Register ("stringFromStream", "(Ljava/io/InputStream;)Ljava/lang/String;", "")]
		public static unsafe string StringFromStream (global::System.IO.Stream inputStream)
		{
			const string __id = "stringFromStream.(Ljava/io/InputStream;)Ljava/lang/String;";
			IntPtr native_inputStream = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (inputStream);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_inputStream);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_inputStream);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Utils']/class[@name='HelperFunctions']/method[@name='testIsValidURL' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("testIsValidURL", "(Ljava/lang/String;)Z", "")]
		public static unsafe bool TestIsValidURL (string url)
		{
			const string __id = "testIsValidURL.(Ljava/lang/String;)Z";
			IntPtr native_url = JNIEnv.NewString (url);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_url);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_url);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Utils']/class[@name='HelperFunctions']/method[@name='updated' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int']]"
		[Register ("updated", "(Landroid/content/Context;I)Z", "")]
		public static unsafe bool Updated (global::Android.Content.Context context, int currentVersion)
		{
			const string __id = "updated.(Landroid/content/Context;I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (currentVersion);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Utils']/class[@name='HelperFunctions']/method[@name='urlDecode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("urlDecode", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string UrlDecode (string @string)
		{
			const string __id = "urlDecode.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native__string = JNIEnv.NewString (@string);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native__string);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native__string);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Utils']/class[@name='HelperFunctions']/method[@name='urlEncode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("urlEncode", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string UrlEncode (string @string)
		{
			const string __id = "urlEncode.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native__string = JNIEnv.NewString (@string);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native__string);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native__string);
			}
		}

	}
}
