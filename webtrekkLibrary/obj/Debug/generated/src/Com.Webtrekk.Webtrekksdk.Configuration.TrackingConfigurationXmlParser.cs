using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Webtrekk.Webtrekksdk.Configuration {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Configuration']/class[@name='TrackingConfigurationXmlParser']"
	[global::Android.Runtime.Register ("com/webtrekk/webtrekksdk/Configuration/TrackingConfigurationXmlParser", DoNotGenerateAcw=true)]
	public partial class TrackingConfigurationXmlParser : global::Java.Lang.Object {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Configuration']/interface[@name='TrackingConfigurationXmlParser.ParameterAction']"
		[Register ("com/webtrekk/webtrekksdk/Configuration/TrackingConfigurationXmlParser$ParameterAction", "", "Com.Webtrekk.Webtrekksdk.Configuration.TrackingConfigurationXmlParser/IParameterActionInvoker")]
		public partial interface IParameterAction : IJavaObject {

		}

		[global::Android.Runtime.Register ("com/webtrekk/webtrekksdk/Configuration/TrackingConfigurationXmlParser$ParameterAction", DoNotGenerateAcw=true)]
		internal class IParameterActionInvoker : global::Java.Lang.Object, IParameterAction {

			internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/webtrekk/webtrekksdk/Configuration/TrackingConfigurationXmlParser$ParameterAction", typeof (IParameterActionInvoker));

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

			public static IParameterAction GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IParameterAction> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.webtrekk.webtrekksdk.Configuration.TrackingConfigurationXmlParser.ParameterAction"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IParameterActionInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

		}


		// Metadata.xml XPath class reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Configuration']/class[@name='TrackingConfigurationXmlParser.ParType']"
		[global::Android.Runtime.Register ("com/webtrekk/webtrekksdk/Configuration/TrackingConfigurationXmlParser$ParType", DoNotGenerateAcw=true)]
		public sealed partial class ParType : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Configuration']/class[@name='TrackingConfigurationXmlParser.ParType']/field[@name='ACTIVITY_SCREEN']"
			[Register ("ACTIVITY_SCREEN")]
			public static global::Com.Webtrekk.Webtrekksdk.Configuration.TrackingConfigurationXmlParser.ParType ActivityScreen {
				get {
					const string __id = "ACTIVITY_SCREEN.Lcom/webtrekk/webtrekksdk/Configuration/TrackingConfigurationXmlParser$ParType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Configuration.TrackingConfigurationXmlParser.ParType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Configuration']/class[@name='TrackingConfigurationXmlParser.ParType']/field[@name='AUTO_TRACKED']"
			[Register ("AUTO_TRACKED")]
			public static global::Com.Webtrekk.Webtrekksdk.Configuration.TrackingConfigurationXmlParser.ParType AutoTracked {
				get {
					const string __id = "AUTO_TRACKED.Lcom/webtrekk/webtrekksdk/Configuration/TrackingConfigurationXmlParser$ParType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Configuration.TrackingConfigurationXmlParser.ParType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Configuration']/class[@name='TrackingConfigurationXmlParser.ParType']/field[@name='AUTO_TRACK_ADDVERISEMENT_OPT_OUT']"
			[Register ("AUTO_TRACK_ADDVERISEMENT_OPT_OUT")]
			public static global::Com.Webtrekk.Webtrekksdk.Configuration.TrackingConfigurationXmlParser.ParType AutoTrackAddverisementOptOut {
				get {
					const string __id = "AUTO_TRACK_ADDVERISEMENT_OPT_OUT.Lcom/webtrekk/webtrekksdk/Configuration/TrackingConfigurationXmlParser$ParType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Configuration.TrackingConfigurationXmlParser.ParType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Configuration']/class[@name='TrackingConfigurationXmlParser.ParType']/field[@name='AUTO_TRACK_ADDVERTISER_ID']"
			[Register ("AUTO_TRACK_ADDVERTISER_ID")]
			public static global::Com.Webtrekk.Webtrekksdk.Configuration.TrackingConfigurationXmlParser.ParType AutoTrackAddvertiserId {
				get {
					const string __id = "AUTO_TRACK_ADDVERTISER_ID.Lcom/webtrekk/webtrekksdk/Configuration/TrackingConfigurationXmlParser$ParType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Configuration.TrackingConfigurationXmlParser.ParType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Configuration']/class[@name='TrackingConfigurationXmlParser.ParType']/field[@name='AUTO_TRACK_ADD_CLEAR_ID']"
			[Register ("AUTO_TRACK_ADD_CLEAR_ID")]
			public static global::Com.Webtrekk.Webtrekksdk.Configuration.TrackingConfigurationXmlParser.ParType AutoTrackAddClearId {
				get {
					const string __id = "AUTO_TRACK_ADD_CLEAR_ID.Lcom/webtrekk/webtrekksdk/Configuration/TrackingConfigurationXmlParser$ParType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Configuration.TrackingConfigurationXmlParser.ParType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Configuration']/class[@name='TrackingConfigurationXmlParser.ParType']/field[@name='AUTO_TRACK_API_LEVEL']"
			[Register ("AUTO_TRACK_API_LEVEL")]
			public static global::Com.Webtrekk.Webtrekksdk.Configuration.TrackingConfigurationXmlParser.ParType AutoTrackApiLevel {
				get {
					const string __id = "AUTO_TRACK_API_LEVEL.Lcom/webtrekk/webtrekksdk/Configuration/TrackingConfigurationXmlParser$ParType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Configuration.TrackingConfigurationXmlParser.ParType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Configuration']/class[@name='TrackingConfigurationXmlParser.ParType']/field[@name='AUTO_TRACK_APP_PLAY_STORE_FAMILY_NAME']"
			[Register ("AUTO_TRACK_APP_PLAY_STORE_FAMILY_NAME")]
			public static global::Com.Webtrekk.Webtrekksdk.Configuration.TrackingConfigurationXmlParser.ParType AutoTrackAppPlayStoreFamilyName {
				get {
					const string __id = "AUTO_TRACK_APP_PLAY_STORE_FAMILY_NAME.Lcom/webtrekk/webtrekksdk/Configuration/TrackingConfigurationXmlParser$ParType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Configuration.TrackingConfigurationXmlParser.ParType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Configuration']/class[@name='TrackingConfigurationXmlParser.ParType']/field[@name='AUTO_TRACK_APP_PLAY_STORE_GIVEN_NAME']"
			[Register ("AUTO_TRACK_APP_PLAY_STORE_GIVEN_NAME")]
			public static global::Com.Webtrekk.Webtrekksdk.Configuration.TrackingConfigurationXmlParser.ParType AutoTrackAppPlayStoreGivenName {
				get {
					const string __id = "AUTO_TRACK_APP_PLAY_STORE_GIVEN_NAME.Lcom/webtrekk/webtrekksdk/Configuration/TrackingConfigurationXmlParser$ParType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Configuration.TrackingConfigurationXmlParser.ParType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Configuration']/class[@name='TrackingConfigurationXmlParser.ParType']/field[@name='AUTO_TRACK_APP_PLAY_STORE_MAIL']"
			[Register ("AUTO_TRACK_APP_PLAY_STORE_MAIL")]
			public static global::Com.Webtrekk.Webtrekksdk.Configuration.TrackingConfigurationXmlParser.ParType AutoTrackAppPlayStoreMail {
				get {
					const string __id = "AUTO_TRACK_APP_PLAY_STORE_MAIL.Lcom/webtrekk/webtrekksdk/Configuration/TrackingConfigurationXmlParser$ParType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Configuration.TrackingConfigurationXmlParser.ParType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Configuration']/class[@name='TrackingConfigurationXmlParser.ParType']/field[@name='AUTO_TRACK_APP_PLAY_STORE_USER_NAME']"
			[Register ("AUTO_TRACK_APP_PLAY_STORE_USER_NAME")]
			public static global::Com.Webtrekk.Webtrekksdk.Configuration.TrackingConfigurationXmlParser.ParType AutoTrackAppPlayStoreUserName {
				get {
					const string __id = "AUTO_TRACK_APP_PLAY_STORE_USER_NAME.Lcom/webtrekk/webtrekksdk/Configuration/TrackingConfigurationXmlParser$ParType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Configuration.TrackingConfigurationXmlParser.ParType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Configuration']/class[@name='TrackingConfigurationXmlParser.ParType']/field[@name='AUTO_TRACK_APP_PRE_INSTALLED']"
			[Register ("AUTO_TRACK_APP_PRE_INSTALLED")]
			public static global::Com.Webtrekk.Webtrekksdk.Configuration.TrackingConfigurationXmlParser.ParType AutoTrackAppPreInstalled {
				get {
					const string __id = "AUTO_TRACK_APP_PRE_INSTALLED.Lcom/webtrekk/webtrekksdk/Configuration/TrackingConfigurationXmlParser$ParType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Configuration.TrackingConfigurationXmlParser.ParType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Configuration']/class[@name='TrackingConfigurationXmlParser.ParType']/field[@name='AUTO_TRACK_APP_VERSION_CODE']"
			[Register ("AUTO_TRACK_APP_VERSION_CODE")]
			public static global::Com.Webtrekk.Webtrekksdk.Configuration.TrackingConfigurationXmlParser.ParType AutoTrackAppVersionCode {
				get {
					const string __id = "AUTO_TRACK_APP_VERSION_CODE.Lcom/webtrekk/webtrekksdk/Configuration/TrackingConfigurationXmlParser$ParType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Configuration.TrackingConfigurationXmlParser.ParType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Configuration']/class[@name='TrackingConfigurationXmlParser.ParType']/field[@name='AUTO_TRACK_APP_VERSION_NAME']"
			[Register ("AUTO_TRACK_APP_VERSION_NAME")]
			public static global::Com.Webtrekk.Webtrekksdk.Configuration.TrackingConfigurationXmlParser.ParType AutoTrackAppVersionName {
				get {
					const string __id = "AUTO_TRACK_APP_VERSION_NAME.Lcom/webtrekk/webtrekksdk/Configuration/TrackingConfigurationXmlParser$ParType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Configuration.TrackingConfigurationXmlParser.ParType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Configuration']/class[@name='TrackingConfigurationXmlParser.ParType']/field[@name='AUTO_TRACK_CONNECTION_TYPE']"
			[Register ("AUTO_TRACK_CONNECTION_TYPE")]
			public static global::Com.Webtrekk.Webtrekksdk.Configuration.TrackingConfigurationXmlParser.ParType AutoTrackConnectionType {
				get {
					const string __id = "AUTO_TRACK_CONNECTION_TYPE.Lcom/webtrekk/webtrekksdk/Configuration/TrackingConfigurationXmlParser$ParType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Configuration.TrackingConfigurationXmlParser.ParType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Configuration']/class[@name='TrackingConfigurationXmlParser.ParType']/field[@name='AUTO_TRACK_REQUEST_URL_STORE_SIZE']"
			[Register ("AUTO_TRACK_REQUEST_URL_STORE_SIZE")]
			public static global::Com.Webtrekk.Webtrekksdk.Configuration.TrackingConfigurationXmlParser.ParType AutoTrackRequestUrlStoreSize {
				get {
					const string __id = "AUTO_TRACK_REQUEST_URL_STORE_SIZE.Lcom/webtrekk/webtrekksdk/Configuration/TrackingConfigurationXmlParser$ParType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Configuration.TrackingConfigurationXmlParser.ParType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Configuration']/class[@name='TrackingConfigurationXmlParser.ParType']/field[@name='AUTO_TRACK_SCREEN_ORIENTATION']"
			[Register ("AUTO_TRACK_SCREEN_ORIENTATION")]
			public static global::Com.Webtrekk.Webtrekksdk.Configuration.TrackingConfigurationXmlParser.ParType AutoTrackScreenOrientation {
				get {
					const string __id = "AUTO_TRACK_SCREEN_ORIENTATION.Lcom/webtrekk/webtrekksdk/Configuration/TrackingConfigurationXmlParser$ParType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Configuration.TrackingConfigurationXmlParser.ParType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Configuration']/class[@name='TrackingConfigurationXmlParser.ParType']/field[@name='AUTO_TRACK_UPDATE']"
			[Register ("AUTO_TRACK_UPDATE")]
			public static global::Com.Webtrekk.Webtrekksdk.Configuration.TrackingConfigurationXmlParser.ParType AutoTrackUpdate {
				get {
					const string __id = "AUTO_TRACK_UPDATE.Lcom/webtrekk/webtrekksdk/Configuration/TrackingConfigurationXmlParser$ParType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Configuration.TrackingConfigurationXmlParser.ParType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Configuration']/class[@name='TrackingConfigurationXmlParser.ParType']/field[@name='CUSTOM_PARAMETER']"
			[Register ("CUSTOM_PARAMETER")]
			public static global::Com.Webtrekk.Webtrekksdk.Configuration.TrackingConfigurationXmlParser.ParType CustomParameter {
				get {
					const string __id = "CUSTOM_PARAMETER.Lcom/webtrekk/webtrekksdk/Configuration/TrackingConfigurationXmlParser$ParType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Configuration.TrackingConfigurationXmlParser.ParType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Configuration']/class[@name='TrackingConfigurationXmlParser.ParType']/field[@name='ENABLE_CAMPAIGN_TRACKING']"
			[Register ("ENABLE_CAMPAIGN_TRACKING")]
			public static global::Com.Webtrekk.Webtrekksdk.Configuration.TrackingConfigurationXmlParser.ParType EnableCampaignTracking {
				get {
					const string __id = "ENABLE_CAMPAIGN_TRACKING.Lcom/webtrekk/webtrekksdk/Configuration/TrackingConfigurationXmlParser$ParType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Configuration.TrackingConfigurationXmlParser.ParType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Configuration']/class[@name='TrackingConfigurationXmlParser.ParType']/field[@name='ENABLE_REMOTE_CONFIGURATION']"
			[Register ("ENABLE_REMOTE_CONFIGURATION")]
			public static global::Com.Webtrekk.Webtrekksdk.Configuration.TrackingConfigurationXmlParser.ParType EnableRemoteConfiguration {
				get {
					const string __id = "ENABLE_REMOTE_CONFIGURATION.Lcom/webtrekk/webtrekksdk/Configuration/TrackingConfigurationXmlParser$ParType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Configuration.TrackingConfigurationXmlParser.ParType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Configuration']/class[@name='TrackingConfigurationXmlParser.ParType']/field[@name='ERROR_LOG_ENABLED']"
			[Register ("ERROR_LOG_ENABLED")]
			public static global::Com.Webtrekk.Webtrekksdk.Configuration.TrackingConfigurationXmlParser.ParType ErrorLogEnabled {
				get {
					const string __id = "ERROR_LOG_ENABLED.Lcom/webtrekk/webtrekksdk/Configuration/TrackingConfigurationXmlParser$ParType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Configuration.TrackingConfigurationXmlParser.ParType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Configuration']/class[@name='TrackingConfigurationXmlParser.ParType']/field[@name='ERROR_LOG_LEVEL']"
			[Register ("ERROR_LOG_LEVEL")]
			public static global::Com.Webtrekk.Webtrekksdk.Configuration.TrackingConfigurationXmlParser.ParType ErrorLogLevel {
				get {
					const string __id = "ERROR_LOG_LEVEL.Lcom/webtrekk/webtrekksdk/Configuration/TrackingConfigurationXmlParser$ParType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Configuration.TrackingConfigurationXmlParser.ParType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Configuration']/class[@name='TrackingConfigurationXmlParser.ParType']/field[@name='GLOBAL_TRACKING_PARAMETER']"
			[Register ("GLOBAL_TRACKING_PARAMETER")]
			public static global::Com.Webtrekk.Webtrekksdk.Configuration.TrackingConfigurationXmlParser.ParType GlobalTrackingParameter {
				get {
					const string __id = "GLOBAL_TRACKING_PARAMETER.Lcom/webtrekk/webtrekksdk/Configuration/TrackingConfigurationXmlParser$ParType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Configuration.TrackingConfigurationXmlParser.ParType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Configuration']/class[@name='TrackingConfigurationXmlParser.ParType']/field[@name='MAX_REQUEST']"
			[Register ("MAX_REQUEST")]
			public static global::Com.Webtrekk.Webtrekksdk.Configuration.TrackingConfigurationXmlParser.ParType MaxRequest {
				get {
					const string __id = "MAX_REQUEST.Lcom/webtrekk/webtrekksdk/Configuration/TrackingConfigurationXmlParser$ParType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Configuration.TrackingConfigurationXmlParser.ParType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Configuration']/class[@name='TrackingConfigurationXmlParser.ParType']/field[@name='RECOMMENDATIONS']"
			[Register ("RECOMMENDATIONS")]
			public static global::Com.Webtrekk.Webtrekksdk.Configuration.TrackingConfigurationXmlParser.ParType Recommendations {
				get {
					const string __id = "RECOMMENDATIONS.Lcom/webtrekk/webtrekksdk/Configuration/TrackingConfigurationXmlParser$ParType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Configuration.TrackingConfigurationXmlParser.ParType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Configuration']/class[@name='TrackingConfigurationXmlParser.ParType']/field[@name='RESEND_ON_START_EVENT_TIME']"
			[Register ("RESEND_ON_START_EVENT_TIME")]
			public static global::Com.Webtrekk.Webtrekksdk.Configuration.TrackingConfigurationXmlParser.ParType ResendOnStartEventTime {
				get {
					const string __id = "RESEND_ON_START_EVENT_TIME.Lcom/webtrekk/webtrekksdk/Configuration/TrackingConfigurationXmlParser$ParType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Configuration.TrackingConfigurationXmlParser.ParType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Configuration']/class[@name='TrackingConfigurationXmlParser.ParType']/field[@name='SAMPLING']"
			[Register ("SAMPLING")]
			public static global::Com.Webtrekk.Webtrekksdk.Configuration.TrackingConfigurationXmlParser.ParType Sampling {
				get {
					const string __id = "SAMPLING.Lcom/webtrekk/webtrekksdk/Configuration/TrackingConfigurationXmlParser$ParType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Configuration.TrackingConfigurationXmlParser.ParType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Configuration']/class[@name='TrackingConfigurationXmlParser.ParType']/field[@name='SEND_DELAY']"
			[Register ("SEND_DELAY")]
			public static global::Com.Webtrekk.Webtrekksdk.Configuration.TrackingConfigurationXmlParser.ParType SendDelay {
				get {
					const string __id = "SEND_DELAY.Lcom/webtrekk/webtrekksdk/Configuration/TrackingConfigurationXmlParser$ParType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Configuration.TrackingConfigurationXmlParser.ParType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Configuration']/class[@name='TrackingConfigurationXmlParser.ParType']/field[@name='TRACKING_CONFIGURATION_URL']"
			[Register ("TRACKING_CONFIGURATION_URL")]
			public static global::Com.Webtrekk.Webtrekksdk.Configuration.TrackingConfigurationXmlParser.ParType TrackingConfigurationUrl {
				get {
					const string __id = "TRACKING_CONFIGURATION_URL.Lcom/webtrekk/webtrekksdk/Configuration/TrackingConfigurationXmlParser$ParType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Configuration.TrackingConfigurationXmlParser.ParType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Configuration']/class[@name='TrackingConfigurationXmlParser.ParType']/field[@name='TRACK_DOMAIN']"
			[Register ("TRACK_DOMAIN")]
			public static global::Com.Webtrekk.Webtrekksdk.Configuration.TrackingConfigurationXmlParser.ParType TrackDomain {
				get {
					const string __id = "TRACK_DOMAIN.Lcom/webtrekk/webtrekksdk/Configuration/TrackingConfigurationXmlParser$ParType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Configuration.TrackingConfigurationXmlParser.ParType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Configuration']/class[@name='TrackingConfigurationXmlParser.ParType']/field[@name='TRACK_ID']"
			[Register ("TRACK_ID")]
			public static global::Com.Webtrekk.Webtrekksdk.Configuration.TrackingConfigurationXmlParser.ParType TrackId {
				get {
					const string __id = "TRACK_ID.Lcom/webtrekk/webtrekksdk/Configuration/TrackingConfigurationXmlParser$ParType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Configuration.TrackingConfigurationXmlParser.ParType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Configuration']/class[@name='TrackingConfigurationXmlParser.ParType']/field[@name='VERSION']"
			[Register ("VERSION")]
			public static global::Com.Webtrekk.Webtrekksdk.Configuration.TrackingConfigurationXmlParser.ParType Version {
				get {
					const string __id = "VERSION.Lcom/webtrekk/webtrekksdk/Configuration/TrackingConfigurationXmlParser$ParType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Configuration.TrackingConfigurationXmlParser.ParType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/webtrekk/webtrekksdk/Configuration/TrackingConfigurationXmlParser$ParType", typeof (ParType));
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

			internal ParType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Configuration']/class[@name='TrackingConfigurationXmlParser.ParType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Configuration']/class[@name='TrackingConfigurationXmlParser.ParType']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/webtrekk/webtrekksdk/Configuration/TrackingConfigurationXmlParser$ParType;", "")]
			public static unsafe global::Com.Webtrekk.Webtrekksdk.Configuration.TrackingConfigurationXmlParser.ParType[] Values ()
			{
				const string __id = "values.()[Lcom/webtrekk/webtrekksdk/Configuration/TrackingConfigurationXmlParser$ParType;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Com.Webtrekk.Webtrekksdk.Configuration.TrackingConfigurationXmlParser.ParType[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Webtrekk.Webtrekksdk.Configuration.TrackingConfigurationXmlParser.ParType));
				} finally {
				}
			}

		}

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/webtrekk/webtrekksdk/Configuration/TrackingConfigurationXmlParser", typeof (TrackingConfigurationXmlParser));
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

		protected TrackingConfigurationXmlParser (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Configuration']/class[@name='TrackingConfigurationXmlParser']/constructor[@name='TrackingConfigurationXmlParser' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe TrackingConfigurationXmlParser ()
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

		static Delegate cb_parse_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetParse_Ljava_lang_String_Handler ()
		{
			if (cb_parse_Ljava_lang_String_ == null)
				cb_parse_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Parse_Ljava_lang_String_);
			return cb_parse_Ljava_lang_String_;
		}

		static IntPtr n_Parse_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native__in)
		{
			global::Com.Webtrekk.Webtrekksdk.Configuration.TrackingConfigurationXmlParser __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Configuration.TrackingConfigurationXmlParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @in = JNIEnv.GetString (native__in, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Parse (@in));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Configuration']/class[@name='TrackingConfigurationXmlParser']/method[@name='parse' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("parse", "(Ljava/lang/String;)Lcom/webtrekk/webtrekksdk/Configuration/TrackingConfiguration;", "GetParse_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Webtrekk.Webtrekksdk.Configuration.TrackingConfiguration Parse (string @in)
		{
			const string __id = "parse.(Ljava/lang/String;)Lcom/webtrekk/webtrekksdk/Configuration/TrackingConfiguration;";
			IntPtr native__in = JNIEnv.NewString (@in);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native__in);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Configuration.TrackingConfiguration> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native__in);
			}
		}

	}
}
