using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Webtrekk.Webtrekksdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='TrackingParameter']"
	[global::Android.Runtime.Register ("com/webtrekk/webtrekksdk/TrackingParameter", DoNotGenerateAcw=true)]
	public partial class TrackingParameter : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='TrackingParameter']/field[@name='PRODUCT_LIST_SEPARATOR']"
		[Register ("PRODUCT_LIST_SEPARATOR")]
		public const string ProductListSeparator = (string) ";";
		// Metadata.xml XPath class reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='TrackingParameter.Parameter']"
		[global::Android.Runtime.Register ("com/webtrekk/webtrekksdk/TrackingParameter$Parameter", DoNotGenerateAcw=true)]
		public sealed partial class Parameter : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='TrackingParameter.Parameter']/field[@name='ACTION']"
			[Register ("ACTION")]
			public static global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter Action {
				get {
					const string __id = "ACTION.Lcom/webtrekk/webtrekksdk/TrackingParameter$Parameter;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='TrackingParameter.Parameter']/field[@name='ACTION_NAME']"
			[Register ("ACTION_NAME")]
			public static global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter ActionName {
				get {
					const string __id = "ACTION_NAME.Lcom/webtrekk/webtrekksdk/TrackingParameter$Parameter;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='TrackingParameter.Parameter']/field[@name='ACTIVITY_NAME']"
			[Register ("ACTIVITY_NAME")]
			public static global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter ActivityName {
				get {
					const string __id = "ACTIVITY_NAME.Lcom/webtrekk/webtrekksdk/TrackingParameter$Parameter;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='TrackingParameter.Parameter']/field[@name='AD']"
			[Register ("AD")]
			public static global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter Ad {
				get {
					const string __id = "AD.Lcom/webtrekk/webtrekksdk/TrackingParameter$Parameter;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='TrackingParameter.Parameter']/field[@name='ADVERTISEMENT']"
			[Register ("ADVERTISEMENT")]
			public static global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter Advertisement {
				get {
					const string __id = "ADVERTISEMENT.Lcom/webtrekk/webtrekksdk/TrackingParameter$Parameter;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='TrackingParameter.Parameter']/field[@name='ADVERTISEMENT_ACTION']"
			[Register ("ADVERTISEMENT_ACTION")]
			public static global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter AdvertisementAction {
				get {
					const string __id = "ADVERTISEMENT_ACTION.Lcom/webtrekk/webtrekksdk/TrackingParameter$Parameter;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='TrackingParameter.Parameter']/field[@name='ADVERTISER_ID']"
			[Register ("ADVERTISER_ID")]
			public static global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter AdvertiserId {
				get {
					const string __id = "ADVERTISER_ID.Lcom/webtrekk/webtrekksdk/TrackingParameter$Parameter;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='TrackingParameter.Parameter']/field[@name='APP_FIRST_START']"
			[Register ("APP_FIRST_START")]
			public static global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter AppFirstStart {
				get {
					const string __id = "APP_FIRST_START.Lcom/webtrekk/webtrekksdk/TrackingParameter$Parameter;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='TrackingParameter.Parameter']/field[@name='BIRTHDAY']"
			[Register ("BIRTHDAY")]
			public static global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter Birthday {
				get {
					const string __id = "BIRTHDAY.Lcom/webtrekk/webtrekksdk/TrackingParameter$Parameter;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='TrackingParameter.Parameter']/field[@name='CDB_ADDRESS_MD5']"
			[Register ("CDB_ADDRESS_MD5")]
			public static global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter CdbAddressMd5 {
				get {
					const string __id = "CDB_ADDRESS_MD5.Lcom/webtrekk/webtrekksdk/TrackingParameter$Parameter;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='TrackingParameter.Parameter']/field[@name='CDB_ADDRESS_SHA']"
			[Register ("CDB_ADDRESS_SHA")]
			public static global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter CdbAddressSha {
				get {
					const string __id = "CDB_ADDRESS_SHA.Lcom/webtrekk/webtrekksdk/TrackingParameter$Parameter;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='TrackingParameter.Parameter']/field[@name='CDB_ANDROID_ID']"
			[Register ("CDB_ANDROID_ID")]
			public static global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter CdbAndroidId {
				get {
					const string __id = "CDB_ANDROID_ID.Lcom/webtrekk/webtrekksdk/TrackingParameter$Parameter;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='TrackingParameter.Parameter']/field[@name='CDB_EMAIL_MD5']"
			[Register ("CDB_EMAIL_MD5")]
			public static global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter CdbEmailMd5 {
				get {
					const string __id = "CDB_EMAIL_MD5.Lcom/webtrekk/webtrekksdk/TrackingParameter$Parameter;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='TrackingParameter.Parameter']/field[@name='CDB_EMAIL_SHA']"
			[Register ("CDB_EMAIL_SHA")]
			public static global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter CdbEmailSha {
				get {
					const string __id = "CDB_EMAIL_SHA.Lcom/webtrekk/webtrekksdk/TrackingParameter$Parameter;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='TrackingParameter.Parameter']/field[@name='CDB_FACEBOOK_ID']"
			[Register ("CDB_FACEBOOK_ID")]
			public static global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter CdbFacebookId {
				get {
					const string __id = "CDB_FACEBOOK_ID.Lcom/webtrekk/webtrekksdk/TrackingParameter$Parameter;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='TrackingParameter.Parameter']/field[@name='CDB_GOOGLE_PLUS_ID']"
			[Register ("CDB_GOOGLE_PLUS_ID")]
			public static global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter CdbGooglePlusId {
				get {
					const string __id = "CDB_GOOGLE_PLUS_ID.Lcom/webtrekk/webtrekksdk/TrackingParameter$Parameter;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='TrackingParameter.Parameter']/field[@name='CDB_IOS_ADD_ID']"
			[Register ("CDB_IOS_ADD_ID")]
			public static global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter CdbIosAddId {
				get {
					const string __id = "CDB_IOS_ADD_ID.Lcom/webtrekk/webtrekksdk/TrackingParameter$Parameter;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='TrackingParameter.Parameter']/field[@name='CDB_LINKEDIN_ID']"
			[Register ("CDB_LINKEDIN_ID")]
			public static global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter CdbLinkedinId {
				get {
					const string __id = "CDB_LINKEDIN_ID.Lcom/webtrekk/webtrekksdk/TrackingParameter$Parameter;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='TrackingParameter.Parameter']/field[@name='CDB_PHONE_MD5']"
			[Register ("CDB_PHONE_MD5")]
			public static global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter CdbPhoneMd5 {
				get {
					const string __id = "CDB_PHONE_MD5.Lcom/webtrekk/webtrekksdk/TrackingParameter$Parameter;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='TrackingParameter.Parameter']/field[@name='CDB_PHONE_SHA']"
			[Register ("CDB_PHONE_SHA")]
			public static global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter CdbPhoneSha {
				get {
					const string __id = "CDB_PHONE_SHA.Lcom/webtrekk/webtrekksdk/TrackingParameter$Parameter;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='TrackingParameter.Parameter']/field[@name='CDB_TWITTER_ID']"
			[Register ("CDB_TWITTER_ID")]
			public static global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter CdbTwitterId {
				get {
					const string __id = "CDB_TWITTER_ID.Lcom/webtrekk/webtrekksdk/TrackingParameter$Parameter;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='TrackingParameter.Parameter']/field[@name='CDB_WIN_AD_ID']"
			[Register ("CDB_WIN_AD_ID")]
			public static global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter CdbWinAdId {
				get {
					const string __id = "CDB_WIN_AD_ID.Lcom/webtrekk/webtrekksdk/TrackingParameter$Parameter;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='TrackingParameter.Parameter']/field[@name='CITY']"
			[Register ("CITY")]
			public static global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter City {
				get {
					const string __id = "CITY.Lcom/webtrekk/webtrekksdk/TrackingParameter$Parameter;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='TrackingParameter.Parameter']/field[@name='COUNTRY']"
			[Register ("COUNTRY")]
			public static global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter Country {
				get {
					const string __id = "COUNTRY.Lcom/webtrekk/webtrekksdk/TrackingParameter$Parameter;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='TrackingParameter.Parameter']/field[@name='CURRENCY']"
			[Register ("CURRENCY")]
			public static global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter Currency {
				get {
					const string __id = "CURRENCY.Lcom/webtrekk/webtrekksdk/TrackingParameter$Parameter;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='TrackingParameter.Parameter']/field[@name='CURRENT_TIME']"
			[Register ("CURRENT_TIME")]
			public static global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter CurrentTime {
				get {
					const string __id = "CURRENT_TIME.Lcom/webtrekk/webtrekksdk/TrackingParameter$Parameter;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='TrackingParameter.Parameter']/field[@name='CUSTOMER_ID']"
			[Register ("CUSTOMER_ID")]
			public static global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter CustomerId {
				get {
					const string __id = "CUSTOMER_ID.Lcom/webtrekk/webtrekksdk/TrackingParameter$Parameter;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='TrackingParameter.Parameter']/field[@name='CUSTOM_USER_PAR']"
			[Register ("CUSTOM_USER_PAR")]
			public static global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter CustomUserPar {
				get {
					const string __id = "CUSTOM_USER_PAR.Lcom/webtrekk/webtrekksdk/TrackingParameter$Parameter;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='TrackingParameter.Parameter']/field[@name='DEFAULT_PARAMETERS']"
			[Register ("DEFAULT_PARAMETERS")]
			public static global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter DefaultParameters {
				get {
					const string __id = "DEFAULT_PARAMETERS.Lcom/webtrekk/webtrekksdk/TrackingParameter$Parameter;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='TrackingParameter.Parameter']/field[@name='DEV_LANG']"
			[Register ("DEV_LANG")]
			public static global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter DevLang {
				get {
					const string __id = "DEV_LANG.Lcom/webtrekk/webtrekksdk/TrackingParameter$Parameter;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='TrackingParameter.Parameter']/field[@name='ECOM']"
			[Register ("ECOM")]
			public static global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter Ecom {
				get {
					const string __id = "ECOM.Lcom/webtrekk/webtrekksdk/TrackingParameter$Parameter;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='TrackingParameter.Parameter']/field[@name='EMAIL']"
			[Register ("EMAIL")]
			public static global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter Email {
				get {
					const string __id = "EMAIL.Lcom/webtrekk/webtrekksdk/TrackingParameter$Parameter;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='TrackingParameter.Parameter']/field[@name='EMAIL_RID']"
			[Register ("EMAIL_RID")]
			public static global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter EmailRid {
				get {
					const string __id = "EMAIL_RID.Lcom/webtrekk/webtrekksdk/TrackingParameter$Parameter;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='TrackingParameter.Parameter']/field[@name='EVERID']"
			[Register ("EVERID")]
			public static global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter Everid {
				get {
					const string __id = "EVERID.Lcom/webtrekk/webtrekksdk/TrackingParameter$Parameter;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='TrackingParameter.Parameter']/field[@name='FORCE_NEW_SESSION']"
			[Register ("FORCE_NEW_SESSION")]
			public static global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter ForceNewSession {
				get {
					const string __id = "FORCE_NEW_SESSION.Lcom/webtrekk/webtrekksdk/TrackingParameter$Parameter;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='TrackingParameter.Parameter']/field[@name='GENDER']"
			[Register ("GENDER")]
			public static global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter Gender {
				get {
					const string __id = "GENDER.Lcom/webtrekk/webtrekksdk/TrackingParameter$Parameter;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='TrackingParameter.Parameter']/field[@name='GNAME']"
			[Register ("GNAME")]
			public static global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter Gname {
				get {
					const string __id = "GNAME.Lcom/webtrekk/webtrekksdk/TrackingParameter$Parameter;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='TrackingParameter.Parameter']/field[@name='INSTALL_REFERRER_KEYWORD']"
			[Register ("INSTALL_REFERRER_KEYWORD")]
			public static global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter InstallReferrerKeyword {
				get {
					const string __id = "INSTALL_REFERRER_KEYWORD.Lcom/webtrekk/webtrekksdk/TrackingParameter$Parameter;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='TrackingParameter.Parameter']/field[@name='INSTALL_REFERRER_PARAMS_MC']"
			[Register ("INSTALL_REFERRER_PARAMS_MC")]
			public static global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter InstallReferrerParamsMc {
				get {
					const string __id = "INSTALL_REFERRER_PARAMS_MC.Lcom/webtrekk/webtrekksdk/TrackingParameter$Parameter;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='TrackingParameter.Parameter']/field[@name='INST_AD_ID']"
			[Register ("INST_AD_ID")]
			public static global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter InstAdId {
				get {
					const string __id = "INST_AD_ID.Lcom/webtrekk/webtrekksdk/TrackingParameter$Parameter;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='TrackingParameter.Parameter']/field[@name='INST_CLICK_ID']"
			[Register ("INST_CLICK_ID")]
			public static global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter InstClickId {
				get {
					const string __id = "INST_CLICK_ID.Lcom/webtrekk/webtrekksdk/TrackingParameter$Parameter;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='TrackingParameter.Parameter']/field[@name='INST_TRACK_ID']"
			[Register ("INST_TRACK_ID")]
			public static global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter InstTrackId {
				get {
					const string __id = "INST_TRACK_ID.Lcom/webtrekk/webtrekksdk/TrackingParameter$Parameter;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='TrackingParameter.Parameter']/field[@name='INTERN_SEARCH']"
			[Register ("INTERN_SEARCH")]
			public static global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter InternSearch {
				get {
					const string __id = "INTERN_SEARCH.Lcom/webtrekk/webtrekksdk/TrackingParameter$Parameter;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='TrackingParameter.Parameter']/field[@name='IP_ADDRESS']"
			[Register ("IP_ADDRESS")]
			public static global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter IpAddress {
				get {
					const string __id = "IP_ADDRESS.Lcom/webtrekk/webtrekksdk/TrackingParameter$Parameter;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='TrackingParameter.Parameter']/field[@name='MEDIA_ACTION']"
			[Register ("MEDIA_ACTION")]
			public static global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter MediaAction {
				get {
					const string __id = "MEDIA_ACTION.Lcom/webtrekk/webtrekksdk/TrackingParameter$Parameter;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='TrackingParameter.Parameter']/field[@name='MEDIA_BANDWITH']"
			[Register ("MEDIA_BANDWITH")]
			public static global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter MediaBandwith {
				get {
					const string __id = "MEDIA_BANDWITH.Lcom/webtrekk/webtrekksdk/TrackingParameter$Parameter;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='TrackingParameter.Parameter']/field[@name='MEDIA_CAT']"
			[Register ("MEDIA_CAT")]
			public static global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter MediaCat {
				get {
					const string __id = "MEDIA_CAT.Lcom/webtrekk/webtrekksdk/TrackingParameter$Parameter;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='TrackingParameter.Parameter']/field[@name='MEDIA_FILE']"
			[Register ("MEDIA_FILE")]
			public static global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter MediaFile {
				get {
					const string __id = "MEDIA_FILE.Lcom/webtrekk/webtrekksdk/TrackingParameter$Parameter;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='TrackingParameter.Parameter']/field[@name='MEDIA_LENGTH']"
			[Register ("MEDIA_LENGTH")]
			public static global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter MediaLength {
				get {
					const string __id = "MEDIA_LENGTH.Lcom/webtrekk/webtrekksdk/TrackingParameter$Parameter;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='TrackingParameter.Parameter']/field[@name='MEDIA_MUTED']"
			[Register ("MEDIA_MUTED")]
			public static global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter MediaMuted {
				get {
					const string __id = "MEDIA_MUTED.Lcom/webtrekk/webtrekksdk/TrackingParameter$Parameter;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='TrackingParameter.Parameter']/field[@name='MEDIA_POS']"
			[Register ("MEDIA_POS")]
			public static global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter MediaPos {
				get {
					const string __id = "MEDIA_POS.Lcom/webtrekk/webtrekksdk/TrackingParameter$Parameter;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='TrackingParameter.Parameter']/field[@name='MEDIA_TIMESTAMP']"
			[Register ("MEDIA_TIMESTAMP")]
			public static global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter MediaTimestamp {
				get {
					const string __id = "MEDIA_TIMESTAMP.Lcom/webtrekk/webtrekksdk/TrackingParameter$Parameter;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='TrackingParameter.Parameter']/field[@name='MEDIA_VOLUME']"
			[Register ("MEDIA_VOLUME")]
			public static global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter MediaVolume {
				get {
					const string __id = "MEDIA_VOLUME.Lcom/webtrekk/webtrekksdk/TrackingParameter$Parameter;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='TrackingParameter.Parameter']/field[@name='NEWSLETTER']"
			[Register ("NEWSLETTER")]
			public static global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter Newsletter {
				get {
					const string __id = "NEWSLETTER.Lcom/webtrekk/webtrekksdk/TrackingParameter$Parameter;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='TrackingParameter.Parameter']/field[@name='ORDER_NUMBER']"
			[Register ("ORDER_NUMBER")]
			public static global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter OrderNumber {
				get {
					const string __id = "ORDER_NUMBER.Lcom/webtrekk/webtrekksdk/TrackingParameter$Parameter;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='TrackingParameter.Parameter']/field[@name='ORDER_TOTAL']"
			[Register ("ORDER_TOTAL")]
			public static global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter OrderTotal {
				get {
					const string __id = "ORDER_TOTAL.Lcom/webtrekk/webtrekksdk/TrackingParameter$Parameter;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='TrackingParameter.Parameter']/field[@name='PAGE']"
			[Register ("PAGE")]
			public static global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter Page {
				get {
					const string __id = "PAGE.Lcom/webtrekk/webtrekksdk/TrackingParameter$Parameter;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='TrackingParameter.Parameter']/field[@name='PAGE_CAT']"
			[Register ("PAGE_CAT")]
			public static global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter PageCat {
				get {
					const string __id = "PAGE_CAT.Lcom/webtrekk/webtrekksdk/TrackingParameter$Parameter;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='TrackingParameter.Parameter']/field[@name='PAGE_URL']"
			[Register ("PAGE_URL")]
			public static global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter PageUrl {
				get {
					const string __id = "PAGE_URL.Lcom/webtrekk/webtrekksdk/TrackingParameter$Parameter;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='TrackingParameter.Parameter']/field[@name='PHONE']"
			[Register ("PHONE")]
			public static global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter Phone {
				get {
					const string __id = "PHONE.Lcom/webtrekk/webtrekksdk/TrackingParameter$Parameter;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='TrackingParameter.Parameter']/field[@name='PRODUCT']"
			[Register ("PRODUCT")]
			public static global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter Product {
				get {
					const string __id = "PRODUCT.Lcom/webtrekk/webtrekksdk/TrackingParameter$Parameter;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='TrackingParameter.Parameter']/field[@name='PRODUCT_CAT']"
			[Register ("PRODUCT_CAT")]
			public static global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter ProductCat {
				get {
					const string __id = "PRODUCT_CAT.Lcom/webtrekk/webtrekksdk/TrackingParameter$Parameter;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='TrackingParameter.Parameter']/field[@name='PRODUCT_COST']"
			[Register ("PRODUCT_COST")]
			public static global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter ProductCost {
				get {
					const string __id = "PRODUCT_COST.Lcom/webtrekk/webtrekksdk/TrackingParameter$Parameter;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='TrackingParameter.Parameter']/field[@name='PRODUCT_COUNT']"
			[Register ("PRODUCT_COUNT")]
			public static global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter ProductCount {
				get {
					const string __id = "PRODUCT_COUNT.Lcom/webtrekk/webtrekksdk/TrackingParameter$Parameter;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='TrackingParameter.Parameter']/field[@name='PRODUCT_COUPON']"
			[Register ("PRODUCT_COUPON")]
			public static global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter ProductCoupon {
				get {
					const string __id = "PRODUCT_COUPON.Lcom/webtrekk/webtrekksdk/TrackingParameter$Parameter;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='TrackingParameter.Parameter']/field[@name='PRODUCT_GROSS_MARGIN']"
			[Register ("PRODUCT_GROSS_MARGIN")]
			public static global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter ProductGrossMargin {
				get {
					const string __id = "PRODUCT_GROSS_MARGIN.Lcom/webtrekk/webtrekksdk/TrackingParameter$Parameter;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='TrackingParameter.Parameter']/field[@name='PRODUCT_ORDER_STATUS']"
			[Register ("PRODUCT_ORDER_STATUS")]
			public static global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter ProductOrderStatus {
				get {
					const string __id = "PRODUCT_ORDER_STATUS.Lcom/webtrekk/webtrekksdk/TrackingParameter$Parameter;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='TrackingParameter.Parameter']/field[@name='PRODUCT_PAYMENT_METHOD']"
			[Register ("PRODUCT_PAYMENT_METHOD")]
			public static global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter ProductPaymentMethod {
				get {
					const string __id = "PRODUCT_PAYMENT_METHOD.Lcom/webtrekk/webtrekksdk/TrackingParameter$Parameter;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='TrackingParameter.Parameter']/field[@name='PRODUCT_POSITION']"
			[Register ("PRODUCT_POSITION")]
			public static global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter ProductPosition {
				get {
					const string __id = "PRODUCT_POSITION.Lcom/webtrekk/webtrekksdk/TrackingParameter$Parameter;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='TrackingParameter.Parameter']/field[@name='PRODUCT_SHIPPING_COST']"
			[Register ("PRODUCT_SHIPPING_COST")]
			public static global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter ProductShippingCost {
				get {
					const string __id = "PRODUCT_SHIPPING_COST.Lcom/webtrekk/webtrekksdk/TrackingParameter$Parameter;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='TrackingParameter.Parameter']/field[@name='PRODUCT_SHIPPING_SERVICE']"
			[Register ("PRODUCT_SHIPPING_SERVICE")]
			public static global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter ProductShippingService {
				get {
					const string __id = "PRODUCT_SHIPPING_SERVICE.Lcom/webtrekk/webtrekksdk/TrackingParameter$Parameter;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='TrackingParameter.Parameter']/field[@name='PRODUCT_SHIPPING_SPEED']"
			[Register ("PRODUCT_SHIPPING_SPEED")]
			public static global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter ProductShippingSpeed {
				get {
					const string __id = "PRODUCT_SHIPPING_SPEED.Lcom/webtrekk/webtrekksdk/TrackingParameter$Parameter;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='TrackingParameter.Parameter']/field[@name='PRODUCT_SOLD_OUT']"
			[Register ("PRODUCT_SOLD_OUT")]
			public static global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter ProductSoldOut {
				get {
					const string __id = "PRODUCT_SOLD_OUT.Lcom/webtrekk/webtrekksdk/TrackingParameter$Parameter;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='TrackingParameter.Parameter']/field[@name='PRODUCT_STATUS']"
			[Register ("PRODUCT_STATUS")]
			public static global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter ProductStatus {
				get {
					const string __id = "PRODUCT_STATUS.Lcom/webtrekk/webtrekksdk/TrackingParameter$Parameter;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='TrackingParameter.Parameter']/field[@name='PRODUCT_VARIANT']"
			[Register ("PRODUCT_VARIANT")]
			public static global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter ProductVariant {
				get {
					const string __id = "PRODUCT_VARIANT.Lcom/webtrekk/webtrekksdk/TrackingParameter$Parameter;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='TrackingParameter.Parameter']/field[@name='SAMPLING']"
			[Register ("SAMPLING")]
			public static global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter Sampling {
				get {
					const string __id = "SAMPLING.Lcom/webtrekk/webtrekksdk/TrackingParameter$Parameter;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='TrackingParameter.Parameter']/field[@name='SCREEN_DEPTH']"
			[Register ("SCREEN_DEPTH")]
			public static global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter ScreenDepth {
				get {
					const string __id = "SCREEN_DEPTH.Lcom/webtrekk/webtrekksdk/TrackingParameter$Parameter;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='TrackingParameter.Parameter']/field[@name='SCREEN_RESOLUTION']"
			[Register ("SCREEN_RESOLUTION")]
			public static global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter ScreenResolution {
				get {
					const string __id = "SCREEN_RESOLUTION.Lcom/webtrekk/webtrekksdk/TrackingParameter$Parameter;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='TrackingParameter.Parameter']/field[@name='SESSION']"
			[Register ("SESSION")]
			public static global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter Session {
				get {
					const string __id = "SESSION.Lcom/webtrekk/webtrekksdk/TrackingParameter$Parameter;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='TrackingParameter.Parameter']/field[@name='SNAME']"
			[Register ("SNAME")]
			public static global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter Sname {
				get {
					const string __id = "SNAME.Lcom/webtrekk/webtrekksdk/TrackingParameter$Parameter;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='TrackingParameter.Parameter']/field[@name='STREET']"
			[Register ("STREET")]
			public static global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter Street {
				get {
					const string __id = "STREET.Lcom/webtrekk/webtrekksdk/TrackingParameter$Parameter;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='TrackingParameter.Parameter']/field[@name='STREETNUMBER']"
			[Register ("STREETNUMBER")]
			public static global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter Streetnumber {
				get {
					const string __id = "STREETNUMBER.Lcom/webtrekk/webtrekksdk/TrackingParameter$Parameter;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='TrackingParameter.Parameter']/field[@name='TIMESTAMP']"
			[Register ("TIMESTAMP")]
			public static global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter Timestamp {
				get {
					const string __id = "TIMESTAMP.Lcom/webtrekk/webtrekksdk/TrackingParameter$Parameter;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='TrackingParameter.Parameter']/field[@name='TIMEZONE']"
			[Register ("TIMEZONE")]
			public static global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter Timezone {
				get {
					const string __id = "TIMEZONE.Lcom/webtrekk/webtrekksdk/TrackingParameter$Parameter;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='TrackingParameter.Parameter']/field[@name='USERAGENT']"
			[Register ("USERAGENT")]
			public static global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter Useragent {
				get {
					const string __id = "USERAGENT.Lcom/webtrekk/webtrekksdk/TrackingParameter$Parameter;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='TrackingParameter.Parameter']/field[@name='USER_CAT']"
			[Register ("USER_CAT")]
			public static global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter UserCat {
				get {
					const string __id = "USER_CAT.Lcom/webtrekk/webtrekksdk/TrackingParameter$Parameter;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='TrackingParameter.Parameter']/field[@name='VOUCHER_VALUE']"
			[Register ("VOUCHER_VALUE")]
			public static global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter VoucherValue {
				get {
					const string __id = "VOUCHER_VALUE.Lcom/webtrekk/webtrekksdk/TrackingParameter$Parameter;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='TrackingParameter.Parameter']/field[@name='ZIP']"
			[Register ("ZIP")]
			public static global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter Zip {
				get {
					const string __id = "ZIP.Lcom/webtrekk/webtrekksdk/TrackingParameter$Parameter;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/webtrekk/webtrekksdk/TrackingParameter$Parameter", typeof (Parameter));
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

			internal Parameter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='TrackingParameter.Parameter']/method[@name='getParameterByName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("getParameterByName", "(Ljava/lang/String;)Lcom/webtrekk/webtrekksdk/TrackingParameter$Parameter;", "")]
			public static unsafe global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter GetParameterByName (string name)
			{
				const string __id = "getParameterByName.(Ljava/lang/String;)Lcom/webtrekk/webtrekksdk/TrackingParameter$Parameter;";
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='TrackingParameter.Parameter']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/webtrekk/webtrekksdk/TrackingParameter$Parameter;", "")]
			public static unsafe global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/webtrekk/webtrekksdk/TrackingParameter$Parameter;";
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='TrackingParameter.Parameter']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/webtrekk/webtrekksdk/TrackingParameter$Parameter;", "")]
			public static unsafe global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter[] Values ()
			{
				const string __id = "values.()[Lcom/webtrekk/webtrekksdk/TrackingParameter$Parameter;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter));
				} finally {
				}
			}

		}

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/webtrekk/webtrekksdk/TrackingParameter", typeof (TrackingParameter));
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

		protected TrackingParameter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='TrackingParameter']/constructor[@name='TrackingParameter' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe TrackingParameter ()
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

		static Delegate cb_getActionParameter;
#pragma warning disable 0169
		static Delegate GetGetActionParameterHandler ()
		{
			if (cb_getActionParameter == null)
				cb_getActionParameter = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetActionParameter);
			return cb_getActionParameter;
		}

		static IntPtr n_GetActionParameter (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Webtrekk.Webtrekksdk.TrackingParameter __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.TrackingParameter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (__this.ActionParameter);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IDictionary<string, string> ActionParameter {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='TrackingParameter']/method[@name='getActionParameter' and count(parameter)=0]"
			[Register ("getActionParameter", "()Ljava/util/SortedMap;", "GetGetActionParameterHandler")]
			get {
				const string __id = "getActionParameter.()Ljava/util/SortedMap;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getAdParameter;
#pragma warning disable 0169
		static Delegate GetGetAdParameterHandler ()
		{
			if (cb_getAdParameter == null)
				cb_getAdParameter = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAdParameter);
			return cb_getAdParameter;
		}

		static IntPtr n_GetAdParameter (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Webtrekk.Webtrekksdk.TrackingParameter __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.TrackingParameter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (__this.AdParameter);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IDictionary<string, string> AdParameter {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='TrackingParameter']/method[@name='getAdParameter' and count(parameter)=0]"
			[Register ("getAdParameter", "()Ljava/util/SortedMap;", "GetGetAdParameterHandler")]
			get {
				const string __id = "getAdParameter.()Ljava/util/SortedMap;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getCustomUserParameters;
#pragma warning disable 0169
		static Delegate GetGetCustomUserParametersHandler ()
		{
			if (cb_getCustomUserParameters == null)
				cb_getCustomUserParameters = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCustomUserParameters);
			return cb_getCustomUserParameters;
		}

		static IntPtr n_GetCustomUserParameters (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Webtrekk.Webtrekksdk.TrackingParameter __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.TrackingParameter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (__this.CustomUserParameters);
		}
#pragma warning restore 0169

		static Delegate cb_setCustomUserParameters_Ljava_util_SortedMap_;
#pragma warning disable 0169
		static Delegate GetSetCustomUserParameters_Ljava_util_SortedMap_Handler ()
		{
			if (cb_setCustomUserParameters_Ljava_util_SortedMap_ == null)
				cb_setCustomUserParameters_Ljava_util_SortedMap_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCustomUserParameters_Ljava_util_SortedMap_);
			return cb_setCustomUserParameters_Ljava_util_SortedMap_;
		}

		static void n_SetCustomUserParameters_Ljava_util_SortedMap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_customUserParameters)
		{
			global::Com.Webtrekk.Webtrekksdk.TrackingParameter __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.TrackingParameter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var customUserParameters = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_customUserParameters, JniHandleOwnership.DoNotTransfer);
			__this.CustomUserParameters = customUserParameters;
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IDictionary<string, string> CustomUserParameters {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='TrackingParameter']/method[@name='getCustomUserParameters' and count(parameter)=0]"
			[Register ("getCustomUserParameters", "()Ljava/util/SortedMap;", "GetGetCustomUserParametersHandler")]
			get {
				const string __id = "getCustomUserParameters.()Ljava/util/SortedMap;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='TrackingParameter']/method[@name='setCustomUserParameters' and count(parameter)=1 and parameter[1][@type='java.util.SortedMap&lt;java.lang.String, java.lang.String&gt;']]"
			[Register ("setCustomUserParameters", "(Ljava/util/SortedMap;)V", "GetSetCustomUserParameters_Ljava_util_SortedMap_Handler")]
			set {
				const string __id = "setCustomUserParameters.(Ljava/util/SortedMap;)V";
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

		static Delegate cb_getDefaultParameter;
#pragma warning disable 0169
		static Delegate GetGetDefaultParameterHandler ()
		{
			if (cb_getDefaultParameter == null)
				cb_getDefaultParameter = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDefaultParameter);
			return cb_getDefaultParameter;
		}

		static IntPtr n_GetDefaultParameter (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Webtrekk.Webtrekksdk.TrackingParameter __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.TrackingParameter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter, string>.ToLocalJniHandle (__this.DefaultParameter);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IDictionary<global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter, string> DefaultParameter {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='TrackingParameter']/method[@name='getDefaultParameter' and count(parameter)=0]"
			[Register ("getDefaultParameter", "()Ljava/util/SortedMap;", "GetGetDefaultParameterHandler")]
			get {
				const string __id = "getDefaultParameter.()Ljava/util/SortedMap;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaDictionary<global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter, string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getEcomParameter;
#pragma warning disable 0169
		static Delegate GetGetEcomParameterHandler ()
		{
			if (cb_getEcomParameter == null)
				cb_getEcomParameter = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEcomParameter);
			return cb_getEcomParameter;
		}

		static IntPtr n_GetEcomParameter (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Webtrekk.Webtrekksdk.TrackingParameter __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.TrackingParameter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (__this.EcomParameter);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IDictionary<string, string> EcomParameter {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='TrackingParameter']/method[@name='getEcomParameter' and count(parameter)=0]"
			[Register ("getEcomParameter", "()Ljava/util/SortedMap;", "GetGetEcomParameterHandler")]
			get {
				const string __id = "getEcomParameter.()Ljava/util/SortedMap;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getMediaCategories;
#pragma warning disable 0169
		static Delegate GetGetMediaCategoriesHandler ()
		{
			if (cb_getMediaCategories == null)
				cb_getMediaCategories = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMediaCategories);
			return cb_getMediaCategories;
		}

		static IntPtr n_GetMediaCategories (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Webtrekk.Webtrekksdk.TrackingParameter __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.TrackingParameter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (__this.MediaCategories);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IDictionary<string, string> MediaCategories {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='TrackingParameter']/method[@name='getMediaCategories' and count(parameter)=0]"
			[Register ("getMediaCategories", "()Ljava/util/SortedMap;", "GetGetMediaCategoriesHandler")]
			get {
				const string __id = "getMediaCategories.()Ljava/util/SortedMap;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getPageCategories;
#pragma warning disable 0169
		static Delegate GetGetPageCategoriesHandler ()
		{
			if (cb_getPageCategories == null)
				cb_getPageCategories = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPageCategories);
			return cb_getPageCategories;
		}

		static IntPtr n_GetPageCategories (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Webtrekk.Webtrekksdk.TrackingParameter __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.TrackingParameter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (__this.PageCategories);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IDictionary<string, string> PageCategories {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='TrackingParameter']/method[@name='getPageCategories' and count(parameter)=0]"
			[Register ("getPageCategories", "()Ljava/util/SortedMap;", "GetGetPageCategoriesHandler")]
			get {
				const string __id = "getPageCategories.()Ljava/util/SortedMap;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getPageParameter;
#pragma warning disable 0169
		static Delegate GetGetPageParameterHandler ()
		{
			if (cb_getPageParameter == null)
				cb_getPageParameter = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPageParameter);
			return cb_getPageParameter;
		}

		static IntPtr n_GetPageParameter (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Webtrekk.Webtrekksdk.TrackingParameter __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.TrackingParameter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (__this.PageParameter);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IDictionary<string, string> PageParameter {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='TrackingParameter']/method[@name='getPageParameter' and count(parameter)=0]"
			[Register ("getPageParameter", "()Ljava/util/SortedMap;", "GetGetPageParameterHandler")]
			get {
				const string __id = "getPageParameter.()Ljava/util/SortedMap;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getProductCategories;
#pragma warning disable 0169
		static Delegate GetGetProductCategoriesHandler ()
		{
			if (cb_getProductCategories == null)
				cb_getProductCategories = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetProductCategories);
			return cb_getProductCategories;
		}

		static IntPtr n_GetProductCategories (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Webtrekk.Webtrekksdk.TrackingParameter __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.TrackingParameter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (__this.ProductCategories);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IDictionary<string, string> ProductCategories {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='TrackingParameter']/method[@name='getProductCategories' and count(parameter)=0]"
			[Register ("getProductCategories", "()Ljava/util/SortedMap;", "GetGetProductCategoriesHandler")]
			get {
				const string __id = "getProductCategories.()Ljava/util/SortedMap;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSessionParameter;
#pragma warning disable 0169
		static Delegate GetGetSessionParameterHandler ()
		{
			if (cb_getSessionParameter == null)
				cb_getSessionParameter = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSessionParameter);
			return cb_getSessionParameter;
		}

		static IntPtr n_GetSessionParameter (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Webtrekk.Webtrekksdk.TrackingParameter __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.TrackingParameter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (__this.SessionParameter);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IDictionary<string, string> SessionParameter {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='TrackingParameter']/method[@name='getSessionParameter' and count(parameter)=0]"
			[Register ("getSessionParameter", "()Ljava/util/SortedMap;", "GetGetSessionParameterHandler")]
			get {
				const string __id = "getSessionParameter.()Ljava/util/SortedMap;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getUserCategories;
#pragma warning disable 0169
		static Delegate GetGetUserCategoriesHandler ()
		{
			if (cb_getUserCategories == null)
				cb_getUserCategories = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUserCategories);
			return cb_getUserCategories;
		}

		static IntPtr n_GetUserCategories (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Webtrekk.Webtrekksdk.TrackingParameter __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.TrackingParameter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (__this.UserCategories);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IDictionary<string, string> UserCategories {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='TrackingParameter']/method[@name='getUserCategories' and count(parameter)=0]"
			[Register ("getUserCategories", "()Ljava/util/SortedMap;", "GetGetUserCategoriesHandler")]
			get {
				const string __id = "getUserCategories.()Ljava/util/SortedMap;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_add_Lcom_webtrekk_webtrekksdk_TrackingParameter_;
#pragma warning disable 0169
		static Delegate GetAdd_Lcom_webtrekk_webtrekksdk_TrackingParameter_Handler ()
		{
			if (cb_add_Lcom_webtrekk_webtrekksdk_TrackingParameter_ == null)
				cb_add_Lcom_webtrekk_webtrekksdk_TrackingParameter_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Add_Lcom_webtrekk_webtrekksdk_TrackingParameter_);
			return cb_add_Lcom_webtrekk_webtrekksdk_TrackingParameter_;
		}

		static IntPtr n_Add_Lcom_webtrekk_webtrekksdk_TrackingParameter_ (IntPtr jnienv, IntPtr native__this, IntPtr native_tp)
		{
			global::Com.Webtrekk.Webtrekksdk.TrackingParameter __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.TrackingParameter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Webtrekk.Webtrekksdk.TrackingParameter tp = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.TrackingParameter> (native_tp, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Add (tp));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='TrackingParameter']/method[@name='add' and count(parameter)=1 and parameter[1][@type='com.webtrekk.webtrekksdk.TrackingParameter']]"
		[Register ("add", "(Lcom/webtrekk/webtrekksdk/TrackingParameter;)Lcom/webtrekk/webtrekksdk/TrackingParameter;", "GetAdd_Lcom_webtrekk_webtrekksdk_TrackingParameter_Handler")]
		public virtual unsafe global::Com.Webtrekk.Webtrekksdk.TrackingParameter Add (global::Com.Webtrekk.Webtrekksdk.TrackingParameter tp)
		{
			const string __id = "add.(Lcom/webtrekk/webtrekksdk/TrackingParameter;)Lcom/webtrekk/webtrekksdk/TrackingParameter;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((tp == null) ? IntPtr.Zero : ((global::Java.Lang.Object) tp).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.TrackingParameter> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_add_Lcom_webtrekk_webtrekksdk_TrackingParameter_Parameter_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAdd_Lcom_webtrekk_webtrekksdk_TrackingParameter_Parameter_Ljava_lang_String_Handler ()
		{
			if (cb_add_Lcom_webtrekk_webtrekksdk_TrackingParameter_Parameter_Ljava_lang_String_ == null)
				cb_add_Lcom_webtrekk_webtrekksdk_TrackingParameter_Parameter_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Add_Lcom_webtrekk_webtrekksdk_TrackingParameter_Parameter_Ljava_lang_String_);
			return cb_add_Lcom_webtrekk_webtrekksdk_TrackingParameter_Parameter_Ljava_lang_String_;
		}

		static IntPtr n_Add_Lcom_webtrekk_webtrekksdk_TrackingParameter_Parameter_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_key, IntPtr native_value)
		{
			global::Com.Webtrekk.Webtrekksdk.TrackingParameter __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.TrackingParameter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter key = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter> (native_key, JniHandleOwnership.DoNotTransfer);
			string value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Add (key, value));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='TrackingParameter']/method[@name='add' and count(parameter)=2 and parameter[1][@type='com.webtrekk.webtrekksdk.TrackingParameter.Parameter'] and parameter[2][@type='java.lang.String']]"
		[Register ("add", "(Lcom/webtrekk/webtrekksdk/TrackingParameter$Parameter;Ljava/lang/String;)Lcom/webtrekk/webtrekksdk/TrackingParameter;", "GetAdd_Lcom_webtrekk_webtrekksdk_TrackingParameter_Parameter_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Webtrekk.Webtrekksdk.TrackingParameter Add (global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter key, string value)
		{
			const string __id = "add.(Lcom/webtrekk/webtrekksdk/TrackingParameter$Parameter;Ljava/lang/String;)Lcom/webtrekk/webtrekksdk/TrackingParameter;";
			IntPtr native_value = JNIEnv.NewString (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((key == null) ? IntPtr.Zero : ((global::Java.Lang.Object) key).Handle);
				__args [1] = new JniArgumentValue (native_value);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.TrackingParameter> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_add_Lcom_webtrekk_webtrekksdk_TrackingParameter_Parameter_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAdd_Lcom_webtrekk_webtrekksdk_TrackingParameter_Parameter_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_add_Lcom_webtrekk_webtrekksdk_TrackingParameter_Parameter_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_add_Lcom_webtrekk_webtrekksdk_TrackingParameter_Parameter_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Add_Lcom_webtrekk_webtrekksdk_TrackingParameter_Parameter_Ljava_lang_String_Ljava_lang_String_);
			return cb_add_Lcom_webtrekk_webtrekksdk_TrackingParameter_Parameter_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_Add_Lcom_webtrekk_webtrekksdk_TrackingParameter_Parameter_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_key, IntPtr native_index, IntPtr native_value)
		{
			global::Com.Webtrekk.Webtrekksdk.TrackingParameter __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.TrackingParameter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter key = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter> (native_key, JniHandleOwnership.DoNotTransfer);
			string index = JNIEnv.GetString (native_index, JniHandleOwnership.DoNotTransfer);
			string value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Add (key, index, value));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='TrackingParameter']/method[@name='add' and count(parameter)=3 and parameter[1][@type='com.webtrekk.webtrekksdk.TrackingParameter.Parameter'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("add", "(Lcom/webtrekk/webtrekksdk/TrackingParameter$Parameter;Ljava/lang/String;Ljava/lang/String;)Lcom/webtrekk/webtrekksdk/TrackingParameter;", "GetAdd_Lcom_webtrekk_webtrekksdk_TrackingParameter_Parameter_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Webtrekk.Webtrekksdk.TrackingParameter Add (global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter key, string index, string value)
		{
			const string __id = "add.(Lcom/webtrekk/webtrekksdk/TrackingParameter$Parameter;Ljava/lang/String;Ljava/lang/String;)Lcom/webtrekk/webtrekksdk/TrackingParameter;";
			IntPtr native_index = JNIEnv.NewString (index);
			IntPtr native_value = JNIEnv.NewString (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((key == null) ? IntPtr.Zero : ((global::Java.Lang.Object) key).Handle);
				__args [1] = new JniArgumentValue (native_index);
				__args [2] = new JniArgumentValue (native_value);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.TrackingParameter> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_index);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_add_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetAdd_Ljava_util_Map_Handler ()
		{
			if (cb_add_Ljava_util_Map_ == null)
				cb_add_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Add_Ljava_util_Map_);
			return cb_add_Ljava_util_Map_;
		}

		static IntPtr n_Add_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_auto_tracked_values)
		{
			global::Com.Webtrekk.Webtrekksdk.TrackingParameter __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.TrackingParameter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var auto_tracked_values = global::Android.Runtime.JavaDictionary<global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter, string>.FromJniHandle (native_auto_tracked_values, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Add (auto_tracked_values));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='TrackingParameter']/method[@name='add' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;com.webtrekk.webtrekksdk.TrackingParameter.Parameter, java.lang.String&gt;']]"
		[Register ("add", "(Ljava/util/Map;)Lcom/webtrekk/webtrekksdk/TrackingParameter;", "GetAdd_Ljava_util_Map_Handler")]
		public virtual unsafe global::Com.Webtrekk.Webtrekksdk.TrackingParameter Add (global::System.Collections.Generic.IDictionary<global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter, string> auto_tracked_values)
		{
			const string __id = "add.(Ljava/util/Map;)Lcom/webtrekk/webtrekksdk/TrackingParameter;";
			IntPtr native_auto_tracked_values = global::Android.Runtime.JavaDictionary<global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter, string>.ToLocalJniHandle (auto_tracked_values);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_auto_tracked_values);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.TrackingParameter> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_auto_tracked_values);
			}
		}

		static Delegate cb_applyMapping_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetApplyMapping_Ljava_util_Map_Handler ()
		{
			if (cb_applyMapping_Ljava_util_Map_ == null)
				cb_applyMapping_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_ApplyMapping_Ljava_util_Map_);
			return cb_applyMapping_Ljava_util_Map_;
		}

		static IntPtr n_ApplyMapping_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_mappingValues)
		{
			global::Com.Webtrekk.Webtrekksdk.TrackingParameter __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.TrackingParameter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var mappingValues = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_mappingValues, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ApplyMapping (mappingValues));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='TrackingParameter']/method[@name='applyMapping' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("applyMapping", "(Ljava/util/Map;)Lcom/webtrekk/webtrekksdk/TrackingParameter;", "GetApplyMapping_Ljava_util_Map_Handler")]
		public virtual unsafe global::Com.Webtrekk.Webtrekksdk.TrackingParameter ApplyMapping (global::System.Collections.Generic.IDictionary<string, string> mappingValues)
		{
			const string __id = "applyMapping.(Ljava/util/Map;)Lcom/webtrekk/webtrekksdk/TrackingParameter;";
			IntPtr native_mappingValues = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (mappingValues);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_mappingValues);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.TrackingParameter> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_mappingValues);
			}
		}

		static Delegate cb_containsKey_Lcom_webtrekk_webtrekksdk_TrackingParameter_Parameter_;
#pragma warning disable 0169
		static Delegate GetContainsKey_Lcom_webtrekk_webtrekksdk_TrackingParameter_Parameter_Handler ()
		{
			if (cb_containsKey_Lcom_webtrekk_webtrekksdk_TrackingParameter_Parameter_ == null)
				cb_containsKey_Lcom_webtrekk_webtrekksdk_TrackingParameter_Parameter_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_ContainsKey_Lcom_webtrekk_webtrekksdk_TrackingParameter_Parameter_);
			return cb_containsKey_Lcom_webtrekk_webtrekksdk_TrackingParameter_Parameter_;
		}

		static bool n_ContainsKey_Lcom_webtrekk_webtrekksdk_TrackingParameter_Parameter_ (IntPtr jnienv, IntPtr native__this, IntPtr native_key)
		{
			global::Com.Webtrekk.Webtrekksdk.TrackingParameter __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.TrackingParameter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter key = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter> (native_key, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.ContainsKey (key);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='TrackingParameter']/method[@name='containsKey' and count(parameter)=1 and parameter[1][@type='com.webtrekk.webtrekksdk.TrackingParameter.Parameter']]"
		[Register ("containsKey", "(Lcom/webtrekk/webtrekksdk/TrackingParameter$Parameter;)Z", "GetContainsKey_Lcom_webtrekk_webtrekksdk_TrackingParameter_Parameter_Handler")]
		public virtual unsafe bool ContainsKey (global::Com.Webtrekk.Webtrekksdk.TrackingParameter.Parameter key)
		{
			const string __id = "containsKey.(Lcom/webtrekk/webtrekksdk/TrackingParameter$Parameter;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((key == null) ? IntPtr.Zero : ((global::Java.Lang.Object) key).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='TrackingParameter']/method[@name='createFromJson' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
		[Register ("createFromJson", "(Lorg/json/JSONObject;)Lcom/webtrekk/webtrekksdk/TrackingParameter;", "")]
		public static unsafe global::Com.Webtrekk.Webtrekksdk.TrackingParameter CreateFromJson (global::Org.Json.JSONObject @object)
		{
			const string __id = "createFromJson.(Lorg/json/JSONObject;)Lcom/webtrekk/webtrekksdk/TrackingParameter;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((@object == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @object).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.TrackingParameter> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_mergeProducts_Lcom_webtrekk_webtrekksdk_TrackingParameter_Lcom_webtrekk_webtrekksdk_TrackingParameter_Lcom_webtrekk_webtrekksdk_Configuration_TrackingConfiguration_;
#pragma warning disable 0169
		static Delegate GetMergeProducts_Lcom_webtrekk_webtrekksdk_TrackingParameter_Lcom_webtrekk_webtrekksdk_TrackingParameter_Lcom_webtrekk_webtrekksdk_Configuration_TrackingConfiguration_Handler ()
		{
			if (cb_mergeProducts_Lcom_webtrekk_webtrekksdk_TrackingParameter_Lcom_webtrekk_webtrekksdk_TrackingParameter_Lcom_webtrekk_webtrekksdk_Configuration_TrackingConfiguration_ == null)
				cb_mergeProducts_Lcom_webtrekk_webtrekksdk_TrackingParameter_Lcom_webtrekk_webtrekksdk_TrackingParameter_Lcom_webtrekk_webtrekksdk_Configuration_TrackingConfiguration_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_MergeProducts_Lcom_webtrekk_webtrekksdk_TrackingParameter_Lcom_webtrekk_webtrekksdk_TrackingParameter_Lcom_webtrekk_webtrekksdk_Configuration_TrackingConfiguration_);
			return cb_mergeProducts_Lcom_webtrekk_webtrekksdk_TrackingParameter_Lcom_webtrekk_webtrekksdk_TrackingParameter_Lcom_webtrekk_webtrekksdk_Configuration_TrackingConfiguration_;
		}

		static IntPtr n_MergeProducts_Lcom_webtrekk_webtrekksdk_TrackingParameter_Lcom_webtrekk_webtrekksdk_TrackingParameter_Lcom_webtrekk_webtrekksdk_Configuration_TrackingConfiguration_ (IntPtr jnienv, IntPtr native__this, IntPtr native_mergedFrom, IntPtr native_baseParameter, IntPtr native_configuration)
		{
			global::Com.Webtrekk.Webtrekksdk.TrackingParameter __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.TrackingParameter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Webtrekk.Webtrekksdk.TrackingParameter mergedFrom = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.TrackingParameter> (native_mergedFrom, JniHandleOwnership.DoNotTransfer);
			global::Com.Webtrekk.Webtrekksdk.TrackingParameter baseParameter = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.TrackingParameter> (native_baseParameter, JniHandleOwnership.DoNotTransfer);
			global::Com.Webtrekk.Webtrekksdk.Configuration.TrackingConfiguration configuration = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Configuration.TrackingConfiguration> (native_configuration, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.MergeProducts (mergedFrom, baseParameter, configuration));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='TrackingParameter']/method[@name='mergeProducts' and count(parameter)=3 and parameter[1][@type='com.webtrekk.webtrekksdk.TrackingParameter'] and parameter[2][@type='com.webtrekk.webtrekksdk.TrackingParameter'] and parameter[3][@type='com.webtrekk.webtrekksdk.Configuration.TrackingConfiguration']]"
		[Register ("mergeProducts", "(Lcom/webtrekk/webtrekksdk/TrackingParameter;Lcom/webtrekk/webtrekksdk/TrackingParameter;Lcom/webtrekk/webtrekksdk/Configuration/TrackingConfiguration;)Lcom/webtrekk/webtrekksdk/TrackingParameter;", "GetMergeProducts_Lcom_webtrekk_webtrekksdk_TrackingParameter_Lcom_webtrekk_webtrekksdk_TrackingParameter_Lcom_webtrekk_webtrekksdk_Configuration_TrackingConfiguration_Handler")]
		public virtual unsafe global::Com.Webtrekk.Webtrekksdk.TrackingParameter MergeProducts (global::Com.Webtrekk.Webtrekksdk.TrackingParameter mergedFrom, global::Com.Webtrekk.Webtrekksdk.TrackingParameter baseParameter, global::Com.Webtrekk.Webtrekksdk.Configuration.TrackingConfiguration configuration)
		{
			const string __id = "mergeProducts.(Lcom/webtrekk/webtrekksdk/TrackingParameter;Lcom/webtrekk/webtrekksdk/TrackingParameter;Lcom/webtrekk/webtrekksdk/Configuration/TrackingConfiguration;)Lcom/webtrekk/webtrekksdk/TrackingParameter;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((mergedFrom == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mergedFrom).Handle);
				__args [1] = new JniArgumentValue ((baseParameter == null) ? IntPtr.Zero : ((global::Java.Lang.Object) baseParameter).Handle);
				__args [2] = new JniArgumentValue ((configuration == null) ? IntPtr.Zero : ((global::Java.Lang.Object) configuration).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.TrackingParameter> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_saveToJson;
#pragma warning disable 0169
		static Delegate GetSaveToJsonHandler ()
		{
			if (cb_saveToJson == null)
				cb_saveToJson = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_SaveToJson);
			return cb_saveToJson;
		}

		static IntPtr n_SaveToJson (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Webtrekk.Webtrekksdk.TrackingParameter __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.TrackingParameter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SaveToJson ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='TrackingParameter']/method[@name='saveToJson' and count(parameter)=0]"
		[Register ("saveToJson", "()Lorg/json/JSONObject;", "GetSaveToJsonHandler")]
		public virtual unsafe global::Org.Json.JSONObject SaveToJson ()
		{
			const string __id = "saveToJson.()Lorg/json/JSONObject;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
